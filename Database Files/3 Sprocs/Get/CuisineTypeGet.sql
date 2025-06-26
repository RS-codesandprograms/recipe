create or alter procedure dbo.CuisineTypeGet(
	@CuisineTypeId int = 0,
	@All bit = 0,
	@CuisineName varchar(50) = '',
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
)
as
begin

	declare @return int = 0

	select @All = isnull(@All,0), @CuisineTypeId = isnull(@CuisineTypeId,0), @IncludeBlank = ISNULL(@IncludeBlank,0), @CuisineName = nullif(@CuisineName, '')
	
	select c.CuisineTypeID, c.CuisineName
	from CuisineType c
	where c.CuisineTypeId = @CuisineTypeId
	or @All = 1
	or c.CuisineName like '%' + @CuisineName + '%'
	union select 0, ''
	where @IncludeBlank = 1
	order by c.CuisineTypeID

	return @return

end
go


--exec CuisineTypeGet @All = 1, @Includeblank = 1