namespace AeroSync
{
    partial class frmInicioSesion
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
            btnProbarBD = new Button();
            lblNombreUsuario = new Label();
            lblPasswordUsuario = new Label();
            lblRolUsuario = new Label();
            txtNombreUsuario = new TextBox();
            txtPasswordUsuario = new TextBox();
            cboRolUsuario = new ComboBox();
            pictureBox1 = new PictureBox();
            btnIniciarSesion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnProbarBD
            // 
            btnProbarBD.BackColor = Color.LavenderBlush;
            btnProbarBD.Location = new Point(29, 394);
            btnProbarBD.Name = "btnProbarBD";
            btnProbarBD.Size = new Size(160, 27);
            btnProbarBD.TabIndex = 0;
            btnProbarBD.Text = "Probar conexión a BD";
            btnProbarBD.UseVisualStyleBackColor = false;
            btnProbarBD.Click += btnProbarBD_Click;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = Color.LavenderBlush;
            lblNombreUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreUsuario.ForeColor = SystemColors.ActiveCaptionText;
            lblNombreUsuario.Location = new Point(29, 195);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(163, 21);
            lblNombreUsuario.TabIndex = 1;
            lblNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // lblPasswordUsuario
            // 
            lblPasswordUsuario.AutoSize = true;
            lblPasswordUsuario.BackColor = Color.LavenderBlush;
            lblPasswordUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPasswordUsuario.Location = new Point(29, 248);
            lblPasswordUsuario.Name = "lblPasswordUsuario";
            lblPasswordUsuario.Size = new Size(149, 21);
            lblPasswordUsuario.TabIndex = 2;
            lblPasswordUsuario.Text = "Password Usuario:";
            // 
            // lblRolUsuario
            // 
            lblRolUsuario.AutoSize = true;
            lblRolUsuario.BackColor = Color.LavenderBlush;
            lblRolUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRolUsuario.Location = new Point(29, 303);
            lblRolUsuario.Name = "lblRolUsuario";
            lblRolUsuario.Size = new Size(125, 21);
            lblRolUsuario.TabIndex = 3;
            lblRolUsuario.Text = "Rol de Usuario:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(216, 190);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(152, 26);
            txtNombreUsuario.TabIndex = 4;
            // 
            // txtPasswordUsuario
            // 
            txtPasswordUsuario.Location = new Point(216, 248);
            txtPasswordUsuario.Name = "txtPasswordUsuario";
            txtPasswordUsuario.Size = new Size(152, 26);
            txtPasswordUsuario.TabIndex = 5;
            txtPasswordUsuario.UseSystemPasswordChar = true;
            // 
            // cboRolUsuario
            // 
            cboRolUsuario.FormattingEnabled = true;
            cboRolUsuario.Location = new Point(216, 303);
            cboRolUsuario.Name = "cboRolUsuario";
            cboRolUsuario.Size = new Size(152, 27);
            cboRolUsuario.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2025_07_10_at_2_59_00_PM;
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(508, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.LavenderBlush;
            btnIniciarSesion.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.Image = Properties.Resources.WhatsApp_Image_2025_07_10_at_4_15_44_PM__1_;
            btnIniciarSesion.ImageAlign = ContentAlignment.TopCenter;
            btnIniciarSesion.Location = new Point(392, 354);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(77, 84);
            btnIniciarSesion.TabIndex = 8;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.TextAlign = ContentAlignment.BottomCenter;
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._860__1_1;
            ClientSize = new Size(507, 450);
            Controls.Add(btnIniciarSesion);
            Controls.Add(pictureBox1);
            Controls.Add(cboRolUsuario);
            Controls.Add(txtPasswordUsuario);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblRolUsuario);
            Controls.Add(lblPasswordUsuario);
            Controls.Add(lblNombreUsuario);
            Controls.Add(btnProbarBD);
            Name = "frmInicioSesion";
            Text = "Formulario Inicio de Sesión de Usuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProbarBD;
        private Label lblNombreUsuario;
        private Label lblPasswordUsuario;
        private Label lblRolUsuario;
        private TextBox txtNombreUsuario;
        private TextBox txtPasswordUsuario;
        private ComboBox cboRolUsuario;
        private PictureBox pictureBox1;
        private Button btnIniciarSesion;
    }
}
