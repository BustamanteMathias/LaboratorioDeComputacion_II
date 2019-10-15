namespace FormSistemaSolar
{
  partial class formSistemaSolar
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
            this.NombrePlaneta = new System.Windows.Forms.Label();
            this.txtOrbitaPlanera = new System.Windows.Forms.Label();
            this.txtNombrePlaneta = new System.Windows.Forms.TextBox();
            this.txtOrbitaPlaneta = new System.Windows.Forms.TextBox();
            this.txtPlaneta = new System.Windows.Forms.Label();
            this.NombreSatelite = new System.Windows.Forms.Label();
            this.txtNombreSatelite = new System.Windows.Forms.TextBox();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numSatelite = new System.Windows.Forms.NumericUpDown();
            this.numOrbitaSatelite = new System.Windows.Forms.NumericUpDown();
            this.numRotacionSatelite = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarPlaneta = new System.Windows.Forms.Button();
            this.btnAgregarSatelite = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnMoverAstros = new System.Windows.Forms.Button();
            this.numRotacion = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSatelite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatelite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacion)).BeginInit();
            this.SuspendLayout();
            // 
            // NombrePlaneta
            // 
            this.NombrePlaneta.AutoSize = true;
            this.NombrePlaneta.Location = new System.Drawing.Point(12, 15);
            this.NombrePlaneta.Name = "NombrePlaneta";
            this.NombrePlaneta.Size = new System.Drawing.Size(100, 13);
            this.NombrePlaneta.TabIndex = 0;
            this.NombrePlaneta.Text = "Nombre del Planeta";
            // 
            // txtOrbitaPlanera
            // 
            this.txtOrbitaPlanera.AutoSize = true;
            this.txtOrbitaPlanera.Location = new System.Drawing.Point(12, 42);
            this.txtOrbitaPlanera.Name = "txtOrbitaPlanera";
            this.txtOrbitaPlanera.Size = new System.Drawing.Size(137, 13);
            this.txtOrbitaPlanera.TabIndex = 1;
            this.txtOrbitaPlanera.Text = "Tiempo en completar Orbita";
            // 
            // txtNombrePlaneta
            // 
            this.txtNombrePlaneta.Location = new System.Drawing.Point(165, 12);
            this.txtNombrePlaneta.Name = "txtNombrePlaneta";
            this.txtNombrePlaneta.Size = new System.Drawing.Size(193, 20);
            this.txtNombrePlaneta.TabIndex = 2;
            // 
            // txtOrbitaPlaneta
            // 
            this.txtOrbitaPlaneta.Location = new System.Drawing.Point(165, 38);
            this.txtOrbitaPlaneta.Name = "txtOrbitaPlaneta";
            this.txtOrbitaPlaneta.Size = new System.Drawing.Size(193, 20);
            this.txtOrbitaPlaneta.TabIndex = 3;
            // 
            // txtPlaneta
            // 
            this.txtPlaneta.AutoSize = true;
            this.txtPlaneta.Location = new System.Drawing.Point(383, 15);
            this.txtPlaneta.Name = "txtPlaneta";
            this.txtPlaneta.Size = new System.Drawing.Size(43, 13);
            this.txtPlaneta.TabIndex = 4;
            this.txtPlaneta.Text = "Planeta";
            // 
            // NombreSatelite
            // 
            this.NombreSatelite.AutoSize = true;
            this.NombreSatelite.Location = new System.Drawing.Point(383, 42);
            this.NombreSatelite.Name = "NombreSatelite";
            this.NombreSatelite.Size = new System.Drawing.Size(99, 13);
            this.NombreSatelite.TabIndex = 5;
            this.NombreSatelite.Text = "Nombre del Satelite";
            // 
            // txtNombreSatelite
            // 
            this.txtNombreSatelite.Location = new System.Drawing.Point(547, 39);
            this.txtNombreSatelite.Name = "txtNombreSatelite";
            this.txtNombreSatelite.Size = new System.Drawing.Size(193, 20);
            this.txtNombreSatelite.TabIndex = 6;
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(547, 12);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(193, 21);
            this.cmbPlanetas.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tiempo en completar Rotacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cantidad de Lunas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo de Planeta";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(165, 119);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(193, 21);
            this.cmbTipo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tiempo en completar la Orbita";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tiempo en completar la Rotacion";
            // 
            // numSatelite
            // 
            this.numSatelite.Location = new System.Drawing.Point(165, 93);
            this.numSatelite.Name = "numSatelite";
            this.numSatelite.Size = new System.Drawing.Size(193, 20);
            this.numSatelite.TabIndex = 15;
            // 
            // numOrbitaSatelite
            // 
            this.numOrbitaSatelite.Location = new System.Drawing.Point(547, 66);
            this.numOrbitaSatelite.Name = "numOrbitaSatelite";
            this.numOrbitaSatelite.Size = new System.Drawing.Size(193, 20);
            this.numOrbitaSatelite.TabIndex = 16;
            // 
            // numRotacionSatelite
            // 
            this.numRotacionSatelite.Location = new System.Drawing.Point(547, 93);
            this.numRotacionSatelite.Name = "numRotacionSatelite";
            this.numRotacionSatelite.Size = new System.Drawing.Size(193, 20);
            this.numRotacionSatelite.TabIndex = 17;
            // 
            // btnAgregarPlaneta
            // 
            this.btnAgregarPlaneta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPlaneta.Location = new System.Drawing.Point(15, 146);
            this.btnAgregarPlaneta.Name = "btnAgregarPlaneta";
            this.btnAgregarPlaneta.Size = new System.Drawing.Size(343, 38);
            this.btnAgregarPlaneta.TabIndex = 18;
            this.btnAgregarPlaneta.Text = "AGREGAR PLANETA";
            this.btnAgregarPlaneta.UseVisualStyleBackColor = true;
            this.btnAgregarPlaneta.Click += new System.EventHandler(this.btnAgregarPlaneta_Click);
            // 
            // btnAgregarSatelite
            // 
            this.btnAgregarSatelite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSatelite.Location = new System.Drawing.Point(397, 146);
            this.btnAgregarSatelite.Name = "btnAgregarSatelite";
            this.btnAgregarSatelite.Size = new System.Drawing.Size(343, 38);
            this.btnAgregarSatelite.TabIndex = 19;
            this.btnAgregarSatelite.Text = "AGREGAR SATELITE";
            this.btnAgregarSatelite.UseVisualStyleBackColor = true;
            this.btnAgregarSatelite.Click += new System.EventHandler(this.btnAgregarSatelite_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(15, 194);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(725, 38);
            this.btnInfo.TabIndex = 20;
            this.btnInfo.Text = "MOSTRAR INFORMACION";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnMoverAstros
            // 
            this.btnMoverAstros.Location = new System.Drawing.Point(15, 238);
            this.btnMoverAstros.Name = "btnMoverAstros";
            this.btnMoverAstros.Size = new System.Drawing.Size(725, 38);
            this.btnMoverAstros.TabIndex = 21;
            this.btnMoverAstros.Text = "MOVER ASTROS";
            this.btnMoverAstros.UseVisualStyleBackColor = true;
            this.btnMoverAstros.Click += new System.EventHandler(this.btnMoverAstros_Click);
            // 
            // numRotacion
            // 
            this.numRotacion.Location = new System.Drawing.Point(165, 67);
            this.numRotacion.Name = "numRotacion";
            this.numRotacion.Size = new System.Drawing.Size(193, 20);
            this.numRotacion.TabIndex = 23;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(746, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(262, 264);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // formSistemaSolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1013, 281);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.numRotacion);
            this.Controls.Add(this.btnMoverAstros);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnAgregarSatelite);
            this.Controls.Add(this.btnAgregarPlaneta);
            this.Controls.Add(this.numRotacionSatelite);
            this.Controls.Add(this.numOrbitaSatelite);
            this.Controls.Add(this.numSatelite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPlanetas);
            this.Controls.Add(this.txtNombreSatelite);
            this.Controls.Add(this.NombreSatelite);
            this.Controls.Add(this.txtPlaneta);
            this.Controls.Add(this.txtOrbitaPlaneta);
            this.Controls.Add(this.txtNombrePlaneta);
            this.Controls.Add(this.txtOrbitaPlanera);
            this.Controls.Add(this.NombrePlaneta);
            this.Name = "formSistemaSolar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formSistemaSolar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSatelite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatelite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label NombrePlaneta;
    private System.Windows.Forms.Label txtOrbitaPlanera;
    private System.Windows.Forms.TextBox txtNombrePlaneta;
    private System.Windows.Forms.TextBox txtOrbitaPlaneta;
    private System.Windows.Forms.Label txtPlaneta;
    private System.Windows.Forms.Label NombreSatelite;
    private System.Windows.Forms.TextBox txtNombreSatelite;
    private System.Windows.Forms.ComboBox cmbPlanetas;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cmbTipo;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.NumericUpDown numSatelite;
    private System.Windows.Forms.NumericUpDown numOrbitaSatelite;
    private System.Windows.Forms.NumericUpDown numRotacionSatelite;
    private System.Windows.Forms.Button btnAgregarPlaneta;
    private System.Windows.Forms.Button btnAgregarSatelite;
    private System.Windows.Forms.Button btnInfo;
    private System.Windows.Forms.Button btnMoverAstros;
    private System.Windows.Forms.NumericUpDown numRotacion;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

