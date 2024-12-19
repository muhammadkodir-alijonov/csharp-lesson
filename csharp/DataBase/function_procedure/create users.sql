create table users(
	id int generated always as identity primary key,
	full_name varchar(50) not null,
	card_number varchar(19),
	balance real
);