create or alter procedure dbo.RecipeDirectionGet(
	@RecipeDirectionId int = 0,
	@RecipeId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select  @RecipeDirectionId = isnull(@RecipeDirectionId,0), @RecipeId = isnull(@RecipeId,0)
	
	
	select ri.RecipeID, ri.Instruction, ri.DirectionSequence
	from RecipeDirection ri 
	where ri.RecipeID = @RecipeId
	order by ri.DirectionSequence

	return @return
end

go


exec RecipeDirectionGet
@RecipeId = 107
--@All = 1, @IncludeBlank = 1