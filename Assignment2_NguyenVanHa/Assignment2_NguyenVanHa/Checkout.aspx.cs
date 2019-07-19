using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Assignment2_NguyenVanHa
{

    public partial class Checkout : System.Web.UI.Page
    {
        DataSet ds = new DataSet();
        DateTime today = DateTime.Today;
        int daysUntilTuesday = -1;

        static double discount;
        static double amount = 0;
        static double tax = 0;
        static double total = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["AdminStatus"] == true) { btnAdminAccess.Visible = true; }
            if (Session["MovieID"] == null) Server.Transfer("Login.aspx");
            
            DataSetTableAdapters.MoviesTableAdapter taMovies
               = new DataSetTableAdapters.MoviesTableAdapter();
            taMovies.Fill(ds.Movies);

            DataRow[] drMovies = ds.Movies.Select("MovieID='" + (int)Session["MovieID"] + "'");

            if (!IsPostBack)
            {
                this.iframe.Attributes.Add("src", drMovies[0]["YoutubeTrailer"].ToString());//Load movies' trailer
            }
            
            lblMovieName0.Text = drMovies[0]["MovieTitle"].ToString();//Load movie name
            lblSummary0.Text = drMovies[0]["Summary"].ToString();//Load summary
            lblDuration0.Text = drMovies[0]["Duration"].ToString();//Load duration
            lblReleaseDate0.Text = drMovies[0]["ReleaseDate"].ToString();//Load relase date
            lblIMDB0.Text = drMovies[0]["IMDBRating"].ToString();//Load IMDB rating
            lblGenres0.Text = drMovies[0]["Genres"].ToString();//Load genres
            lblShowtime.Text = (string)Session["Showtime"];
            lblDiscount.Text = ((double)Session["Discount"]).ToString();

            daysUntilTuesday = ((int)DayOfWeek.Tuesday - (int)today.DayOfWeek + 7) % 7;
            lblDate.Text = "Today is " + today.DayOfWeek + ", " + today.ToString("dd/MM/yyyy");
            
            
            if (daysUntilTuesday != 0) GetOtherDayLayout();
            else GetTuesdayLayout();
            
            if(!IsPostBack) { amount = 0; tax = 0;total = 0; }

            GetTotalPrice();
        }

        private void GetTuesdayLayout()
        {
            lblTuesOrNot.Visible = false;
            Label9.Visible = false;
            lblGeneralAdmission.Visible = false;
            btnMinus.Visible = false;
            lblQuantity.Visible = false;
            btnAdd.Visible = false;
        }

        private void GetOtherDayLayout()
        {
            
            DateTime nextTuesday = today.AddDays(daysUntilTuesday);
            
            lblDaysTillTues.Text = "Next Tuesday is in " + daysUntilTuesday + " day(s)";
            lblNextTues.Text = "Next tuesday's date is " + nextTuesday.ToString("dd/MM/yyyy");

            lblTues.Visible = true;
            lblTuesdayAdmission.Visible = true;
            lblDaysTillTues.Visible = true;
            lblDaysTillTues.Visible = true;
            lblNextTues.Visible = true;
            btnMinus2.Visible = true;
            lblQuantity2.Visible = true;
            btnAdd2.Visible = true;
            Label11.Visible = true;
        }

        private string AddQuantity(Label lblQuantity, Label lblPrice)
        {
            int quantity = Convert.ToInt32(lblQuantity.Text) + 1;
            amount += Convert.ToDouble(lblPrice.Text);

            int totalQuantity = GetTotalQuantity() + 1;
            int availableQuantity = GetAvailableQuantity();
            if (totalQuantity <= availableQuantity)
            {
                btnShowBill.Attributes.Remove("disabled");
                lblNotEnoughTicket.Visible = false;
            }
            else
            {
                btnShowBill.Attributes.Add("disabled", "true");
                lblNotEnoughTicket.Visible = true;
                lblNotEnoughTicket.Text = "Sorry we only have " + availableQuantity + " ticket(s) left";
            }

            return quantity.ToString();
        }

        private string MinusQuantity(Label lblQuantity, Label lblPrice)
        {
            int quantity = Convert.ToInt32(lblQuantity.Text);
            if (quantity > 0)
            {
                quantity -= 1;
                amount -= Convert.ToDouble(lblPrice.Text);

                int totalQuantity = GetTotalQuantity() - 1;
                int availableQuantity = GetAvailableQuantity();
                if (totalQuantity <= availableQuantity)
                {
                    btnShowBill.Attributes.Remove("disabled");
                    lblNotEnoughTicket.Visible = false;
                }
                else
                {
                    btnShowBill.Attributes.Add("disabled", "true");
                    lblNotEnoughTicket.Visible = true;
                    lblNotEnoughTicket.Text = "Sorry we only have " + availableQuantity + " ticket(s) left";
                }
            }
            
            return quantity.ToString();
        }

        private void GetTotalPrice()
        {
            tax = amount * 0.13;
            total = amount * (1.13 - (double)(Session["Discount"]) / 100);

            lblAmount.Text = "$" + amount;
            lblTax.Text = "$" + tax;
            lblTotal.Text = "$" + total;
        }
        
        protected void btnMinus_Click(object sender, EventArgs e)
        {
            lblQuantity.Text = MinusQuantity(lblQuantity, lblGeneralAdmission);
            GetTotalPrice();
        }

        protected void btnMinus1_Click(object sender, EventArgs e)
        {
            lblQuantity1.Text = MinusQuantity(lblQuantity1, lblAgeAdmission);
            GetTotalPrice();
        }

        protected void btnMinus2_Click(object sender, EventArgs e)
        {
            lblQuantity2.Text = MinusQuantity(lblQuantity2, lblTuesdayAdmission);
            GetTotalPrice();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            lblQuantity.Text = AddQuantity(lblQuantity, lblGeneralAdmission);
            GetTotalPrice();
        }

        protected void btnAdd1_Click(object sender, EventArgs e)
        {
            lblQuantity1.Text = AddQuantity(lblQuantity1, lblAgeAdmission);
            GetTotalPrice();
        }

        protected void btnAdd2_Click(object sender, EventArgs e)
        {
            lblQuantity2.Text = AddQuantity(lblQuantity2, lblTuesdayAdmission);
            GetTotalPrice();
        }

        private int GetTotalQuantity()
        {
            return Convert.ToInt32(lblQuantity.Text) + Convert.ToInt32(lblQuantity1.Text) 
                + Convert.ToInt32(lblQuantity2.Text);
        }

        private int GetAvailableQuantity()
        {
            DataSetTableAdapters.SchedulesTableAdapter taSchedules
                = new DataSetTableAdapters.SchedulesTableAdapter();
            taSchedules.Fill(ds.Schedules);//Get the lateset and put into ds1.Schedules

            DataRow[] drSchedules
                    = ds.Schedules.Select("MovieID='" + (int)Session["MovieID"] + "'");
            int timeIndex = 0;
            for (int index = 0; index < drSchedules.Length; index++)
            {
                if (drSchedules[index]["Showtime"].ToString() == (string)Session["Showtime"])
                    timeIndex = Convert.ToInt32(drSchedules[index]["TimeID"]);
            }
            Session["TimeID"] = timeIndex;

            DataRow[] drTimeID = ds.Schedules.Select("TimeID = '" + timeIndex + "'");
            int remainQnt = Convert.ToInt32(drTimeID[0]["Quantity"]);

            return remainQnt;
        }

        protected void btnShowBill_Click(object sender, EventArgs e)
        {
            Session["Ammount"] = amount;
            Session["Tax"] = tax;
            Session["Total"] = total;
            Session["DaysUntilTuesday"] = daysUntilTuesday;
            Session["GeneralAdmission"] = lblQuantity.Text;
            Session["SeniorAdmission"] = lblQuantity1.Text;
            Session["TuesdayAdmission"] = lblQuantity2.Text;

            DataSet ds1 = new DataSet();
            DataSetTableAdapters.SchedulesTableAdapter taSchedules
                = new DataSetTableAdapters.SchedulesTableAdapter();
            taSchedules.Fill(ds1.Schedules);
            DataRow[] drTimeId = ds1.Schedules.Select("TimeID=" + (int)Session["TimeID"]);//Inside is where clause
            drTimeId[0]["Quantity"] = GetAvailableQuantity() - GetTotalQuantity();
            
            taSchedules.Update(ds1.Schedules);

            Server.Transfer("Bill.aspx");
        }

        protected void btnAdminAccess_Click(object sender, EventArgs e)
        {
            Server.Transfer("AdminPage.aspx");
        }
    }
}