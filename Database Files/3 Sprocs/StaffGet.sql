create or alter procedure dbo.StaffGet(
	@StaffId int = 0,
	@All bit = 0,
	@UserName varchar(25)= ''
)
as
begin
	select @UserName = nullif(@UserName, '')
	select s.StaffId, s.FirstName, s.LastName, s.UserName
	from Staff s
	where s.StaffID = @StaffId
	or @All = 1
	or s.UserName like '%' + @UserName + '%'
	order by s.StaffID
end 
go
