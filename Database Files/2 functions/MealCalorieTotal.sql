create or alter function dbo.MealCalorieTotal(@MealId int)
returns int
as
begin
	
	declare @value int 

	select @value = sum(r.calories)
	from meal m 
	join MealCourse mc
	on m.MealID = mc.MealID
	join MealCourseRecipe mcr
	on mc.MealCourseID = mcr.MealCourseID
	join Recipe r
	on r.RecipeID = mcr.RecipeID
	where m.MealID = @MealId
	
	

	return @value
end 
go


select m.MealName, TotalCalories = dbo.MealCalorieTotal(m.mealid)
from meal m 