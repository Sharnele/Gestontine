using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using GESYNDICAT.MODELE;
using System.IO;

namespace GESYNDICAT.DAO
{
  public  class ParticipantDAO
    {
        
        public static void save(Participant participant)
        { // s'occupe de la l'ajout et de la modification


            if (participant.id == 0)
            {

                OdbcCommand cmd = new OdbcCommand("insert into participer(idad,idop,datep) values(?,?,?)", BDD.getconnection());
                cmd.Parameters.AddWithValue("@z", participant.adherent.id);
                cmd.Parameters.Add("@e", OdbcType.Int).Value = participant.operation.id;
                cmd.Parameters.Add("@t", OdbcType.Date).Value = participant.datep.ToShortDateString();
                
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            else
            {
                OdbcCommand cmd = new OdbcCommand("update participer set idad=?,idop=?,datep=? where id=?", BDD.getconnection());

                cmd.Parameters.Add("@z", OdbcType.Int).Value = participant.adherent.id;
                cmd.Parameters.Add("@e", OdbcType.Int).Value = participant.operation.id;
                cmd.Parameters.Add("@t", OdbcType.Date).Value = participant.datep.ToShortDateString();
                cmd.Parameters.Add("@o", OdbcType.Int).Value = participant.id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }


        }



        public static Participant find(int id)
        {


            Participant participant = null;

            OdbcCommand cmd = new OdbcCommand("select * from participer where id=?", BDD.getconnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = id;
            OdbcDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {


                participant = new Participant() { id = dr.GetInt32(0), adherent = AdherentDAO.find( dr.GetInt32(1)), operation = OperationDAO.find( dr.GetInt32(2)), datep= dr.GetDate(3) };

            }
            cmd.Dispose();
            dr.Close();
            dr.Dispose();
            return participant;



        }
     



        public static List<Participant> findAll()
        {
            List<Participant> participants = new List<Participant>();
            OdbcCommand cmd = new OdbcCommand("select id from paaticipant ", BDD.getconnection());

            OdbcDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Participant participant = find(dr.GetInt32(0));
                participants.Add(participant);

            }
            cmd.Dispose();
            dr.Close();
            dr.Dispose();
            return participants;
        }


        public static void delete(int id)
        {

            OdbcCommand cmd = new OdbcCommand("delete from participant where id=?", BDD.getconnection());
            cmd.Parameters.Add("@id", OdbcType.Int).Value = id;
            cmd.ExecuteNonQuery();
            cmd.Dispose();


        }

        public OdbcDataReader lister()
        {
            OdbcCommand cmd = new OdbcCommand("select * from participant order by id desc ", BDD.getconnection());

            OdbcDataReader resultat = cmd.ExecuteReader();


            return resultat;
        }
    }
}
