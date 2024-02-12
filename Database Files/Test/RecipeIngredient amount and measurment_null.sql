
Create table dbo.RecipeIngredient(
    RecipeIngredientID int not null identity primary key,
    RecipeID int not null constraint f_Recipe_RecipeIngredient foreign key references Recipe(RecipeID), 
    MeasurementTypeID int null constraint f_MeasurmentType_RecipeIngredient foreign key references MeasurementType(MeasurementTypeID),
    IngredientID int not null constraint f_Ingredient_RecipeIngredient foreign key references Ingredient(IngredientID), 
-- SM Ingredient amount should not allow null. Example: Egg will always have the "1" in the amount but nothing in the measurement. And Pinch of salt is allowed to be 1 pinch salt
    IngredientAmount decimal(5,2) null constraint ck_Recipe_Ingredient_ingredient_amount_must_be_greater_than_0 check(IngredientAmount > 0),
    IngredientSequence int not null constraint ck_Recipe_Ingredient_ingredient_sequence_must_be_greater_than_0 check (IngredientSequence > 0),
-- SM No need for this constraint since IngredientAmount will be changed to not null.
    Constraint ck_Recipe_Ingredient_measurement_typeID_and_ingredient_amount_cannot_both_be_null 
    check (MeasurementTypeID is null and IngredientAmount is not null
    or (MeasurementTypeID is not null and (IngredientAmount is not null or IngredientAmount is null))),
    Constraint u_Recipe_Ingredient_recipeID_and_ingredient_sequence unique(Recipeid, IngredientSequence),
    Constraint u_Recipe_Ingredient_recipeID_and_Ingredient_ID unique(RecipeId, IngredientID)
    )