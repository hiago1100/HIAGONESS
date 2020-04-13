use NESS 

CREATE PROCEDURE ExcluirPaciente
(
	@Paciente int
)
as 
begin
	DELETE FROM dbo.Pacientes WHERE IdPaciente = @Paciente;
end


--  @@@@@@@@@@  Execução para teste   @@@@@@@@@@@

-- exec ExcluirPaciente @Paciente = 1