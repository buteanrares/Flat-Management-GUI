
namespace Lab4_Ex4.GUI
{
    partial class ModifyPersonForm
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
            this.searchedPersonGrid = new System.Windows.Forms.DataGridView();
            this.surnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forenameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noApartmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.info2Label = new System.Windows.Forms.Label();
            this.modifyPersonGrid = new System.Windows.Forms.DataGridView();
            this.modifySurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyForename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyNoApartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchedPersonGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyPersonGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchedPersonGrid
            // 
            this.searchedPersonGrid.AllowUserToAddRows = false;
            this.searchedPersonGrid.AllowUserToDeleteRows = false;
            this.searchedPersonGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchedPersonGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameColumn,
            this.forenameColumn,
            this.noApartmentColumn,
            this.birthdateColumn,
            this.jobColumn});
            this.searchedPersonGrid.Location = new System.Drawing.Point(12, 103);
            this.searchedPersonGrid.Name = "searchedPersonGrid";
            this.searchedPersonGrid.ReadOnly = true;
            this.searchedPersonGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchedPersonGrid.Size = new System.Drawing.Size(621, 104);
            this.searchedPersonGrid.TabIndex = 1;
            this.searchedPersonGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchedPersonGrid_CellClick);
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
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(12, 23);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(141, 20);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "Cautare persoana:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(40, 55);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(131, 20);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Nume / Prenume:";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextbox.Location = new System.Drawing.Point(177, 53);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(106, 24);
            this.nameTextbox.TabIndex = 4;
            this.nameTextbox.TextChanged += new System.EventHandler(this.nameTextbox_TextChanged);
            // 
            // info2Label
            // 
            this.info2Label.AutoSize = true;
            this.info2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info2Label.Location = new System.Drawing.Point(8, 255);
            this.info2Label.Name = "info2Label";
            this.info2Label.Size = new System.Drawing.Size(157, 20);
            this.info2Label.TabIndex = 5;
            this.info2Label.Text = "Modificare persoana:";
            // 
            // modifyPersonGrid
            // 
            this.modifyPersonGrid.AllowUserToAddRows = false;
            this.modifyPersonGrid.AllowUserToDeleteRows = false;
            this.modifyPersonGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyPersonGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modifySurname,
            this.modifyForename,
            this.modifyNoApartment,
            this.modifyBirthdate,
            this.modifyJob});
            this.modifyPersonGrid.Location = new System.Drawing.Point(8, 291);
            this.modifyPersonGrid.Name = "modifyPersonGrid";
            this.modifyPersonGrid.Size = new System.Drawing.Size(621, 58);
            this.modifyPersonGrid.TabIndex = 6;
            // 
            // modifySurname
            // 
            this.modifySurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.modifySurname.Frozen = true;
            this.modifySurname.HeaderText = "Nume";
            this.modifySurname.Name = "modifySurname";
            this.modifySurname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.modifySurname.Width = 130;
            // 
            // modifyForename
            // 
            this.modifyForename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.modifyForename.Frozen = true;
            this.modifyForename.HeaderText = "Prenume";
            this.modifyForename.Name = "modifyForename";
            this.modifyForename.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.modifyForename.Width = 130;
            // 
            // modifyNoApartment
            // 
            this.modifyNoApartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.modifyNoApartment.HeaderText = "Nr. Apartament";
            this.modifyNoApartment.Name = "modifyNoApartment";
            this.modifyNoApartment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.modifyNoApartment.Width = 95;
            // 
            // modifyBirthdate
            // 
            this.modifyBirthdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.modifyBirthdate.HeaderText = "Data nasterii";
            this.modifyBirthdate.Name = "modifyBirthdate";
            this.modifyBirthdate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.modifyBirthdate.Width = 84;
            // 
            // modifyJob
            // 
            this.modifyJob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modifyJob.HeaderText = "Job";
            this.modifyJob.Name = "modifyJob";
            this.modifyJob.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorMessageLabel.Location = new System.Drawing.Point(12, 384);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(620, 60);
            this.errorMessageLabel.TabIndex = 7;
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Location = new System.Drawing.Point(398, 471);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(107, 23);
            this.applyButton.TabIndex = 8;
            this.applyButton.Text = "Aplica modificari";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(528, 471);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Anuleaza";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ModifyPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 506);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.modifyPersonGrid);
            this.Controls.Add(this.info2Label);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.searchedPersonGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifyPersonForm";
            this.Text = "ModifyPersonForm";
            ((System.ComponentModel.ISupportInitialize)(this.searchedPersonGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyPersonGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView searchedPersonGrid;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label info2Label;
        private System.Windows.Forms.DataGridView modifyPersonGrid;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forenameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noApartmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifySurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyForename;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyNoApartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyBirthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyJob;
    }
}