--1
/*SELECT surname,salary,
	CASE 
		WHEN salary<1500 THEN 'low paid'
		WHEN salary>1500 AND salary<3000 THEN 'average paid'
		WHEN salary>3000 THEN 'well paid'
	END AS label
FROM employees
ORDER BY surname;*/
--2
/*SELECT DISTINCT boss_id 
FROM employees
WHERE boss_id IS NOT NULL
ORDER BY boss_id;*/
--3
/*SELECT DISTINCT dept_id, job
FROM employees
WHERE dept_id IS NOT NULL
ORDER BY dept_id, job;*/
--4
/*SELECT DISTINCT
SUBSTRING(CAST(hire_date AS text),1,4) AS years
FROM employees
ORDER BY years*/
--5
/*SELECT dept_id FROM departments
EXCEPT ALL
SELECT dept_id FROM employees*/
--6
/*SELECT surname,salary,'low paid' AS label FROM employees WHERE salary<1500
UNION
SELECT surname,salary,'average paid' AS label FROM employees WHERE salary>1500 AND salary<3000
UNION
SELECT surname,salary,'well paid' AS label FROM employees WHERE salary>3000
ORDER BY surname;*/