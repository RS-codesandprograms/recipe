create or alter procedure dbo.RecipeGet(
	@RecipeId int = 0,
	@All bit = 0,
	@RecipeName varchar(50) = '',
	@Summary bit = 0,
	@Message varchar(500) = ''  output

)
as
begin
	select @RecipeId = isnull(@RecipeId,0), @RecipeName = nullif(@RecipeName, ''), @Summary = ISNULL(@Summary, 0)

	if @Summary = 1
	begin
		select
		r.RecipeId, 
		'Recipe Name' = r.RecipeName,
		'Status' = r.CurrentStatus,
		'User' = concat(s.FirstName, ' ',  s.LastName),
		r.Calories,
		'Num Ingredients' = count(ri.RecipeIngredientId) 
		from recipe r
		join Staff s 
		on r.StaffId = s.StaffId
		left join RecipeIngredient ri
		on r.RecipeId = ri.RecipeId
		group by r.RecipeId, r.RecipeName, r.CurrentStatus, s.FirstName, s.LastName, r.Calories
		order by r.CurrentStatus desc
	end
	else 
	
		select r.RecipeId, r.StaffId, r.CuisineTypeId, r.RecipeName, r.Calories, r.DraftDate, r.PublishedDate, r.ArchivedDate, r.CurrentStatus, r.RecipePicture
		from Recipe r 
		where r.RecipeId = @RecipeId
		or @All = 1
		or r.RecipeName like '%' + @RecipeName + '%'
		order by r.CurrentStatus
end
go

