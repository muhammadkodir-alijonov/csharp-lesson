create or replace procedure transfer_balance(sender_card_number varchar(19), 
									         receiver_card_number varchar(19),
											 transfer_balance real
											)
language plpgsql
as 
$$
declare
	sender_balanc real;
	first_account int;
	last_account int;
begin
	--Pul yuboruvchi account egasi uchun tekshiruv
	first_account = (select id from users where card_number = sender_card_number);
	if(first_account is null) then raise exception 'Sender account is not found';
	end if;
	--Pul qabul qiliuvchi account egasi uchun tekshiruv
	last_account = (select id from users where card_number = receiver_card_number);
	if(last_account is null) then raise exception 'Reciever account is not found';
	end if;
	--Pul yechib olish uchun avval yetarli ekanini tekshirish
	sender_balanc:=(select balance from users where card_number = sender_card_number);
	if(sender_balanc < transfer_balance) then
	raise exception 'mablag yetarli emas';
	else 
	--Pul birinchi kartadan olindi
	update users set balance = balance - transfer_balance 
	where card_number = sender_card_number;
	--Pul ikkinchi accountga yuorildi
	update users set balance = balance + transfer_balance 
	where card_number = receiver_card_number;
	end if;
end;
$$
