create or alter proc dbo.StaffUpdate(
	@StaffId int  output,
	@FirstName varchar (50),
	@LastName varchar (50),
	@UserName varchar (25),
	@Message varchar(500) = '' output
) 
as
begin
	declare @return int = 0

	select @StaffId = isnull(@StaffId,0)
	
	if @StaffId = 0
	begin
		insert Staff(FirstName, LastName, UserName)
		values(@FirstName, @LastName, @UserName)
		
		select @StaffId = SCOPE_IDENTITY()
	end
	else
	begin
		update Staff 
		set 
			FirstName = @FirstName, 
			LastName = @LastName, 
			UserName = @UserName 
		where StaffId = @StaffId
	end

	finished:
	return @return
end
go

