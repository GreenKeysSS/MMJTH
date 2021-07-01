namespace Presentation
{
    partial class Kardex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kardex));
            this.panel1 = new System.Windows.Forms.Panel();
            this.prodcodetxt = new System.Windows.Forms.TextBox();
            this.excelexportbtn = new XanderUI.XUIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.productscbo = new System.Windows.Forms.ComboBox();
            this.kardexmc = new System.Windows.Forms.MonthCalendar();
            this.salidasdgv = new System.Windows.Forms.DataGridView();
            this.entradasdgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salidasdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradasdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.prodcodetxt);
            this.panel1.Controls.Add(this.excelexportbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label76);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.productscbo);
            this.panel1.Controls.Add(this.kardexmc);
            this.panel1.Controls.Add(this.salidasdgv);
            this.panel1.Controls.Add(this.entradasdgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 594);
            this.panel1.TabIndex = 0;
            // 
            // prodcodetxt
            // 
            this.prodcodetxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prodcodetxt.BackColor = System.Drawing.Color.White;
            this.prodcodetxt.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodcodetxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.prodcodetxt.Location = new System.Drawing.Point(851, 338);
            this.prodcodetxt.Name = "prodcodetxt";
            this.prodcodetxt.Size = new System.Drawing.Size(241, 33);
            this.prodcodetxt.TabIndex = 169;
            this.prodcodetxt.Click += new System.EventHandler(this.prodcodetxt_Click);
            this.prodcodetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.prodcodetxt_KeyDown);
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
            this.excelexportbtn.Location = new System.Drawing.Point(852, 387);
            this.excelexportbtn.Name = "excelexportbtn";
            this.excelexportbtn.Size = new System.Drawing.Size(114, 33);
            this.excelexportbtn.TabIndex = 168;
            this.excelexportbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(133)))), ((int)(((byte)(69)))));
            this.excelexportbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.excelexportbtn.Click += new System.EventHandler(this.excelexportbtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label2.Location = new System.Drawing.Point(777, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Salidas";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(764, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Entradas";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label3.Location = new System.Drawing.Point(848, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Codigo Prod:";
            // 
            // label76
            // 
            this.label76.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label76.AutoSize = true;
            this.label76.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label76.Location = new System.Drawing.Point(848, 252);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(53, 13);
            this.label76.TabIndex = 67;
            this.label76.Text = "Producto:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(168)))), ((int)(((byte)(210)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(-7, -13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 61);
            this.panel2.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label9.Location = new System.Drawing.Point(30, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 32);
            this.label9.TabIndex = 22;
            this.label9.Text = "KARDEX";
            // 
            // productscbo
            // 
            this.productscbo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.productscbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.productscbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productscbo.BackColor = System.Drawing.Color.White;
            this.productscbo.DropDownHeight = 250;
            this.productscbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productscbo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.productscbo.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.productscbo.FormattingEnabled = true;
            this.productscbo.IntegralHeight = false;
            this.productscbo.Location = new System.Drawing.Point(851, 275);
            this.productscbo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.productscbo.MaxDropDownItems = 100;
            this.productscbo.Name = "productscbo";
            this.productscbo.Size = new System.Drawing.Size(241, 29);
            this.productscbo.TabIndex = 56;
            this.productscbo.SelectedIndexChanged += new System.EventHandler(this.productscbo_SelectedIndexChanged);
            // 
            // kardexmc
            // 
            this.kardexmc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kardexmc.Location = new System.Drawing.Point(851, 73);
            this.kardexmc.MaxSelectionCount = 365;
            this.kardexmc.Name = "kardexmc";
            this.kardexmc.TabIndex = 55;
            this.kardexmc.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.kardexmc_DateChanged);
            // 
            // salidasdgv
            // 
            this.salidasdgv.AllowUserToAddRows = false;
            this.salidasdgv.AllowUserToDeleteRows = false;
            this.salidasdgv.AllowUserToResizeColumns = false;
            this.salidasdgv.AllowUserToResizeRows = false;
            this.salidasdgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salidasdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.salidasdgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.salidasdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salidasdgv.EnableHeadersVisualStyles = false;
            this.salidasdgv.Location = new System.Drawing.Point(24, 310);
            this.salidasdgv.MultiSelect = false;
            this.salidasdgv.Name = "salidasdgv";
            this.salidasdgv.ReadOnly = true;
            this.salidasdgv.RowHeadersVisible = false;
            this.salidasdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salidasdgv.Size = new System.Drawing.Size(805, 231);
            this.salidasdgv.TabIndex = 53;
            // 
            // entradasdgv
            // 
            this.entradasdgv.AllowUserToAddRows = false;
            this.entradasdgv.AllowUserToDeleteRows = false;
            this.entradasdgv.AllowUserToResizeColumns = false;
            this.entradasdgv.AllowUserToResizeRows = false;
            this.entradasdgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entradasdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.entradasdgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.entradasdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entradasdgv.Location = new System.Drawing.Point(24, 73);
            this.entradasdgv.MultiSelect = false;
            this.entradasdgv.Name = "entradasdgv";
            this.entradasdgv.ReadOnly = true;
            this.entradasdgv.RowHeadersVisible = false;
            this.entradasdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.entradasdgv.Size = new System.Drawing.Size(805, 231);
            this.entradasdgv.TabIndex = 54;
            // 
            // Kardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 594);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kardex";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kardex";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salidasdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradasdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView salidasdgv;
        private System.Windows.Forms.DataGridView entradasdgv;
        private System.Windows.Forms.MonthCalendar kardexmc;
        private System.Windows.Forms.ComboBox productscbo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton excelexportbtn;
        private System.Windows.Forms.TextBox prodcodetxt;
        private System.Windows.Forms.Label label3;
    }
}