using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHOW
{
    //Minha variavel universal
    public static class Usuario
    {


        private static string e_Email = "";
        public static string Email
        {
            get { return e_Email; }
            set { e_Email = value; }
        } 
        private static string s_Senha = "";
        public static string Senha
        {
            get { return s_Senha; }
            set { s_Senha= value; }
        }
        private static Int32 i_usuarioId;
        

    }
    class Class1
    {
    }
}
