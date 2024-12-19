create table teachers(
	id int generated always as identity primary key,
	full_name varchar(30),
	age int,
	profession varchar(30),
	started_at_work date
);

create table subjects(
	id int generated always as identity primary key,
	name varchar(30),
	info text,
	s_room int,
	teacher_id int references teachers(id)
);




















