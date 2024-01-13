CREATE TABLE Authors(
    AuthorId PRIMARY KEY,
    Vards TEXT,
    Uzvards TEXT
);

INSERT INTO Authors(AuthorId, Vards, Uzvards)
VALUES(1, 'Janis', 'Abolins'),
      (2, 'Jekabs', 'Berzins');


CREATE TABLE Books(
    Id INTEGER PRIMARY KEY,
    AuthorId INTEGER REFERENCES Authors(AuthorId),
    Nosaukums TEXT 
);

INSERT INTO Books(Id, Nosaukums, AuthorId)
VALUES(1, 'PirmaGramata', 1),
      (2, 'OtraGramata', 2);




