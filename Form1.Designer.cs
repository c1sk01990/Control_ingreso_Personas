namespace control_de_empleados
{
    partial class Form1
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
            this.BtnIngresar = new MaterialSkin.Controls.MaterialButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.CboTipo_Persona = new MaterialSkin.Controls.MaterialComboBox();
            this.Lblmostrarentrad = new System.Windows.Forms.Label();
            this.LblMostrarSali = new System.Windows.Forms.Label();
            this.BtnRegistroInvi = new MaterialSkin.Controls.MaterialButton();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new MaterialSkin.Controls.MaterialLabel();
            this.btnHorasTrabajadas = new MaterialSkin.Controls.MaterialButton();
            this.lblhoras = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnnumeroemple = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.btncalculo = new MaterialSkin.Controls.MaterialButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.horas = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnIngresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnIngresar.Depth = 0;
            this.BtnIngresar.HighEmphasis = true;
            this.BtnIngresar.Icon = null;
            this.BtnIngresar.Location = new System.Drawing.Point(73, 97);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnIngresar.Size = new System.Drawing.Size(83, 36);
            this.BtnIngresar.TabIndex = 0;
            this.BtnIngresar.Text = "Ingreso";
            this.BtnIngresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnIngresar.UseAccentColor = false;
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnSalir.Depth = 0;
            this.BtnSalir.HighEmphasis = true;
            this.BtnSalir.Icon = null;
            this.BtnSalir.Location = new System.Drawing.Point(1092, 97);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnSalir.Size = new System.Drawing.Size(71, 36);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salida";
            this.BtnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnSalir.UseAccentColor = false;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(527, 287);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(601, 284);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(136, 22);
            this.txtCedula.TabIndex = 5;
            // 
            // CboTipo_Persona
            // 
            this.CboTipo_Persona.AutoResize = false;
            this.CboTipo_Persona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CboTipo_Persona.Depth = 0;
            this.CboTipo_Persona.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CboTipo_Persona.DropDownHeight = 174;
            this.CboTipo_Persona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipo_Persona.DropDownWidth = 121;
            this.CboTipo_Persona.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CboTipo_Persona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CboTipo_Persona.FormattingEnabled = true;
            this.CboTipo_Persona.IntegralHeight = false;
            this.CboTipo_Persona.ItemHeight = 43;
            this.CboTipo_Persona.Items.AddRange(new object[] {
            "EMPLEADOS",
            "INVITADOS",
            "PROVEEDORES"});
            this.CboTipo_Persona.Location = new System.Drawing.Point(611, 391);
            this.CboTipo_Persona.MaxDropDownItems = 4;
            this.CboTipo_Persona.MouseState = MaterialSkin.MouseState.OUT;
            this.CboTipo_Persona.Name = "CboTipo_Persona";
            this.CboTipo_Persona.Size = new System.Drawing.Size(218, 49);
            this.CboTipo_Persona.StartIndex = 0;
            this.CboTipo_Persona.TabIndex = 6;
            this.CboTipo_Persona.SelectedIndexChanged += new System.EventHandler(this.CboTipo_Persona_SelectedIndexChanged);
            // 
            // Lblmostrarentrad
            // 
            this.Lblmostrarentrad.AutoSize = true;
            this.Lblmostrarentrad.Location = new System.Drawing.Point(6, 200);
            this.Lblmostrarentrad.Name = "Lblmostrarentrad";
            this.Lblmostrarentrad.Size = new System.Drawing.Size(0, 16);
            this.Lblmostrarentrad.TabIndex = 8;
            // 
            // LblMostrarSali
            // 
            this.LblMostrarSali.AutoSize = true;
            this.LblMostrarSali.Location = new System.Drawing.Point(966, 246);
            this.LblMostrarSali.Name = "LblMostrarSali";
            this.LblMostrarSali.Size = new System.Drawing.Size(0, 16);
            this.LblMostrarSali.TabIndex = 9;
            // 
            // BtnRegistroInvi
            // 
            this.BtnRegistroInvi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnRegistroInvi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnRegistroInvi.Depth = 0;
            this.BtnRegistroInvi.HighEmphasis = true;
            this.BtnRegistroInvi.Icon = null;
            this.BtnRegistroInvi.Location = new System.Drawing.Point(481, 570);
            this.BtnRegistroInvi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnRegistroInvi.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnRegistroInvi.Name = "BtnRegistroInvi";
            this.BtnRegistroInvi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnRegistroInvi.Size = new System.Drawing.Size(335, 36);
            this.BtnRegistroInvi.TabIndex = 10;
            this.BtnRegistroInvi.Text = "REGISTRARSE COMO INVITADO O PROVEEDOR";
            this.BtnRegistroInvi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnRegistroInvi.UseAccentColor = false;
            this.BtnRegistroInvi.UseVisualStyleBackColor = true;
            this.BtnRegistroInvi.Click += new System.EventHandler(this.BtnRegistroInvi_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(601, 331);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(136, 22);
            this.txtnombre.TabIndex = 11;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Depth = 0;
            this.lblnombre.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblnombre.Location = new System.Drawing.Point(527, 334);
            this.lblnombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(57, 19);
            this.lblnombre.TabIndex = 12;
            this.lblnombre.Text = "Nombre";
            // 
            // btnHorasTrabajadas
            // 
            this.btnHorasTrabajadas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHorasTrabajadas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnHorasTrabajadas.Depth = 0;
            this.btnHorasTrabajadas.HighEmphasis = true;
            this.btnHorasTrabajadas.Icon = null;
            this.btnHorasTrabajadas.Location = new System.Drawing.Point(20, 385);
            this.btnHorasTrabajadas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnHorasTrabajadas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnHorasTrabajadas.Name = "btnHorasTrabajadas";
            this.btnHorasTrabajadas.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnHorasTrabajadas.Size = new System.Drawing.Size(243, 36);
            this.btnHorasTrabajadas.TabIndex = 13;
            this.btnHorasTrabajadas.Text = "Calcular Horas Trabajadas";
            this.btnHorasTrabajadas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnHorasTrabajadas.UseAccentColor = false;
            this.btnHorasTrabajadas.UseVisualStyleBackColor = true;
            this.btnHorasTrabajadas.Click += new System.EventHandler(this.btnHorasTrabajadas_Click);
            // 
            // lblhoras
            // 
            this.lblhoras.AutoSize = true;
            this.lblhoras.Depth = 0;
            this.lblhoras.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblhoras.Location = new System.Drawing.Point(608, 647);
            this.lblhoras.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblhoras.Name = "lblhoras";
            this.lblhoras.Size = new System.Drawing.Size(1, 0);
            this.lblhoras.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::control_de_empleados.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(573, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnnumeroemple
            // 
            this.btnnumeroemple.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnnumeroemple.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnnumeroemple.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnnumeroemple.Depth = 0;
            this.btnnumeroemple.HighEmphasis = true;
            this.btnnumeroemple.Icon = null;
            this.btnnumeroemple.Location = new System.Drawing.Point(20, 239);
            this.btnnumeroemple.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnnumeroemple.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnnumeroemple.Name = "btnnumeroemple";
            this.btnnumeroemple.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnnumeroemple.Size = new System.Drawing.Size(156, 36);
            this.btnnumeroemple.TabIndex = 15;
            this.btnnumeroemple.Text = "Total Empleados";
            this.btnnumeroemple.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnnumeroemple.UseAccentColor = false;
            this.btnnumeroemple.UseVisualStyleBackColor = false;
            this.btnnumeroemple.Click += new System.EventHandler(this.btnnumeroPers_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(20, 287);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(146, 36);
            this.materialButton1.TabIndex = 16;
            this.materialButton1.Text = "Total Invitados";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(20, 334);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(172, 36);
            this.materialButton2.TabIndex = 17;
            this.materialButton2.Text = "Total Proveedores";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // btncalculo
            // 
            this.btncalculo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncalculo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btncalculo.Depth = 0;
            this.btncalculo.HighEmphasis = true;
            this.btncalculo.Icon = null;
            this.btncalculo.Location = new System.Drawing.Point(20, 433);
            this.btncalculo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btncalculo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncalculo.Name = "btncalculo";
            this.btncalculo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btncalculo.Size = new System.Drawing.Size(316, 36);
            this.btncalculo.TabIndex = 18;
            this.btncalculo.Text = "Calcular Tiempo Total en la Empresa";
            this.btncalculo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btncalculo.UseAccentColor = false;
            this.btncalculo.UseVisualStyleBackColor = true;
            this.btncalculo.Click += new System.EventHandler(this.btncalculo_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(530, 80);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 19;
            // 
            // horas
            // 
            this.horas.AutoSize = true;
            this.horas.Depth = 0;
            this.horas.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.horas.Location = new System.Drawing.Point(743, 80);
            this.horas.MouseState = MaterialSkin.MouseState.HOVER;
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(1, 0);
            this.horas.TabIndex = 20;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(478, 402);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(83, 19);
            this.materialLabel2.TabIndex = 21;
            this.materialLabel2.Text = "Seleccionar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 735);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.horas);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btncalculo);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.btnnumeroemple);
            this.Controls.Add(this.lblhoras);
            this.Controls.Add(this.btnHorasTrabajadas);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.BtnRegistroInvi);
            this.Controls.Add(this.LblMostrarSali);
            this.Controls.Add(this.Lblmostrarentrad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CboTipo_Persona);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnIngresar);
            this.Name = "Form1";
            this.Text = "Sistema de Control de Empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton BtnIngresar;
        private MaterialSkin.Controls.MaterialButton BtnSalir;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox txtCedula;
        private MaterialSkin.Controls.MaterialComboBox CboTipo_Persona;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lblmostrarentrad;
        private System.Windows.Forms.Label LblMostrarSali;
        private MaterialSkin.Controls.MaterialButton BtnRegistroInvi;
        private System.Windows.Forms.TextBox txtnombre;
        private MaterialSkin.Controls.MaterialLabel lblnombre;
        private MaterialSkin.Controls.MaterialButton btnHorasTrabajadas;
        private MaterialSkin.Controls.MaterialLabel lblhoras;
        private MaterialSkin.Controls.MaterialButton btnnumeroemple;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton btncalculo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private MaterialSkin.Controls.MaterialLabel horas;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}

