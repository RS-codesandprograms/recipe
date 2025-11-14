create or alter procedure dbo.CookbookDelete(
	@CookbookId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CookbookId = isnull(@CookbookId,0)

	begin try 
		begin tran 

			delete cbr
			from CookBookRecipe cbr
			join Cookbook cb 
			on cbr.CookbookID = cb.CookbookID
			where cb.CookbookID = @CookbookId

			delete Cookbook where CookbookId = @CookbookId	

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

