namespace Presentation
{
    partial class ClientFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.exitbtn = new XanderUI.XUIButton();
            this.continuebtn = new XanderUI.XUIButton();
            this.modifybtn = new XanderUI.XUIButton();
            this.label10 = new System.Windows.Forms.Label();
            this.deletebtn = new XanderUI.XUIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.addbtn = new XanderUI.XUIButton();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.confirmpanel = new System.Windows.Forms.Panel();
            this.savebtn = new XanderUI.XUIButton();
            this.discardbtn = new XanderUI.XUIButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fijotxt = new System.Windows.Forms.TextBox();
            this.lastvisittxt = new System.Windows.Forms.TextBox();
            this.creationdatetxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.moviltxt = new System.Windows.Forms.TextBox();
            this.ClientNametxt = new System.Windows.Forms.TextBox();
            this.clientdgv = new System.Windows.Forms.DataGridView();
            this.clienttosearchbtn = new XanderUI.XUIButton();
            this.clienttosearchtxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.confirmpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.exitbtn);
            this.panel1.Controls.Add(this.continuebtn);
            this.panel1.Controls.Add(this.modifybtn);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.deletebtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.confirmpanel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.fijotxt);
            this.panel1.Controls.Add(this.lastvisittxt);
            this.panel1.Controls.Add(this.creationdatetxt);
            this.panel1.Controls.Add(this.addresstxt);
            this.panel1.Controls.Add(this.emailtxt);
            this.panel1.Controls.Add(this.moviltxt);
            this.panel1.Controls.Add(this.ClientNametxt);
            this.panel1.Controls.Add(this.clientdgv);
            this.panel1.Controls.Add(this.clienttosearchbtn);
            this.panel1.Controls.Add(this.clienttosearchtxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 487);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(168)))), ((int)(((byte)(210)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(-11, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 63);
            this.panel2.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label9.Location = new System.Drawing.Point(38, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 32);
            this.label9.TabIndex = 22;
            this.label9.Text = "Clientes";
            // 
            // exitbtn
            // 
            this.exitbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.exitbtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("exitbtn.ButtonImage")));
            this.exitbtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.exitbtn.ButtonText = "Button";
            this.exitbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.exitbtn.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.exitbtn.CornerRadius = 5;
            this.exitbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.exitbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.exitbtn.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.exitbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.exitbtn.Location = new System.Drawing.Point(430, 371);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(56, 50);
            this.exitbtn.TabIndex = 38;
            this.exitbtn.TextColor = System.Drawing.Color.DodgerBlue;
            this.exitbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // continuebtn
            // 
            this.continuebtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.continuebtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("continuebtn.ButtonImage")));
            this.continuebtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.continuebtn.ButtonText = "Button";
            this.continuebtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.continuebtn.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.continuebtn.CornerRadius = 5;
            this.continuebtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.continuebtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.continuebtn.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.continuebtn.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.continuebtn.Location = new System.Drawing.Point(350, 371);
            this.continuebtn.Name = "continuebtn";
            this.continuebtn.Size = new System.Drawing.Size(56, 50);
            this.continuebtn.TabIndex = 38;
            this.continuebtn.TextColor = System.Drawing.Color.DodgerBlue;
            this.continuebtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.continuebtn.Click += new System.EventHandler(this.continuebtn_Click);
            // 
            // modifybtn
            // 
            this.modifybtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.modifybtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("modifybtn.ButtonImage")));
            this.modifybtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.modifybtn.ButtonText = "Button";
            this.modifybtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.modifybtn.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.modifybtn.CornerRadius = 5;
            this.modifybtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.modifybtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.modifybtn.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.modifybtn.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.modifybtn.Location = new System.Drawing.Point(269, 371);
            this.modifybtn.Name = "modifybtn";
            this.modifybtn.Size = new System.Drawing.Size(56, 50);
            this.modifybtn.TabIndex = 38;
            this.modifybtn.TextColor = System.Drawing.Color.DodgerBlue;
            this.modifybtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.modifybtn.Click += new System.EventHandler(this.modifybtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label10.Location = new System.Drawing.Point(445, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Salir";
            // 
            // deletebtn
            // 
            this.deletebtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.deletebtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("deletebtn.ButtonImage")));
            this.deletebtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.deletebtn.ButtonText = "Button";
            this.deletebtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.deletebtn.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.deletebtn.CornerRadius = 5;
            this.deletebtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.deletebtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.deletebtn.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.deletebtn.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.deletebtn.Location = new System.Drawing.Point(188, 371);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(56, 50);
            this.deletebtn.TabIndex = 39;
            this.deletebtn.TextColor = System.Drawing.Color.DodgerBlue;
            this.deletebtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label2.Location = new System.Drawing.Point(352, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Continuar ";
            // 
            // addbtn
            // 
            this.addbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.addbtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("addbtn.ButtonImage")));
            this.addbtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.addbtn.ButtonText = "Button";
            this.addbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.addbtn.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.addbtn.CornerRadius = 5;
            this.addbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.addbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.addbtn.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.addbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.addbtn.Location = new System.Drawing.Point(108, 371);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(56, 50);
            this.addbtn.TabIndex = 40;
            this.addbtn.TextColor = System.Drawing.Color.DodgerBlue;
            this.addbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label24.Location = new System.Drawing.Point(256, 435);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 13);
            this.label24.TabIndex = 35;
            this.label24.Text = "Modificar Cliente";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label23.Location = new System.Drawing.Point(181, 435);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 13);
            this.label23.TabIndex = 36;
            this.label23.Text = "Borrar Cliente";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label22.Location = new System.Drawing.Point(100, 435);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 13);
            this.label22.TabIndex = 37;
            this.label22.Text = "Añadir Cliente";
            // 
            // confirmpanel
            // 
            this.confirmpanel.Controls.Add(this.savebtn);
            this.confirmpanel.Controls.Add(this.discardbtn);
            this.confirmpanel.Location = new System.Drawing.Point(319, 13);
            this.confirmpanel.Name = "confirmpanel";
            this.confirmpanel.Size = new System.Drawing.Size(228, 49);
            this.confirmpanel.TabIndex = 34;
            this.confirmpanel.Visible = false;
            // 
            // savebtn
            // 
            this.savebtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.savebtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("savebtn.ButtonImage")));
            this.savebtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.savebtn.ButtonText = "Guardar Cambios";
            this.savebtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.savebtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.savebtn.CornerRadius = 5;
            this.savebtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.savebtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.savebtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.savebtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.savebtn.Location = new System.Drawing.Point(3, 8);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(111, 33);
            this.savebtn.TabIndex = 9;
            this.savebtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.savebtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // discardbtn
            // 
            this.discardbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.discardbtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("discardbtn.ButtonImage")));
            this.discardbtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.discardbtn.ButtonText = "Descartar";
            this.discardbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(101)))), ((int)(((byte)(104)))));
            this.discardbtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.discardbtn.CornerRadius = 5;
            this.discardbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.discardbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(75)))), ((int)(((byte)(78)))));
            this.discardbtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.discardbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.discardbtn.Location = new System.Drawing.Point(117, 8);
            this.discardbtn.Name = "discardbtn";
            this.discardbtn.Size = new System.Drawing.Size(111, 33);
            this.discardbtn.TabIndex = 9;
            this.discardbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.discardbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.discardbtn.Click += new System.EventHandler(this.discardbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label6.Location = new System.Drawing.Point(379, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Telf. Fijo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label8.Location = new System.Drawing.Point(216, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Ultima Visita";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label7.Location = new System.Drawing.Point(38, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Fecha  de Alta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label5.Location = new System.Drawing.Point(38, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label4.Location = new System.Drawing.Point(216, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label3.Location = new System.Drawing.Point(37, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Movil WhatsApp (9)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(37, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre y Apellidos";
            // 
            // fijotxt
            // 
            this.fijotxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.fijotxt.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fijotxt.Location = new System.Drawing.Point(382, 233);
            this.fijotxt.Name = "fijotxt";
            this.fijotxt.Size = new System.Drawing.Size(164, 27);
            this.fijotxt.TabIndex = 32;
            // 
            // lastvisittxt
            // 
            this.lastvisittxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lastvisittxt.Enabled = false;
            this.lastvisittxt.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastvisittxt.Location = new System.Drawing.Point(219, 298);
            this.lastvisittxt.Name = "lastvisittxt";
            this.lastvisittxt.ReadOnly = true;
            this.lastvisittxt.Size = new System.Drawing.Size(172, 27);
            this.lastvisittxt.TabIndex = 32;
            // 
            // creationdatetxt
            // 
            this.creationdatetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.creationdatetxt.Enabled = false;
            this.creationdatetxt.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationdatetxt.Location = new System.Drawing.Point(41, 298);
            this.creationdatetxt.Name = "creationdatetxt";
            this.creationdatetxt.ReadOnly = true;
            this.creationdatetxt.Size = new System.Drawing.Size(172, 27);
            this.creationdatetxt.TabIndex = 32;
            // 
            // addresstxt
            // 
            this.addresstxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.addresstxt.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstxt.Location = new System.Drawing.Point(41, 233);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(335, 27);
            this.addresstxt.TabIndex = 32;
            // 
            // emailtxt
            // 
            this.emailtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.emailtxt.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.Location = new System.Drawing.Point(219, 170);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(327, 27);
            this.emailtxt.TabIndex = 32;
            // 
            // moviltxt
            // 
            this.moviltxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.moviltxt.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moviltxt.Location = new System.Drawing.Point(40, 170);
            this.moviltxt.MaxLength = 9;
            this.moviltxt.Name = "moviltxt";
            this.moviltxt.Size = new System.Drawing.Size(173, 27);
            this.moviltxt.TabIndex = 32;
            // 
            // ClientNametxt
            // 
            this.ClientNametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientNametxt.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNametxt.Location = new System.Drawing.Point(40, 110);
            this.ClientNametxt.Name = "ClientNametxt";
            this.ClientNametxt.Size = new System.Drawing.Size(358, 27);
            this.ClientNametxt.TabIndex = 32;
            // 
            // clientdgv
            // 
            this.clientdgv.AllowUserToAddRows = false;
            this.clientdgv.AllowUserToDeleteRows = false;
            this.clientdgv.AllowUserToResizeColumns = false;
            this.clientdgv.AllowUserToResizeRows = false;
            this.clientdgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.clientdgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.clientdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientdgv.Location = new System.Drawing.Point(582, 59);
            this.clientdgv.MultiSelect = false;
            this.clientdgv.Name = "clientdgv";
            this.clientdgv.ReadOnly = true;
            this.clientdgv.RowHeadersVisible = false;
            this.clientdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientdgv.Size = new System.Drawing.Size(428, 408);
            this.clientdgv.TabIndex = 31;
            this.clientdgv.SelectionChanged += new System.EventHandler(this.clientdgv_SelectionChanged);
            // 
            // clienttosearchbtn
            // 
            this.clienttosearchbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(139)))), ((int)(((byte)(200)))));
            this.clienttosearchbtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("clienttosearchbtn.ButtonImage")));
            this.clienttosearchbtn.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.clienttosearchbtn.ButtonText = "Buscar";
            this.clienttosearchbtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.clienttosearchbtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.clienttosearchbtn.CornerRadius = 5;
            this.clienttosearchbtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienttosearchbtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.clienttosearchbtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(102)))), ((int)(((byte)(155)))));
            this.clienttosearchbtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.clienttosearchbtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.clienttosearchbtn.Location = new System.Drawing.Point(896, 20);
            this.clienttosearchbtn.Name = "clienttosearchbtn";
            this.clienttosearchbtn.Size = new System.Drawing.Size(114, 33);
            this.clienttosearchbtn.TabIndex = 30;
            this.clienttosearchbtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.clienttosearchbtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.clienttosearchbtn.Click += new System.EventHandler(this.clienttosearchbtn_Click);
            // 
            // clienttosearchtxt
            // 
            this.clienttosearchtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.clienttosearchtxt.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienttosearchtxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.clienttosearchtxt.Location = new System.Drawing.Point(582, 20);
            this.clienttosearchtxt.Name = "clienttosearchtxt";
            this.clienttosearchtxt.Size = new System.Drawing.Size(308, 33);
            this.clienttosearchtxt.TabIndex = 29;
            // 
            // ClientFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 487);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.confirmpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton clienttosearchbtn;
        private System.Windows.Forms.TextBox clienttosearchtxt;
        private System.Windows.Forms.DataGridView clientdgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClientNametxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fijotxt;
        private System.Windows.Forms.TextBox lastvisittxt;
        private System.Windows.Forms.TextBox creationdatetxt;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox moviltxt;
        private System.Windows.Forms.Panel confirmpanel;
        private XanderUI.XUIButton savebtn;
        private XanderUI.XUIButton discardbtn;
        private XanderUI.XUIButton modifybtn;
        private XanderUI.XUIButton deletebtn;
        private XanderUI.XUIButton addbtn;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private XanderUI.XUIButton continuebtn;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUIButton exitbtn;
        private System.Windows.Forms.Label label10;
    }
}