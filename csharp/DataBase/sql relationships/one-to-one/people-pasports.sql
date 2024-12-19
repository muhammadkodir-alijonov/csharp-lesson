create table pasports(
	id int generated always as identity primary key,
	seria varchar(6),
	s_number int,
	place varchar(30),
	iib varchar(30),
	i_date date
);

create table people(
	id int generated always as identity primary key,
	full_name varchar(30),
	age int,
	pasport_id int references pasports(id)
);

