Use HeartyHearthDB
go 

drop table if exists CookBookRecipe
go  
drop table if exists Cookbook
go
drop table if exists MealCourseRecipe
go
drop table if exists MealCourse
go
drop table if exists Meal
go
drop table if exists Course 
go
drop table if exists RecipeDirection
go
drop table if exists RecipeIngredient
go
drop table if exists Recipe 
go
drop table if exists Ingredient
go
drop table if exists MeasurementType
go
drop table if exists CuisineType
go
drop table if exists Staff
go


create table dbo.Staff(
    StaffID int not null identity primary key,
    FirstName varchar(50) not null constraint ck_Staff_first_name_cannot_be_blank check(FirstName <> ''),
    LastName varchar(50) not null constraint ck_Staff_last_name_cannot_be_blank check(LastName <> ''),
    UserName varchar(25) not null 
        constraint ck_Staff_user_name_cannot_be_blank check(UserName <> '')
        constraint u_Staff_user_name unique
    )
go

Create table dbo.CuisineType(
    CuisineTypeID int not null identity primary key,
    CuisineName varchar (50) not null 
        constraint ck_Cuisine_Type_cuisine_name_cannot_be_blank check(CuisineName <> '')
        constraint u_Cuisine_Type_cuisine_name unique
    )
Create table dbo.MeasurementType(
    MeasurementTypeID int not null identity primary key,
    MeasurementName varchar(25) not null 
        constraint ck_Measurement_Type_measurement_name_cannot_be_blank check(MeasurementName <> '')
        constraint u_Measurement_Type_measurement_name unique
    )
go

create table dbo.Ingredient(
    IngredientID int not null identity primary key,
    IngredientName varchar(50) not null 
        constraint ck_Ingredient_ingredient_name_cannot_be_blank check(IngredientName <> '')
        constraint u_Ingredient_ingredient_name unique,
    IngredientPicture as concat('Ingredient-', replace(IngredientName,' ', '-'), '.jpg')
    )
go

Create table dbo.Recipe(
    RecipeID int not null identity primary key,
    StaffID int not null constraint f_Staff_Recipe foreign key references Staff(StaffID),
    CuisineTypeID int not null constraint f_CuisineType_Recipe foreign key references CuisineType(CuisineTypeID),
    RecipeName varchar(50) not null 
        constraint ck_Recipe_recipe_name_cannot_be_blank check(RecipeName <> '')
        constraint u_Recipe_recipe_name unique,
    Calories int not null constraint ck_Recipe_calories_must_be_greater_than_0 check (Calories > 0), 
    DraftDate datetime not null default getdate()
        constraint ck_Recipe_draft_date_cannot_be_future_date check(DraftDate <= getdate()),
    PublishedDate datetime null
        constraint ck_Recipe_published_date_cannot_be_future_date check(PublishedDate <= getdate()), 
    ArchivedDate datetime null
        constraint ck_Recipe_archived_date_cannot_be_future_date check (ArchivedDate <= getdate()), 
    CurrentStatus as 
        case
            /* when PublishedDate is null and ArchivedDate is null then 'Draft'
            when ArchivedDate is null then 'Published'
            else 'Archived'  */
			when PublishedDate is null and ArchivedDate is null then 'Draft'
			when DraftDate > PublishedDate and DraftDate > ArchivedDate then 'Draft'
			when PublishedDate > DraftDate and PublishedDate > ArchivedDate then 'Published'
			when PublishedDate > DraftDate and ArchivedDate is null then 'Published'
			when ArchivedDate > DraftDate and ArchivedDate > PublishedDate then 'Archived'
			when ArchivedDate > DraftDate and PublishedDate is null then 'Archived'
        end persisted,
        RecipePicture as concat('Recipe-', replace(RecipeName,' ', '-'), '.jpg'),
    Constraint ck_Recipe_published_date_must_be_between_draft_date_and_archived_date check(DraftDate < PublishedDate and PublishedDate < ArchivedDate)
    )
go       

