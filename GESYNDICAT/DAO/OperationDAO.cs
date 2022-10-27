using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using GESYNDICAT.MODELE;

namespace GESYNDICAT.DAO
{
   public  class OperationDAO
    {
        Operation operation = new Operation();
        public static void save(Operation operation)
        { // s'occupe de la l'ajout et de la modification

            if (operation.id == 0)
            {

                OdbcCommand cmd = new OdbcCommand("insert into operation(montant,taux,type) values(?,?,?)", BDD.getconnection());

                cmd.Parameters.Add("@z", OdbcType.Double).Value = operation.montant;
                cmd.Parameters.Add("@e", OdbcType.Double).Value = operation.taux;
                cmd.Parameters.Add("@j", OdbcType.VarChar).Value = operation.type;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            else
            {
                OdbcCommand cmd = new OdbcCommand("update operation set montant=?,taux=?,type=? where id=?", BDD.getconnection());

                cmd.Parameters.Add("@z", OdbcType.Double).Value = operation.montant;
                cmd.Parameters.Add("@e", OdbcType.Double).Value = operation.taux;
                cmd.Parameters.Add("@j", OdbcType.VarChar).Value = operation.type;
                cmd.Parameters.Add("@o", OdbcType.Int).Value = operation.id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }


        }



        public static Operation findLast(string cbtype)
        {
            Operation operation = null;


            OdbcCommand cmd = new OdbcCommand("select max(id) from operation where type = '" + cbtype + " ' ", BDD.getconnection());
            cmd.Parameters.Add("@id", OdbcType.VarChar).Value = cbtype;
                OdbcDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                   
                        operation = find(dr.GetInt32(0));
                         
                }    
            cmd.Dispose();
            dr.Dispose();
          
            return operation;
        }

        public static void delete(int id)
        {

            OdbcCommand cmd = new OdbcCommand("delete from operation where id=?", BDD.getconnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();


        }

        public OdbcDataReader lister()
        {
            OdbcCommand cmd = new OdbcCommand("select * from operation order by id desc ", BDD.getconnection());

            OdbcDataReader resultat = cmd.ExecuteReader();


            return resultat;
        }

        public static void initialiseoperation(int report, string cbtype)
        {
            OdbcCommand cmd = new OdbcCommand("insert into operation(report,type) values('" + report + " ','" + cbtype + " ' )", BDD.getconnection());

            cmd.Parameters.Add("@t", OdbcType.Double).Value = report;
            cmd.Parameters.Add("@j", OdbcType.VarChar).Value = cbtype;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }


        public static List<Operation> findAll()
        {
            List<Operation> operations = new List<Operation>();
            OdbcCommand cmd = new OdbcCommand("select id from operation ", BDD.getconnection());

            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Operation operation = find(dr.GetInt32(0));
                operations.Add(operation);

            }
            cmd.Dispose();
            dr.Close();
            dr.Dispose();
            return operations;
        }


        public static Operation findmontan( string cbtype)
        {
           
            Operation operation = null;
            operation = new Operation();
            //operation = findLast(cbtype);

            OdbcCommand cmd = new OdbcCommand("select sum(report) from operation where type = '" + cbtype + " ' ", BDD.getconnection());
            cmd.Parameters.Add("@id", OdbcType.VarChar).Value = cbtype;
            OdbcDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {


                operation = find(dr.GetInt32(0));

            }
            cmd.Dispose();
            dr.Close();
            dr.Dispose();
            return operation;
        }

        public static Operation find(int id)
        {


            Operation operation = null;

            OdbcCommand cmd = new OdbcCommand("select * from operation where id=?", BDD.getconnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = id;
            OdbcDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {


                operation = new Operation() { id = dr.GetInt32(0), montant = dr.GetInt32(1), taux= dr.GetInt32(2), type = dr.GetString(3)};
            }
            cmd.Dispose();
            dr.Close();
            dr.Dispose();
            return operation;
        }

        public static Operation find2(string type)
        {
            Operation operation = null;

            OdbcCommand cmd = new OdbcCommand("select * from operation where type = ? ", BDD.getconnection());
            cmd.Parameters.Add("@id", OdbcType.VarChar).Value = type;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                operation = new Operation() { id = dr.GetInt32(0), montant = dr.GetInt32(1), taux = dr.GetInt32(2), type = dr.GetString(3) };
            }
            cmd.Dispose();
            dr.Close();
            dr.Dispose();
            return operation;



        }
     


        


       

    }
}
