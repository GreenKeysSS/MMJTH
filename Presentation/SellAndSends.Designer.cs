namespace Presentation
{
    partial class SellAndSends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellAndSends));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gmailsendbtn = new XanderUI.XUIButton();
            this.wasendbtn = new XanderUI.XUIButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbtn = new XanderUI.XUIButton();
            this.texttosearchtxt = new System.Windows.Forms.TextBox();
            this.openaspdfbtn = new XanderUI.XUIButton();
            this.printsellbtn = new XanderUI.XUIButton();
            this.sellproductsdgv = new System.Windows.Forms.DataGridView();
            this.sellsdetaildgv = new System.Windows.Forms.DataGridView();
            this.datedtp = new System.Windows.Forms.DateTimePicker();
            this.excelexportsellbtn = new XanderUI.XUIButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellproductsdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellsdetaildgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.excelexportsellbtn);
            this.panel1.Controls.Add(this.gmailsendbtn);
            this.panel1.Controls.Add(this.wasendbtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchbtn);
            this.panel1.Controls.Add(this.texttosearchtxt);
            this.panel1.Controls.Add(this.openaspdfbtn);
            this.panel1.Controls.Add(this.printsellbtn);
            this.panel1.Controls.Add(this.sellproductsdgv);
            this.panel1.Controls.Add(this.sellsdetaildgv);
            this.panel1.Controls.Add(this.datedtp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 553);
            this.panel1.TabIndex = 0;
            // 
            // gmailsendbtn
            // 
            this.gmailsendbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gmailsendbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(139)))), ((int)(((byte)(203)))));
            this.gmailsendbtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("gmailsendbtn.ButtonImage")));
            this.gmailsendbtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.gmailsendbtn.ButtonText = "Enviar por Gmail";
            this.gmailsendbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(170)))));
            this.gmailsendbtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.gmailsendbtn.CornerRadius = 10;
            this.gmailsendbtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmailsendbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.gmailsendbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(170)))));
            this.gmailsendbtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.gmailsendbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.gmailsendbtn.Location = new System.Drawing.Point(584, 487);
            this.gmailsendbtn.Name = "gmailsendbtn";
            this.gmailsendbtn.Size = new System.Drawing.Size(134, 50);
            this.gmailsendbtn.TabIndex = 49;
            this.gmailsendbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.gmailsendbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.gmailsendbtn.Click += new System.EventHandler(this.gmailsendbtn_Click);
            // 
            // wasendbtn
            // 
            this.wasendbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.wasendbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.wasendbtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("wasendbtn.ButtonImage")));
            this.wasendbtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.wasendbtn.ButtonText = "Enviar por WhatsApp";
            this.wasendbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(121)))), ((int)(((byte)(135)))));
            this.wasendbtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.wasendbtn.CornerRadius = 10;
            this.wasendbtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wasendbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.wasendbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(121)))), ((int)(((byte)(135)))));
            this.wasendbtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.wasendbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.wasendbtn.Location = new System.Drawing.Point(432, 487);
            this.wasendbtn.Name = "wasendbtn";
            this.wasendbtn.Size = new System.Drawing.Size(146, 50);
            this.wasendbtn.TabIndex = 50;
            this.wasendbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.wasendbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.wasendbtn.Click += new System.EventHandler(this.wasendbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(168)))), ((int)(((byte)(210)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(-14, -11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 61);
            this.panel2.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label9.Location = new System.Drawing.Point(36, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 32);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ventas y Envios";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label2.Location = new System.Drawing.Point(997, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(34, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 5;
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
            this.searchbtn.Location = new System.Drawing.Point(389, 67);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(114, 33);
            this.searchbtn.TabIndex = 4;
            this.searchbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.searchbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // texttosearchtxt
            // 
            this.texttosearchtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.texttosearchtxt.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttosearchtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.texttosearchtxt.Location = new System.Drawing.Point(38, 67);
            this.texttosearchtxt.Name = "texttosearchtxt";
            this.texttosearchtxt.Size = new System.Drawing.Size(345, 33);
            this.texttosearchtxt.TabIndex = 3;
            this.texttosearchtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.texttosearchtxt_KeyDown);
            // 
            // openaspdfbtn
            // 
            this.openaspdfbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openaspdfbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(139)))), ((int)(((byte)(203)))));
            this.openaspdfbtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("openaspdfbtn.ButtonImage")));
            this.openaspdfbtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.openaspdfbtn.ButtonText = "Abrir PDF";
            this.openaspdfbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(170)))));
            this.openaspdfbtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.openaspdfbtn.CornerRadius = 5;
            this.openaspdfbtn.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openaspdfbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.openaspdfbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(170)))));
            this.openaspdfbtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.openaspdfbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.openaspdfbtn.Location = new System.Drawing.Point(746, 487);
            this.openaspdfbtn.Name = "openaspdfbtn";
            this.openaspdfbtn.Size = new System.Drawing.Size(140, 50);
            this.openaspdfbtn.TabIndex = 2;
            this.openaspdfbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.openaspdfbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.openaspdfbtn.Click += new System.EventHandler(this.openaspdfbtn_Click);
            // 
            // printsellbtn
            // 
            this.printsellbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.printsellbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(139)))), ((int)(((byte)(203)))));
            this.printsellbtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("printsellbtn.ButtonImage")));
            this.printsellbtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.printsellbtn.ButtonText = "Imprimir Venta";
            this.printsellbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(170)))));
            this.printsellbtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.printsellbtn.CornerRadius = 5;
            this.printsellbtn.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printsellbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.printsellbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(170)))));
            this.printsellbtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.printsellbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.printsellbtn.Location = new System.Drawing.Point(892, 487);
            this.printsellbtn.Name = "printsellbtn";
            this.printsellbtn.Size = new System.Drawing.Size(185, 50);
            this.printsellbtn.TabIndex = 2;
            this.printsellbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.printsellbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.printsellbtn.Click += new System.EventHandler(this.printsellbtn_Click);
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
            this.sellproductsdgv.Location = new System.Drawing.Point(596, 126);
            this.sellproductsdgv.MultiSelect = false;
            this.sellproductsdgv.Name = "sellproductsdgv";
            this.sellproductsdgv.ReadOnly = true;
            this.sellproductsdgv.RowHeadersVisible = false;
            this.sellproductsdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellproductsdgv.Size = new System.Drawing.Size(481, 343);
            this.sellproductsdgv.TabIndex = 1;
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
            this.sellsdetaildgv.Location = new System.Drawing.Point(38, 126);
            this.sellsdetaildgv.MultiSelect = false;
            this.sellsdetaildgv.Name = "sellsdetaildgv";
            this.sellsdetaildgv.ReadOnly = true;
            this.sellsdetaildgv.RowHeadersVisible = false;
            this.sellsdetaildgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellsdetaildgv.Size = new System.Drawing.Size(552, 343);
            this.sellsdetaildgv.TabIndex = 1;
            this.sellsdetaildgv.SelectionChanged += new System.EventHandler(this.sellsdetaildgv_SelectionChanged);
            // 
            // datedtp
            // 
            this.datedtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datedtp.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.datedtp.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datedtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datedtp.Location = new System.Drawing.Point(920, 0);
            this.datedtp.Name = "datedtp";
            this.datedtp.Size = new System.Drawing.Size(157, 33);
            this.datedtp.TabIndex = 51;
            this.datedtp.ValueChanged += new System.EventHandler(this.datedtp_ValueChanged);
            // 
            // excelexportsellbtn
            // 
            this.excelexportsellbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.excelexportsellbtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("excelexportsellbtn.ButtonImage")));
            this.excelexportsellbtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.excelexportsellbtn.ButtonText = "Exportar";
            this.excelexportsellbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.excelexportsellbtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(69)))));
            this.excelexportsellbtn.CornerRadius = 5;
            this.excelexportsellbtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excelexportsellbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.excelexportsellbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.excelexportsellbtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(69)))));
            this.excelexportsellbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.excelexportsellbtn.Location = new System.Drawing.Point(509, 67);
            this.excelexportsellbtn.Name = "excelexportsellbtn";
            this.excelexportsellbtn.Size = new System.Drawing.Size(114, 33);
            this.excelexportsellbtn.TabIndex = 167;
            this.excelexportsellbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(69)))));
            this.excelexportsellbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.excelexportsellbtn.Click += new System.EventHandler(this.excelexportsellbtn_Click);
            // 
            // SellAndSends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 553);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SellAndSends";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reimprimir Venta";
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
        private System.Windows.Forms.DataGridView sellproductsdgv;
        private System.Windows.Forms.DataGridView sellsdetaildgv;
        private XanderUI.XUIButton printsellbtn;
        private XanderUI.XUIButton searchbtn;
        private System.Windows.Forms.TextBox texttosearchtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton openaspdfbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private XanderUI.XUIButton gmailsendbtn;
        private XanderUI.XUIButton wasendbtn;
        private System.Windows.Forms.DateTimePicker datedtp;
        private XanderUI.XUIButton excelexportsellbtn;
    }
}