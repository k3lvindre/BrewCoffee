SELECT
	name
FROM 
	employees, payroll 
WHERE 
	employees.employee_id = payroll.employee_id
	AND
	DATE_PART('year',pay_date) NOT IN('2024')