CREATE TABLE Books(
    Id INTEGER PRIMARY KEY,
    Nosaukums TEXT, 
    AuthorId INTEGER
);

INSERT INTO Books(Id, Nosaukums, AuthorId)
VALUES(1, PirmaGramata, 1);

INSERT INTO Books(Id, Nosaukums, AuthorId)
VALUES(2, OtraGramata, 2);

INSERT INTO Books(Id, Nosaukums, AuthorId)
VALUES(3, TresaGramata, 3);