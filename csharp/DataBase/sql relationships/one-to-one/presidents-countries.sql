create table countries(
	id int generated always as identity primary key,
	name varchar(30),
	pupulation int
);

create table presidents(
	id int generated always as identity primary key,
	full_name varchar(30),
	age int,
	country_id int references countries(id)
);
