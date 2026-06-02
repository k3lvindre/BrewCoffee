# this file is needed to be able to run PrivateBuild function inside build.ps1
# •	The leading dot (.) with space in . .build.ps1  executes the script in the current scope instead of a child scope.
# •	That means any functions, variables or aliases defined in build.ps1 remain available after the script finishes for this script to use.
# •	In your PrivateBuild.ps1 you dot‑source build.ps1 so the PrivateBuild function (and Init/Compile) become defined in the current session and can be called on the next line.

. .\build.ps1

PrivateBuild