--1
-- CREATE TABLE Projects(
-- 	project_id INTEGER GENERATED ALWAYS AS IDENTITY,
-- 	project_name CHARACTER VARYING(200),
-- 	description CHARACTER VARYING(1000),
-- 	start_date DATE DEFAULT CURRENT_DATE,
-- 	end_date DATE,
-- 	budget NUMERIC(10,2));
--2
-- INSERT INTO Projects(project_name,description,start_date,budget)
-- VALUES('New Technologies Survey','A project aimed at reviewing the area
-- of advanced database technologies.',DATE '2018-01-01',1500000);

-- INSERT INTO Projects(project_name,description,start_date,end_date,budget)
-- VALUES('Advanced Data Analysis','Analyzing data obtained from various
-- organizations.',DATE '2017-09-20',DATE '2018-10-01',2750000)

-- SELECT * FROM Projects;
--3
-- INSERT INTO Projects(project_id,project_name,description,start_date,end_date,budget)
-- VALUES(55,'Creating backbone network','Expanding the organizations network
-- infrastructure.',DATE '2019-06-01',DATE '2020-05-31',5000000)
-- I did not succeed because of the fact that 'project_id' field is set as GENERATED ALWAYS AS IDENTITY.
--4
-- INSERT INTO Projects(project_name,description,start_date,end_date,budget)
-- VALUES('Creating backbone network','Expanding the organizations network
-- infrastructure.',DATE '2019-06-01',DATE '2020-05-31',5000000);

-- SELECT * FROM Projects;
--5
-- UPDATE Projects
-- SET project_id = 100
-- WHERE project_name = 'Creating backbone network'
-- I did not succeed because of the fact that 'project_id' field is set as GENERATED ALWAYS AS IDENTITY.
--6
-- CREATE TABLE Projects_Copy AS
-- SELECT * FROM Projects;

-- SELECT * FROM Projects_Copy;
--7
-- INSERT INTO Projects_Copy(project_id,project_name,description,start_date,end_date,budget)
-- VALUES(55,'Creating backbone network','Expanding the organizations network
-- infrastructure - part 2.',DATE '2019-06-01',DATE '2020-05-31',4000000);

-- SELECT * FROM Projects_Copy;

-- It works because there is no restrictions for "project_id" field in Projects_Copy table.
-- The contents were just copied.
--8
-- DELETE FROM Projects_Copy
-- WHERE  project_name = 'Creating backbone network';

-- SELECT * FROM Projects;
-- Project still exists in 'Projects' table.
