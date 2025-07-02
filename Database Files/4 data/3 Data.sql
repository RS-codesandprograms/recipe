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
Union Select 'Rachel', 'Stevens', 'RStevens'
Union Select 'Thomas', 'Kelly', 'TKelly'
Union Select 'Anne', 'Chavitz', 'AChavitz'
Union Select 'Lea', 'Green', 'LGreen'


--CuisineType
insert CuisineType(CuisineName)
select 'American'
union select 'French'
union select 'English'
union select 'Chinese'

insert MeasurementType(MeasurementName)
select 'tbsp'
union select 'cup(s)'
union select 'tsp'
union select 'oz'
union select 'clove(s)'
union select 'pinch'
union select 'stick(s)'
union select 'lb'
union select 'cube(s)'
union select 'gram(s)'

insert ingredient
select 'oil'
union select 'chocolate chips'
union select 'egg(s)'
union select 'sugar'
union select 'flour'
union select 'vanilla sugar'
union select 'baking powder'    
union select 'baking soda'
union select 'granny smith apple(s)'
union select 'vanilla yogurt'
union select 'orange juice'
union select 'honey'
union select 'ice cube(s)'
union select 'club bread'
union select 'butter'
union select 'shredded cheese'
union select 'crushed garlic'
union select 'black pepper'
union select 'salt'
union select 'vanilla pudding'
union select 'whipped cream cheese'
union select 'sour cream cheese'
union select 'chicken quarters'
union select 'duck sauce'
union select 'apricot jelly'
union select 'onion powder'
union select 'garlic powder'
union select 'paprika'
union select 'red potato(es)'
union select 'French green beans'
union select 'frozen crushed garlic cubes'
union select 'soy sauce'
union select 'sesame seeds'
union select 'olive oil'
union select 'smoked paprika'
union select 'graham cracker(s)'
union select 'super-sized marshmallow(s)'
union select 'chocolate bar(s)'
union select 'strawberries'
union select 'lemon juice'
union select 'peaches'
union select 'BBQ sauce'


;
with x as(
    Select UserName = 'TKelly', CuisineName = 'American', RecipeName = 'Chocolate Chip Cookies', Calories = 155, DraftDate = '10/15/2017 12:34', PublishedDate = '12/01/2017 8:00', ArchivedDate = null
    Union Select 'RStevens', 'French', 'Apple Yogurt Smoothie', 43, '01/25/2018 16:00', '03/10/2018 14:00', '07/18/2019 8:00'
    Union Select 'LGreen', 'English', 'Cheese Bread', 123, '12/15/2018 9:23', '01/01/2020', null  
    Union Select 'LGreen', 'American', 'Butter Muffins', 95, '04/17/2019 16:15', '05/22/2019 15:23', null 
    Union Select 'AChavitz', 'American', 'Sweet Chicken', 45, '08/25/22 12:00', null, '11/22/22 11:00'
    Union Select 'AChavitz', 'English', 'Smoky Spicy Potatoes' , 78, '08/12/2022 9:34', '01/05/2023 11:56', null 
    Union Select 'RGreenwich', 'French', 'Sesame Green Beans', 32, '10/10/2020 9:15', '12/01/2020 19:00', null 
    Union select 'LGreen', 'American', 'Betty Crocker Smores', 71, '1/12/2023 10:34:45', null, null
    Union select 'AChavitz', 'American', 'Apple Pie', 212, '8/12/2021 10:37:45', null, null
    Union select 'TKelly', 'French', 'Wine Roasted Chicken', 98, '11/12/2021 23:34:45', null, null
	Union Select 'LGreen', 'American', 'Spiced Chicken', 95, '03/17/2025 16:15', '03/22/2025 15:23', '04/20/2025'
    Union Select 'AChavitz', 'American', 'Tangy Chicken', 45, '04/01/2025', '04/10/2025', null
    
	
)
Insert Recipe (StaffID, CuisineTypeID, RecipeName, Calories, DraftDate, PublishedDate, ArchivedDate)
Select s.StaffID, ct.CuisineTypeID, x.RecipeName, x.Calories, x.DraftDate, x.PublishedDate, x.ArchivedDate
from x 
join Staff s 
on x.UserName = s.UserName
join CuisineType ct 
on x.CuisineName = ct.CuisineName



