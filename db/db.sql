CREATE DATABASE IF NOT EXISTS pet4sitter CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

USE pet4sitter;

CREATE TABLE IF NOT EXISTS users (
    id_user INT AUTO_INCREMENT,
    id_google VARCHAR(255) UNIQUE,
    name VARCHAR(30) CHARACTER SET utf8mb4 NOT NULL,
    surname VARCHAR(60) CHARACTER SET utf8mb4,
    email VARCHAR(60) CHARACTER SET utf8mb4 NOT NULL unique,
    dni VARCHAR(9) CHARACTER SET utf8mb4,
    password VARCHAR(255) CHARACTER SET utf8mb4 NOT NULL,
    price DOUBLE,
    location VARCHAR(50) CHARACTER SET utf8mb4,
    premium TINYINT DEFAULT 0,
    sitter TINYINT DEFAULT 0,
    admin TINYINT DEFAULT 0,
    image longblob default null,
    latitud float,
    longitud float,
    PRIMARY KEY (id_user)
) CHARACTER SET utf8mb4;

CREATE TABLE IF NOT EXISTS products (
    id_product INT AUTO_INCREMENT PRIMARY KEY,
    name varchar(30) NOT NULL,
    price DOUBLE NOT NULL,	
    quantity INT NOT NULL,
    description VARCHAR(99) CHARACTER SET utf8mb4,
    image LONGBLOB NOT NULL
) CHARACTER SET utf8mb4;

CREATE TABLE IF NOT EXISTS chat (
    id int auto_increment primary key,
    id_receiver INT NOT NULL,
    id_sender INT NOT NULL,
    `date` DATETIME DEFAULT NOW() NOT NULL,
    messages VARCHAR(255) CHARACTER SET utf8mb4 NOT NULL,
    FOREIGN KEY (id_receiver) REFERENCES users(id_user) on delete cascade,
    FOREIGN KEY (id_sender) REFERENCES users(id_user)on delete cascade
) CHARACTER SET utf8mb4;

CREATE TABLE IF NOT EXISTS delivery (
    id_delivery int auto_increment primary key,
    id_receiver INT NOT NULL,
    delivery_date DATETIME not null,
    direction VARCHAR(200) NOT NULL,
    FOREIGN KEY (id_receiver) REFERENCES users(id_user)on delete cascade
) CHARACTER SET utf8mb4;
CREATE TABLE IF NOT EXISTS delivery_products (
    id_delivery INT NOT NULL,
    id_product INT NOT NULL,
    PRIMARY KEY (id_delivery, id_product),
    FOREIGN KEY (id_delivery) REFERENCES delivery(id_delivery)on delete cascade,
    FOREIGN KEY (id_product) REFERENCES products(id_product)on delete cascade
) CHARACTER SET utf8mb4;

CREATE TABLE if NOT EXISTS tokens(
id_token INT auto_increment PRIMARY KEY,
token_name VARCHAR(50) NOT NULL,
token_value VARCHAR(255) NOT NULL);

CREATE TABLE IF NOT EXISTS `user_logs` (
  `id_log` int NOT NULL AUTO_INCREMENT,
  `id_user` int,
  `action` varchar(50) NOT NULL,
  `action_date` datetime DEFAULT CURRENT_TIMESTAMP,
  `details` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_log`),
  KEY `id_user` (`id_user`),
  CONSTRAINT `user_logs_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `users` (`id_user`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=UTF8MB4;
