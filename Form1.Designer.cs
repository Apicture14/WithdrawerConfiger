namespace WithdrawerConfiger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.TabHomePage = new System.Windows.Forms.TabPage();
            this.LBMWord = new Sunny.UI.UILabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabMainConfig = new System.Windows.Forms.TabPage();
            this.LBEpath = new Sunny.UI.UILabel();
            this.BtnECreate = new Sunny.UI.UIButton();
            this.BtnEBrowse = new Sunny.UI.UIButton();
            this.TVE = new Sunny.UI.UITreeView();
            this.TabDaemonConfig = new System.Windows.Forms.TabPage();
            this.LBDpath = new Sunny.UI.UILabel();
            this.BtnDCreate = new Sunny.UI.UIButton();
            this.BtnDBrowse = new Sunny.UI.UIButton();
            this.TVD = new Sunny.UI.UITreeView();
            this.LBMStateMain = new Sunny.UI.UILabel();
            this.LBMStateDaemon = new Sunny.UI.UILabel();
            this.BtnMMainInfo = new Sunny.UI.UIButton();
            this.BtnMDaemonInfo = new Sunny.UI.UIButton();
            this.BtnMRefresh = new Sunny.UI.UIButton();
            this.uiTabControl1.SuspendLayout();
            this.TabHomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TabMainConfig.SuspendLayout();
            this.TabDaemonConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.TabHomePage);
            this.uiTabControl1.Controls.Add(this.TabMainConfig);
            this.uiTabControl1.Controls.Add(this.TabDaemonConfig);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(3, 38);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(794, 409);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabIndex = 0;
            this.uiTabControl1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // TabHomePage
            // 
            this.TabHomePage.Controls.Add(this.BtnMRefresh);
            this.TabHomePage.Controls.Add(this.BtnMDaemonInfo);
            this.TabHomePage.Controls.Add(this.BtnMMainInfo);
            this.TabHomePage.Controls.Add(this.LBMStateDaemon);
            this.TabHomePage.Controls.Add(this.LBMStateMain);
            this.TabHomePage.Controls.Add(this.LBMWord);
            this.TabHomePage.Controls.Add(this.pictureBox1);
            this.TabHomePage.Location = new System.Drawing.Point(0, 40);
            this.TabHomePage.Name = "TabHomePage";
            this.TabHomePage.Size = new System.Drawing.Size(794, 369);
            this.TabHomePage.TabIndex = 0;
            this.TabHomePage.Text = "Home";
            this.TabHomePage.UseVisualStyleBackColor = true;
            // 
            // LBMWord
            // 
            this.LBMWord.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBMWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.LBMWord.Location = new System.Drawing.Point(180, 3);
            this.LBMWord.Name = "LBMWord";
            this.LBMWord.Size = new System.Drawing.Size(583, 23);
            this.LBMWord.TabIndex = 1;
            this.LBMWord.Text = "Null";
            this.LBMWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TabMainConfig
            // 
            this.TabMainConfig.Controls.Add(this.LBEpath);
            this.TabMainConfig.Controls.Add(this.BtnECreate);
            this.TabMainConfig.Controls.Add(this.BtnEBrowse);
            this.TabMainConfig.Controls.Add(this.TVE);
            this.TabMainConfig.Location = new System.Drawing.Point(0, 40);
            this.TabMainConfig.Name = "TabMainConfig";
            this.TabMainConfig.Size = new System.Drawing.Size(200, 60);
            this.TabMainConfig.TabIndex = 1;
            this.TabMainConfig.Text = "Executor Config";
            this.TabMainConfig.UseVisualStyleBackColor = true;
            // 
            // LBEpath
            // 
            this.LBEpath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBEpath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.LBEpath.Location = new System.Drawing.Point(109, 15);
            this.LBEpath.Name = "LBEpath";
            this.LBEpath.Size = new System.Drawing.Size(681, 23);
            this.LBEpath.TabIndex = 3;
            this.LBEpath.Text = "No Indication\r\n\r\n\r\n\r\n\r\n";
            this.LBEpath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnECreate
            // 
            this.BtnECreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnECreate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnECreate.Location = new System.Drawing.Point(4, 44);
            this.BtnECreate.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnECreate.Name = "BtnECreate";
            this.BtnECreate.Size = new System.Drawing.Size(100, 35);
            this.BtnECreate.TabIndex = 2;
            this.BtnECreate.Text = "CreateNew";
            this.BtnECreate.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnECreate.Click += new System.EventHandler(this.BtnECreate_Click);
            // 
            // BtnEBrowse
            // 
            this.BtnEBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEBrowse.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnEBrowse.Location = new System.Drawing.Point(3, 3);
            this.BtnEBrowse.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnEBrowse.Name = "BtnEBrowse";
            this.BtnEBrowse.Size = new System.Drawing.Size(100, 35);
            this.BtnEBrowse.TabIndex = 1;
            this.BtnEBrowse.Text = "Browse";
            this.BtnEBrowse.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnEBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // TVE
            // 
            this.TVE.FillColor = System.Drawing.Color.White;
            this.TVE.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TVE.Location = new System.Drawing.Point(4, 119);
            this.TVE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TVE.MinimumSize = new System.Drawing.Size(1, 1);
            this.TVE.Name = "TVE";
            this.TVE.ScrollBarStyleInherited = false;
            this.TVE.ShowText = false;
            this.TVE.Size = new System.Drawing.Size(786, 245);
            this.TVE.TabIndex = 0;
            this.TVE.Text = "uiTreeView1";
            this.TVE.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabDaemonConfig
            // 
            this.TabDaemonConfig.Controls.Add(this.LBDpath);
            this.TabDaemonConfig.Controls.Add(this.BtnDCreate);
            this.TabDaemonConfig.Controls.Add(this.BtnDBrowse);
            this.TabDaemonConfig.Controls.Add(this.TVD);
            this.TabDaemonConfig.Location = new System.Drawing.Point(0, 40);
            this.TabDaemonConfig.Name = "TabDaemonConfig";
            this.TabDaemonConfig.Size = new System.Drawing.Size(200, 60);
            this.TabDaemonConfig.TabIndex = 2;
            this.TabDaemonConfig.Text = "Daemon Config";
            this.TabDaemonConfig.UseVisualStyleBackColor = true;
            // 
            // LBDpath
            // 
            this.LBDpath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBDpath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.LBDpath.Location = new System.Drawing.Point(110, 16);
            this.LBDpath.Name = "LBDpath";
            this.LBDpath.Size = new System.Drawing.Size(681, 23);
            this.LBDpath.TabIndex = 7;
            this.LBDpath.Text = "No Indication\r\n\r\n\r\n\r\n\r\n";
            this.LBDpath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnDCreate
            // 
            this.BtnDCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDCreate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDCreate.Location = new System.Drawing.Point(5, 45);
            this.BtnDCreate.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnDCreate.Name = "BtnDCreate";
            this.BtnDCreate.Size = new System.Drawing.Size(100, 35);
            this.BtnDCreate.TabIndex = 6;
            this.BtnDCreate.Text = "CreateNew";
            this.BtnDCreate.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // BtnDBrowse
            // 
            this.BtnDBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDBrowse.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDBrowse.Location = new System.Drawing.Point(4, 4);
            this.BtnDBrowse.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnDBrowse.Name = "BtnDBrowse";
            this.BtnDBrowse.Size = new System.Drawing.Size(100, 35);
            this.BtnDBrowse.TabIndex = 5;
            this.BtnDBrowse.Text = "Browse";
            this.BtnDBrowse.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDBrowse.Click += new System.EventHandler(this.BtnDBrowse_Click);
            // 
            // TVD
            // 
            this.TVD.FillColor = System.Drawing.Color.White;
            this.TVD.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TVD.Location = new System.Drawing.Point(5, 120);
            this.TVD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TVD.MinimumSize = new System.Drawing.Size(1, 1);
            this.TVD.Name = "TVD";
            this.TVD.ScrollBarStyleInherited = false;
            this.TVD.ShowText = false;
            this.TVD.Size = new System.Drawing.Size(786, 245);
            this.TVD.TabIndex = 4;
            this.TVD.Text = "uiTreeView1";
            this.TVD.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBMStateMain
            // 
            this.LBMStateMain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBMStateMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.LBMStateMain.Location = new System.Drawing.Point(3, 183);
            this.LBMStateMain.Name = "LBMStateMain";
            this.LBMStateMain.Size = new System.Drawing.Size(285, 34);
            this.LBMStateMain.TabIndex = 2;
            this.LBMStateMain.Text = "MainProgram:Unknown";
            this.LBMStateMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBMStateDaemon
            // 
            this.LBMStateDaemon.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBMStateDaemon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.LBMStateDaemon.Location = new System.Drawing.Point(3, 217);
            this.LBMStateDaemon.Name = "LBMStateDaemon";
            this.LBMStateDaemon.Size = new System.Drawing.Size(285, 34);
            this.LBMStateDaemon.TabIndex = 3;
            this.LBMStateDaemon.Text = "Daemon:Unknown";
            this.LBMStateDaemon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnMMainInfo
            // 
            this.BtnMMainInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMMainInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnMMainInfo.Location = new System.Drawing.Point(213, 186);
            this.BtnMMainInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnMMainInfo.Name = "BtnMMainInfo";
            this.BtnMMainInfo.Size = new System.Drawing.Size(100, 31);
            this.BtnMMainInfo.TabIndex = 4;
            this.BtnMMainInfo.Text = "Kill";
            this.BtnMMainInfo.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // BtnMDaemonInfo
            // 
            this.BtnMDaemonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMDaemonInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnMDaemonInfo.Location = new System.Drawing.Point(213, 223);
            this.BtnMDaemonInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnMDaemonInfo.Name = "BtnMDaemonInfo";
            this.BtnMDaemonInfo.Size = new System.Drawing.Size(100, 31);
            this.BtnMDaemonInfo.TabIndex = 6;
            this.BtnMDaemonInfo.Text = "Stop";
            this.BtnMDaemonInfo.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // BtnMRefresh
            // 
            this.BtnMRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMRefresh.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnMRefresh.Location = new System.Drawing.Point(352, 203);
            this.BtnMRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnMRefresh.Name = "BtnMRefresh";
            this.BtnMRefresh.Size = new System.Drawing.Size(100, 35);
            this.BtnMRefresh.TabIndex = 7;
            this.BtnMRefresh.Text = "Refresh";
            this.BtnMRefresh.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnMRefresh.Click += new System.EventHandler(this.BtnMRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WithdrawerConfiger";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.uiTabControl1.ResumeLayout(false);
            this.TabHomePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TabMainConfig.ResumeLayout(false);
            this.TabDaemonConfig.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private Sunny.UI.UILabel LBMStateMain;
        private Sunny.UI.UILabel LBMStateDaemon;
        private Sunny.UI.UIButton BtnMMainInfo;
        private Sunny.UI.UIButton BtnMRefresh;
        private Sunny.UI.UIButton BtnMDaemonInfo;

        private Sunny.UI.UILabel LBMWord;

        private System.Windows.Forms.PictureBox pictureBox1;

        private Sunny.UI.UILabel LBDpath;
        private Sunny.UI.UIButton BtnDCreate;
        private Sunny.UI.UIButton BtnDBrowse;
        private Sunny.UI.UITreeView TVD;

        private Sunny.UI.UIButton BtnECreate;
        private Sunny.UI.UILabel LBEpath;

        private Sunny.UI.UITreeView TVE;
        private Sunny.UI.UIButton BtnEBrowse;

        private System.Windows.Forms.TabPage TabDaemonConfig;

        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage TabHomePage;
        private System.Windows.Forms.TabPage TabMainConfig;

        #endregion
    }
}