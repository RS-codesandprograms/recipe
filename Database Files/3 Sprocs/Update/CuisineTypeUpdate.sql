create or alter proc dbo.CuisineTypeUpdate(
	@CuisineTypeId int  output,
	@CuisineName varchar (50),
	@Message varchar(500) = '' output
) 
as
begin
	declare @return int = 0

	select @CuisineTypeId = isnull(@CuisineTypeId,0)
	
	if @CuisineTypeId = 0
	begin
		insert CuisineType(CuisineName)
		values(@CuisineName)
		
		select @CuisineTypeId = SCOPE_IDENTITY()
	end
	else
	begin
		update CuisineType 
		set 
			CuisineName = @CuisineName 
		where CuisineTypeId = @CuisineTypeId
	end

	finished:
	return @return
end
go

