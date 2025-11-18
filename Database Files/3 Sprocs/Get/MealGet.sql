create or alter procedure dbo.MealGet(
	@MealId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Summary bit = 0,
	@Message varchar(500) = ''  output
)
as
begin

	declare @return int = 0

	select @All = isnull(@All,0), @MealId = isnull(@MealId,0), @IncludeBlank = ISNULL(@IncludeBlank,0), @Summary = ISNULL(@Summary, 0)
	
	if @Summary = 1
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
	else

		select m.MealId, m.MealName
		from Meal m
		where m.MealId = @MealId
		or @All = 1
		union select 0, ''
		where @IncludeBlank = 1
		order by m.MealName
	
	return @return

end
go


--exec MealGet @All = 1, @Includeblank = 1