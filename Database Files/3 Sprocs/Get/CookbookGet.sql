create or alter procedure dbo.CookbookGet(
	@CookbookId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
)
as
begin

	declare @return int = 0

	select @All = isnull(@All,0), @CookbookId = isnull(@CookbookId,0), @IncludeBlank = ISNULL(@IncludeBlank,0)
	
	select cb.CookbookID, cb.CookbookName, cb.StaffID, cb.Price, cb.CookbookCreationDate, cb.IsActive
	from Cookbook cb
	where --cb.IsActive = 1
	--and
	(cb.CookbookId = @CookbookId
	or @All = 1) 
	union select 0, ' ', 0, 0, null, 0
	where @IncludeBlank = 1
	order by cb.CookbookName

	return @return

end
go


exec CookbookGet @All = 1, @Includeblank = 1