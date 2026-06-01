SELECT
	department,
	name,
	SUM(net_salary) AS total_net_salary
FROM 
	employees, payroll 
WHERE 
	employees.employee_id = payroll.employee_id
	AND
	DATE_PART('year',pay_date) = '2024'
GROUP BY
	name, department
ORDER BY total_net_salary DESC 
LIMIT 3