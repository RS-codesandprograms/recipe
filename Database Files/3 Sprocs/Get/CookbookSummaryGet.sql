create or alter procedure dbo.CookbookSummaryGet(
	@Message varchar(500) = ''  output

)
as
begin
	select cb.CookbookId, 'Cookbook Name' = cb.CookbookName, Author = s.UserName, 'Num Recipes' = count(cbr.RecipeId), cb.Price
	from Cookbook cb 
	join Staff s 
	on cb.StaffId = s.StaffId
	join CookBookRecipe cbr
	on cb.CookbookId = cbr.CookbookId
	--where cb.IsActive = 1
	group by cb.CookbookId, cb.CookbookName, s.StaffId, s.UserName, cb.Price
	order by cb.CookbookName

end
go