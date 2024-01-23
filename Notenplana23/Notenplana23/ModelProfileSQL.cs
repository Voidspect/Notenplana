using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class ModelProfileSQL:IModelProfile
    {
        private MySqlConnection conn;

        

        void IModelProfile.ausgeben(Profil profil)
        {
            string myConnectionString = "server=127.0.0.1;pwd = root; database = Notenplana; ";//uid=erp;
            conn = new MySqlConnection(myConnectionString);
            MySqlCommand mycommand = conn.CreateCommand();
            string selectString = "SELECT Benutzername,Passwort FROM Profil WHERE Benutzername=" + profil.Benutzername + "AND Passwort =" + profil.Passwort + ";";
            mycommand.CommandText = selectString;
            try
            {
                conn.Open();//Problem
                mycommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        bool IModelProfile.check(string Benutzername, string Passwort)
        {
            throw new NotImplementedException();
        }
    }
}
