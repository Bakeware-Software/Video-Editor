namespace VideoEditor
{
    partial class SubtitlesMainMenu
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
            this.fMain = new System.Windows.Forms.TableLayoutPanel();
            this.fTemp = new System.Windows.Forms.TableLayoutPanel();
            this.bConfirm = new System.Windows.Forms.Button();
            this.bOpen = new System.Windows.Forms.Button();
            this.bErase = new System.Windows.Forms.Button();
            this.tMainBox = new System.Windows.Forms.TextBox();
            this.tSubIndex = new System.Windows.Forms.TextBox();
            this.tStartPoint = new System.Windows.Forms.TextBox();
            this.tEndPoint = new System.Windows.Forms.TextBox();
            this.bPrev = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.fMain.SuspendLayout();
            this.fTemp.SuspendLayout();
            this.SuspendLayout();
            // 
            // fMain
            // 
            this.fMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fMain.ColumnCount = 3;
            this.fMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.91803F));
            this.fMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.fMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.08197F));
            this.fMain.Controls.Add(this.fTemp, 0, 3);
            this.fMain.Controls.Add(this.bErase, 1, 3);
            this.fMain.Controls.Add(this.tMainBox, 0, 0);
            this.fMain.Controls.Add(this.tSubIndex, 1, 2);
            this.fMain.Controls.Add(this.tStartPoint, 1, 1);
            this.fMain.Controls.Add(this.tEndPoint, 2, 1);
            this.fMain.Controls.Add(this.bPrev, 1, 0);
            this.fMain.Controls.Add(this.bNext, 2, 0);
            this.fMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fMain.Location = new System.Drawing.Point(0, 0);
            this.fMain.Name = "fMain";
            this.fMain.RowCount = 4;
            this.fMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.fMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.fMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.85135F));
            this.fMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.14865F));
            this.fMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fMain.Size = new System.Drawing.Size(467, 348);
            this.fMain.TabIndex = 0;
            // 
            // fTemp
            // 
            this.fTemp.AutoSize = true;
            this.fTemp.ColumnCount = 3;
            this.fTemp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fTemp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fTemp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.fTemp.Controls.Add(this.bConfirm, 0, 0);
            this.fTemp.Controls.Add(this.bOpen, 2, 0);
            this.fTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fTemp.Location = new System.Drawing.Point(3, 317);
            this.fTemp.Name = "fTemp";
            this.fTemp.RowCount = 1;
            this.fTemp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fTemp.Size = new System.Drawing.Size(337, 28);
            this.fTemp.TabIndex = 1;
            // 
            // bConfirm
            // 
            this.bConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bConfirm.Location = new System.Drawing.Point(3, 3);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.Size = new System.Drawing.Size(108, 22);
            this.bConfirm.TabIndex = 0;
            this.bConfirm.Text = "Confirm";
            this.bConfirm.UseVisualStyleBackColor = true;
            this.bConfirm.Click += new System.EventHandler(this.bConfirm_Click);
            // 
            // bOpen
            // 
            this.bOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bOpen.Location = new System.Drawing.Point(231, 3);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(103, 22);
            this.bOpen.TabIndex = 2;
            this.bOpen.Text = "Open";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // bErase
            // 
            this.bErase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fMain.SetColumnSpan(this.bErase, 2);
            this.bErase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bErase.Location = new System.Drawing.Point(346, 317);
            this.bErase.Name = "bErase";
            this.bErase.Size = new System.Drawing.Size(118, 28);
            this.bErase.TabIndex = 2;
            this.bErase.Text = "Erase All";
            this.bErase.UseVisualStyleBackColor = true;
            this.bErase.Click += new System.EventHandler(this.bErase_Click);
            // 
            // tMainBox
            // 
            this.tMainBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tMainBox.Location = new System.Drawing.Point(3, 3);
            this.tMainBox.Multiline = true;
            this.tMainBox.Name = "tMainBox";
            this.fMain.SetRowSpan(this.tMainBox, 3);
            this.tMainBox.Size = new System.Drawing.Size(337, 308);
            this.tMainBox.TabIndex = 3;
            this.tMainBox.TextChanged += new System.EventHandler(this.tMainBox_TextChanged);
            // 
            // tSubIndex
            // 
            this.fMain.SetColumnSpan(this.tSubIndex, 2);
            this.tSubIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tSubIndex.Location = new System.Drawing.Point(346, 55);
            this.tSubIndex.Name = "tSubIndex";
            this.tSubIndex.ReadOnly = true;
            this.tSubIndex.Size = new System.Drawing.Size(118, 20);
            this.tSubIndex.TabIndex = 4;
            // 
            // tStartPoint
            // 
            this.tStartPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tStartPoint.Location = new System.Drawing.Point(346, 30);
            this.tStartPoint.Name = "tStartPoint";
            this.tStartPoint.ReadOnly = true;
            this.tStartPoint.Size = new System.Drawing.Size(57, 20);
            this.tStartPoint.TabIndex = 5;
            // 
            // tEndPoint
            // 
            this.tEndPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tEndPoint.Location = new System.Drawing.Point(409, 30);
            this.tEndPoint.Name = "tEndPoint";
            this.tEndPoint.ReadOnly = true;
            this.tEndPoint.Size = new System.Drawing.Size(55, 20);
            this.tEndPoint.TabIndex = 6;
            // 
            // bPrev
            // 
            this.bPrev.AutoSize = true;
            this.bPrev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bPrev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bPrev.Location = new System.Drawing.Point(346, 3);
            this.bPrev.Name = "bPrev";
            this.bPrev.Size = new System.Drawing.Size(57, 21);
            this.bPrev.TabIndex = 7;
            this.bPrev.Text = "<";
            this.bPrev.UseVisualStyleBackColor = true;
            this.bPrev.Click += new System.EventHandler(this.bPrev_Click);
            // 
            // bNext
            // 
            this.bNext.AutoSize = true;
            this.bNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bNext.Location = new System.Drawing.Point(409, 3);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(55, 21);
            this.bNext.TabIndex = 8;
            this.bNext.Text = ">";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // SubtitlesMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 348);
            this.Controls.Add(this.fMain);
            this.Name = "SubtitlesMainMenu";
            this.Text = "Subtitles Menu";
            this.fMain.ResumeLayout(false);
            this.fMain.PerformLayout();
            this.fTemp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel fMain;
        private System.Windows.Forms.TableLayoutPanel fTemp;
        private System.Windows.Forms.Button bConfirm;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.TextBox tMainBox;
        private System.Windows.Forms.TextBox tSubIndex;
        private System.Windows.Forms.TextBox tStartPoint;
        private System.Windows.Forms.TextBox tEndPoint;
        private System.Windows.Forms.Button bPrev;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bErase;
    }
}