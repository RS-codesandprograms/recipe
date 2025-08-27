--AS Combine this sproc with CookbookGet sproc
create or alter procedure dbo.CookbookSummaryGet(
	@Message varchar(500) = ''  output

)
as
begin
	select cb.CookbookID, cb.CookbookName, Author = s.UserName, 'Num Recipes' = count(cbr.RecipeID), cb.Price
	from Cookbook cb 
	join Staff s 
	on cb.StaffID = s.StaffID
	join CookBookRecipe cbr
	on cb.CookbookID = cbr.CookbookID
	--where cb.IsActive = 1
	group by cb.CookbookID, cb.CookbookName, s.StaffID, s.UserName, cb.Price
	order by cb.CookbookName

end
go