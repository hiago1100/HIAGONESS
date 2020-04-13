use NESS

CREATE PROCEDURE AtualizarPaciente
(
        @Paciente int,
		@NomePaciente varchar(100)  ,
        @DataNascimento varchar(10) ,
        @Endereco varchar(100)  ,
        @Telefone varchar(20)  ,
        @Celular varchar(20)  ,
        @Email varchar(200) ,
        @DataConsulta varchar(10)
)
as 
begin
	UPDATE dbo.Pacientes SET  
		NomePaciente   = @NomePaciente,
		DataNascimento = @DataNascimento,
		Endereco 	   = @Endereco,
		Telefone	   = @Telefone,
		Celular		   = @Celular,
		Email		   = @Email,
		DataConsulta   = @DataConsulta
	WHERE IdPaciente   = @Paciente 				 
end



--  @@@@@@@@@@  Execução para teste   @@@@@@@@@@@


exec AtualizarPaciente @Paciente       = 2 ,
					 @NomePaciente   = "Hiago Oliveira" ,
					 @DataNascimento = '11/05/1992' ,
					 @Endereco 		 = 'Fanganiello' ,
					 @Telefone       = '1234-5678',
					 @Celular 		 = '98765-4321',
					 @Email			 = 'Teste@teste',
					 @DataConsulta	 = '11/05/1992'	


-- select * from pacientes