;
with x as (
    Select RecipeName = 'Chocolate Chip Cookies', MeasurementName = 'cup(s)', IngredientName = 'sugar', IngredientAmount =  1, IngredientSequence = 1
    Union Select 'Chocolate Chip Cookies', 'cup(s)', 'oil', 0.5, 2
    Union Select 'Chocolate Chip Cookies', null, 'egg(s)', 3, 3
    Union Select 'Chocolate Chip Cookies', 'cup(s)', 'flour', 2, 4
    Union Select 'Chocolate Chip Cookies', 'tsp', 'vanilla sugar', 1, 5
    Union Select 'Chocolate Chip Cookies', 'tsp', 'baking powder', 2, 6
    Union Select 'Chocolate Chip Cookies', 'tsp', 'baking soda', 0.5, 7
    Union Select 'Chocolate Chip Cookies', 'cup(s)', 'chocolate chips', 1, 8
    Union Select 'Apple Yogurt Smoothie', null, 'granny smith apple(s)', 3, 1
    Union Select 'Apple Yogurt Smoothie', 'cup(s)', 'vanilla yogurt', 2, 2
    Union Select 'Apple Yogurt Smoothie', 'tsp', 'sugar', 2, 3
    Union Select 'Apple Yogurt Smoothie', 'cup(s)', 'orange juice', 0.5, 4
    Union Select 'Apple Yogurt Smoothie', 'tbsp', 'honey', 2, 5
    Union Select 'Apple Yogurt Smoothie', null, 'ice cube(s)', 6, 6
    Union Select 'Cheese Bread', null, 'club bread', 1, 1
    Union Select 'Cheese Bread', 'oz', 'butter', 4, 2
    Union Select 'Cheese Bread', 'oz', 'shredded cheese', 8, 3
    Union Select 'Cheese Bread', 'clove(s)', 'crushed garlic', 2, 4
    Union Select 'Cheese Bread', 'tsp', 'black pepper', 0.25, 5
    Union Select 'Cheese Bread', 'pinch', 'salt', 1, 6
    Union Select 'Butter Muffins', 'stick(s)', 'butter', 1, 1
    Union Select 'Butter Muffins', 'cup(s)', 'sugar', 3, 2
    Union Select 'Butter Muffins', 'tbsp', 'vanilla pudding', 2, 3
    Union Select 'Butter Muffins', null, 'egg(s)', 4, 4
    Union Select 'Butter Muffins', 'oz', 'whipped cream cheese', 8, 5
    Union Select 'Butter Muffins', 'oz', 'sour cream cheese', 8, 6
    Union Select 'Butter Muffins', 'cup(s)', 'flour', 1, 7
    Union Select 'Butter Muffins', 'tsp', 'baking powder', 2, 8
    Union Select 'Sweet Chicken', null, 'chicken quarters', 4, 1
    Union Select 'Sweet Chicken', 'cup(s)', 'duck sauce', 0.25, 2
    Union Select 'Sweet Chicken', 'cup(s)', 'apricot jelly', 0.25, 3
    Union Select 'Sweet Chicken', 'tsp', 'onion powder', 0.25, 4
    Union Select 'Sweet Chicken', 'tsp', 'garlic powder', 0.25, 5
    Union Select 'Sweet Chicken', 'tsp', 'salt', 0.255, 6
    Union Select 'Sweet Chicken', 'tsp', 'paprika', 0.25, 7
    Union Select 'Smoky Spicy Potatoes' , 'lb', 'red potato(es)', 2, 1
    Union Select 'Smoky Spicy Potatoes' , 'tbsp', 'paprika', 1, 2
    Union Select 'Smoky Spicy Potatoes' , 'tbsp', 'onion powder', 1, 3
    Union Select 'Smoky Spicy Potatoes' , 'tsp', 'garlic powder', 1.5, 4
    Union Select 'Smoky Spicy Potatoes' , 'tsp', 'black pepper', 1.5, 5
    Union Select 'Smoky Spicy Potatoes' , 'tbsp', 'smoked paprika', 1, 6
    Union Select 'Smoky Spicy Potatoes' , 'tbsp', 'oil', 3, 7
    Union Select 'Sesame Green Beans', 'lb', 'French green beans', 1, 1
    Union Select 'Sesame Green Beans', null, 'frozen crushed garlic cubes', 3, 2
    Union Select 'Sesame Green Beans', 'tbsp', 'sugar', 1, 3 
    Union Select 'Sesame Green Beans', 'tbsp', 'soy sauce', 3, 4
    Union Select 'Sesame Green Beans', 'tbsp', 'sesame seeds', 2, 5
    Union Select 'Sesame Green Beans', 'tbsp', 'olive oil', 1, 6
    Union Select 'Betty Crocker Smores', null, 'graham cracker(s)', 6, 1
    Union Select 'Betty Crocker Smores', null, 'super-sized marshmallow(s)', 6, 2
    Union Select 'Betty Crocker Smores', null, 'chocolate bar(s)', 1, 3
	Union Select 'Spiced Chicken', null, 'chicken quarters', 4, 1
	Union Select 'Tangy Chicken', null, 'chicken quarters', 4, 1
)
Insert RecipeIngredient (RecipeID, MeasurementTypeID, IngredientID, IngredientAmount, IngredientSequence)
select r.RecipeID, m.MeasurementTypeID, i.IngredientID, x.IngredientAmount, x.IngredientSequence
from x 
join Recipe r 
on x.RecipeName = r.RecipeName
left join MeasurementType m 
on x.MeasurementName = m.MeasurementName
left join Ingredient i 
on x.IngredientName = i.IngredientName

