create or alter proc dbo.MeasurementTypeUpdate(
	@MeasurementTypeId int  output,
	@MeasurementName varchar (25),
	@Message varchar(500) = '' output
) 
as
begin
	declare @return int = 0

	select @MeasurementTypeId = isnull(@MeasurementTypeId,0)
	
	if @MeasurementTypeId = 0
	begin
		insert MeasurementType(MeasurementName)
		values(@MeasurementName)
		
		select @MeasurementTypeId = SCOPE_IDENTITY()
	end
	else
	begin
		update MeasurementType 
		set 
			MeasurementName = @MeasurementName 
		where MeasurementTypeId = @MeasurementTypeId
	end

	finished:
	return @return
end
go

