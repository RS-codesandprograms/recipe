create or alter procedure dbo.SummaryGet(
	@Message varchar(500) = ''  output
)
as
begin
	
	
	select  Type = 'Recipes', Number = count(r.RecipeId) from Recipe r
	union select 'Meals', count(m.MealId) from Meal m
	union select 'Cookbooks', count(cb.CookbookId) from CookBook cb

	

end

go

exec SummaryGet