create or alter procedure dbo.CookbookRecipeGet(
	@CookbookRecipeId int = 0,
	@CookbookId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select  @CookbookRecipeId = isnull(@CookbookRecipeId,0), @CookbookId = isnull(@CookbookId,0)
	
	select cb.CookbookId, cbr.CookBookRecipeId, cbr.RecipeId, cbr.BookRecipeSequence
	from Cookbook cb 
	join CookBookRecipe cbr 
	on cb.CookbookId = cbr.CookbookId
	join Recipe r 
	on cbr.RecipeId = r.RecipeId
	where cbr.CookbookId = @CookbookId
	order by cbr.BookRecipeSequence

	return @return
end

go