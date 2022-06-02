///////////////////////////////////////////////////////////////////////////////
// Une application developpé par Maxence Hédouin avec l'aide d'Eric FAURE//////
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;

namespace formjdrppe
{
    public static class global
    {
        public static HttpClient client = new HttpClient();

        public static string ipApi = "https://192.168.1.17:45455/"; 

        public static bool ACCES_PROGRAMME = false;

        public static bool isAdmin = false;

        public static int idJoueurConnecte ;

        public static string user;
        public static string pw;

        public static string charaName;

        public static Users ConnectedUser;

        public static string token;


        public static void connexion(bool valid)
        {
            global.ACCES_PROGRAMME = true;
        }

    }
    public class Token
    {
        public string token { get; set; }
        
    }
}
