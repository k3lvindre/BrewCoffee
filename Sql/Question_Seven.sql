WITH TempSalaryRankingTable AS (
    SELECT 
        e.name,
        e.department, 
        ROW_NUMBER() OVER (PARTITION BY department ORDER BY SUM(p.net_salary) DESC) as salary_rank 
    FROM employees e
    INNER JOIN payroll p ON e.employee_id = p.employee_id 
    GROUP BY e.name, e.department 
)
SELECT 
    name,
    department, 
    salary_rank
FROM TempSalaryRankingTable