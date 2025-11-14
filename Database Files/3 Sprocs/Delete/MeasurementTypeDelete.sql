create or alter procedure dbo.MeasurementTypeDelete(
	@MeasurementTypeId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @MeasurementTypeId = isnull(@MeasurementTypeId,0)
	begin try 
		begin tran 

			delete ri 
			from RecipeIngredient ri 
			join MeasurementType mt
			on ri.MeasurementTypeID = mt.MeasurementTypeID
			where mt.MeasurementTypeID = @MeasurementTypeId


			delete MeasurementType where MeasurementTypeId = @MeasurementTypeId


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

