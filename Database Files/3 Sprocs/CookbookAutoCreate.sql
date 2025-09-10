create or alter proc dbo.CookbookAutoCreate(
	@CookbookId int output,
	@StaffId int,
	@Message varchar(500) = '' output
)
as
begin

	declare @return int = 0
	select @CookbookId = isnull(@CookbookId,0), @StaffId = isnull(@StaffId,0)

	begin try
		begin tran
	
	Insert Cookbook(StaffId, CookBookName, Price, IsActive)
	Select s.StaffId, concat('Recipes by ', s.Firstname, ' ', s.Lastname), count(r.RecipeId) * 1.33, 1
	from Staff s
	join Recipe r 
	on s.StaffId = r.StaffId
	where s.StaffId = @StaffId
	and r.CurrentStatus in ('Archived', 'Published')
	group by s.StaffId, concat('Recipes by ', s.Firstname, ' ', s.Lastname)

	select @CookbookId = SCOPE_IdENTITY();

	Insert CookbookRecipe(CookbookId, RecipeId, BookRecipeSequence)
	select cb.CookbookId, r.RecipeId, Row_Number() over (order by r.RecipeName)
	from Cookbook cb 
	join staff s
	on cb.StaffId = s.StaffId 
	join Recipe r 
	on r.StaffId = s.StaffId  
	where cb.Cookbookid = @CookbookId
	and r.CurrentStatus in ('Archived', 'Published')
	order by r.RecipeName

	commit
	end try
	begin catch
		rollback;
		throw
	end catch

	finished:
	return @return
end
go
