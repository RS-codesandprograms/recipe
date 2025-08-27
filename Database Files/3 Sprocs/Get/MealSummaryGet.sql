--AS Combine this sproc with MealGet
create or alter procedure dbo.MealSummaryGet(
	@Message varchar(500) = ''  output

)
as
begin
	
	
	select m.MealID, 'Meal Name' = m.MealName, 'User' = s.UserName, 
	'Num Calories' = Sum(r.Calories),
	'Num Courses' = count(distinct mc.MealCourseID),
	'Num Recipes' = count(distinct mcr.MealCourseRecipeID)
	from Meal m 
	join Staff s 
	on m.StaffID = s.StaffID
	join MealCourse mc 
	on m.MealID = mc.MealID
	join MealCourseRecipe mcr
	on mc.MealCourseID = mcr.MealCourseID 
	join Recipe r 
	on mcr.RecipeID = r.RecipeID
	group by m.MealID, m.MealName, s.StaffID, s.UserName, m.MealPicture
	order by m.MealName
	
end
go

