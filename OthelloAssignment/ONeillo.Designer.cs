namespace OthelloAssignment
{
    partial class frm_ONeillo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ONeillo));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Game = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_New = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Restore = new System.Windows.Forms.ToolStripMenuItem();
            this.settToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuIteam_Speak = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_PlayerBox = new System.Windows.Forms.Panel();
            this.pbox_BlackToPlay = new System.Windows.Forms.PictureBox();
            this.pbox_WhitesToPlay = new System.Windows.Forms.PictureBox();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.txt_PlayerTwo = new System.Windows.Forms.TextBox();
            this.txt_PlayerOne = new System.Windows.Forms.TextBox();
            this.PBWhite = new System.Windows.Forms.PictureBox();
            this.pbBlack = new System.Windows.Forms.PictureBox();
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnl_PlayerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_BlackToPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_WhitesToPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Game,
            this.settToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1087, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Game
            // 
            this.Game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_New,
            this.MenuItem_Save,
            this.MenuItem_Restore});
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(60, 24);
            this.Game.Text = "Game";
            // 
            // MenuItem_New
            // 
            this.MenuItem_New.Name = "MenuItem_New";
            this.MenuItem_New.Size = new System.Drawing.Size(216, 26);
            this.MenuItem_New.Text = "New";
            this.MenuItem_New.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // MenuItem_Save
            // 
            this.MenuItem_Save.Name = "MenuItem_Save";
            this.MenuItem_Save.Size = new System.Drawing.Size(216, 26);
            this.MenuItem_Save.Text = "Save";
            this.MenuItem_Save.Click += new System.EventHandler(this.MenuItem_Save_Click);
            // 
            // MenuItem_Restore
            // 
            this.MenuItem_Restore.Name = "MenuItem_Restore";
            this.MenuItem_Restore.Size = new System.Drawing.Size(216, 26);
            this.MenuItem_Restore.Text = "Restore";
            this.MenuItem_Restore.Click += new System.EventHandler(this.MenuItem_Restore_Click);
            // 
            // settToolStripMenuItem
            // 
            this.settToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuIteam_Speak});
            this.settToolStripMenuItem.Name = "settToolStripMenuItem";
            this.settToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settToolStripMenuItem.Text = "Settings";
            // 
            // MenuIteam_Speak
            // 
            this.MenuIteam_Speak.CheckOnClick = true;
            this.MenuIteam_Speak.Name = "MenuIteam_Speak";
            this.MenuIteam_Speak.Size = new System.Drawing.Size(124, 26);
            this.MenuIteam_Speak.Text = "Speak";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_About});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // MenuItem_About
            // 
            this.MenuItem_About.Name = "MenuItem_About";
            this.MenuItem_About.Size = new System.Drawing.Size(125, 26);
            this.MenuItem_About.Text = "About";
            this.MenuItem_About.Click += new System.EventHandler(this.MenuItem_About_Click);
            // 
            // pnl_PlayerBox
            // 
            this.pnl_PlayerBox.BackColor = System.Drawing.Color.Bisque;
            this.pnl_PlayerBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_PlayerBox.Controls.Add(this.pbox_BlackToPlay);
            this.pnl_PlayerBox.Controls.Add(this.pbox_WhitesToPlay);
            this.pnl_PlayerBox.Controls.Add(this.lblPlayerTwo);
            this.pnl_PlayerBox.Controls.Add(this.txt_PlayerTwo);
            this.pnl_PlayerBox.Controls.Add(this.txt_PlayerOne);
            this.pnl_PlayerBox.Controls.Add(this.PBWhite);
            this.pnl_PlayerBox.Controls.Add(this.pbBlack);
            this.pnl_PlayerBox.Controls.Add(this.lblPlayerOne);
            this.pnl_PlayerBox.Location = new System.Drawing.Point(13, 687);
            this.pnl_PlayerBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_PlayerBox.Name = "pnl_PlayerBox";
            this.pnl_PlayerBox.Size = new System.Drawing.Size(1019, 122);
            this.pnl_PlayerBox.TabIndex = 1;
            // 
            // pbox_BlackToPlay
            // 
            this.pbox_BlackToPlay.Image = global::OthelloAssignment.Properties.Resources.ToPlay;
            this.pbox_BlackToPlay.Location = new System.Drawing.Point(773, 30);
            this.pbox_BlackToPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbox_BlackToPlay.Name = "pbox_BlackToPlay";
            this.pbox_BlackToPlay.Size = new System.Drawing.Size(205, 41);
            this.pbox_BlackToPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_BlackToPlay.TabIndex = 7;
            this.pbox_BlackToPlay.TabStop = false;
            this.pbox_BlackToPlay.Visible = false;
            // 
            // pbox_WhitesToPlay
            // 
            this.pbox_WhitesToPlay.Image = global::OthelloAssignment.Properties.Resources.ToPlay;
            this.pbox_WhitesToPlay.Location = new System.Drawing.Point(283, 31);
            this.pbox_WhitesToPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbox_WhitesToPlay.Name = "pbox_WhitesToPlay";
            this.pbox_WhitesToPlay.Size = new System.Drawing.Size(205, 41);
            this.pbox_WhitesToPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_WhitesToPlay.TabIndex = 6;
            this.pbox_WhitesToPlay.TabStop = false;
            this.pbox_WhitesToPlay.Visible = false;
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.AutoSize = true;
            this.lblPlayerTwo.Location = new System.Drawing.Point(573, 82);
            this.lblPlayerTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(0, 17);
            this.lblPlayerTwo.TabIndex = 5;
            // 
            // txt_PlayerTwo
            // 
            this.txt_PlayerTwo.Location = new System.Drawing.Point(773, 79);
            this.txt_PlayerTwo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_PlayerTwo.Name = "txt_PlayerTwo";
            this.txt_PlayerTwo.Size = new System.Drawing.Size(204, 22);
            this.txt_PlayerTwo.TabIndex = 4;
            // 
            // txt_PlayerOne
            // 
            this.txt_PlayerOne.Location = new System.Drawing.Point(283, 79);
            this.txt_PlayerOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_PlayerOne.Name = "txt_PlayerOne";
            this.txt_PlayerOne.Size = new System.Drawing.Size(204, 22);
            this.txt_PlayerOne.TabIndex = 3;
            // 
            // PBWhite
            // 
            this.PBWhite.Image = global::OthelloAssignment.Properties.Resources._1;
            this.PBWhite.Location = new System.Drawing.Point(165, 31);
            this.PBWhite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PBWhite.Name = "PBWhite";
            this.PBWhite.Size = new System.Drawing.Size(91, 78);
            this.PBWhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBWhite.TabIndex = 2;
            this.PBWhite.TabStop = false;
            // 
            // pbBlack
            // 
            this.pbBlack.Image = global::OthelloAssignment.Properties.Resources._0;
            this.pbBlack.Location = new System.Drawing.Point(656, 31);
            this.pbBlack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbBlack.Name = "pbBlack";
            this.pbBlack.Size = new System.Drawing.Size(96, 78);
            this.pbBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBlack.TabIndex = 1;
            this.pbBlack.TabStop = false;
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.AutoSize = true;
            this.lblPlayerOne.Location = new System.Drawing.Point(56, 79);
            this.lblPlayerOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(0, 17);
            this.lblPlayerOne.TabIndex = 0;
            // 
            // frm_ONeillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 822);
            this.Controls.Add(this.pnl_PlayerBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ONeillo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ONeillo v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_ONeillo_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_PlayerBox.ResumeLayout(false);
            this.pnl_PlayerBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_BlackToPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_WhitesToPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Game;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_New;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem settToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuIteam_Speak;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_About;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Restore;
        private System.Windows.Forms.Panel pnl_PlayerBox;
        private System.Windows.Forms.PictureBox pbBlack;
        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.PictureBox PBWhite;
        private System.Windows.Forms.TextBox txt_PlayerTwo;
        private System.Windows.Forms.TextBox txt_PlayerOne;
        private System.Windows.Forms.PictureBox pbox_WhitesToPlay;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.PictureBox pbox_BlackToPlay;
    }
}

