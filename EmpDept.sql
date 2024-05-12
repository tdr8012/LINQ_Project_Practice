CREATE DATABASE EmpDept

CREATE TABLE Departments (
    DeptId INT NOT NULL,
    Name VARCHAR(50) NOT NULL,
    PRIMARY KEY (DeptId)
);

CREATE TABLE Employees (
    EmpId INT NOT NULL,
    Name VARCHAR(50) NOT NULL,
    Salary DECIMAL(10,2) NOT NULL,
    DeptId INT NOT NULL,
    PRIMARY KEY (EmpId),
    FOREIGN KEY (DeptId) REFERENCES Departments(DeptId)
      ON DELETE NO ACTION
      ON UPDATE CASCADE
);

INSERT INTO Departments (DeptId, Name) VALUES (1, 'Marketing');
INSERT INTO Departments (DeptId, Name) VALUES (2, 'Accounting');
INSERT INTO Departments (DeptId, Name) VALUES (3, 'Finance');
INSERT INTO Departments (DeptId, Name) VALUES (4, 'IT');


INSERT INTO Employees (EmpId, Name, Salary, DeptId) VALUES (1, 'Mary', 90000.00, 3);
INSERT INTO Employees (EmpId, Name, Salary, DeptId) VALUES (3, 'John', 90000.00, 1);
INSERT INTO Employees (EmpId, Name, Salary, DeptId) VALUES (7, 'Brian', 80000.00, 2);
INSERT INTO Employees (EmpId, Name, Salary, DeptId) VALUES (14, 'Anne', 95000.00, 4);
INSERT INTO Employees (EmpId, Name, Salary, DeptId) VALUES (32, 'James', 85000.00, 1);
