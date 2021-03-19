
namespace Lab4_Ex4
{
    partial class MainGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            this.butonAddPerson = new System.Windows.Forms.Button();
            this.buttonAddApartment = new System.Windows.Forms.Button();
            this.buttonMonthlyPayments = new System.Windows.Forms.Button();
            this.showPeopleButton = new System.Windows.Forms.Button();
            this.showApartmentsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plusPicturebox = new System.Windows.Forms.PictureBox();
            this.deletePersonButton = new System.Windows.Forms.Button();
            this.deleteApartmentButton = new System.Windows.Forms.Button();
            this.minusPicturebox = new System.Windows.Forms.PictureBox();
            this.modifyPicturebox = new System.Windows.Forms.PictureBox();
            this.modifyPersonButton = new System.Windows.Forms.Button();
            this.modifyApartmentButton = new System.Windows.Forms.Button();
            this.showPicturebox = new System.Windows.Forms.PictureBox();
            this.showEventsButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.setDBbutton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // butonAddPerson
            // 
            this.butonAddPerson.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butonAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonAddPerson.Location = new System.Drawing.Point(170, 38);
            this.butonAddPerson.Name = "butonAddPerson";
            this.butonAddPerson.Size = new System.Drawing.Size(169, 26);
            this.butonAddPerson.TabIndex = 0;
            this.butonAddPerson.Text = "Adaugare persoana";
            this.butonAddPerson.UseVisualStyleBackColor = true;
            this.butonAddPerson.Click += new System.EventHandler(this.butonAddPerson_Click);
            // 
            // buttonAddApartment
            // 
            this.buttonAddApartment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddApartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddApartment.Location = new System.Drawing.Point(170, 71);
            this.buttonAddApartment.Name = "buttonAddApartment";
            this.buttonAddApartment.Size = new System.Drawing.Size(169, 26);
            this.buttonAddApartment.TabIndex = 1;
            this.buttonAddApartment.Text = "Adaugare apartament";
            this.buttonAddApartment.UseVisualStyleBackColor = true;
            this.buttonAddApartment.Click += new System.EventHandler(this.buttonAddApartment_Click);
            // 
            // buttonMonthlyPayments
            // 
            this.buttonMonthlyPayments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMonthlyPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMonthlyPayments.Location = new System.Drawing.Point(170, 467);
            this.buttonMonthlyPayments.Name = "buttonMonthlyPayments";
            this.buttonMonthlyPayments.Size = new System.Drawing.Size(169, 26);
            this.buttonMonthlyPayments.TabIndex = 2;
            this.buttonMonthlyPayments.Text = "Afisare cheltuieli lunare";
            this.buttonMonthlyPayments.UseVisualStyleBackColor = true;
            this.buttonMonthlyPayments.Click += new System.EventHandler(this.buttonMonthlyPayments_Click);
            // 
            // showPeopleButton
            // 
            this.showPeopleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPeopleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPeopleButton.Location = new System.Drawing.Point(170, 357);
            this.showPeopleButton.Name = "showPeopleButton";
            this.showPeopleButton.Size = new System.Drawing.Size(169, 26);
            this.showPeopleButton.TabIndex = 3;
            this.showPeopleButton.Text = "Afisare persoane";
            this.showPeopleButton.UseVisualStyleBackColor = true;
            this.showPeopleButton.Click += new System.EventHandler(this.showPeopleButton_Click);
            // 
            // showApartmentsButton
            // 
            this.showApartmentsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showApartmentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showApartmentsButton.Location = new System.Drawing.Point(170, 390);
            this.showApartmentsButton.Name = "showApartmentsButton";
            this.showApartmentsButton.Size = new System.Drawing.Size(169, 26);
            this.showApartmentsButton.TabIndex = 4;
            this.showApartmentsButton.Text = "Afisare apartamente";
            this.showApartmentsButton.UseVisualStyleBackColor = true;
            this.showApartmentsButton.Click += new System.EventHandler(this.showApartmentsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 467);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // plusPicturebox
            // 
            this.plusPicturebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plusPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("plusPicturebox.Image")));
            this.plusPicturebox.Location = new System.Drawing.Point(82, 38);
            this.plusPicturebox.Name = "plusPicturebox";
            this.plusPicturebox.Size = new System.Drawing.Size(67, 58);
            this.plusPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plusPicturebox.TabIndex = 6;
            this.plusPicturebox.TabStop = false;
            // 
            // deletePersonButton
            // 
            this.deletePersonButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deletePersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePersonButton.Location = new System.Drawing.Point(170, 144);
            this.deletePersonButton.Name = "deletePersonButton";
            this.deletePersonButton.Size = new System.Drawing.Size(169, 26);
            this.deletePersonButton.TabIndex = 7;
            this.deletePersonButton.Text = "Stergere persoana";
            this.deletePersonButton.UseVisualStyleBackColor = true;
            this.deletePersonButton.Click += new System.EventHandler(this.deletePersonButton_Click);
            // 
            // deleteApartmentButton
            // 
            this.deleteApartmentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteApartmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteApartmentButton.Location = new System.Drawing.Point(170, 177);
            this.deleteApartmentButton.Name = "deleteApartmentButton";
            this.deleteApartmentButton.Size = new System.Drawing.Size(169, 26);
            this.deleteApartmentButton.TabIndex = 8;
            this.deleteApartmentButton.Text = "Stergere apartament";
            this.deleteApartmentButton.UseVisualStyleBackColor = true;
            this.deleteApartmentButton.Click += new System.EventHandler(this.deleteApartmentButton_Click);
            // 
            // minusPicturebox
            // 
            this.minusPicturebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minusPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("minusPicturebox.Image")));
            this.minusPicturebox.Location = new System.Drawing.Point(82, 144);
            this.minusPicturebox.Name = "minusPicturebox";
            this.minusPicturebox.Size = new System.Drawing.Size(67, 58);
            this.minusPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minusPicturebox.TabIndex = 9;
            this.minusPicturebox.TabStop = false;
            // 
            // modifyPicturebox
            // 
            this.modifyPicturebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modifyPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("modifyPicturebox.Image")));
            this.modifyPicturebox.Location = new System.Drawing.Point(82, 255);
            this.modifyPicturebox.Name = "modifyPicturebox";
            this.modifyPicturebox.Size = new System.Drawing.Size(67, 58);
            this.modifyPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modifyPicturebox.TabIndex = 10;
            this.modifyPicturebox.TabStop = false;
            // 
            // modifyPersonButton
            // 
            this.modifyPersonButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modifyPersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPersonButton.Location = new System.Drawing.Point(170, 255);
            this.modifyPersonButton.Name = "modifyPersonButton";
            this.modifyPersonButton.Size = new System.Drawing.Size(169, 26);
            this.modifyPersonButton.TabIndex = 11;
            this.modifyPersonButton.Text = "Modificare persoana";
            this.modifyPersonButton.UseVisualStyleBackColor = true;
            this.modifyPersonButton.Click += new System.EventHandler(this.modifyPersonButton_Click);
            // 
            // modifyApartmentButton
            // 
            this.modifyApartmentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modifyApartmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyApartmentButton.Location = new System.Drawing.Point(170, 284);
            this.modifyApartmentButton.Name = "modifyApartmentButton";
            this.modifyApartmentButton.Size = new System.Drawing.Size(169, 26);
            this.modifyApartmentButton.TabIndex = 12;
            this.modifyApartmentButton.Text = "Modificare apartament";
            this.modifyApartmentButton.UseVisualStyleBackColor = true;
            this.modifyApartmentButton.Click += new System.EventHandler(this.modifyApartmentButton_Click);
            // 
            // showPicturebox
            // 
            this.showPicturebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPicturebox.Image = ((System.Drawing.Image)(resources.GetObject("showPicturebox.Image")));
            this.showPicturebox.Location = new System.Drawing.Point(82, 350);
            this.showPicturebox.Name = "showPicturebox";
            this.showPicturebox.Size = new System.Drawing.Size(67, 76);
            this.showPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPicturebox.TabIndex = 13;
            this.showPicturebox.TabStop = false;
            // 
            // showEventsButton
            // 
            this.showEventsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showEventsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showEventsButton.Location = new System.Drawing.Point(170, 499);
            this.showEventsButton.Name = "showEventsButton";
            this.showEventsButton.Size = new System.Drawing.Size(169, 26);
            this.showEventsButton.TabIndex = 14;
            this.showEventsButton.Text = "Afisare evenimente";
            this.showEventsButton.UseVisualStyleBackColor = true;
            this.showEventsButton.Click += new System.EventHandler(this.showEventsButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Lab4_Ex4.Properties.Resources.DB_Fixed;
            this.pictureBox2.Location = new System.Drawing.Point(89, 565);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // setDBbutton
            // 
            this.setDBbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setDBbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setDBbutton.Location = new System.Drawing.Point(170, 581);
            this.setDBbutton.Name = "setDBbutton";
            this.setDBbutton.Size = new System.Drawing.Size(169, 26);
            this.setDBbutton.TabIndex = 17;
            this.setDBbutton.Text = "Setare BD";
            this.setDBbutton.UseVisualStyleBackColor = true;
            this.setDBbutton.Click += new System.EventHandler(this.setDBbutton_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 668);
            this.Controls.Add(this.setDBbutton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.showEventsButton);
            this.Controls.Add(this.showPicturebox);
            this.Controls.Add(this.modifyApartmentButton);
            this.Controls.Add(this.modifyPersonButton);
            this.Controls.Add(this.modifyPicturebox);
            this.Controls.Add(this.minusPicturebox);
            this.Controls.Add(this.deleteApartmentButton);
            this.Controls.Add(this.deletePersonButton);
            this.Controls.Add(this.plusPicturebox);
            this.Controls.Add(this.showApartmentsButton);
            this.Controls.Add(this.showPeopleButton);
            this.Controls.Add(this.buttonMonthlyPayments);
            this.Controls.Add(this.buttonAddApartment);
            this.Controls.Add(this.butonAddPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainGUI";
            this.Text = "Panou management bloc";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plusPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butonAddPerson;
        private System.Windows.Forms.Button buttonAddApartment;
        private System.Windows.Forms.Button buttonMonthlyPayments;
        private System.Windows.Forms.Button showPeopleButton;
        private System.Windows.Forms.Button showApartmentsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox plusPicturebox;
        private System.Windows.Forms.Button deletePersonButton;
        private System.Windows.Forms.Button deleteApartmentButton;
        private System.Windows.Forms.PictureBox minusPicturebox;
        private System.Windows.Forms.PictureBox modifyPicturebox;
        private System.Windows.Forms.Button modifyPersonButton;
        private System.Windows.Forms.Button modifyApartmentButton;
        private System.Windows.Forms.PictureBox showPicturebox;
        private System.Windows.Forms.Button showEventsButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button setDBbutton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

