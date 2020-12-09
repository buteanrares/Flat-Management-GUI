
namespace Lab4_Ex4.GUI
{
    partial class ShowApartmentsForm
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
            this.apartmentsGridView = new System.Windows.Forms.DataGridView();
            this.noApartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noResidents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentInfoTextbox = new System.Windows.Forms.TextBox();
            this.apartmentInfoLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // apartmentsGridView
            // 
            this.apartmentsGridView.AllowUserToAddRows = false;
            this.apartmentsGridView.AllowUserToDeleteRows = false;
            this.apartmentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apartmentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noApartment,
            this.owner,
            this.noResidents,
            this.surface});
            this.apartmentsGridView.Location = new System.Drawing.Point(12, 106);
            this.apartmentsGridView.Name = "apartmentsGridView";
            this.apartmentsGridView.ReadOnly = true;
            this.apartmentsGridView.Size = new System.Drawing.Size(524, 399);
            this.apartmentsGridView.TabIndex = 0;
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
            // apartmentInfoTextbox
            // 
            this.apartmentInfoTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apartmentInfoTextbox.Location = new System.Drawing.Point(177, 56);
            this.apartmentInfoTextbox.Name = "apartmentInfoTextbox";
            this.apartmentInfoTextbox.Size = new System.Drawing.Size(106, 24);
            this.apartmentInfoTextbox.TabIndex = 10;
            this.apartmentInfoTextbox.TextChanged += new System.EventHandler(this.apartmentInfoTextbox_TextChanged);
            // 
            // apartmentInfoLabel
            // 
            this.apartmentInfoLabel.AutoSize = true;
            this.apartmentInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apartmentInfoLabel.Location = new System.Drawing.Point(34, 58);
            this.apartmentInfoLabel.Name = "apartmentInfoLabel";
            this.apartmentInfoLabel.Size = new System.Drawing.Size(137, 20);
            this.apartmentInfoLabel.TabIndex = 9;
            this.apartmentInfoLabel.Text = "Numar / Proprietar";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(12, 26);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(152, 20);
            this.infoLabel.TabIndex = 8;
            this.infoLabel.Text = "Cautare apartament";
            // 
            // ShowApartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 517);
            this.Controls.Add(this.apartmentInfoTextbox);
            this.Controls.Add(this.apartmentInfoLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.apartmentsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShowApartmentsForm";
            this.Text = "Tabel apartamente";
            this.Load += new System.EventHandler(this.ShowApartmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView apartmentsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn noApartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn noResidents;
        private System.Windows.Forms.DataGridViewTextBoxColumn surface;
        private System.Windows.Forms.TextBox apartmentInfoTextbox;
        private System.Windows.Forms.Label apartmentInfoLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}