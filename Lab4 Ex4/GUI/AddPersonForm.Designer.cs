
namespace Lab4_Ex4.GUI
{
    partial class AddPersonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.personForenameLabel = new System.Windows.Forms.Label();
            this.personSurnameLabel = new System.Windows.Forms.Label();
            this.noApartmentLabel = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.birthdateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.jobLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.personForenameTextbox = new System.Windows.Forms.TextBox();
            this.personSurnameTextbox = new System.Windows.Forms.TextBox();
            this.noApartmentTextbox = new System.Windows.Forms.TextBox();
            this.jobTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // personForenameLabel
            // 
            this.personForenameLabel.AutoSize = true;
            this.personForenameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personForenameLabel.Location = new System.Drawing.Point(12, 36);
            this.personForenameLabel.Name = "personForenameLabel";
            this.personForenameLabel.Size = new System.Drawing.Size(77, 20);
            this.personForenameLabel.TabIndex = 0;
            this.personForenameLabel.Text = "Prenume:";
            // 
            // personSurnameLabel
            // 
            this.personSurnameLabel.AutoSize = true;
            this.personSurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personSurnameLabel.Location = new System.Drawing.Point(12, 70);
            this.personSurnameLabel.Name = "personSurnameLabel";
            this.personSurnameLabel.Size = new System.Drawing.Size(55, 20);
            this.personSurnameLabel.TabIndex = 1;
            this.personSurnameLabel.Text = "Nume:";
            // 
            // noApartmentLabel
            // 
            this.noApartmentLabel.AutoSize = true;
            this.noApartmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noApartmentLabel.Location = new System.Drawing.Point(13, 104);
            this.noApartmentLabel.Name = "noApartmentLabel";
            this.noApartmentLabel.Size = new System.Drawing.Size(146, 20);
            this.noApartmentLabel.TabIndex = 2;
            this.noApartmentLabel.Text = "Numar apartament:";
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateLabel.Location = new System.Drawing.Point(14, 143);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(103, 20);
            this.birthdateLabel.TabIndex = 3;
            this.birthdateLabel.Text = "Data nasterii:";
            // 
            // birthdateDatePicker
            // 
            this.birthdateDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdateDatePicker.Location = new System.Drawing.Point(123, 139);
            this.birthdateDatePicker.MaxDate = new System.DateTime(2020, 11, 21, 0, 0, 0, 0);
            this.birthdateDatePicker.Name = "birthdateDatePicker";
            this.birthdateDatePicker.Size = new System.Drawing.Size(100, 24);
            this.birthdateDatePicker.TabIndex = 4;
            this.birthdateDatePicker.Value = new System.DateTime(2020, 11, 21, 0, 0, 0, 0);
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobLabel.Location = new System.Drawing.Point(12, 178);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(39, 20);
            this.jobLabel.TabIndex = 7;
            this.jobLabel.Text = "Job:";
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(12, 222);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(535, 58);
            this.errorLabel.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(371, 283);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 26);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Adauga";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(462, 283);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 26);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Anuleaza";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // personForenameTextbox
            // 
            this.personForenameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personForenameTextbox.Location = new System.Drawing.Point(95, 34);
            this.personForenameTextbox.Name = "personForenameTextbox";
            this.personForenameTextbox.Size = new System.Drawing.Size(100, 24);
            this.personForenameTextbox.TabIndex = 11;
            // 
            // personSurnameTextbox
            // 
            this.personSurnameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personSurnameTextbox.Location = new System.Drawing.Point(73, 68);
            this.personSurnameTextbox.Name = "personSurnameTextbox";
            this.personSurnameTextbox.Size = new System.Drawing.Size(100, 24);
            this.personSurnameTextbox.TabIndex = 12;
            // 
            // noApartmentTextbox
            // 
            this.noApartmentTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noApartmentTextbox.Location = new System.Drawing.Point(165, 102);
            this.noApartmentTextbox.Name = "noApartmentTextbox";
            this.noApartmentTextbox.Size = new System.Drawing.Size(100, 24);
            this.noApartmentTextbox.TabIndex = 13;
            // 
            // jobTextbox
            // 
            this.jobTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTextbox.Location = new System.Drawing.Point(57, 176);
            this.jobTextbox.Name = "jobTextbox";
            this.jobTextbox.Size = new System.Drawing.Size(100, 24);
            this.jobTextbox.TabIndex = 14;
            // 
            // AddPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 321);
            this.Controls.Add(this.jobTextbox);
            this.Controls.Add(this.noApartmentTextbox);
            this.Controls.Add(this.personSurnameTextbox);
            this.Controls.Add(this.personForenameTextbox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.jobLabel);
            this.Controls.Add(this.birthdateDatePicker);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.noApartmentLabel);
            this.Controls.Add(this.personSurnameLabel);
            this.Controls.Add(this.personForenameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddPersonForm";
            this.Text = "Panou adaugare persoana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label personForenameLabel;
        private System.Windows.Forms.Label personSurnameLabel;
        private System.Windows.Forms.Label noApartmentLabel;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.DateTimePicker birthdateDatePicker;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox personForenameTextbox;
        private System.Windows.Forms.TextBox personSurnameTextbox;
        private System.Windows.Forms.TextBox noApartmentTextbox;
        private System.Windows.Forms.TextBox jobTextbox;
    }
}