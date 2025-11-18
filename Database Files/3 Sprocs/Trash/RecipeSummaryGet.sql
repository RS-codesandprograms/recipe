create or alter procedure dbo.RecipeSummaryGet(
	@Message varchar(500) = ''  output

)
as
begin
	
	select
		r.RecipeId, 
		'Recipe Name' = r.RecipeName,
		'Status' = r.CurrentStatus,
		'User' = concat(s.FirstName, ' ',  s.LastName),
		r.Calories,
		'Num Ingredients' = count(ri.RecipeIngredientId) 
	from recipe r
	join Staff s 
	on r.StaffId = s.StaffId
	left join RecipeIngredient ri
	on r.RecipeId = ri.RecipeId
	group by r.RecipeId, r.RecipeName, r.CurrentStatus, s.FirstName, s.LastName, r.Calories
	order by r.CurrentStatus desc
	
	
end
go

