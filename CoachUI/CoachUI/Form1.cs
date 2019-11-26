using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachUI
{
    public partial class Form1 : Form
    {
        public Coach myCoach = new Coach();
        
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            Person p1 = new Person(Nametextbox.Text, Convert.ToInt32(Agetextbox.Text));
            int Seat = myCoach.AddPerson(p1);
            Seattextxbox.Text = Seat + "";
        }

        private void SeatLabel_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Nametextbox.Text = "";
            Agetextbox.Text = "";
            Seattextxbox.Text = "";
            
        }

        private void getbynameButton_Click(object sender, EventArgs e)
        {
           Seattextxbox.Text = myCoach.GetSeatByName(Nametextbox.Text) +"";
        }

        private void removebynameButton_Click(object sender, EventArgs e)
        {

        }
    }
}
