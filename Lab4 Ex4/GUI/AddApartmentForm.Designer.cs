
namespace Lab4_Ex4.GUI
{
    partial class AddApartmentForm
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
            this.noApartmentLabel = new System.Windows.Forms.Label();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.noResidentsLabel = new System.Windows.Forms.Label();
            this.surfaceLabel = new System.Windows.Forms.Label();
            this.noApartmentTextbox = new System.Windows.Forms.TextBox();
            this.ownerTextbox = new System.Windows.Forms.TextBox();
            this.noResidentsTextbox = new System.Windows.Forms.TextBox();
            this.surfaceTextbox = new System.Windows.Forms.TextBox();
            this.addApartmentButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // noApartmentLabel
            // 
            this.noApartmentLabel.AutoSize = true;
            this.noApartmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noApartmentLabel.Location = new System.Drawing.Point(12, 42);
            this.noApartmentLabel.Name = "noApartmentLabel";
            this.noApartmentLabel.Size = new System.Drawing.Size(121, 20);
            this.noApartmentLabel.TabIndex = 0;
            this.noApartmentLabel.Text = "Nr. Apartament:";
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerLabel.Location = new System.Drawing.Point(12, 73);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(82, 20);
            this.ownerLabel.TabIndex = 1;
            this.ownerLabel.Text = "Proprietar:";
            // 
            // noResidentsLabel
            // 
            this.noResidentsLabel.AutoSize = true;
            this.noResidentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noResidentsLabel.Location = new System.Drawing.Point(12, 106);
            this.noResidentsLabel.Name = "noResidentsLabel";
            this.noResidentsLabel.Size = new System.Drawing.Size(94, 20);
            this.noResidentsLabel.TabIndex = 2;
            this.noResidentsLabel.Text = "Nr. Locatari:";
            // 
            // surfaceLabel
            // 
            this.surfaceLabel.AutoSize = true;
            this.surfaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceLabel.Location = new System.Drawing.Point(12, 139);
            this.surfaceLabel.Name = "surfaceLabel";
            this.surfaceLabel.Size = new System.Drawing.Size(84, 20);
            this.surfaceLabel.TabIndex = 3;
            this.surfaceLabel.Text = "Suprafata:";
            // 
            // noApartmentTextbox
            // 
            this.noApartmentTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noApartmentTextbox.Location = new System.Drawing.Point(139, 40);
            this.noApartmentTextbox.Name = "noApartmentTextbox";
            this.noApartmentTextbox.Size = new System.Drawing.Size(51, 24);
            this.noApartmentTextbox.TabIndex = 4;
            // 
            // ownerTextbox
            // 
            this.ownerTextbox.BackColor = System.Drawing.Color.White;
            this.ownerTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ownerTextbox.Location = new System.Drawing.Point(100, 71);
            this.ownerTextbox.Name = "ownerTextbox";
            this.ownerTextbox.ReadOnly = true;
            this.ownerTextbox.Size = new System.Drawing.Size(90, 24);
            this.ownerTextbox.TabIndex = 5;
            this.ownerTextbox.Text = "(implicit fara)";
            // 
            // noResidentsTextbox
            // 
            this.noResidentsTextbox.BackColor = System.Drawing.Color.White;
            this.noResidentsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noResidentsTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.noResidentsTextbox.Location = new System.Drawing.Point(113, 105);
            this.noResidentsTextbox.Name = "noResidentsTextbox";
            this.noResidentsTextbox.ReadOnly = true;
            this.noResidentsTextbox.Size = new System.Drawing.Size(95, 24);
            this.noResidentsTextbox.TabIndex = 6;
            this.noResidentsTextbox.Text = "(implicit zero)";
            // 
            // surfaceTextbox
            // 
            this.surfaceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceTextbox.Location = new System.Drawing.Point(100, 137);
            this.surfaceTextbox.Name = "surfaceTextbox";
            this.surfaceTextbox.Size = new System.Drawing.Size(100, 24);
            this.surfaceTextbox.TabIndex = 7;
            // 
            // addApartmentButton
            // 
            this.addApartmentButton.Location = new System.Drawing.Point(328, 272);
            this.addApartmentButton.Name = "addApartmentButton";
            this.addApartmentButton.Size = new System.Drawing.Size(114, 23);
            this.addApartmentButton.TabIndex = 8;
            this.addApartmentButton.Text = "Adauga apartament";
            this.addApartmentButton.UseVisualStyleBackColor = true;
            this.addApartmentButton.Click += new System.EventHandler(this.addApartmentButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(463, 272);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Anuleaza";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorMessageLabel.Location = new System.Drawing.Point(12, 193);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(537, 76);
            this.errorMessageLabel.TabIndex = 10;
            // 
            // AddApartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 307);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addApartmentButton);
            this.Controls.Add(this.surfaceTextbox);
            this.Controls.Add(this.noResidentsTextbox);
            this.Controls.Add(this.ownerTextbox);
            this.Controls.Add(this.noApartmentTextbox);
            this.Controls.Add(this.surfaceLabel);
            this.Controls.Add(this.noResidentsLabel);
            this.Controls.Add(this.ownerLabel);
            this.Controls.Add(this.noApartmentLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddApartmentForm";
            this.Text = "Panou adaugare apartament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noApartmentLabel;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Label noResidentsLabel;
        private System.Windows.Forms.Label surfaceLabel;
        private System.Windows.Forms.TextBox noApartmentTextbox;
        private System.Windows.Forms.TextBox ownerTextbox;
        private System.Windows.Forms.TextBox noResidentsTextbox;
        private System.Windows.Forms.TextBox surfaceTextbox;
        private System.Windows.Forms.Button addApartmentButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label errorMessageLabel;
    }
}