-- INSERT

-- 1. Add Klingon as a spoken language in the USA
SELECT *
FROM countrylanguage;

INSERT INTO countrylanguage
(countrycode,language,isofficial,percentage)
VALUES('USA', 'Klingon', 0, 1.0)

-- 2. Add Klingon as a spoken language in Great Britain
SELECT *
FROM countrylanguage;

INSERT INTO countrylanguage
(countrycode,language,isofficial,percentage)
VALUES('GBR', 'Klingon', 0, 1.0)

-- UPDATE

-- 1. Update the capital of the USA to Houston
SELECT *
FROM country

SELECT *
FROM city 
WHERE name LIKE 'Hou%'


UPDATE country 
SET capital = 3796                      --running this as is will set every capital to 3796
WHERE code = 'USA'                      -- this will specify that it is only in USA  that you want to make this change

-- 2. Update the capital of the USA to Washington DC and the head of state
UPDATE country 
SET capital = 3813, headofstate = 'Donny Drumpf'                      
WHERE code = 'USA' 

-- DELETE

-- 1. Delete English as a spoken language in the USA
SELECT *
FROM countrylanguage
WHERE countrycode = 'USA' AND language = 'ENGLISH'

DELETE
FROM countrylanguage
WHERE countrycode = 'USA' AND language = 'ENGLISH'

SELECT *
FROM countrylanguage
WHERE countrycode = 'USA'

-- 2. Delete all occurrences of the Klingon language 
DELETE
FROM countrylanguage
WHERE language = 'Klingon'

-- REFERENTIAL INTEGRITY

-- 1. Try just adding Elvish to the country language table.
INSERT INTO countrylanguage
(language, countrycode, isofficial, percentage)
VALUES ('Elvish', 'ZZZ', 0, 0.1)

-- 2. Try inserting English as a spoken language in the country ZZZ. What happens?
INSERT INTO countrylanguage
(language, countrycode, isofficial, percentage)
VALUES ('Elvish', 'ZZZ', 0, 0.1)

-- 3. Try deleting the country USA. What happens?
SELECT *
FROM country
WHERE code = 'USA'

DELETE
FROM country
WHERE code = 'USA'

-- CONSTRAINTS

-- 1. Try inserting English as a spoken language in the USA
INSERT INTO countrylanguage
(countrycode,language,isofficial,percentage)
VALUES ('USA', 'ENGLISH', 0, 87.0)

-- 2. Try again. What happens?
INSERT INTO countrylanguage                    --Msg 2627, Level 14, State 1, Line 88
                                               --Violation of PRIMARY KEY constraint 'pk_countrylanguage_countrycode_language'. Cannot insert duplicate key in object 'dbo.countrylanguage'. The duplicate key value is (USA, ENGLISH).
                                               --The statement has been terminated.

(countrycode,language,isofficial,percentage)
VALUES ('USA', 'ENGLISH', 0, 87.0)
-- 3. Let's relocate the USA to the continent - 'Outer Space'
SELECT *
FROM country
WHERE code = 'USA'

UPDATE country
SET continent = 'Outer Space'
WHERE code = 'USA'


-- How to view all of the constraints

SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS


-- TRANSACTIONS

-- 1. Try deleting all of the rows from the country language table and roll it back.
BEGIN TRANSACTION;

DELETE
FROM countrylanguage;

ROLLBACK;



-- 2. Try updating all of the cities to be in the USA and roll it back

-- 3. Demonstrate two different SQL connections trying to access the same table where one happens to be inside of a transaction but hasn't committed yet.