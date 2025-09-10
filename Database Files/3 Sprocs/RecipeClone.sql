create or alter proc dbo.RecipeClone(
	@Recipeid int = null output,
	@BaseRecipeid int,
	@Message varchar (500) = ''
)
as
begin

declare @return int = 0

Insert Recipe (StaffId, CuisineTypeId, RecipeName, Calories)
select r.StaffId, r.CuisineTypeId, concat(r.RecipeName, ' - clone'), r.Calories
from Recipe r 
where Recipeid = @BaseRecipeid

select @Recipeid = SCOPE_IdENTITY();

; 
with x as (
    select RecipeName = concat(r.RecipeName, ' - clone'),
    MeasurementTypeId = ri.MeasurementTypeId, IngredientId = ri.IngredientId,
    IngredientAmount = ri.IngredientAmount, IngredientSequence = ri.IngredientSequence
    from RecipeIngredient ri 
    join Recipe r 
    on ri.RecipeId = r.RecipeId
    where r.Recipeid = @BaseRecipeid
)
Insert RecipeIngredient (RecipeId, MeasurementTypeId, IngredientId, IngredientAmount, IngredientSequence)
select r.RecipeId, x.MeasurementTypeId, x.IngredientId, x.IngredientAmount, x.IngredientSequence
from x
join Recipe r
on x.RecipeName = r.RecipeName 

; 
with x as (
    select RecipeName = concat(r.RecipeName, ' - clone'),
    DirectionSequence = rd.DirectionSequence, Instruction = rd.Instruction
    from RecipeDirection rd 
    join Recipe r 
    on rd.RecipeId = r.RecipeId
    where r.Recipeid = @BaseRecipeid
)
Insert RecipeDirection (RecipeId, DirectionSequence, Instruction)
select r.RecipeId, x.DirectionSequence, x.Instruction
from x
join Recipe r
on x.RecipeName = r.RecipeName

return @return 

end 
go