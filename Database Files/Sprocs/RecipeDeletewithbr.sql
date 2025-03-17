create or alter procedure dbo.RecipeDelete(
	@RecipeId int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	if exists(select * from recipe r  where r.CurrentStatus = 'Published' or (r.CurrentStatus = 'Archived' and datediff(day, r.ArchivedDate, GETDATE()) <= 30))
	begin
		select @return = 1, @Message = 'Cannot delete recipe that is published or archived 30 or less days ago.'
		goto finished
	end

	begin try
		begin tran
		delete RecipeDirection where RecipeID = @RecipeId
		delete RecipeIngredient where RecipeID = @RecipeId
		delete Recipe where RecipeID = @RecipeId
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





