--1
SELECT employees.name AS name,
       employees.surname AS Surname,
       COALESCE(departments.dept_name,' ') AS department,
       COALESCE(departments.address, ' ') AS address
FROM employees LEFT OUTER JOIN departments
    ON employees.dept_id = departments.dept_id
ORDER BY surname
--2
SELECT employees.name AS name,
       employees.surname AS Surname,
       COALESCE(departments.dept_name,'no department') AS department,
       COALESCE(departments.address, 'no department') AS address
FROM employees LEFT OUTER JOIN departments
    ON employees.dept_id = departments.dept_id
ORDER BY surname
--3
SELECT COALESCE(employees.name,'no employee') AS name,
       COALESCE(employees.surname,'no employee') AS Surname,
       COALESCE(departments.dept_name,'no department') AS department,
       COALESCE(departments.address, 'no department') AS address
FROM employees FULL OUTER JOIN departments
    ON employees.dept_id = departments.dept_id
ORDER BY surname
--4
SELECT departments.dept_name AS department,
       COUNT(employees.name) AS employees_at_dept,
       COALESCE(SUM(employees.salary), 0) AS salaries_at_dept
FROM departments LEFT OUTER JOIN employees
ON departments.dept_id = employees.dept_id
GROUP BY department
ORDER BY department
--5
SELECT e.surname AS employee, 
       COALESCE(b.surname,'no boss') AS boss
FROM employees e LEFT OUTER JOIN employees b
ON e.boss_id = b.emp_id
ORDER BY employee;
--6
SELECT e.surname AS employee, 
       COALESCE(b.surname,'no boss') AS boss
FROM employees e LEFT OUTER JOIN employees b
ON e.boss_id = b.emp_id
WHERE b.surname LIKE '%Wilson%' OR b.surname LIKE '%Smith%' OR e.boss_id IS NULL
ORDER BY employee;
--7
SELECT e.surname AS employee,
       12*e.salary+COALESCE(e.add_salary,0) AS emp_annual_salary,
       12*b.salary+COALESCE(b.add_salary,0) -
       12*e.salary+COALESCE(e.add_salary,0) AS less_than_boss
FROM employees e INNER JOIN employees b
           ON e.boss_id = b.emp_id
GROUP BY e.surname,e.salary,e.add_salary,b.salary,b.add_salary
ORDER BY e.surname




SELECT e.surname AS employee,
       (12*e.salary+COALESCE(e.add_salary,0)) AS emp_annual_salary,
       (12*b.salary+COALESCE(b.add_salary,0)) -
       (12*e.salary+COALESCE(e.add_salary,0)) AS less_than_boss
FROM employees e INNER JOIN employees b
           ON e.boss_id = b.emp_id
ORDER BY e.surname
--8
SELECT b.surname AS boss,
       COUNT(e.emp_id) AS subordinates
FROM employees e FULL OUTER JOIN employees b
ON b.emp_id = e.boss_id
WHERE b.surname IS NOT NULL
GROUP BY b.surname
ORDER BY b.surname
--9
SELECT e.name || ' ' || e.surname AS employee,d.dept_name AS employee_department,b.name || ' ' || b.surname AS boss,
f.dept_name AS boss_department
FROM employees e LEFT OUTER JOIN departments d USING(dept_id)
INNER JOIN employees b ON e.boss_id = b.emp_id
INNER JOIN departments f ON b.dept_id = f.dept_id
WHERE e.name IS NOT NULL AND d.dept_name IS NOT NULL
ORDER BY employee
--10
SELECT e.name || ' ' || e.surname AS employee,
COALESCE(d.dept_name,'no department') AS employee_department,
COALESCE(b.name || ' ' ||b.surname,'no boss') AS boss,
COALESCE(f.dept_name,'no department') AS boss_department
FROM employees e LEFT JOIN departments d USING(dept_id)
LEFT JOIN employees b ON e.boss_id = b.emp_id
LEFT JOIN departments f ON b.dept_id = f.dept_id
WHERE e.name IS NOT NULL
ORDER BY employee
--11
SELECT COUNT(*) AS rows_of_cartesian_product
FROM employees CROSS JOIN departments CROSS JOIN jobs
