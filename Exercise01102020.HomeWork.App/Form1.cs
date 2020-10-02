using Exercise01102020.Common.Abstractions;
using Exercise01102020.Common.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Exercise01102020.HomeWork.App
{
    public partial class Form1 : Form
    {
        private BindingList<Team> Teams;
        private BindingList<SporEmployee> Players;
        private BindingList<SporEmployee> Coaches;
        private BindingList<SporEmployee> Managers;

        public Form1()
        {
            InitializeComponent();
            Teams = new BindingList<Team>();
            Players = new BindingList<SporEmployee>();
            Coaches = new BindingList<SporEmployee>();
            Managers = new BindingList<SporEmployee>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetLoad();
            RefreshForm();

            
        }


        private void GetLoad()
        {
            var T1 = new Team("Galatasaray");
            var T2 = new Team("Fenerbahçe");
            var T3 = new Team("Beşiktaş");
            Teams.Add(T1);
            Teams.Add(T2);
            Teams.Add(T3);
            lstTeams.DataSource = Teams;

            var P1 = new Player("Sergen", "Kahraman", 1589);
            var P2 = new Player("Emre", "Ertuğrul", 2526);
            var P3 = new Player("Arda", "Turan", 7863);
            var P4 = new Player("Burak", "Yılmaz", 1147);
            Players.Add(P1);
            Players.Add(P2);
            Players.Add(P3);
            Players.Add(P4);
            lstPlayers.DataSource = Players;


            var C1 = new Coach("Hami", "Aktaş");
            var C2 = new Coach("Can", "Perk");
            Coaches.Add(C1);
            Coaches.Add(C2);
            lstCoaches.DataSource = Coaches;

            var M1 = new Manager("Gamze", "Uysal");
            var M2 = new Manager("Ali", "Koç");
            Managers.Add(M1);
            Managers.Add(M2);
            lstManagers.DataSource = Managers;
        }


        private void RefreshForm()
        {
            lstCoaches.SelectedIndex = -1;
            lstManagers.SelectedIndex = -1;
            lstPlayers.SelectedIndex = -1;
            lstTeams.SelectedIndex = -1;
            grbDetails.Visible = false;
        }

        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lstTeams.SelectedIndex > -1)
            {
                ClearAllCompenent();
                lstPlayers.SelectedIndex = -1;
                lstManagers.SelectedIndex = -1;
                lstCoaches.SelectedIndex = -1;

                lblCoachName.Visible = true;
                txtCoachName.Visible = true;
                lblTeamName.Text = "Takım Adı";
                lblManagerName.Text = "Yöneticisi";
                lblCoachName.Text = "Koçu";
                grbDetails.Visible = true;
                lstPlayersForATeam.Visible = true;
                var selected = (lstTeams.SelectedItem as Team);
                txtName.Text = selected.TeamName;
                if (selected.Coach != null)
                {
                    txtCoachName.Text = selected.Coach.FullName;
                }
                if (selected.Manager != null)
                {
                    txtManagerName.Text = selected.Manager.FullName;
                }

                lstPlayersForATeam.DataSource = selected.Players;

            }
            
        }

        private void lstPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlayers.SelectedIndex > -1)
            {
                ClearAllCompenent();
                var selected = lstPlayers.SelectedItem as Player;
                lstTeams.SelectedIndex = -1;
                lstManagers.SelectedIndex = -1;
                lstCoaches.SelectedIndex = -1;
                grbDetails.Visible = true;

                lblCoachName.Visible = true;
                txtCoachName.Visible = true;
                lstPlayersForATeam.Visible = false;
                lblTeamName.Text = "Adı Soyadı";
                lblManagerName.Text = "Lisans No";
                lblCoachName.Text = "Takımı";

                txtName.Text = selected.FullName;
                txtManagerName.Text = selected.LicenseNo.ToString();
                if (selected.Team != null)
                {
                    txtCoachName.Text = selected.Team.TeamName;
                }
                
            }
            
        }

        private void lstCoaches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCoaches.SelectedIndex > -1)
            {
                ClearAllCompenent();
                var selected = lstCoaches.SelectedItem as Coach;
                lstTeams.SelectedIndex = -1;
                lstManagers.SelectedIndex = -1;
                lstPlayers.SelectedIndex = -1;

                grbDetails.Visible = true;
                lstPlayersForATeam.Visible = false;
                lblTeamName.Text = "Adı Soyadı";
                lblManagerName.Text = "Takımı";
                lblCoachName.Visible = false;
                txtCoachName.Visible = false;

                txtName.Text = selected.FullName;

                if (selected.Team != null)
                {
                    txtManagerName.Text = selected.Team.TeamName;
                }
                
            }
        }

        private void lstManagers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstManagers.SelectedIndex > -1)
            {
                ClearAllCompenent();
                var selected = lstManagers.SelectedItem as Manager;
                lstTeams.SelectedIndex = -1;
                lstCoaches.SelectedIndex = -1;
                lstPlayers.SelectedIndex = -1;
                grbDetails.Visible = true;
                lstPlayersForATeam.Visible = false;
                lblTeamName.Text = "Adı Soyadı";
                lblManagerName.Text = "Takımı";
                lblCoachName.Visible = false;
                txtCoachName.Visible = false;

                txtName.Text = selected.FullName;
                
                if (selected.Team != null)
                {
                    txtManagerName.Text = selected.Team.TeamName;
                }
            }
        }



        private void ClearAllCompenent()
        {
            txtCoachName.Clear();
            txtManagerName.Clear();
            txtName.Clear();
        }

        private void oyuncuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var frmAddHelper = new frmAdd(lstTeams.SelectedItem, Players);
            frmAddHelper.ShowDialog();
        }

        private void yöneticiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAddHelper = new frmAdd(lstTeams.SelectedItem, Managers);
            frmAddHelper.ShowDialog();
        }

        private void koçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAddHelper = new frmAdd(lstTeams.SelectedItem, Coaches);
            frmAddHelper.ShowDialog();
        }

        private void takımEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object selected = null;
            if (lstPlayers.SelectedIndex > -1)
            {
                selected = lstPlayers.SelectedItem;
            }
            else if (lstCoaches.SelectedIndex > -1)
            {
                selected = lstCoaches.SelectedItem;
            }
            else if (lstManagers.SelectedIndex > -1)
            {
                selected = lstManagers.SelectedItem;
            }
            var frmAddHelper = new frmAdd(selected, Teams);
            frmAddHelper.ShowDialog();
        }

        private void yeniOyuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAddNewPlayerHelper = new frmAddNew(Players, "Player");
            frmAddNewPlayerHelper.ShowDialog();
        }

        private void yeniKoçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAddNewPlayerHelper = new frmAddNew(Coaches, "Coach");
            frmAddNewPlayerHelper.ShowDialog();
        }

        private void yeniYöneticiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAddNewPlayerHelper = new frmAddNew(Managers, "Manager");
            frmAddNewPlayerHelper.ShowDialog();
        }

        private void yeniTakımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAddNewPlayerHelper = new frmAddNew(Teams, "Team");
            frmAddNewPlayerHelper.ShowDialog();
        }
    }
}