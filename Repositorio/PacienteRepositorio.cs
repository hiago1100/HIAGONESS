// Hiago Domingos de Oliveira
// Prova de capacitação NESS

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using testeNess.Models;


namespace testeNess.Repositorio
{
    public class PacienteRepositorio
    {

        private SqlConnection _con;

        private void Connection()
        {

            string constr = ConfigurationManager.ConnectionStrings["stringConexao"].ToString();
            _con = new SqlConnection(constr);
        }

        // Adicionar Paciente
        public bool AdicionarPaciente(Paciente PacienteObj)
        {
            Connection();

            int i;

            using (SqlCommand command = new SqlCommand("IncluirPaciente", _con))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@NomePaciente", PacienteObj.NomePaciente);
                command.Parameters.AddWithValue("@DataNascimento", PacienteObj.DataNascimento);
                command.Parameters.AddWithValue("@Endereco", PacienteObj.Endereco);
                command.Parameters.AddWithValue("@Telefone", PacienteObj.Telefone);
                command.Parameters.AddWithValue("@Celular", PacienteObj.Celular);
                command.Parameters.AddWithValue("@Email", PacienteObj.Email);
                command.Parameters.AddWithValue("@DataConsulta", PacienteObj.DataConsulta);

                _con.Open();

                i = command.ExecuteNonQuery();

                _con.Close();
                return i >= 1;

            }
        }

        //Obter Pacientes
        public List<Paciente> ObterPacientes()
            {
                Connection();
                List<Paciente> ListaPaciente = new List<Paciente>();

                using (SqlCommand command = new SqlCommand("ObterPacientes", _con))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    _con.Open();                    

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Paciente paciente = new Paciente()
                        {
                            IdPaciente = Convert.ToInt32(reader["IdPaciente"]),
                            NomePaciente = Convert.ToString(reader["NomePaciente"]),
                            DataNascimento = Convert.ToString(reader["DataNascimento"]),
                            Endereco = Convert.ToString(reader["Endereco"]),
                            Telefone = Convert.ToString(reader["Telefone"]),
                            Celular = Convert.ToString(reader["Celular"]),
                            Email = Convert.ToString(reader["Email"]),
                            DataConsulta = Convert.ToString(reader["DataConsulta"])

                        };

                        ListaPaciente.Add(paciente);
                    }

                    _con.Close();
                    return ListaPaciente;
                }
            }



        //Atualizar Paciente
        public bool AtualizarPaciente(Paciente PacienteObj)
        {
            Connection();
           

            using (SqlCommand command = new SqlCommand("AtualizarPaciente", _con))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Paciente", PacienteObj.IdPaciente);
                command.Parameters.AddWithValue("@NomePaciente", PacienteObj.NomePaciente);
                command.Parameters.AddWithValue("@DataNascimento", PacienteObj.DataNascimento);
                command.Parameters.AddWithValue("@Endereco", PacienteObj.Endereco);
                command.Parameters.AddWithValue("@Telefone", PacienteObj.Telefone);
                command.Parameters.AddWithValue("@Celular", PacienteObj.Celular);
                command.Parameters.AddWithValue("@Email", PacienteObj.Email);
                command.Parameters.AddWithValue("@DataConsulta", PacienteObj.DataConsulta);

                _con.Open();

                command.ExecuteNonQuery();

                _con.Close();
                return true;

            }
        }

        //Excluir Time
        public bool DeletarPaciente(int id)
        {
            Connection();


            using (SqlCommand command = new SqlCommand("ExcluirPaciente", _con))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Paciente", id);


                _con.Open();

                command.ExecuteNonQuery();
                _con.Close();
               
                 return true;

            }
        }

        // #################### AGENDAS ##################

        public bool AdicionarConsulta(Paciente DataConsulta)
        {
            Connection();

            int i;

            using (SqlCommand command = new SqlCommand("IncluirConsulta", _con))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Paciente", DataConsulta.IdPaciente);
                command.Parameters.AddWithValue("@DataConsulta", DataConsulta.DataConsulta);

                _con.Open();

                i = command.ExecuteNonQuery();

                _con.Close();
                return i >= 1;

            }
        }

        //Obter Consulta
        public List<Paciente> ObterConsulta()
        {
            Connection();
            List<Paciente> ConsultaLista = new List<Paciente>();

            using (SqlCommand command = new SqlCommand("ObterPacientes", _con))
            {
                command.CommandType = CommandType.StoredProcedure;

                _con.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Paciente paciente = new Paciente()
                    {
                        IdPaciente = Convert.ToInt32(reader["IdPaciente"]),
                        NomePaciente = Convert.ToString(reader["NomePaciente"]),
                        DataNascimento = Convert.ToString(reader["DataNascimento"]),
                        Endereco = Convert.ToString(reader["Endereco"]),
                        Telefone = Convert.ToString(reader["Telefone"]),
                        Celular = Convert.ToString(reader["Celular"]),
                        Email = Convert.ToString(reader["Email"]),
                        DataConsulta = Convert.ToString(reader["DataConsulta"])

                    };

                    ConsultaLista.Add(paciente);
                }

                _con.Close();
                return ConsultaLista;
            }
        }











    }
}

            

    

