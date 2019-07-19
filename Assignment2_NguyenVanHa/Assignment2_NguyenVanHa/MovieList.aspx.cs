using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Assignment2_NguyenVanHa
{
    public partial class MovieList : System.Web.UI.Page
    {
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if((bool)Session["AdminStatus"] == true) { btnAdminAccess.Visible = true; }

            DataRow[] drMovies = GetMoviesInfo();

            DataSetTableAdapters.SchedulesTableAdapter taSchedules
                = new DataSetTableAdapters.SchedulesTableAdapter();
            taSchedules.Fill(ds.Schedules);
            
            //Pack labels and button for effectiveness 
            //TODO: Ask Dario how to get all tags instead of this
            Image[] images = { img1, img2, img3 };
            Label[] movieNames = { lblMovieName0, lblMovieName1, lblMovieName2 };
            Label[] summaries = { lblSummary0, lblSummary1, lblSummary2 };
            Label[] durations = { lblDuration0, lblDuration1, lblDuration2 };
            Label[] releaseDates = { lblReleaseDate0, lblReleaseDate1, lblReleaseDate2 };
            Label[] IMDB = { lblIMDB0, lblIMDB1, lblIMDB2 };
            Label[] genres = { lblGenres0, lblGenres1, lblGenres2 };
            DropDownList[] showtimes = { drdShowtime0, drdShowtime1, drdShowtime2 };

            for (int index = 0; index < drMovies.Length; index++)
            {
                images[index].Attributes.Add("src", "images/" + drMovies[index]["Poster"]);//Load movies' images
                movieNames[index].Text = drMovies[index]["MovieTitle"].ToString();//Load movie name
                summaries[index].Text = drMovies[index]["Summary"].ToString();//Load summary
                durations[index].Text = drMovies[index]["Duration"].ToString();//Load duration
                releaseDates[index].Text = drMovies[index]["ReleaseDate"].ToString();//Load relase date
                IMDB[index].Text = drMovies[index]["IMDBRating"].ToString();//Load IMDB rating
                genres[index].Text = drMovies[index]["Genres"].ToString();//Load genres

                DataRow[] drSchedules
                    = ds.Schedules.Select("MovieID='" + drMovies[index]["MovieID"] + "'");
                
                for(int x = 0; x < 5; x++)
                {
                    ListItem item = new ListItem(drSchedules[x]["Showtime"].ToString());
                    if(Convert.ToInt32(drSchedules[x]["Quantity"]) == 0)
                    {
                        item.Attributes.Add("disabled", "true");
                    }

                    showtimes[index].Items.Add(item);
                }

            }
        }

        private DataRow[] GetMoviesInfo()
        {
            DataSetTableAdapters.MoviesTableAdapter taMovies
               = new DataSetTableAdapters.MoviesTableAdapter();
            taMovies.Fill(ds.Movies);

            DataRow[] drMovies = ds.Movies.Select();

            return drMovies;
        }

        protected void btnGetTicket0_Click(object sender, EventArgs e)
        {
            DataRow[] drMovies = GetMoviesInfo();

            Session["Showtime"] = drdShowtime0.SelectedItem.Text;
            Session["MovieID"] = drMovies[0]["MovieID"];

            Server.Transfer("Checkout.aspx");
        }

        protected void btnGetTicket1_Click(object sender, EventArgs e)
        {
            DataRow[] drMovies = GetMoviesInfo();

            Session["Showtime"] = drdShowtime1.SelectedItem.Text;
            Session["MovieID"] = drMovies[1]["MovieID"];

            Server.Transfer("Checkout.aspx");
        }

        protected void btnGetTicket2_Click(object sender, EventArgs e)
        {
            DataRow[] drMovies = GetMoviesInfo();

            Session["Showtime"] = drdShowtime2.SelectedItem.Text;
            Session["MovieID"] = drMovies[2]["MovieID"];

            Server.Transfer("Checkout.aspx");
        }

        protected void btnAdminAccess_Click(object sender, EventArgs e)
        {
            Server.Transfer("AdminPage.aspx");
        }
    }
}