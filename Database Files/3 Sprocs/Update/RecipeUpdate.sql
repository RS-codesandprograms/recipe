create or alter proc dbo.RecipeUpdate(
	@RecipeId int output,
	@StaffId int,
	@CuisineTypeId int,
	@RecipeName varchar (50),
	@Calories int,
	@DraftDate datetime,
	@PublishedDate datetime,
	@ArchivedDate datetime,
	@CurrentStatus varchar (9) output,
	@RecipePicture varchar (8000),
	@Message varchar(500) = '' output
) 
as
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId,0)
	


	if @RecipeId = 0
	begin
		insert Recipe(StaffId, CuisineTypeId, RecipeName,Calories, DraftDate, PublishedDate, ArchivedDate)
		values(@StaffId, @CuisineTypeId, @RecipeName, @Calories, GETDATE(), @PublishedDate, @ArchivedDate)
		
		select @RecipeId = SCOPE_IdENTITY()
	end
	else
	begin
		update Recipe 
		set 
			StaffId = @StaffId,
			CuisineTypeId = @CuisineTypeId, 
			RecipeName = @RecipeName, 
			Calories = @Calories, 
			DraftDate = @DraftDate, 
			PublishedDate = @PublishedDate, 
			ArchivedDate = @ArchivedDate
		where RecipeId = @RecipeId
	end

	select @CurrentStatus = CurrentStatus
	from Recipe
	where RecipeId = @RecipeId;


	finished:
	return @return
end
go
