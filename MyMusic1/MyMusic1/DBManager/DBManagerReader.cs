using MyMusic1.Models;
using System.Data.SqlClient;

namespace MyMusic1.DBManager
{
    public class DBManagerReader
    {
            private static string connectionString = @"Server = ACADEMYNETPD09\SQLEXPRESS; Database = MyMusic; Trusted_Connection = True;";

            public IEnumerable<ArtistaViwModel> GetAllArtista()
            {
                string sql = @"Select * from Artista";
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand(sql, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    yield return new ArtistaViwModel
                    {
                        IdArtista = Convert.ToInt32(reader["IdArtista"].ToString()),
                        Nome = reader["Nome"].ToString(),
                        Cognome = reader["Cognome"].ToString(),
                        NomeDArte = reader["NomeDArte"].ToString(),
                        Tipo = reader["Tipo"].ToString(),
                    };
                }
            }

            public IEnumerable<BranoViwModel> GetAllBrani()
            {
                string sql = @"Select * from Brano";

                using var connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand(sql, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    yield return new BranoViwModel
                    {
                        IdBrano = Convert.ToInt32(reader["IdBrano"].ToString()),
                        TitoloBrano = reader["Titolo"].ToString(),
                        AnnoUscita = DateTime.Parse(reader["AnnoUscita"].ToString()),
                        Durata = Decimal.Parse(reader["Durata"].ToString()),
                        Genere = reader["Genere"].ToString(),
                    };

                }
            }
            public IEnumerable<BandViwModel> GetAllBand()
            {
                string sql = @"Select * from Band";
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand(sql, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    yield return new BandViwModel
                    {
                        IdBand = Convert.ToInt32(reader["IdBand"].ToString()),
                        NomeBand = reader["Titolo"].ToString(),
                        Immagine = reader["Immagine"].ToString(),
                        Genere = reader["Genere"].ToString(),
                        IdArtistaB = Convert.ToInt32(reader["IdArtista"].ToString()),

                    };
                }



            }
            public IEnumerable<AlbumViwModel> GetAllAlbum()
            {
                string sql = @"Select * from Album";
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand(sql, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    yield return new AlbumViwModel
                    {
                        IdAlbum = Convert.ToInt32(reader["IdAlbum"].ToString()),
                        NomeAlbum = reader["NomeAlbum"].ToString(),
                        AnnoUscitaA = DateTime.Parse(reader["AnnoUScita"].ToString()),
                        IdBranoA = Convert.ToInt32(reader["IdBrano"].ToString()),
                        IdBandA = Convert.ToInt32(reader["IdBand"].ToString()),


                    };
                }
            }

            public IEnumerable<FeaturingViwModel> GetAllFeaturing()
            {
                string sql = @"Select * from Featuring";
                using var connection = new SqlConnection(connectionString);
                connection.Open();
                using var command = new SqlCommand(sql, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    yield return new FeaturingViwModel
                    {
                        IdFeaturing = Convert.ToInt32(reader["IdFeaturing"].ToString()),
                        IdArtistaF = Convert.ToInt32(reader["IdArtista"].ToString()),
                        IdAlbumF = Convert.ToInt32(reader["IdAlbum"].ToString()),


                    };
                }
            }

        }
    }

