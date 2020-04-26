--1
/*SELECT employees.name AS name,
       employees.surname AS Surname,
       departments.dept_name AS department,
       departments.address AS address
FROM employees INNER JOIN departments
    ON employees.dept_id = departments.dept_id
ORDER BY surname*/
--2
/*SELECT 'Employee ' || employees.name || ' ' || employees.surname || ' works in ' ||
 departments.dept_name || ' located at ' || departments.address
FROM employees INNER JOIN departments
    ON employees.dept_id = departments.dept_id
ORDER BY surname*/
--3
/*SELECT employees.surname AS surname,employees.salary AS salary
FROM employees INNER JOIN departments
ON employees.dept_id = departments.dept_id
WHERE departments.address = '47TH STR'
ORDER BY surname*/
--4
/*SELECT COUNT(*) AS employees_at_47th_street,ROUND(AVG(salary),2) AS avg_salary
FROM employees INNER JOIN departments
ON employees.dept_id = departments.dept_id
WHERE departments.address = '47TH STR'*/
--5
/*SELECT employees.surname AS surname,
       employees.name AS name,
       employees.salary AS salary,
       jobs.min_salary AS job_min_salary,
       jobs.max_salary AS job_max_salary
FROM employees INNER JOIN jobs
ON employees.job = jobs.name
ORDER BY surname*/
--6
/*SELECT employees.surname AS surname,
       employees.name AS name,
       employees.salary AS salary,
       jobs.min_salary AS job_min_salary,
       jobs.max_salary AS job_max_salary
FROM employees INNER JOIN jobs
ON employees.job = jobs.name
WHERE employees.salary < jobs.min_salary OR employees.salary > jobs.max_salary 
ORDER BY surname*/
--7
/*SELECT employees.surname AS surname,
       employees.name AS name,
       employees.salary AS salary,
       (SELECT jobs.min_salary FROM jobs WHERE jobs.name LIKE 'ASSISTANT') AS job_min_salary,
       (SELECT jobs.max_salary FROM jobs WHERE jobs.name LIKE 'ASSISTANT') AS job_max_salary
FROM employees INNER JOIN jobs
ON employees.salary
BETWEEN (SELECT jobs.min_salary FROM jobs WHERE jobs.name = 'ASSISTANT')
AND (SELECT jobs.max_salary FROM jobs WHERE jobs.name = 'ASSISTANT')
GROUP BY employees.name,employees.surname,employees.salary
ORDER BY surname*/
--8
/*SELECT departments.dept_name as department,
	COUNT(*) AS employees_at_dept,
	SUM(salary) AS salaries_at_dept
FROM departments INNER JOIN employees USING (dept_id)
GROUP BY department
ORDER BY department*/
--9
/*SELECT departments.dept_name as department,
	COUNT(*) AS employees_at_dept,
	SUM(salary) AS salaries_at_dept
FROM departments INNER JOIN employees
ON employees.dept_id = departments.dept_id
GROUP BY department
HAVING COUNT(*) > 1
ORDER BY department*/
--10
/*SELECT departments.dept_name as department,
	CASE
		WHEN COUNT(*) <=2 THEN 'small'
		WHEN COUNT(*) >=3 AND COUNT(*) <=6 THEN 'medium'
		WHEN COUNT(*) >=7 THEN 'big'
	END AS label
FROM departments INNER JOIN employees USING (dept_id)
GROUP BY department
ORDER BY department*/