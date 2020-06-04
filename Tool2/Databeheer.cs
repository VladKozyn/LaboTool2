using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text;
using Tool2.Model;

namespace Tool2
{
    public class Databeheer
    {
        private string connectionString;

        public Databeheer(string connectionString)
        {
            this.connectionString = connectionString;
        }
        private SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog = Labo; Integrated Security = True");
            return connection;
        }



        public void voegProvinciesToe(List<Provincie> provincie)
        {
            SqlConnection connection = GetConnection();
            string query = "INSERT INTO dbo.Provincie (provincieId,provincieNaam) "
                 + "VALUES(@provincieId,@provincieNaam)";
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();
                try
                {
                    command.CommandText = query;


                    command.Parameters.Add(new SqlParameter("@provincieId", SqlDbType.Int));
                    command.Parameters.Add(new SqlParameter("@provincieNaam", SqlDbType.VarChar));


                    foreach (Provincie p in provincie)
                    {

                        command.Parameters["@provincieId"].Value = p.provincieId;
                        command.Parameters["@provincieNaam"].Value = p.provincieNaam;
                        command.ExecuteNonQuery();
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void voegGemeentesToe(List<Gemeente> gemeente)
        {
            SqlConnection connection = GetConnection();
            string query = "INSERT INTO dbo.Gemeente (gemeenteId,gemeenteNaam,totaalAantalStraten,provincieId) "
                 + "VALUES(@gemeenteId,@gemeenteNaam,@totaalAantalStraten,@provincieId)";
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();
                try
                {
                    command.CommandText = query;


                    command.Parameters.Add(new SqlParameter("@gemeenteId", SqlDbType.Int));
                    command.Parameters.Add(new SqlParameter("@gemeenteNaam", SqlDbType.VarChar));
                    command.Parameters.Add(new SqlParameter("@totaalAantalStraten", SqlDbType.Int));
                    command.Parameters.Add(new SqlParameter("@provincieId", SqlDbType.Int));

                    foreach (Gemeente g in gemeente)
                    {

                        command.Parameters["@gemeenteId"].Value = g.gemeenteId;
                        command.Parameters["@gemeenteNaam"].Value = g.gemeenteNaam;
                        command.Parameters["@totaalAantalStraten"].Value = g.totaalAantalStraten;
                        command.Parameters["@provincieId"].Value = g.provincieId;
                        command.ExecuteNonQuery();
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    connection.Close();
                }
            }

        }
        public void voegStratenToe(List<Straat> straat)
        {
            SqlConnection connection = GetConnection();
            string query = "INSERT INTO dbo.Straat (straatId,straatNaam,lengteStraat,gemeenteId) "
                 + "VALUES(@straatId,@gstraatNaam,@lengteStraat,@gemeenteId)";
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();
                try
                {
                    command.CommandText = query;


                    command.Parameters.Add(new SqlParameter("@straatId", SqlDbType.Int));
                    command.Parameters.Add(new SqlParameter("@gstraatNaam", SqlDbType.VarChar));
                    command.Parameters.Add(new SqlParameter("@lengteStraat", SqlDbType.Float));
                    command.Parameters.Add(new SqlParameter("@gemeenteId", SqlDbType.Int));

                    foreach (Straat s in straat)
                    {

                        command.Parameters["@straatId"].Value = s.straatId;
                        command.Parameters["@gstraatNaam"].Value = s.straatNaam;
                        command.Parameters["@lengteStraat"].Value = s.lengteStraat;
                        command.Parameters["@gemeenteId"].Value = s.gemeenteId;
                        command.ExecuteNonQuery();
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void voegGravenToe(List<Graaf> graaf)
        {
            SqlConnection connection = GetConnection();
            string query = "INSERT INTO dbo.Graaf (graafId,straatId) "
                 + "VALUES(@graafId,@straatId)";
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();
                try
                {
                    command.CommandText = query;


                    command.Parameters.Add(new SqlParameter("@graafId", SqlDbType.Int));
                    command.Parameters.Add(new SqlParameter("@straatId", SqlDbType.Int));

                    foreach (Graaf g in graaf)
                    {

                        command.Parameters["@graafId"].Value = g.graafId;
                        command.Parameters["@straatId"].Value = g.straatId;
                        command.ExecuteNonQuery();
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void voegKnopenToe(List<Knoop> knoop)
        {
            SqlConnection connection = GetConnection();
            string query = "INSERT INTO dbo.Knoop (knoopId,puntX,puntY) "
                 + "VALUES(@knoopId,@puntX,@puntY)";
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();
                try
                {
                    command.CommandText = query;


                    command.Parameters.Add(new SqlParameter("@knoopId", SqlDbType.Int));
                    command.Parameters.Add(new SqlParameter("@puntX", SqlDbType.Float));
                    command.Parameters.Add(new SqlParameter("@puntY", SqlDbType.Float));

                    foreach (Knoop k in knoop)
                    {

                        command.Parameters["@knoopId"].Value = k.knoopId;
                        command.Parameters["@puntX"].Value = k.puntX;
                        command.Parameters["@puntY"].Value = k.puntY;
                        command.ExecuteNonQuery();
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void voegKnopen_GravenToe(List<Knoop> knoop)
        {
            SqlConnection connection = GetConnection();
            string query = "INSERT INTO dbo.Graaf_Knoop (graafId,knoopId) "
                 + "VALUES(@graafId,@knoopId)";
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();
                try
                {
                    command.CommandText = query;


                    command.Parameters.Add(new SqlParameter("@graafId", SqlDbType.Int));
                    command.Parameters.Add(new SqlParameter("@knoopId", SqlDbType.Int));

                    foreach (Knoop k in knoop)
                    {

                        command.Parameters["@graafId"].Value = k.graafId;
                        command.Parameters["@knoopId"].Value = k.knoopId;

                        command.ExecuteNonQuery();
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void voegKnoop_SegmentToe(List<Segment> segment)
        {
            SqlConnection connection = GetConnection();
            string query = "INSERT INTO dbo.Knoop_Segment (knoopId,segmentId) "
                 + "VALUES(@knoopId,@segmentId)";
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();
                try
                {
                    command.CommandText = query;


                    command.Parameters.Add(new SqlParameter("@knoopId", SqlDbType.Int));
                    command.Parameters.Add(new SqlParameter("@segmentId", SqlDbType.Int));

                    foreach (Segment s in segment)
                    {

                        command.Parameters["@knoopId"].Value = s.knoopId;
                        command.Parameters["@segmentId"].Value = s.segmentId;

                        command.ExecuteNonQuery();
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void voegSegmentenToe(List<Segment> segment)
        {
            SqlConnection connection = GetConnection();
            string query = "INSERT INTO dbo.Segment (segmentId,beginKnoop,eindKnoop) "
                 + "VALUES(@segmentId,@beginKnoop,@eindKnoop)";
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();
                try
                {
                    command.CommandText = query;


                    command.Parameters.Add(new SqlParameter("@segmentId", SqlDbType.Int));
                    command.Parameters.Add(new SqlParameter("@beginKnoop", SqlDbType.Int));
                    command.Parameters.Add(new SqlParameter("@eindKnoop", SqlDbType.Int));

                    foreach (Segment s in segment)
                    {

                        command.Parameters["@segmentId"].Value = s.segmentId;
                        command.Parameters["@beginKnoop"].Value = s.beginKnoop;
                        command.Parameters["@eindKnoop"].Value = s.eindKnoop;
                        command.ExecuteNonQuery();
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void voegPuntenToe(List<Punt> punt)
        {
            SqlConnection connection = GetConnection();
            string query = "INSERT INTO dbo.Punt (puntX,puntY,segmentId) "
                 + "VALUES(@puntX,@puntY,@segmentId)";
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();
                try
                {
                    command.CommandText = query;


                    command.Parameters.Add(new SqlParameter("@puntX", SqlDbType.Float));
                    command.Parameters.Add(new SqlParameter("@puntY", SqlDbType.Float));
                    command.Parameters.Add(new SqlParameter("@segmentId", SqlDbType.Int));

                    foreach (Punt p in punt)
                    {

                        command.Parameters["@puntX"].Value = p.puntX;
                        command.Parameters["@puntY"].Value = p.puntY;
                        command.Parameters["@segmentId"].Value = p.segmentId;
                        command.ExecuteNonQuery();
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
