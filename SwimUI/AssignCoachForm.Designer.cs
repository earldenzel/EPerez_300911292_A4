namespace SwimUI
{
    partial class AssignCoachForm
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
            this.btnAssignCoach = new System.Windows.Forms.Button();
            this.lblClubInfo = new System.Windows.Forms.Label();
            this.cmbCoaches = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAssignCoach
            // 
            this.btnAssignCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignCoach.Location = new System.Drawing.Point(277, 12);
            this.btnAssignCoach.Name = "btnAssignCoach";
            this.btnAssignCoach.Size = new System.Drawing.Size(83, 28);
            this.btnAssignCoach.TabIndex = 21;
            this.btnAssignCoach.Text = "Assign";
            this.btnAssignCoach.UseVisualStyleBackColor = true;
            this.btnAssignCoach.Click += new System.EventHandler(this.btnAssignCoach_Click);
            // 
            // lblClubInfo
            // 
            this.lblClubInfo.AutoSize = true;
            this.lblClubInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubInfo.Location = new System.Drawing.Point(7, 15);
            this.lblClubInfo.Name = "lblClubInfo";
            this.lblClubInfo.Size = new System.Drawing.Size(137, 20);
            this.lblClubInfo.TabIndex = 20;
            this.lblClubInfo.Text = "Coaches available";
            // 
            // cmbCoaches
            // 
            this.cmbCoaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoaches.FormattingEnabled = true;
            this.cmbCoaches.Location = new System.Drawing.Point(150, 12);
            this.cmbCoaches.Name = "cmbCoaches";
            this.cmbCoaches.Size = new System.Drawing.Size(121, 28);
            this.cmbCoaches.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(366, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 28);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(8, 47);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(188, 48);
            this.lblCopyright.TabIndex = 65;
            this.lblCopyright.Text = "Copyright by:\r\nEarl Denzel Perez - 300911292\r\nVictor Almeida - 300915237";
            // 
            // AssignCoachForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 104);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAssignCoach);
            this.Controls.Add(this.lblClubInfo);
            this.Controls.Add(this.cmbCoaches);
            this.Name = "AssignCoachForm";
            this.Text = "AssignCoachForm";
            this.Load += new System.EventHandler(this.AssignCoachForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAssignCoach;
        private System.Windows.Forms.Label lblClubInfo;
        private System.Windows.Forms.ComboBox cmbCoaches;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCopyright;
    }
}