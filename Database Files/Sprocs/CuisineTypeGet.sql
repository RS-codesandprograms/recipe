create or alter procedure dbo.CuisineTypeGet(
	@CuisineTypeId int = 0,
	@All bit = 0,
	@CuisineName varchar(50) = ''
)
as
begin
	select @CuisineName = nullif(@CuisineName, '')
	select c.CuisineTypeID, c.CuisineName
	from CuisineType c
	where c.CuisineTypeId = @CuisineTypeId
	or @All = 1
	or c.CuisineName like '%' + @CuisineName + '%'

end
go
