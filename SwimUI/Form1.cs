using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwimLib;
using System.IO;
using System.Collections;

namespace SwimUI
{
    public partial class Form1 : Form
    {
        ClubsManager clbMngr;
        SwimmersManager swmMngr;
        ArrayList coachMngr;
        ArrayList swimMeetMngr;

        public Form1()
        {
            InitializeComponent();
        }

        public ClubsManager ClubManager
        {
            get
            {
                return clbMngr;
            }
        }

        public SwimmersManager SwimmerManager
        {
            get
            {
                return swmMngr;
            }
        }

        public ArrayList CoachManager
        {
            get
            {
                return coachMngr;
            }
        }

        public ArrayList SwimMeetManager
        {
            get
            {
                return swimMeetMngr;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clbMngr = new ClubsManager();
            swmMngr = new SwimmersManager(clbMngr);
            coachMngr = new ArrayList();
            swimMeetMngr = new ArrayList();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    clbMngr.Load(openFileDialog1.FileName, ",");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                RefreshData();
            }
        }

        private void lsbClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Club)lsbClubs.SelectedItem != null)
            {
                Club club = (Club)lsbClubs.SelectedItem;
                lblClubInfo.Text = club.ToString();
            }
            else
            {
                lblClubInfo.Text = "No clubs selected.";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Club aClub = null;
            AddClubForm frmAddClub = new AddClubForm(aClub);
            DialogResult dr = frmAddClub.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                RefreshData();
            }

        }

        private void loadSwimmersFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    swmMngr.Load(openFileDialog1.FileName, ",");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                RefreshData();
            }

        }

        private void lsbSwimmers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Swimmer)lsbSwimmers.SelectedItem != null)
            {
                Swimmer swimmer = (Swimmer)lsbSwimmers.SelectedItem;
                lblSwimmerInfo.Text = swimmer.ToString();
            }
            else
            {
                lblSwimmerInfo.Text = "No clubs selected.";
            }

        }

        private void btnAddSwimmer_Click(object sender, EventArgs e)
        {
            Swimmer swimmer = null;
            AddSwimmerForm frmAddSwimmer = new AddSwimmerForm(swimmer);
            DialogResult dr = frmAddSwimmer.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                RefreshData();
            }

        }

        private void btnAddCoach_Click(object sender, EventArgs e)
        {
            Coach coach = null;
            AddCoachForm frmAddCoach = new AddCoachForm(coach);
            DialogResult dr = frmAddCoach.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void RefreshData()
        {
            lsbSwimmers.DataSource = null;
            lsbSwimmers.DataSource = swmMngr.Swimmers;
            lsbSwimmers.DisplayMember = "Name";

            lsbClubs.DataSource = null;
            lsbClubs.DataSource = clbMngr.Clubs;
            lsbClubs.DisplayMember = "Name";

            lsbCoaches.DataSource = null;
            lsbCoaches.DataSource = coachMngr;
            lsbCoaches.DisplayMember = "Name";
            
            lsbSwimMeets.DataSource = null;
            lsbSwimMeets.DataSource = swimMeetMngr;
            lsbSwimMeets.DisplayMember = "Name";
        }

        private void lsbCoaches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Coach)lsbCoaches.SelectedItem != null)
            {
                Coach coach = (Coach)lsbCoaches.SelectedItem;
                lblCoachInfo.Text = coach.ToString();
            }
            else
            {
                lblCoachInfo.Text = "No coach selected.";
            }

        }

        private void btnAssignClub_Click(object sender, EventArgs e)
        {
            Coach coach = (Coach)lsbCoaches.SelectedItem;
            if (coach != null)
            {
                AssignClubForm frmAssignClub = new AssignClubForm(coach);
                DialogResult dr = frmAssignClub.ShowDialog(this);

                if (dr == DialogResult.OK)
                {
                    lblCoachInfo.Text = coach.ToString();
                    RefreshData();
                }
            }
            else
            {
                lblCoachInfo.Text = "No coach selected.";
            }

        }

        private void btnAssignClubSwimmer_Click(object sender, EventArgs e)
        {
            Swimmer swimmer = (Swimmer)lsbSwimmers.SelectedItem;
            if (swimmer != null)
            {
                AssignClubForm frmAssignClub = new AssignClubForm(swimmer);
                DialogResult dr = frmAssignClub.ShowDialog(this);

                if (dr == DialogResult.OK)
                {
                    lblSwimmerInfo.Text = swimmer.ToString();
                }
            }
            else
            {
                lblSwimmerInfo.Text = "No swimmer selected.";
            }

        }

        private void btnAssignCoach_Click(object sender, EventArgs e)
        {
            Swimmer swimmer = (Swimmer)lsbSwimmers.SelectedItem;
            if (swimmer != null)
            {
                AssignCoachForm frmAssignClub = new AssignCoachForm(swimmer);
                DialogResult dr = frmAssignClub.ShowDialog(this);

                if (dr == DialogResult.OK)
                {
                    lblSwimmerInfo.Text = swimmer.ToString();
                }
            }
            else
            {
                lblSwimmerInfo.Text = "No swimmer selected.";
            }

        }

        private void createSwimMeetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwimMeet swimMeet = null;
            SwimMeetForm frmCreateSwimMeet = new SwimMeetForm(swimMeet);
            DialogResult dr = frmCreateSwimMeet.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                RefreshData();
            }
        }

        private void lsbSwimMeets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((SwimMeet)lsbSwimMeets.SelectedItem != null)
            {
                SwimMeet swimMeet = (SwimMeet)lsbSwimMeets.SelectedItem;
                lblSwimMeetInfo.Text = swimMeet.ToString();
            }
            else
            {
                lblSwimMeetInfo.Text = "No swim meets selected.";
            }

        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            if ((SwimMeet)lsbSwimMeets.SelectedItem != null)
            {
                SwimMeet swimMeet = (SwimMeet)lsbSwimMeets.SelectedItem;
                AddEventForm frmAddEvent = new AddEventForm(swimMeet);
                DialogResult dr = frmAddEvent.ShowDialog(this);

                if (dr == DialogResult.OK)
                {
                    lblSwimMeetInfo.Text = lsbSwimMeets.SelectedItem.ToString();
                }
            }
            else
            {
                lblSwimMeetInfo.Text = "No swim meets selected.";
            }

        }

        private void btnAssignToEvent_Click(object sender, EventArgs e)
        {
            SwimMeet swimMeet = (SwimMeet)lsbSwimMeets.SelectedItem;
            if (swimMeet != null)
            {
                AssignSwimmersToEventForm frmEvent = new AssignSwimmersToEventForm(swimMeet);
                DialogResult dr = frmEvent.ShowDialog(this);

                if (dr == DialogResult.OK)
                {
                    lblSwimMeetInfo.Text = lsbSwimMeets.SelectedItem.ToString();
                }
            }
            else
            {
                lblSwimMeetInfo.Text = "No swim meets selected.";
            }
        }

        private void btnSeed_Click(object sender, EventArgs e)
        {
            SwimMeet swimMeet = (SwimMeet)lsbSwimMeets.SelectedItem;
            if (swimMeet != null)
            {
                swimMeet.Seed();
                lblSwimMeetInfo.Text = lsbSwimMeets.SelectedItem.ToString();
            }
            else
            {
                lblSwimMeetInfo.Text = "No swim meets selected.";
            }

        }

        private void btnSaveClubs_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    clbMngr.Save(saveFileDialog1.FileName, ",");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnSaveSwimmers_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    swmMngr.Save(saveFileDialog1.FileName, ",");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnSeeSwimmers_Click(object sender, EventArgs e)
        {
            if ((Club)lsbClubs.SelectedItem != null)
            {
                Club club = (Club)lsbClubs.SelectedItem;

                ArrayList swimmerList = new ArrayList();
                foreach(Registrant registrant in club.Registrants)
                {
                    Swimmer swimmer = registrant as Swimmer;
                    if (swimmer != null) swimmerList.Add(swimmer);
                }

                lsbSwimmers.DataSource = null;
                lsbSwimmers.DataSource = swimmerList;
                lsbSwimmers.DisplayMember = "Name";

            }
        }

        private void btnSeeAllSwimmers_Click(object sender, EventArgs e)
        {
            lsbSwimmers.DataSource = null;
            lsbSwimmers.DataSource = swmMngr.Swimmers;
            lsbSwimmers.DisplayMember = "Name";
        }

        private void btnSeeAllCoaches_Click(object sender, EventArgs e)
        {
            lsbCoaches.DataSource = null;
            lsbCoaches.DataSource = coachMngr;
            lsbCoaches.DisplayMember = "Name";

        }

        private void btnSeeCoaches_Click(object sender, EventArgs e)
        {
            if ((Club)lsbClubs.SelectedItem != null)
            {
                Club club = (Club)lsbClubs.SelectedItem;

                ArrayList coachList = new ArrayList();
                foreach (Registrant registrant in club.Registrants)
                {
                    Coach coach = registrant as Coach;
                    if (coach != null) coachList.Add(coach);
                }

                lsbCoaches.DataSource = null;
                lsbCoaches.DataSource = coachList;
                lsbCoaches.DisplayMember = "Name";

            }

        }
    }
}
