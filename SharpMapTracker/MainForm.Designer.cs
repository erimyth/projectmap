namespace SharpMapTracker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.traceTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.trackTibiaCastFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveNPCsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackMoveableItemsCheckBox = new System.Windows.Forms.ToolStripMenuItem();
            this.trackSplashesCheckBox = new System.Windows.Forms.ToolStripMenuItem();
            this.trackMonstersCheckBox = new System.Windows.Forms.ToolStripMenuItem();
            this.trackNpcsCheckBox = new System.Windows.Forms.ToolStripMenuItem();
            this.trackOnlyCurrentFloorCheckBox = new System.Windows.Forms.ToolStripMenuItem();
            this.retrackTilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.alwaysOnTopCheckBox = new System.Windows.Forms.ToolStripMenuItem();
            this.highlitghtMissingTilesCheckBox = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tileCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.monsterCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.npcCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.miniMap = new SharpMapTracker.MiniMap();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // traceTextBox
            // 
            resources.ApplyResources(this.traceTextBox, "traceTextBox");
            this.traceTextBox.Name = "traceTextBox";
            this.traceTextBox.ReadOnly = true;
            this.traceTextBox.TabStop = false;
            this.traceTextBox.TextChanged += new System.EventHandler(this.traceTextBox_TextChanged);
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadClientToolStripMenuItem,
            this.toolStripSeparator4,
            this.trackTibiaCastFilesToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveMapToolStripMenuItem,
            this.saveNPCsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // loadClientToolStripMenuItem
            // 
            resources.ApplyResources(this.loadClientToolStripMenuItem, "loadClientToolStripMenuItem");
            this.loadClientToolStripMenuItem.Image = global::SharpMapTracker.Properties.Resources.fire;
            this.loadClientToolStripMenuItem.Name = "loadClientToolStripMenuItem";
            this.loadClientToolStripMenuItem.Click += new System.EventHandler(this.loadClientToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // trackTibiaCastFilesToolStripMenuItem
            // 
            resources.ApplyResources(this.trackTibiaCastFilesToolStripMenuItem, "trackTibiaCastFilesToolStripMenuItem");
            this.trackTibiaCastFilesToolStripMenuItem.Image = global::SharpMapTracker.Properties.Resources.cast;
            this.trackTibiaCastFilesToolStripMenuItem.Name = "trackTibiaCastFilesToolStripMenuItem";
            this.trackTibiaCastFilesToolStripMenuItem.Click += new System.EventHandler(this.trackTibiaCastFilesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // saveMapToolStripMenuItem
            // 
            resources.ApplyResources(this.saveMapToolStripMenuItem, "saveMapToolStripMenuItem");
            this.saveMapToolStripMenuItem.Image = global::SharpMapTracker.Properties.Resources.download;
            this.saveMapToolStripMenuItem.Name = "saveMapToolStripMenuItem";
            this.saveMapToolStripMenuItem.Click += new System.EventHandler(this.saveMapToolStripMenuItem_Click);
            // 
            // saveNPCsToolStripMenuItem
            // 
            resources.ApplyResources(this.saveNPCsToolStripMenuItem, "saveNPCsToolStripMenuItem");
            this.saveNPCsToolStripMenuItem.Image = global::SharpMapTracker.Properties.Resources.addons;
            this.saveNPCsToolStripMenuItem.Name = "saveNPCsToolStripMenuItem";
            this.saveNPCsToolStripMenuItem.Click += new System.EventHandler(this.saveNPCsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Image = global::SharpMapTracker.Properties.Resources.exit_icon_2;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trackMoveableItemsCheckBox,
            this.trackSplashesCheckBox,
            this.trackMonstersCheckBox,
            this.trackNpcsCheckBox,
            this.trackOnlyCurrentFloorCheckBox,
            this.retrackTilesToolStripMenuItem,
            this.toolStripSeparator3,
            this.alwaysOnTopCheckBox,
            this.highlitghtMissingTilesCheckBox,
            this.toolStripSeparator5,
            this.clearToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            // 
            // trackMoveableItemsCheckBox
            // 
            resources.ApplyResources(this.trackMoveableItemsCheckBox, "trackMoveableItemsCheckBox");
            this.trackMoveableItemsCheckBox.Checked = true;
            this.trackMoveableItemsCheckBox.CheckOnClick = true;
            this.trackMoveableItemsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trackMoveableItemsCheckBox.Name = "trackMoveableItemsCheckBox";
            // 
            // trackSplashesCheckBox
            // 
            resources.ApplyResources(this.trackSplashesCheckBox, "trackSplashesCheckBox");
            this.trackSplashesCheckBox.Checked = true;
            this.trackSplashesCheckBox.CheckOnClick = true;
            this.trackSplashesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trackSplashesCheckBox.Name = "trackSplashesCheckBox";
            // 
            // trackMonstersCheckBox
            // 
            resources.ApplyResources(this.trackMonstersCheckBox, "trackMonstersCheckBox");
            this.trackMonstersCheckBox.Checked = true;
            this.trackMonstersCheckBox.CheckOnClick = true;
            this.trackMonstersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trackMonstersCheckBox.Name = "trackMonstersCheckBox";
            // 
            // trackNpcsCheckBox
            // 
            resources.ApplyResources(this.trackNpcsCheckBox, "trackNpcsCheckBox");
            this.trackNpcsCheckBox.Checked = true;
            this.trackNpcsCheckBox.CheckOnClick = true;
            this.trackNpcsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trackNpcsCheckBox.Name = "trackNpcsCheckBox";
            // 
            // trackOnlyCurrentFloorCheckBox
            // 
            resources.ApplyResources(this.trackOnlyCurrentFloorCheckBox, "trackOnlyCurrentFloorCheckBox");
            this.trackOnlyCurrentFloorCheckBox.Checked = true;
            this.trackOnlyCurrentFloorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trackOnlyCurrentFloorCheckBox.Name = "trackOnlyCurrentFloorCheckBox";
            this.trackOnlyCurrentFloorCheckBox.Click += new System.EventHandler(this.trackOnlyCurrentFloorCheckBox_Click);
            // 
            // retrackTilesToolStripMenuItem
            // 
            resources.ApplyResources(this.retrackTilesToolStripMenuItem, "retrackTilesToolStripMenuItem");
            this.retrackTilesToolStripMenuItem.CheckOnClick = true;
            this.retrackTilesToolStripMenuItem.Name = "retrackTilesToolStripMenuItem";
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // alwaysOnTopCheckBox
            // 
            resources.ApplyResources(this.alwaysOnTopCheckBox, "alwaysOnTopCheckBox");
            this.alwaysOnTopCheckBox.Checked = true;
            this.alwaysOnTopCheckBox.CheckOnClick = true;
            this.alwaysOnTopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alwaysOnTopCheckBox.Name = "alwaysOnTopCheckBox";
            // 
            // highlitghtMissingTilesCheckBox
            // 
            resources.ApplyResources(this.highlitghtMissingTilesCheckBox, "highlitghtMissingTilesCheckBox");
            this.highlitghtMissingTilesCheckBox.CheckOnClick = true;
            this.highlitghtMissingTilesCheckBox.Name = "highlitghtMissingTilesCheckBox";
            this.highlitghtMissingTilesCheckBox.Click += new System.EventHandler(this.highlitghtMissingTilesToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // clearToolStripMenuItem
            // 
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            this.clearToolStripMenuItem.Image = global::SharpMapTracker.Properties.Resources.exit_icon_2;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tileCountLabel,
            this.monsterCountLabel,
            this.npcCountLabel});
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.SizingGrip = false;
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
            // 
            // tileCountLabel
            // 
            resources.ApplyResources(this.tileCountLabel, "tileCountLabel");
            this.tileCountLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tileCountLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tileCountLabel.Image = global::SharpMapTracker.Properties.Resources._2471;
            this.tileCountLabel.Name = "tileCountLabel";
            this.tileCountLabel.Click += new System.EventHandler(this.tileCountLabel_Click);
            // 
            // monsterCountLabel
            // 
            resources.ApplyResources(this.monsterCountLabel, "monsterCountLabel");
            this.monsterCountLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.monsterCountLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.monsterCountLabel.Image = global::SharpMapTracker.Properties.Resources.druid;
            this.monsterCountLabel.Name = "monsterCountLabel";
            // 
            // npcCountLabel
            // 
            resources.ApplyResources(this.npcCountLabel, "npcCountLabel");
            this.npcCountLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.npcCountLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.npcCountLabel.Image = global::SharpMapTracker.Properties.Resources.addons;
            this.npcCountLabel.Name = "npcCountLabel";
            // 
            // miniMap
            // 
            resources.ApplyResources(this.miniMap, "miniMap");
            this.miniMap.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.miniMap.CenterLocation = null;
            this.miniMap.Floor = 0;
            this.miniMap.HighlightMissingTiles = false;
            this.miniMap.Map = null;
            this.miniMap.Name = "miniMap";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.miniMap);
            this.Controls.Add(this.traceTextBox);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox traceTextBox;
        private MiniMap miniMap;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tileCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel npcCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel monsterCountLabel;
        private System.Windows.Forms.ToolStripMenuItem trackMoveableItemsCheckBox;
        private System.Windows.Forms.ToolStripMenuItem trackSplashesCheckBox;
        private System.Windows.Forms.ToolStripMenuItem trackMonstersCheckBox;
        private System.Windows.Forms.ToolStripMenuItem trackNpcsCheckBox;
        private System.Windows.Forms.ToolStripMenuItem trackOnlyCurrentFloorCheckBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopCheckBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem saveNPCsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highlitghtMissingTilesCheckBox;
        private System.Windows.Forms.ToolStripMenuItem trackTibiaCastFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem retrackTilesToolStripMenuItem;
    }
}