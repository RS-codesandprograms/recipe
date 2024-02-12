Use HeartyHearthDB
go 

go
delete CookBookRecipe
go
delete cookbook
go
delete MealCourseRecipe
go
delete MealCourse
go 
delete Meal 
go
delete Course 
go
delete RecipeDirection
go 
delete RecipeIngredient
go
delete Recipe
go
delete Ingredient
go
delete MeasurementType
go
delete CuisineType
go
delete Staff 
go 


--Staff
insert Staff(FirstName, LastName, UserName)
Select 'Robbin', 'Greenwich', 'RGreenwich'

-- Test Data
--FirstName null
--Union Select null 
--FirstName Blank
--Union Select ''
--LastName null
--Union Select 'Kathy', null
--LastName blank
--Union Select 'Kathy', ''
-- UserName null
--Union Select 'Kathy', 'Stevens', null
--UserName Blank
--union Select 'Kathy', 'Stevens', ''  
--UserName unique
--Union Select 'Kathy', 'Stevens', 'KStevens'
--Union Select 'Katie', 'Stevens', 'KStevens' 
--Select * from Staff

--CuisineType
insert CuisineType(CuisineName)
select 'American'

--Test Data
--CuisineType null
--union select null
--CuisineType blank
--union select ''
--CuisineType unique
--union select 'English'
--union all select 'English'
--Select * from CuisineType 

insert MeasurementType(MeasurementName)
select 'tablespoon'
--Test Data
--MeasurementName Null
--union select null
--MeasurementName Blank
--union select ''
--MeasurementName Unique
--union select 'teaspoon'
--union all select 'teaspoon'
--select * from MeasurementType

insert ingredient
select 'oil'
union select 'chocolate chips'
union select 'egg(s)'
union select 'flour'
--Test Data
--IngredientName null
--union select null 
--IngredientName blank
--union select ''
--IngredientName unique
--union select 'flour'
--union all select 'flour'
--select * from Ingredient

 
Insert Recipe (StaffID, CuisineTypeID, RecipeName, Calories, DraftDate, PublishedDate, ArchivedDate)
Select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), (select c.CuisineTypeID from CuisineType c where c.CuisineName = 'American'), 'The Best Cookies', 150, '1/21/22 3:34', '2/15/22 2:10', '3/25/22 5:23'


--Test Data
--StaffID null
--union select null
--CuisineTypeID null
--union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), null
--RecipeName null
--union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), (select c.CuisineTypeID from CuisineType c where c.CuisineName = 'American'), null 
--RecipeName blank
--union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), (select c.CuisineTypeID from CuisineType c where c.CuisineName = 'American'), ''
--RecipeName unique
--union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), (select c.CuisineTypeID from CuisineType c where c.CuisineName = 'American'), 'Cake' 
--union all select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), (select c.CuisineTypeID from CuisineType c where c.CuisineName = 'American'), 'Cake' 
--Calories Null
--union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), (select c.CuisineTypeID from CuisineType c where c.CuisineName = 'American'), 'Cake', null
--Calories >= 0
--union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), (select c.CuisineTypeID from CuisineType c where c.CuisineName = 'American'), 'Cake', -1
--DraftDate not null
--union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), (select c.CuisineTypeID from CuisineType c where c.CuisineName = 'American'), 'Cake', 125, null 
--DraftDate cannot be future date
--DraftDate cannot be future date
--union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), (select c.CuisineTypeID from CuisineType c where c.CuisineName = 'American'), 'Cake', 125, '12/12/9999', null, null 
--PuplishedDate cannot be future date
--union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), (select c.CuisineTypeID from CuisineType c where c.CuisineName = 'American'), 'Cake', 125, '11/15/2020 9:00:00', '12/12/9999', null 
--ArchivedDate cannot be future date
--union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), (select c.CuisineTypeID from CuisineType c where c.CuisineName = 'American'), 'Cake', 125, '11/15/2020 9:00:00', null, '12/12/9999'
--ck_Recipe_draft_date_must_be_before_published_date_and_published_date_must_be_before_archived_date
--union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), (select c.CuisineTypeID from CuisineType c where c.CuisineName = 'American'), 'Fruit Salad', 34, '01/01/2020', '12/30/2019', null
--union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), (select c.CuisineTypeID from CuisineType c where c.CuisineName = 'American'), 'Fruit Salad', 34, '01/01/2020', '03/01/2020', '02/01/2020' 
--union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), (select c.CuisineTypeID from CuisineType c where c.CuisineName = 'American'), 'Fruit Salad', 34, '01/01/2020', '02/01/2020', '12/30/2019'

