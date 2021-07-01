namespace Presentation
{
    partial class ModifySellFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifySellFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.datedtp = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbtn = new XanderUI.XUIButton();
            this.tosearchtxt = new System.Windows.Forms.TextBox();
            this.deletesellbtn = new XanderUI.XUIButton();
            this.refundbtn = new XanderUI.XUIButton();
            this.sellproductsdgv = new System.Windows.Forms.DataGridView();
            this.sellsdetaildgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellproductsdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellsdetaildgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.datedtp);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchbtn);
            this.panel1.Controls.Add(this.tosearchtxt);
            this.panel1.Controls.Add(this.deletesellbtn);
            this.panel1.Controls.Add(this.refundbtn);
            this.panel1.Controls.Add(this.sellproductsdgv);
            this.panel1.Controls.Add(this.sellsdetaildgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 565);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label3.Location = new System.Drawing.Point(47, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(439, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "*Los descuentos no son validos despues de realizar la devolución";
            // 
            // datedtp
            // 
            this.datedtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datedtp.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.datedtp.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datedtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datedtp.Location = new System.Drawing.Point(965, 0);
            this.datedtp.Name = "datedtp";
            this.datedtp.Size = new System.Drawing.Size(157, 33);
            this.datedtp.TabIndex = 60;
            this.datedtp.ValueChanged += new System.EventHandler(this.datedtp_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(168)))), ((int)(((byte)(210)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(-11, -13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 61);
            this.panel2.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label9.Location = new System.Drawing.Point(26, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 32);
            this.label9.TabIndex = 22;
            this.label9.Text = "Modificar Venta";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label2.Location = new System.Drawing.Point(1042, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(37, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Ventas";
            // 
            // searchbtn
            // 
            this.searchbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(139)))), ((int)(((byte)(200)))));
            this.searchbtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("searchbtn.ButtonImage")));
            this.searchbtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.searchbtn.ButtonText = "Buscar";
            this.searchbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.searchbtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.searchbtn.CornerRadius = 5;
            this.searchbtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.searchbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.searchbtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.searchbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.searchbtn.Location = new System.Drawing.Point(392, 65);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(114, 33);
            this.searchbtn.TabIndex = 56;
            this.searchbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.searchbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click_1);
            // 
            // tosearchtxt
            // 
            this.tosearchtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tosearchtxt.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tosearchtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tosearchtxt.Location = new System.Drawing.Point(41, 65);
            this.tosearchtxt.Name = "tosearchtxt";
            this.tosearchtxt.Size = new System.Drawing.Size(345, 33);
            this.tosearchtxt.TabIndex = 55;
            this.tosearchtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tosearchtxt_KeyDown);
            // 
            // deletesellbtn
            // 
            this.deletesellbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletesellbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.deletesellbtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("deletesellbtn.ButtonImage")));
            this.deletesellbtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.deletesellbtn.ButtonText = "Anular Venta";
            this.deletesellbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.deletesellbtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.deletesellbtn.CornerRadius = 5;
            this.deletesellbtn.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletesellbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.deletesellbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.deletesellbtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.deletesellbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.deletesellbtn.Location = new System.Drawing.Point(724, 497);
            this.deletesellbtn.Name = "deletesellbtn";
            this.deletesellbtn.Size = new System.Drawing.Size(175, 50);
            this.deletesellbtn.TabIndex = 54;
            this.deletesellbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.deletesellbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.deletesellbtn.Click += new System.EventHandler(this.deletesellbtn_Click);
            // 
            // refundbtn
            // 
            this.refundbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refundbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(139)))), ((int)(((byte)(203)))));
            this.refundbtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("refundbtn.ButtonImage")));
            this.refundbtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.refundbtn.ButtonText = "Devolver Producto";
            this.refundbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.refundbtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.refundbtn.CornerRadius = 5;
            this.refundbtn.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refundbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.refundbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.refundbtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.refundbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.refundbtn.Location = new System.Drawing.Point(905, 497);
            this.refundbtn.Name = "refundbtn";
            this.refundbtn.Size = new System.Drawing.Size(217, 50);
            this.refundbtn.TabIndex = 54;
            this.refundbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.refundbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.refundbtn.Click += new System.EventHandler(this.refundbtn_Click);
            // 
            // sellproductsdgv
            // 
            this.sellproductsdgv.AllowUserToAddRows = false;
            this.sellproductsdgv.AllowUserToDeleteRows = false;
            this.sellproductsdgv.AllowUserToResizeColumns = false;
            this.sellproductsdgv.AllowUserToResizeRows = false;
            this.sellproductsdgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellproductsdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.sellproductsdgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.sellproductsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellproductsdgv.EnableHeadersVisualStyles = false;
            this.sellproductsdgv.Location = new System.Drawing.Point(603, 136);
            this.sellproductsdgv.MultiSelect = false;
            this.sellproductsdgv.Name = "sellproductsdgv";
            this.sellproductsdgv.ReadOnly = true;
            this.sellproductsdgv.RowHeadersVisible = false;
            this.sellproductsdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellproductsdgv.Size = new System.Drawing.Size(519, 343);
            this.sellproductsdgv.TabIndex = 51;
            // 
            // sellsdetaildgv
            // 
            this.sellsdetaildgv.AllowUserToAddRows = false;
            this.sellsdetaildgv.AllowUserToDeleteRows = false;
            this.sellsdetaildgv.AllowUserToResizeColumns = false;
            this.sellsdetaildgv.AllowUserToResizeRows = false;
            this.sellsdetaildgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellsdetaildgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.sellsdetaildgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.sellsdetaildgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellsdetaildgv.Location = new System.Drawing.Point(41, 136);
            this.sellsdetaildgv.MultiSelect = false;
            this.sellsdetaildgv.Name = "sellsdetaildgv";
            this.sellsdetaildgv.ReadOnly = true;
            this.sellsdetaildgv.RowHeadersVisible = false;
            this.sellsdetaildgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellsdetaildgv.Size = new System.Drawing.Size(556, 343);
            this.sellsdetaildgv.TabIndex = 52;
            this.sellsdetaildgv.SelectionChanged += new System.EventHandler(this.sellsdetaildgv_SelectionChanged);
            // 
            // ModifySellFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 565);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifySellFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellproductsdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellsdetaildgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton searchbtn;
        private System.Windows.Forms.TextBox tosearchtxt;
        private XanderUI.XUIButton refundbtn;
        private System.Windows.Forms.DataGridView sellproductsdgv;
        private System.Windows.Forms.DataGridView sellsdetaildgv;
        private System.Windows.Forms.DateTimePicker datedtp;
        private System.Windows.Forms.Label label3;
        private XanderUI.XUIButton deletesellbtn;
    }
}