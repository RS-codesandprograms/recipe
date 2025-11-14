create or alter procedure dbo.CuisineTypeDelete(
	@CuisineTypeId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CuisineTypeId = isnull(@CuisineTypeId,0)
	begin try 
		begin tran 

			delete ri 
			from Ingredient i 
			join RecipeIngredient ri 
			on i.IngredientID = ri.IngredientID
			join Recipe r 
			on r.RecipeID = ri.RecipeID
			join CuisineType ct 
			on r.CuisineTypeID = ct.CuisineTypeID
			where ct.CuisineTypeID = @CuisineTypeId
			
			delete rd
			from RecipeDirection rd 
			join Recipe r 
			on r.RecipeID = rd.RecipeID
			join CuisineType ct 
			on r.CuisineTypeID = ct.CuisineTypeID
			where ct.CuisineTypeID = @CuisineTypeId

			delete cbr
			from CookBookRecipe cbr
			join Recipe r 
			on r.RecipeID = cbr.RecipeID
			join CuisineType ct 
			on r.CuisineTypeID = ct.CuisineTypeID
			where ct.CuisineTypeID = @CuisineTypeId

			delete mcr
			from MealCourseRecipe mcr
			join Recipe r 
			on r.RecipeID = mcr.RecipeID
			join CuisineType ct 
			on r.CuisineTypeID = ct.CuisineTypeID
			where ct.CuisineTypeID = @CuisineTypeId


			delete r
			from CuisineType ct 
			join Recipe  r
			on ct.CuisineTypeID = r.CuisineTypeID
			where ct.CuisineTypeID = @CuisineTypeId


			delete CuisineType where CuisineTypeId = @CuisineTypeId


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

