create or alter proc dbo.CookbookRecipeUpdate(
@CookBookRecipeID int output,
@CookbookID int,
@RecipeID int,
@BookRecipeSequence int,
@Message varchar(500) = ''
)

as
begin
	declare @return int = 0

	select @CookbookRecipeId = isnull(@CookbookRecipeId, 0), @CookbookId = isnull(@CookbookId, 0), @RecipeId = isnull(@RecipeId, 0)

	if @CookBookRecipeID = 0
	begin
		insert CookBookRecipe(CookbookID, RecipeID, BookRecipeSequence)
		values (@CookbookID, @RecipeID, @BookRecipeSequence)

		select @CookBookRecipeID = SCOPE_IDENTITY()
	end

	else 
	begin
		update CookBookRecipe
		set
		CookbookID = @CookbookID, 
		RecipeID = @RecipeID, 
		BookRecipeSequence = @BookRecipeSequence
		where CookBookRecipeID = @CookBookRecipeID
	end

	finished:
	return @return 
end
go

