Use HeartyHearthDB
go 




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





