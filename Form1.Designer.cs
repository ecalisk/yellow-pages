
namespace yellow_pages
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addContacts = new System.Windows.Forms.Button();
            this.viewContacts = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addContacts
            // 
            this.addContacts.BackColor = System.Drawing.Color.Transparent;
            this.addContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addContacts.Font = new System.Drawing.Font("Big John PRO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addContacts.Location = new System.Drawing.Point(138, 193);
            this.addContacts.Name = "addContacts";
            this.addContacts.Size = new System.Drawing.Size(125, 49);
            this.addContacts.TabIndex = 0;
            this.addContacts.Text = "ADD CONTACTS";
            this.addContacts.UseVisualStyleBackColor = false;
            this.addContacts.Click += new System.EventHandler(this.addContacts_Click);
            // 
            // viewContacts
            // 
            this.viewContacts.BackColor = System.Drawing.Color.Transparent;
            this.viewContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewContacts.Font = new System.Drawing.Font("Big John PRO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewContacts.Location = new System.Drawing.Point(138, 248);
            this.viewContacts.Name = "viewContacts";
            this.viewContacts.Size = new System.Drawing.Size(125, 49);
            this.viewContacts.TabIndex = 1;
            this.viewContacts.Text = "VIEW CONTACTS";
            this.viewContacts.UseVisualStyleBackColor = false;
            this.viewContacts.Click += new System.EventHandler(this.viewContacts_Click);
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.Transparent;
            this.quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit.Font = new System.Drawing.Font("Big John PRO", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quit.Location = new System.Drawing.Point(138, 303);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(125, 49);
            this.quit.TabIndex = 2;
            this.quit.Text = "QUIT";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(350, 488);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.viewContacts);
            this.Controls.Add(this.addContacts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yellow Pages";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addContacts;
        private System.Windows.Forms.Button viewContacts;
        private System.Windows.Forms.Button quit;
    }
}

