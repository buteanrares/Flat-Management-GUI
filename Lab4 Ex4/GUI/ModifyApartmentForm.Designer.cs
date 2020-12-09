
namespace Lab4_Ex4.GUI
{
    partial class ModifyApartmentForm
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
            this.apartmentsGridView = new System.Windows.Forms.DataGridView();
            this.noApartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noResidents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyApartmentGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyApartmentLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyApartmentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // apartmentInfoTextbox
            // 
            this.apartmentInfoTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apartmentInfoTextbox.Location = new System.Drawing.Point(177, 60);
            this.apartmentInfoTextbox.Name = "apartmentInfoTextbox";
            this.apartmentInfoTextbox.Size = new System.Drawing.Size(106, 24);
            this.apartmentInfoTextbox.TabIndex = 14;
            this.apartmentInfoTextbox.TextChanged += new System.EventHandler(this.apartmentInfoTextbox_TextChanged);
            // 
            // apartmentInfoLabel
            // 
            this.apartmentInfoLabel.AutoSize = true;
            this.apartmentInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apartmentInfoLabel.Location = new System.Drawing.Point(34, 62);
            this.apartmentInfoLabel.Name = "apartmentInfoLabel";
            this.apartmentInfoLabel.Size = new System.Drawing.Size(137, 20);
            this.apartmentInfoLabel.TabIndex = 13;
            this.apartmentInfoLabel.Text = "Numar / Proprietar";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(12, 30);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(152, 20);
            this.infoLabel.TabIndex = 12;
            this.infoLabel.Text = "Cautare apartament";
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
            this.apartmentsGridView.Location = new System.Drawing.Point(12, 110);
            this.apartmentsGridView.Name = "apartmentsGridView";
            this.apartmentsGridView.ReadOnly = true;
            this.apartmentsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.apartmentsGridView.Size = new System.Drawing.Size(527, 103);
            this.apartmentsGridView.TabIndex = 11;
            this.apartmentsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.apartmentsGridView_CellClick);
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
            // modifyApartmentGrid
            // 
            this.modifyApartmentGrid.AllowUserToAddRows = false;
            this.modifyApartmentGrid.AllowUserToDeleteRows = false;
            this.modifyApartmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyApartmentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.modifyApartmentGrid.Location = new System.Drawing.Point(12, 323);
            this.modifyApartmentGrid.Name = "modifyApartmentGrid";
            this.modifyApartmentGrid.Size = new System.Drawing.Size(527, 57);
            this.modifyApartmentGrid.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nr. Apartament";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Proprietar";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nr. Locatari";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Suprafata";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // modifyApartmentLabel
            // 
            this.modifyApartmentLabel.AutoSize = true;
            this.modifyApartmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyApartmentLabel.Location = new System.Drawing.Point(12, 277);
            this.modifyApartmentLabel.Name = "modifyApartmentLabel";
            this.modifyApartmentLabel.Size = new System.Drawing.Size(168, 20);
            this.modifyApartmentLabel.TabIndex = 16;
            this.modifyApartmentLabel.Text = "Modificare apartament";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(429, 476);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 23);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Anuleaza";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Location = new System.Drawing.Point(299, 476);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(107, 23);
            this.applyButton.TabIndex = 17;
            this.applyButton.Text = "Aplica modificari";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorMessageLabel.Location = new System.Drawing.Point(9, 398);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(527, 60);
            this.errorMessageLabel.TabIndex = 19;
            // 
            // ModifyApartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 511);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.modifyApartmentLabel);
            this.Controls.Add(this.modifyApartmentGrid);
            this.Controls.Add(this.apartmentInfoTextbox);
            this.Controls.Add(this.apartmentInfoLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.apartmentsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModifyApartmentForm";
            this.Text = "ModifyApartmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyApartmentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox apartmentInfoTextbox;
        private System.Windows.Forms.Label apartmentInfoLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.DataGridView apartmentsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn noApartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn noResidents;
        private System.Windows.Forms.DataGridViewTextBoxColumn surface;
        private System.Windows.Forms.DataGridView modifyApartmentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label modifyApartmentLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label errorMessageLabel;
    }
}