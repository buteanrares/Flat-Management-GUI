
namespace Lab4_Ex4.GUI
{
    partial class ShowEventsForm
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
            this.eventsDataGrid = new System.Windows.Forms.DataGridView();
            this.noIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // eventsDataGrid
            // 
            this.eventsDataGrid.AllowUserToAddRows = false;
            this.eventsDataGrid.AllowUserToDeleteRows = false;
            this.eventsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noIndex,
            this.description});
            this.eventsDataGrid.Location = new System.Drawing.Point(13, 13);
            this.eventsDataGrid.Name = "eventsDataGrid";
            this.eventsDataGrid.ReadOnly = true;
            this.eventsDataGrid.Size = new System.Drawing.Size(625, 549);
            this.eventsDataGrid.TabIndex = 0;
            // 
            // noIndex
            // 
            this.noIndex.HeaderText = "Nr. Crt";
            this.noIndex.Name = "noIndex";
            this.noIndex.ReadOnly = true;
            this.noIndex.Width = 50;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.HeaderText = "Eveniment:";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // ShowEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 574);
            this.Controls.Add(this.eventsDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShowEventsForm";
            this.Text = "ShowEventsForm";
            this.Load += new System.EventHandler(this.ShowEventsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView eventsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn noIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}