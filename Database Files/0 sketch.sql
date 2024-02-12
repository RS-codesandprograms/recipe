/*
Staff
    StaffID (pk)
    FirstName varchar(50) not null/not blank 
    LastName varchar(50) not null/not blank
    UserName varchar(25) not null/not blank unique
CuisineType 
    CuisineTypeID (pk)
    CuisineName varchar (50) not null/not blank unique 
MeasurementType
    MeasurementTypeID (pk)
    MeasurementName varchar (25) not null/not blank unique 
Ingredient
    IngredientID (pk)
    IngredientName varchar (50) not null/not blank unique
    IngredientPicture computed as Ingredient-ingredient-name.jpg 
Recipe
    RecipeID (pk)
    StaffID (fk) not null
    CuisineTypeID (fk) not null
    RecipeName varchar (50) not null/not blank unique
    Calories int not null/>=0
    RecipePicture computed as Recipe-recipe-name.jpg
    DraftDate date time not null default to get date 
    PublishedDate date time null 
    ArchivedDate date time null
    CurrentStatus as 
        case
            when getdate() >= draftdate then 'Draft'
            when getdate() >= PublishedDate then 'Published'
            when getdate() >= ArchivedDate then 'Archived'
        end persisted 
RecipeIngredient
    RecipeIngredientID (pk)
    RecipeID (fk) not null
    MeasurementTypeID (fk) null
    IngredientID (fk) not null
    IngredientAmount int not null >0
RecipeDirection
    RecipeDirectionID (pk)
    RecipeID (fk) not null
    DirectionSequence int not null > 0
    Instruction varchar(250) not null/blank
    unique - recipeid, directionsequence 
Course
    CourseID (pk)
    CourseName varchar(25) not null not blank unique
    CourseSequence int not null > 0  unique 
Meal
    MealID (pk)
    StaffID (fk) not null
    MealName varchar(50) not null not blank unique 
    Active bit not null default to inactive
    MealCreationDate date default to getdate()
    MealPicture computed as Meal-meal-name.jpg 
MealCourse
    MealCourseID (pk)
    MealID (fk) not null
    CourseID (fk) not null
    unique -mealID, courseID
MealCourseRecipe
    MealCourseRecipeID (pk)
    MealCourseID (fk) not null
    RecipeID (fk) not null
    Main bit not null
    unique - mealcourseid, recipeid
Cookbook
    CookbookID (pk)
    StaffID (fk) not null
    CookbookName varchar(50) not null/not blank unique
    Price decimal(6,2) not null not blank
    Active bit, not null default to inactive
    CookbookCreationDate not null date default to getdate() 
    BookPicture computed as concat Book-book-name.jpg 
CookBookRecipe
    CookBookRecipieID (pk)
    CookbookID (fk) not null
    RecipeID (fk) not null
    BookRecipeSequence int not null >0
    unique - cookbook, recipe
    unique - cookbook, BookRecipeSequence
*/
 

