use NESS

CREATE PROCEDURE IncluirPaciente
( 
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
	INSERT INTO dbo.Pacientes VALUES  
			(@NomePaciente,@DataNascimento,@Endereco,@Telefone,@Celular,@Email,@DataConsulta)			 
end

--  @@@@@@@@@@  Execução para teste   @@@@@@@@@@@

exec IncluirPaciente 
					 @NomePaciente   = "Hiago Oliveira" ,
					 @DataNascimento = '11/05/1992' ,
					 @Endereco 		 = 'Fanganiello' ,
					 @Telefone       = '1234-5678',
					 @Celular 		 = '98765-4321',
					 @Email			 = 'Teste@teste',	
					 @DataConsulta	 = '11/05/1992'	