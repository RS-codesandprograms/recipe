create or alter proc dbo.CookbookRecipeUpdate(
@CookBookRecipeId int output,
@CookbookId int,
@RecipeId int,
@BookRecipeSequence int,
@Message varchar(500) = ''
)

as
begin
	declare @return int = 0

	select @CookbookRecipeId = isnull(@CookbookRecipeId, 0), @CookbookId = isnull(@CookbookId, 0)

	if @CookBookRecipeId = 0
	begin
		insert CookBookRecipe(CookbookId, RecipeId, BookRecipeSequence)
		values (@CookbookId, @RecipeId, @BookRecipeSequence)

		select @CookBookRecipeId = SCOPE_IdENTITY()
	end

	else 
	begin
		update CookBookRecipe
		set
		CookbookId = @CookbookId, 
		RecipeId = @RecipeId, 
		BookRecipeSequence = @BookRecipeSequence
		where CookBookRecipeId = @CookBookRecipeId
	end

	finished:
	return @return 
end
go

