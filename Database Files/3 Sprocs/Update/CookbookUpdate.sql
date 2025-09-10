create or alter proc dbo.CookbookUpdate(
	@CookbookId int  output,
	@StaffId int,
	@CookbookName varchar (50),
	@Price decimal (6,2),
	@IsActive bit,
	@CookbookCreationDate date,
	@Message varchar(500) = '' output
)
as 
begin 

declare @return int 

select @CookbookId = ISNULL(@CookbookId, 0)

if @CookbookId  = 0
begin 
	insert Cookbook (StaffId, CookbookName, Price, IsActive, CookbookCreationDate)
	values (@StaffId, @CookbookName, @Price, @IsActive, @CookbookCreationDate)
	select @CookbookId = SCOPE_IdENTITY()
end 
else
begin 

	update Cookbook
	set 
	StaffId = @StaffId, 
	CookbookName = @CookbookName, 
	Price = @Price, 
	IsActive = @IsActive, 
	CookbookCreationDate = @CookbookCreationDate
	where CookbookId = @CookbookId
end 
finished: 
return @return 
end 
go 