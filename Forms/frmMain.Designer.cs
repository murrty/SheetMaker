namespace SheetMaker {
    partial class frmMain {
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mSettings = new System.Windows.Forms.MenuItem();
            this.mAbout = new System.Windows.Forms.MenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tbCUE = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPerformer = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtCuePerformer = new System.Windows.Forms.TextBox();
            this.txtCueTitle = new System.Windows.Forms.TextBox();
            this.txtCueDate = new System.Windows.Forms.TextBox();
            this.txtCueGenre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSep = new System.Windows.Forms.Label();
            this.lbCUE = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabcueSingle = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.lbCueTracks = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBrws = new System.Windows.Forms.Button();
            this.txtCueFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStTitle = new System.Windows.Forms.TextBox();
            this.txtStArtist = new System.Windows.Forms.TextBox();
            this.txtStIndex = new System.Windows.Forms.TextBox();
            this.txtScuePerformer = new System.Windows.Forms.TextBox();
            this.txtScueTitle = new System.Windows.Forms.TextBox();
            this.txtScueDate = new System.Windows.Forms.TextBox();
            this.txtScueGenre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbM3U8 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lbM3U8 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tbCUE.SuspendLayout();
            this.tabcueSingle.SuspendLayout();
            this.tbM3U8.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mSettings,
            this.mAbout});
            // 
            // mSettings
            // 
            this.mSettings.Index = 0;
            this.mSettings.Text = "Settings";
            this.mSettings.Click += new System.EventHandler(this.mSettings_Click);
            // 
            // mAbout
            // 
            this.mAbout.Index = 1;
            this.mAbout.Text = "About";
            this.mAbout.Click += new System.EventHandler(this.mAbout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 32);
            this.panel1.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(280, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 20);
            this.txtName.TabIndex = 11;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(26, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(185, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(440, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tbCUE);
            this.tcMain.Controls.Add(this.tabcueSingle);
            this.tcMain.Controls.Add(this.tbM3U8);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(522, 338);
            this.tcMain.TabIndex = 0;
            // 
            // tbCUE
            // 
            this.tbCUE.Controls.Add(this.label5);
            this.tbCUE.Controls.Add(this.txtTitle);
            this.tbCUE.Controls.Add(this.txtPerformer);
            this.tbCUE.Controls.Add(this.txtIndex);
            this.tbCUE.Controls.Add(this.txtCuePerformer);
            this.tbCUE.Controls.Add(this.txtCueTitle);
            this.tbCUE.Controls.Add(this.txtCueDate);
            this.tbCUE.Controls.Add(this.txtCueGenre);
            this.tbCUE.Controls.Add(this.label4);
            this.tbCUE.Controls.Add(this.lbSep);
            this.tbCUE.Controls.Add(this.lbCUE);
            this.tbCUE.Controls.Add(this.label3);
            this.tbCUE.Location = new System.Drawing.Point(4, 22);
            this.tbCUE.Name = "tbCUE";
            this.tbCUE.Padding = new System.Windows.Forms.Padding(3);
            this.tbCUE.Size = new System.Drawing.Size(514, 312);
            this.tbCUE.TabIndex = 0;
            this.tbCUE.Text = "cue (multiple files)";
            this.tbCUE.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Selected file information";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(287, 204);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(174, 20);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtPerformer
            // 
            this.txtPerformer.Location = new System.Drawing.Point(310, 234);
            this.txtPerformer.Name = "txtPerformer";
            this.txtPerformer.Size = new System.Drawing.Size(127, 20);
            this.txtPerformer.TabIndex = 6;
            this.txtPerformer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPerformer.TextChanged += new System.EventHandler(this.txtPerformer_TextChanged);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(311, 264);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(127, 20);
            this.txtIndex.TabIndex = 7;
            this.txtIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIndex.TextChanged += new System.EventHandler(this.txtIndex_TextChanged);
            // 
            // txtCuePerformer
            // 
            this.txtCuePerformer.Location = new System.Drawing.Point(311, 70);
            this.txtCuePerformer.Name = "txtCuePerformer";
            this.txtCuePerformer.Size = new System.Drawing.Size(127, 20);
            this.txtCuePerformer.TabIndex = 2;
            this.txtCuePerformer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCueTitle
            // 
            this.txtCueTitle.Location = new System.Drawing.Point(298, 40);
            this.txtCueTitle.Name = "txtCueTitle";
            this.txtCueTitle.Size = new System.Drawing.Size(151, 20);
            this.txtCueTitle.TabIndex = 1;
            this.txtCueTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCueDate
            // 
            this.txtCueDate.Location = new System.Drawing.Point(343, 130);
            this.txtCueDate.Name = "txtCueDate";
            this.txtCueDate.Size = new System.Drawing.Size(63, 20);
            this.txtCueDate.TabIndex = 4;
            this.txtCueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCueGenre
            // 
            this.txtCueGenre.Location = new System.Drawing.Point(315, 100);
            this.txtCueGenre.Name = "txtCueGenre";
            this.txtCueGenre.Size = new System.Drawing.Size(119, 20);
            this.txtCueGenre.TabIndex = 3;
            this.txtCueGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CUE information:";
            // 
            // lbSep
            // 
            this.lbSep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSep.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbSep.Location = new System.Drawing.Point(264, 167);
            this.lbSep.Name = "lbSep";
            this.lbSep.Size = new System.Drawing.Size(230, 2);
            this.lbSep.TabIndex = 4;
            this.lbSep.Text = "Shh";
            // 
            // lbCUE
            // 
            this.lbCUE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCUE.FormattingEnabled = true;
            this.lbCUE.Location = new System.Drawing.Point(20, 22);
            this.lbCUE.Name = "lbCUE";
            this.lbCUE.ScrollAlwaysVisible = true;
            this.lbCUE.Size = new System.Drawing.Size(219, 264);
            this.lbCUE.TabIndex = 0;
            this.lbCUE.SelectedIndexChanged += new System.EventHandler(this.lbCUE_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Files";
            // 
            // tabcueSingle
            // 
            this.tabcueSingle.Controls.Add(this.label11);
            this.tabcueSingle.Controls.Add(this.lbCueTracks);
            this.tabcueSingle.Controls.Add(this.label10);
            this.tabcueSingle.Controls.Add(this.btnBrws);
            this.tabcueSingle.Controls.Add(this.txtCueFile);
            this.tabcueSingle.Controls.Add(this.label6);
            this.tabcueSingle.Controls.Add(this.txtStTitle);
            this.tabcueSingle.Controls.Add(this.txtStArtist);
            this.tabcueSingle.Controls.Add(this.txtStIndex);
            this.tabcueSingle.Controls.Add(this.txtScuePerformer);
            this.tabcueSingle.Controls.Add(this.txtScueTitle);
            this.tabcueSingle.Controls.Add(this.txtScueDate);
            this.tabcueSingle.Controls.Add(this.txtScueGenre);
            this.tabcueSingle.Controls.Add(this.label7);
            this.tabcueSingle.Controls.Add(this.label8);
            this.tabcueSingle.Controls.Add(this.label9);
            this.tabcueSingle.Location = new System.Drawing.Point(4, 22);
            this.tabcueSingle.Name = "tabcueSingle";
            this.tabcueSingle.Padding = new System.Windows.Forms.Padding(3);
            this.tabcueSingle.Size = new System.Drawing.Size(514, 312);
            this.tabcueSingle.TabIndex = 2;
            this.tabcueSingle.Text = "cue (single file)";
            this.tabcueSingle.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Tracks";
            // 
            // lbCueTracks
            // 
            this.lbCueTracks.FormattingEnabled = true;
            this.lbCueTracks.Location = new System.Drawing.Point(22, 74);
            this.lbCueTracks.Name = "lbCueTracks";
            this.lbCueTracks.Size = new System.Drawing.Size(219, 225);
            this.lbCueTracks.TabIndex = 29;
            this.lbCueTracks.SelectedIndexChanged += new System.EventHandler(this.lbCueTracks_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Location = new System.Drawing.Point(267, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 2);
            this.label10.TabIndex = 28;
            this.label10.Text = "Shh";
            // 
            // btnBrws
            // 
            this.btnBrws.Location = new System.Drawing.Point(476, 22);
            this.btnBrws.Name = "btnBrws";
            this.btnBrws.Size = new System.Drawing.Size(24, 23);
            this.btnBrws.TabIndex = 27;
            this.btnBrws.Text = "...";
            this.btnBrws.UseVisualStyleBackColor = true;
            this.btnBrws.Click += new System.EventHandler(this.btnBrws_Click);
            // 
            // txtCueFile
            // 
            this.txtCueFile.Location = new System.Drawing.Point(23, 24);
            this.txtCueFile.Name = "txtCueFile";
            this.txtCueFile.ReadOnly = true;
            this.txtCueFile.Size = new System.Drawing.Size(447, 20);
            this.txtCueFile.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Selected track information";
            // 
            // txtStTitle
            // 
            this.txtStTitle.Location = new System.Drawing.Point(303, 227);
            this.txtStTitle.Name = "txtStTitle";
            this.txtStTitle.Size = new System.Drawing.Size(174, 20);
            this.txtStTitle.TabIndex = 21;
            this.txtStTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStTitle.TextChanged += new System.EventHandler(this.txtStTitle_TextChanged);
            // 
            // txtStArtist
            // 
            this.txtStArtist.Location = new System.Drawing.Point(327, 253);
            this.txtStArtist.Name = "txtStArtist";
            this.txtStArtist.Size = new System.Drawing.Size(127, 20);
            this.txtStArtist.TabIndex = 23;
            this.txtStArtist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStArtist.TextChanged += new System.EventHandler(this.txtStArtist_TextChanged);
            // 
            // txtStIndex
            // 
            this.txtStIndex.Location = new System.Drawing.Point(327, 279);
            this.txtStIndex.Name = "txtStIndex";
            this.txtStIndex.Size = new System.Drawing.Size(127, 20);
            this.txtStIndex.TabIndex = 24;
            this.txtStIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStIndex.TextChanged += new System.EventHandler(this.txtStIndex_TextChanged);
            // 
            // txtScuePerformer
            // 
            this.txtScuePerformer.Location = new System.Drawing.Point(327, 102);
            this.txtScuePerformer.Name = "txtScuePerformer";
            this.txtScuePerformer.Size = new System.Drawing.Size(127, 20);
            this.txtScuePerformer.TabIndex = 16;
            this.txtScuePerformer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtScueTitle
            // 
            this.txtScueTitle.Location = new System.Drawing.Point(314, 76);
            this.txtScueTitle.Name = "txtScueTitle";
            this.txtScueTitle.Size = new System.Drawing.Size(151, 20);
            this.txtScueTitle.TabIndex = 15;
            this.txtScueTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtScueDate
            // 
            this.txtScueDate.Location = new System.Drawing.Point(359, 154);
            this.txtScueDate.Name = "txtScueDate";
            this.txtScueDate.Size = new System.Drawing.Size(63, 20);
            this.txtScueDate.TabIndex = 19;
            this.txtScueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtScueGenre
            // 
            this.txtScueGenre.Location = new System.Drawing.Point(331, 128);
            this.txtScueGenre.Name = "txtScueGenre";
            this.txtScueGenre.Size = new System.Drawing.Size(119, 20);
            this.txtScueGenre.TabIndex = 18;
            this.txtScueGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "CUE information:";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Location = new System.Drawing.Point(264, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 158);
            this.label8.TabIndex = 20;
            this.label8.Text = "Shh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "File";
            // 
            // tbM3U8
            // 
            this.tbM3U8.Controls.Add(this.label2);
            this.tbM3U8.Controls.Add(this.lbM3U8);
            this.tbM3U8.Controls.Add(this.label1);
            this.tbM3U8.Location = new System.Drawing.Point(4, 22);
            this.tbM3U8.Name = "tbM3U8";
            this.tbM3U8.Padding = new System.Windows.Forms.Padding(3);
            this.tbM3U8.Size = new System.Drawing.Size(514, 312);
            this.tbM3U8.TabIndex = 1;
            this.tbM3U8.Text = "m3u8";
            this.tbM3U8.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 65);
            this.label2.TabIndex = 2;
            this.label2.Text = "No additional options.\r\n\r\n\r\n\r\nbased m3u8 for easy playlists";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbM3U8
            // 
            this.lbM3U8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbM3U8.FormattingEnabled = true;
            this.lbM3U8.Location = new System.Drawing.Point(22, 22);
            this.lbM3U8.Name = "lbM3U8";
            this.lbM3U8.ScrollAlwaysVisible = true;
            this.lbM3U8.Size = new System.Drawing.Size(219, 251);
            this.lbM3U8.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Files";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 370);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.panel1);
            this.Menu = this.mainMenu1;
            this.MinimumSize = new System.Drawing.Size(530, 400);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SheetMaker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tbCUE.ResumeLayout(false);
            this.tbCUE.PerformLayout();
            this.tabcueSingle.ResumeLayout(false);
            this.tabcueSingle.PerformLayout();
            this.tbM3U8.ResumeLayout(false);
            this.tbM3U8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem mAbout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tbCUE;
        private System.Windows.Forms.TabPage tbM3U8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbM3U8;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbCUE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCuePerformer;
        private System.Windows.Forms.TextBox txtCueTitle;
        private System.Windows.Forms.TextBox txtCueDate;
        private System.Windows.Forms.TextBox txtCueGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSep;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPerformer;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabcueSingle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStTitle;
        private System.Windows.Forms.TextBox txtStArtist;
        private System.Windows.Forms.TextBox txtStIndex;
        private System.Windows.Forms.TextBox txtScuePerformer;
        private System.Windows.Forms.TextBox txtScueTitle;
        private System.Windows.Forms.TextBox txtScueDate;
        private System.Windows.Forms.TextBox txtScueGenre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCueFile;
        private System.Windows.Forms.Button btnBrws;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbCueTracks;
        private System.Windows.Forms.MenuItem mSettings;
    }
}

