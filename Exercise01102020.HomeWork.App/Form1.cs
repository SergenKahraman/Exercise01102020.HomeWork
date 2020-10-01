
using Exercise01102020.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise01102020.HomeWork.App
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var T1 = new Team("Galatasaray");
            var T2 = new Team("Fenerbahçe");
            var T3 = new Team("Beşiktaş");

            var P1 = new Player("Sergen", "Kahraman", 12345);
            var P2 = new Player("Emre", "Ertuğrul", 12);
            var P3 = new Player("Yunus", "Ertuğrul", 1234);
            var P4 = new Player("Hami", "Ertuğrul", 1);

            var C1 = new Coach("Hami", "Aktaş");
            var C2 = new Coach("Hami", "BAktaş");

            var M1 = new Manager("Gamze", "Uysal");
            var M2 = new Manager("Nur", "Uysal");


            T1.AssignPlayers(P1, P2);
            T1.AssignManager(M1);
            T1.AssignCoach(C1);

            P3.AddTeam(T2);
            C2.AddTeam(T2);
            M2.AddTeam(T2);

            P1.AddTeam(T2);
            



        }
    }
}
