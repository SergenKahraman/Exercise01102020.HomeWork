using Exercise01102020.Common.Abstractions;
using Exercise01102020.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise01102020.HomeWork.App
{
    public partial class frmAdd : Form
    {
        private object obj;
        private BindingList<SporEmployee> SporEmployees;
        private BindingList<Team> teams;

        public frmAdd(object seleceted, BindingList<SporEmployee> sporEmployees)
        {
            InitializeComponent();
            obj = seleceted;
            this.SporEmployees = sporEmployees;

        }
        public frmAdd(object seleceted, BindingList<Team> teams)
        {
            InitializeComponent();
            obj = seleceted;
            this.teams = teams;

        }

        private void frmAddPlayer_Load(object sender, EventArgs e)
        {
            if (obj is SporEmployee)
            {
                cmbPlayers.DataSource = teams;
            }
            else if (obj is Team)
            {
                cmbPlayers.DataSource = SporEmployees;
            }
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (obj is Team team)
            {
                if (cmbPlayers.SelectedItem is Player P)
                {
                    team.AssignPlayers(P);
                }
                else if (cmbPlayers.SelectedItem is Manager M)
                {
                    team.AssignManager(M);
                }
                else if (cmbPlayers.SelectedItem is Coach C)
                {
                    team.AssignCoach(C);
                }
            }
            else if (obj is Player P)
            {
                var selectedTeam = cmbPlayers.SelectedItem as Team;
                P.AddTeam(selectedTeam);
            }
            else if (obj is Coach C)
            {
                var selectedTeam = cmbPlayers.SelectedItem as Team;
                C.AddTeam(selectedTeam);
            }
            else if (obj is Manager M)
            {
                var selectedTeam = cmbPlayers.SelectedItem as Team;
                M.AddTeam(selectedTeam);
            }


            this.Close();
        }
    }
}
