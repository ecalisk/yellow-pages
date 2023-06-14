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
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace yellow_pages
{
    public partial class viewContacts : Form
    {
        public int recordIndex = 0;
        string textFilePath = @".\database.txt";

        public viewContacts()
        {
            InitializeComponent();
            fileCheck.checkNCreate();
            readContacts();
        }

        //REGISTER NEXT RECORD
        private void buttonNextRecord_Click(object sender, EventArgs e)
        {
            recordIndex++;
            readContacts();
        }

        //REGISTER PREVIOUS RECORD
        private void buttonPreviousRecord_Click(object sender, EventArgs e)
        {
            recordIndex--;
            readContacts();
        }

        //MOVE BACK TO MENU
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        //DELETE RECORD, RESTART FORM
        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            deleteRecord();
            this.Hide();
            viewContacts f3 = new viewContacts();
            f3.ShowDialog();
            this.Close();
        }

        //READ CONTACT RECORDS FROM THE TEXT FILE AND REGISTER THEM
        void readContacts()
        {
            List<string> allLines = File.ReadAllLines(textFilePath).ToList();
            int howManyRecords = allLines.Count / 8;

            //no complete record
            if (howManyRecords == 0)
            {
                labelRecordIndex.Text = "No records found!";
                buttonNextRecord.Enabled = false;
                buttonPreviousRecord.Enabled = false;
                buttonDeleteRecord.Enabled = false;
            }
            //a line of the current read record does not meet the requirements
            else if ((allLines[8 * recordIndex + 0].Length < 6) || (allLines[8 * recordIndex + 1].Length < 13) || (allLines[8 * recordIndex + 2].Length < 11)
                || (allLines[8 * recordIndex + 3].Length < 14) || (allLines[8 * recordIndex + 4].Length < 9) || (allLines[8 * recordIndex + 5].Length < 8))
            {
                MessageBox.Show("Badly formatted records file!", "ERROR: Invalid Record Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonNextRecord.Enabled = false;
                buttonPreviousRecord.Enabled = false;
                buttonDeleteRecord.Enabled = false;
                labelRecordIndex.Text = "Bad record detected!";
                clearAllFields();
            }
            //read and process the contact into the form
            else
            {
                textBoxName.Text = allLines[8 * recordIndex + 0].Substring(6, allLines[8 * recordIndex + 0].Length - 6);

                //registering an empty middle name input to textBox results in index erorr thus crash  
                if (allLines[8 * recordIndex + 1] != "Middle Name: ")
                {
                    textBoxMidName.Text = allLines[8 * recordIndex + 1].Substring(13, allLines[8 * recordIndex + 1].Length - 13);
                }
                else 
                {
                    textBoxMidName.Text = "";
                }

                textBoxLastName.Text = allLines[8 * recordIndex + 2].Substring(11, allLines[8 * recordIndex + 2].Length - 11);
                textBoxPhoneNo.Text = allLines[8 * recordIndex + 3].Substring(14, allLines[8 * recordIndex + 3].Length - 14);
                textBoxAddress.Text = allLines[8 * recordIndex + 4].Substring(9, allLines[8 * recordIndex + 4].Length - 9);
                labelGen.Text = allLines[8 * recordIndex + 5].Substring(8, allLines[8 * recordIndex + 5].Length - 8);
                pictureBox1.ImageLocation = allLines[8 * recordIndex + 6].Substring(7, allLines[8 * recordIndex + 6].Length - 7);

                labelRecordIndex.Text = "Record " + (recordIndex + 1) + " out of " + howManyRecords;

                lockButtons(howManyRecords);
            }
        }

        //DELETE ALL THE LINES FROM THE FILE WHICH ARE OCCUPIED BY AN UNWANTED RECORD
        void deleteRecord()
        {
            List<string> allLines = File.ReadAllLines(textFilePath).ToList();
            allLines.RemoveRange(recordIndex * 8, 8);
            File.WriteAllLines(textFilePath, allLines);
        }

        //EMPTY OUT ALL FIELDS
        void clearAllFields()
        {
            textBoxName.Text = "";
            textBoxMidName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhoneNo.Text = "";
            textBoxAddress.Text = "";
            labelGen.Text = "";
            pictureBox1.Image = yellow_pages.Properties.Resources.no_user_image;
        }

        //HANDLE APPROPRIATE LOCK OF PREVIOUS & NEXT BUTTONS
        void lockButtons(int howManyRecords)
        {
            if (recordIndex == (howManyRecords - 1))
            {
                buttonNextRecord.Enabled = false;
            }
            else
            {
                buttonNextRecord.Enabled = true;
            }

            if (recordIndex == 0)
            {
                buttonPreviousRecord.Enabled = false;
            }
            else
            {
                buttonPreviousRecord.Enabled = true;
            }
        }
    }
}
