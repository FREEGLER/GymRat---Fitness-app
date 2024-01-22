namespace GymRat___Fitness_app
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flypSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPROFILE = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnWORKOUT = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEXERCISES = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGOALS = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.ucExercises1 = new GymRat___Fitness_app.UCExercises();
            this.ucAbdominalsEx1 = new GymRat___Fitness_app.UCAbdominalsEx();
            this.ucWorkOut1 = new GymRat___Fitness_app.UCWorkOut();
            this.flypSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flypSidebar
            // 
            this.flypSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.flypSidebar.Controls.Add(this.panel1);
            this.flypSidebar.Controls.Add(this.panel4);
            this.flypSidebar.Controls.Add(this.panel5);
            this.flypSidebar.Controls.Add(this.panel3);
            this.flypSidebar.Controls.Add(this.panel2);
            this.flypSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flypSidebar.Location = new System.Drawing.Point(0, 0);
            this.flypSidebar.Margin = new System.Windows.Forms.Padding(2);
            this.flypSidebar.MaximumSize = new System.Drawing.Size(225, 650);
            this.flypSidebar.MinimumSize = new System.Drawing.Size(50, 650);
            this.flypSidebar.Name = "flypSidebar";
            this.flypSidebar.Size = new System.Drawing.Size(225, 650);
            this.flypSidebar.TabIndex = 1;
            this.flypSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.flypSidebar_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 46);
            this.panel1.TabIndex = 0;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMenu.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(44, 10);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(59, 23);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "MENU";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(5, 6);
            this.menuButton.Margin = new System.Windows.Forms.Padding(2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(32, 32);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPROFILE);
            this.panel4.Location = new System.Drawing.Point(2, 52);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(223, 41);
            this.panel4.TabIndex = 4;
            // 
            // btnPROFILE
            // 
            this.btnPROFILE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPROFILE.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPROFILE.ForeColor = System.Drawing.Color.White;
            this.btnPROFILE.Image = ((System.Drawing.Image)(resources.GetObject("btnPROFILE.Image")));
            this.btnPROFILE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPROFILE.Location = new System.Drawing.Point(-2, -3);
            this.btnPROFILE.Margin = new System.Windows.Forms.Padding(2);
            this.btnPROFILE.Name = "btnPROFILE";
            this.btnPROFILE.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnPROFILE.Size = new System.Drawing.Size(230, 49);
            this.btnPROFILE.TabIndex = 0;
            this.btnPROFILE.Text = "PROFILE";
            this.btnPROFILE.UseVisualStyleBackColor = true;
            this.btnPROFILE.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnWORKOUT);
            this.panel5.Location = new System.Drawing.Point(2, 97);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(223, 41);
            this.panel5.TabIndex = 3;
            // 
            // btnWORKOUT
            // 
            this.btnWORKOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWORKOUT.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWORKOUT.ForeColor = System.Drawing.Color.White;
            this.btnWORKOUT.Image = global::GymRat___Fitness_app.Properties.Resources.trainingCurtainSymbool;
            this.btnWORKOUT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWORKOUT.Location = new System.Drawing.Point(-2, -3);
            this.btnWORKOUT.Margin = new System.Windows.Forms.Padding(2);
            this.btnWORKOUT.Name = "btnWORKOUT";
            this.btnWORKOUT.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnWORKOUT.Size = new System.Drawing.Size(230, 49);
            this.btnWORKOUT.TabIndex = 0;
            this.btnWORKOUT.Text = "WORKOUT";
            this.btnWORKOUT.UseVisualStyleBackColor = true;
            this.btnWORKOUT.Click += new System.EventHandler(this.btnWORKOUT_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEXERCISES);
            this.panel3.Location = new System.Drawing.Point(2, 142);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 41);
            this.panel3.TabIndex = 2;
            // 
            // btnEXERCISES
            // 
            this.btnEXERCISES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEXERCISES.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXERCISES.ForeColor = System.Drawing.Color.White;
            this.btnEXERCISES.Image = global::GymRat___Fitness_app.Properties.Resources.exerciseCurtainSymbool;
            this.btnEXERCISES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEXERCISES.Location = new System.Drawing.Point(-2, -3);
            this.btnEXERCISES.Margin = new System.Windows.Forms.Padding(2);
            this.btnEXERCISES.Name = "btnEXERCISES";
            this.btnEXERCISES.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnEXERCISES.Size = new System.Drawing.Size(230, 49);
            this.btnEXERCISES.TabIndex = 0;
            this.btnEXERCISES.Text = "EXERCISES";
            this.btnEXERCISES.UseVisualStyleBackColor = true;
            this.btnEXERCISES.Click += new System.EventHandler(this.btnEXERCISES_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGOALS);
            this.panel2.Location = new System.Drawing.Point(2, 187);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 41);
            this.panel2.TabIndex = 1;
            // 
            // btnGOALS
            // 
            this.btnGOALS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGOALS.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGOALS.ForeColor = System.Drawing.Color.White;
            this.btnGOALS.Image = ((System.Drawing.Image)(resources.GetObject("btnGOALS.Image")));
            this.btnGOALS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGOALS.Location = new System.Drawing.Point(-2, -3);
            this.btnGOALS.Margin = new System.Windows.Forms.Padding(2);
            this.btnGOALS.Name = "btnGOALS";
            this.btnGOALS.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnGOALS.Size = new System.Drawing.Size(230, 49);
            this.btnGOALS.TabIndex = 0;
            this.btnGOALS.Text = "GOALS";
            this.btnGOALS.UseVisualStyleBackColor = true;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // ucExercises1
            // 
            this.ucExercises1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ucExercises1.ForeColor = System.Drawing.Color.White;
            this.ucExercises1.Location = new System.Drawing.Point(50, 0);
            this.ucExercises1.Margin = new System.Windows.Forms.Padding(2);
            this.ucExercises1.Name = "ucExercises1";
            this.ucExercises1.Size = new System.Drawing.Size(265, 650);
            this.ucExercises1.TabIndex = 3;
            this.ucExercises1.Visible = false;
            // 
            // ucAbdominalsEx1
            // 
            this.ucAbdominalsEx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ucAbdominalsEx1.Location = new System.Drawing.Point(50, 0);
            this.ucAbdominalsEx1.Name = "ucAbdominalsEx1";
            this.ucAbdominalsEx1.Size = new System.Drawing.Size(265, 650);
            this.ucAbdominalsEx1.TabIndex = 2;
            this.ucAbdominalsEx1.Visible = false;
            // 
            // ucWorkOut1
            // 
            this.ucWorkOut1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ucWorkOut1.Location = new System.Drawing.Point(50, 0);
            this.ucWorkOut1.Name = "ucWorkOut1";
            this.ucWorkOut1.Size = new System.Drawing.Size(265, 650);
            this.ucWorkOut1.TabIndex = 4;
            this.ucWorkOut1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(315, 650);
            this.Controls.Add(this.flypSidebar);
            this.Controls.Add(this.ucExercises1);
            this.Controls.Add(this.ucAbdominalsEx1);
            this.Controls.Add(this.ucWorkOut1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.flypSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGOALS;
        private System.Windows.Forms.FlowLayoutPanel flypSidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEXERCISES;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPROFILE;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnWORKOUT;
        private UCAbdominalsEx ucAbdominalsEx1;
        private UCExercises ucExercises1;
        private UCWorkOut ucWorkOut1;
    }
}

