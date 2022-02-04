namespace Ikra
{
    partial class mainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonManager = new System.Windows.Forms.Button();
            this.buttonFarm = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Logo2 = new System.Windows.Forms.PictureBox();
            this.panelHome = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTile = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.logo1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo2)).BeginInit();
            this.panelHome.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Beige;
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.buttonReport);
            this.panelMenu.Controls.Add(this.buttonManager);
            this.panelMenu.Controls.Add(this.buttonFarm);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(167, 519);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Сайт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReport.FlatAppearance.BorderSize = 0;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReport.ForeColor = System.Drawing.Color.Maroon;
            this.buttonReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReport.Location = new System.Drawing.Point(0, 150);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(167, 40);
            this.buttonReport.TabIndex = 3;
            this.buttonReport.Text = "Закуп";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonManager
            // 
            this.buttonManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonManager.FlatAppearance.BorderSize = 0;
            this.buttonManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManager.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonManager.ForeColor = System.Drawing.Color.Maroon;
            this.buttonManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManager.Location = new System.Drawing.Point(0, 110);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(167, 40);
            this.buttonManager.TabIndex = 2;
            this.buttonManager.Text = "Менеджер";
            this.buttonManager.UseVisualStyleBackColor = true;
            this.buttonManager.Click += new System.EventHandler(this.buttonManager_Click);
            // 
            // buttonFarm
            // 
            this.buttonFarm.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFarm.FlatAppearance.BorderSize = 0;
            this.buttonFarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFarm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFarm.ForeColor = System.Drawing.Color.Maroon;
            this.buttonFarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFarm.Location = new System.Drawing.Point(0, 70);
            this.buttonFarm.Name = "buttonFarm";
            this.buttonFarm.Size = new System.Drawing.Size(167, 40);
            this.buttonFarm.TabIndex = 1;
            this.buttonFarm.Text = "Хозяйство";
            this.buttonFarm.UseVisualStyleBackColor = true;
            this.buttonFarm.Click += new System.EventHandler(this.buttonFarm_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.Logo2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(167, 70);
            this.panelLogo.TabIndex = 0;
            // 
            // Logo2
            // 
            this.Logo2.BackColor = System.Drawing.Color.White;
            this.Logo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Logo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo2.Image = global::Ikra.Properties.Resources.logo21;
            this.Logo2.Location = new System.Drawing.Point(0, 0);
            this.Logo2.Name = "Logo2";
            this.Logo2.Size = new System.Drawing.Size(167, 70);
            this.Logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo2.TabIndex = 0;
            this.Logo2.TabStop = false;
            this.Logo2.Click += new System.EventHandler(this.Logo2_Click);
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.Beige;
            this.panelHome.Controls.Add(this.button1);
            this.panelHome.Controls.Add(this.lblTile);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(167, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(829, 70);
            this.panelHome.TabIndex = 1;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHome_Paint);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Image = global::Ikra.Properties.Resources._673453;
            this.button1.Location = new System.Drawing.Point(749, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 70);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTile
            // 
            this.lblTile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTile.AutoSize = true;
            this.lblTile.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTile.ForeColor = System.Drawing.Color.Maroon;
            this.lblTile.Location = new System.Drawing.Point(23, 12);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(300, 33);
            this.lblTile.TabIndex = 0;
            this.lblTile.Text = "Домашняя страница";
            this.lblTile.Click += new System.EventHandler(this.lblTile_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.logo1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(167, 70);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(829, 449);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // logo1
            // 
            this.logo1.BackColor = System.Drawing.Color.White;
            this.logo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo1.Image = global::Ikra.Properties.Resources.logo11;
            this.logo1.Location = new System.Drawing.Point(0, 0);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(829, 449);
            this.logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo1.TabIndex = 0;
            this.logo1.TabStop = false;
            this.logo1.Click += new System.EventHandler(this.logo1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = ".";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 519);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelMenu);
            this.Name = "mainForm";
            this.Text = "Рыбки рыбки мои рыбки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo2)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonFarm;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Logo2;
        private System.Windows.Forms.PictureBox logo1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

