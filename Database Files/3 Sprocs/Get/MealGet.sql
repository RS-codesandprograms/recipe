create or alter procedure dbo.MealGet(
	@MealId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
)
as
begin

	declare @return int = 0

	select @All = isnull(@All,0), @MealId = isnull(@MealId,0), @IncludeBlank = ISNULL(@IncludeBlank,0)
	
	select m.MealId, m.MealName
	from Meal m
	where m.MealId = @MealId
	or @All = 1
	union select 0, ''
	where @IncludeBlank = 1
	order by m.MealID

	return @return

end
go


--exec MealGet @All = 1, @Includeblank = 1