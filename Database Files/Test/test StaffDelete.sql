select *
from staff

exec dbo.StaffUpdate
@StaffID = 6,
@FirstName = 'adfa',
@LastName = 'adfa' ,
@UserName = 'adsf'

select *
from staff