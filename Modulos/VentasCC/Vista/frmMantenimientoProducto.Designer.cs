
namespace CapaVistaMVentasCC
{
    partial class frmMantenimientoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoProducto));
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.txtStockMaximo = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.txtPkid = new System.Windows.Forms.TextBox();
            this.rbnActivo = new System.Windows.Forms.RadioButton();
            this.rbnInactivo = new System.Windows.Forms.RadioButton();
            this.navegador1 = new DLL.nav.navegador();
            this.labelcorreocliente = new System.Windows.Forms.Label();
            this.labeldireccioncliente = new System.Windows.Forms.Label();
            this.labeltelefonocliente = new System.Windows.Forms.Label();
            this.labelnitcliente = new System.Windows.Forms.Label();
            this.labelClientes = new System.Windows.Forms.Label();
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.labelestadocliente = new System.Windows.Forms.Label();
            this.labelapellidocliente = new System.Windows.Forms.Label();
            this.labelnombrecliente = new System.Windows.Forms.Label();
            this.labelidcliente = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxInventario = new System.Windows.Forms.ComboBox();
            this.cbxLinea = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstatus
            // 
            this.txtEstatus.Enabled = false;
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(293, 522);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(52, 26);
            this.txtEstatus.TabIndex = 69;
            this.txtEstatus.Tag = "Estatus";
            this.txtEstatus.Visible = false;
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockMinimo.Location = new System.Drawing.Point(112, 366);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(220, 26);
            this.txtStockMinimo.TabIndex = 74;
            this.txtStockMinimo.Tag = "StockMinimo";
            // 
            // txtStockMaximo
            // 
            this.txtStockMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockMaximo.Location = new System.Drawing.Point(112, 327);
            this.txtStockMaximo.Name = "txtStockMaximo";
            this.txtStockMaximo.Size = new System.Drawing.Size(220, 26);
            this.txtStockMaximo.TabIndex = 73;
            this.txtStockMaximo.Tag = "StockMaximo";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(112, 288);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(220, 26);
            this.txtStock.TabIndex = 72;
            this.txtStock.Tag = "Stock";
            // 
            // txtLinea
            // 
            this.txtLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinea.Location = new System.Drawing.Point(336, 251);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(26, 26);
            this.txtLinea.TabIndex = 71;
            this.txtLinea.Tag = "Fkidlinea";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(112, 214);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 26);
            this.txtNombre.TabIndex = 70;
            this.txtNombre.Tag = "Nombre";
            // 
            // txtInventario
            // 
            this.txtInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventario.Location = new System.Drawing.Point(336, 177);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.Size = new System.Drawing.Size(28, 26);
            this.txtInventario.TabIndex = 75;
            this.txtInventario.Tag = "fkinventario";
            // 
            // txtPkid
            // 
            this.txtPkid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkid.Location = new System.Drawing.Point(112, 140);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(220, 26);
            this.txtPkid.TabIndex = 68;
            this.txtPkid.Tag = "Pkid";
            // 
            // rbnActivo
            // 
            this.rbnActivo.AutoSize = true;
            this.rbnActivo.BackColor = System.Drawing.Color.Transparent;
            this.rbnActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnActivo.Location = new System.Drawing.Point(65, 523);
            this.rbnActivo.Name = "rbnActivo";
            this.rbnActivo.Size = new System.Drawing.Size(98, 24);
            this.rbnActivo.TabIndex = 67;
            this.rbnActivo.TabStop = true;
            this.rbnActivo.Text = "Habilitado";
            this.rbnActivo.UseVisualStyleBackColor = false;
            this.rbnActivo.CheckedChanged += new System.EventHandler(this.rbnActivo_CheckedChanged);
            // 
            // rbnInactivo
            // 
            this.rbnInactivo.AutoSize = true;
            this.rbnInactivo.BackColor = System.Drawing.Color.Transparent;
            this.rbnInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnInactivo.Location = new System.Drawing.Point(169, 524);
            this.rbnInactivo.Name = "rbnInactivo";
            this.rbnInactivo.Size = new System.Drawing.Size(109, 24);
            this.rbnInactivo.TabIndex = 76;
            this.rbnInactivo.TabStop = true;
            this.rbnInactivo.Text = "Inhabilitado";
            this.rbnInactivo.UseVisualStyleBackColor = false;
            this.rbnInactivo.CheckedChanged += new System.EventHandler(this.rbnInactivo_CheckedChanged);
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(2, -1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 83;
            // 
            // labelcorreocliente
            // 
            this.labelcorreocliente.AutoSize = true;
            this.labelcorreocliente.BackColor = System.Drawing.Color.Transparent;
            this.labelcorreocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcorreocliente.Location = new System.Drawing.Point(26, 372);
            this.labelcorreocliente.Name = "labelcorreocliente";
            this.labelcorreocliente.Size = new System.Drawing.Size(79, 20);
            this.labelcorreocliente.TabIndex = 82;
            this.labelcorreocliente.Text = "StockMin:";
            // 
            // labeldireccioncliente
            // 
            this.labeldireccioncliente.AutoSize = true;
            this.labeldireccioncliente.BackColor = System.Drawing.Color.Transparent;
            this.labeldireccioncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldireccioncliente.Location = new System.Drawing.Point(26, 333);
            this.labeldireccioncliente.Name = "labeldireccioncliente";
            this.labeldireccioncliente.Size = new System.Drawing.Size(87, 20);
            this.labeldireccioncliente.TabIndex = 81;
            this.labeldireccioncliente.Text = "Stock Max:";
            // 
            // labeltelefonocliente
            // 
            this.labeltelefonocliente.AutoSize = true;
            this.labeltelefonocliente.BackColor = System.Drawing.Color.Transparent;
            this.labeltelefonocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltelefonocliente.Location = new System.Drawing.Point(26, 299);
            this.labeltelefonocliente.Name = "labeltelefonocliente";
            this.labeltelefonocliente.Size = new System.Drawing.Size(54, 20);
            this.labeltelefonocliente.TabIndex = 80;
            this.labeltelefonocliente.Text = "Stock:";
            // 
            // labelnitcliente
            // 
            this.labelnitcliente.AutoSize = true;
            this.labelnitcliente.BackColor = System.Drawing.Color.Transparent;
            this.labelnitcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnitcliente.Location = new System.Drawing.Point(27, 257);
            this.labelnitcliente.Name = "labelnitcliente";
            this.labelnitcliente.Size = new System.Drawing.Size(52, 20);
            this.labelnitcliente.TabIndex = 79;
            this.labelnitcliente.Text = "Linea:";
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.BackColor = System.Drawing.Color.Transparent;
            this.labelClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientes.Location = new System.Drawing.Point(366, 111);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(171, 20);
            this.labelClientes.TabIndex = 78;
            this.labelClientes.Text = "Productos Registrados";
            // 
            // dtgClientes
            // 
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgClientes.Location = new System.Drawing.Point(370, 134);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.Size = new System.Drawing.Size(794, 435);
            this.dtgClientes.TabIndex = 77;
            // 
            // labelestadocliente
            // 
            this.labelestadocliente.AutoSize = true;
            this.labelestadocliente.BackColor = System.Drawing.Color.Transparent;
            this.labelestadocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelestadocliente.Location = new System.Drawing.Point(45, 494);
            this.labelestadocliente.Name = "labelestadocliente";
            this.labelestadocliente.Size = new System.Drawing.Size(64, 20);
            this.labelestadocliente.TabIndex = 66;
            this.labelestadocliente.Text = "Estado:";
            // 
            // labelapellidocliente
            // 
            this.labelapellidocliente.AutoSize = true;
            this.labelapellidocliente.BackColor = System.Drawing.Color.Transparent;
            this.labelapellidocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelapellidocliente.Location = new System.Drawing.Point(26, 220);
            this.labelapellidocliente.Name = "labelapellidocliente";
            this.labelapellidocliente.Size = new System.Drawing.Size(69, 20);
            this.labelapellidocliente.TabIndex = 65;
            this.labelapellidocliente.Text = "Nombre:";
            // 
            // labelnombrecliente
            // 
            this.labelnombrecliente.AutoSize = true;
            this.labelnombrecliente.BackColor = System.Drawing.Color.Transparent;
            this.labelnombrecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombrecliente.Location = new System.Drawing.Point(27, 183);
            this.labelnombrecliente.Name = "labelnombrecliente";
            this.labelnombrecliente.Size = new System.Drawing.Size(83, 20);
            this.labelnombrecliente.TabIndex = 64;
            this.labelnombrecliente.Text = "Inventario:";
            // 
            // labelidcliente
            // 
            this.labelidcliente.AutoSize = true;
            this.labelidcliente.BackColor = System.Drawing.Color.Transparent;
            this.labelidcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidcliente.Location = new System.Drawing.Point(27, 146);
            this.labelidcliente.Name = "labelidcliente";
            this.labelidcliente.Size = new System.Drawing.Size(30, 20);
            this.labelidcliente.TabIndex = 63;
            this.labelidcliente.Text = "ID:";
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(112, 407);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(220, 26);
            this.txtCosto.TabIndex = 74;
            this.txtCosto.Tag = "Costo";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(112, 450);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(220, 26);
            this.txtPrecio.TabIndex = 74;
            this.txtPrecio.Tag = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "Costo:";
            // 
            // cbxInventario
            // 
            this.cbxInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxInventario.FormattingEnabled = true;
            this.cbxInventario.Location = new System.Drawing.Point(112, 175);
            this.cbxInventario.Name = "cbxInventario";
            this.cbxInventario.Size = new System.Drawing.Size(220, 28);
            this.cbxInventario.TabIndex = 98;
            this.cbxInventario.SelectedIndexChanged += new System.EventHandler(this.cbxInventario_SelectedIndexChanged);
            // 
            // cbxLinea
            // 
            this.cbxLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLinea.FormattingEnabled = true;
            this.cbxLinea.Location = new System.Drawing.Point(112, 249);
            this.cbxLinea.Name = "cbxLinea";
            this.cbxLinea.Size = new System.Drawing.Size(220, 28);
            this.cbxLinea.TabIndex = 98;
            this.cbxLinea.SelectedIndexChanged += new System.EventHandler(this.cbxLinea_SelectedIndexChanged);
            // 
            // frmMantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaMVentasCC.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.ClientSize = new System.Drawing.Size(1191, 596);
            this.Controls.Add(this.cbxLinea);
            this.Controls.Add(this.cbxInventario);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtStockMinimo);
            this.Controls.Add(this.txtStockMaximo);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtLinea);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtInventario);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.rbnActivo);
            this.Controls.Add(this.rbnInactivo);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelcorreocliente);
            this.Controls.Add(this.labeldireccioncliente);
            this.Controls.Add(this.labeltelefonocliente);
            this.Controls.Add(this.labelnitcliente);
            this.Controls.Add(this.labelClientes);
            this.Controls.Add(this.dtgClientes);
            this.Controls.Add(this.labelestadocliente);
            this.Controls.Add(this.labelapellidocliente);
            this.Controls.Add(this.labelnombrecliente);
            this.Controls.Add(this.labelidcliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.TextBox txtStockMaximo;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.TextBox txtPkid;
        private System.Windows.Forms.RadioButton rbnActivo;
        private System.Windows.Forms.RadioButton rbnInactivo;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.Label labelcorreocliente;
        private System.Windows.Forms.Label labeldireccioncliente;
        private System.Windows.Forms.Label labeltelefonocliente;
        private System.Windows.Forms.Label labelnitcliente;
        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.DataGridView dtgClientes;
        private System.Windows.Forms.Label labelestadocliente;
        private System.Windows.Forms.Label labelapellidocliente;
        private System.Windows.Forms.Label labelnombrecliente;
        private System.Windows.Forms.Label labelidcliente;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxInventario;
        private System.Windows.Forms.ComboBox cbxLinea;
    }
}