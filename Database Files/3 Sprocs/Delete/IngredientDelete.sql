create or alter procedure dbo.IngredientDelete(
	@IngredientId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @IngredientId = isnull(@IngredientId,0)

	begin try 
		begin tran 
			delete ri 
			from Ingredient i 
			join RecipeIngredient ri 
			on i.IngredientID = ri.IngredientID
			where i.IngredientID = @IngredientId

			delete i 
			from Ingredient i 
			where i.IngredientID = @IngredientId
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

