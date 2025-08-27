--AS Combine this sproc with RecipeGet
create or alter procedure dbo.RecipeSummaryGet(
	@Message varchar(500) = ''  output

)
as
begin
	
	select
		r.RecipeID, 
		'Recipe Name' = r.RecipeName,
		'Status' = r.CurrentStatus,
		'User' = concat(s.FirstName, ' ',  s.LastName),
		r.Calories,
		'Num Ingredients' = count(ri.RecipeIngredientID) 
	from recipe r
	join Staff s 
	on r.StaffID = s.StaffID
	left join RecipeIngredient ri
	on r.RecipeID = ri.RecipeID
	group by r.RecipeID, r.RecipeName, r.CurrentStatus, s.FirstName, s.LastName, r.Calories
	order by r.CurrentStatus desc
	
	
end
go

