create or alter procedure dbo.SummaryGet(
	@Message varchar(500) = ''  output
)
as
begin
	
	select Type = 'Recipes', Number = count(r.RecipeID) from Recipe r
	union select 'Meals', count(m.MealID) from Meal m
	union select 'Cookbooks', count(cb.CookbookID) from CookBook cb


end

go

exec SummaryGet