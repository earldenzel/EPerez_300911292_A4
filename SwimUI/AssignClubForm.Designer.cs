namespace SwimUI
{
    partial class AssignClubForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbClubs = new System.Windows.Forms.ComboBox();
            this.lblClubInfo = new System.Windows.Forms.Label();
            this.btnAssignClub = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbClubs
            // 
            this.cmbClubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClubs.FormattingEnabled = true;
            this.cmbClubs.Location = new System.Drawing.Point(132, 10);
            this.cmbClubs.Name = "cmbClubs";
            this.cmbClubs.Size = new System.Drawing.Size(121, 28);
            this.cmbClubs.TabIndex = 0;
            // 
            // lblClubInfo
            // 
            this.lblClubInfo.AutoSize = true;
            this.lblClubInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubInfo.Location = new System.Drawing.Point(12, 13);
            this.lblClubInfo.Name = "lblClubInfo";
            this.lblClubInfo.Size = new System.Drawing.Size(114, 20);
            this.lblClubInfo.TabIndex = 5;
            this.lblClubInfo.Text = "Clubs available";
            // 
            // btnAssignClub
            // 
            this.btnAssignClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignClub.Location = new System.Drawing.Point(259, 10);
            this.btnAssignClub.Name = "btnAssignClub";
            this.btnAssignClub.Size = new System.Drawing.Size(83, 28);
            this.btnAssignClub.TabIndex = 18;
            this.btnAssignClub.Text = "Assign";
            this.btnAssignClub.UseVisualStyleBackColor = true;
            this.btnAssignClub.Click += new System.EventHandler(this.btnAssignClub_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(348, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 28);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(0, 41);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(188, 48);
            this.lblCopyright.TabIndex = 65;
            this.lblCopyright.Text = "Copyright by:\r\nEarl Denzel Perez - 300911292\r\nVictor Almeida - 300915237";
            // 
            // AssignClubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 92);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAssignClub);
            this.Controls.Add(this.lblClubInfo);
            this.Controls.Add(this.cmbClubs);
            this.Name = "AssignClubForm";
            this.Text = "AssignClubForm";
            this.Load += new System.EventHandler(this.AssignClubForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClubs;
        private System.Windows.Forms.Label lblClubInfo;
        private System.Windows.Forms.Button btnAssignClub;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCopyright;
    }
}