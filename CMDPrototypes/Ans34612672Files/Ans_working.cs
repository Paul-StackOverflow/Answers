using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDPrototypes.Ans34612672Files
{
    public class Ans_working
    {
        public Ans_working()
        {

        }

        public bool Execute()
        {
            String newName = "";
            SessionClass Session = new SessionClass();
            String tipoRefeicao = "";
            String DataSelecionada = "";
            String refeicaoFinalizada = "";

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vitor\Documents\Visual Studio 2015\Projects\Educational\Educational\App_Data\SchoolPASS.mdf; Integrated Security=True;Connect Timeout=30");
            con.Open();
            string selectUser = "SELECT count (*) from EEAluno where NomeUtilizadorEE='" + newName + "'";
            string res = Convert.ToString(selectUser);
            SqlCommand com = new SqlCommand(selectUser, con);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            con.Close();
            if (temp == 1)
            {
                con.Open();
                string verificaPassword = "select Password from EEAluno where NomeUtilizadorEE='" + newName + "'";
                SqlCommand passCommand = new SqlCommand(verificaPassword, con);
                string password = passCommand.ExecuteScalar().ToString();
                if (password == Session["Pass"]?.ToString())//Nao testado
                {
                    //Inserir refeicao numa tabela nova
                    SqlCommand insert = new SqlCommand("INSERT INTO TabelaRefeicoesEncomendadas (NomePessoa,TipoRefeicao,Data, Finalizada) VALUES (@NomePessoa,@TipoRefeicao,@Data,@Finalizada)", con);
                    //insert.Parameters.Add("@Id", 1);
                    insert.Parameters.AddWithValue("@NomePessoa", newName);
                    insert.Parameters.AddWithValue("@TipoRefeicao", tipoRefeicao);
                    insert.Parameters.AddWithValue("@Data", DataSelecionada);
                    insert.Parameters.AddWithValue("@Finalizada", refeicaoFinalizada);//escreve falso na DB
                    insert.ExecuteNonQuery();
                }
            }
            return true;
        }
     }
    public class SessionClass
    {
        public SessionClass()
        {

        }
        public string this[string index]
        {
            get
            {
                return "";
            }
        }
    }
}
