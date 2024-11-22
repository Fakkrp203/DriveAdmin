namespace CRUD_TEST
{
    partial class Login
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtusuario = new TextBox();
            txtcontraseña = new TextBox();
            label3 = new Label();
            label4 = new Label();
            buttoningresar = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 619);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(577, 58);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(426, 103);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(482, 151);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(228, 23);
            txtusuario.TabIndex = 3;
            txtusuario.TextChanged += txtusuario_TextChanged;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(482, 216);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.Size = new Size(228, 23);
            txtcontraseña.TabIndex = 4;
            txtcontraseña.UseSystemPasswordChar = true;
            txtcontraseña.TextChanged += txtcontraseña_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(482, 124);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(482, 187);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // buttoningresar
            // 
            buttoningresar.BackColor = Color.DarkSlateGray;
            buttoningresar.FlatStyle = FlatStyle.Popup;
            buttoningresar.ForeColor = Color.White;
            buttoningresar.Location = new Point(493, 271);
            buttoningresar.Name = "buttoningresar";
            buttoningresar.Size = new Size(200, 29);
            buttoningresar.TabIndex = 7;
            buttoningresar.Text = "Ingresar";
            buttoningresar.UseVisualStyleBackColor = false;
            buttoningresar.Click += buttoningresar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttoningresar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtcontraseña);
            Controls.Add(txtusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtusuario;
        private TextBox txtcontraseña;
        private Label label3;
        private Label label4;
        private Button buttoningresar;
    }
}