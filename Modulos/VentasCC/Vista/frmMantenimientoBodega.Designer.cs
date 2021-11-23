
namespace CapaVistaMVentasCC
{
    partial class frmMantenimientoBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoBodega));
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFktipobodega = new System.Windows.Forms.TextBox();
            this.txtPkid = new System.Windows.Forms.TextBox();
            this.cbxTipoBodega = new System.Windows.Forms.ComboBox();
            this.rbnHabilitado = new System.Windows.Forms.RadioButton();
            this.rbnInhabilitado = new System.Windows.Forms.RadioButton();
            this.navegador1 = new DLL.nav.navegador();
            this.labelcostoinventario = new System.Windows.Forms.Label();
            this.labelstockinventario = new System.Windows.Forms.Label();
            this.labelInventario = new System.Windows.Forms.Label();
            this.dtgBodega = new System.Windows.Forms.DataGridView();
            this.labelestadoinventario = new System.Windows.Forms.Label();
            this.labeltipoinventario = new System.Windows.Forms.Label();
            this.labelidinventario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBodega)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstatus
            // 
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(319, 301);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(45, 26);
            this.txtEstatus.TabIndex = 104;
            this.txtEstatus.Tag = "Estatus";
            this.txtEstatus.Visible = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(151, 236);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(157, 26);
            this.txtDireccion.TabIndex = 101;
            this.txtDireccion.Tag = "direccion";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(151, 201);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 26);
            this.txtNombre.TabIndex = 100;
            this.txtNombre.Tag = "nombre";
            // 
            // txtFktipobodega
            // 
            this.txtFktipobodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFktipobodega.Location = new System.Drawing.Point(314, 166);
            this.txtFktipobodega.Name = "txtFktipobodega";
            this.txtFktipobodega.Size = new System.Drawing.Size(45, 26);
            this.txtFktipobodega.TabIndex = 99;
            this.txtFktipobodega.Tag = "fkidTipobodega";
            this.txtFktipobodega.Visible = false;
            // 
            // txtPkid
            // 
            this.txtPkid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkid.Location = new System.Drawing.Point(151, 132);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(157, 26);
            this.txtPkid.TabIndex = 98;
            this.txtPkid.Tag = "Pkid";
            // 
            // cbxTipoBodega
            // 
            this.cbxTipoBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoBodega.FormattingEnabled = true;
            this.cbxTipoBodega.Location = new System.Drawing.Point(151, 164);
            this.cbxTipoBodega.Name = "cbxTipoBodega";
            this.cbxTipoBodega.Size = new System.Drawing.Size(157, 28);
            this.cbxTipoBodega.TabIndex = 97;
            this.cbxTipoBodega.SelectedIndexChanged += new System.EventHandler(this.cbxTipoinventario_SelectedIndexChanged);
            // 
            // rbnHabilitado
            // 
            this.rbnHabilitado.AutoSize = true;
            this.rbnHabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbnHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnHabilitado.Location = new System.Drawing.Point(70, 303);
            this.rbnHabilitado.Name = "rbnHabilitado";
            this.rbnHabilitado.Size = new System.Drawing.Size(98, 24);
            this.rbnHabilitado.TabIndex = 90;
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
            this.rbnInhabilitado.Location = new System.Drawing.Point(174, 303);
            this.rbnInhabilitado.Name = "rbnInhabilitado";
            this.rbnInhabilitado.Size = new System.Drawing.Size(109, 24);
            this.rbnInhabilitado.TabIndex = 91;
            this.rbnInhabilitado.TabStop = true;
            this.rbnInhabilitado.Text = "Inhabilitado";
            this.rbnInhabilitado.UseVisualStyleBackColor = false;
            this.rbnInhabilitado.CheckedChanged += new System.EventHandler(this.rbnInactivo_CheckedChanged);
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, -2);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 105;
            // 
            // labelcostoinventario
            // 
            this.labelcostoinventario.AutoSize = true;
            this.labelcostoinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelcostoinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcostoinventario.Location = new System.Drawing.Point(32, 239);
            this.labelcostoinventario.Name = "labelcostoinventario";
            this.labelcostoinventario.Size = new System.Drawing.Size(79, 20);
            this.labelcostoinventario.TabIndex = 95;
            this.labelcostoinventario.Text = "Dirección:";
            // 
            // labelstockinventario
            // 
            this.labelstockinventario.AutoSize = true;
            this.labelstockinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelstockinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstockinventario.Location = new System.Drawing.Point(32, 207);
            this.labelstockinventario.Name = "labelstockinventario";
            this.labelstockinventario.Size = new System.Drawing.Size(69, 20);
            this.labelstockinventario.TabIndex = 94;
            this.labelstockinventario.Text = "Nombre:";
            // 
            // labelInventario
            // 
            this.labelInventario.AutoSize = true;
            this.labelInventario.BackColor = System.Drawing.Color.Transparent;
            this.labelInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventario.Location = new System.Drawing.Point(362, 102);
            this.labelInventario.Name = "labelInventario";
            this.labelInventario.Size = new System.Drawing.Size(163, 20);
            this.labelInventario.TabIndex = 93;
            this.labelInventario.Text = "Bodegas Registradas";
            // 
            // dtgBodega
            // 
            this.dtgBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBodega.Location = new System.Drawing.Point(365, 123);
            this.dtgBodega.Name = "dtgBodega";
            this.dtgBodega.Size = new System.Drawing.Size(790, 295);
            this.dtgBodega.TabIndex = 92;
            // 
            // labelestadoinventario
            // 
            this.labelestadoinventario.AutoSize = true;
            this.labelestadoinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelestadoinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelestadoinventario.Location = new System.Drawing.Point(37, 269);
            this.labelestadoinventario.Name = "labelestadoinventario";
            this.labelestadoinventario.Size = new System.Drawing.Size(64, 20);
            this.labelestadoinventario.TabIndex = 89;
            this.labelestadoinventario.Text = "Estado:";
            // 
            // labeltipoinventario
            // 
            this.labeltipoinventario.AutoSize = true;
            this.labeltipoinventario.BackColor = System.Drawing.Color.Transparent;
            this.labeltipoinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltipoinventario.Location = new System.Drawing.Point(32, 172);
            this.labeltipoinventario.Name = "labeltipoinventario";
            this.labeltipoinventario.Size = new System.Drawing.Size(103, 20);
            this.labeltipoinventario.TabIndex = 88;
            this.labeltipoinventario.Text = "Tipo Bodega:";
            // 
            // labelidinventario
            // 
            this.labelidinventario.AutoSize = true;
            this.labelidinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelidinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidinventario.Location = new System.Drawing.Point(32, 138);
            this.labelidinventario.Name = "labelidinventario";
            this.labelidinventario.Size = new System.Drawing.Size(30, 20);
            this.labelidinventario.TabIndex = 86;
            this.labelidinventario.Text = "ID:";
            // 
            // frmMantenimientoBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaMVentasCC.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.ClientSize = new System.Drawing.Size(1188, 450);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtFktipobodega);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.cbxTipoBodega);
            this.Controls.Add(this.rbnHabilitado);
            this.Controls.Add(this.rbnInhabilitado);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.labelcostoinventario);
            this.Controls.Add(this.labelstockinventario);
            this.Controls.Add(this.labelInventario);
            this.Controls.Add(this.dtgBodega);
            this.Controls.Add(this.labelestadoinventario);
            this.Controls.Add(this.labeltipoinventario);
            this.Controls.Add(this.labelidinventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoBodega";
            ((System.ComponentModel.ISupportInitialize)(this.dtgBodega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFktipobodega;
        private System.Windows.Forms.TextBox txtPkid;
        private System.Windows.Forms.ComboBox cbxTipoBodega;
        private System.Windows.Forms.RadioButton rbnHabilitado;
        private System.Windows.Forms.RadioButton rbnInhabilitado;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.Label labelcostoinventario;
        private System.Windows.Forms.Label labelstockinventario;
        private System.Windows.Forms.Label labelInventario;
        private System.Windows.Forms.DataGridView dtgBodega;
        private System.Windows.Forms.Label labelestadoinventario;
        private System.Windows.Forms.Label labeltipoinventario;
        private System.Windows.Forms.Label labelidinventario;
    }
}