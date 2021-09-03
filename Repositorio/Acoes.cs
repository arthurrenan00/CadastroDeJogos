using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CadastroJogos.Repositorio;
using MySql.Data.MySqlClient;
using CadastroJogos.Models;


namespace CadastroJogos.Repositorio
{
    public class Acoes
    {
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public void CadastrarJogo(Jogo jogo)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tbl_Jogo values(@codjogo, @nomejogo, @versaojogo, @desenvolvedor, @generojogo," +
                " @faixaetaria, @plataforma, @anolanc, @sinopse)", con.ConectarBd());
            cmd.Parameters.Add("@codjogo", MySqlDbType.VarChar).Value = jogo.Cod_Jogo;
            cmd.Parameters.Add("@nomejogo", MySqlDbType.VarChar).Value = jogo.Nome_Jogo;
            cmd.Parameters.Add("@versaojogo", MySqlDbType.VarChar).Value = jogo.Versao_Jogo;
            cmd.Parameters.Add("@desenvolvedor", MySqlDbType.VarChar).Value = jogo.Desenvolvedor;
            cmd.Parameters.Add("@generojogo", MySqlDbType.VarChar).Value = jogo.Genero_Jogo;
            cmd.Parameters.Add("@faixaetaria", MySqlDbType.VarChar).Value = jogo.Faixa_Etaria;
            cmd.Parameters.Add("@plataforma", MySqlDbType.VarChar).Value = jogo.Plataforma;
            cmd.Parameters.Add("@anolanc", MySqlDbType.VarChar).Value = jogo.Ano_Lanc;
            cmd.Parameters.Add("@sinopse", MySqlDbType.VarChar).Value = jogo.Sinopse;
            cmd.ExecuteNonQuery();
            con.DesconectarBd();
        }

        public void CadastrarCliente(Cliente cliente)
        {
            string data_sistema = Convert.ToDateTime(cliente.DtNasc_Cli).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into tbl_Cliente values(@nomecli, @cpfcli, @dtnasccli, @emailcli, @cellcli," +
                " @endecli)", con.ConectarBd());
            cmd.Parameters.Add("@nomecli", MySqlDbType.VarChar).Value = cliente.Nome_Cli;
            cmd.Parameters.Add("@cpfcli", MySqlDbType.VarChar).Value = cliente.Cpf_Cli;
            cmd.Parameters.Add("@dtnasccli", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@emailcli", MySqlDbType.VarChar).Value = cliente.Email_Cli;
            cmd.Parameters.Add("@cellcli", MySqlDbType.VarChar).Value = cliente.Cell_Cli;
            cmd.Parameters.Add("@endecli", MySqlDbType.VarChar).Value = cliente.Ende_Cli;
            cmd.ExecuteNonQuery();
            con.DesconectarBd();
        }

        public void CadastrarFunc(Funcionario func)
        {
            string data_sistema = Convert.ToDateTime(func.DtNasc_Func).ToString("yyyy-MM-dd");
            MySqlCommand cmd = new MySqlCommand("insert into tbl_Func values(@codfunc, @nomefunc, @cpffunc, @rgfunc, @dtnascfunc," +
                " @endefunc, @cellfunc, @emailfunc, @cargofunc)", con.ConectarBd());
            cmd.Parameters.Add("@codfunc", MySqlDbType.VarChar).Value = func.Cod_Func;
            cmd.Parameters.Add("@nomefunc", MySqlDbType.VarChar).Value = func.Nome_Func;
            cmd.Parameters.Add("@cpffunc", MySqlDbType.VarChar).Value = func.Cpf_Func;
            cmd.Parameters.Add("@rgfunc", MySqlDbType.VarChar).Value = func.Rg_Func;
            cmd.Parameters.Add("@dtnascfunc", MySqlDbType.DateTime).Value = data_sistema;
            cmd.Parameters.Add("@endefunc", MySqlDbType.VarChar).Value = func.Ende_Func;
            cmd.Parameters.Add("@cellfunc", MySqlDbType.VarChar).Value = func.Cell_Func;
            cmd.Parameters.Add("@emailfunc", MySqlDbType.VarChar).Value = func.Email_Func;
            cmd.Parameters.Add("@cargofunc", MySqlDbType.VarChar).Value = func.Cargo;
            cmd.ExecuteNonQuery();
            con.DesconectarBd();
        }

    }
}