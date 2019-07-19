using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Assignment2_NguyenVanHa
{
    public partial class Bill : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        DateTime today = DateTime.Today;
        int daysUntilTuesday = -1;

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["AdminStatus"] == true) { btnAdminAccess.Visible = true; }
            if (Session["MovieID"] == null) Server.Transfer("Login.aspx");

            DataSetTableAdapters.MoviesTableAdapter taMovies
               = new DataSetTableAdapters.MoviesTableAdapter();
            taMovies.Fill(ds.Movies);

            DataRow[] drMovies = ds.Movies.Select("MovieID='" + (int)Session["MovieID"] + "'");

            img.Attributes.Add("src", "images/" + drMovies[0]["Poster"]);//Load movies' images
            lblMovieName0.Text = drMovies[0]["MovieTitle"].ToString();//Load movie name
            lblSummary0.Text = drMovies[0]["Summary"].ToString();//Load summary
            lblDuration0.Text = drMovies[0]["Duration"].ToString();//Load duration
            lblReleaseDate0.Text = drMovies[0]["ReleaseDate"].ToString();//Load relase date
            lblIMDB0.Text = drMovies[0]["IMDBRating"].ToString();//Load IMDB rating
            lblGenres0.Text = drMovies[0]["Genres"].ToString();//Load genres
            lblShowtime.Text = (string)Session["Showtime"];

            daysUntilTuesday = (int)Session["DaysUntilTuesday"];
            lblDate.Text = "Today is " + today.DayOfWeek + ", " + today.ToString("dd/MM/yyyy");

            if (daysUntilTuesday != 0) GetOtherDayLayout();
            else GetTuesdayLayout();

            lblDiscount.Text = ((double)Session["Discount"]).ToString();
            lblAmount.Text = "$" + (double)Session["Ammount"];
            lblTax.Text = "$" + (double)Session["Tax"];
            lblTotal.Text = "$" + (double)Session["Total"];

            if (!IsPostBack) { ShowSelectedTickets(); }
        }

        private void ShowSelectedTickets()
        {
            int GeneralQnt = Convert.ToInt32((string)(Session["GeneralAdmission"]));
            int SeniorQnt = Convert.ToInt32((string)(Session["SeniorAdmission"]));
            int TuesdayQnt = Convert.ToInt32((string)(Session["TuesdayAdmission"]));
            
            if (GeneralQnt == 0)
            {
                lblGeneralAdmission.Visible = false;
                Label9.Visible = false;
                lblGeneralAdmissionPrice.Visible = false;
                lblQnt0.Visible = false;
            }  

            if(SeniorQnt == 0)
            {
                lblSeniorAdmission.Visible = false;
                Label10.Visible = false;
                lblAgeAdmissionPrice.Visible = false;
                lblQnt1.Visible = false;
            }

            if(TuesdayQnt == 0)
            {
                lblTues.Visible = false;
                Label11.Visible = false;
                lblTuesdayAdmissionPrice.Visible = false;
                lblQnt2.Visible = false;
                lblTuesDate.Visible = false;
            }
        }

        private void GetTuesdayLayout()
        {
            lblGeneralAdmission.Text = "Tuesday Special";
            lblGeneralAdmissionPrice.Text = "5.00";
            int TuesdayQnt = Convert.ToInt32((string)(Session["TuesdayAdmission"]));
            lblQnt0.Text = TuesdayQnt.ToString() + " x";

            lblQnt1.Text = (string)(Session["SeniorAdmission"]);
        }

        private void GetOtherDayLayout()
        {
             
            DateTime nextTuesday = today.AddDays(daysUntilTuesday);
            
            lblTuesDate.Text = "Ticket is/are valid on " + nextTuesday.ToString("dd/MM/yyyy");
            lblQnt0.Text = (string)(Session["GeneralAdmission"]) + " x";
            lblQnt1.Text = (string)(Session["SeniorAdmission"]) + " x";
            lblQnt2.Text = (string)(Session["TuesdayAdmission"]) + " x";

            lblTues.Visible = true;
            lblTuesdayAdmissionPrice.Visible = true;
            lblTuesDate.Visible = true;
            Label11.Visible = true;
            lblQnt2.Visible = true;
        }

        protected void btnMovieList_Click(object sender, EventArgs e)
        {
            Server.Transfer("MovieList.aspx");
        }

        protected void btnAdminAccess_Click(object sender, EventArgs e)
        {
            Server.Transfer("AdminPage.aspx");
        }
    }
}