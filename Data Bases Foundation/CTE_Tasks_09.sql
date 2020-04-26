--1
WITH
	more_than_avg(job, avg_sal_for_job) AS
		(SELECT job, ROUND(AVG(salary),2) FROM employees GROUP BY job)
	SELECT surname, job, salary, avg_sal_for_job
	FROM employees e RIGHT JOIN more_than_avg av USING(job)
	WHERE salary>avg_sal_for_job
	ORDER BY surname;
--2
WITH
	sum_pays_in_dept(dept_name, sum_of_sal) AS
		(SELECT dept_name, SUM(salary) as sum_sal
			FROM employees JOIN departments USING(dept_id)
			GROUP BY dept_name
			ORDER BY sum_sal DESC
			FETCH FIRST 1 ROWS ONLY)
	SELECT dept_name, sum_of_sal
		FROM sum_pays_in_dept;
--3
WITH
	boss_salaries(emp_name, emp_salary, boss_name, boss_salary) AS
		(SELECT e1.surname, e1.salary, e2.surname, e2.salary
			FROM employees e1 JOIN employees e2
				ON e1.boss_id = e2.emp_id)
		SELECT emp_name, emp_salary, boss_name, boss_salary
			FROM boss_salaries
			WHERE emp_salary >= boss_salary * 0.6
		ORDER BY emp_name;
--4
SELECT surname, hire_date
FRoM employees
FETCH FIRST 1 ROWS only;
--5
WITH
most_old_employee(old_emp_days) AS
(SELECT hire_date 
FROM employees 
FETCH FIRST 1 ROWS only)
SELECT surname, hire_date - old_emp_days AS num_of_days
FROM employees CROSS JOIN most_old_employee
ORDER BY num_of_days;
--6
WITH
numbers(num_to_word,emp_id) AS
(SELECT CASE
 		WHEN ROUND(salary/1000) = 1 THEN 'one'
 		WHEN ROUND(salary/1000) = 2 THEN 'two'
 		WHEN ROUND(salary/1000) = 3 THEN 'three'
 		WHEN ROUND(salary/1000) = 4 THEN 'four'
 		WHEN ROUND(salary/1000) = 5 THEN 'five'
 		ELSE 'No data' END, emp_id
	FROM employees)
SELECT surname ||' earns '|| num_to_word ||' grand.' as Sentence
FROM employees JOIN numbers USING(emp_id)
ORDER BY surname;