Questions
Section 1: Query Writing (40%)
1. List the top 3 employees by total net salary paid in 2024 (include name, department,
total_net_salary).
2. Show each department with total gross salary, total tax deducted, and average net
salary.

Section 2: Joins  Subqueries (30%)
3. List all employees who have not received any payroll in 2024.
4. Return each employee’s most recent pay date and net salary.

Section 3: Performance  Optimization (20%)
5. Which columns would you index in Payroll to optimize queries filtering by pay_date
and aggregating by employee_id? Why?
6. Explain why this query might be inefficient and provide an optimized alternative:
SELECT * FROM Payroll WHERE YEAR(pay_date) = 2024;

Section 4: Bonus (10%)
7. Rank employees by total net salary within their department using a window function.