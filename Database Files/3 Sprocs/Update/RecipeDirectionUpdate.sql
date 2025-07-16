create or alter proc dbo.RecipeDirectionUpdate(
	@RecipeDirectionId int  output,
	@RecipeId int,
	@DirectionSequence int ,
	@Instruction varchar (250),
	@Message varchar(500) = ''
)
as 
begin
	declare @return int = 0;

	select @RecipeDirectionId = isnull(@RecipeDirectionId, 0), @RecipeId = isnull(@RecipeId, 0)

	if @RecipeDirectionId = 0
	begin 

		insert RecipeDirection(RecipeId, DirectionSequence, Instruction)
		values (@RecipeId, @DirectionSequence, @Instruction)

		select @RecipeDirectionId = SCOPE_IdENTITY()

	end 

	else 
	begin
		update RecipeDirection
		set
		RecipeId = @RecipeId, 
		DirectionSequence = @DirectionSequence, 
		Instruction = @Instruction
		where RecipeDirectionId = @RecipeDirectionId 
	end

	finished:
	return @return 
end
go