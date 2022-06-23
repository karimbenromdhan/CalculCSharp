namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnExit = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDiv = new Guna.UI2.WinForms.Guna2Button();
            this.BtnFoi = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMinis = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPlus = new Guna.UI2.WinForms.Guna2Button();
            this.BtnEquals = new Guna.UI2.WinForms.Guna2Button();
            this.Btn3 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn6 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn9 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPercentage = new Guna.UI2.WinForms.Guna2Button();
            this.BtnZero = new Guna.UI2.WinForms.Guna2Button();
            this.Btn1 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn4 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn7 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnClear = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPoint = new Guna.UI2.WinForms.Guna2Button();
            this.Btn2 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn5 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn8 = new Guna.UI2.WinForms.Guna2Button();
            this.TextStore = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextResulta = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageRotate = 0F;
            this.BtnExit.Location = new System.Drawing.Point(320, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnExit.Size = new System.Drawing.Size(41, 40);
            this.BtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnExit.TabIndex = 0;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calcul";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.BackColor = System.Drawing.Color.Transparent;
            this.BtnDiv.BorderRadius = 15;
            this.BtnDiv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDiv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDiv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDiv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDiv.FillColor = System.Drawing.Color.Black;
            this.BtnDiv.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnDiv.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnDiv.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.BtnDiv.HoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnDiv.Location = new System.Drawing.Point(256, 272);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.ShadowDecoration.BorderRadius = 15;
            this.BtnDiv.ShadowDecoration.Color = System.Drawing.Color.OrangeRed;
            this.BtnDiv.ShadowDecoration.Enabled = true;
            this.BtnDiv.Size = new System.Drawing.Size(47, 41);
            this.BtnDiv.TabIndex = 2;
            this.BtnDiv.Text = "/";
            this.BtnDiv.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // BtnFoi
            // 
            this.BtnFoi.BackColor = System.Drawing.Color.Transparent;
            this.BtnFoi.BorderRadius = 15;
            this.BtnFoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnFoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnFoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnFoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnFoi.FillColor = System.Drawing.Color.Black;
            this.BtnFoi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnFoi.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnFoi.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.BtnFoi.HoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnFoi.Location = new System.Drawing.Point(256, 329);
            this.BtnFoi.Name = "BtnFoi";
            this.BtnFoi.ShadowDecoration.BorderRadius = 15;
            this.BtnFoi.ShadowDecoration.Color = System.Drawing.Color.OrangeRed;
            this.BtnFoi.ShadowDecoration.Enabled = true;
            this.BtnFoi.Size = new System.Drawing.Size(47, 41);
            this.BtnFoi.TabIndex = 3;
            this.BtnFoi.Text = "*";
            this.BtnFoi.Click += new System.EventHandler(this.BtnFoi_Click);
            // 
            // BtnMinis
            // 
            this.BtnMinis.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinis.BorderRadius = 15;
            this.BtnMinis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMinis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMinis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMinis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMinis.FillColor = System.Drawing.Color.Black;
            this.BtnMinis.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnMinis.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnMinis.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.BtnMinis.HoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnMinis.Location = new System.Drawing.Point(256, 442);
            this.BtnMinis.Name = "BtnMinis";
            this.BtnMinis.ShadowDecoration.BorderRadius = 15;
            this.BtnMinis.ShadowDecoration.Color = System.Drawing.Color.OrangeRed;
            this.BtnMinis.ShadowDecoration.Enabled = true;
            this.BtnMinis.Size = new System.Drawing.Size(47, 41);
            this.BtnMinis.TabIndex = 5;
            this.BtnMinis.Text = "-";
            this.BtnMinis.Click += new System.EventHandler(this.BtnMinis_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.BackColor = System.Drawing.Color.Transparent;
            this.BtnPlus.BorderRadius = 15;
            this.BtnPlus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPlus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPlus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPlus.FillColor = System.Drawing.Color.Black;
            this.BtnPlus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnPlus.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnPlus.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.BtnPlus.HoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnPlus.Location = new System.Drawing.Point(256, 385);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.ShadowDecoration.BorderRadius = 15;
            this.BtnPlus.ShadowDecoration.Color = System.Drawing.Color.OrangeRed;
            this.BtnPlus.ShadowDecoration.Enabled = true;
            this.BtnPlus.Size = new System.Drawing.Size(47, 41);
            this.BtnPlus.TabIndex = 4;
            this.BtnPlus.Text = "+";
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.BackColor = System.Drawing.Color.Transparent;
            this.BtnEquals.BorderRadius = 15;
            this.BtnEquals.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEquals.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEquals.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEquals.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEquals.FillColor = System.Drawing.Color.Black;
            this.BtnEquals.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnEquals.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnEquals.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.BtnEquals.HoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnEquals.Location = new System.Drawing.Point(188, 498);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.ShadowDecoration.BorderRadius = 15;
            this.BtnEquals.ShadowDecoration.Color = System.Drawing.Color.OrangeRed;
            this.BtnEquals.ShadowDecoration.Enabled = true;
            this.BtnEquals.Size = new System.Drawing.Size(115, 41);
            this.BtnEquals.TabIndex = 11;
            this.BtnEquals.Text = "=";
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.Transparent;
            this.Btn3.BorderRadius = 15;
            this.Btn3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn3.FillColor = System.Drawing.Color.Black;
            this.Btn3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn3.ForeColor = System.Drawing.Color.OrangeRed;
            this.Btn3.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.Btn3.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn3.Location = new System.Drawing.Point(188, 442);
            this.Btn3.Name = "Btn3";
            this.Btn3.ShadowDecoration.BorderRadius = 15;
            this.Btn3.ShadowDecoration.Color = System.Drawing.Color.OrangeRed;
            this.Btn3.ShadowDecoration.Enabled = true;
            this.Btn3.Size = new System.Drawing.Size(47, 41);
            this.Btn3.TabIndex = 10;
            this.Btn3.Text = "3";
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.Transparent;
            this.Btn6.BorderRadius = 15;
            this.Btn6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn6.FillColor = System.Drawing.Color.Black;
            this.Btn6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn6.ForeColor = System.Drawing.Color.OrangeRed;
            this.Btn6.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.Btn6.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn6.Location = new System.Drawing.Point(188, 385);
            this.Btn6.Name = "Btn6";
            this.Btn6.ShadowDecoration.BorderRadius = 15;
            this.Btn6.ShadowDecoration.Color = System.Drawing.Color.OrangeRed;
            this.Btn6.ShadowDecoration.Enabled = true;
            this.Btn6.Size = new System.Drawing.Size(47, 41);
            this.Btn6.TabIndex = 9;
            this.Btn6.Text = "6";
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.Transparent;
            this.Btn9.BorderRadius = 15;
            this.Btn9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn9.FillColor = System.Drawing.Color.Black;
            this.Btn9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn9.ForeColor = System.Drawing.Color.OrangeRed;
            this.Btn9.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.Btn9.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn9.Location = new System.Drawing.Point(188, 329);
            this.Btn9.Name = "Btn9";
            this.Btn9.ShadowDecoration.BorderRadius = 15;
            this.Btn9.ShadowDecoration.Color = System.Drawing.Color.OrangeRed;
            this.Btn9.ShadowDecoration.Enabled = true;
            this.Btn9.Size = new System.Drawing.Size(47, 41);
            this.Btn9.TabIndex = 8;
            this.Btn9.Text = "9";
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // BtnPercentage
            // 
            this.BtnPercentage.BackColor = System.Drawing.Color.Transparent;
            this.BtnPercentage.BorderRadius = 15;
            this.BtnPercentage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPercentage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPercentage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPercentage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPercentage.FillColor = System.Drawing.Color.Black;
            this.BtnPercentage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnPercentage.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnPercentage.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.BtnPercentage.HoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnPercentage.Location = new System.Drawing.Point(188, 272);
            this.BtnPercentage.Name = "BtnPercentage";
            this.BtnPercentage.ShadowDecoration.BorderRadius = 15;
            this.BtnPercentage.ShadowDecoration.Color = System.Drawing.Color.OrangeRed;
            this.BtnPercentage.ShadowDecoration.Enabled = true;
            this.BtnPercentage.Size = new System.Drawing.Size(47, 41);
            this.BtnPercentage.TabIndex = 7;
            this.BtnPercentage.Text = "%";
            this.BtnPercentage.Click += new System.EventHandler(this.BtnPercentage_Click);
            // 
            // BtnZero
            // 
            this.BtnZero.BackColor = System.Drawing.Color.Transparent;
            this.BtnZero.BorderRadius = 15;
            this.BtnZero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnZero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnZero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnZero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnZero.FillColor = System.Drawing.Color.Black;
            this.BtnZero.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnZero.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnZero.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.BtnZero.HoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnZero.Location = new System.Drawing.Point(53, 498);
            this.BtnZero.Name = "BtnZero";
            this.BtnZero.ShadowDecoration.BorderRadius = 15;
            this.BtnZero.ShadowDecoration.Color = System.Drawing.Color.OrangeRed;
            this.BtnZero.ShadowDecoration.Enabled = true;
            this.BtnZero.Size = new System.Drawing.Size(47, 41);
            this.BtnZero.TabIndex = 21;
            this.BtnZero.Text = "0";
            this.BtnZero.Click += new System.EventHandler(this.BtnZero_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.Transparent;
            this.Btn1.BorderRadius = 15;
            this.Btn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn1.FillColor = System.Drawing.Color.Black;
            this.Btn1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn1.ForeColor = System.Drawing.Color.OrangeRed;
            this.Btn1.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.Btn1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn1.Location = new System.Drawing.Point(53, 442);
            this.Btn1.Name = "Btn1";
            this.Btn1.ShadowDecoration.BorderRadius = 15;
            this.Btn1.ShadowDecoration.Color = System.Drawing.Color.OrangeRed;
            this.Btn1.ShadowDecoration.Enabled = true;
            this.Btn1.Size = new System.Drawing.Size(47, 41);
            this.Btn1.TabIndex = 20;
            this.Btn1.Text = "1";
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.Transparent;
            this.Btn4.BorderRadius = 15;
            this.Btn4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn4.FillColor = System.Drawing.Color.Black;
            this.Btn4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn4.ForeColor = System.Drawing.Color.OrangeRed;
            this.Btn4.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.Btn4.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn4.Location = new System.Drawing.Point(53, 385);
            this.Btn4.Name = "Btn4";
            this.Btn4.ShadowDecoration.BorderRadius = 15;
            this.Btn4.ShadowDecoration.Color = System.Drawing.Color.OrangeRed;
            this.Btn4.ShadowDecoration.Enabled = true;
            this.Btn4.Size = new System.Drawing.Size(47, 41);
            this.Btn4.TabIndex = 19;
            this.Btn4.Text = "4";
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.Transparent;
            this.Btn7.BorderRadius = 15;
            this.Btn7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn7.FillColor = System.Drawing.Color.Black;
            this.Btn7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn7.ForeColor = System.Drawing.Color.OrangeRed;
            this.Btn7.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.Btn7.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn7.Location = new System.Drawing.Point(53, 329);
            this.Btn7.Name = "Btn7";
            this.Btn7.ShadowDecoration.BorderRadius = 15;
            this.Btn7.ShadowDecoration.Color = System.Drawing.Color.OrangeRed;
            this.Btn7.ShadowDecoration.Enabled = true;
            this.Btn7.Size = new System.Drawing.Size(47, 41);
            this.Btn7.TabIndex = 18;
            this.Btn7.Text = "7";
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Transparent;
            this.BtnClear.BorderRadius = 15;
            this.BtnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClear.FillColor = System.Drawing.Color.Black;
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnClear.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnClear.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.BtnClear.HoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnClear.Location = new System.Drawing.Point(53, 272);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.ShadowDecoration.BorderRadius = 15;
            this.BtnClear.ShadowDecoration.Color = System.Drawing.Color.OrangeRed;
            this.BtnClear.ShadowDecoration.Enabled = true;
            this.BtnClear.Size = new System.Drawing.Size(115, 41);
            this.BtnClear.TabIndex = 17;
            this.BtnClear.Text = "C";
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnPoint
            // 
            this.BtnPoint.BackColor = System.Drawing.Color.Transparent;
            this.BtnPoint.BorderRadius = 15;
            this.BtnPoint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPoint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPoint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPoint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPoint.FillColor = System.Drawing.Color.Black;
            this.BtnPoint.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnPoint.ForeColor = System.Drawing.Color.OrangeRed;
            this.BtnPoint.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.BtnPoint.HoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnPoint.Location = new System.Drawing.Point(121, 498);
            this.BtnPoint.Name = "BtnPoint";
            this.BtnPoint.ShadowDecoration.BorderRadius = 15;
            this.BtnPoint.ShadowDecoration.Color = System.Drawing.Color.OrangeRed;
            this.BtnPoint.ShadowDecoration.Enabled = true;
            this.BtnPoint.Size = new System.Drawing.Size(47, 41);
            this.BtnPoint.TabIndex = 16;
            this.BtnPoint.Text = ".";
            this.BtnPoint.Click += new System.EventHandler(this.BtnPoint_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.Transparent;
            this.Btn2.BorderRadius = 15;
            this.Btn2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn2.FillColor = System.Drawing.Color.Black;
            this.Btn2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn2.ForeColor = System.Drawing.Color.OrangeRed;
            this.Btn2.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.Btn2.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn2.Location = new System.Drawing.Point(121, 442);
            this.Btn2.Name = "Btn2";
            this.Btn2.ShadowDecoration.BorderRadius = 15;
            this.Btn2.ShadowDecoration.Color = System.Drawing.Color.OrangeRed;
            this.Btn2.ShadowDecoration.Enabled = true;
            this.Btn2.Size = new System.Drawing.Size(47, 41);
            this.Btn2.TabIndex = 15;
            this.Btn2.Text = "2";
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.Transparent;
            this.Btn5.BorderRadius = 15;
            this.Btn5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn5.FillColor = System.Drawing.Color.Black;
            this.Btn5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn5.ForeColor = System.Drawing.Color.OrangeRed;
            this.Btn5.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.Btn5.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn5.Location = new System.Drawing.Point(121, 385);
            this.Btn5.Name = "Btn5";
            this.Btn5.ShadowDecoration.BorderRadius = 15;
            this.Btn5.ShadowDecoration.Color = System.Drawing.Color.OrangeRed;
            this.Btn5.ShadowDecoration.Enabled = true;
            this.Btn5.Size = new System.Drawing.Size(47, 41);
            this.Btn5.TabIndex = 14;
            this.Btn5.Text = "5";
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.Transparent;
            this.Btn8.BorderRadius = 15;
            this.Btn8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn8.FillColor = System.Drawing.Color.Black;
            this.Btn8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Btn8.ForeColor = System.Drawing.Color.OrangeRed;
            this.Btn8.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.Btn8.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Btn8.Location = new System.Drawing.Point(121, 329);
            this.Btn8.Name = "Btn8";
            this.Btn8.ShadowDecoration.BorderRadius = 15;
            this.Btn8.ShadowDecoration.Color = System.Drawing.Color.OrangeRed;
            this.Btn8.ShadowDecoration.Enabled = true;
            this.Btn8.Size = new System.Drawing.Size(47, 41);
            this.Btn8.TabIndex = 13;
            this.Btn8.Text = "8";
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // TextStore
            // 
            this.TextStore.BackColor = System.Drawing.Color.Black;
            this.TextStore.BorderThickness = 0;
            this.TextStore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextStore.DefaultText = "";
            this.TextStore.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextStore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextStore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextStore.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextStore.FillColor = System.Drawing.Color.Transparent;
            this.TextStore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextStore.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextStore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextStore.Location = new System.Drawing.Point(53, 180);
            this.TextStore.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.TextStore.Name = "TextStore";
            this.TextStore.PasswordChar = '\0';
            this.TextStore.PlaceholderText = "";
            this.TextStore.SelectedText = "";
            this.TextStore.Size = new System.Drawing.Size(250, 67);
            this.TextStore.TabIndex = 22;
            this.TextStore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextResulta
            // 
            this.TextResulta.BorderThickness = 0;
            this.TextResulta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextResulta.DefaultText = "";
            this.TextResulta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextResulta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextResulta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextResulta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextResulta.FillColor = System.Drawing.Color.Transparent;
            this.TextResulta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextResulta.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.TextResulta.ForeColor = System.Drawing.Color.White;
            this.TextResulta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextResulta.Location = new System.Drawing.Point(53, 97);
            this.TextResulta.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TextResulta.Name = "TextResulta";
            this.TextResulta.PasswordChar = '\0';
            this.TextResulta.PlaceholderText = "0";
            this.TextResulta.SelectedText = "";
            this.TextResulta.Size = new System.Drawing.Size(250, 82);
            this.TextResulta.TabIndex = 23;
            this.TextResulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TextResulta.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(373, 577);
            this.Controls.Add(this.TextResulta);
            this.Controls.Add(this.TextStore);
            this.Controls.Add(this.BtnZero);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnPoint);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.BtnPercentage);
            this.Controls.Add(this.BtnMinis);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnFoi);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox BtnExit;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button BtnDiv;
        private Guna.UI2.WinForms.Guna2Button BtnFoi;
        private Guna.UI2.WinForms.Guna2Button BtnMinis;
        private Guna.UI2.WinForms.Guna2Button BtnPlus;
        private Guna.UI2.WinForms.Guna2Button BtnEquals;
        private Guna.UI2.WinForms.Guna2Button Btn3;
        private Guna.UI2.WinForms.Guna2Button Btn6;
        private Guna.UI2.WinForms.Guna2Button Btn9;
        private Guna.UI2.WinForms.Guna2Button BtnPercentage;
        private Guna.UI2.WinForms.Guna2Button BtnZero;
        private Guna.UI2.WinForms.Guna2Button Btn1;
        private Guna.UI2.WinForms.Guna2Button Btn4;
        private Guna.UI2.WinForms.Guna2Button Btn7;
        private Guna.UI2.WinForms.Guna2Button BtnClear;
        private Guna.UI2.WinForms.Guna2Button BtnPoint;
        private Guna.UI2.WinForms.Guna2Button Btn2;
        private Guna.UI2.WinForms.Guna2Button Btn5;
        private Guna.UI2.WinForms.Guna2Button Btn8;
        private Guna.UI2.WinForms.Guna2TextBox TextStore;
        private Guna.UI2.WinForms.Guna2TextBox TextResulta;
    }
}

