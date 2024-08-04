exec CuisineTypeGet -- returns none
exec CuisineTypeGet @All = 1 -- returns all

declare @CuisineTypeId int
select @CuisineTypeId = c.CuisineTypeId from CuisineType c 
exec CuisineTypeGet @CuisineTypeId = @CuisineTypeId

declare @CuisineName varchar(50)
select @CuisineName = c.CuisineName from CuisineType c
exec CuisineTypeGet @CuisineName = @CuisineName 