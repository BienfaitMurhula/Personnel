namespace Personnel.user
{
    partial class Fonction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.design = new Guna.UI.WinForms.GunaLineTextBox();
            this.date1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.salaire = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(780, 59);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLabel4.Font = new System.Drawing.Font("Plantagenet Cherokee", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(0, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(776, 55);
            this.gunaLabel4.TabIndex = 30;
            this.gunaLabel4.Text = "AJOUTER UNE FONCTION";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaPanel2.Controls.Add(this.gunaPanel3);
            this.gunaPanel2.Controls.Add(this.design);
            this.gunaPanel2.Controls.Add(this.date1);
            this.gunaPanel2.Controls.Add(this.salaire);
            this.gunaPanel2.Controls.Add(this.gunaLabel6);
            this.gunaPanel2.Controls.Add(this.gunaLabel3);
            this.gunaPanel2.Controls.Add(this.gunaLabel1);
            this.gunaPanel2.Controls.Add(this.dataGridView1);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 59);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(780, 452);
            this.gunaPanel2.TabIndex = 1;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.gunaButton3);
            this.gunaPanel3.Controls.Add(this.gunaButton2);
            this.gunaPanel3.Controls.Add(this.gunaButton1);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 158);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(776, 66);
            this.gunaPanel3.TabIndex = 35;
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BorderColor = System.Drawing.Color.White;
            this.gunaButton3.BorderSize = 1;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = null;
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(282, 15);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.Green;
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Blue;
            this.gunaButton3.Radius = 20;
            this.gunaButton3.Size = new System.Drawing.Size(115, 36);
            this.gunaButton3.TabIndex = 28;
            this.gunaButton3.Text = "Supprimer";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BorderColor = System.Drawing.Color.White;
            this.gunaButton2.BorderSize = 1;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(148, 14);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.Green;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Blue;
            this.gunaButton2.Radius = 20;
            this.gunaButton2.Size = new System.Drawing.Size(115, 36);
            this.gunaButton2.TabIndex = 27;
            this.gunaButton2.Text = "Modifier";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.White;
            this.gunaButton1.BorderSize = 1;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(14, 15);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Green;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Blue;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(115, 36);
            this.gunaButton1.TabIndex = 26;
            this.gunaButton1.Text = "Enregistrer";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // design
            // 
            this.design.BackColor = System.Drawing.Color.White;
            this.design.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.design.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.design.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.design.LineColor = System.Drawing.Color.Gainsboro;
            this.design.Location = new System.Drawing.Point(96, 21);
            this.design.Name = "design";
            this.design.PasswordChar = '\0';
            this.design.Size = new System.Drawing.Size(229, 33);
            this.design.TabIndex = 34;
            // 
            // date1
            // 
            this.date1.BaseColor = System.Drawing.Color.White;
            this.date1.BorderColor = System.Drawing.Color.Silver;
            this.date1.CustomFormat = null;
            this.date1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date1.ForeColor = System.Drawing.Color.Black;
            this.date1.Location = new System.Drawing.Point(96, 55);
            this.date1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date1.MinDate = new System.DateTime(2022, 3, 12, 0, 0, 0, 0);
            this.date1.Name = "date1";
            this.date1.OnHoverBaseColor = System.Drawing.Color.White;
            this.date1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date1.OnPressedColor = System.Drawing.Color.Black;
            this.date1.Size = new System.Drawing.Size(229, 30);
            this.date1.TabIndex = 33;
            this.date1.Text = "samedi 12 mars 2022";
            this.date1.Value = new System.DateTime(2022, 3, 12, 0, 0, 0, 0);
            // 
            // salaire
            // 
            this.salaire.BackColor = System.Drawing.Color.White;
            this.salaire.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salaire.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.salaire.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.salaire.LineColor = System.Drawing.Color.Gainsboro;
            this.salaire.Location = new System.Drawing.Point(96, 88);
            this.salaire.Name = "salaire";
            this.salaire.PasswordChar = '\0';
            this.salaire.Size = new System.Drawing.Size(229, 32);
            this.salaire.TabIndex = 32;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.White;
            this.gunaLabel6.Location = new System.Drawing.Point(3, 55);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(95, 29);
            this.gunaLabel6.TabIndex = 30;
            this.gunaLabel6.Text = "Date engagement";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(3, 88);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(95, 32);
            this.gunaLabel3.TabIndex = 29;
            this.gunaLabel3.Text = "Salaire";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(3, 21);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(95, 30);
            this.gunaLabel1.TabIndex = 28;
            this.gunaLabel1.Text = "Designation";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Fonction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "Fonction";
            this.Size = new System.Drawing.Size(780, 511);
            this.Load += new System.EventHandler(this.Fonction_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaLineTextBox design;
        private Guna.UI.WinForms.GunaDateTimePicker date1;
        private Guna.UI.WinForms.GunaLineTextBox salaire;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}
