CREATE TABLE users (
    id INT PRIMARY KEY IDENTITY,
    username VARCHAR(255) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL
);

insert into users (username, password) values ('admin', 'admin');