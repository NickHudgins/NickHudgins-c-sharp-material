-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)
SELECT actor.first_name, actor.last_name, film.title
FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON actor.actor_id = film_actor.actor_id
WHERE first_name = 'Nick'
AND last_name = 'Stallone'

-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)
SELECT actor.first_name, actor.last_name, film.title
FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON actor.actor_id = film_actor.actor_id
WHERE first_name = 'Rita'
AND last_name = 'Reynolds'

-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)
SELECT actor.first_name, actor.last_name, film.title
FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON actor.actor_id = film_actor.actor_id
WHERE first_name = 'River'
AND last_name = 'Dean'
OR first_name = 'Judy'
AND last_name = 'Dean'

-- 4. All of the the ‘Documentary’ films
-- (68 rows)
SELECT *
FROM film 
JOIN film_category ON film.film_id = film_category.film_id
JOIN category ON category.category_id = film_category.category_id
WHERE name = 'Documentary'

-- 5. All of the ‘Comedy’ films
-- (58 rows)
SELECT *
FROM film 
JOIN film_category ON film.film_id = film_category.film_id
JOIN category ON category.category_id = film_category.category_id
WHERE name = 'Comedy'

-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)
SELECT *
FROM film 
JOIN film_category ON film.film_id = film_category.film_id
JOIN category ON category.category_id = film_category.category_id
WHERE name = 'Children'
AND rating = 'G'

-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)
SELECT *
FROM film 
JOIN film_category ON film.film_id = film_category.film_id
JOIN category ON category.category_id = film_category.category_id
WHERE name = 'Family'
AND rating = 'G'
AND length < 120

-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)
SELECT actor.first_name [First Name], actor.last_name [Last Name], film.title [Title], film.rating [Rating]
FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON actor.actor_id = film_actor.actor_id
WHERE first_name = 'Matthew'
AND last_name = 'Leigh'
AND rating = 'G'

-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)
SELECT *
FROM film 
JOIN film_category ON film.film_id = film_category.film_id
JOIN category ON category.category_id = film_category.category_id
WHERE name = 'Sci-Fi'
AND release_year = '2006'

-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)
SELECT actor.first_name, actor.last_name, film.title
FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON actor.actor_id = film_actor.actor_id
JOIN film_category ON film.film_id = film_category.film_id
JOIN category ON category.category_id = film_category.category_id
WHERE first_name = 'Nick'
AND last_name = 'Stallone'
AND name = 'Action'


-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)
SELECT address, city, district, country
FROM store
JOIN address ON store.address_id = store.store_id
JOIN city ON city.city_id = address.city_id
JOIN country ON country.country_id = city.country_id


-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)
SELECT address, store.store_id, first_name, last_name
FROM store
JOIN address ON store.address_id = store.store_id
JOIN city ON city.city_id = address.city_id
JOIN country ON country.country_id = city.country_id
JOIN staff ON staff.staff_id = staff.store_id


-- 13. The first and last name of the top ten customers ranked by number of rentals 
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)
SELECT TOP 10 c.first_name + ' ' + c.last_name AS [Customer Name], COUNT(r.rental_date) AS [Number of Rentals]
FROM rental r
JOIN customer c ON r.customer_id = c.customer_id
GROUP BY c.first_name + ' ' + c.last_name
ORDER BY [Number of Rentals] DESC 



-- 14. The first and last name of the top ten customers ranked by dollars spent 
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)
SELECT TOP 10 c.first_name + ' ' + c.last_name AS [Customer Name], SUM(p.amount) AS [Amount Spent]
FROM rental r
JOIN customer c ON r.customer_id = c.customer_id
JOIN payment p ON p.customer_id = r.customer_id
GROUP BY c.first_name + ' ' + c.last_name
ORDER BY [Amount Spent] DESC 


-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store 
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)
SELECT store.store_id AS [Store ID], address.address, COUNT(rental.return_date) AS [Total Rentals], SUM(amount) AS [Total Sales], AVG(amount) AS [Average Sale]
FROM store
JOIN address ON address.address_id = store.address_id
JOIN customer ON customer.address_id = address.address_id
JOIN rental ON rental.customer_id = customer.customer_id
JOIN payment ON payment.rental_id = rental.rental_id
GROUP BY store.store_id, address.address
ORDER BY [Total Rentals], [Total Sales], [Average Sale]


-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)
SELECT TOP 10(title) AS [Film Title], COUNT(rental_date) AS [Number of Rentals]
FROM film
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON rental.inventory_id = inventory.film_id
GROUP BY title
ORDER BY [Number of Rentals] DESC


-- 17. The top five film categories by number of rentals 
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)
SELECT TOP 5(name) AS [Film Category], COUNT(rental_date) AS [Number of Rentals]
FROM category
JOIN film_category ON film_category.category_id = category.category_id
JOIN film ON film.film_id = film_category.film_id
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
GROUP BY name
ORDER BY [Number of Rentals] DESC

-- 18. The top five Action film titles by number of rentals 
-- (#1 should have 30 rentals and #5 should have 28 rentals)
SELECT TOP 5(Title) AS [Film Name], COUNT(rental_date) AS [Number of Rentals]
FROM category
JOIN film_category ON film_category.category_id = category.category_id
JOIN film ON film.film_id = film_category.film_id
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
WHERE film_category.category_id = '1'
GROUP BY title
ORDER BY [Number of Rentals] DESC


-- 19. The top 10 actors ranked by number of rentals of films starring that actor 
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)
SELECT TOP 10 actor.first_name + ' ' + actor.last_name AS [Actor], COUNT(rental_date) AS [Number of Rentals]
FROM actor
JOIN film_actor ON film_actor.actor_id = actor.actor_id
JOIN film ON film.film_id = film_actor.film_id
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
GROUP BY actor.first_name + ' ' + actor.last_name
ORDER BY [Number of Rentals] DESC

-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor 
-- (#1 should have 87 rentals and #5 should have 72 rentals)
SELECT TOP 5 actor.first_name + ' ' + actor.last_name AS [Actor], COUNT(rental_date) AS [Number of Rentals]
FROM actor
JOIN film_actor ON film_actor.actor_id = actor.actor_id
JOIN film ON film.film_id = film_actor.film_id
JOIN film_category ON film_category.film_id = film.film_id
JOIN category ON category.category_id = film_category.category_id
JOIN inventory ON inventory.film_id = film.film_id
JOIN rental ON rental.inventory_id = inventory.inventory_id
GROUP BY actor.first_name + ' ' + actor.last_name
WHERE film_category.category_id = '5'
ORDER BY [Number of Rentals] DESC

--This one made my brain hurt. Turning in assignment, will submit for regrade.

select*
from category
