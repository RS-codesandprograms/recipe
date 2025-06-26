create or alter procedure dbo.CourseGet(
	@CourseId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
)
as
begin

	declare @return int = 0

	select @All = isnull(@All,0), @CourseId = isnull(@CourseId,0), @IncludeBlank = ISNULL(@IncludeBlank,0)
	
	select c.CourseID, c.CourseName, c.CourseSequence
	from Course c
	where c.CourseId = @CourseId
	or @All = 1
	union select 0, '', 0
	where @IncludeBlank = 1
	order by c.CourseId

	return @return

end
go


--exec CourseGet @All = 1, @Includeblank = 1