create table categories(
	id int generated always as identity primary key,
	name varchar(50)
);

create table products(
	id int generated always as identity primary key,
	name varchar(50) not null unique,
	info text,
	image_link text,
	price real not null,
	catigory_id int references categories(id)	
);

create table employees(
	id int generated always as identity primary key,
	full_name varchar(50) not null,
	phone_number varchar(13) not null,
	email varchar(50) not null unique,
	is_male bool default true,
	salary double precision not null,
	i_position text,
	created_at timestamp not null,
	schedule varchar(50),
	birth_date date,
	passport_image_path text
);

create table users(
	id int generated always as identity primary key,
	full_name varchar(50) not null,
	phone_number varchar(13) not null,
	email varchar(50) not null unique,
	password_hash text,
	is_admin bool default false,
	created_at timestamp not null default now()
);

create table orders(
 	id int generated always as identity primary key,
	employee_id int references employees(id),
	i_location point not null,
	user_id int references users(id),
	total_sum real,
	deliver_id int references employees(id),
	status varchar(30) default 'pending',
	patment_type varchar(10) default 'by_cash',
	created_at timestamp not null default now(),
	delivered_at timestamp
);

create table order_details(
	id int generated always as identity primary key,
	order_id int references orders(id),
	product_id int references products(id),
	quantity int
);













