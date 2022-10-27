using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using GESYNDICAT.MODELE;
using GESYNDICAT.VUE;

namespace GESYNDICAT.DAO
{
   public class AdherentDAO
    {
       
         public static void save(Adherent adherent)
        { // s'occupe de la l'ajout et de la modification
            
            if (adherent.id == 0)
            {
           
                OdbcCommand cmd = new OdbcCommand("insert into adherent(nom,prenom,datenaiss,lieunaiss,sexe,numcni,tel) values(?,?,?,?,?,?,?)", BDD.getconnection());
               
                cmd.Parameters.Add("@z", OdbcType.VarChar).Value = adherent.nom  ;
                cmd.Parameters.Add("@e", OdbcType.VarChar).Value = adherent.prenom;
                cmd.Parameters.Add("@t", OdbcType.VarChar).Value = adherent.datenaiss;
                cmd.Parameters.Add("@j", OdbcType.VarChar).Value = adherent.lieunaiss;
                cmd.Parameters.Add("@f", OdbcType.VarChar).Value = adherent.sexe;
                 cmd.Parameters.Add("@a", OdbcType.Int).Value = adherent.numcni;
                cmd.Parameters.Add("@e", OdbcType.VarChar).Value = adherent.tel;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
               
            }
            else
            {
                OdbcCommand cmd = new OdbcCommand("update adherent set nom=?,prenom=?,datenaiss=?,lieunaiss=?,sexe=?,numcni=?,tel=? where id=?", BDD.getconnection());
               
                cmd.Parameters.Add("@z", OdbcType.VarChar).Value = adherent.nom;
                cmd.Parameters.Add("@e", OdbcType.VarChar).Value = adherent.prenom;
                cmd.Parameters.Add("@t", OdbcType.VarChar).Value = adherent.datenaiss;
                cmd.Parameters.Add("@j", OdbcType.VarChar).Value = adherent.lieunaiss;
                cmd.Parameters.Add("@f", OdbcType.VarChar).Value = adherent.sexe;
                cmd.Parameters.Add("@a", OdbcType.Int).Value = adherent.numcni;
                cmd.Parameters.Add("@e", OdbcType.VarChar).Value = adherent.tel;
                cmd.Parameters.Add("@o", OdbcType.Int).Value = adherent.id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            

        }

        public static Adherent findLast()
        {
            Adherent adherent = null;
            OdbcCommand cmd = new OdbcCommand("select max(id) from adherent", BDD.getconnection());
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                adherent = find(dr.GetInt32(0));
            }
            cmd.Dispose();
            dr.Dispose();
            return adherent;
        }

        public static void delete(int id)
        {

            OdbcCommand cmd = new OdbcCommand("delete from adherent where id=?", BDD.getconnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();


        }

       public      OdbcDataReader lister() 
         {
             OdbcCommand cmd = new OdbcCommand("select * from Adherent order by id desc ", BDD.getconnection());

        OdbcDataReader resultat  = cmd.ExecuteReader();


        return resultat;
         }
         
        public static Adherent find(int id)
        {

           
                Adherent adherent = null;

                OdbcCommand cmd = new OdbcCommand("select * from adherent where id=?", BDD.getconnection());
                cmd.Parameters.Add("@id", OdbcType.Int).Value = id;
                OdbcDataReader dr = cmd.ExecuteReader();
               
                if (dr.Read())
                {
                    
            
                    adherent = new Adherent() { id = dr.GetInt32(0), nom = dr.GetString(1), prenom = dr.GetString(2), datenaiss = dr.GetString(3), lieunaiss = dr.GetString(4), sexe = dr.GetString(5), numcni = dr.GetInt32(6), tel = dr.GetString(7) };

                }
                cmd.Dispose();
                dr.Close();
                dr.Dispose();
                return adherent;
           
            

        }

       
        public static List<Adherent> findAll()
        {
            List<Adherent> adherents = new List<Adherent>();
            OdbcCommand cmd = new OdbcCommand("select id from Adherent ", BDD.getconnection());

            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Adherent adherent = find(dr.GetInt32(0));
                adherents.Add(adherent);

            }
            cmd.Dispose();
            dr.Close();
            dr.Dispose();
            return adherents;
        }

       
        public static Adherent find2(string nom)//recherche parport au nom de l'adherent
        {
            Adherent adherent= null;

            OdbcCommand cmd = new OdbcCommand("select * from adherent where nom = ? ", BDD.getconnection());
            cmd.Parameters.Add("@nom", OdbcType.VarChar).Value = nom;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                adherent = new Adherent() { id = dr.GetInt32(0), nom = dr.GetString(1), prenom = dr.GetString(2), datenaiss = dr.GetString(3), lieunaiss = dr.GetString(4), sexe = dr.GetString(5), numcni = dr.GetInt32(6), tel = dr.GetString(7) };

            }
            cmd.Dispose();
            dr.Close();
            
  
            return adherent;

        }

       
        public static int compter()
        {
            OdbcCommand cmd = new OdbcCommand("select Count(id) from Adherent ", BDD.getconnection());
            int cpteur = -1;
            OdbcDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cpteur = dr.GetInt32(0);

            }
            cmd.Dispose();
            dr.Close();
            dr.Dispose();
            return cpteur;
        }
    }
    }

