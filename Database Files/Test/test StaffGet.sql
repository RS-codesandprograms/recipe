exec StaffGet @All = 1 -- returns all
exec StaffGet --returns none
exec StaffGet @UserName = '' -- returns none

declare @UserName varchar(25)
select @UserName = s.UserName from Staff s 
exec StaffGet @UserName = @UserName 

declare @StaffId int
select @StaffId = s.StaffId from Staff s
exec StaffGet @StaffId = @StaffId