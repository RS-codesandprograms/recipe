create or alter procedure dbo.StaffGet(
	@StaffId int = 0,
	@All bit = 0,
	@UserName varchar(25)= '',
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @StaffId = isnull(@StaffId,0), @IncludeBlank = ISNULL(@IncludeBlank,0), @UserName = nullif(@UserName, '')
	
	select s.StaffId, s.FirstName, s.LastName, s.UserName
	from Staff s
	where s.StaffID = @StaffId
	or @All = 1
	or s.UserName like '%' + @UserName + '%'
	union select 0, '', '', ''
	where @IncludeBlank = 1
	order by s.StaffId

	return @return
end 
go


