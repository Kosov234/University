--1
/*
SELECT surname,emp_id,UPPER(SUBSTRING(surname,1,2)) || emp_id AS login
 FROM employees
 ORDER BY surname;*/
--2
/*
SELECT surname
FROM employees
WHERE surname LIKE '%L%' OR surname LIKE '%l%';
*/
--3
/*
SELECT surname
FROM employees
WHERE SUBSTRING(surname,1,(LENGTH(surname)/2)) LIKE '%L%' OR SUBSTRING(surname,1,LENGTH(surname)/2) LIKE '%l%'
ORDER BY surname;
*/
--4
/*
SELECT surname,salary AS original_salary,ROUND(salary*1.15) AS increased_salary
FROM employees
ORDER BY surname;
*/
--5
/*
SELECT TO_CHAR(CURRENT_DATE,'Day') AS Today_is;
*/
--6
/*SELECT TO_CHAR(TO_DATE('25.11.1998','DD.MM.YYYY'),'Day') AS I_was_born_on;*/
--7
/*SELECT surname,TO_CHAR(hire_date, 'FMDD FMMonth YYYY,') || TO_CHAR(hire_date,'Day') AS hire_date
FROM employees
ORDER BY surname;
*/
--8
/*
SELECT surname,job,AGE(TO_DATE('01.01.2000','DD.MM.YYYY'),hire_date) AS experience_in_2000
FROM employees
WHERE (job = 'PROFESSOR') or (job = 'ASSISTANT') or (job = 'LECTURER')
ORDER BY hire_date,surname;
*/
--9
/*
SELECT surname,job,AGE(TO_DATE('01.01.2000','DD.MM.YYYY'),hire_date) AS experience_in_2000
FROM employees
WHERE ((job = 'PROFESSOR') or (job = 'ASSISTANT') or (job = 'LECTURER'))
AND AGE(TO_DATE('01.01.2000','DD.MM.YYYY'),hire_date) > INTERVAL '10-0'
ORDER BY hire_date,surname;
*/
--10
/*
SELECT surname,job,SUBSTRING(CAST(AGE(TO_DATE('01.01.2000','DD.MM.YYYY'),hire_date) AS text),1,2) AS experience_in_2000
FROM employees
WHERE ((job = 'PROFESSOR') or (job = 'ASSISTANT') or (job = 'LECTURER'))
AND AGE(TO_DATE('01.01.2000','DD.MM.YYYY'),hire_date) > INTERVAL '10-0'
ORDER BY hire_date,surname;
*/