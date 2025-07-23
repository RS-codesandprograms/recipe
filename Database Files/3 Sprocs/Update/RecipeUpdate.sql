create or alter proc dbo.RecipeUpdate(
	@RecipeID int output,
	@StaffID int,
	@CuisineTypeID int,
	@RecipeName varchar (50),
	@Calories int,
	@DraftDate datetime output,
	@PublishedDate datetime,
	@ArchivedDate datetime,
	@CurrentStatus varchar (9),
	@RecipePicture varchar (8000),
	@Message varchar(500) = '' output
) 
as
begin
	declare @return int = 0

	select @RecipeID = isnull(@RecipeID,0)
	
	if @RecipeID = 0
	begin
		insert Recipe(StaffID, CuisineTypeID, RecipeName, Calories, DraftDate, PublishedDate, ArchivedDate)
		values(@StaffID, @CuisineTypeID, @RecipeName, @Calories, @DraftDate, @PublishedDate, @ArchivedDate)
		
		select @RecipeID = SCOPE_IDENTITY()
	end
	else
	begin
		update Recipe 
		set 
			CuisineTypeID = @CuisineTypeID, 
			RecipeName = @RecipeName, 
			Calories = @Calories, 
			DraftDate = @DraftDate, 
			PublishedDate = @PublishedDate, 
			ArchivedDate = @ArchivedDate
		where RecipeID = @RecipeID
	end

	finished:
	return @return
end
go
