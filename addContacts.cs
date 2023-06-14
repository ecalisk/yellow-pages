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
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace yellow_pages
{
    public partial class addContacts : Form
    {
        string SEPERATOR = "++++++++++++++++++++++++++++++++++++++++++++++++++";
        string imageLocation = @".\img\no-user-image.png";
        int pictureIndex = 1;

        public addContacts()
        {
            InitializeComponent();
            fileCheck.checkNCreate();
            clearAllFields();
        }

        //ADD INPUT TO RECORDS
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool formatCheck = int.TryParse(textBoxPhoneNo.Text, out _) && textBoxName.Text != "" && textBoxLastName.Text != "" && textBoxAddress.Text != "";
            if (formatCheck) 
            {
                if (textBoxMidName.Text == null) { textBoxMidName.Text = " "; }
                contact newContact = new contact(textBoxName.Text, textBoxMidName.Text, textBoxLastName.Text, Int32.Parse(textBoxPhoneNo.Text), textBoxAddress.Text, comboBoxGender.SelectedItem.ToString(), imageLocation);

                string textFilePath = @".\database.txt";
                List<string> allLines = File.ReadAllLines(textFilePath).ToList();

                allLines.InsertRange(allLines.Count, new List<string>
                {"Name: " + newContact.firstName, "Middle Name: " + newContact.middleName, "Last Name: " + newContact.lastName, "Phone Number: " + newContact.phoneNumber.ToString(),
                "Address: " + newContact.address, "Gender: " + newContact.gender, "Photo: " + imageLocation, SEPERATOR});

                File.WriteAllLines(textFilePath, allLines);

                successfulAdd();
            }
            else 
            {
                MessageBox.Show("ALL FIELDS MUST BE FILLED EXCEPT THE MIDDLE NAME FIELD. ONLY ENTER NUMBERS FOR THE PHONE NUMBER FIELD!", "ERROR: Invalid Input Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //HANDLES UPLOAD CLICK
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureIndex = Int32.Parse(File.ReadLines(@".\imgIndex.txt").First());
                pictureBox1.Image = new Bitmap(opnfd.FileName);
                //COPY UPLOADED IMAGE WITH INDEXED NAMES
                imageLocation = @".\img\" + textBoxName.Text + pictureIndex.ToString() + ".jpg";
                System.IO.File.Copy(opnfd.FileName, imageLocation);
                pictureIndex++;
                //SAVE PICTURE INDEX ACCROSS SESSIONS
                File.WriteAllText(@".\imgIndex.txt", null);
                File.WriteAllText(@".\imgIndex.txt", pictureIndex.ToString());
            }
        }

        ////CLEAR ALL INPUT FIELDS AND REVERT PHOTO BACK TO DEFAULT
        void clearAllFields() 
        {
            textBoxName.Text = "";
            textBoxMidName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhoneNo.Text = "";
            textBoxAddress.Text = "";
            comboBoxGender.SelectedItem = "Unspecified";
            imageLocation = @".\img\no-user-image.png";
            pictureBox1.Image = yellow_pages.Properties.Resources.no_user_image;
        }

        //INFORM USER OF THEIR SUCCESSFUL RECORD ADD
        void successfulAdd()
        {
            MessageBox.Show("You contact has been successfully added!", "SUCCESS: Contact added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearAllFields();
        }

        //CLEAR BUTTON CLICK ACTION
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        //MOVE BACK TO MENU - BACK BUTTON CLICK ACTION
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
