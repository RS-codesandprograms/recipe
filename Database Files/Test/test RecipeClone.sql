declare @BaseRecipeid int 
select top 1 @BaseRecipeid = recipeid from Recipe r where r.CurrentStatus <> 'Draft'
select @BaseRecipeid

declare @return int
exec @return = RecipeClone @BaseRecipeid = @BaseRecipeid 

select *
from Recipe r
join RecipeIngredient i 
on r.RecipeID = i.RecipeID
join RecipeDirection d 
on r.RecipeID = d.RecipeID
where r.RecipeID = 241

