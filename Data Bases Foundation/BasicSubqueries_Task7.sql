SELECT dept_name,COUNT(*) AS num_of_empl FROM departments
JOIN employees using(dept_id)
GROUP BY dept_name
HAVING COUNT(*) > (SELECT COUNT(*) FROM employees JOIN departments USING(dept_id) WHERE dept_name = 'ADMINISTRATION')