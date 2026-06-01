CREATE TABLE Employees (
	employee_id INT PRIMARY KEY,
	name VARCHAR(100),
	department VARCHAR(50),
	hire_date DATE
);

CREATE TABLE Payroll (
	payroll_id INT PRIMARY KEY,
	employee_id INT,
	pay_date DATE,
	gross_salary DECIMAL(10, 2),
	tax_amount DECIMAL(10, 2),
	net_salary DECIMAL(10, 2),
	FOREIGN KEY (employee_id) REFERENCES Employees(employee_id)
);