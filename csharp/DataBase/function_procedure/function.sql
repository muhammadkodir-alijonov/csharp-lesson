create or replace function upgrate_salary(persentage real)
returns double precision
language plpgsql
as
$$
	declare
	total_sum double precision;
	unit_persantage_balance real;
	itr record;
begin 
	total_sum:=0;
	for itr in (select id,salary from employees ) loop
	unit_persantage_balance:= itr.salary*persentage /100;
	update employees set salary = salary + unit_persantage_balance
	where id = itr.id;
	total_sum:= total_sum + unit_persantage_balance;
	end loop;
	return total_sum;
end;
$$

