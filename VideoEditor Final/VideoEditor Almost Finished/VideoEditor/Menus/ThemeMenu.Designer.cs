namespace VideoEditor
{
    partial class SettingsTheme
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
            this.ActiveList = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDEFAULT = new System.Windows.Forms.Panel();
            this.panelACTIVE = new System.Windows.Forms.Panel();
            this.panelLOADED = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ThemeSelector = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelDEFAULT.SuspendLayout();
            this.panelACTIVE.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActiveList
            // 
            this.ActiveList.FormattingEnabled = true;
            this.ActiveList.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Yellow",
            "Green",
            "Orange",
            "Purple",
            "Custom"});
            this.ActiveList.Location = new System.Drawing.Point(12, 12);
            this.ActiveList.Name = "ActiveList";
            this.ActiveList.Size = new System.Drawing.Size(75, 95);
            this.ActiveList.TabIndex = 4;
            this.ActiveList.SelectedIndexChanged += new System.EventHandler(this.ActiveList_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(90, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(197, 95);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelDEFAULT);
            this.panel1.Location = new System.Drawing.Point(109, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 85);
            this.panel1.TabIndex = 0;
            // 
            // panelDEFAULT
            // 
            this.panelDEFAULT.Controls.Add(this.panelACTIVE);
            this.panelDEFAULT.Location = new System.Drawing.Point(3, 3);
            this.panelDEFAULT.Name = "panelDEFAULT";
            this.panelDEFAULT.Size = new System.Drawing.Size(50, 50);
            this.panelDEFAULT.TabIndex = 1;
            // 
            // panelACTIVE
            // 
            this.panelACTIVE.Controls.Add(this.panelLOADED);
            this.panelACTIVE.Location = new System.Drawing.Point(10, 10);
            this.panelACTIVE.Name = "panelACTIVE";
            this.panelACTIVE.Size = new System.Drawing.Size(40, 40);
            this.panelACTIVE.TabIndex = 2;
            // 
            // panelLOADED
            // 
            this.panelLOADED.Location = new System.Drawing.Point(10, 10);
            this.panelLOADED.Name = "panelLOADED";
            this.panelLOADED.Size = new System.Drawing.Size(30, 30);
            this.panelLOADED.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThemeSelector
            // 
            this.ThemeSelector.FormattingEnabled = true;
            this.ThemeSelector.Items.AddRange(new object[] {
            "Dark",
            "Light",
            "Blue"});
            this.ThemeSelector.Location = new System.Drawing.Point(290, 12);
            this.ThemeSelector.Name = "ThemeSelector";
            this.ThemeSelector.Size = new System.Drawing.Size(75, 95);
            this.ThemeSelector.TabIndex = 3;
            this.ThemeSelector.SelectedIndexChanged += new System.EventHandler(this.ThemeSelector_SelectedIndexChanged);
            // 
            // SettingsTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 137);
            this.Controls.Add(this.ThemeSelector);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ActiveList);
            this.Name = "SettingsTheme";
            this.Text = "SettingsTheme";
            this.Load += new System.EventHandler(this.SettingsTheme_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelDEFAULT.ResumeLayout(false);
            this.panelACTIVE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ActiveList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ThemeSelector;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLOADED;
        private System.Windows.Forms.Panel panelACTIVE;
        private System.Windows.Forms.Panel panelDEFAULT;
    }
}