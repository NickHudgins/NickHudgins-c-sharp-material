USE [master]
GO

DROP DATABASE IF EXISTS ProjectManager
GO

CREATE DATABASE ProjectManager;
GO

USE ProjectManager
GO
BEGIN TRANSACTION
CREATE TABLE Employee 
(
employee_number int NOT NULL,
job_title nvarchar(60) NOT NULL,
last_name nvarchar(60) NOT NULL,
first_name nvarchar(60) NOT NULL,
gender nvarchar(60),
date_of_birth nvarchar(60) NOT NULL,
department_name nvarchar(60) NOT NULL,
department_id int NOT NULL
);

CREATE TABLE Department
(
department_id int NOT NULL,
department_name nvarchar (60) NOT NULL,
number_of_employees nvarchar (60) NOT NULL,
);

CREATE TABLE Project
(
    project_id int NOT NULL,
    name nvarchar(60) NOT NULL,
    project_start nvarchar(60) NOT NULL,
    number_of_employees nvarchar(60) NOT NULL,
	);

	ALTER TABLE Employee
ADD PRIMARY KEY (employee_number);

	ALTER TABLE Department
ADD PRIMARY KEY (department_id);

	ALTER TABLE Project
ADD PRIMARY KEY (project_id);

INSERT INTO Employee(employee_number, job_title, last_name, first_name, gender, date_of_birth, department_name, department_id) 
VALUES('1', 'Office Manager', 'Lumbergh', 'Bill', 'M', '1956-07-28', 'TPS Reporting', 04);
INSERT INTO Employee(employee_number, job_title, last_name, first_name, gender, date_of_birth, department_name, department_id) 
VALUES ('2', 'TPS Writer', 'Bolton', 'Michael', 'M', '1986-06-05', 'TPS Reporting', 04);
INSERT INTO Employee(employee_number, job_title, last_name, first_name, gender, date_of_birth, department_name, department_id) 
VALUES ('3', 'Copyist', 'Gibbons', 'Peter', 'M', '1976-11-12', 'Copy Machine Hater', 99)
INSERT INTO Employee(employee_number, job_title, last_name, first_name, gender, date_of_birth, department_name, department_id) 
VALUES ('4', 'Stapler Enthusiast', 'Waddams', 'Milton', 'M', '1999-04-19', 'Stapler Collection', 19)
INSERT INTO Employee(employee_number, job_title, last_name, first_name, gender, date_of_birth, department_name, department_id) 
VALUES ('5', 'Copyist', 'Nagheenanajar', 'Samir', 'M', '1981-03-14', 'Copy Machine Hater', 99)
INSERT INTO Employee(employee_number, job_title, last_name, first_name, gender, date_of_birth, department_name, department_id) 
VALUES ('6', 'TPS Writer', 'Slydell', 'Bob', 'M', '1956-08-17', 'TPS Reporting', 04)
INSERT INTO Employee(employee_number, job_title, last_name, first_name, gender, date_of_birth, department_name, department_id) 
VALUES ('7', 'Stapler Enthusiast', 'Smykowski', 'Tom', 'M', '1999-04-19', 'Stapler Collection', 19)
INSERT INTO Employee(employee_number, job_title, last_name, first_name, gender, date_of_birth, department_name,department_id) 
VALUES ('8', 'TPS Writer', 'Portwood', 'Dom', 'M', '1956-01-01', 'TPS Reporting', 04)

INSERT INTO Department(department_id, department_name, number_of_employees)
VALUES (04, 'TPS Reporting', 4)
INSERT INTO Department(department_id, department_name, number_of_employees)
VALUES (19, 'Stapler Collection', 2)
INSERT INTO Department(department_id, department_name, number_of_employees)
VALUES (99, 'Copy Machine Hater', 2)

INSERT INTO Project(project_id, name, project_start, number_of_employees)
VALUES (7098, 'The Allen Parsons Project', 1975-05-25, 3)
INSERT INTO Project(project_id, name, project_start, number_of_employees)
VALUES (6780, 'Project Runway', 2004-12-01, 2)
INSERT INTO Project(project_id, name, project_start, number_of_employees)
VALUES (7098, 'The Blair Witch Project', 1999-07-16, 3)

ALTER TABLE Employee
ADD FOREIGN KEY (department_id) REFERENCES Department(department_id);
COMMIT