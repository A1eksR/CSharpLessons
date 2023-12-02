CREATE TABLE emplyee(
    id INTEGER PRIMARY KEY,
    first_name TEXT(255),
    last_name TEXT(255)
);

CREATE TABLE customer(
    id INTEGER PRIMARY KEY,
    customer_name TEXT(255),
    customer_addres TEXT(255),
    next_call_date TEXT NOT NULL,
    ts_inserted TEXT(255)
);

CREATE TABLE call(
    id INTEGER PRIMARY KEY,
    employee_id INTEGER,
    customer_id INTEGER,
    start_time TEXT NOT NULL,
    end_time TEXT(255),
    FOREIGN KEY (employee_id) REFERENCES customer(id),
    FOREIGN KEY (customer_id) REFERENCES employee(id)
);

INSERT INTO employee(id, first_name, last_name)
VALUES(1, "Andris", "Berzins");

INSERT INTO customer(id, customer_name, customer_addres, next_call_date, ts_inserted)
VALUES(1, "Janis", "Brivibas iela", "septembris", "Nezinu ko tas nozime");

INSERT INTO call(id, employee_id, customer_id, start_time, end_time)
VALUES(1, 1, 1, "Pirmdiena", "Otrdiena"); 

SELECT employee.last_name, call.start_time, call.end_time
FROM employee, call
WHERE emplyee.id = call.employee_id;

SELECT customer.customer_name, customer.customer_addres, call.start_time, call.ent_time
FROM customer, call
WHERE customer.id = call.customer_id;
