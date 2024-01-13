CREATE TABLE Books(
    Id INTEGER PRIMARY KEY,
    AuthorId INTEGER REFERENCES Authors(AuthorId),
    Nosaukums TEXT 
);

INSERT INTO Books(Id, Nosaukums, AuthorId)
VALUES(1, PirmaGramata, 1);

INSERT INTO Books(Id, Nosaukums, AuthorId)
VALUES(2, OtraGramata, 2);


CREATE TABLE Authors(
    AuthorId PRIMARY KEY,
    Vards TEXT,
    Uzvards TEXT,
    Id INTEGER REFERENCES Books(Id)
);

INSERT INTO Authors(AuthorId, Vards, Uzvards, Id)
VALUES(1, 'Janis', 'Abolins', 1);

INSERT INTO Authors(AuthorId, Vards, Uzvards, Id)
VALUES(2, 'Jekabs', 'Berzins', 2)

