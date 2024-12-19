create table videoes(
	id int generated always as identity primary key,
	name varchar(50),
	quality varchar(20),
	created_date date,
	info text
);

create table comments(
	id int generated always as identity primary key,
	comment_name varchar(100),
	created_date date,
	info_aboout_a_comment varchar(50)
		check (info_aboout_a_comment in ('bad','cool','norm')),
	video_id int references videoes(id)
);





















