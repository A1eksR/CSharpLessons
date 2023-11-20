CREATE TABLE Person(
    PersonId integer,
    Name text(20),
    LastNAME text(20)
);

INSERT INTO Person(PersonId, Name, LastName)
VALUES(1, "Janis", "Berzins");

INSERT INTO Person(PersonId, Name, LastName)
VALUES(2, "Janis", "Berzins");

SELECT * FROM Person; 
SELECT Name, LastName FROM Person;

SELECT Name, LastName
FROM Person
WHERE PersonId = 1;