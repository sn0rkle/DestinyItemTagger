namespace DestinyItemTagger
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.listArmourWithPerkSets = new System.Windows.Forms.ListBox();
            this.listArmourWithPerkRecomendations = new System.Windows.Forms.ListBox();
            this.txtArmourPerkScoreLevel = new System.Windows.Forms.TextBox();
            this.groupArmour = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkIncludeArmourForInfusion = new System.Windows.Forms.CheckBox();
            this.listArmourForInfusion = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCurrentPowerLevel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkIncludeWeaponsForInfusion = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listWeaponsForInfusion = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWeaponPerkScoreLevel = new System.Windows.Forms.TextBox();
            this.listWeaponsWithPerkRecommendations = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listWeaponsWithPerkSets = new System.Windows.Forms.ListBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupArmour.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listArmourWithPerkSets
            // 
            this.listArmourWithPerkSets.BackColor = System.Drawing.SystemColors.Window;
            this.listArmourWithPerkSets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listArmourWithPerkSets.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listArmourWithPerkSets.FormattingEnabled = true;
            this.listArmourWithPerkSets.ItemHeight = 17;
            this.listArmourWithPerkSets.Location = new System.Drawing.Point(10, 61);
            this.listArmourWithPerkSets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listArmourWithPerkSets.Name = "listArmourWithPerkSets";
            this.listArmourWithPerkSets.Size = new System.Drawing.Size(199, 255);
            this.listArmourWithPerkSets.TabIndex = 1;
            // 
            // listArmourWithPerkRecomendations
            // 
            this.listArmourWithPerkRecomendations.BackColor = System.Drawing.SystemColors.Window;
            this.listArmourWithPerkRecomendations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listArmourWithPerkRecomendations.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listArmourWithPerkRecomendations.FormattingEnabled = true;
            this.listArmourWithPerkRecomendations.ItemHeight = 17;
            this.listArmourWithPerkRecomendations.Location = new System.Drawing.Point(217, 78);
            this.listArmourWithPerkRecomendations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listArmourWithPerkRecomendations.Name = "listArmourWithPerkRecomendations";
            this.listArmourWithPerkRecomendations.Size = new System.Drawing.Size(230, 238);
            this.listArmourWithPerkRecomendations.TabIndex = 2;
            // 
            // txtArmourPerkScoreLevel
            // 
            this.txtArmourPerkScoreLevel.BackColor = System.Drawing.SystemColors.Control;
            this.txtArmourPerkScoreLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArmourPerkScoreLevel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArmourPerkScoreLevel.Location = new System.Drawing.Point(217, 56);
            this.txtArmourPerkScoreLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArmourPerkScoreLevel.Name = "txtArmourPerkScoreLevel";
            this.txtArmourPerkScoreLevel.Size = new System.Drawing.Size(35, 15);
            this.txtArmourPerkScoreLevel.TabIndex = 3;
            this.txtArmourPerkScoreLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArmourPerkScoreLevel.TextChanged += new System.EventHandler(this.TxtArmourPerkScoreLevel_TextChanged);
            // 
            // groupArmour
            // 
            this.groupArmour.Controls.Add(this.label9);
            this.groupArmour.Controls.Add(this.chkIncludeArmourForInfusion);
            this.groupArmour.Controls.Add(this.listArmourForInfusion);
            this.groupArmour.Controls.Add(this.label4);
            this.groupArmour.Controls.Add(this.label3);
            this.groupArmour.Controls.Add(this.label2);
            this.groupArmour.Controls.Add(this.txtArmourPerkScoreLevel);
            this.groupArmour.Controls.Add(this.listArmourWithPerkRecomendations);
            this.groupArmour.Controls.Add(this.listArmourWithPerkSets);
            this.groupArmour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupArmour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupArmour.Location = new System.Drawing.Point(6, 88);
            this.groupArmour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupArmour.Name = "groupArmour";
            this.groupArmour.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupArmour.Size = new System.Drawing.Size(667, 324);
            this.groupArmour.TabIndex = 4;
            this.groupArmour.TabStop = false;
            this.groupArmour.Text = "Armour";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(452, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Armour for Infusion";
            // 
            // chkIncludeArmourForInfusion
            // 
            this.chkIncludeArmourForInfusion.AutoSize = true;
            this.chkIncludeArmourForInfusion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkIncludeArmourForInfusion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeArmourForInfusion.Location = new System.Drawing.Point(456, 55);
            this.chkIncludeArmourForInfusion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkIncludeArmourForInfusion.Name = "chkIncludeArmourForInfusion";
            this.chkIncludeArmourForInfusion.Size = new System.Drawing.Size(180, 21);
            this.chkIncludeArmourForInfusion.TabIndex = 8;
            this.chkIncludeArmourForInfusion.Text = "Include Armour for Infusion";
            this.chkIncludeArmourForInfusion.UseVisualStyleBackColor = true;
            this.chkIncludeArmourForInfusion.CheckedChanged += new System.EventHandler(this.ChkIncludeArmourForInfusion_CheckedChanged);
            // 
            // listArmourForInfusion
            // 
            this.listArmourForInfusion.BackColor = System.Drawing.SystemColors.Window;
            this.listArmourForInfusion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listArmourForInfusion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listArmourForInfusion.FormattingEnabled = true;
            this.listArmourForInfusion.ItemHeight = 17;
            this.listArmourForInfusion.Location = new System.Drawing.Point(456, 78);
            this.listArmourForInfusion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listArmourForInfusion.Name = "listArmourForInfusion";
            this.listArmourForInfusion.Size = new System.Drawing.Size(199, 238);
            this.listArmourForInfusion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Perk Score Required";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Armour Meeting Perk Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Armour with Perk Set";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Current Power Level";
            // 
            // txtCurrentPowerLevel
            // 
            this.txtCurrentPowerLevel.BackColor = System.Drawing.SystemColors.Control;
            this.txtCurrentPowerLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentPowerLevel.Location = new System.Drawing.Point(264, 63);
            this.txtCurrentPowerLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurrentPowerLevel.Name = "txtCurrentPowerLevel";
            this.txtCurrentPowerLevel.Size = new System.Drawing.Size(35, 15);
            this.txtCurrentPowerLevel.TabIndex = 7;
            this.txtCurrentPowerLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCurrentPowerLevel.TextChanged += new System.EventHandler(this.TxtCurrentPowerLevel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Destiny Item Tagger";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.chkIncludeWeaponsForInfusion);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.listWeaponsForInfusion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtWeaponPerkScoreLevel);
            this.groupBox1.Controls.Add(this.listWeaponsWithPerkRecommendations);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.listWeaponsWithPerkSets);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 416);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(667, 324);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weapons";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(452, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Weapons for Infusion";
            // 
            // chkIncludeWeaponsForInfusion
            // 
            this.chkIncludeWeaponsForInfusion.AutoSize = true;
            this.chkIncludeWeaponsForInfusion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkIncludeWeaponsForInfusion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeWeaponsForInfusion.Location = new System.Drawing.Point(455, 53);
            this.chkIncludeWeaponsForInfusion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkIncludeWeaponsForInfusion.Name = "chkIncludeWeaponsForInfusion";
            this.chkIncludeWeaponsForInfusion.Size = new System.Drawing.Size(194, 21);
            this.chkIncludeWeaponsForInfusion.TabIndex = 7;
            this.chkIncludeWeaponsForInfusion.Text = "Include Weapons for Infusion";
            this.chkIncludeWeaponsForInfusion.UseVisualStyleBackColor = true;
            this.chkIncludeWeaponsForInfusion.CheckedChanged += new System.EventHandler(this.ChkIncludeWeaponsForInfusion_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(619, -377);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 27);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.TxtCurrentPowerLevel_TextChanged);
            // 
            // listWeaponsForInfusion
            // 
            this.listWeaponsForInfusion.BackColor = System.Drawing.SystemColors.Window;
            this.listWeaponsForInfusion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listWeaponsForInfusion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listWeaponsForInfusion.FormattingEnabled = true;
            this.listWeaponsForInfusion.ItemHeight = 17;
            this.listWeaponsForInfusion.Location = new System.Drawing.Point(456, 78);
            this.listWeaponsForInfusion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listWeaponsForInfusion.Name = "listWeaponsForInfusion";
            this.listWeaponsForInfusion.Size = new System.Drawing.Size(199, 238);
            this.listWeaponsForInfusion.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Perk Score Required";
            // 
            // txtWeaponPerkScoreLevel
            // 
            this.txtWeaponPerkScoreLevel.BackColor = System.Drawing.SystemColors.Control;
            this.txtWeaponPerkScoreLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWeaponPerkScoreLevel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeaponPerkScoreLevel.Location = new System.Drawing.Point(217, 57);
            this.txtWeaponPerkScoreLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWeaponPerkScoreLevel.Name = "txtWeaponPerkScoreLevel";
            this.txtWeaponPerkScoreLevel.Size = new System.Drawing.Size(35, 15);
            this.txtWeaponPerkScoreLevel.TabIndex = 3;
            this.txtWeaponPerkScoreLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWeaponPerkScoreLevel.TextChanged += new System.EventHandler(this.TxtWeaponPerkScoreLevel_TextChanged);
            // 
            // listWeaponsWithPerkRecommendations
            // 
            this.listWeaponsWithPerkRecommendations.BackColor = System.Drawing.SystemColors.Window;
            this.listWeaponsWithPerkRecommendations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listWeaponsWithPerkRecommendations.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listWeaponsWithPerkRecommendations.FormattingEnabled = true;
            this.listWeaponsWithPerkRecommendations.ItemHeight = 17;
            this.listWeaponsWithPerkRecommendations.Location = new System.Drawing.Point(217, 78);
            this.listWeaponsWithPerkRecommendations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listWeaponsWithPerkRecommendations.Name = "listWeaponsWithPerkRecommendations";
            this.listWeaponsWithPerkRecommendations.Size = new System.Drawing.Size(230, 238);
            this.listWeaponsWithPerkRecommendations.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Weapons Meeting Perk Score";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Weapons with Perk Set";
            // 
            // listWeaponsWithPerkSets
            // 
            this.listWeaponsWithPerkSets.BackColor = System.Drawing.SystemColors.Window;
            this.listWeaponsWithPerkSets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listWeaponsWithPerkSets.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listWeaponsWithPerkSets.FormattingEnabled = true;
            this.listWeaponsWithPerkSets.ItemHeight = 17;
            this.listWeaponsWithPerkSets.Location = new System.Drawing.Point(10, 61);
            this.listWeaponsWithPerkSets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listWeaponsWithPerkSets.Name = "listWeaponsWithPerkSets";
            this.listWeaponsWithPerkSets.Size = new System.Drawing.Size(199, 255);
            this.listWeaponsWithPerkSets.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.SystemColors.Control;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(6, 745);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(667, 62);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(679, 814);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtCurrentPowerLevel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupArmour);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "DiT";
            this.groupArmour.ResumeLayout(false);
            this.groupArmour.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listArmourWithPerkSets;
        private System.Windows.Forms.ListBox listArmourWithPerkRecomendations;
        private System.Windows.Forms.TextBox txtArmourPerkScoreLevel;
        private System.Windows.Forms.GroupBox groupArmour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWeaponPerkScoreLevel;
        private System.Windows.Forms.ListBox listWeaponsWithPerkRecommendations;
        private System.Windows.Forms.ListBox listWeaponsWithPerkSets;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCurrentPowerLevel;
        private System.Windows.Forms.ListBox listArmourForInfusion;
        private System.Windows.Forms.ListBox listWeaponsForInfusion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkIncludeArmourForInfusion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkIncludeWeaponsForInfusion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

