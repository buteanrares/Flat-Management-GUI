
namespace Lab4_Ex4.GUI
{
    partial class MonthlyPaymentsForm
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
            this.monthlyPaymentsGridView = new System.Windows.Forms.DataGridView();
            this.noApartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceWater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.electricity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthsCombobox = new System.Windows.Forms.ComboBox();
            this.monthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyPaymentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // monthlyPaymentsGridView
            // 
            this.monthlyPaymentsGridView.AllowUserToAddRows = false;
            this.monthlyPaymentsGridView.AllowUserToDeleteRows = false;
            this.monthlyPaymentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthlyPaymentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noApartment,
            this.owner,
            this.gas,
            this.maintenanceWater,
            this.electricity,
            this.internet,
            this.total});
            this.monthlyPaymentsGridView.Location = new System.Drawing.Point(12, 12);
            this.monthlyPaymentsGridView.Name = "monthlyPaymentsGridView";
            this.monthlyPaymentsGridView.ReadOnly = true;
            this.monthlyPaymentsGridView.Size = new System.Drawing.Size(646, 464);
            this.monthlyPaymentsGridView.TabIndex = 0;
            // 
            // noApartment
            // 
            this.noApartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.noApartment.HeaderText = "Nr. Apartament";
            this.noApartment.Name = "noApartment";
            this.noApartment.ReadOnly = true;
            this.noApartment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.noApartment.Width = 95;
            // 
            // owner
            // 
            this.owner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.owner.HeaderText = "Proprietar";
            this.owner.Name = "owner";
            this.owner.ReadOnly = true;
            this.owner.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.owner.Width = 160;
            // 
            // gas
            // 
            this.gas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gas.HeaderText = "Gaz";
            this.gas.Name = "gas";
            this.gas.ReadOnly = true;
            this.gas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gas.Width = 51;
            // 
            // maintenanceWater
            // 
            this.maintenanceWater.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.maintenanceWater.HeaderText = "Intretinere si apa";
            this.maintenanceWater.Name = "maintenanceWater";
            this.maintenanceWater.ReadOnly = true;
            this.maintenanceWater.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.maintenanceWater.Width = 85;
            // 
            // electricity
            // 
            this.electricity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.electricity.HeaderText = "Curent";
            this.electricity.Name = "electricity";
            this.electricity.ReadOnly = true;
            this.electricity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.electricity.Width = 63;
            // 
            // internet
            // 
            this.internet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.internet.HeaderText = "Internet";
            this.internet.Name = "internet";
            this.internet.ReadOnly = true;
            this.internet.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.internet.Width = 68;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // monthsCombobox
            // 
            this.monthsCombobox.FormattingEnabled = true;
            this.monthsCombobox.Location = new System.Drawing.Point(67, 499);
            this.monthsCombobox.Name = "monthsCombobox";
            this.monthsCombobox.Size = new System.Drawing.Size(121, 21);
            this.monthsCombobox.TabIndex = 1;
            this.monthsCombobox.SelectedIndexChanged += new System.EventHandler(this.monthsCombobox_SelectedIndexChanged);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(12, 497);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(49, 20);
            this.monthLabel.TabIndex = 2;
            this.monthLabel.Text = "Luna:";
            // 
            // MonthlyPaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 541);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.monthsCombobox);
            this.Controls.Add(this.monthlyPaymentsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MonthlyPaymentsForm";
            this.Text = "Panou plati lunare";
            this.Load += new System.EventHandler(this.MonthlyPaymentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monthlyPaymentsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView monthlyPaymentsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn noApartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn gas;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceWater;
        private System.Windows.Forms.DataGridViewTextBoxColumn electricity;
        private System.Windows.Forms.DataGridViewTextBoxColumn internet;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.ComboBox monthsCombobox;
        private System.Windows.Forms.Label monthLabel;
    }
}