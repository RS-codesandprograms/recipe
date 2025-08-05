create or alter function dbo.IsCookbookCreateAllowed(@StaffId int)
returns varchar(72)
as
begin

	declare @value varchar(72) = ''
	if exists(
	Select s.StaffID, concat('Recipes by ', s.Firstname, ' ', s.Lastname)
	from Staff s
	join Cookbook cb
	on s.StaffID = cb.StaffID
	where s.StaffId = @StaffId
	)
	begin
	select @value = 'Cookbook for this user already exists. Cannot create duplicate cookbook.'
	end

	return @value 
end
go



	
