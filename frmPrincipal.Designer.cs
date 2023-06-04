namespace PROYECTO
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgOb = new System.Windows.Forms.PictureBox();
            this.btnOb = new System.Windows.Forms.Button();
            this.imgSP = new System.Windows.Forms.PictureBox();
            this.btnSP = new System.Windows.Forms.Button();
            this.imgPN = new System.Windows.Forms.PictureBox();
            this.btnPN = new System.Windows.Forms.Button();
            this.btnBP = new System.Windows.Forms.Button();
            this.lblRecomendacion = new System.Windows.Forms.Label();
            this.imgBP = new System.Windows.Forms.PictureBox();
            this.imgAtencion = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAtencion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 77);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(153, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "\" C A L C U L A   T U   I M C \"";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.imgOb);
            this.panel2.Controls.Add(this.btnOb);
            this.panel2.Controls.Add(this.imgSP);
            this.panel2.Controls.Add(this.btnSP);
            this.panel2.Controls.Add(this.imgPN);
            this.panel2.Controls.Add(this.btnPN);
            this.panel2.Controls.Add(this.btnBP);
            this.panel2.Controls.Add(this.lblRecomendacion);
            this.panel2.Controls.Add(this.imgBP);
            this.panel2.Controls.Add(this.imgAtencion);
            this.panel2.Location = new System.Drawing.Point(-2, 577);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 142);
            this.panel2.TabIndex = 2;
            // 
            // imgOb
            // 
            this.imgOb.Image = global::PROYECTO.Properties.Resources.OBESO1;
            this.imgOb.Location = new System.Drawing.Point(509, -12);
            this.imgOb.Name = "imgOb";
            this.imgOb.Size = new System.Drawing.Size(163, 188);
            this.imgOb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgOb.TabIndex = 107;
            this.imgOb.TabStop = false;
            this.imgOb.Visible = false;
            // 
            // btnOb
            // 
            this.btnOb.BackColor = System.Drawing.Color.Red;
            this.btnOb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOb.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOb.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOb.Location = new System.Drawing.Point(208, 57);
            this.btnOb.Name = "btnOb";
            this.btnOb.Size = new System.Drawing.Size(227, 49);
            this.btnOb.TabIndex = 106;
            this.btnOb.Text = "\"PLAN NUTRICIONAL\"";
            this.btnOb.UseVisualStyleBackColor = false;
            this.btnOb.Visible = false;
            this.btnOb.Click += new System.EventHandler(this.btnOb_Click);
            // 
            // imgSP
            // 
            this.imgSP.Image = global::PROYECTO.Properties.Resources.SOBREPESO;
            this.imgSP.Location = new System.Drawing.Point(493, -4);
            this.imgSP.Name = "imgSP";
            this.imgSP.Size = new System.Drawing.Size(192, 194);
            this.imgSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSP.TabIndex = 105;
            this.imgSP.TabStop = false;
            this.imgSP.Visible = false;
            // 
            // btnSP
            // 
            this.btnSP.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSP.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSP.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSP.Location = new System.Drawing.Point(208, 57);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(227, 49);
            this.btnSP.TabIndex = 104;
            this.btnSP.Text = "\"PLAN NUTRICIONAL\"";
            this.btnSP.UseVisualStyleBackColor = false;
            this.btnSP.Visible = false;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // imgPN
            // 
            this.imgPN.Image = global::PROYECTO.Properties.Resources.PESO_NORMAL;
            this.imgPN.Location = new System.Drawing.Point(494, -22);
            this.imgPN.Name = "imgPN";
            this.imgPN.Size = new System.Drawing.Size(217, 189);
            this.imgPN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPN.TabIndex = 103;
            this.imgPN.TabStop = false;
            this.imgPN.Visible = false;
            // 
            // btnPN
            // 
            this.btnPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPN.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPN.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPN.Location = new System.Drawing.Point(208, 57);
            this.btnPN.Name = "btnPN";
            this.btnPN.Size = new System.Drawing.Size(227, 49);
            this.btnPN.TabIndex = 102;
            this.btnPN.Text = "\"PLAN NUTRICIONAL\"";
            this.btnPN.UseVisualStyleBackColor = false;
            this.btnPN.Visible = false;
            this.btnPN.Click += new System.EventHandler(this.btnPN_Click);
            // 
            // btnBP
            // 
            this.btnBP.BackColor = System.Drawing.Color.Orange;
            this.btnBP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBP.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBP.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBP.Location = new System.Drawing.Point(208, 57);
            this.btnBP.Name = "btnBP";
            this.btnBP.Size = new System.Drawing.Size(227, 49);
            this.btnBP.TabIndex = 101;
            this.btnBP.Text = "\"PLAN NUTRICIONAL\"";
            this.btnBP.UseVisualStyleBackColor = false;
            this.btnBP.Visible = false;
            this.btnBP.Click += new System.EventHandler(this.btnBP_Click);
            // 
            // lblRecomendacion
            // 
            this.lblRecomendacion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRecomendacion.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecomendacion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRecomendacion.Location = new System.Drawing.Point(147, 14);
            this.lblRecomendacion.Name = "lblRecomendacion";
            this.lblRecomendacion.Size = new System.Drawing.Size(356, 32);
            this.lblRecomendacion.TabIndex = 23;
            this.lblRecomendacion.Text = "TE RECOMENDAMOS ESTE";
            this.lblRecomendacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRecomendacion.Visible = false;
            // 
            // imgBP
            // 
            this.imgBP.Image = global::PROYECTO.Properties.Resources.BAJO_PESO;
            this.imgBP.Location = new System.Drawing.Point(493, 0);
            this.imgBP.Name = "imgBP";
            this.imgBP.Size = new System.Drawing.Size(217, 179);
            this.imgBP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBP.TabIndex = 22;
            this.imgBP.TabStop = false;
            this.imgBP.Visible = false;
            // 
            // imgAtencion
            // 
            this.imgAtencion.Image = global::PROYECTO.Properties.Resources.ALERTA;
            this.imgAtencion.Location = new System.Drawing.Point(14, 9);
            this.imgAtencion.Name = "imgAtencion";
            this.imgAtencion.Size = new System.Drawing.Size(106, 112);
            this.imgAtencion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAtencion.TabIndex = 0;
            this.imgAtencion.TabStop = false;
            this.imgAtencion.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(30, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "\" D A T O S   P E R S O N A L E S \"";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(68, 119);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(267, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre Completo";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlias
            // 
            this.txtAlias.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlias.Location = new System.Drawing.Point(68, 151);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(267, 26);
            this.txtAlias.TabIndex = 2;
            this.txtAlias.Text = "Alias";
            this.txtAlias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(144, 183);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(114, 26);
            this.txtEdad.TabIndex = 3;
            this.txtEdad.Text = "Edad";
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de Nacimiento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(92, 284);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(56, 26);
            this.txtPeso.TabIndex = 4;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lbs.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(92, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Peso";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(228, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Altura";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(284, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "cm.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(228, 284);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(56, 26);
            this.txtAltura.TabIndex = 5;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Location = new System.Drawing.Point(124, 323);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(161, 49);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(315, 213);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(20, 26);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Orange;
            this.lblResultado.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Black;
            this.lblResultado.Location = new System.Drawing.Point(35, 477);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(389, 29);
            this.lblResultado.TabIndex = 16;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Visible = false;
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(96, 514);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(267, 33);
            this.txtResultado.TabIndex = 17;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResultado.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Green;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Location = new System.Drawing.Point(124, 378);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 29);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.Location = new System.Drawing.Point(210, 378);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 29);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblRes
            // 
            this.lblRes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRes.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRes.Location = new System.Drawing.Point(154, 440);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(150, 32);
            this.lblRes.TabIndex = 20;
            this.lblRes.Text = "RESULTADO";
            this.lblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRes.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO.Properties.Resources.FONDO;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 529);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 711);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROYECTO IMC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgOb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAtencion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.PictureBox imgAtencion;
        private System.Windows.Forms.PictureBox imgBP;
        private System.Windows.Forms.Label lblRecomendacion;
        private System.Windows.Forms.Button btnBP;
        private System.Windows.Forms.Button btnPN;
        private System.Windows.Forms.PictureBox imgPN;
        private System.Windows.Forms.Button btnSP;
        private System.Windows.Forms.PictureBox imgSP;
        private System.Windows.Forms.Button btnOb;
        private System.Windows.Forms.PictureBox imgOb;
    }
}

