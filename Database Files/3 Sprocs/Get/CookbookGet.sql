create or alter procedure dbo.CookbookGet(
	@CookbookId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Summary bit = 0,
	@Message varchar(500) = ''  output
)
as
begin

	declare @return int = 0

	select @All = isnull(@All,0), @CookbookId = isnull(@CookbookId,0), @IncludeBlank = ISNULL(@IncludeBlank,0)
	
	if @Summary = 1
	begin 
		select cb.CookbookId, 'Cookbook Name' = cb.CookbookName, Author = s.UserName, 'Num Recipes' = count(cbr.RecipeId), cb.Price
		from Cookbook cb 
		join Staff s 
		on cb.StaffId = s.StaffId
		join CookBookRecipe cbr
		on cb.CookbookId = cbr.CookbookId
		group by cb.CookbookId, cb.CookbookName, s.StaffId, s.UserName, cb.Price
		order by cb.CookbookName
	end
	else

		select cb.CookbookId, cb.CookbookName, cb.StaffId, cb.Price, cb.CookbookCreationDate, cb.IsActive
		from Cookbook cb
		where (cb.CookbookId = @CookbookId
		or @All = 1) 
		union select 0, ' ', 0, 0, null, 0
		where @IncludeBlank = 1
		order by cb.CookbookName
	

	return @return

end

go 
