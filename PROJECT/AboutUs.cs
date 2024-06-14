using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void kostSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KostSearch kostsearch = new KostSearch();
            kostsearch.Show();
            this.Hide();
        }

        private void kostCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KostCategories kostcategories = new KostCategories();
            kostcategories.Show();
            this.Hide();
        }

        private void kostRecomendationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KostRecomendationns kostcategories = new KostRecomendationns();
            kostcategories.Show();
            this.Hide();
        }

        private void onlineReservationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnlineReservationForm onlinereservationform = new OnlineReservationForm();
            onlinereservationform.Show();
            this.Hide();
        }

        private void roomAvailabilityCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomAvailabilityCalendar roomavailabilitycalendar = new RoomAvailabilityCalendar();
            roomavailabilitycalendar.Show();
            this.Hide();
        }

        private void userProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfile userprofile = new UserProfile();
            userprofile.Show();
            this.Hide();
        }

        private void privacyAndSecuritySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Privacy_and_Security_Settings privacyandsecuritysetting = new Privacy_and_Security_Settings();
            privacyandsecuritysetting.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void helpAndSupportCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs aboutus = new AboutUs();
            aboutus.Show();
            this.Hide();
        }

        private void helpAndSupportCenterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HelpandSupportCenter helpandsupportcenter = new HelpandSupportCenter();
            helpandsupportcenter.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HomePage homep = new HomePage();
            homep.Show();
            this.Hide();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
