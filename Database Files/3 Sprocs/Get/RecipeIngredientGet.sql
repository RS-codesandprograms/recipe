create or alter procedure dbo.RecipeIngredientGet(
	@RecipeIngredientId int = 0,
	@RecipeId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select  @RecipeIngredientId = isnull(@RecipeIngredientId,0), @RecipeId = isnull(@RecipeId,0)
	
	
	select ri.RecipeIngredientID,  ri.IngredientID, ri.MeasurementTypeID, ri.IngredientAmount, ri.IngredientSequence
	from RecipeIngredient ri 
	where ri.RecipeID = @RecipeId
	order by ri.IngredientSequence

	return @return
end

go


exec RecipeIngredientGet
@RecipeId = 107
--@All = 1, @IncludeBlank = 1