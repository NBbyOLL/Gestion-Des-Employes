CREATE TABLE employees (
    employee_id INT PRIMARY KEY IDENTITY(1,1),
    firstName VARCHAR(50) NOT NULL,
    lastName VARCHAR(50) NOT NULL,
    address VARCHAR(50),
    salary FLOAT CHECK (salary >= 0),
    dateBirth DATE NOT NULL,
    phoneNumber VARCHAR(15) CHECK (phoneNumber LIKE '[0-9]%')
);
