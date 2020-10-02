using Exercise01102020.Common.Abstractions;
using Exercise01102020.Common.Models;
using System;
using System.CodeDom;
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
    public partial class frmAddNew : Form
    {
        private BindingList<SporEmployee> SporEmployees;
        private BindingList<Team> Teams;
        private string KeyWord;
        public frmAddNew(BindingList<SporEmployee> sporEmployees, string keyWord)
        {
            InitializeComponent();
            this.SporEmployees = sporEmployees;
            KeyWord = keyWord;
        }
        public frmAddNew(BindingList<Team> teams, string keyWord)
        {
            InitializeComponent();
            Teams = teams;
            KeyWord = keyWord;
        }
        private void frmAddNew_Load(object sender, EventArgs e)
        {
            switch (KeyWord)
            {
                case "Player":
                    PlayerVisibility();
                    break;
                case "Coach":
                    CoachVisibility();
                    break;
                case "Manager":
                    ManagerVisibility();
                    break;
                case "Team":
                    TeamVisibility();
                    break;
                default:
                    throw new Exception("Keyword yanlış gönderilmiştir");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (KeyWord)
            {
                case "Player":
                    AddNewPlayer();
                    break;
                case "Coach":
                    AddNewCoach();
                    break;
                case "Manager":
                    AddNewManager();
                    break;
                case "Team":
                    AddNewTeam();
                    break;
                default:
                    throw new Exception("Keyword yanlış gönderilmiştir");
            }
            
            this.Close();
        }

        private void AddNewTeam()
        {
            

            var T = new Team(txtFirstName.Text);
            Teams.Add(T);
        }

        private void AddNewManager()
        {
            

            var M = new Manager(txtFirstName.Text, txtLastName.Text);
            SporEmployees.Add(M);
        }

        private void AddNewCoach()
        {
            
            var C = new Coach(txtFirstName.Text, txtLastName.Text);
            SporEmployees.Add(C);
        }

        private void AddNewPlayer()
        {
            

            erpWarning.Clear();
            Player P;
            try
            {
                P = new Player(txtFirstName.Text, txtLastName.Text, Convert.ToInt32(txtLicenseNo.Text));
            }
            catch
            {
                erpWarning.SetError(txtLicenseNo, "Lütfen sayısal bir değer giriniz!");
                txtLicenseNo.Clear();
                txtLicenseNo.Focus();
                txtLicenseNo.Focus();
                return;
            }

            SporEmployees.Add(P);
        }
        private void PlayerVisibility()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            txtFirstName.Visible = true;
            txtLastName.Visible = true;
            txtLicenseNo.Visible = true;
        }

        private void CoachVisibility()
        {
            label3.Visible = false;
            label2.Visible = true;
            label1.Visible = true;

            txtFirstName.Visible = true;
            txtLastName.Visible = true;
            txtLicenseNo.Visible = false;

        }

        private void ManagerVisibility()
        {
            label3.Visible = false;
            label2.Visible = true;
            label1.Visible = true;

            txtFirstName.Visible = true;
            txtLastName.Visible = true;
            txtLicenseNo.Visible = false;
        }

        private void TeamVisibility()
        {
            label3.Visible = false;
            label2.Visible = false;
            label1.Visible = true;

            txtFirstName.Visible = true;
            txtLastName.Visible = false;
            txtLicenseNo.Visible = false;
        }

        
    }
}