;
with x as (
        select RecipeName = 'Chocolate Chip Cookies', DirectionSequence = 1, Instruction = 'First combine sugar, oil, and eggs in a bowl'
        union select 'Chocolate Chip Cookies', 2, 'mix well'
        union select 'Chocolate Chip Cookies', 3, 'add flour, vanilla sugar, baking powder and baking soda'
        union select 'Chocolate Chip Cookies', 4, 'beat for 5 minutes'
        union select 'Chocolate Chip Cookies', 5, 'add chocolate chips'
        union select 'Chocolate Chip Cookies', 6, 'freeze for 1-2 hours'
        union select 'Chocolate Chip Cookies', 7, 'roll into balls and place spread out on a cookie sheet'
        union select 'Chocolate Chip Cookies', 8, 'bake on 350 for 10 min.'
        union select 'Apple Yogurt Smoothie', 1, 'Peel the apples and dice'
        union select 'Apple Yogurt Smoothie', 2, 'Combine all ingredients in bowl except for apples anice cubes'
        union select 'Apple Yogurt Smoothie', 3, 'mix until smooth'
        union select 'Apple Yogurt Smoothie', 4, 'add apples and ice cubes'
        union select 'Apple Yogurt Smoothie', 5, 'pour into glasses.'
        union select 'Cheese Bread', 1, 'Slit bread every 3/4 inch'
        union select 'Cheese Bread', 2, 'Combine all ingredients in bowl'
        union select 'Cheese Bread', 3, 'fill slits with cheese mixture'
        union select 'Cheese Bread', 4, 'wrap bread into a foil and bake for 30 minutes.'
        union select 'Butter Muffins', 1, 'Cream butter with sugars'
        union select 'Butter Muffins', 2, 'Add eggs and mix well'
        union select 'Butter Muffins', 3, 'Slowly add rest of ingredients and mix well'
        union select 'Butter Muffins', 4, 'fill muffin pans 3/4 full and bake for 30 minutes.'
        union select 'Sweet Chicken', 1, 'Place chicken in 9x13 tin'
        union select 'Sweet Chicken', 2, 'Mix spices.'
        union select 'Sweet Chicken', 3, 'Sprinkle on chicken.'
        union select 'Sweet Chicken', 4, 'Mix duck sauce and jelly.'
        union select 'Sweet Chicken', 5, 'Shmear on chicken.'
        union select 'Sweet Chicken', 6, 'Bake at 350 for 2.5 hours, or until well done.'
        union select 'Smoky Spicy Potatoes', 1, 'wash potatoes'
        union select 'Smoky Spicy Potatoes', 2, 'dice potatoes and place in bag'
        union select 'Smoky Spicy Potatoes', 3, 'pour oil in bag and shake to coat'
        union select 'Smoky Spicy Potatoes', 4, 'add spices and shake to coat'
        union select 'Smoky Spicy Potatoes', 5, 'lay in single layer on baking sheet'
        union select 'Smoky Spicy Potatoes', 6, 'bake at 400 for 45 min or until fork easily spears through'
        union select 'Sesame Green Beans', 1, 'Place sugar, garlic, soy sauce, and oil in a pot and bring to a boil.' 
        union select 'Sesame Green Beans', 2, 'Add green beans and sesame seeds and mix.'
        union select 'Sesame Green Beans', 3, 'Let green beans sauté until they reach desired texture.'
        union select 'Sesame Green Beans', 4, 'If you like green beans soft, bake covered in oven on 350.'
        union select 'Betty Crocker Smores', 1, 'Crack each graham cracker in half.'
        union select 'Betty Crocker Smores', 2, 'Place each graham cracker half on a square of parchment paper.'
        union select 'Betty Crocker Smores', 3, 'On top of the graham cracker half place one piece of chocolate, 1 marshmallow, 1 piece of chocolate and the other graham cracker half on top.'
        union select 'Betty Crocker Smores', 4, 'Wrap in parchment paper and place in Betty Crocker for about 5 minutes or until ready.'
		union select 'Spiced Chicken', 1, 'Place chicken in 9x13 tin'
		union select 'Spiced Chicken', 2, 'Drizzle olive oil over chicken.'
		union select 'Spiced Chicken', 3, 'Mix Spices together to make a mix.'
		union select 'Spiced Chicken', 4, 'Evenly pour spices over chicket.'
		union select 'Tangy Chicken', 1, 'Place chicken in 9x13 tin'
)
Insert RecipeDirection (RecipeID, DirectionSequence, Instruction)
select r.RecipeID, x.DirectionSequence, x.Instruction
from x 
join Recipe r 
on x.RecipeName = r.RecipeName




