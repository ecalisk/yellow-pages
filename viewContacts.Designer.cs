
namespace yellow_pages
{
    partial class viewContacts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewContacts));
            this.buttonPreviousRecord = new System.Windows.Forms.Button();
            this.labelGender = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelMidName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonNextRecord = new System.Windows.Forms.Button();
            this.labelGen = new System.Windows.Forms.Label();
            this.labelRecordIndex = new System.Windows.Forms.Label();
            this.buttonDeleteRecord = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMidName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPreviousRecord
            // 
            this.buttonPreviousRecord.BackColor = System.Drawing.Color.Transparent;
            this.buttonPreviousRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousRecord.Font = new System.Drawing.Font("Big John PRO Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreviousRecord.Location = new System.Drawing.Point(243, 298);
            this.buttonPreviousRecord.Name = "buttonPreviousRecord";
            this.buttonPreviousRecord.Size = new System.Drawing.Size(113, 52);
            this.buttonPreviousRecord.TabIndex = 33;
            this.buttonPreviousRecord.Text = "PREVIOUS RECORD";
            this.buttonPreviousRecord.UseVisualStyleBackColor = false;
            this.buttonPreviousRecord.Click += new System.EventHandler(this.buttonPreviousRecord_Click);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGender.Font = new System.Drawing.Font("Metropolis Semi Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGender.Location = new System.Drawing.Point(14, 256);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(123, 29);
            this.labelGender.TabIndex = 31;
            this.labelGender.Text = "Gender:";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Big John PRO Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Location = new System.Drawing.Point(688, 298);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(113, 52);
            this.buttonBack.TabIndex = 29;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Metropolis Semi Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.Location = new System.Drawing.Point(14, 206);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(139, 29);
            this.labelAddress.TabIndex = 21;
            this.labelAddress.Text = "Address:";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Font = new System.Drawing.Font("Metropolis Semi Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumber.Location = new System.Drawing.Point(14, 158);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(232, 29);
            this.labelNumber.TabIndex = 20;
            this.labelNumber.Text = "Phone Number:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.Font = new System.Drawing.Font("Metropolis Semi Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLastName.Location = new System.Drawing.Point(14, 109);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(175, 29);
            this.labelLastName.TabIndex = 19;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelMidName
            // 
            this.labelMidName.AutoSize = true;
            this.labelMidName.BackColor = System.Drawing.Color.Transparent;
            this.labelMidName.Font = new System.Drawing.Font("Metropolis Semi Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMidName.Location = new System.Drawing.Point(14, 64);
            this.labelMidName.Name = "labelMidName";
            this.labelMidName.Size = new System.Drawing.Size(206, 29);
            this.labelMidName.TabIndex = 18;
            this.labelMidName.Text = "Middle Name:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Metropolis Semi Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(14, 11);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(105, 29);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Name:";
            // 
            // buttonNextRecord
            // 
            this.buttonNextRecord.BackColor = System.Drawing.Color.Transparent;
            this.buttonNextRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextRecord.Font = new System.Drawing.Font("Big John PRO Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNextRecord.Location = new System.Drawing.Point(410, 298);
            this.buttonNextRecord.Name = "buttonNextRecord";
            this.buttonNextRecord.Size = new System.Drawing.Size(113, 52);
            this.buttonNextRecord.TabIndex = 35;
            this.buttonNextRecord.Text = "NEXT RECORD";
            this.buttonNextRecord.UseVisualStyleBackColor = false;
            this.buttonNextRecord.Click += new System.EventHandler(this.buttonNextRecord_Click);
            // 
            // labelGen
            // 
            this.labelGen.AutoSize = true;
            this.labelGen.BackColor = System.Drawing.Color.Transparent;
            this.labelGen.Font = new System.Drawing.Font("Metropolis", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGen.Location = new System.Drawing.Point(16, 285);
            this.labelGen.Name = "labelGen";
            this.labelGen.Size = new System.Drawing.Size(0, 24);
            this.labelGen.TabIndex = 36;
            // 
            // labelRecordIndex
            // 
            this.labelRecordIndex.AutoSize = true;
            this.labelRecordIndex.BackColor = System.Drawing.Color.Transparent;
            this.labelRecordIndex.Font = new System.Drawing.Font("Metropolis", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRecordIndex.Location = new System.Drawing.Point(6, 331);
            this.labelRecordIndex.Name = "labelRecordIndex";
            this.labelRecordIndex.Size = new System.Drawing.Size(0, 21);
            this.labelRecordIndex.TabIndex = 37;
            // 
            // buttonDeleteRecord
            // 
            this.buttonDeleteRecord.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteRecord.Font = new System.Drawing.Font("Big John PRO Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteRecord.Location = new System.Drawing.Point(545, 300);
            this.buttonDeleteRecord.Name = "buttonDeleteRecord";
            this.buttonDeleteRecord.Size = new System.Drawing.Size(113, 52);
            this.buttonDeleteRecord.TabIndex = 38;
            this.buttonDeleteRecord.Text = "DELETE RECORD";
            this.buttonDeleteRecord.UseVisualStyleBackColor = false;
            this.buttonDeleteRecord.Click += new System.EventHandler(this.buttonDeleteRecord_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::yellow_pages.Properties.Resources.no_user_image;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(545, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Metropolis", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAddress.Location = new System.Drawing.Point(243, 207);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(280, 68);
            this.textBoxAddress.TabIndex = 43;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Metropolis", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(243, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(280, 31);
            this.textBoxName.TabIndex = 42;
            // 
            // textBoxMidName
            // 
            this.textBoxMidName.Font = new System.Drawing.Font("Metropolis", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMidName.Location = new System.Drawing.Point(243, 65);
            this.textBoxMidName.Name = "textBoxMidName";
            this.textBoxMidName.Size = new System.Drawing.Size(280, 31);
            this.textBoxMidName.TabIndex = 41;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Metropolis", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLastName.Location = new System.Drawing.Point(243, 110);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(280, 31);
            this.textBoxLastName.TabIndex = 40;
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Font = new System.Drawing.Font("Metropolis", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPhoneNo.Location = new System.Drawing.Point(243, 156);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(280, 31);
            this.textBoxPhoneNo.TabIndex = 39;
            // 
            // viewContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::yellow_pages.Properties.Resources.yellow_page_background;
            this.ClientSize = new System.Drawing.Size(814, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxMidName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxPhoneNo);
            this.Controls.Add(this.buttonDeleteRecord);
            this.Controls.Add(this.labelRecordIndex);
            this.Controls.Add(this.labelGen);
            this.Controls.Add(this.buttonNextRecord);
            this.Controls.Add(this.buttonPreviousRecord);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMidName);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "viewContacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yellow Pages: View Contacts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPreviousRecord;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelMidName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonNextRecord;
        private System.Windows.Forms.Label labelGen;
        private System.Windows.Forms.Label labelRecordIndex;
        private System.Windows.Forms.Button buttonDeleteRecord;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMidName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
    }
}