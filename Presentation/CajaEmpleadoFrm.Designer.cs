namespace Presentation
{
    partial class CajaEmpleadoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CajaEmpleadoFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.devtxt = new System.Windows.Forms.TextBox();
            this.dtotxt = new System.Windows.Forms.TextBox();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.excelexportbtn = new XanderUI.XUIButton();
            this.label16 = new System.Windows.Forms.Label();
            this.empcbo = new System.Windows.Forms.ComboBox();
            this.datedtp = new System.Windows.Forms.DateTimePicker();
            this.cajadatadgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.titlelbl = new System.Windows.Forms.Label();
            this.turncbo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cajadatadgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.devtxt);
            this.panel1.Controls.Add(this.dtotxt);
            this.panel1.Controls.Add(this.totaltxt);
            this.panel1.Controls.Add(this.excelexportbtn);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.turncbo);
            this.panel1.Controls.Add(this.empcbo);
            this.panel1.Controls.Add(this.datedtp);
            this.panel1.Controls.Add(this.cajadatadgv);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 358);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(597, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 169;
            this.label1.Text = "Dtos. S/.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label2.Location = new System.Drawing.Point(478, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 169;
            this.label2.Text = "Turno";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label18.Location = new System.Drawing.Point(478, 227);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 169;
            this.label18.Text = "Total S/.";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label17.Location = new System.Drawing.Point(478, 286);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 13);
            this.label17.TabIndex = 170;
            this.label17.Text = "Devoluciones S/.";
            // 
            // devtxt
            // 
            this.devtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.devtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.devtxt.Enabled = false;
            this.devtxt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devtxt.Location = new System.Drawing.Point(481, 309);
            this.devtxt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.devtxt.Name = "devtxt";
            this.devtxt.Size = new System.Drawing.Size(95, 29);
            this.devtxt.TabIndex = 166;
            // 
            // dtotxt
            // 
            this.dtotxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtotxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.dtotxt.Enabled = false;
            this.dtotxt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtotxt.Location = new System.Drawing.Point(600, 309);
            this.dtotxt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.dtotxt.Name = "dtotxt";
            this.dtotxt.Size = new System.Drawing.Size(95, 29);
            this.dtotxt.TabIndex = 167;
            // 
            // totaltxt
            // 
            this.totaltxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totaltxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.totaltxt.Enabled = false;
            this.totaltxt.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltxt.Location = new System.Drawing.Point(481, 250);
            this.totaltxt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(95, 29);
            this.totaltxt.TabIndex = 167;
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
            this.excelexportbtn.Location = new System.Drawing.Point(341, 90);
            this.excelexportbtn.Name = "excelexportbtn";
            this.excelexportbtn.Size = new System.Drawing.Size(114, 33);
            this.excelexportbtn.TabIndex = 165;
            this.excelexportbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(69)))));
            this.excelexportbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.excelexportbtn.Click += new System.EventHandler(this.excelexportbtn_Click);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label16.Location = new System.Drawing.Point(478, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 71;
            this.label16.Text = "Empleado";
            // 
            // empcbo
            // 
            this.empcbo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.empcbo.BackColor = System.Drawing.Color.White;
            this.empcbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empcbo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empcbo.FormattingEnabled = true;
            this.empcbo.Location = new System.Drawing.Point(481, 120);
            this.empcbo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.empcbo.MaxDropDownItems = 18;
            this.empcbo.Name = "empcbo";
            this.empcbo.Size = new System.Drawing.Size(241, 33);
            this.empcbo.TabIndex = 68;
            this.empcbo.SelectedIndexChanged += new System.EventHandler(this.empcbo_SelectedIndexChanged);
            // 
            // datedtp
            // 
            this.datedtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datedtp.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.datedtp.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datedtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datedtp.Location = new System.Drawing.Point(564, 0);
            this.datedtp.Name = "datedtp";
            this.datedtp.Size = new System.Drawing.Size(157, 33);
            this.datedtp.TabIndex = 65;
            this.datedtp.ValueChanged += new System.EventHandler(this.datedtp_ValueChanged);
            // 
            // cajadatadgv
            // 
            this.cajadatadgv.AllowUserToAddRows = false;
            this.cajadatadgv.AllowUserToDeleteRows = false;
            this.cajadatadgv.AllowUserToResizeColumns = false;
            this.cajadatadgv.AllowUserToResizeRows = false;
            this.cajadatadgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cajadatadgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.cajadatadgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.cajadatadgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cajadatadgv.Location = new System.Drawing.Point(18, 129);
            this.cajadatadgv.MultiSelect = false;
            this.cajadatadgv.Name = "cajadatadgv";
            this.cajadatadgv.ReadOnly = true;
            this.cajadatadgv.RowHeadersVisible = false;
            this.cajadatadgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cajadatadgv.Size = new System.Drawing.Size(437, 210);
            this.cajadatadgv.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(168)))), ((int)(((byte)(210)))));
            this.panel2.Controls.Add(this.titlelbl);
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 62);
            this.panel2.TabIndex = 63;
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.BackColor = System.Drawing.Color.Transparent;
            this.titlelbl.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.titlelbl.Location = new System.Drawing.Point(8, 14);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(272, 32);
            this.titlelbl.TabIndex = 22;
            this.titlelbl.Text = "Caja General Empleados";
            // 
            // turncbo
            // 
            this.turncbo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.turncbo.BackColor = System.Drawing.Color.White;
            this.turncbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.turncbo.Enabled = false;
            this.turncbo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turncbo.FormattingEnabled = true;
            this.turncbo.Items.AddRange(new object[] {
            "SELECCIONE",
            "MAÑANA ",
            "TARDE"});
            this.turncbo.Location = new System.Drawing.Point(481, 185);
            this.turncbo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.turncbo.MaxDropDownItems = 18;
            this.turncbo.Name = "turncbo";
            this.turncbo.Size = new System.Drawing.Size(196, 33);
            this.turncbo.TabIndex = 68;
            this.turncbo.SelectedIndexChanged += new System.EventHandler(this.empcbo_SelectedIndexChanged);
            // 
            // CajaEmpleadoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 358);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CajaEmpleadoFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CajaEmpleadoFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cajadatadgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker datedtp;
        private System.Windows.Forms.DataGridView cajadatadgv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox empcbo;
        private XanderUI.XUIButton excelexportbtn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox devtxt;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dtotxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox turncbo;
    }
}