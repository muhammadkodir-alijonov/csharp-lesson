create table userss(
	id int generated always as identity primary key,
	full_name varchar(30),
	birth_date date,
	phone_number varchar(13)
		check(phone_number ~ '^[+9989]{4}[0-9]{9}$')	
);

create table chats(
	id int generated always as identity primary key,
	chat_name varchar(30),
	created_at date,
	i_info text
);

create table users_chat(
	id int generated always as identity primary key,
	user_id int references userss(id),
	chat_id int references chats(id)
);














