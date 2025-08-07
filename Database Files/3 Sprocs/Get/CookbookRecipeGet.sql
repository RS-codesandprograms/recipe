create or alter procedure dbo.CookbookRecipeGet(
	@CookbookRecipeId int = 0,
	@CookbookId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select  @CookbookRecipeId = isnull(@CookbookRecipeId,0), @CookbookId = isnull(@CookbookId,0)
	
	select cb.CookbookID, cbr.CookBookRecipieID, cbr.RecipeID, cbr.BookRecipeSequence
	from Cookbook cb 
	join CookBookRecipe cbr 
	on cb.CookbookID = cbr.CookbookID
	join Recipe r 
	on cbr.RecipeID = r.RecipeID
	where cbr.CookbookID = @CookbookId
	order by cbr.BookRecipeSequence

	return @return
end

go