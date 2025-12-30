namespace HSS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Grilla_Productos = new DataGridView();
            BTN_AGREGAR = new Button();
            BTN_ELIMINAR = new Button();
            BTN_MODIFICAR = new Button();
            TXT_BUSQUEDA = new TextBox();
            TXT_NOMBRE = new TextBox();
            TXT_MARCA = new TextBox();
            List_Categoria = new ListBox();
            label45 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Grilla_Productos).BeginInit();
            SuspendLayout();
            // 
            // Grilla_Productos
            // 
            Grilla_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Productos.Location = new Point(12, 88);
            Grilla_Productos.Name = "Grilla_Productos";
            Grilla_Productos.Size = new Size(659, 192);
            Grilla_Productos.TabIndex = 0;
            // 
            // BTN_AGREGAR
            // 
            BTN_AGREGAR.Location = new Point(12, 286);
            BTN_AGREGAR.Name = "BTN_AGREGAR";
            BTN_AGREGAR.Size = new Size(75, 23);
            BTN_AGREGAR.TabIndex = 1;
            BTN_AGREGAR.Text = "AGREGAR";
            BTN_AGREGAR.UseVisualStyleBackColor = true;
            // 
            // BTN_ELIMINAR
            // 
            BTN_ELIMINAR.Location = new Point(12, 315);
            BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            BTN_ELIMINAR.Size = new Size(75, 23);
            BTN_ELIMINAR.TabIndex = 2;
            BTN_ELIMINAR.Text = "ELIMINAR";
            BTN_ELIMINAR.UseVisualStyleBackColor = true;
            // 
            // BTN_MODIFICAR
            // 
            BTN_MODIFICAR.Location = new Point(12, 344);
            BTN_MODIFICAR.Name = "BTN_MODIFICAR";
            BTN_MODIFICAR.Size = new Size(80, 23);
            BTN_MODIFICAR.TabIndex = 3;
            BTN_MODIFICAR.Text = "MODIFICAR";
            BTN_MODIFICAR.UseVisualStyleBackColor = true;
            // 
            // TXT_BUSQUEDA
            // 
            TXT_BUSQUEDA.Location = new Point(12, 59);
            TXT_BUSQUEDA.Name = "TXT_BUSQUEDA";
            TXT_BUSQUEDA.Size = new Size(235, 23);
            TXT_BUSQUEDA.TabIndex = 4;
            // 
            // TXT_NOMBRE
            // 
            TXT_NOMBRE.Location = new Point(203, 286);
            TXT_NOMBRE.Name = "TXT_NOMBRE";
            TXT_NOMBRE.Size = new Size(157, 23);
            TXT_NOMBRE.TabIndex = 7;
            // 
            // TXT_MARCA
            // 
            TXT_MARCA.Location = new Point(436, 286);
            TXT_MARCA.Name = "TXT_MARCA";
            TXT_MARCA.Size = new Size(148, 23);
            TXT_MARCA.TabIndex = 8;
            // 
            // List_Categoria
            // 
            List_Categoria.FormattingEnabled = true;
            List_Categoria.Location = new Point(618, 287);
            List_Categoria.Name = "List_Categoria";
            List_Categoria.Size = new Size(154, 94);
            List_Categoria.TabIndex = 9;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Location = new Point(146, 294);
            label45.Name = "label45";
            label45.Size = new Size(51, 15);
            label45.TabIndex = 10;
            label45.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(379, 294);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 11;
            label1.Text = "Marca";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label45);
            Controls.Add(List_Categoria);
            Controls.Add(TXT_MARCA);
            Controls.Add(TXT_NOMBRE);
            Controls.Add(TXT_BUSQUEDA);
            Controls.Add(BTN_MODIFICAR);
            Controls.Add(BTN_ELIMINAR);
            Controls.Add(BTN_AGREGAR);
            Controls.Add(Grilla_Productos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Grilla_Productos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grilla_Productos;
        private Button BTN_AGREGAR;
        private Button BTN_ELIMINAR;
        private Button BTN_MODIFICAR;
        private TextBox TXT_BUSQUEDA;
        private TextBox TXT_NOMBRE;
        private TextBox TXT_MARCA;
        private ListBox List_Categoria;
        private Label label45;
        private Label label1;
    }
}
