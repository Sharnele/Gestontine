using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using GESYNDICAT.MODELE;

namespace GESYNDICAT.DAO
{
   public class BDD
    {
       
        private static OdbcConnection con = null;

        public static OdbcConnection getconnection()
        {
            if (con == null)
            {
                con = new OdbcConnection("dsn=bdsyndicat");
                con.Open();
            }
            return con;
        }
        public static void closeconnection()
        {
            if (con != null)
            {
                con.Close();
                con.Dispose();
                con = null;
            }

        }
    }
}
