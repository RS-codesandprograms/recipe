create or alter procedure dbo.RecipeIngredientGet(
	@RecipeIngredientId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @RecipeIngredientId = isnull(@RecipeIngredientId,0), @IncludeBlank = ISNULL(@IncludeBlank,0)
	
	
	select ri.RecipeIngredientID, ri.RecipeID, ri.IngredientID, ri.MeasurementTypeID, ri.MeasurementTypeID, ri.IngredientAmount, ri.IngredientSequence
	from RecipeIngredient ri 
	where ri.RecipeIngredientID = @RecipeIngredientId
	or @All = 1
	union select 0, 0, 0, ' ',  ' ', 0, 0
	where @IncludeBlank = 1
	order by ri.IngredientSequence

	return @return
end

go


exec RecipeIngredientGet @All = 1, @IncludeBlank = 1