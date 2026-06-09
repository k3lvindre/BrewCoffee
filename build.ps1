$base_dir = resolve-path .\
$source_dir = "$base_dir"
$build_dir = "$base_dir\build"
$test_dir = "$build_dir\UnitTests"
$unitTestProjectPath = "$source_dir\BrewCoffee.UnitTests"
$projectName = "BrewCoffee"


# rd is an alias for Remove-Item (remove directory / files). In your script it removes the build folder and its contents because of -Recurse -Force.
# md is an alias for New-Item (mkdir). In your script it creates the build folder; the redirection (> $null) discards the output.
# -ErrorAction SilentlyContinue (or Ignore) prevents errors when the folder does not exist.

Function Init {
    rd $build_dir -recurse -force  -ErrorAction Ignore
	md $build_dir > $null

	& dotnet clean $source_dir\$projectName.sln -nologo -v m
	
	& dotnet restore $source_dir\$projectName.sln -nologo --interactive -v m

    Write-Host $projectConfig
    Write-Host $version
}

Function Compile{
	& dotnet build $source_dir\$projectName.sln -nologo --no-restore -v m -maxcpucount --configuration release --no-incremental
}

Function UnitTests{
	Push-Location -Path $unitTestProjectPath

	try {
		& dotnet test -nologo -v m --logger:trx `
		--results-directory $test_dir --no-build `
		--no-restore --configuration release `
		--collect:"Code Coverage" 
	}
	finally {
		Pop-Location
	}
}

# For future use, we can automate the database migration or setup here.
# especially for setting up new dev env or for new developer
Function MigrateDatabaseLocal {
	Write-Host "Starting LocalDB"
	sqllocaldb start mssqllocaldb

	exec{
		& $aliaSql $databaseAction $databaseServer $databaseName $databaseScripts
	}
}

Function PrivateBuild{
	$sw = [Diagnostics.Stopwatch]::StartNew()
	Init
	Compile
	UnitTests
	$sw.Stop()
	write-host "Build time: " $sw.Elapsed.ToString()
}