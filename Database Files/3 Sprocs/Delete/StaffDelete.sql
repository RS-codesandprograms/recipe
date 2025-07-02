create or alter procedure dbo.StaffDelete(
	@StaffId int,
	@Message varchar(500) = '' output

)
as
begin
	declare @return int = 0
		; 
		with x as(
			select StaffID = s.StaffID
			from staff s 
			where s.StaffID = @StaffId
		)
		delete cbr
		from x 
		cross join staff s 
		join cookbook cb 
		on s.StaffID = cb.StaffID
		join CookBookRecipe cbr 
		on cb.CookbookID = cbr.CookbookID
		join Recipe r 
		on cbr.RecipeID = r.RecipeID
		where r.StaffID = x.StaffID 
		or s.staffID = x.StaffID

		delete cb
		from staff s 
		join Cookbook cb 
		on s.StaffID = cb.StaffID
		where s.StaffID = @StaffId

		; 
		with x as(
			select StaffID = s.StaffID
			from staff s 
			where s.StaffID = @StaffId
		)
		delete mcr 
		from x 
		cross join staff s 
		join Meal m 
		on s.StaffID = m.StaffID
		join MealCourse mc
		on m.MealID = mc.MealID
		join MealCourseRecipe mcr 
		on mc.MealCourseID = mcr.MealCourseID
		join recipe r 
		on mcr.RecipeID = r.RecipeID
		where r.StaffID = x.StaffID 
		or s.staffID = x.StaffID

		delete mc
		from staff s 
		join Meal m 
		on s.StaffID = m.StaffID
		join MealCourse mc 
		on m.MealID = mc.MealID
		where s.StaffID = @StaffId

		delete m
		from staff s 
		join Meal m 
		on s.StaffID = m.StaffID
		where s.StaffID = @StaffId

		delete ri
		from staff s 
		join Recipe r 
		on s.StaffID = r.StaffID
		join RecipeIngredient ri 
		on r.RecipeID = ri.RecipeID
		where s.StaffID = @StaffId

		delete rd
		from staff s 
		join Recipe r 
		on s.StaffID = r.StaffID
		join RecipeDirection rd 
		on r.RecipeID = rd.RecipeID
		where s.StaffID = @StaffId

		delete r
		from staff s 
		join Recipe r 
		on s.StaffID = r.StaffID
		where s.StaffID = @StaffId

		delete s 
		from staff s 
		where s.StaffID = @StaffId

	return @return
end
go














