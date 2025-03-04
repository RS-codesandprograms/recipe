declare @recipeID int

select @recipeID = r.RecipeID from recipe r
join RecipeIngredient ri 
on r.RecipeID = ri.RecipeID
join RecipeDirection rd
on r.RecipeID = rd.RecipeID
--join MealCourseRecipe m 
--on r.RecipeID = m.RecipeID
--join CookBookRecipe c
--on r.RecipeID = c.RecipeID

select count(*) from recipe r 

exec RecipeDelete @RecipeID = @recipeID

select count(*) from recipe r

