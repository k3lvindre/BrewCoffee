SELECT 
	DISTINCT ON(employee_id) employee_id, 
	pay_date,
	net_salary 
FROM
(
	SELECT
		e.employee_id,
		pay_date,
		net_salary
	FROM 
		employees e, payroll p
	WHERE 
		e.employee_id = p.employee_id
	ORDER BY pay_date DESC 
)