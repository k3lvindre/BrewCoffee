INSERT INTO 
	Employees (employee_id, name, department, hire_date)
VALUES
	(1, Alice Smith, Finance, 2020-03-15),
	(2, Bob Johnson, IT, 2019-07-01),
	(3, Charlie Brown, HR, 2021-01-10),
	(4, Diana Prince, Finance, 2018-11-20),
	(5, Ethan Hunt, Operations, 2022-06-05);

INSERT INTO 
	Payroll (payroll_id, employee_id, pay_date, gross_salary, tax_amount, net_salary) 
VALUES
	(101, 1, 2024-01-31, 5000.00, 1000.00, 4000.00),
	(102, 1, 2024-02-29, 5000.00, 1000.00, 4000.00),
	(103, 2, 2024-01-31, 4500.00, 900.00, 3600.00),
	(104, 3, 2024-01-31, 4000.00, 800.00, 3200.00),
	(105, 4, 2024-01-31, 6000.00, 1200.00, 4800.00),
	(106, 4, 2024-02-29, 6000.00, 1200.00, 4800.00),
	(107, 5, 2024-01-31, 3500.00, 700.00, 2800.00),
	(108, 2, 2024-02-29, 4500.00, 900.00, 3600.00),
	(109, 3, 2024-02-29, 4000.00, 800.00, 3200.00);