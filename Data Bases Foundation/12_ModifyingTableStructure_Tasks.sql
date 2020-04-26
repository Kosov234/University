--1
-- ALTER TABLE Projects
-- 	ADD COLUMN number_of_emp NUMERIC(3),
-- 	ALTER COLUMN description SET DATA TYPE character varying(1500);
	
-- SELECT * FROM Projects;

--2
-- SELECT MAX(LENGTH(project_name)) FROM Projects;

-- ALTER TABLE Projects
-- 	ALTER COLUMN project_name SET DATA TYPE character varying(24);
	
-- I was unable to set the data type of 'project_name' column to string with shorter length.

--3
-- ALTER TABLE Projects
--  RENAME COLUMN budget TO project_budget;
 
-- SELECT * FROM Projects;

--4
-- DROP TABLE Projects_Copy;