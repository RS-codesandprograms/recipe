declare @recipeID int

select top 1 @recipeID = r.RecipeID from recipe r
join RecipeIngredient ri 
on r.RecipeID = ri.RecipeID
join RecipeDirection rd
on r.RecipeID = rd.RecipeID
left join MealCourseRecipe m 
on r.RecipeID = m.RecipeID
left join CookBookRecipe c
on r.RecipeID = c.RecipeID

where m.RecipeID is null and c.RecipeID is null
/*and (
r.CurrentStatus = 'Draft'
or (r.CurrentStatus = 'Archived' and datediff(day, r.ArchivedDate, GETDATE()) > 30))-- recipe selected should be able to be deleted.
*/

--Update the where clause to see recipe selected cannot be deleted. 
and (
r.CurrentStatus = 'Published' 
or (r.CurrentStatus = 'Archived' and datediff(day, r.ArchivedDate, GETDATE()) <= 30))

	

select * from recipe r where r.RecipeID = @recipeID

declare @return int, @message varchar (500)
exec @return = RecipeDelete @RecipeID = @recipeID, @Message = @message output
select @return, @message


select * from recipe r where r.RecipeID = @recipeID


