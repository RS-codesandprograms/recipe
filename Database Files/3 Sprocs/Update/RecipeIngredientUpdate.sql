create or alter proc dbo.RecipeIngredientUpdate(
	@RecipeIngredientId int  output,
	@RecipeId int,
	@MeasurementTypeId int,
	@IngredientId int,
	@IngredientAmount decimal,
	@IngredientSequence int,
	@Message varchar(500) = ''
)
as 
begin
	declare @return int = 0;

	select @RecipeIngredientId = isnull(@RecipeIngredientId, 0), @RecipeId = isnull(@RecipeId,0)

	if @RecipeIngredientId = 0
	begin 

		insert RecipeIngredient(RecipeId, MeasurementTypeId, IngredientId, IngredientAmount, IngredientSequence)
		values (@RecipeId, @MeasurementTypeId, @IngredientId, @IngredientAmount, @IngredientSequence)

		select @RecipeIngredientId = SCOPE_IdENTITY()

	end 

	else 
	begin
		update RecipeIngredient
		set
		RecipeId = @RecipeId, 
		MeasurementTypeId = @MeasurementTypeId, 
		IngredientId = @IngredientId, 
		IngredientAmount = @IngredientAmount, 
		IngredientSequence = @IngredientSequence
		where RecipeIngredientId = @RecipeIngredientId 
	end

	finished:
	return @return 
end
go