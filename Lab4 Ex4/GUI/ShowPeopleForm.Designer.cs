
namespace Lab4_Ex4.GUI
{
    partial class ShowPeopleForm
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
            this.peopleGridView = new System.Windows.Forms.DataGridView();
            this.surnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forenameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noApartmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.peopleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // peopleGridView
            // 
            this.peopleGridView.AllowUserToAddRows = false;
            this.peopleGridView.AllowUserToDeleteRows = false;
            this.peopleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peopleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameColumn,
            this.forenameColumn,
            this.noApartmentColumn,
            this.birthdateColumn,
            this.jobColumn});
            this.peopleGridView.Location = new System.Drawing.Point(12, 97);
            this.peopleGridView.Name = "peopleGridView";
            this.peopleGridView.ReadOnly = true;
            this.peopleGridView.Size = new System.Drawing.Size(621, 440);
            this.peopleGridView.TabIndex = 0;
            // 
            // surnameColumn
            // 
            this.surnameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.surnameColumn.Frozen = true;
            this.surnameColumn.HeaderText = "Nume";
            this.surnameColumn.Name = "surnameColumn";
            this.surnameColumn.ReadOnly = true;
            this.surnameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.surnameColumn.Width = 130;
            // 
            // forenameColumn
            // 
            this.forenameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.forenameColumn.Frozen = true;
            this.forenameColumn.HeaderText = "Prenume";
            this.forenameColumn.Name = "forenameColumn";
            this.forenameColumn.ReadOnly = true;
            this.forenameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.forenameColumn.Width = 130;
            // 
            // noApartmentColumn
            // 
            this.noApartmentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.noApartmentColumn.HeaderText = "Nr. Apartament";
            this.noApartmentColumn.Name = "noApartmentColumn";
            this.noApartmentColumn.ReadOnly = true;
            this.noApartmentColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.noApartmentColumn.Width = 95;
            // 
            // birthdateColumn
            // 
            this.birthdateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.birthdateColumn.HeaderText = "Data nasterii";
            this.birthdateColumn.Name = "birthdateColumn";
            this.birthdateColumn.ReadOnly = true;
            this.birthdateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.birthdateColumn.Width = 84;
            // 
            // jobColumn
            // 
            this.jobColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jobColumn.HeaderText = "Job";
            this.jobColumn.Name = "jobColumn";
            this.jobColumn.ReadOnly = true;
            this.jobColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextbox.Location = new System.Drawing.Point(177, 51);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(106, 24);
            this.nameTextbox.TabIndex = 7;
            this.nameTextbox.TextChanged += new System.EventHandler(this.nameTextbox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(40, 53);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(131, 20);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Nume / Prenume:";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(12, 21);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(141, 20);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.Text = "Cautare persoana:";
            // 
            // ShowPeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 549);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.peopleGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShowPeopleForm";
            this.Text = "Tabel locatari bloc";
            this.Load += new System.EventHandler(this.ShowPeopleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peopleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView peopleGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forenameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noApartmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobColumn;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}