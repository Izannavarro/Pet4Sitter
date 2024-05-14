CREATE DATABASE if NOT exists pet4sitter; 

USE pet4sitter;

CREATE TABLE IF NOT EXISTS users(
id_user INT AUTO_INCREMENT,
nàme VARCHAR(30) NOT NULL, 
surname VARCHAR(60),
email VARCHAR(60) NOT NULL, 
dni VARCHAR(9),
pàssword VARCHAR(30) NOT NULL,
maxpets INT,
price DOUBLE,
location VARCHAR(50),
premium TINYINT,
sitter TINYINT,
PRIMARY KEY (id)
);
CREATE TABLE if NOT EXISTS reviews(
id_review INT AUTO_INCREMENT PRIMARY KEY,
valoration INT NOT NULL, 
id_reviewed INT NOT NULL,
id_reviewer INT NOT NULL
);

CREATE TABLE if NOT EXISTS products (
id_product INT AUTO_INCREMENT PRIMARY KEY,
price DOUBLE NOT NULL,
quantity INT NOT NULL,   
dèscription VARCHAR(99)
);

CREATE TABLE if NOT EXISTS chat(
id_chat INT AUTO_INCREMENT PRIMARY KEY,
id_reciever INT NOT NULL,
id_sender INT NOT NULL,
messages VARCHAR NOT NULL
);