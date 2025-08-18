create or alter proc dbo.CookbookUpdate(
	@CookbookID int  output,
	@StaffID int,
	@CookbookName varchar (50),
	@Price decimal,
	@IsActive bit,
	@CookbookCreationDate date,
	@Message varchar(500) = '' output
)
as 
begin 

declare @return int 

select @CookbookID = ISNULL(@CookbookID, 0)

if @CookbookID  = 0
begin 
	insert Cookbook (StaffID, CookbookName, Price, IsActive, CookbookCreationDate)
	values (@StaffID, @CookbookName, @Price, @IsActive, @CookbookCreationDate)
	select @CookbookID = SCOPE_IDENTITY()
end 
else
begin 

	update Cookbook
	set 
	StaffID = @StaffID, 
	CookbookName = @CookbookName, 
	Price = @Price, 
	IsActive = @IsActive, 
	CookbookCreationDate = @CookbookCreationDate
	where CookbookID = @CookbookID
end 
finished: 
return @return 
end 
go 