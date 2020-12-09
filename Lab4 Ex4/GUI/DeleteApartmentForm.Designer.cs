
namespace Lab4_Ex4.GUI
{
    partial class DeleteApartmentForm
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
            this.apartmentInfoTextbox = new System.Windows.Forms.TextBox();
            this.apartmentInfoLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.deleteApartmentGrid = new System.Windows.Forms.DataGridView();
            this.noApartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noResidents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deleteApartmentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // apartmentInfoTextbox
            // 
            this.apartmentInfoTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apartmentInfoTextbox.Location = new System.Drawing.Point(177, 56);
            this.apartmentInfoTextbox.Name = "apartmentInfoTextbox";
            this.apartmentInfoTextbox.Size = new System.Drawing.Size(106, 24);
            this.apartmentInfoTextbox.TabIndex = 14;
            this.apartmentInfoTextbox.TextChanged += new System.EventHandler(this.apartmentInfoTextbox_TextChanged);
            // 
            // apartmentInfoLabel
            // 
            this.apartmentInfoLabel.AutoSize = true;
            this.apartmentInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apartmentInfoLabel.Location = new System.Drawing.Point(34, 58);
            this.apartmentInfoLabel.Name = "apartmentInfoLabel";
            this.apartmentInfoLabel.Size = new System.Drawing.Size(137, 20);
            this.apartmentInfoLabel.TabIndex = 13;
            this.apartmentInfoLabel.Text = "Numar / Proprietar";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(12, 26);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(152, 20);
            this.infoLabel.TabIndex = 12;
            this.infoLabel.Text = "Cautare apartament";
            // 
            // deleteApartmentGrid
            // 
            this.deleteApartmentGrid.AllowUserToAddRows = false;
            this.deleteApartmentGrid.AllowUserToDeleteRows = false;
            this.deleteApartmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteApartmentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noApartment,
            this.owner,
            this.noResidents,
            this.surface});
            this.deleteApartmentGrid.Location = new System.Drawing.Point(12, 106);
            this.deleteApartmentGrid.Name = "deleteApartmentGrid";
            this.deleteApartmentGrid.ReadOnly = true;
            this.deleteApartmentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deleteApartmentGrid.Size = new System.Drawing.Size(526, 135);
            this.deleteApartmentGrid.TabIndex = 11;
            // 
            // noApartment
            // 
            this.noApartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.noApartment.HeaderText = "Nr. Apartament";
            this.noApartment.Name = "noApartment";
            this.noApartment.ReadOnly = true;
            this.noApartment.Width = 70;
            // 
            // owner
            // 
            this.owner.HeaderText = "Proprietar";
            this.owner.Name = "owner";
            this.owner.ReadOnly = true;
            this.owner.Width = 150;
            // 
            // noResidents
            // 
            this.noResidents.HeaderText = "Nr. Locatari";
            this.noResidents.Name = "noResidents";
            this.noResidents.ReadOnly = true;
            this.noResidents.Width = 60;
            // 
            // surface
            // 
            this.surface.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surface.HeaderText = "Suprafata";
            this.surface.Name = "surface";
            this.surface.ReadOnly = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(463, 332);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 26);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Anuleaza";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(372, 332);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 26);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Sterge";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.Location = new System.Drawing.Point(12, 265);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(524, 32);
            this.errorMessageLabel.TabIndex = 17;
            // 
            // warningLabel
            // 
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.warningLabel.Location = new System.Drawing.Point(12, 297);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(526, 32);
            this.warningLabel.TabIndex = 18;
            // 
            // DeleteApartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 370);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.apartmentInfoTextbox);
            this.Controls.Add(this.apartmentInfoLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.deleteApartmentGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeleteApartmentForm";
            this.Text = "DeleteApartmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.deleteApartmentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox apartmentInfoTextbox;
        private System.Windows.Forms.Label apartmentInfoLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.DataGridView deleteApartmentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn noApartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn noResidents;
        private System.Windows.Forms.DataGridViewTextBoxColumn surface;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Label warningLabel;
    }
}