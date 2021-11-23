
namespace CapaVistaMVentasCC
{
    partial class frmMantenimientoLinea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoLinea));
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPkid = new System.Windows.Forms.TextBox();
            this.cbxIdMarca = new System.Windows.Forms.ComboBox();
            this.rbnHabilitado = new System.Windows.Forms.RadioButton();
            this.rbnInhabilitado = new System.Windows.Forms.RadioButton();
            this.navegador1 = new DLL.nav.navegador();
            this.labelcostoinventario = new System.Windows.Forms.Label();
            this.labelstockinventario = new System.Windows.Forms.Label();
            this.labelInventario = new System.Windows.Forms.Label();
            this.dtgLinea = new System.Windows.Forms.DataGridView();
            this.labelestadoinventario = new System.Windows.Forms.Label();
            this.labeltipoinventario = new System.Windows.Forms.Label();
            this.labelidinventario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLinea)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstatus
            // 
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(316, 303);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(45, 26);
            this.txtEstatus.TabIndex = 120;
            this.txtEstatus.Tag = "Estatus";
            this.txtEstatus.Visible = false;
            this.txtEstatus.TextChanged += new System.EventHandler(this.txtEstatus_TextChanged);
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMarca.Location = new System.Drawing.Point(313, 238);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.Size = new System.Drawing.Size(32, 26);
            this.txtIdMarca.TabIndex = 119;
            this.txtIdMarca.Tag = "idMarca";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(150, 203);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(157, 26);
            this.txtDescripcion.TabIndex = 118;
            this.txtDescripcion.Tag = "descripcion";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(150, 171);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 26);
            this.txtNombre.TabIndex = 117;
            this.txtNombre.Tag = "nombre";
            // 
            // txtPkid
            // 
            this.txtPkid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkid.Location = new System.Drawing.Point(150, 134);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(157, 26);
            this.txtPkid.TabIndex = 116;
            this.txtPkid.Tag = "idLinea";
            // 
            // cbxIdMarca
            // 
            this.cbxIdMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdMarca.FormattingEnabled = true;
            this.cbxIdMarca.Location = new System.Drawing.Point(150, 238);
            this.cbxIdMarca.Name = "cbxIdMarca";
            this.cbxIdMarca.Size = new System.Drawing.Size(157, 28);
            this.cbxIdMarca.TabIndex = 115;
            this.cbxIdMarca.SelectedIndexChanged += new System.EventHandler(this.cbxTipoinventario_SelectedIndexChanged);
            // 
            // rbnHabilitado
            // 
            this.rbnHabilitado.AutoSize = true;
            this.rbnHabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbnHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnHabilitado.Location = new System.Drawing.Point(69, 305);
            this.rbnHabilitado.Name = "rbnHabilitado";
            this.rbnHabilitado.Size = new System.Drawing.Size(98, 24);
            this.rbnHabilitado.TabIndex = 109;
            this.rbnHabilitado.TabStop = true;
            this.rbnHabilitado.Text = "Habilitado";
            this.rbnHabilitado.UseVisualStyleBackColor = false;
            this.rbnHabilitado.CheckedChanged += new System.EventHandler(this.rbnActivo_CheckedChanged);
            // 
            // rbnInhabilitado
            // 
            this.rbnInhabilitado.AutoSize = true;
            this.rbnInhabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbnInhabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnInhabilitado.Location = new System.Drawing.Point(173, 305);
            this.rbnInhabilitado.Name = "rbnInhabilitado";
            this.rbnInhabilitado.Size = new System.Drawing.Size(109, 24);
            this.rbnInhabilitado.TabIndex = 110;
            this.rbnInhabilitado.TabStop = true;
            this.rbnInhabilitado.Text = "Inhabilitado";
            this.rbnInhabilitado.UseVisualStyleBackColor = false;
            this.rbnInhabilitado.CheckedChanged += new System.EventHandler(this.rbnInactivo_CheckedChanged);
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(-1, 0);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 121;
            // 
            // labelcostoinventario
            // 
            this.labelcostoinventario.AutoSize = true;
            this.labelcostoinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelcostoinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcostoinventario.Location = new System.Drawing.Point(31, 241);
            this.labelcostoinventario.Name = "labelcostoinventario";
            this.labelcostoinventario.Size = new System.Drawing.Size(74, 20);
            this.labelcostoinventario.TabIndex = 114;
            this.labelcostoinventario.Text = "ID Marca";
            // 
            // labelstockinventario
            // 
            this.labelstockinventario.AutoSize = true;
            this.labelstockinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelstockinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstockinventario.Location = new System.Drawing.Point(31, 209);
            this.labelstockinventario.Name = "labelstockinventario";
            this.labelstockinventario.Size = new System.Drawing.Size(96, 20);
            this.labelstockinventario.TabIndex = 113;
            this.labelstockinventario.Text = "Descripción:";
            // 
            // labelInventario
            // 
            this.labelInventario.AutoSize = true;
            this.labelInventario.BackColor = System.Drawing.Color.Transparent;
            this.labelInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventario.Location = new System.Drawing.Point(361, 104);
            this.labelInventario.Name = "labelInventario";
            this.labelInventario.Size = new System.Drawing.Size(146, 20);
            this.labelInventario.TabIndex = 112;
            this.labelInventario.Text = "Lineas Registradas";
            // 
            // dtgLinea
            // 
            this.dtgLinea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLinea.Location = new System.Drawing.Point(364, 125);
            this.dtgLinea.Name = "dtgLinea";
            this.dtgLinea.Size = new System.Drawing.Size(790, 295);
            this.dtgLinea.TabIndex = 111;
            // 
            // labelestadoinventario
            // 
            this.labelestadoinventario.AutoSize = true;
            this.labelestadoinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelestadoinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelestadoinventario.Location = new System.Drawing.Point(36, 271);
            this.labelestadoinventario.Name = "labelestadoinventario";
            this.labelestadoinventario.Size = new System.Drawing.Size(64, 20);
            this.labelestadoinventario.TabIndex = 108;
            this.labelestadoinventario.Text = "Estado:";
            // 
            // labeltipoinventario
            // 
            this.labeltipoinventario.AutoSize = true;
            this.labeltipoinventario.BackColor = System.Drawing.Color.Transparent;
            this.labeltipoinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltipoinventario.Location = new System.Drawing.Point(31, 174);
            this.labeltipoinventario.Name = "labeltipoinventario";
            this.labeltipoinventario.Size = new System.Drawing.Size(69, 20);
            this.labeltipoinventario.TabIndex = 107;
            this.labeltipoinventario.Text = "Nombre:";
            // 
            // labelidinventario
            // 
            this.labelidinventario.AutoSize = true;
            this.labelidinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelidinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidinventario.Location = new System.Drawing.Point(31, 140);
            this.labelidinventario.Name = "labelidinventario";
            this.labelidinventario.Size = new System.Drawing.Size(30, 20);
            this.labelidinventario.TabIndex = 106;
            this.labelidinventario.Text = "ID:";
            // 
            // frmMantenimientoLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaMVentasCC.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.ClientSize = new System.Drawing.Size(1188, 450);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.txtIdMarca);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.cbxIdMarca);
            this.Controls.Add(this.rbnHabilitado);
            this.Controls.Add(this.rbnInhabilitado);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.labelcostoinventario);
            this.Controls.Add(this.labelstockinventario);
            this.Controls.Add(this.labelInventario);
            this.Controls.Add(this.dtgLinea);
            this.Controls.Add(this.labelestadoinventario);
            this.Controls.Add(this.labeltipoinventario);
            this.Controls.Add(this.labelidinventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoLinea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimientoLinea";
            ((System.ComponentModel.ISupportInitialize)(this.dtgLinea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.TextBox txtIdMarca;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPkid;
        private System.Windows.Forms.ComboBox cbxIdMarca;
        private System.Windows.Forms.RadioButton rbnHabilitado;
        private System.Windows.Forms.RadioButton rbnInhabilitado;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.Label labelcostoinventario;
        private System.Windows.Forms.Label labelstockinventario;
        private System.Windows.Forms.Label labelInventario;
        private System.Windows.Forms.DataGridView dtgLinea;
        private System.Windows.Forms.Label labelestadoinventario;
        private System.Windows.Forms.Label labeltipoinventario;
        private System.Windows.Forms.Label labelidinventario;
    }
}