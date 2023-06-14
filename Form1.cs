/* - - - - * 
 April 2021, OOP Project 3
 * - - - - *
 Team: noble rubber duckies
 * - - - - * 
 Members:
 Emirhan Caliskan (56140)
 Nattawat Srisuriyaprateep (55499)
 * - - - - *
 Digitilized phone book desktop application - Yellow Pages.
 */

using System;
using System.Windows.Forms;

namespace yellow_pages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fileCheck.checkNCreate();
        }

        //MOVE TO addContacts FORM
        private void addContacts_Click(object sender, EventArgs e)
        {
            this.Hide();
            addContacts f2 = new addContacts();
            f2.ShowDialog();
            this.Close();
        }

        //MOVE TO viewContacts FORM
        private void viewContacts_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewContacts f3 = new viewContacts();
            f3.ShowDialog();
            this.Close();
        }

        //QUIT APPLICATION
        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
