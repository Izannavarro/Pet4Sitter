CREATE DATABASE if NOT exists pet4sitter;
USE pet4sitter;
CREATE TABLE users(
id INT AUTO_INCREMENT PRIMARY KEY,
username VARCHAR(40) NOT NULL,
usermail VARCHAR(40) NOT NULL,
userpassword VARCHAR(255),
google_id VARCHAR(255) UNIQUE
);

--   "sub": "112352489022344879962",
--   "name": "DAM",
--   "given_name": "DAM",
--   "picture": "https://lh3.googleusercontent.com/a/ACg8ocL11Sva-DpNzVj_B6JT27rYjimR_mmoc-OyVlU00M9U\u003ds96-c",
--   "locale": "en"