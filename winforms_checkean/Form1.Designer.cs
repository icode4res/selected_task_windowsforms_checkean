namespace winforms_checkean
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdCheck = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.cboEan = new System.Windows.Forms.ComboBox();
            this.LblEan = new System.Windows.Forms.Label();
            this.LblAusgabe = new System.Windows.Forms.Label();
            this.LblQuersumme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdCheck
            // 
            this.CmdCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CmdCheck.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CmdCheck.FlatAppearance.BorderSize = 10;
            this.CmdCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CmdCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdCheck.Location = new System.Drawing.Point(488, 87);
            this.CmdCheck.Name = "CmdCheck";
            this.CmdCheck.Size = new System.Drawing.Size(128, 31);
            this.CmdCheck.TabIndex = 0;
            this.CmdCheck.Text = "Check";
            this.CmdCheck.UseVisualStyleBackColor = true;
            this.CmdCheck.Click += new System.EventHandler(this.CmdCheck_Click);
            // 
            // CmdClose
            // 
            this.CmdClose.BackColor = System.Drawing.Color.RosyBrown;
            this.CmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CmdClose.Font = new System.Drawing.Font("Tempus Sans ITC", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CmdClose.ForeColor = System.Drawing.Color.Transparent;
            this.CmdClose.Location = new System.Drawing.Point(728, 213);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(81, 34);
            this.CmdClose.TabIndex = 1;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = false;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // cboEan
            // 
            this.cboEan.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboEan.FormattingEnabled = true;
            this.cboEan.Items.AddRange(new object[] {
            "4260036430738",
            "4009350832398",
            "5939857923574",
            "3489539453334",
            "345384975034",
            "34820",
            "23443907923589223"});
            this.cboEan.Location = new System.Drawing.Point(227, 89);
            this.cboEan.Name = "cboEan";
            this.cboEan.Size = new System.Drawing.Size(239, 31);
            this.cboEan.TabIndex = 2;
            this.cboEan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LblEan
            // 
            this.LblEan.AutoSize = true;
            this.LblEan.Font = new System.Drawing.Font("Segoe UI", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEan.Location = new System.Drawing.Point(157, 89);
            this.LblEan.Name = "LblEan";
            this.LblEan.Size = new System.Drawing.Size(50, 28);
            this.LblEan.TabIndex = 3;
            this.LblEan.Text = "EAN";
            // 
            // LblAusgabe
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAusgabe.Location = new System.Drawing.Point(640, 92);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(0, 23);
            this.LblAusgabe.TabIndex = 4;
            // 
            // LblQuersumme
            // 
            this.LblQuersumme.AutoSize = true;
            this.LblQuersumme.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblQuersumme.Location = new System.Drawing.Point(29, 219);
            this.LblQuersumme.Name = "LblQuersumme";
            this.LblQuersumme.Size = new System.Drawing.Size(0, 21);
            this.LblQuersumme.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 258);
            this.Controls.Add(this.LblQuersumme);
            this.Controls.Add(this.LblAusgabe);
            this.Controls.Add(this.LblEan);
            this.Controls.Add(this.cboEan);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdCheck);
            this.Name = "Form1";
            this.Text = "Aufgabe 02: WindowsForms (CheckEAN)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CmdCheck;
        private Button CmdClose;
        private ComboBox cboEan;
        private Label LblEan;
        private Label LblAusgabe;
        private Label LblQuersumme;
    }
}