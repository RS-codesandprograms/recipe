create or alter procedure dbo.RecipeDelete(
	@RecipeId int
)
as
begin
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
end
go





