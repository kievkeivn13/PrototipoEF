
namespace CapaVistaMVentasCC
{
    partial class frmMantenimientoTipoBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoTipoBodega));
            this.navegador1 = new DLL.nav.navegador();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPkid = new System.Windows.Forms.TextBox();
            this.rbnHabilitado = new System.Windows.Forms.RadioButton();
            this.rbnInhabilitado = new System.Windows.Forms.RadioButton();
            this.labelMoras = new System.Windows.Forms.Label();
            this.dtgTipoBodega = new System.Windows.Forms.DataGridView();
            this.labelestadoinventario = new System.Windows.Forms.Label();
            this.labelnombretinventario = new System.Windows.Forms.Label();
            this.labelidtinventario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoBodega)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, -1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 56;
            // 
            // txtEstatus
            // 
            this.txtEstatus.Enabled = false;
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(275, 272);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(54, 26);
            this.txtEstatus.TabIndex = 53;
            this.txtEstatus.Tag = "Estatus";
            this.txtEstatus.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(82, 204);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(247, 26);
            this.txtNombre.TabIndex = 54;
            this.txtNombre.Tag = "Nombre";
            // 
            // txtPkid
            // 
            this.txtPkid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkid.Location = new System.Drawing.Point(82, 167);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(247, 26);
            this.txtPkid.TabIndex = 55;
            this.txtPkid.Tag = "Pkid";
            // 
            // rbnHabilitado
            // 
            this.rbnHabilitado.AutoSize = true;
            this.rbnHabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbnHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnHabilitado.Location = new System.Drawing.Point(58, 274);
            this.rbnHabilitado.Name = "rbnHabilitado";
            this.rbnHabilitado.Size = new System.Drawing.Size(98, 24);
            this.rbnHabilitado.TabIndex = 49;
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
            this.rbnInhabilitado.Location = new System.Drawing.Point(160, 272);
            this.rbnInhabilitado.Name = "rbnInhabilitado";
            this.rbnInhabilitado.Size = new System.Drawing.Size(109, 24);
            this.rbnInhabilitado.TabIndex = 50;
            this.rbnInhabilitado.TabStop = true;
            this.rbnInhabilitado.Text = "Inhabilitado";
            this.rbnInhabilitado.UseVisualStyleBackColor = false;
            this.rbnInhabilitado.CheckedChanged += new System.EventHandler(this.rbnInactivo_CheckedChanged);
            // 
            // labelMoras
            // 
            this.labelMoras.AutoSize = true;
            this.labelMoras.BackColor = System.Drawing.Color.Transparent;
            this.labelMoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoras.Location = new System.Drawing.Point(362, 109);
            this.labelMoras.Name = "labelMoras";
            this.labelMoras.Size = new System.Drawing.Size(129, 20);
            this.labelMoras.TabIndex = 52;
            this.labelMoras.Text = "Tipos de Bodega";
            // 
            // dtgTipoBodega
            // 
            this.dtgTipoBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTipoBodega.Location = new System.Drawing.Point(365, 130);
            this.dtgTipoBodega.Name = "dtgTipoBodega";
            this.dtgTipoBodega.Size = new System.Drawing.Size(791, 236);
            this.dtgTipoBodega.TabIndex = 51;
            // 
            // labelestadoinventario
            // 
            this.labelestadoinventario.AutoSize = true;
            this.labelestadoinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelestadoinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelestadoinventario.Location = new System.Drawing.Point(14, 248);
            this.labelestadoinventario.Name = "labelestadoinventario";
            this.labelestadoinventario.Size = new System.Drawing.Size(64, 20);
            this.labelestadoinventario.TabIndex = 48;
            this.labelestadoinventario.Text = "Estado:";
            // 
            // labelnombretinventario
            // 
            this.labelnombretinventario.AutoSize = true;
            this.labelnombretinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelnombretinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombretinventario.Location = new System.Drawing.Point(9, 210);
            this.labelnombretinventario.Name = "labelnombretinventario";
            this.labelnombretinventario.Size = new System.Drawing.Size(69, 20);
            this.labelnombretinventario.TabIndex = 47;
            this.labelnombretinventario.Text = "Nombre:";
            // 
            // labelidtinventario
            // 
            this.labelidtinventario.AutoSize = true;
            this.labelidtinventario.BackColor = System.Drawing.Color.Transparent;
            this.labelidtinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidtinventario.Location = new System.Drawing.Point(14, 168);
            this.labelidtinventario.Name = "labelidtinventario";
            this.labelidtinventario.Size = new System.Drawing.Size(30, 20);
            this.labelidtinventario.TabIndex = 46;
            this.labelidtinventario.Text = "ID:";
            // 
            // frmMantenimientoTipoBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaMVentasCC.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.ClientSize = new System.Drawing.Size(1188, 387);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.rbnHabilitado);
            this.Controls.Add(this.rbnInhabilitado);
            this.Controls.Add(this.labelMoras);
            this.Controls.Add(this.dtgTipoBodega);
            this.Controls.Add(this.labelestadoinventario);
            this.Controls.Add(this.labelnombretinventario);
            this.Controls.Add(this.labelidtinventario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoTipoBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimientoTipoBodega";
            this.Load += new System.EventHandler(this.frmMantenimientoTipoBodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipoBodega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPkid;
        private System.Windows.Forms.RadioButton rbnHabilitado;
        private System.Windows.Forms.RadioButton rbnInhabilitado;
        private System.Windows.Forms.Label labelMoras;
        private System.Windows.Forms.DataGridView dtgTipoBodega;
        private System.Windows.Forms.Label labelestadoinventario;
        private System.Windows.Forms.Label labelnombretinventario;
        private System.Windows.Forms.Label labelidtinventario;
    }
}