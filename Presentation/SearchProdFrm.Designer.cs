namespace Presentation
{
    partial class SearchProdFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchProdFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectprodbtn = new XanderUI.XUIButton();
            this.searchbtn = new XanderUI.XUIButton();
            this.tosearchtxt = new System.Windows.Forms.TextBox();
            this.searchproddgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchproddgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.selectprodbtn);
            this.panel1.Controls.Add(this.searchbtn);
            this.panel1.Controls.Add(this.tosearchtxt);
            this.panel1.Controls.Add(this.searchproddgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 417);
            this.panel1.TabIndex = 0;
            // 
            // selectprodbtn
            // 
            this.selectprodbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(247)))), ((int)(((byte)(130)))));
            this.selectprodbtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("selectprodbtn.ButtonImage")));
            this.selectprodbtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.selectprodbtn.ButtonText = "Elegir Producto";
            this.selectprodbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.selectprodbtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.selectprodbtn.CornerRadius = 5;
            this.selectprodbtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectprodbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.selectprodbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.selectprodbtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.selectprodbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.selectprodbtn.Location = new System.Drawing.Point(491, 25);
            this.selectprodbtn.Name = "selectprodbtn";
            this.selectprodbtn.Size = new System.Drawing.Size(162, 33);
            this.selectprodbtn.TabIndex = 61;
            this.selectprodbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.selectprodbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.selectprodbtn.Click += new System.EventHandler(this.selectprodbtn_Click);
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
            this.searchbtn.Location = new System.Drawing.Point(371, 25);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(114, 33);
            this.searchbtn.TabIndex = 61;
            this.searchbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.searchbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // tosearchtxt
            // 
            this.tosearchtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tosearchtxt.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tosearchtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tosearchtxt.Location = new System.Drawing.Point(20, 25);
            this.tosearchtxt.Name = "tosearchtxt";
            this.tosearchtxt.Size = new System.Drawing.Size(345, 33);
            this.tosearchtxt.TabIndex = 1;
            this.tosearchtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tosearchtxt_KeyDown);
            // 
            // searchproddgv
            // 
            this.searchproddgv.AllowUserToAddRows = false;
            this.searchproddgv.AllowUserToDeleteRows = false;
            this.searchproddgv.AllowUserToResizeColumns = false;
            this.searchproddgv.AllowUserToResizeRows = false;
            this.searchproddgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchproddgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.searchproddgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.searchproddgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchproddgv.Location = new System.Drawing.Point(20, 68);
            this.searchproddgv.MultiSelect = false;
            this.searchproddgv.Name = "searchproddgv";
            this.searchproddgv.ReadOnly = true;
            this.searchproddgv.RowHeadersVisible = false;
            this.searchproddgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchproddgv.Size = new System.Drawing.Size(786, 331);
            this.searchproddgv.TabIndex = 59;
            // 
            // SearchProdFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 417);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchProdFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Producto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchproddgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton selectprodbtn;
        private XanderUI.XUIButton searchbtn;
        private System.Windows.Forms.DataGridView searchproddgv;
        public System.Windows.Forms.TextBox tosearchtxt;
    }
}