Insert Course (CourseName,CourseSequence)
select 'appetizer', 1
union select 'main', 2
union select 'dessert', 3
union select 'palate refresher', 4




;
with x as(
    select UserName = 'RGreenwich', MealName = 'Breakfast Bash', IsActive = 1, MealCreationDate = '11/10/2020'
    union select 'TKelly', 'Super Supper', 0, '04/25/2019'
    union select 'AChavitz', 'Dairy Lunch', 1, '05/15/2021'
    union select 'LGreen', 'Super Delight', 1, '3/12/2022'
)
Insert Meal (StaffID, MealName, IsActive, MealCreationDate)
select s.StaffID, x.MealName, x.IsActive, x.MealCreationDate
from x 
join Staff s 
on x.UserName = s.UserName

;
with x as (
    select MealName = 'Breakfast Bash', CourseName = 'appetizer'
    union select 'Breakfast Bash', 'main'
	union select 'Super Supper', 'appetizer'
    union select 'Super Supper', 'main'
    union select 'Super Supper', 'dessert'
    union select 'Dairy Lunch', 'appetizer'
    union select 'Dairy Lunch', 'main'
    union select 'Super Delight', 'appetizer'
    union select 'Super Delight', 'main'
    union select 'Super Delight', 'dessert'
)
Insert MealCourse(MealID, CourseID)
select m.MealID, c.CourseID
from x 
join Meal m
on x.MealName = m.MealName
join Course c 
on x.CourseName = c.CourseName



