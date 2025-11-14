create or alter procedure dbo.CourseDelete(
	@CourseId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CourseId = isnull(@CourseId,0)

	begin try 
		begin tran 

			delete mcr 
			from MealCourseRecipe mcr
			join MealCourse mc
			on mcr.MealCourseID = mc.MealCourseID
			join Meal m 
			on mc.MealID = m.MealID
			join Course c 
			on mc.CourseID = c.CourseID
			where c.CourseID = @CourseId

			delete mc
			from MealCourse mc 
			join Course c 
			on mc.CourseID = c.CourseID
			where c.CourseID = @CourseId

			delete Course where CourseId = @CourseId

		commit 
		end try 
		begin catch
		rollback;
		throw
	end catch

	finished: 



	return @return
end
go

