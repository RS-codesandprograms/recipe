Use HeartyHearthDB
go 

<<<<<<< Updated upstream
=======
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




Create table dbo.CuisineType(
    CuisineTypeID int not null identity primary key,
    CuisineName varchar (50) not null 
        constraint ck_Cuisine_Type_cuisine_name_cannot_be_blank check(CuisineName <> '')
        constraint u_Cuisine_Type_cuisine_name unique
    )

create table dbo.Staff(
    StaffID int not null identity primary key,
    FirstName varchar(50) not null constraint ck_Staff_first_name_cannot_be_blank check(FirstName <> ''),
    LastName varchar(50) not null constraint ck_Staff_last_name_cannot_be_blank check(LastName <> ''),
    UserName varchar(25) not null 
        constraint ck_Staff_user_name_cannot_be_blank check(UserName <> '')
        constraint u_Staff_user_name unique
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
            when PublishedDate is null and ArchivedDate is null then 'Draft'
            when ArchivedDate is null then 'Published'
            else 'Archived' 
        end,
        RecipePicture as concat('Recipe-', replace(RecipeName,' ', '-'), '.jpg'),
    Constraint ck_Recipe_published_date_must_be_between_draft_date_and_archived_date check(DraftDate < PublishedDate and PublishedDate < ArchivedDate)
    )
go       


--CuisineType
insert CuisineType(CuisineName)
select 'American'
union select 'French'
union select 'English'

--Staff
insert Staff(FirstName, LastName, UserName)
Select 'Robbin', 'Greenwich', 'RGreenwich'
Union Select 'Rachel', 'Stevens', 'RStevens'
Union Select 'Thomas', 'Kelly', 'TKelly'
Union Select 'Anne', 'Chavitz', 'AChavitz'
Union Select 'Lea', 'Green', 'LGreen'

>>>>>>> Stashed changes



;
with x as(
    Select UserName = 'TKelly', CuisineName = 'American', RecipeName = 'Coco Fun', Calories = 155, DraftDate = '10/15/2017 12:34'
    Union Select 'RStevens', 'French', 'French Fries', 250, '01/25/2018 16:00'
    Union Select 'LGreen', 'English', 'Meat Loaf', 123, '12/15/2018 9:23'

)
Insert Recipe (StaffID, CuisineTypeID, RecipeName, Calories, DraftDate)
Select s.StaffID, ct.CuisineTypeID, x.RecipeName, x.Calories, x.DraftDate
from x 
join Staff s 
on x.UserName = s.UserName
join CuisineType ct 
on x.CuisineName = ct.CuisineName





