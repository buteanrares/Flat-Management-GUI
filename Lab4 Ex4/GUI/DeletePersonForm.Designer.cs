
namespace Lab4_Ex4.GUI
{
    partial class DeletePersonForm
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
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.deletePersonGrid = new System.Windows.Forms.DataGridView();
            this.surnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forenameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noApartmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deletePersonGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextbox.Location = new System.Drawing.Point(177, 62);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(106, 24);
            this.nameTextbox.TabIndex = 8;
            this.nameTextbox.TextChanged += new System.EventHandler(this.nameTextbox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(40, 64);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(131, 20);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Nume / Prenume:";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(12, 32);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(141, 20);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "Cautare persoana:";
            // 
            // deletePersonGrid
            // 
            this.deletePersonGrid.AllowUserToAddRows = false;
            this.deletePersonGrid.AllowUserToDeleteRows = false;
            this.deletePersonGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deletePersonGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameColumn,
            this.forenameColumn,
            this.noApartmentColumn,
            this.birthdateColumn,
            this.jobColumn});
            this.deletePersonGrid.Location = new System.Drawing.Point(12, 112);
            this.deletePersonGrid.Name = "deletePersonGrid";
            this.deletePersonGrid.ReadOnly = true;
            this.deletePersonGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deletePersonGrid.Size = new System.Drawing.Size(630, 104);
            this.deletePersonGrid.TabIndex = 5;
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
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(567, 317);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 26);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Anuleaza";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(476, 317);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 26);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Sterge";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.Location = new System.Drawing.Point(16, 248);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(626, 66);
            this.errorMessageLabel.TabIndex = 13;
            // 
            // DeletePersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 355);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.deletePersonGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeletePersonForm";
            this.Text = "DeletePersonForm";
            ((System.ComponentModel.ISupportInitialize)(this.deletePersonGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.DataGridView deletePersonGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forenameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noApartmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobColumn;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label errorMessageLabel;
    }
}