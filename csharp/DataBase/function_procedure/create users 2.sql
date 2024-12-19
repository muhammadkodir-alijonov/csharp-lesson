create table users(
	id int generated always as identity primary key,
	full_name varchar(50) not null,
	card_number varchar(19),
	balance real
);

select * from users

call transfer_balance('8600 1223 3434 2323','8600 3434 3987 9432', 11000);

