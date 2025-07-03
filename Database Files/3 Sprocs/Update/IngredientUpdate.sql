create or alter proc dbo.IngredientUpdate(
	@IngredientID int  output,
	@IngredientName varchar (50),
	@Message varchar(500) = '' output
) 
as
begin
	declare @return int = 0

	select @IngredientID = isnull(@IngredientID,0)
	
	if @IngredientID = 0
	begin
		insert Ingredient(IngredientName)
		values(@IngredientName)
		
		select @IngredientID = SCOPE_IDENTITY()
	end
	else
	begin
		update Ingredient 
		set 
		IngredientName = @IngredientName 
		where IngredientID = @IngredientID
	end

	finished:
	return @return
end
go

