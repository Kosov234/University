--1
-- INSERT INTO employees (emp_id,surname,name,job,boss_id,hire_date,salary,add_salary,dept_id)
-- VALUES(300,'Jack','Snow','PROFESSOR',100,'2013-05-01',4750,NULL,30),
-- 	  (310,'Robin','Cook','PROFESSOR',100,'2016-09-15',3500,1250,40),
-- 	  (320,'Francis','Dormand','ASSISTANT',110,'2018-01-01',3900,NULL,40);
	  
-- SELECT * FROM employees
--2
-- INSERT INTO departments
-- VALUES(70,'DATABASE SYSTEMS');

-- SELECT * FROM DEPARTMENTS
-- WHERE dept_name = 'DATABASE SYSTEMS'
--3
-- UPDATE employees
-- SET dept_id = 70
-- WHERE emp_id >= 300;

-- SELECT * FROM employees
-- WHERE emp_id >= 300
-- 4
-- Update employees
-- Set salary = salary * 1.1,
-- add_salary = (Case
-- when add_salary is null then 100
-- else add_salary*1.2
-- end)
-- where dept_id=70;

-- Select surname, name, salary, add_salary from employees
-- where dept_id = (Select dept_id
-- from departments
-- where dept_name = 'DATABASE SYSTEMS')
-- order by surname;
--5
-- DELETE FROM departments
-- WHERE dept_name = 'DATABASE SYSTEMS'

--We cannot delete DATABASE SYSTEMS department because there are still employees working in it

--6

-- DELETE FROM employees 
-- WHERE salary < 5000 AND dept_id = 70;

-- UPDATE employees
-- SET dept_id = NULL
-- WHERE dept_id = (SELECT dept_id from departments WHERE dept_name LIKE 'DATABASE SYSTEMS');

-- SELECT * FROM employees

--7
-- DELETE FROM departments
-- WHERE dept_name = 'DATABASE SYSTEMS';

-- SELECT * FROM departments

--8
-- 	WITH
-- 		avg_salary(dept_id, raise) AS (SELECT dept_id, AVG(salary) FROM employees GROUP BY dept_id)
-- SELECT surname, salary,
-- Round(CASE
-- 	  WHEN employees.dept_id is null then 0
-- 	  ELSE raise*0.1
-- 	  END,2)
-- AS raise FROM employees
-- LEFT JOIN avg_salary ON(avg_salary.dept_id = employees.dept_id)
-- ORDER BY surname;
--9
-- 	With 
-- 		avg_salary(dept_id, raise) AS (SELECT dept_id, AVG(salary) FROM employees GROUP BY dept_id)
-- UPDATE employees e
-- SET salary =
-- CASE
-- WHEN dept_id IS null THEN salary
-- ELSE salary + (SELECT raise * 0.1 FROM avg_salary av_sal WHERE e.dept_id = av_sal.dept_id)
-- END;

-- Select surname,salary from employees order by surname;
--10
-- DELETE FROM employees
-- WHERE name = 'Jack' AND surname = 'Snow';

-- SELECT * FROM employees


--Reset employees default salaries
-- Update employees
-- SET salary = 4750,
--     add_salary = NULL
-- WHERE emp_id = 300;

-- Update employees
-- SET salary = 3500,
--     add_salary = 1250
-- WHERE emp_id = 310;

-- Update employees
-- SET salary = 3900,
--     add_salary = NULL
-- WHERE emp_id = 320;