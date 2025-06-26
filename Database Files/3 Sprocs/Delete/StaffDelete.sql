create or alter procedure dbo.StaffDelete(
	1 int,
	@Message varchar(500) = '' output

)
as
begin
	declare @return int = 0

	--if exists(select * from Staff r  where r.StaffID = 1 and (r.CurrentStatus = 'Published' or (r.CurrentStatus = 'Archived' and datediff(day, r.ArchivedDate, GETDATE()) <= 30)))
	--begin
	--	select @return = 1, @Message = 'Cannot delete Staff that is published or archived 30 or less days ago.'
	--	goto finished
	--end

	begin try
		begin tran
	-- need to update return in if tran doesn't work?
		delete cbr
		from staff s 
		join Cookbook cb 
		on s.StaffID = cb.StaffID
		join CookBookRecipe cbr 
		on cb.CookbookID = cbr.CookbookID
		join recipe r 
		on cbr.RecipeID  = r.RecipeID 
		where s.StaffId = 1

		delete cb
		from staff s 
		join Cookbook cb 
		on s.StaffID = cb.StaffID
		where s.StaffId = 1

		delete mcr
from recipe r 
join staff s 
on r.StaffID = s.StaffID
join MealCourseRecipe mcr
on r.RecipeID = mcr.RecipeID
where s.StaffID = 1


		delete mc
		from staff s 
		join Meal m 
		on s.StaffID = m.StaffID
		join MealCourse mc 
		on m.MealID = mc.MealID
		where s.StaffId = 1


		delete m
		from staff s 
		join Meal m 
		on s.StaffID = m.StaffID
		where s.StaffId = 1

		delete ri
		from staff s 
		join Recipe r 
		on s.StaffID = r.StaffID
		join RecipeIngredient ri 
		on r.RecipeID = ri.RecipeID
		where s.StaffId = 1

		delete rd
		from staff s 
		join Recipe r 
		on s.StaffID = r.StaffID
		join RecipeDirection rd 
		on r.RecipeID = rd.RecipeID
		where s.StaffId = 1


		delete r
		from staff s 
		join Recipe r 
		on s.StaffID = r.StaffID
		where s.StaffId = 1

		delete s 
		from staff s 
		where s.StaffId = 1

		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	finished:
	return @return
end
go















select * from staff
exec dbo.StaffDelete
	1 = 1

select * from staff 


delete cbr
from CookBookRecipe cbr
join Cookbook cb
on cbr.CookbookID = cb.CookbookID
where cb.StaffID = 1

delete cb
from Cookbook cb 
where cb.StaffID = 1 

delete mcr
from MealCourseRecipe mcr
join Recipe r 
on mcr.RecipeID = r.RecipeID
where r.StaffID = 1 

delete mc
from MealCourse mc
join Meal m 
on mc.MealID = m.MealID
where m.StaffID = 1

delete m 
from Meal m
where m.StaffId = 1 

delete r 
from Recipe r
where r.StaffID  =1 

delete s  
from staff s 
where s.StaffID = 1

