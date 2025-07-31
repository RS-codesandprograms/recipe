declare @staffid int
select top 1 @staffid = s.StaffId from Staff s join Recipe r on s.StaffID = r.StaffID
select *
from staff s 
where s.StaffID = @staffid


--declare @cookbookid int
--exec @cookbookid = CookbookAutoCreate @Cookbookid = 0, @Staffid = @staffid

Insert Cookbook(StaffID, CookBookName, Price, IsActive)
	Select s.StaffID, concat('Recipes by ', s.Firstname, ' ', s.Lastname), count(r.RecipeID) * 1.33, 1
	from Staff s
	join Recipe r 
	on s.StaffID = r.StaffID
	where s.StaffID = @StaffId
	and r.CurrentStatus in ('Archived', 'Published')
	group by s.StaffID, concat('Recipes by ', s.Firstname, ' ', s.Lastname)

	--select @CookbookId = SCOPE_IDENTITY() 

	Insert CookBookRecipe(CookBookID, RecipeID, BookRecipeSequence)
	select cb.CookbookID, r.RecipeID, Row_Number() over (order by r.RecipeName)
	from Cookbook cb 
	join staff s
	on cb.StaffID = s.StaffID 
	join Recipe r 
	on r.StaffID = s.StaffID  
	where s.StaffID = @StaffId
	and cb.CookbookName = concat('Recipes by ', s.Firstname, ' ', s.Lastname)
	and r.CurrentStatus in ('Archived', 'Published')



select *
from Cookbook c
join CookBookRecipe r
on c.CookbookName = r.CookbookID