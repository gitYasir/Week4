DROP TABLE IF EXISTS Spartans;

CREATE TABLE Spartans
(
	[id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [title] NCHAR(10) NOT NULL, 
    [firstname] VARCHAR(50) NOT NULL, 
    [lastname] VARCHAR(50) NOT NULL, 
    [univerity_attended] VARCHAR(100) NULL, 
    [course_taken] VARCHAR(50) NULL, 
    [mark_achieved] NCHAR(10) NULL, 
    [city] VARCHAR(50) NOT NULL, 
    [country] VARCHAR(50) NOT NULL
)

INSERT INTO Spartans (
title, firstname, lastname, univerity_attended, 
course_taken, mark_achieved, city, country
) 
VALUES (
'Mr','Yasir','Ibrahim','Wuhan University', 'Medicine', '80', 'Birmingham', 'UK'
),(
'Dr', 'John', 'Dolittle', 'Animal Medicine University' , 'Veterinary Medicine', '99', 'London', 'UK'
);


SELECT *
FROM Spartans;


