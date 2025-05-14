create or alter function dbo.RecipeDesc(@RecipeId int)
returns varchar(100)
as
begin

	declare @value varchar(100) = ''

	select @value = 
	concat(
		r.RecipeName, 
		' (', c.CuisineName, ') has ',
		count(distinct i.RecipeIngredientID),
		' ingredients and ',
		count( distinct d.RecipeDirectionID), 
		' steps.'
	) 
	from recipe r 
	join CuisineType c 
	on r.CuisineTypeID = c.CuisineTypeID
	left join RecipeIngredient i 
	on r.RecipeID = i.RecipeID
	left join RecipeDirection d
	on r.RecipeID = d.RecipeID
	where r.RecipeID = @RecipeId
	group by r.RecipeName, c.CuisineName
	
		

	return @value
end
go

select RecipeDesc = dbo.RecipeDesc(r.recipeid)
from recipe r 
