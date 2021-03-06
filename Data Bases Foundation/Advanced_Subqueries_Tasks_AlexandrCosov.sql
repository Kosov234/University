--1
-- SELECT dept_id,dept_name,address
-- FROM departments d
-- WHERE NOT EXISTS
-- (SELECT 1 FROM employees e
-- WHERE e.dept_id = d.dept_id)
-- ORDER BY dept_name;
--2
-- SELECT surname,job,salary
-- FROM employees e1
-- WHERE salary >
-- (SELECT AVG(salary) FROM employees e2
-- WHERE e1.job = e2.job)
-- ORDER BY surname;
--3
-- SELECT surname,job,salary,
-- (SELECT ROUND(AVG(salary),2) FROM employees e3 WHERE e1.job = e3.job) AS avg_sal_for_job
-- FROM employees e1
-- WHERE salary >
-- (SELECT AVG(salary) FROM employees e2
-- WHERE e1.job = e2.job)
-- ORDER BY surname;
--4
-- SELECT surname,job,salary
-- FROM employees e
-- WHERE salary >=
-- ((SELECT salary FROM employees b WHERE b.emp_id = e.boss_id)/100)*60
-- ORDER BY surname
--5
-- SELECT MAX(dept_sum) AS max_sum
-- FROM (SELECT dept_id, SUM(salary) AS dept_sum
-- FROM employees
-- GROUP BY dept_id) test;
--6
-- SELECT dept_name, SUM(salary) AS sum_of_sal
-- FROM employees JOIN departments USING (dept_id) 
-- GROUP BY dept_name
-- HAVING SUM(salary) = 
-- (SELECT MAX(dept_sum) AS max_sum
-- FROM (SELECT dept_id, SUM(salary) AS dept_sum 
--    FROM employees
-- 	  GROUP BY dept_id) dept_sum_alias);
--7
-- SELECT surname, salary
-- FROM employees e1
-- WHERE salary = (SELECT MAX(salary) FROM employees e2 WHERE e1.dept_id = e2.dept_id)
-- ORDER BY salary DESC FETCH FIRST 3 ROWS ONLY;