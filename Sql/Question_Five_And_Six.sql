-- Question 5:
-- I will add non clustered index to pay_date column since it is the column being filtered.

-- Question 6:
-- SELECT * FROM Payroll WHERE YEAR(pay_date) = 2024;
-- This is inefficient because it will get all the columns then will get all the data from 2024 
-- and that could take a lot of time if data were large.
-- Instead , i will write this query as follows:
SELECT
	pay_date, 
	net_salary 
FROM 
	Payroll 
WHERE 
	YEAR(pay_date) = 2024
LIMIT 10;