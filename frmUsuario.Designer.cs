namespace AeroSync
{
    partial class frmUsuario
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
            lblGestionUsuario = new Label();
            SuspendLayout();
            // 
            // lblGestionUsuario
            // 
            lblGestionUsuario.AutoSize = true;
            lblGestionUsuario.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGestionUsuario.Location = new Point(234, 25);
            lblGestionUsuario.Name = "lblGestionUsuario";
            lblGestionUsuario.Size = new Size(348, 30);
            lblGestionUsuario.TabIndex = 0;
            lblGestionUsuario.Text = "Bienvenidos a Gestión de Usuarios ";
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGestionUsuario);
            Name = "frmUsuario";
            Text = "Formulario de Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGestionUsuario;
    }
}