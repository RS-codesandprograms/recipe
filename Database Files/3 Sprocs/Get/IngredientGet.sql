create or alter procedure dbo.IngredientGet(
	@IngredientId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @IngredientId = isnull(@IngredientId,0), @IncludeBlank = ISNULL(@IncludeBlank,0)
	
	select i.IngredientID, i.IngredientName, i.IngredientPicture
	from Ingredient i 
	where @IngredientId = i.IngredientID
	or @All = 1
	union select 0, '', ''
	where @IncludeBlank = 1
	order by i.IngredientID

	return @return
end

go

--exec IngredientGet @All = 1, @IncludeBlank = 1

