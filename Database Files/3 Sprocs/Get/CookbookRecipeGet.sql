create or alter procedure dbo.CookbookRecipeGet(
	@CookbookRecipeId int = 0,
	@CookbookId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select  @CookbookRecipeId = isnull(@CookbookRecipeId,0), @CookbookId = isnull(@CookbookId,0)
	
	
	select  ri.CookbookRecipeID, ri.RecipeID, ri.IngredientID, ri.MeasurementTypeID, ri.IngredientAmount, ri.IngredientSequence
	from CookbookRecipe ri 
	where ri.RecipeID = @CookbookId
	order by ri.IngredientSequence

	return @return
end

go