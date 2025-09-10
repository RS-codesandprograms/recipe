create or alter procedure dbo.StaffDelete(
	@StaffId int,
	@Message varchar(500) = '' output

)
as
begin
	declare @return int = 0
		; 
		with x as(
			select StaffId = s.StaffId
			from staff s 
			where s.StaffId = @StaffId
		)
		delete cbr
		from x 
		cross join staff s 
		join cookbook cb 
		on s.StaffId = cb.StaffId
		join CookBookRecipe cbr 
		on cb.CookbookId = cbr.CookbookId
		join Recipe r 
		on cbr.RecipeId = r.RecipeId
		where r.StaffId = x.StaffId 
		or s.staffId = x.StaffId

		delete cb
		from staff s 
		join Cookbook cb 
		on s.StaffId = cb.StaffId
		where s.StaffId = @StaffId

		; 
		with x as(
			select StaffId = s.StaffId
			from staff s 
			where s.StaffId = @StaffId
		)
		delete mcr 
		from x 
		cross join staff s 
		join Meal m 
		on s.StaffId = m.StaffId
		join MealCourse mc
		on m.MealId = mc.MealId
		join MealCourseRecipe mcr 
		on mc.MealCourseId = mcr.MealCourseId
		join recipe r 
		on mcr.RecipeId = r.RecipeId
		where r.StaffId = x.StaffId 
		or s.staffId = x.StaffId

		delete mc
		from staff s 
		join Meal m 
		on s.StaffId = m.StaffId
		join MealCourse mc 
		on m.MealId = mc.MealId
		where s.StaffId = @StaffId

		delete m
		from staff s 
		join Meal m 
		on s.StaffId = m.StaffId
		where s.StaffId = @StaffId

		delete ri
		from staff s 
		join Recipe r 
		on s.StaffId = r.StaffId
		join RecipeIngredient ri 
		on r.RecipeId = ri.RecipeId
		where s.StaffId = @StaffId

		delete rd
		from staff s 
		join Recipe r 
		on s.StaffId = r.StaffId
		join RecipeDirection rd 
		on r.RecipeId = rd.RecipeId
		where s.StaffId = @StaffId

		delete r
		from staff s 
		join Recipe r 
		on s.StaffId = r.StaffId
		where s.StaffId = @StaffId

		delete s 
		from staff s 
		where s.StaffId = @StaffId

	return @return
end
go














