create or alter procedure dbo.RecipeDelete(
	@RecipeId int,
	@Message varchar(500) = '' output

)
as
begin
	declare @return int = 0

	if exists(select * from recipe r  where r.RecipeId = @RecipeId and (r.CurrentStatus = 'Published' or (r.CurrentStatus = 'Archived' and datediff(day, r.ArchivedDate, GETDATE()) <= 30)))
	begin
		select @return = 1, @Message = 'Cannot delete recipe that is published or archived 30 or less days ago.'
		goto finished
	end

	begin try
		begin tran
		delete CookBookRecipe where RecipeId = @RecipeId
		delete MealCourseRecipe where RecipeId = @RecipeId
		delete RecipeDirection where RecipeId = @RecipeId
		delete RecipeIngredient where RecipeId = @RecipeId
		delete Recipe where RecipeId = @RecipeId
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





