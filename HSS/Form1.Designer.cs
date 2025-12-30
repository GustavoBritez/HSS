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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Grilla_Productos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Grilla_Productos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Grilla_Productos;
    }
}
