CREATE PROCEDURE ObterPacientes

as

begin 

	SELECT * FROM Pacientes 
end

	--  @@@@@@@@@@  Execução para teste   @@@@@@@@@@@

-- exec TOP 1 ObterPacientes

CREATE PROCEDURE Pacientes

as

begin 

	SELECT * FROM Consultas 
end