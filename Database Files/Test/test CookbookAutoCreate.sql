
declare @staffid int

select top 1 @staffid = s.StaffId from Staff s join Recipe r on s.StaffID = r.StaffID
select *
from staff s 
where s.StaffID = @staffid


exec CookbookAutoCreate @cookbookid = 0, @Staffid = @staffid, @message = ''


