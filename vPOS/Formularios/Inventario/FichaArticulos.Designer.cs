namespace vPOS.Formularios.Inventario
{
    partial class FichaArticulos
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
            this.components = new System.ComponentModel.Container();
            this.invTab = new System.Windows.Forms.TabControl();
            this.Principal = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.idproducto = new System.Windows.Forms.TextBox();
            this.lblidproducto = new System.Windows.Forms.Label();
            this.Barras = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.costo = new System.Windows.Forms.TextBox();
            this.invTab.SuspendLayout();
            this.Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // invTab
            // 
            this.invTab.Controls.Add(this.Principal);
            this.invTab.Controls.Add(this.Barras);
            this.invTab.Controls.Add(this.tabPage1);
            this.invTab.Location = new System.Drawing.Point(12, 12);
            this.invTab.Name = "invTab";
            this.invTab.SelectedIndex = 0;
            this.invTab.Size = new System.Drawing.Size(776, 426);
            this.invTab.TabIndex = 0;
            // 
            // Principal
            // 
            this.Principal.Controls.Add(this.label2);
            this.Principal.Controls.Add(this.codigo);
            this.Principal.Controls.Add(this.label1);
            this.Principal.Controls.Add(this.descripcion);
            this.Principal.Controls.Add(this.idproducto);
            this.Principal.Controls.Add(this.lblidproducto);
            this.Principal.Location = new System.Drawing.Point(4, 22);
            this.Principal.Name = "Principal";
            this.Principal.Padding = new System.Windows.Forms.Padding(3);
            this.Principal.Size = new System.Drawing.Size(768, 400);
            this.Principal.TabIndex = 0;
            this.Principal.Text = "Principal";
            this.Principal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Código";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(142, 86);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(165, 20);
            this.codigo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripción";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(142, 55);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(347, 20);
            this.descripcion.TabIndex = 2;
            this.descripcion.Validating += new System.ComponentModel.CancelEventHandler(this.descripcion_Validating);
            // 
            // idproducto
            // 
            this.idproducto.Location = new System.Drawing.Point(142, 21);
            this.idproducto.Name = "idproducto";
            this.idproducto.Size = new System.Drawing.Size(68, 20);
            this.idproducto.TabIndex = 1;
            // 
            // lblidproducto
            // 
            this.lblidproducto.AutoSize = true;
            this.lblidproducto.Location = new System.Drawing.Point(23, 21);
            this.lblidproducto.Name = "lblidproducto";
            this.lblidproducto.Size = new System.Drawing.Size(62, 13);
            this.lblidproducto.TabIndex = 0;
            this.lblidproducto.Text = "Id Producto";
            // 
            // Barras
            // 
            this.Barras.Location = new System.Drawing.Point(4, 22);
            this.Barras.Name = "Barras";
            this.Barras.Padding = new System.Windows.Forms.Padding(3);
            this.Barras.Size = new System.Drawing.Size(768, 400);
            this.Barras.TabIndex = 1;
            this.Barras.Text = "Barras";
            this.Barras.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.costo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Costos, Precios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Costo Unitario";
            // 
            // costo
            // 
            this.costo.Location = new System.Drawing.Point(143, 22);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(189, 20);
            this.costo.TabIndex = 1;
            // 
            // FichaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.invTab);
            this.Name = "FichaArticulos";
            this.Text = "Ficha de Articulos";
            this.invTab.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl invTab;
        private System.Windows.Forms.TabPage Principal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.TextBox idproducto;
        private System.Windows.Forms.Label lblidproducto;
        private System.Windows.Forms.TabPage Barras;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox costo;
        private System.Windows.Forms.Label label3;
    }
}