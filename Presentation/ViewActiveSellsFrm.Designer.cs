namespace Presentation
{
    partial class ViewActiveSellsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewActiveSellsFrm));
            this.activesellsdgv = new System.Windows.Forms.DataGridView();
            this.deletesellbtn = new System.Windows.Forms.Button();
            this.RestoreSellbtn = new System.Windows.Forms.Button();
            this.ClientNametxt = new System.Windows.Forms.TextBox();
            this.Totaltxt = new System.Windows.Forms.TextBox();
            this.DateTimetxt = new System.Windows.Forms.TextBox();
            this.productsviewdgv = new System.Windows.Forms.DataGridView();
            this.employnametxt = new System.Windows.Forms.TextBox();
            this.errormessagelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.subtotaltxt = new System.Windows.Forms.TextBox();
            this.paymethodtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtotxt = new System.Windows.Forms.TextBox();
            this.dtotypelbl = new System.Windows.Forms.Label();
            this.igvtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gravadatxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtovaltxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.activesellsdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsviewdgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // activesellsdgv
            // 
            this.activesellsdgv.AllowUserToAddRows = false;
            this.activesellsdgv.AllowUserToDeleteRows = false;
            this.activesellsdgv.AllowUserToResizeColumns = false;
            this.activesellsdgv.AllowUserToResizeRows = false;
            this.activesellsdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.activesellsdgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.activesellsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activesellsdgv.Location = new System.Drawing.Point(12, 62);
            this.activesellsdgv.MultiSelect = false;
            this.activesellsdgv.Name = "activesellsdgv";
            this.activesellsdgv.ReadOnly = true;
            this.activesellsdgv.RowHeadersVisible = false;
            this.activesellsdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activesellsdgv.Size = new System.Drawing.Size(228, 490);
            this.activesellsdgv.TabIndex = 0;
            this.activesellsdgv.SelectionChanged += new System.EventHandler(this.activesellsdgv_SelectionChanged);
            // 
            // deletesellbtn
            // 
            this.deletesellbtn.BackColor = System.Drawing.Color.Crimson;
            this.deletesellbtn.FlatAppearance.BorderSize = 0;
            this.deletesellbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletesellbtn.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletesellbtn.Location = new System.Drawing.Point(467, 591);
            this.deletesellbtn.Name = "deletesellbtn";
            this.deletesellbtn.Size = new System.Drawing.Size(162, 32);
            this.deletesellbtn.TabIndex = 1;
            this.deletesellbtn.Text = "Eliminar Venta Activa";
            this.deletesellbtn.UseVisualStyleBackColor = false;
            this.deletesellbtn.Click += new System.EventHandler(this.deletesellbtn_Click);
            // 
            // RestoreSellbtn
            // 
            this.RestoreSellbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(139)))), ((int)(((byte)(202)))));
            this.RestoreSellbtn.FlatAppearance.BorderSize = 0;
            this.RestoreSellbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreSellbtn.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoreSellbtn.Location = new System.Drawing.Point(635, 591);
            this.RestoreSellbtn.Name = "RestoreSellbtn";
            this.RestoreSellbtn.Size = new System.Drawing.Size(117, 32);
            this.RestoreSellbtn.TabIndex = 2;
            this.RestoreSellbtn.Text = "Continuar";
            this.RestoreSellbtn.UseVisualStyleBackColor = false;
            this.RestoreSellbtn.Click += new System.EventHandler(this.RestoreSellbtn_Click);
            // 
            // ClientNametxt
            // 
            this.ClientNametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientNametxt.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNametxt.Location = new System.Drawing.Point(374, 67);
            this.ClientNametxt.Name = "ClientNametxt";
            this.ClientNametxt.ReadOnly = true;
            this.ClientNametxt.Size = new System.Drawing.Size(378, 27);
            this.ClientNametxt.TabIndex = 3;
            // 
            // Totaltxt
            // 
            this.Totaltxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Totaltxt.Font = new System.Drawing.Font("Nirmala UI", 11.25F);
            this.Totaltxt.Location = new System.Drawing.Point(374, 172);
            this.Totaltxt.Name = "Totaltxt";
            this.Totaltxt.ReadOnly = true;
            this.Totaltxt.Size = new System.Drawing.Size(81, 27);
            this.Totaltxt.TabIndex = 3;
            // 
            // DateTimetxt
            // 
            this.DateTimetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.DateTimetxt.Font = new System.Drawing.Font("Nirmala UI", 11.25F);
            this.DateTimetxt.Location = new System.Drawing.Point(374, 242);
            this.DateTimetxt.Name = "DateTimetxt";
            this.DateTimetxt.ReadOnly = true;
            this.DateTimetxt.Size = new System.Drawing.Size(216, 27);
            this.DateTimetxt.TabIndex = 3;
            // 
            // productsviewdgv
            // 
            this.productsviewdgv.AllowUserToAddRows = false;
            this.productsviewdgv.AllowUserToDeleteRows = false;
            this.productsviewdgv.AllowUserToResizeColumns = false;
            this.productsviewdgv.AllowUserToResizeRows = false;
            this.productsviewdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.productsviewdgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.productsviewdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsviewdgv.Location = new System.Drawing.Point(246, 280);
            this.productsviewdgv.Name = "productsviewdgv";
            this.productsviewdgv.ReadOnly = true;
            this.productsviewdgv.RowHeadersVisible = false;
            this.productsviewdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsviewdgv.Size = new System.Drawing.Size(506, 272);
            this.productsviewdgv.TabIndex = 6;
            // 
            // employnametxt
            // 
            this.employnametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.employnametxt.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employnametxt.Location = new System.Drawing.Point(374, 102);
            this.employnametxt.Name = "employnametxt";
            this.employnametxt.ReadOnly = true;
            this.employnametxt.Size = new System.Drawing.Size(273, 27);
            this.employnametxt.TabIndex = 7;
            // 
            // errormessagelbl
            // 
            this.errormessagelbl.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errormessagelbl.ForeColor = System.Drawing.Color.White;
            this.errormessagelbl.Location = new System.Drawing.Point(246, 562);
            this.errormessagelbl.Name = "errormessagelbl";
            this.errormessagelbl.Size = new System.Drawing.Size(506, 20);
            this.errormessagelbl.TabIndex = 8;
            this.errormessagelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(246, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre del Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label2.Location = new System.Drawing.Point(247, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total de la Venta S/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label3.Location = new System.Drawing.Point(294, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label4.Location = new System.Drawing.Point(322, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cajero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label5.Location = new System.Drawing.Point(17, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ventas Activas";
            // 
            // subtotaltxt
            // 
            this.subtotaltxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.subtotaltxt.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotaltxt.Location = new System.Drawing.Point(374, 137);
            this.subtotaltxt.Name = "subtotaltxt";
            this.subtotaltxt.ReadOnly = true;
            this.subtotaltxt.Size = new System.Drawing.Size(81, 27);
            this.subtotaltxt.TabIndex = 7;
            // 
            // paymethodtxt
            // 
            this.paymethodtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.paymethodtxt.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymethodtxt.Location = new System.Drawing.Point(374, 207);
            this.paymethodtxt.Name = "paymethodtxt";
            this.paymethodtxt.ReadOnly = true;
            this.paymethodtxt.Size = new System.Drawing.Size(216, 27);
            this.paymethodtxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label6.Location = new System.Drawing.Point(279, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Método Pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label7.Location = new System.Drawing.Point(293, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Subtotal S/.";
            // 
            // dtotxt
            // 
            this.dtotxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.dtotxt.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtotxt.Location = new System.Drawing.Point(526, 137);
            this.dtotxt.Name = "dtotxt";
            this.dtotxt.ReadOnly = true;
            this.dtotxt.Size = new System.Drawing.Size(81, 27);
            this.dtotxt.TabIndex = 7;
            // 
            // dtotypelbl
            // 
            this.dtotypelbl.AutoSize = true;
            this.dtotypelbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtotypelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.dtotypelbl.Location = new System.Drawing.Point(472, 142);
            this.dtotypelbl.Name = "dtotypelbl";
            this.dtotypelbl.Size = new System.Drawing.Size(32, 17);
            this.dtotypelbl.TabIndex = 9;
            this.dtotypelbl.Text = "Dto.";
            // 
            // igvtxt
            // 
            this.igvtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.igvtxt.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igvtxt.Location = new System.Drawing.Point(509, 172);
            this.igvtxt.Name = "igvtxt";
            this.igvtxt.ReadOnly = true;
            this.igvtxt.Size = new System.Drawing.Size(81, 27);
            this.igvtxt.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label9.Location = new System.Drawing.Point(475, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "IGV";
            // 
            // gravadatxt
            // 
            this.gravadatxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.gravadatxt.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravadatxt.Location = new System.Drawing.Point(671, 172);
            this.gravadatxt.Name = "gravadatxt";
            this.gravadatxt.ReadOnly = true;
            this.gravadatxt.Size = new System.Drawing.Size(81, 27);
            this.gravadatxt.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label10.Location = new System.Drawing.Point(613, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Gravada";
            // 
            // dtovaltxt
            // 
            this.dtovaltxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.dtovaltxt.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtovaltxt.Location = new System.Drawing.Point(671, 207);
            this.dtovaltxt.Name = "dtovaltxt";
            this.dtovaltxt.ReadOnly = true;
            this.dtovaltxt.Size = new System.Drawing.Size(81, 27);
            this.dtovaltxt.TabIndex = 7;
            this.dtovaltxt.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label11.Location = new System.Drawing.Point(621, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "dtoval";
            this.label11.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(168)))), ((int)(((byte)(210)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(-5, -9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 59);
            this.panel2.TabIndex = 24;
            // 
            // ViewActiveSellsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(764, 635);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtotypelbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errormessagelbl);
            this.Controls.Add(this.paymethodtxt);
            this.Controls.Add(this.dtovaltxt);
            this.Controls.Add(this.gravadatxt);
            this.Controls.Add(this.igvtxt);
            this.Controls.Add(this.dtotxt);
            this.Controls.Add(this.subtotaltxt);
            this.Controls.Add(this.employnametxt);
            this.Controls.Add(this.productsviewdgv);
            this.Controls.Add(this.DateTimetxt);
            this.Controls.Add(this.Totaltxt);
            this.Controls.Add(this.ClientNametxt);
            this.Controls.Add(this.RestoreSellbtn);
            this.Controls.Add(this.deletesellbtn);
            this.Controls.Add(this.activesellsdgv);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ViewActiveSellsFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Y ";
            this.Text = "Ventas Activas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ViewActiveSells_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.activesellsdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsviewdgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deletesellbtn;
        private System.Windows.Forms.Button RestoreSellbtn;
        private System.Windows.Forms.TextBox ClientNametxt;
        private System.Windows.Forms.TextBox Totaltxt;
        private System.Windows.Forms.TextBox DateTimetxt;
        public System.Windows.Forms.DataGridView activesellsdgv;
        private System.Windows.Forms.DataGridView productsviewdgv;
        private System.Windows.Forms.TextBox employnametxt;
        private System.Windows.Forms.Label errormessagelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox subtotaltxt;
        private System.Windows.Forms.TextBox paymethodtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dtotxt;
        private System.Windows.Forms.Label dtotypelbl;
        private System.Windows.Forms.TextBox igvtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox gravadatxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dtovaltxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
    }
}