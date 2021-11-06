using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GameLibrary.Models
{
    public class GameRepositoryADO
    {
        List<Game> games = new List<Game>();
        //Temporary game
        Game game = new Game();
        public List<Game> GetAll()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["GameLibrary"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_GetAll";
                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Game game = new Game();
                        game.GameID = (int)dr["GameID"];
                        game.Title = dr["Title"].ToString();
                        if (dr["Genre"] != DBNull.Value)
                        {
                            game.Genre = dr["Genre"].ToString();
                        }
                        else
                        {
                            game.Genre = "";
                        }

                        if (dr["Rating"] != DBNull.Value)
                        {
                            game.Rating = dr["Rating"].ToString();
                        }
                        else
                        {
                            game.Rating = "";
                        }

                        game.Director = dr["Director"].ToString();

                        if (dr["Composer"] != DBNull.Value)
                        {
                            game.Composer = dr["Composer"].ToString();
                        }
                        else
                        {
                            game.Composer = "";
                        }

                        if (dr["Artist"] != DBNull.Value)
                        {
                            game.Artist = dr["Artist"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }

                        game.Company = dr["Company"].ToString();

                        if (dr["Year"] != DBNull.Value)
                        {
                            game.Year = dr["Year"].ToString();
                        }
                        else
                        {
                            game.Year = "";
                        }


                        if (dr["Console"] != DBNull.Value)
                        {
                            game.Console = dr["Console"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }
                        games.Add(game);
                    }
                }
            }
            return games;
        }

        public Game GetByID(int gameID)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["GameLibrary"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_GetByID";
                cmd.Parameters.AddWithValue("@GameID", gameID);
                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Game game = new Game();
                        game.GameID = (int)dr["GameID"];
                        game.Title = dr["Title"].ToString();
                        if (dr["Genre"] != DBNull.Value)
                        {
                            game.Genre = dr["Genre"].ToString();
                        }
                        else
                        {
                            game.Genre = "";
                        }

                        if (dr["Rating"] != DBNull.Value)
                        {
                            game.Rating = dr["Rating"].ToString();
                        }
                        else
                        {
                            game.Rating = "";
                        }

                        game.Director = dr["Director"].ToString();

                        if (dr["Composer"] != DBNull.Value)
                        {
                            game.Composer = dr["Composer"].ToString();
                        }
                        else
                        {
                            game.Composer = "";
                        }

                        if (dr["Artist"] != DBNull.Value)
                        {
                            game.Artist = dr["Artist"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }

                        game.Company = dr["Company"].ToString();

                        if (dr["Year"] != DBNull.Value)
                        {
                            game.Year = dr["Year"].ToString();
                        }
                        else
                        {
                            game.Year = "";
                        }


                        if (dr["Console"] != DBNull.Value)
                        {
                            game.Console = dr["Console"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }
                        return game;
                    }
                }
                
            } return null;

        }

        public List<Game> GetByTitle(string title)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["GameLibrary"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_GetByTitle";
                cmd.Parameters.AddWithValue("@Title", title);
                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Game game = new Game();
                        game.GameID = (int)dr["GameID"];
                        game.Title = dr["Title"].ToString();
                        if (dr["Genre"] != DBNull.Value)
                        {
                            game.Genre = dr["Genre"].ToString();
                        }
                        else
                        {
                            game.Genre = "";
                        }

                        if (dr["Rating"] != DBNull.Value)
                        {
                            game.Rating = dr["Rating"].ToString();
                        }
                        else
                        {
                            game.Rating = "";
                        }

                        game.Director = dr["Director"].ToString();

                        if (dr["Composer"] != DBNull.Value)
                        {
                            game.Composer = dr["Composer"].ToString();
                        }
                        else
                        {
                            game.Composer = "";
                        }

                        if (dr["Artist"] != DBNull.Value)
                        {
                            game.Artist = dr["Artist"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }

                        game.Company = dr["Company"].ToString();

                        if (dr["Year"] != DBNull.Value)
                        {
                            game.Year = dr["Year"].ToString();
                        }
                        else
                        {
                            game.Year = "";
                        }


                        if (dr["Console"] != DBNull.Value)
                        {
                            game.Console = dr["Console"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }
                        games.Add(game);
                    }
                }
            }
            return games;
        }

        public List<Game> GetByGenre(string genre)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["GameLibrary"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_GetByGenre";
                cmd.Parameters.AddWithValue("@Genre", genre);
                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Game game = new Game();
                        game.GameID = (int)dr["GameID"];
                        game.Title = dr["Title"].ToString();
                        if (dr["Genre"] != DBNull.Value)
                        {
                            game.Genre = dr["Genre"].ToString();
                        }
                        else
                        {
                            game.Genre = "";
                        }

                        if (dr["Rating"] != DBNull.Value)
                        {
                            game.Rating = dr["Rating"].ToString();
                        }
                        else
                        {
                            game.Rating = "";
                        }

                        game.Director = dr["Director"].ToString();

                        if (dr["Composer"] != DBNull.Value)
                        {
                            game.Composer = dr["Composer"].ToString();
                        }
                        else
                        {
                            game.Composer = "";
                        }

                        if (dr["Artist"] != DBNull.Value)
                        {
                            game.Artist = dr["Artist"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }

                        game.Company = dr["Company"].ToString();

                        if (dr["Year"] != DBNull.Value)
                        {
                            game.Year = dr["Year"].ToString();
                        }
                        else
                        {
                            game.Year = "";
                        }


                        if (dr["Console"] != DBNull.Value)
                        {
                            game.Console = dr["Console"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }
                        games.Add(game);
                    }
                }
            }
            return games;
        }

        public List<Game> GetByRating(string rating)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["GameLibrary"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_GetByRating";
                cmd.Parameters.AddWithValue("@Rating", rating);
                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Game game = new Game();
                        game.GameID = (int)dr["GameID"];
                        game.Title = dr["Title"].ToString();
                        if (dr["Genre"] != DBNull.Value)
                        {
                            game.Genre = dr["Genre"].ToString();
                        }
                        else
                        {
                            game.Genre = "";
                        }

                        if (dr["Rating"] != DBNull.Value)
                        {
                            game.Rating = dr["Rating"].ToString();
                        }
                        else
                        {
                            game.Rating = "";
                        }

                        game.Director = dr["Director"].ToString();

                        if (dr["Composer"] != DBNull.Value)
                        {
                            game.Composer = dr["Composer"].ToString();
                        }
                        else
                        {
                            game.Composer = "";
                        }

                        if (dr["Artist"] != DBNull.Value)
                        {
                            game.Artist = dr["Artist"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }

                        game.Company = dr["Company"].ToString();

                        if (dr["Year"] != DBNull.Value)
                        {
                            game.Year = dr["Year"].ToString();
                        }
                        else
                        {
                            game.Year = "";
                        }


                        if (dr["Console"] != DBNull.Value)
                        {
                            game.Console = dr["Console"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }
                        games.Add(game);
                    }
                }
            }
            return games;
        }

        public List<Game> GetByDirector(string director)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["GameLibrary"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_GetByDirector";
                cmd.Parameters.AddWithValue("@Director", director);
                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Game game = new Game();
                        game.GameID = (int)dr["GameID"];
                        game.Title = dr["Title"].ToString();
                        if (dr["Genre"] != DBNull.Value)
                        {
                            game.Genre = dr["Genre"].ToString();
                        }
                        else
                        {
                            game.Genre = "";
                        }

                        if (dr["Rating"] != DBNull.Value)
                        {
                            game.Rating = dr["Rating"].ToString();
                        }
                        else
                        {
                            game.Rating = "";
                        }

                        game.Director = dr["Director"].ToString();

                        if (dr["Composer"] != DBNull.Value)
                        {
                            game.Composer = dr["Composer"].ToString();
                        }
                        else
                        {
                            game.Composer = "";
                        }

                        if (dr["Artist"] != DBNull.Value)
                        {
                            game.Artist = dr["Artist"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }

                        game.Company = dr["Company"].ToString();

                        if (dr["Year"] != DBNull.Value)
                        {
                            game.Year = dr["Year"].ToString();
                        }
                        else
                        {
                            game.Year = "";
                        }


                        if (dr["Console"] != DBNull.Value)
                        {
                            game.Console = dr["Console"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }
                        games.Add(game);
                    }
                }
            }
            return games;
        }

        public List<Game> GetByComposer(string composer)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["GameLibrary"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_GetByComposer";
                cmd.Parameters.AddWithValue("@Composer", composer);
                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Game game = new Game();
                        game.GameID = (int)dr["GameID"];
                        game.Title = dr["Title"].ToString();
                        if (dr["Genre"] != DBNull.Value)
                        {
                            game.Genre = dr["Genre"].ToString();
                        }
                        else
                        {
                            game.Genre = "";
                        }

                        if (dr["Rating"] != DBNull.Value)
                        {
                            game.Rating = dr["Rating"].ToString();
                        }
                        else
                        {
                            game.Rating = "";
                        }

                        game.Director = dr["Director"].ToString();

                        if (dr["Composer"] != DBNull.Value)
                        {
                            game.Composer = dr["Composer"].ToString();
                        }
                        else
                        {
                            game.Composer = "";
                        }

                        if (dr["Artist"] != DBNull.Value)
                        {
                            game.Artist = dr["Artist"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }

                        game.Company = dr["Company"].ToString();

                        if (dr["Year"] != DBNull.Value)
                        {
                            game.Year = dr["Year"].ToString();
                        }
                        else
                        {
                            game.Year = "";
                        }


                        if (dr["Console"] != DBNull.Value)
                        {
                            game.Console = dr["Console"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }
                        games.Add(game);
                    }
                }
            }
            return games;
        }

        public List<Game> GetByArtist(string artist)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["GameLibrary"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_GetByArtist";
                cmd.Parameters.AddWithValue("@Artist", artist);
                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Game game = new Game();
                        game.GameID = (int)dr["GameID"];
                        game.Title = dr["Title"].ToString();
                        if (dr["Genre"] != DBNull.Value)
                        {
                            game.Genre = dr["Genre"].ToString();
                        }
                        else
                        {
                            game.Genre = "";
                        }

                        if (dr["Rating"] != DBNull.Value)
                        {
                            game.Rating = dr["Rating"].ToString();
                        }
                        else
                        {
                            game.Rating = "";
                        }

                        game.Director = dr["Director"].ToString();

                        if (dr["Composer"] != DBNull.Value)
                        {
                            game.Composer = dr["Composer"].ToString();
                        }
                        else
                        {
                            game.Composer = "";
                        }

                        if (dr["Artist"] != DBNull.Value)
                        {
                            game.Artist = dr["Artist"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }

                        game.Company = dr["Company"].ToString();

                        if (dr["Year"] != DBNull.Value)
                        {
                            game.Year = dr["Year"].ToString();
                        }
                        else
                        {
                            game.Year = "";
                        }


                        if (dr["Console"] != DBNull.Value)
                        {
                            game.Console = dr["Console"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }
                        games.Add(game);
                    }
                }
            }
            return games;
        }

        public List<Game> GetByCompany(string company)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["GameLibrary"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_GetByCompany";
                cmd.Parameters.AddWithValue("@Company", company);
                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Game game = new Game();
                        game.GameID = (int)dr["GameID"];
                        game.Title = dr["Title"].ToString();
                        if (dr["Genre"] != DBNull.Value)
                        {
                            game.Genre = dr["Genre"].ToString();
                        }
                        else
                        {
                            game.Genre = "";
                        }

                        if (dr["Rating"] != DBNull.Value)
                        {
                            game.Rating = dr["Rating"].ToString();
                        }
                        else
                        {
                            game.Rating = "";
                        }

                        game.Director = dr["Director"].ToString();

                        if (dr["Composer"] != DBNull.Value)
                        {
                            game.Composer = dr["Composer"].ToString();
                        }
                        else
                        {
                            game.Composer = "";
                        }

                        if (dr["Artist"] != DBNull.Value)
                        {
                            game.Artist = dr["Artist"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }

                        game.Company = dr["Company"].ToString();

                        if (dr["Year"] != DBNull.Value)
                        {
                            game.Year = dr["Year"].ToString();
                        }
                        else
                        {
                            game.Year = "";
                        }


                        if (dr["Console"] != DBNull.Value)
                        {
                            game.Console = dr["Console"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }
                        games.Add(game);
                    }
                }
            }
            return games;
        }

        public List<Game> GetByYear(string year)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["GameLibrary"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_GetByYear";
                cmd.Parameters.AddWithValue("@Year", year);
                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Game game = new Game();
                        game.GameID = (int)dr["GameID"];
                        game.Title = dr["Title"].ToString();
                        if (dr["Genre"] != DBNull.Value)
                        {
                            game.Genre = dr["Genre"].ToString();
                        }
                        else
                        {
                            game.Genre = "";
                        }

                        if (dr["Rating"] != DBNull.Value)
                        {
                            game.Rating = dr["Rating"].ToString();
                        }
                        else
                        {
                            game.Rating = "";
                        }

                        game.Director = dr["Director"].ToString();

                        if (dr["Composer"] != DBNull.Value)
                        {
                            game.Composer = dr["Composer"].ToString();
                        }
                        else
                        {
                            game.Composer = "";
                        }

                        if (dr["Artist"] != DBNull.Value)
                        {
                            game.Artist = dr["Artist"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }

                        game.Company = dr["Company"].ToString();

                        if (dr["Year"] != DBNull.Value)
                        {
                            game.Year = dr["Year"].ToString();
                        }
                        else
                        {
                            game.Year = "";
                        }


                        if (dr["Console"] != DBNull.Value)
                        {
                            game.Console = dr["Console"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }
                        games.Add(game);
                    }
                }
            }
            return games;
        }

        public List<Game> GetByConsole(string console)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["GameLibrary"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_GetByConsole";
                cmd.Parameters.AddWithValue("@console", console);
                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Game game = new Game();
                        game.GameID = (int)dr["GameID"];
                        game.Title = dr["Title"].ToString();
                        if (dr["Genre"] != DBNull.Value)
                        {
                            game.Genre = dr["Genre"].ToString();
                        }
                        else
                        {
                            game.Genre = "";
                        }

                        if (dr["Rating"] != DBNull.Value)
                        {
                            game.Rating = dr["Rating"].ToString();
                        }
                        else
                        {
                            game.Rating = "";
                        }

                        game.Director = dr["Director"].ToString();

                        if (dr["Composer"] != DBNull.Value)
                        {
                            game.Composer = dr["Composer"].ToString();
                        }
                        else
                        {
                            game.Composer = "";
                        }

                        if (dr["Artist"] != DBNull.Value)
                        {
                            game.Artist = dr["Artist"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }

                        game.Company = dr["Company"].ToString();

                        if (dr["Year"] != DBNull.Value)
                        {
                            game.Year = dr["Year"].ToString();
                        }
                        else
                        {
                            game.Year = "";
                        }


                        if (dr["Console"] != DBNull.Value)
                        {
                            game.Console = dr["Console"].ToString();
                        }
                        else
                        {
                            game.Artist = "";
                        }
                        games.Add(game);
                    }
                }
            }
            return games;
        }

        public void CreateGame(Game newGame)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["GameLibrary"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_CreateGame";
                cmd.Parameters.AddWithValue("@Title", newGame.Title);
                cmd.Parameters.AddWithValue("@Genre", newGame.Genre);
                cmd.Parameters.AddWithValue("@Rating", newGame.Rating);
                cmd.Parameters.AddWithValue("@Director", newGame.Director);
                cmd.Parameters.AddWithValue("@Composer", newGame.Composer);
                cmd.Parameters.AddWithValue("@Artist", newGame.Artist);
                cmd.Parameters.AddWithValue("@Company", newGame.Company);
                cmd.Parameters.AddWithValue("@Year", newGame.Year);
                cmd.Parameters.AddWithValue("@Console", newGame.Console);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateGame(Game updatedGame)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["GameLibrary"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_UpdateGame";
                cmd.Parameters.AddWithValue("@GameID", updatedGame.GameID);
                cmd.Parameters.AddWithValue("@Title", updatedGame.Title);
                cmd.Parameters.AddWithValue("@Genre", updatedGame.Genre);
                cmd.Parameters.AddWithValue("@Rating", updatedGame.Rating);
                cmd.Parameters.AddWithValue("@Director", updatedGame.Director);
                cmd.Parameters.AddWithValue("@Composer", updatedGame.Composer);
                cmd.Parameters.AddWithValue("@Artist", updatedGame.Artist);
                cmd.Parameters.AddWithValue("@Company", updatedGame.Company);
                cmd.Parameters.AddWithValue("@Year", updatedGame.Year);
                cmd.Parameters.AddWithValue("@Console", updatedGame.Console);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteGame(int gameGameID)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["GameLibrary"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_DeleteGame";
                cmd.Parameters.AddWithValue("@GameID", gameGameID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}