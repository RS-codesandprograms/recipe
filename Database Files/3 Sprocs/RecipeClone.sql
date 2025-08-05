create or alter proc dbo.RecipeClone(
	@Recipeid int = null output,
	@BaseRecipeid int,
	@Message varchar (500) = ''
)
as
begin

declare @return int = 0

Insert Recipe (StaffID, CuisineTypeID, RecipeName, Calories)
select r.StaffID, r.CuisineTypeID, concat(r.RecipeName, ' - clone'), r.Calories
from Recipe r 
where Recipeid = @BaseRecipeid

select @Recipeid = SCOPE_IDENTITY();

; 
with x as (
    select RecipeName = concat(r.RecipeName, ' - clone'),
    MeasurementTypeID = ri.MeasurementTypeID, IngredientID = ri.IngredientID,
    IngredientAmount = ri.IngredientAmount, IngredientSequence = ri.IngredientSequence
    from RecipeIngredient ri 
    join Recipe r 
    on ri.RecipeID = r.RecipeID
    where r.Recipeid = @BaseRecipeid
)
Insert RecipeIngredient (RecipeID, MeasurementTypeID, IngredientID, IngredientAmount, IngredientSequence)
select r.RecipeID, x.MeasurementTypeID, x.IngredientID, x.IngredientAmount, x.IngredientSequence
from x
join Recipe r
on x.RecipeName = r.RecipeName 

; 
with x as (
    select RecipeName = concat(r.RecipeName, ' - clone'),
    DirectionSequence = rd.DirectionSequence, Instruction = rd.Instruction
    from RecipeDirection rd 
    join Recipe r 
    on rd.RecipeID = r.RecipeID
    where r.Recipeid = @BaseRecipeid
)
Insert RecipeDirection (RecipeID, DirectionSequence, Instruction)
select r.RecipeID, x.DirectionSequence, x.Instruction
from x
join Recipe r
on x.RecipeName = r.RecipeName

return @return 

end 
go