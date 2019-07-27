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
            this.listPerkSets = new System.Windows.Forms.ListBox();
            this.listPerkReccomendations = new System.Windows.Forms.ListBox();
            this.txtWeightTrigger = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(152, 1100);
            this.btnGo.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(238, 65);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // listPerkSets
            // 
            this.listPerkSets.FormattingEnabled = true;
            this.listPerkSets.ItemHeight = 37;
            this.listPerkSets.Location = new System.Drawing.Point(152, 57);
            this.listPerkSets.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.listPerkSets.Name = "listPerkSets";
            this.listPerkSets.Size = new System.Drawing.Size(834, 929);
            this.listPerkSets.TabIndex = 1;
            // 
            // listPerkReccomendations
            // 
            this.listPerkReccomendations.FormattingEnabled = true;
            this.listPerkReccomendations.ItemHeight = 37;
            this.listPerkReccomendations.Location = new System.Drawing.Point(1279, 57);
            this.listPerkReccomendations.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.listPerkReccomendations.Name = "listPerkReccomendations";
            this.listPerkReccomendations.Size = new System.Drawing.Size(922, 929);
            this.listPerkReccomendations.TabIndex = 2;
            // 
            // txtWeightTrigger
            // 
            this.txtWeightTrigger.Location = new System.Drawing.Point(1314, 1121);
            this.txtWeightTrigger.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtWeightTrigger.Name = "txtWeightTrigger";
            this.txtWeightTrigger.Size = new System.Drawing.Size(308, 44);
            this.txtWeightTrigger.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2301, 1232);
            this.Controls.Add(this.txtWeightTrigger);
            this.Controls.Add(this.listPerkReccomendations);
            this.Controls.Add(this.listPerkSets);
            this.Controls.Add(this.btnGo);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ListBox listPerkSets;
        private System.Windows.Forms.ListBox listPerkReccomendations;
        private System.Windows.Forms.TextBox txtWeightTrigger;
    }
}

