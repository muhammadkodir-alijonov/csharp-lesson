create table students(
	id int generated always as identity primary key,
	full_name varchar(30),
	age int,
	fill_out_at date,
	phone_number varchar(13) unique
		check (phone_number ~ '^[+9989]{4}[0-9]{9$}')
);

create table courses(
	id int generated always as identity primary key,
	course_name varchar(30),
	i_info text,
	student_id int references students(id)
);























