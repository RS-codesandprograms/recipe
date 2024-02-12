-- This trial combines the MealCourse and MealCourseRecipe tables into one.
 
/*drop table if exists MealCourseRecipeTrial
go 
     
Create table dbo.MealCourseRecipeTrial(
    MealCourseRecipeID int not null identity primary key,
    MealID int not null constraint f_Meal_MealCourseRecipeTrial foreign key references Meal(MealID), 
    CourseID int not null constraint f_Course_MealCourseTrial foreign key references Course(CourseID), 
    RecipeID int not null constraint f_Recipe_MealCourseRecipeTrial foreign key references Recipe(RecipeID),
    Main bit not null, 
    Constraint u_MealCourseRecipeTrial_mealID_and_and_CourseID_and_recipeID unique (mealID, CourseID,  recipeid)
) 
 
delete MealCourseRecipeTrial

;
with x as (
    select MealName = 'Breakfast Bash', CourseName = 'appetizer', RecipeName = 'Apple Yogurt Smoothie', Main = 0
    union select 'Breakfast Bash', 'main', 'Cheese Bread', 1
    union select 'Breakfast Bash', 'main', 'Butter Muffins', 0
    union select 'Super Supper', 'main', 'Sweet Chicken', 1
    union select 'Super Supper', 'main', 'Smoky Spicey Potatoes' , 0
    union select 'Super Supper', 'main', 'Sesame Green Beans', 0
    union select 'Super Supper', 'dessert', 'Chocolate Chip Cookies', 0
    union select 'Dairy Lunch', 'appetizer', 'Apple Yogurt Smoothie', 0
    union select 'Dairy Lunch', 'main', 'Cheese Bread', 1
    union select 'Dairy Lunch', 'main', 'Sesame Green Beans', 0
    union select 'Super Delight', 'appetizer', 'Butter Muffins', 0
    union select 'Super Delight', 'main', 'Cheese Bread', 1
    union select 'Super Delight', 'main', 'Sesame Green Beans', 0
    union select 'Super Delight', 'main', 'Smoky Spicey Potatoes' , 0
    union select 'Super Delight', 'dessert', 'Chocolate Chip Cookies', 0
)
Insert MealCourseRecipeTrial(MealID, CourseID, RecipeID, Main)
select m.MealID, c.CourseID, r.RecipeID, x.Main
from x 
join Meal m 
on x.MealName = m.MealName
join Course c 
on x.CourseName = c.CourseName
join Recipe r 
on x.RecipeName = r.RecipeName

select * 
from MealCourseRecipeTrial



Select m.MealName, s.UserName, count(t.courseID), count(t.RecipeID)
from Meal m
join Staff s 
on s.StaffID = m.StaffID
join MealCourseRecipeTrial t 
on m.MealID = t.MealID
where m.Active = 1
and m.MealName = 'Breakfast Bash' 
group by m.MealName, s.UserName
*/
/* Doesn't solve problem of counting duplicate courseIDs, also this way not able to ensure each meal only has one course/type*/