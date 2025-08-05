declare @BaseRecipeid int 
select top 1 @BaseRecipeid = recipeid from Recipe  
select @BaseRecipeid

declare @return int, @message varchar (100)
exec @return = RecipeClone @BaseRecipeid = @BaseRecipeid
select @return, @message