--select * from Recipe

--RecipeIngredient

Insert RecipeIngredient (RecipeID, MeasurementTypeID, IngredientID, IngredientAmount, IngredientSequence)
Select (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), null, (select i.IngredientID from Ingredient i where i.IngredientName = 'egg(s)'), 3, 1

--Test Data
--RecipeID not null 
--union select null 
-- IngredientID null 
--union select (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'),null, null
-- IngredientAmount null
--Union select (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), null, (select i.IngredientID from Ingredient i where i.IngredientName = 'egg(s)'), null 
--IngredientAmount >0
--union select (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), null, (select i.IngredientID from Ingredient i where i.IngredientName = 'egg(s)'), 0
--recipe measurement id and ingredient amount both not null; should work
--union select (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), (select m.MeasurementTypeID from MeasurementType m where m.MeasurementName = 'tablespoon'), (select i.IngredientID from Ingredient i where i.IngredientName = 'oil'), 3
--recipe measurement id and ingredient amount both null; should not work
--union select (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), null, (select i.IngredientID from Ingredient i where i.IngredientName = 'oil'), null
-- measurementid not null ingredient amount null; should work
--union select (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), (select m.MeasurementTypeID from MeasurementType m where m.MeasurementName = 'tablespoon'), (select i.IngredientID from Ingredient i where i.IngredientName = 'oil'), null 
--measurementid null, ingredient amount not null; should work
--union select (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), null, (select i.IngredientID from Ingredient i where i.IngredientName = 'oil'), 2
--IngredientSequence must be > 0
--Union Select (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), null, (select i.IngredientID from Ingredient i where i.IngredientName = 'egg(s)'), 3, 0
--  u_Recipe_Ingredient_recipeID_and_ingredient_sequence 
--Union Select (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), (select m.MeasurementTypeID from MeasurementType m where m.MeasurementName = 'tablespoon'), (select i.IngredientID from Ingredient i where i.IngredientName = 'oil'), 3, 1
--Test unique constraint recipeId and ingredientID
-- Select (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), null, (select i.IngredientID from Ingredient i where i.IngredientName = 'oil'), 3, 10
-- union all  Select  (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), null, (select i.IngredientID from Ingredient i where i.IngredientName = 'oil'), 3, 11

 
--Select * from RecipeIngredient


Insert RecipeDirection (RecipeID, DirectionSequence, Instruction)
Select (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), 1, 'Combine sugar, oil and eggs in a bowl and mix well'

--Test Data
--RecipeID null 
--union select null
--DirectionSequence null
--union select (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), null 
--DirectionSequence >0
--union select (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), 0
--Instruction null
--union select (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), 2, null 
--Instruction blank 
--union select (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), 2, ''
--u_Recipe_Direction_recipeid_and_direction_sequence
--union select (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), 3, 'Combine sugar, oil and eggs in a bowl and mix well'
--union all select (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), 3, 'Combine sugar, oil and eggs in a bowl and mix well'


--select * from RecipeDirection

Insert Course (CourseName,CourseSequence)
select 'appetizer', 1


--test data
--CourseName not null
--union select null 
--CourseName not blank
--union select ''
--CourseName unique 
--union select 'main'
--union all select 'main'
--CourseSequence not null
--union select 'main', null
--CourseSequence > 0
--union select 'main', 0
--Course Sequence unique
--union select 'main', 1
--select * from Course 


Insert Meal (StaffID, MealName, IsActive, MealCreationDate)
select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), 'Breakfast Bash', 1, '10/15/2012'

--Test Data
--StaffID not null 
--union select null 
--MealName not null
--union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), null 
--MealName not blank
--union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), ''
--MealName unique
--union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), 'Best Brunch'
--union all select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), 'Best Brunch'
--IsActive not null 
--union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), 'Best Brunch', null
--MealCreationDate not null  
--union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), 'Best Brunch', 0, null 
--select * from Meal


