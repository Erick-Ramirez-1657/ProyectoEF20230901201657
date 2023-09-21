﻿namespace CapaVista.Formularios
{
    partial class frmInventario
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
            this.txt_cod_producto = new System.Windows.Forms.TextBox();
            this.lbl_cod_producto = new System.Windows.Forms.Label();
            this.lbl_nombre_producto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre_producto = new System.Windows.Forms.TextBox();
            this.lbl_nombre_proveedor = new System.Windows.Forms.Label();
            this.lbl_fecha_entrega = new System.Windows.Forms.Label();
            this.txt_nombre_proveedor = new System.Windows.Forms.TextBox();
            this.txt_unidades = new System.Windows.Forms.TextBox();
            this.lbl_unidades = new System.Windows.Forms.Label();
            this.date_fecha_entrega = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txt_cod_producto
            // 
            this.txt_cod_producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_producto.Location = new System.Drawing.Point(214, 111);
            this.txt_cod_producto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cod_producto.Name = "txt_cod_producto";
            this.txt_cod_producto.Size = new System.Drawing.Size(215, 27);
            this.txt_cod_producto.TabIndex = 0;
            this.txt_cod_producto.Tag = "PK_cod_producto";
            // 
            // lbl_cod_producto
            // 
            this.lbl_cod_producto.AutoSize = true;
            this.lbl_cod_producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod_producto.Location = new System.Drawing.Point(31, 118);
            this.lbl_cod_producto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cod_producto.Name = "lbl_cod_producto";
            this.lbl_cod_producto.Size = new System.Drawing.Size(126, 21);
            this.lbl_cod_producto.TabIndex = 1;
            this.lbl_cod_producto.Text = "Cod. producto";
            this.lbl_cod_producto.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_nombre_producto
            // 
            this.lbl_nombre_producto.AutoSize = true;
            this.lbl_nombre_producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_producto.Location = new System.Drawing.Point(31, 152);
            this.lbl_nombre_producto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre_producto.Name = "lbl_nombre_producto";
            this.lbl_nombre_producto.Size = new System.Drawing.Size(151, 21);
            this.lbl_nombre_producto.TabIndex = 2;
            this.lbl_nombre_producto.Text = "Nombre producto";
            this.lbl_nombre_producto.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Inventario";
            // 
            // txt_nombre_producto
            // 
            this.txt_nombre_producto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_producto.Location = new System.Drawing.Point(214, 150);
            this.txt_nombre_producto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre_producto.Name = "txt_nombre_producto";
            this.txt_nombre_producto.Size = new System.Drawing.Size(215, 27);
            this.txt_nombre_producto.TabIndex = 4;
            this.txt_nombre_producto.Tag = "nbr_nombre_producto";
            // 
            // lbl_nombre_proveedor
            // 
            this.lbl_nombre_proveedor.AutoSize = true;
            this.lbl_nombre_proveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_proveedor.Location = new System.Drawing.Point(31, 188);
            this.lbl_nombre_proveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre_proveedor.Name = "lbl_nombre_proveedor";
            this.lbl_nombre_proveedor.Size = new System.Drawing.Size(159, 21);
            this.lbl_nombre_proveedor.TabIndex = 5;
            this.lbl_nombre_proveedor.Text = "Nombre proveedor";
            // 
            // lbl_fecha_entrega
            // 
            this.lbl_fecha_entrega.AutoSize = true;
            this.lbl_fecha_entrega.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_entrega.Location = new System.Drawing.Point(31, 263);
            this.lbl_fecha_entrega.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fecha_entrega.Name = "lbl_fecha_entrega";
            this.lbl_fecha_entrega.Size = new System.Drawing.Size(126, 21);
            this.lbl_fecha_entrega.TabIndex = 6;
            this.lbl_fecha_entrega.Text = "Fecha Entrega";
            // 
            // txt_nombre_proveedor
            // 
            this.txt_nombre_proveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_proveedor.Location = new System.Drawing.Point(214, 186);
            this.txt_nombre_proveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre_proveedor.Name = "txt_nombre_proveedor";
            this.txt_nombre_proveedor.Size = new System.Drawing.Size(215, 27);
            this.txt_nombre_proveedor.TabIndex = 7;
            this.txt_nombre_proveedor.Tag = "nbr_nombre_proveedor";
            // 
            // txt_unidades
            // 
            this.txt_unidades.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unidades.Location = new System.Drawing.Point(214, 224);
            this.txt_unidades.Margin = new System.Windows.Forms.Padding(2);
            this.txt_unidades.Name = "txt_unidades";
            this.txt_unidades.Size = new System.Drawing.Size(215, 27);
            this.txt_unidades.TabIndex = 8;
            this.txt_unidades.Tag = "nbr_unidades";
            // 
            // lbl_unidades
            // 
            this.lbl_unidades.AutoSize = true;
            this.lbl_unidades.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unidades.Location = new System.Drawing.Point(31, 227);
            this.lbl_unidades.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_unidades.Name = "lbl_unidades";
            this.lbl_unidades.Size = new System.Drawing.Size(83, 21);
            this.lbl_unidades.TabIndex = 9;
            this.lbl_unidades.Text = "Unidades";
            // 
            // date_fecha_entrega
            // 
            this.date_fecha_entrega.CalendarFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_fecha_entrega.CustomFormat = "yyyy-MM-dd";
            this.date_fecha_entrega.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_fecha_entrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_fecha_entrega.Location = new System.Drawing.Point(214, 263);
            this.date_fecha_entrega.Margin = new System.Windows.Forms.Padding(2);
            this.date_fecha_entrega.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.date_fecha_entrega.Name = "date_fecha_entrega";
            this.date_fecha_entrega.Size = new System.Drawing.Size(212, 27);
            this.date_fecha_entrega.TabIndex = 11;
            this.date_fecha_entrega.Tag = "nbr_fecha_entrega";
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(782, 340);
            this.Controls.Add(this.date_fecha_entrega);
            this.Controls.Add(this.lbl_unidades);
            this.Controls.Add(this.txt_unidades);
            this.Controls.Add(this.txt_nombre_proveedor);
            this.Controls.Add(this.lbl_fecha_entrega);
            this.Controls.Add(this.lbl_nombre_proveedor);
            this.Controls.Add(this.txt_nombre_producto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_nombre_producto);
            this.Controls.Add(this.lbl_cod_producto);
            this.Controls.Add(this.txt_cod_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInventario";
            this.Tag = "frmInventario";
            this.Text = "frmInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cod_producto;
        private System.Windows.Forms.Label lbl_cod_producto;
        private System.Windows.Forms.Label lbl_nombre_producto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre_producto;
        private System.Windows.Forms.Label lbl_nombre_proveedor;
        private System.Windows.Forms.Label lbl_fecha_entrega;
        private System.Windows.Forms.TextBox txt_nombre_proveedor;
        private System.Windows.Forms.TextBox txt_unidades;
        private System.Windows.Forms.Label lbl_unidades;
        private System.Windows.Forms.DateTimePicker date_fecha_entrega;
    }
}