Create table dbo.RecipeIngredient(
    RecipeIngredientID int not null identity primary key,
    RecipeID int not null constraint f_Recipe_RecipeIngredient foreign key references Recipe(RecipeID), 
    MeasurementTypeID int null constraint f_MeasurmentType_RecipeIngredient foreign key references MeasurementType(MeasurementTypeID),
    IngredientID int not null constraint f_Ingredient_RecipeIngredient foreign key references Ingredient(IngredientID), 
    IngredientAmount decimal(5,2) not null constraint ck_Recipe_Ingredient_ingredient_amount_must_be_greater_than_0 check(IngredientAmount > 0),
    IngredientSequence int not null constraint ck_Recipe_Ingredient_ingredient_sequence_must_be_greater_than_0 check (IngredientSequence > 0),
    Constraint u_Recipe_Ingredient_recipeID_and_ingredient_sequence unique(Recipeid, IngredientSequence),
    Constraint u_Recipe_Ingredient_recipeID_and_Ingredient_ID unique(RecipeId, IngredientID)
    )

Create table dbo.RecipeDirection(
    RecipeDirectionID int not null identity primary key, 
    RecipeID int not null constraint f_Recipe_RecipeDirection foreign key references Recipe(RecipeID), 
    DirectionSequence int not null constraint ck_Recipe_Direction_direction_sequence_must_be_greater_than_0 check(DirectionSequence > 0),
    Instruction varchar(250) not null constraint ck_Recipe_Direction_instruction_may_not_be_blank check(Instruction <> ''), 
    Constraint u_Recipe_Direction_recipeid_and_direction_sequence unique (recipeid, directionsequence) 
    )
go

Create table dbo.Course(
    CourseID int not null identity primary key,    
    CourseName varchar(25) not null 
        constraint ck_Course_course_name_may_not_be_blank check(CourseName <> '')
        constraint u_Course_course_name unique,
    CourseSequence int not null 
        constraint ck_Course_course_sequence_must_be_greater_than_0 check (CourseSequence > 0)
        constraint u_Course_course_sequence  unique 
    )
go

Create table dbo.Meal(
    MealID int not null identity primary key,
    StaffID int not null constraint f_Staff_Meal foreign key references Staff(StaffID),
    MealName varchar(50) not null 
        constraint ck_Meal_meal_name_may_not_be_blank check(MealName <> '') 
        constraint u_Meal_mealname unique, 
    IsActive bit not null default 1,
    MealCreationDate date not null  default  getdate(),
    MealPicture as concat('Meal-', replace(MealName,' ', '-'), '.jpg')
    )
go

Create table dbo.MealCourse(
    MealCourseID int not null identity primary key, 
    MealID int not null constraint f_Meal_MealCourse foreign key references Meal(MealID), 
    CourseID int not null constraint f_Course_MealCourse foreign key references Course(CourseID), 
    Constraint u_MealCourse_meal_and_course unique (mealID, courseID)
    )
go

Create table dbo.MealCourseRecipe(
    MealCourseRecipeID int not null identity primary key,
    MealCourseID int not null constraint f_MealCourse_MealCourseRecipe foreign key references MealCourse(MealCourseID),
    RecipeID int not null constraint f_Recipe_MealCourseRecipe foreign key references Recipe(RecipeID),
    IsMain bit not null default 0, 
    Constraint u_MealCourseRecipe_mealcourseID_and_recipeID unique (mealcourseid, recipeid)
)
go

Create table dbo.Cookbook(
    CookbookID int not null identity primary key,
    StaffID int not null constraint f_Staff_Cookbook foreign key references Staff(StaffID), 
    CookbookName varchar(50) not null 
        constraint ck_Cookbook_cookbook_name_may_not_be_bank check(CookbookName <> '')
        constraint u_Cookbook_cookbook_name  unique,
    Price decimal(6,2) not null constraint ck_Cookbook_price_must_be_greater_than_0 check(Price > 0), 
    IsActive bit not null default 1, 
    CookbookCreationDate date not null  default getdate(),
    BookPicture as concat('Book-', replace(CookBookName,' ', '-'), '.jpg')
    )
go
 
Create table dbo.CookBookRecipe(
    CookBookRecipeID int not null identity primary key,
    CookbookID int not null constraint f_Cookbook_CookBookRecipe foreign key references CookBook(CookbookID), 
    RecipeID int not null constraint f_Recipe_CookBookRecipe foreign key references Recipe(RecipeID),  
    BookRecipeSequence int not null constraint ck_Cook_Book_Recipe_book_recipe_sequence_must_be_greater_than_0 check(BookRecipeSequence > 0),  
    Constraint u_CookBookRecipe_cookbook_and_recipe unique(CookBookID, RecipeID), 
    Constraint u_CookBookRecipe_cookbook_and_bookrecipesequence unique (CookBookID, BookRecipeSequence)
)
go
