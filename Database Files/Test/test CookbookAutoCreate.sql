declare @staffid int 
select top 1 @staffid = staffid from Staff 

declare @return int, @message varchar (100)
exec @return = CookbookAutoCreate @Cookbookid = 0, @staffid = @staffid, @Message = @message output 
select @return, @message
