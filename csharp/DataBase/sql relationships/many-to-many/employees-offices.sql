create table employees(
	id int generated always as identity primary key,
	full_name varchar(30),
	birth_date date,
	phone_number varchar(13)
		check(phone_number ~ '^[+9989]{4}[0-9]{9}$'),
	possion text	
);

create table offices(
	id int generated always as identity primary key,
	office_name varchar(30),
	created_at date,
	employee_number int
);

create table employee_office(
	id int generated always as identity primary key,
	employee_id int references employees(id),
	office_id int references offices(id)
);














