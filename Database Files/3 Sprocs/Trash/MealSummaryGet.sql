create or alter procedure dbo.MealSummaryGet(
	@Message varchar(500) = ''  output

)
as
begin
	
	
	select m.MealId, 'Meal Name' = m.MealName, 'User' = s.UserName, 
	'Num Calories' = Sum(r.Calories),
	'Num Courses' = count(distinct mc.MealCourseId),
	'Num Recipes' = count(distinct mcr.MealCourseRecipeId)
	from Meal m 
	join Staff s 
	on m.StaffId = s.StaffId
	join MealCourse mc 
	on m.MealId = mc.MealId
	join MealCourseRecipe mcr
	on mc.MealCourseId = mcr.MealCourseId 
	join Recipe r 
	on mcr.RecipeId = r.RecipeId
	group by m.MealId, m.MealName, s.StaffId, s.UserName, m.MealPicture
	order by m.MealName
	
end
go

