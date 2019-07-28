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
            this.btnGo = new System.Windows.Forms.Button();
            this.listArmourWithPerkSets = new System.Windows.Forms.ListBox();
            this.listArmourWithPerkRecomendations = new System.Windows.Forms.ListBox();
            this.txtArmourPerkScoreLevel = new System.Windows.Forms.TextBox();
            this.groupArmour = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWeaponPerkScoreLevel = new System.Windows.Forms.TextBox();
            this.listWeaponsWithPerkRecommendations = new System.Windows.Forms.ListBox();
            this.listWeaponsWithPerkSets = new System.Windows.Forms.ListBox();
            this.groupArmour.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(340, 13);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // listArmourWithPerkSets
            // 
            this.listArmourWithPerkSets.FormattingEnabled = true;
            this.listArmourWithPerkSets.Location = new System.Drawing.Point(9, 45);
            this.listArmourWithPerkSets.Name = "listArmourWithPerkSets";
            this.listArmourWithPerkSets.Size = new System.Drawing.Size(171, 173);
            this.listArmourWithPerkSets.TabIndex = 1;
            // 
            // listArmourWithPerkRecomendations
            // 
            this.listArmourWithPerkRecomendations.FormattingEnabled = true;
            this.listArmourWithPerkRecomendations.Location = new System.Drawing.Point(186, 45);
            this.listArmourWithPerkRecomendations.Name = "listArmourWithPerkRecomendations";
            this.listArmourWithPerkRecomendations.Size = new System.Drawing.Size(198, 173);
            this.listArmourWithPerkRecomendations.TabIndex = 2;
            // 
            // txtArmourPerkScoreLevel
            // 
            this.txtArmourPerkScoreLevel.Location = new System.Drawing.Point(186, 224);
            this.txtArmourPerkScoreLevel.Name = "txtArmourPerkScoreLevel";
            this.txtArmourPerkScoreLevel.Size = new System.Drawing.Size(31, 20);
            this.txtArmourPerkScoreLevel.TabIndex = 3;
            // 
            // groupArmour
            // 
            this.groupArmour.Controls.Add(this.label4);
            this.groupArmour.Controls.Add(this.label3);
            this.groupArmour.Controls.Add(this.label2);
            this.groupArmour.Controls.Add(this.txtArmourPerkScoreLevel);
            this.groupArmour.Controls.Add(this.listArmourWithPerkRecomendations);
            this.groupArmour.Controls.Add(this.listArmourWithPerkSets);
            this.groupArmour.Location = new System.Drawing.Point(13, 52);
            this.groupArmour.Name = "groupArmour";
            this.groupArmour.Size = new System.Drawing.Size(402, 258);
            this.groupArmour.TabIndex = 4;
            this.groupArmour.TabStop = false;
            this.groupArmour.Text = "Armour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Armour with Perk Set";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Destiny Item Tagger";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Armour meeting Perk Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Perk Score Required";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtWeaponPerkScoreLevel);
            this.groupBox1.Controls.Add(this.listWeaponsWithPerkRecommendations);
            this.groupBox1.Controls.Add(this.listWeaponsWithPerkSets);
            this.groupBox1.Location = new System.Drawing.Point(13, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 258);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weapons";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Perk Score Required";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Weapons meeting Perk Score";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Weapons with Perk Set";
            // 
            // txtWeaponPerkScoreLevel
            // 
            this.txtWeaponPerkScoreLevel.Location = new System.Drawing.Point(186, 224);
            this.txtWeaponPerkScoreLevel.Name = "txtWeaponPerkScoreLevel";
            this.txtWeaponPerkScoreLevel.Size = new System.Drawing.Size(31, 20);
            this.txtWeaponPerkScoreLevel.TabIndex = 3;
            // 
            // listWeaponsWithPerkRecommendations
            // 
            this.listWeaponsWithPerkRecommendations.FormattingEnabled = true;
            this.listWeaponsWithPerkRecommendations.Location = new System.Drawing.Point(186, 45);
            this.listWeaponsWithPerkRecommendations.Name = "listWeaponsWithPerkRecommendations";
            this.listWeaponsWithPerkRecommendations.Size = new System.Drawing.Size(198, 173);
            this.listWeaponsWithPerkRecommendations.TabIndex = 2;
            // 
            // listWeaponsWithPerkSets
            // 
            this.listWeaponsWithPerkSets.FormattingEnabled = true;
            this.listWeaponsWithPerkSets.Location = new System.Drawing.Point(9, 45);
            this.listWeaponsWithPerkSets.Name = "listWeaponsWithPerkSets";
            this.listWeaponsWithPerkSets.Size = new System.Drawing.Size(171, 173);
            this.listWeaponsWithPerkSets.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 599);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupArmour);
            this.Controls.Add(this.btnGo);
            this.Name = "Main";
            this.Text = "Form1";
            this.groupArmour.ResumeLayout(false);
            this.groupArmour.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
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
    }
}

