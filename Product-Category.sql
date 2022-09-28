CREATE TABLE products(id int primary key not null, name varchar(50) not null, catId int, FOREIGN KEY(catId) REFERENCES categories(id)); 
CREATE TABLE categories(id int primary key not null, name varchar(50) not null)

INSERT INTO products(id, name, catId) VALUES(1, 'prod1', 2);
INSERT INTO products(id, name) VALUES(2, 'prod2');
INSERT INTO products(id, name, catId) VALUES(3, 'prod3', 1);
INSERT INTO products(id, name) VALUES(4, 'prod4');

INSERT INTO categories(id, name) VALUES(1, 'cat1');
INSERT INTO categories(id, name) VALUES(2, 'cat2')

SELECT p.name as "Product", c.name as "Catetgories" FROM products p LEFT JOIN categories c ON p.catId = c.id
