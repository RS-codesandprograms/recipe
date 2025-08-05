create or alter proc dbo.CookbookAutoCreate(
	@CookbookId int output,
	@StaffId int,
	@Message varchar(500) = ''
)
as
begin

	declare @return int = 0
	select @CookbookId = isnull(@CookbookId,0), @StaffId = isnull(@StaffId,0)


	create or alter procedure dbo.PresidentDelete(
	@PresidentId int,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0, @deleteallowed varchar(60) = ''

	select @deleteallowed = isnull(dbo.IsPresidentDeleteAllowed(@PresidentId), '')
	if @deleteallowed <> ''
	begin
		select @return = 1, @Message = @deleteallowed
		goto finished
	end

	begin try
		begin tran
		



	Insert Cookbook(StaffID, CookBookName, Price, IsActive)
	Select s.StaffID, concat('Recipes by ', s.Firstname, ' ', s.Lastname), count(r.RecipeID) * 1.33, 1
	from Staff s
	join Recipe r 
	on s.StaffID = r.StaffID
	where s.StaffID = @StaffId
	and r.CurrentStatus in ('Archived', 'Published')
	group by s.StaffID, concat('Recipes by ', s.Firstname, ' ', s.Lastname)

	select @CookbookId = SCOPE_IDENTITY() 

	Insert CookbookRecipe(CookbookID, RecipeID, BookRecipeSequence)
	select cb.CookbookID, r.RecipeID, Row_Number() over (order by r.RecipeName)
	from Cookbook cb 
	join staff s
	on cb.StaffID = s.StaffID 
	join Recipe r 
	on r.StaffID = s.StaffID  
	where cb.Cookbookid = @CookbookId
	and r.CurrentStatus in ('Archived', 'Published')

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
