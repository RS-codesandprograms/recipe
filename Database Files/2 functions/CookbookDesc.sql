create or alter function dbo.CookbookDesc(@RecipeId int)
returns varchar(50)
as
begin
	declare @value varchar(50) = ''
	select @value = cb.CookbookName
	from Cookbook cb

	return @value 
end

go