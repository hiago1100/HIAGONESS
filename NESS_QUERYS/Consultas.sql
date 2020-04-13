create table Consultas(
        IdConsulta int PRIMARY KEY IDENTITY(1,1),

		NomePaciente varchar(100) ,
		TelefonePaciente varchar(100),
		dataConsulta varchar(10)

)



CREATE PROCEDURE IncluirConsulta
(
		@Paciente int,
        @DataConsulta varchar(10)
)
as 
begin
	UPDATE dbo.Pacientes SET  	 	
		DataConsulta   = @DataConsulta
	WHERE IdPaciente   = @Paciente 				 
end


	exec IncluirConsulta 
					 @Paciente       = 2,
					 @DataConsulta   = '11/05/1992' 