;
with x as (
    select MealName = 'Breakfast Bash', CourseName = 'appetizer', RecipeName = 'Apple Yogurt Smoothie', IsMain = 0
    union select 'Breakfast Bash', 'main', 'Cheese Bread', 1
    union select 'Breakfast Bash', 'main', 'Butter Muffins', 0
    union select 'Super Supper', 'main', 'Wine Roasted Chicken', 1
    union select 'Super Supper', 'main', 'Smoky Spicy Potatoes' , 0
    union select 'Super Supper', 'main', 'Sesame Green Beans', 0
    union select 'Super Supper', 'dessert', 'Chocolate Chip Cookies', 0
    union select 'Dairy Lunch', 'appetizer', 'Apple Yogurt Smoothie', 0
    union select 'Dairy Lunch', 'main', 'Cheese Bread', 1
    union select 'Dairy Lunch', 'main', 'Sesame Green Beans', 0
    union select 'Super Delight', 'appetizer', 'Butter Muffins', 0
    union select 'Super Delight', 'main', 'Cheese Bread', 1
    union select 'Super Delight', 'main', 'Sesame Green Beans', 0
    union select 'Super Delight', 'main', 'Smoky Spicy Potatoes' , 0
    union select 'Super Delight', 'dessert', 'Chocolate Chip Cookies', 0
)
Insert MealCourseRecipe(MealCourseID, RecipeID, IsMain)
select mc.MealCourseID, r.RecipeID, x.IsMain 
from x 
join meal m 
on x.MealName = m.MealName
join Course c 
on x.CourseName = c.CourseName
join MealCourse mc  
on m.MealID = mc.MealID
and c.CourseID = mc.CourseID
join Recipe r 
on x.RecipeName = r.RecipeName


;  
with x as (
    select UserName = 'LGreen', CookBookName =  'Treats For Two', Price = 30, IsActive = 1, CookbookCreationDate = '12/19/2019'
    union select 'TKelly', 'Today''s Food', 35, 1, '10/25/2020'
    union select 'RStevens', 'English Cooking', 20, 1, '5/18/2019'
    union select 'AChavitz', 'Dairy Delight', 25, 0, '4/22/2018'
)
Insert Cookbook(StaffID, CookBookName, Price, IsActive, CookbookCreationDate)
select  s.StaffID, x.CookBookName, x.Price, x.IsActive, x.CookbookCreationDate
from x 
join Staff s 
on x.UserName = s.UserName




; 
with x as (
    Select CookBookName = 'Treats For Two', RecipeName = 'Chocolate Chip Cookies', BookRecipeSequence = 1
    Union Select 'Treats For Two', 'Apple Yogurt Smoothie', 2
    Union Select 'Treats For Two', 'Cheese Bread', BookRecipeSequence = 3
    Union Select 'Treats For Two', 'Butter Muffins', 4
    Union Select 'Today''s Food', 'Cheese Bread', 1
    Union Select 'Today''s Food', 'Apple Yogurt Smoothie', 2
    Union Select 'Today''s Food', 'Wine Roasted Chicken', 3
    Union Select 'Today''s Food', 'Smoky Spicy Potatoes' , 4
    Union Select 'Today''s Food', 'Sesame Green Beans', 5
    Union Select 'English Cooking', 'Cheese Bread', 1
    Union Select 'English Cooking', 'Smoky Spicy Potatoes' , 2
    Union Select 'Dairy Delight', 'Apple Yogurt Smoothie', 1
    Union Select 'Dairy Delight', 'Cheese Bread', 2
    Union Select 'Dairy Delight', 'Butter Muffins', 3
)
Insert CookBookRecipe(CookBookID, RecipeID, BookRecipeSequence)
select cb.CookbookID, r.RecipeID, x.BookRecipeSequence
from x 
join Cookbook cb 
on x.CookBookName = cb.CookbookName
join Recipe r 
on x.RecipeName = r.RecipeName

--Select * from Staff s 
--Select * from CuisineType ct
--Select * from MeasurementType m 
--Select * from Ingredient i 
--Select * from Recipe r 
--Select * from RecipeIngredient ri
--select * from RecipeDirection rd
--select * from Course c 
--select * from Meal m 
--select * from MealCourse mc 
--select * from MealCourseRecipe mcr
--select * from CookBook cb 
-- select * from CookBookRecipe cbr 