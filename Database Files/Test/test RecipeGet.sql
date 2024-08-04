
exec dbo.RecipeGet -- returns none
exec dbo.RecipeGet @All = 1 -- returns all
exec dbo.RecipeGet @RecipeName = null -- returns none

declare @RecipeId int 
select @RecipeId = r.RecipeId from Recipe r 
exec dbo.RecipeGet @RecipeId = @RecipeId

declare @RecipeName varchar(50)
select @RecipeName = r.RecipeName from Recipe r
exec dbo.RecipeGet @RecipeName = @RecipeName
