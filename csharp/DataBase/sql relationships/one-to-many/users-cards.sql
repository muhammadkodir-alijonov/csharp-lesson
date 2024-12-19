create table users(
	id int generated always as identity primary key,
	full_name varchar(30),
	birth_date date,
	phone_number varchar(13)
);

create table cards(
	id int generated always as identity primary key,
	card_name varchar(29),
	card_created_date date,
	card_end_date date,
	card_number varchar(16),
	user_id int references users(id)
);














