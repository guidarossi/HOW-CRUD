using System;
using MySql.Data.MySqlClient;

static void MySqlConectorStringBuilder()
{
    MySqlConectorStringBuilder conexaoBD = new MySqlConectorStringBuilder;
    conexaoBD.Server = "localhost";
    conexaoBD.Database = "cadastropizzaria";
    conexaoBD.Userid = "root";
    conexaoBD.Password = "";

}