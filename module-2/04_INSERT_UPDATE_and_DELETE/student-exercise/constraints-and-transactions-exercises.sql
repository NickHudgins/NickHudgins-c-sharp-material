-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
BEGIN TRANSACTION
INSERT INTO actor (first_name, last_name)
VALUES ('Hampton', 'Avenue')
INSERT INTO actor (first_name, last_name)
VALUES ('Lisa', 'Byway')
COMMIT;
-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.
BEGIN TRANSACTION
INSERT INTO film (title, description, release_year, language_id, length)
VALUES ('Euclidean PI', 'The epic story of Euclid as a pizza delivery boy in
-- ancient Greece', 2008, 1, 198)
COMMIT;

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
BEGIN TRANSACTION
INSERT INTO film_actor (actor_id, film_id)
VALUES  (201, 1001)
INSERT INTO film_actor (actor_id, film_id)
VALUES  (202, 1001)
COMMIT;


SELECT *
FROM actor
WHERE last_name = 'Byway'


-- 4. Add Mathmagical to the category table.
BEGIN TRANSACTION 
INSERT INTO category (name)
VALUES ('Mathmagical')
COMMIT;

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"
BEGIN TRANSACTION
UPDATE film_category
SET category_id = 17
WHERE film_id IN (1001, 274, 494, 714, 996)
INSERT INTO film_category(film_id, category_id)
VALUES (1001, 17)
COMMIT;

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)

BEGIN TRANSACTION 
UPDATE film
SET rating = 'G'
WHERE film_id IN (1001, 274, 494, 714, 996)
COMMIT;

-- 7. Add a copy of "Euclidean PI" to all the stores.
BEGIN TRANSACTION
INSERT INTO inventory (film_id, store_id)
VALUES (1001, 1)
INSERT INTO inventory (film_id, store_id)
VALUES (1001, 2)
COMMIT;

SELECT *
FROM inventory

-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
-- <It did not succeed because the film is tied into other tables.>
DELETE
FROM film
WHERE film_id = 1001

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- <Similar to the last delete test, this category ID >
DELETE
FROM category
WHERE category_id = 17

-- 10. Delete all links to Mathmagical in the film_category table.
-- (Did it succeed? Why?)
-- <It succeeded due to the category_id being a FK that linked it to category, allowing us to delete all instances of the "MATHMAGICAL" category>
DELETE
FROM film_category
WHERE category_id = 17



-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
-- <You can delete tje "mathmagical" category from the category table due to it only existing there. But since the Euclidian PI movie still exists in other tables, it will not allow you to delete it.>
DELETE
FROM category
WHERE category_id = 17
DELETE
FROM film
where film_id = 1001

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.
--<<WOULD NEED TO JOIN ACTOR, FILM_ACTOR, FILM, INVENTORY, FILM_CATEGORY AND CATEGORY TO DELETE THE FILM FROM THE DATABASE>> 

SELECT *
FROM film
WHERE film_id = 1001