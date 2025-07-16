create or alter proc dbo.RecipeIngredientUpdate(
	@RecipeIngredientID int  output,
	@RecipeID int,
	@MeasurementTypeID int,
	@IngredientID int,
	@IngredientAmount decimal,
	@IngredientSequence int,
	@Message varchar(500) = ''
)
as 
begin
	declare @return int = 0;

	select @RecipeIngredientID = isnull(@RecipeIngredientID, 0), @RecipeID = isnull(@RecipeID,0), @MeasurementTypeID = isnull(@MeasurementTypeID, 0), @IngredientID = isnull(@IngredientID, 0)

	if @RecipeIngredientID = 0
	begin 

		insert RecipeIngredient(RecipeID, MeasurementTypeID, IngredientID, IngredientAmount, IngredientSequence)
		values (@RecipeID, @MeasurementTypeID, @IngredientID, @IngredientAmount, @IngredientSequence)

		select @RecipeIngredientID = SCOPE_IDENTITY()

	end 

	else 
	begin
		update RecipeIngredient
		set
		RecipeID = @RecipeID, 
		MeasurementTypeID = @MeasurementTypeID, 
		IngredientID = @IngredientID, 
		IngredientAmount = @IngredientAmount, 
		IngredientSequence = @IngredientSequence
		where RecipeIngredientId = @RecipeIngredientID 
	end

	finished:
	return @return 
end
go