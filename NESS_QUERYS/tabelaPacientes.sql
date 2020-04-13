create table Pacientes(
        IdPaciente int PRIMARY KEY IDENTITY(1,1),
		NomePaciente varchar(100)  ,
        DataNascimento varchar(10) ,
        Endereco varchar(100)  ,
        Telefone varchar(20)  ,
        Celular varchar(20)  ,
        Email varchar(200) , 
		DataConsulta varchar(10)
)
