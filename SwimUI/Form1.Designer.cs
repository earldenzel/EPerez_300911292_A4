namespace SwimUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addClubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swimmersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSwimmersFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSwimmersFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addSwimmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coachesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCoachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swimMeetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSwimMeetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbClubs = new System.Windows.Forms.ListBox();
            this.lblClubInfo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoadClub = new System.Windows.Forms.Button();
            this.btnLoadSwimmers = new System.Windows.Forms.Button();
            this.btnAddSwimmer = new System.Windows.Forms.Button();
            this.lblSwimmerInfo = new System.Windows.Forms.Label();
            this.lsbSwimmers = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpSwimmers = new System.Windows.Forms.GroupBox();
            this.btnSaveSwimmers = new System.Windows.Forms.Button();
            this.btnAssignCoach = new System.Windows.Forms.Button();
            this.btnAssignClubSwimmer = new System.Windows.Forms.Button();
            this.grpClubs = new System.Windows.Forms.GroupBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.btnSeeAllCoaches = new System.Windows.Forms.Button();
            this.btnSeeCoaches = new System.Windows.Forms.Button();
            this.btnSeeAllSwimmers = new System.Windows.Forms.Button();
            this.btnSeeSwimmers = new System.Windows.Forms.Button();
            this.btnSaveClubs = new System.Windows.Forms.Button();
            this.grpSwimMeet = new System.Windows.Forms.GroupBox();
            this.btnAssignToEvent = new System.Windows.Forms.Button();
            this.btnAddSwimMeet = new System.Windows.Forms.Button();
            this.btnSeed = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lsbSwimMeets = new System.Windows.Forms.ListBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.lblSwimMeetInfo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.grpCoaches = new System.Windows.Forms.GroupBox();
            this.btnAssignClub = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lsbCoaches = new System.Windows.Forms.ListBox();
            this.btnAddCoach = new System.Windows.Forms.Button();
            this.lblCoachInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpSwimmers.SuspendLayout();
            this.grpClubs.SuspendLayout();
            this.grpSwimMeet.SuspendLayout();
            this.grpCoaches.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clubs";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.swimmersToolStripMenuItem,
            this.coachesToolStripMenuItem,
            this.swimMeetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1211, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.addClubToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.fileToolStripMenuItem.Text = "Clubs";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.loadFileToolStripMenuItem.Text = "Load Clubs File";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveFileToolStripMenuItem.Text = "Save Clubs File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // addClubToolStripMenuItem
            // 
            this.addClubToolStripMenuItem.Name = "addClubToolStripMenuItem";
            this.addClubToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addClubToolStripMenuItem.Text = "Add Club";
            this.addClubToolStripMenuItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // swimmersToolStripMenuItem
            // 
            this.swimmersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSwimmersFileToolStripMenuItem,
            this.saveSwimmersFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.addSwimmerToolStripMenuItem});
            this.swimmersToolStripMenuItem.Name = "swimmersToolStripMenuItem";
            this.swimmersToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.swimmersToolStripMenuItem.Text = "Swimmers";
            // 
            // loadSwimmersFileToolStripMenuItem
            // 
            this.loadSwimmersFileToolStripMenuItem.Name = "loadSwimmersFileToolStripMenuItem";
            this.loadSwimmersFileToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.loadSwimmersFileToolStripMenuItem.Text = "Load Swimmers File";
            this.loadSwimmersFileToolStripMenuItem.Click += new System.EventHandler(this.loadSwimmersFileToolStripMenuItem_Click);
            // 
            // saveSwimmersFileToolStripMenuItem
            // 
            this.saveSwimmersFileToolStripMenuItem.Name = "saveSwimmersFileToolStripMenuItem";
            this.saveSwimmersFileToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.saveSwimmersFileToolStripMenuItem.Text = "Save Swimmers File";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            // 
            // addSwimmerToolStripMenuItem
            // 
            this.addSwimmerToolStripMenuItem.Name = "addSwimmerToolStripMenuItem";
            this.addSwimmerToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.addSwimmerToolStripMenuItem.Text = "Add Swimmer";
            this.addSwimmerToolStripMenuItem.Click += new System.EventHandler(this.btnAddSwimmer_Click);
            // 
            // coachesToolStripMenuItem
            // 
            this.coachesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCoachToolStripMenuItem});
            this.coachesToolStripMenuItem.Name = "coachesToolStripMenuItem";
            this.coachesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.coachesToolStripMenuItem.Text = "Coaches";
            // 
            // addCoachToolStripMenuItem
            // 
            this.addCoachToolStripMenuItem.Name = "addCoachToolStripMenuItem";
            this.addCoachToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.addCoachToolStripMenuItem.Text = "Add Coach";
            this.addCoachToolStripMenuItem.Click += new System.EventHandler(this.btnAddCoach_Click);
            // 
            // swimMeetToolStripMenuItem
            // 
            this.swimMeetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createSwimMeetToolStripMenuItem});
            this.swimMeetToolStripMenuItem.Name = "swimMeetToolStripMenuItem";
            this.swimMeetToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.swimMeetToolStripMenuItem.Text = "Swim Meet";
            // 
            // createSwimMeetToolStripMenuItem
            // 
            this.createSwimMeetToolStripMenuItem.Name = "createSwimMeetToolStripMenuItem";
            this.createSwimMeetToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.createSwimMeetToolStripMenuItem.Text = "Create Swim Meet";
            this.createSwimMeetToolStripMenuItem.Click += new System.EventHandler(this.createSwimMeetToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Club Information";
            // 
            // lsbClubs
            // 
            this.lsbClubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbClubs.FormattingEnabled = true;
            this.lsbClubs.ItemHeight = 20;
            this.lsbClubs.Location = new System.Drawing.Point(21, 44);
            this.lsbClubs.Name = "lsbClubs";
            this.lsbClubs.Size = new System.Drawing.Size(178, 184);
            this.lsbClubs.TabIndex = 3;
            this.lsbClubs.SelectedIndexChanged += new System.EventHandler(this.lsbClubs_SelectedIndexChanged);
            // 
            // lblClubInfo
            // 
            this.lblClubInfo.AutoSize = true;
            this.lblClubInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubInfo.Location = new System.Drawing.Point(227, 44);
            this.lblClubInfo.Name = "lblClubInfo";
            this.lblClubInfo.Size = new System.Drawing.Size(119, 16);
            this.lblClubInfo.TabIndex = 4;
            this.lblClubInfo.Text = "No clubs selected.";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(21, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 40);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Club";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLoadClub
            // 
            this.btnLoadClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadClub.Location = new System.Drawing.Point(22, 391);
            this.btnLoadClub.Name = "btnLoadClub";
            this.btnLoadClub.Size = new System.Drawing.Size(88, 49);
            this.btnLoadClub.TabIndex = 6;
            this.btnLoadClub.Text = "Load Clubs";
            this.btnLoadClub.UseVisualStyleBackColor = true;
            this.btnLoadClub.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // btnLoadSwimmers
            // 
            this.btnLoadSwimmers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSwimmers.Location = new System.Drawing.Point(11, 351);
            this.btnLoadSwimmers.Name = "btnLoadSwimmers";
            this.btnLoadSwimmers.Size = new System.Drawing.Size(88, 49);
            this.btnLoadSwimmers.TabIndex = 12;
            this.btnLoadSwimmers.Text = "Load Swimmers";
            this.btnLoadSwimmers.UseVisualStyleBackColor = true;
            this.btnLoadSwimmers.Click += new System.EventHandler(this.loadSwimmersFileToolStripMenuItem_Click);
            // 
            // btnAddSwimmer
            // 
            this.btnAddSwimmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSwimmer.Location = new System.Drawing.Point(11, 241);
            this.btnAddSwimmer.Name = "btnAddSwimmer";
            this.btnAddSwimmer.Size = new System.Drawing.Size(88, 49);
            this.btnAddSwimmer.TabIndex = 11;
            this.btnAddSwimmer.Text = "Add Swimmer";
            this.btnAddSwimmer.UseVisualStyleBackColor = true;
            this.btnAddSwimmer.Click += new System.EventHandler(this.btnAddSwimmer_Click);
            // 
            // lblSwimmerInfo
            // 
            this.lblSwimmerInfo.AutoSize = true;
            this.lblSwimmerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwimmerInfo.Location = new System.Drawing.Point(210, 42);
            this.lblSwimmerInfo.Name = "lblSwimmerInfo";
            this.lblSwimmerInfo.Size = new System.Drawing.Size(147, 16);
            this.lblSwimmerInfo.TabIndex = 10;
            this.lblSwimmerInfo.Text = "No swimmers selected.";
            // 
            // lsbSwimmers
            // 
            this.lsbSwimmers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbSwimmers.FormattingEnabled = true;
            this.lsbSwimmers.ItemHeight = 20;
            this.lsbSwimmers.Location = new System.Drawing.Point(11, 43);
            this.lsbSwimmers.Name = "lsbSwimmers";
            this.lsbSwimmers.Size = new System.Drawing.Size(182, 184);
            this.lsbSwimmers.TabIndex = 9;
            this.lsbSwimmers.SelectedIndexChanged += new System.EventHandler(this.lsbSwimmers_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Swimmer Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Swimmers";
            // 
            // grpSwimmers
            // 
            this.grpSwimmers.Controls.Add(this.btnSaveSwimmers);
            this.grpSwimmers.Controls.Add(this.btnAssignCoach);
            this.grpSwimmers.Controls.Add(this.btnAssignClubSwimmer);
            this.grpSwimmers.Controls.Add(this.label5);
            this.grpSwimmers.Controls.Add(this.btnLoadSwimmers);
            this.grpSwimmers.Controls.Add(this.label4);
            this.grpSwimmers.Controls.Add(this.btnAddSwimmer);
            this.grpSwimmers.Controls.Add(this.lsbSwimmers);
            this.grpSwimmers.Controls.Add(this.lblSwimmerInfo);
            this.grpSwimmers.Location = new System.Drawing.Point(447, 27);
            this.grpSwimmers.Name = "grpSwimmers";
            this.grpSwimmers.Size = new System.Drawing.Size(410, 408);
            this.grpSwimmers.TabIndex = 13;
            this.grpSwimmers.TabStop = false;
            // 
            // btnSaveSwimmers
            // 
            this.btnSaveSwimmers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSwimmers.Location = new System.Drawing.Point(105, 351);
            this.btnSaveSwimmers.Name = "btnSaveSwimmers";
            this.btnSaveSwimmers.Size = new System.Drawing.Size(88, 49);
            this.btnSaveSwimmers.TabIndex = 15;
            this.btnSaveSwimmers.Text = "Save Swimmers";
            this.btnSaveSwimmers.UseVisualStyleBackColor = true;
            this.btnSaveSwimmers.Click += new System.EventHandler(this.btnSaveSwimmers_Click);
            // 
            // btnAssignCoach
            // 
            this.btnAssignCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignCoach.Location = new System.Drawing.Point(11, 296);
            this.btnAssignCoach.Name = "btnAssignCoach";
            this.btnAssignCoach.Size = new System.Drawing.Size(88, 49);
            this.btnAssignCoach.TabIndex = 14;
            this.btnAssignCoach.Text = "Assign Coach";
            this.btnAssignCoach.UseVisualStyleBackColor = true;
            this.btnAssignCoach.Click += new System.EventHandler(this.btnAssignCoach_Click);
            // 
            // btnAssignClubSwimmer
            // 
            this.btnAssignClubSwimmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignClubSwimmer.Location = new System.Drawing.Point(105, 296);
            this.btnAssignClubSwimmer.Name = "btnAssignClubSwimmer";
            this.btnAssignClubSwimmer.Size = new System.Drawing.Size(88, 49);
            this.btnAssignClubSwimmer.TabIndex = 13;
            this.btnAssignClubSwimmer.Text = "Assign Club";
            this.btnAssignClubSwimmer.UseVisualStyleBackColor = true;
            this.btnAssignClubSwimmer.Click += new System.EventHandler(this.btnAssignClubSwimmer_Click);
            // 
            // grpClubs
            // 
            this.grpClubs.Controls.Add(this.lblCopyright);
            this.grpClubs.Controls.Add(this.btnSeeAllCoaches);
            this.grpClubs.Controls.Add(this.btnSeeCoaches);
            this.grpClubs.Controls.Add(this.btnSeeAllSwimmers);
            this.grpClubs.Controls.Add(this.btnSeeSwimmers);
            this.grpClubs.Controls.Add(this.btnSaveClubs);
            this.grpClubs.Controls.Add(this.label1);
            this.grpClubs.Controls.Add(this.label2);
            this.grpClubs.Controls.Add(this.btnLoadClub);
            this.grpClubs.Controls.Add(this.lsbClubs);
            this.grpClubs.Controls.Add(this.btnAdd);
            this.grpClubs.Controls.Add(this.lblClubInfo);
            this.grpClubs.Location = new System.Drawing.Point(0, 27);
            this.grpClubs.Name = "grpClubs";
            this.grpClubs.Size = new System.Drawing.Size(441, 714);
            this.grpClubs.TabIndex = 14;
            this.grpClubs.TabStop = false;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(12, 602);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(188, 96);
            this.lblCopyright.TabIndex = 24;
            this.lblCopyright.Text = "Copyright by:\r\nEarl Denzel Perez - 300911292\r\nVictor Almeida - 300915237\r\nCOMP 12" +
    "3-003\r\nProf. Jake Nesovic\r\nWinter 2017";
            // 
            // btnSeeAllCoaches
            // 
            this.btnSeeAllCoaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeAllCoaches.Location = new System.Drawing.Point(111, 336);
            this.btnSeeAllCoaches.Name = "btnSeeAllCoaches";
            this.btnSeeAllCoaches.Size = new System.Drawing.Size(88, 49);
            this.btnSeeAllCoaches.TabIndex = 23;
            this.btnSeeAllCoaches.Text = "See All Coaches";
            this.btnSeeAllCoaches.UseVisualStyleBackColor = true;
            this.btnSeeAllCoaches.Click += new System.EventHandler(this.btnSeeAllCoaches_Click);
            // 
            // btnSeeCoaches
            // 
            this.btnSeeCoaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeCoaches.Location = new System.Drawing.Point(21, 336);
            this.btnSeeCoaches.Name = "btnSeeCoaches";
            this.btnSeeCoaches.Size = new System.Drawing.Size(88, 49);
            this.btnSeeCoaches.TabIndex = 22;
            this.btnSeeCoaches.Text = "See Coaches";
            this.btnSeeCoaches.UseVisualStyleBackColor = true;
            this.btnSeeCoaches.Click += new System.EventHandler(this.btnSeeCoaches_Click);
            // 
            // btnSeeAllSwimmers
            // 
            this.btnSeeAllSwimmers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeAllSwimmers.Location = new System.Drawing.Point(111, 281);
            this.btnSeeAllSwimmers.Name = "btnSeeAllSwimmers";
            this.btnSeeAllSwimmers.Size = new System.Drawing.Size(88, 49);
            this.btnSeeAllSwimmers.TabIndex = 21;
            this.btnSeeAllSwimmers.Text = "See All Swimmers";
            this.btnSeeAllSwimmers.UseVisualStyleBackColor = true;
            this.btnSeeAllSwimmers.Click += new System.EventHandler(this.btnSeeAllSwimmers_Click);
            // 
            // btnSeeSwimmers
            // 
            this.btnSeeSwimmers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeSwimmers.Location = new System.Drawing.Point(21, 281);
            this.btnSeeSwimmers.Name = "btnSeeSwimmers";
            this.btnSeeSwimmers.Size = new System.Drawing.Size(88, 49);
            this.btnSeeSwimmers.TabIndex = 20;
            this.btnSeeSwimmers.Text = "See Swimmers";
            this.btnSeeSwimmers.UseVisualStyleBackColor = true;
            this.btnSeeSwimmers.Click += new System.EventHandler(this.btnSeeSwimmers_Click);
            // 
            // btnSaveClubs
            // 
            this.btnSaveClubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClubs.Location = new System.Drawing.Point(111, 391);
            this.btnSaveClubs.Name = "btnSaveClubs";
            this.btnSaveClubs.Size = new System.Drawing.Size(88, 49);
            this.btnSaveClubs.TabIndex = 16;
            this.btnSaveClubs.Text = "Save Clubs";
            this.btnSaveClubs.UseVisualStyleBackColor = true;
            this.btnSaveClubs.Click += new System.EventHandler(this.btnSaveClubs_Click);
            // 
            // grpSwimMeet
            // 
            this.grpSwimMeet.Controls.Add(this.btnAssignToEvent);
            this.grpSwimMeet.Controls.Add(this.btnAddSwimMeet);
            this.grpSwimMeet.Controls.Add(this.btnSeed);
            this.grpSwimMeet.Controls.Add(this.label7);
            this.grpSwimMeet.Controls.Add(this.lsbSwimMeets);
            this.grpSwimMeet.Controls.Add(this.btnAddEvent);
            this.grpSwimMeet.Controls.Add(this.lblSwimMeetInfo);
            this.grpSwimMeet.Controls.Add(this.label9);
            this.grpSwimMeet.Location = new System.Drawing.Point(863, 27);
            this.grpSwimMeet.Name = "grpSwimMeet";
            this.grpSwimMeet.Size = new System.Drawing.Size(336, 722);
            this.grpSwimMeet.TabIndex = 18;
            this.grpSwimMeet.TabStop = false;
            // 
            // btnAssignToEvent
            // 
            this.btnAssignToEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignToEvent.Location = new System.Drawing.Point(175, 134);
            this.btnAssignToEvent.Name = "btnAssignToEvent";
            this.btnAssignToEvent.Size = new System.Drawing.Size(132, 40);
            this.btnAssignToEvent.TabIndex = 19;
            this.btnAssignToEvent.Text = "Assign Swimmers to Event";
            this.btnAssignToEvent.UseVisualStyleBackColor = true;
            this.btnAssignToEvent.Click += new System.EventHandler(this.btnAssignToEvent_Click);
            // 
            // btnAddSwimMeet
            // 
            this.btnAddSwimMeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSwimMeet.Location = new System.Drawing.Point(175, 42);
            this.btnAddSwimMeet.Name = "btnAddSwimMeet";
            this.btnAddSwimMeet.Size = new System.Drawing.Size(132, 40);
            this.btnAddSwimMeet.TabIndex = 18;
            this.btnAddSwimMeet.Text = "Add Swim Meet";
            this.btnAddSwimMeet.UseVisualStyleBackColor = true;
            this.btnAddSwimMeet.Click += new System.EventHandler(this.createSwimMeetToolStripMenuItem_Click);
            // 
            // btnSeed
            // 
            this.btnSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeed.Location = new System.Drawing.Point(175, 180);
            this.btnSeed.Name = "btnSeed";
            this.btnSeed.Size = new System.Drawing.Size(132, 40);
            this.btnSeed.TabIndex = 17;
            this.btnSeed.Text = "Seed";
            this.btnSeed.UseVisualStyleBackColor = true;
            this.btnSeed.Click += new System.EventHandler(this.btnSeed_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Swim Meet Information";
            // 
            // lsbSwimMeets
            // 
            this.lsbSwimMeets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbSwimMeets.FormattingEnabled = true;
            this.lsbSwimMeets.ItemHeight = 20;
            this.lsbSwimMeets.Location = new System.Drawing.Point(11, 42);
            this.lsbSwimMeets.Name = "lsbSwimMeets";
            this.lsbSwimMeets.Size = new System.Drawing.Size(158, 184);
            this.lsbSwimMeets.TabIndex = 16;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.Location = new System.Drawing.Point(175, 88);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(132, 40);
            this.btnAddEvent.TabIndex = 16;
            this.btnAddEvent.Text = "Add Events";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // lblSwimMeetInfo
            // 
            this.lblSwimMeetInfo.AutoSize = true;
            this.lblSwimMeetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwimMeetInfo.Location = new System.Drawing.Point(22, 261);
            this.lblSwimMeetInfo.Name = "lblSwimMeetInfo";
            this.lblSwimMeetInfo.Size = new System.Drawing.Size(147, 16);
            this.lblSwimMeetInfo.TabIndex = 7;
            this.lblSwimMeetInfo.Text = "No swim meet selected";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Swim Meets";
            // 
            // grpCoaches
            // 
            this.grpCoaches.Controls.Add(this.btnAssignClub);
            this.grpCoaches.Controls.Add(this.label6);
            this.grpCoaches.Controls.Add(this.lsbCoaches);
            this.grpCoaches.Controls.Add(this.btnAddCoach);
            this.grpCoaches.Controls.Add(this.lblCoachInfo);
            this.grpCoaches.Controls.Add(this.label3);
            this.grpCoaches.Location = new System.Drawing.Point(447, 441);
            this.grpCoaches.Name = "grpCoaches";
            this.grpCoaches.Size = new System.Drawing.Size(410, 308);
            this.grpCoaches.TabIndex = 19;
            this.grpCoaches.TabStop = false;
            // 
            // btnAssignClub
            // 
            this.btnAssignClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignClub.Location = new System.Drawing.Point(100, 244);
            this.btnAssignClub.Name = "btnAssignClub";
            this.btnAssignClub.Size = new System.Drawing.Size(83, 40);
            this.btnAssignClub.TabIndex = 17;
            this.btnAssignClub.Text = "Assign Club";
            this.btnAssignClub.UseVisualStyleBackColor = true;
            this.btnAssignClub.Click += new System.EventHandler(this.btnAssignClub_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(206, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Coach Information";
            // 
            // lsbCoaches
            // 
            this.lsbCoaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbCoaches.FormattingEnabled = true;
            this.lsbCoaches.ItemHeight = 20;
            this.lsbCoaches.Location = new System.Drawing.Point(11, 51);
            this.lsbCoaches.Name = "lsbCoaches";
            this.lsbCoaches.Size = new System.Drawing.Size(178, 184);
            this.lsbCoaches.TabIndex = 16;
            this.lsbCoaches.SelectedIndexChanged += new System.EventHandler(this.lsbCoaches_SelectedIndexChanged);
            // 
            // btnAddCoach
            // 
            this.btnAddCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCoach.Location = new System.Drawing.Point(11, 244);
            this.btnAddCoach.Name = "btnAddCoach";
            this.btnAddCoach.Size = new System.Drawing.Size(83, 40);
            this.btnAddCoach.TabIndex = 16;
            this.btnAddCoach.Text = "Add Coaches";
            this.btnAddCoach.UseVisualStyleBackColor = true;
            this.btnAddCoach.Click += new System.EventHandler(this.btnAddCoach_Click);
            // 
            // lblCoachInfo
            // 
            this.lblCoachInfo.AutoSize = true;
            this.lblCoachInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoachInfo.Location = new System.Drawing.Point(206, 44);
            this.lblCoachInfo.Name = "lblCoachInfo";
            this.lblCoachInfo.Size = new System.Drawing.Size(121, 16);
            this.lblCoachInfo.TabIndex = 7;
            this.lblCoachInfo.Text = "No coach selected";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Coaches";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 761);
            this.Controls.Add(this.grpCoaches);
            this.Controls.Add(this.grpSwimMeet);
            this.Controls.Add(this.grpClubs);
            this.Controls.Add(this.grpSwimmers);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "SwimUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSwimmers.ResumeLayout(false);
            this.grpSwimmers.PerformLayout();
            this.grpClubs.ResumeLayout(false);
            this.grpClubs.PerformLayout();
            this.grpSwimMeet.ResumeLayout(false);
            this.grpSwimMeet.PerformLayout();
            this.grpCoaches.ResumeLayout(false);
            this.grpCoaches.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addClubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem swimmersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSwimmersFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSwimmersFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addSwimmerToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbClubs;
        private System.Windows.Forms.Label lblClubInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoadClub;
        private System.Windows.Forms.Button btnLoadSwimmers;
        private System.Windows.Forms.Button btnAddSwimmer;
        private System.Windows.Forms.Label lblSwimmerInfo;
        private System.Windows.Forms.ListBox lsbSwimmers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpSwimmers;
        private System.Windows.Forms.GroupBox grpClubs;
        private System.Windows.Forms.ToolStripMenuItem coachesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCoachToolStripMenuItem;
        private System.Windows.Forms.Button btnAssignClubSwimmer;
        private System.Windows.Forms.Button btnAssignCoach;
        private System.Windows.Forms.ToolStripMenuItem swimMeetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSwimMeetToolStripMenuItem;
        private System.Windows.Forms.Button btnSaveSwimmers;
        private System.Windows.Forms.Button btnSaveClubs;
        private System.Windows.Forms.GroupBox grpSwimMeet;
        private System.Windows.Forms.Button btnAssignToEvent;
        private System.Windows.Forms.Button btnAddSwimMeet;
        private System.Windows.Forms.Button btnSeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lsbSwimMeets;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Label lblSwimMeetInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSeeSwimmers;
        private System.Windows.Forms.Button btnSeeAllSwimmers;
        private System.Windows.Forms.GroupBox grpCoaches;
        private System.Windows.Forms.Button btnAssignClub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lsbCoaches;
        private System.Windows.Forms.Button btnAddCoach;
        private System.Windows.Forms.Label lblCoachInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSeeAllCoaches;
        private System.Windows.Forms.Button btnSeeCoaches;
        private System.Windows.Forms.Label lblCopyright;
    }
}

