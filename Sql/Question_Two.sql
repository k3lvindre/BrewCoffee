SELECT  
	department, 
	SUM(net_salary) total_net_salary,
	SUM(tax_amount) total_tax_deducted
FROM 
	employees e, payroll p
WHERE 
	e.employee_id = p.employee_id
GROUP BY 
	department