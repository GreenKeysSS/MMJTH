namespace Presentation
{
    partial class GeneralLists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralLists));
            this.panel1 = new System.Windows.Forms.Panel();
            this.excelexportbtn = new XanderUI.XUIButton();
            this.datedtp = new System.Windows.Forms.DateTimePicker();
            this.searchbtn = new XanderUI.XUIButton();
            this.tosearchtxt = new System.Windows.Forms.TextBox();
            this.generallistdgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titlelbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generallistdgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.excelexportbtn);
            this.panel1.Controls.Add(this.datedtp);
            this.panel1.Controls.Add(this.searchbtn);
            this.panel1.Controls.Add(this.tosearchtxt);
            this.panel1.Controls.Add(this.generallistdgv);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 514);
            this.panel1.TabIndex = 0;
            // 
            // excelexportbtn
            // 
            this.excelexportbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.excelexportbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.excelexportbtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("excelexportbtn.ButtonImage")));
            this.excelexportbtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.excelexportbtn.ButtonText = "Exportar";
            this.excelexportbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.excelexportbtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(69)))));
            this.excelexportbtn.CornerRadius = 5;
            this.excelexportbtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excelexportbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.excelexportbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.excelexportbtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(69)))));
            this.excelexportbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.excelexportbtn.Location = new System.Drawing.Point(806, 82);
            this.excelexportbtn.Name = "excelexportbtn";
            this.excelexportbtn.Size = new System.Drawing.Size(114, 33);
            this.excelexportbtn.TabIndex = 166;
            this.excelexportbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(69)))));
            this.excelexportbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.excelexportbtn.Click += new System.EventHandler(this.excelexportbtn_Click);
            // 
            // datedtp
            // 
            this.datedtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datedtp.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.datedtp.CustomFormat = "MM/yyyy";
            this.datedtp.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datedtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datedtp.Location = new System.Drawing.Point(791, 0);
            this.datedtp.Name = "datedtp";
            this.datedtp.Size = new System.Drawing.Size(123, 33);
            this.datedtp.TabIndex = 61;
            this.datedtp.Visible = false;
            this.datedtp.ValueChanged += new System.EventHandler(this.datedtp_ValueChanged);
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
            this.searchbtn.Location = new System.Drawing.Point(381, 82);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(114, 33);
            this.searchbtn.TabIndex = 54;
            this.searchbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.searchbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // tosearchtxt
            // 
            this.tosearchtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tosearchtxt.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tosearchtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tosearchtxt.Location = new System.Drawing.Point(22, 82);
            this.tosearchtxt.Name = "tosearchtxt";
            this.tosearchtxt.Size = new System.Drawing.Size(353, 33);
            this.tosearchtxt.TabIndex = 53;
            this.tosearchtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tosearchtxt_KeyDown);
            // 
            // generallistdgv
            // 
            this.generallistdgv.AllowUserToAddRows = false;
            this.generallistdgv.AllowUserToDeleteRows = false;
            this.generallistdgv.AllowUserToResizeColumns = false;
            this.generallistdgv.AllowUserToResizeRows = false;
            this.generallistdgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generallistdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.generallistdgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.generallistdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generallistdgv.Location = new System.Drawing.Point(22, 126);
            this.generallistdgv.MultiSelect = false;
            this.generallistdgv.Name = "generallistdgv";
            this.generallistdgv.ReadOnly = true;
            this.generallistdgv.RowHeadersVisible = false;
            this.generallistdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.generallistdgv.Size = new System.Drawing.Size(898, 362);
            this.generallistdgv.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(168)))), ((int)(((byte)(210)))));
            this.panel2.Controls.Add(this.titlelbl);
            this.panel2.Location = new System.Drawing.Point(-23, -11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 61);
            this.panel2.TabIndex = 55;
            // 
            // titlelbl
            // 
            this.titlelbl.BackColor = System.Drawing.Color.Transparent;
            this.titlelbl.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.titlelbl.Location = new System.Drawing.Point(23, 18);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(216, 32);
            this.titlelbl.TabIndex = 22;
            this.titlelbl.Text = "Listas Generales";
            this.titlelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GeneralLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 514);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneralLists";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralLists";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generallistdgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton searchbtn;
        private System.Windows.Forms.TextBox tosearchtxt;
        private System.Windows.Forms.DataGridView generallistdgv;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label titlelbl;
        public System.Windows.Forms.DateTimePicker datedtp;
        private XanderUI.XUIButton excelexportbtn;
    }
}