Insert MealCourse(MealID, CourseID)
select (select m.MealID from Meal m where m.MealName = 'Breakfast Bash'), (select c.CourseID from Course c where c.CourseName = 'appetizer')

--test data
--MealID not null 
--union select null
-- CourseID not null  
--union select (select m.MealID from Meal m where m.MealName = 'Breakfast Bash'), null 
--u_MealCourse_meal_and_course
--union all select (select m.MealID from Meal m where m.MealName = 'Breakfast Bash'), (select c.CourseID from Course c where c.CourseName = 'appetizer')

--select * from MealCourse

Insert MealCourseRecipe(MealCourseID, RecipeID, IsMain)
select 
    (select mc.MealCourseID 
    from MealCourse mc 
    join Meal m 
    on m.mealID = mc.MealID 
    join Course c 
    on c.CourseID = mc.CourseID
    where m.MealName = 'Breakfast Bash'
    and c.CourseName =  'appetizer' ),
    (select r.recipeID from Recipe r where RecipeName = 'The Best Cookies'), 0 
    

--test data
--MealCourseID not null
--union select null
--RecipeID not null
/*union select 
    (select mc.MealCourseID 
    from MealCourse mc 
    join Meal m 
    on m.mealID = mc.MealID 
    join Course c 
    on c.CourseID = mc.CourseID
    where m.MealName = 'Breakfast Bash'
    and c.CourseName =  'appetizer' ), null */
    --IsMain not null
   /* union select 
    (select mc.MealCourseID 
    from MealCourse mc 
    join Meal m 
    on m.mealID = mc.MealID 
    join Course c 
    on c.CourseID = mc.CourseID
    where m.MealName = 'Breakfast Bash'
    and c.CourseName =  'appetizer' ),
    (select r.recipeID from Recipe r where RecipeName = 'The Best Cookies'), null */
    --u_MealCourseRecipe_mealcourseID_and_recipeID
    /*union all select 
    (select mc.MealCourseID 
    from MealCourse mc 
    join Meal m 
    on m.mealID = mc.MealID 
    join Course c 
    on c.CourseID = mc.CourseID
    where m.MealName = 'Breakfast Bash'
    and c.CourseName =  'appetizer' ),
    (select r.recipeID from Recipe r where RecipeName = 'The Best Cookies'), 0 */

--select * from MealCourseRecipe

Insert Cookbook(StaffID, CookBookName, Price, IsActive, CookbookCreationDate)
Select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), 'Cooks'' Delight', 45, 1, '4/18/2013'

--Test Data
--StaffID not null 
--union Select null 
--CookbookName not null
--Union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), null 
--CookbookName not blank
--Union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'),  ''
--CookbookName unique
--Union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), 'Best Cooking'
--Union all select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), 'Best Cooking'
-- Price not null
--Union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'), 'Best Cooking', null
--Price > 0 
--Union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'),  'Best Cooking', 0
-- IsActive not null 
--Union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'),  'Best Cooking', 25, null
-- CookbookCreationDate not null
--Union select (select s.StaffID from Staff s where s.UserName = 'RGreenwich'),  'Best Cooking', 25, 0, null 
--select * from Cookbook 

Insert CookBookRecipe(CookBookID, RecipeID, BookRecipeSequence)
Select (select cb.CookBookID from Cookbook cb where cb.CookbookName = 'Cooks'' Delight'), (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), 23

--Test Data
--CookBookID not null 
--union select null
--RecipeID not null
--union select  (select cb.CookBookID from Cookbook cb where cb.CookbookName = 'Cooks'' Delight'),null
--BookRecipeSequence not null
--union select (select cb.CookBookID from Cookbook cb where cb.CookbookName = 'Cooks'' Delight'), (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), null 
--BookRecipeSequence >0 
--union select (select cb.CookBookID from Cookbook cb where cb.CookbookName = 'Cooks'' Delight'), (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), 0
--u_CookBookRecipe_cookbook_and_recipe
--union select (select cb.CookBookID from Cookbook cb where cb.CookbookName = 'Cooks'' Delight'), (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), 14
--u_CookBookRecipe_cookbook_and_bookrecipesequence
--union all select (select cb.CookBookID from Cookbook cb where cb.CookbookName = 'Cooks'' Delight'), (select r.RecipeID from Recipe r where r.RecipeName = 'The Best Cookies'), 23

--select * from CookBookRecipe

