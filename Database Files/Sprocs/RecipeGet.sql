create or alter procedure dbo.RecipeGet(
	@RecipeId int = 0,
	@All bit = 0,
	@RecipeName varchar(50) = ''

)
as
begin
	select @RecipeName = nullif(@RecipeName, '')
	select r.RecipeID, r.StaffID, r.CuisineTypeID, r.RecipeName, r.Calories, r.DraftDate, r.PublishedDate, r.ArchivedDate, r.CurrentStatus, r.RecipePicture
	from Recipe r 
	where r.RecipeID = @RecipeId
	or @All = 1
	or r.RecipeName like '%' + @RecipeName + '%'
	order by r.RecipeID
end
go

