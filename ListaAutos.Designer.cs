namespace CRUD_TEST
{
    partial class ListaAutos
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
            panel2 = new Panel();
            label1 = new Label();
            btnEliminar = new Button();
            checkBox1 = new CheckBox();
            txtAño = new TextBox();
            txtModelo = new TextBox();
            añoLabel = new Label();
            modeloLabel = new Label();
            btnguardar = new Button();
            txtcolor = new TextBox();
            txtprecio = new TextBox();
            txtmarca = new TextBox();
            txtid = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            dgvehiculo = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvehiculo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(txtAño);
            panel1.Controls.Add(txtModelo);
            panel1.Controls.Add(añoLabel);
            panel1.Controls.Add(modeloLabel);
            panel1.Controls.Add(btnguardar);
            panel1.Controls.Add(txtcolor);
            panel1.Controls.Add(txtprecio);
            panel1.Controls.Add(txtmarca);
            panel1.Controls.Add(txtid);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dgvehiculo);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-6, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 453);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(851, 41);
            panel2.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(372, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 0;
            label1.Text = "Gestionar Autos";
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(357, 161);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(506, 81);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(56, 19);
            checkBox1.TabIndex = 30;
            checkBox1.Text = "Editar";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtAño
            // 
            txtAño.Enabled = false;
            txtAño.Location = new Point(594, 243);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(212, 23);
            txtAño.TabIndex = 29;
            txtAño.KeyPress += txtAño_KeyPress;
            // 
            // txtModelo
            // 
            txtModelo.Enabled = false;
            txtModelo.Location = new Point(594, 200);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(212, 23);
            txtModelo.TabIndex = 28;
            txtModelo.KeyPress += txtModelo_KeyPress;
            // 
            // añoLabel
            // 
            añoLabel.AutoSize = true;
            añoLabel.Location = new Point(506, 243);
            añoLabel.Name = "añoLabel";
            añoLabel.Size = new Size(32, 15);
            añoLabel.TabIndex = 27;
            añoLabel.Text = "Año:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new Point(506, 200);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new Size(51, 15);
            modeloLabel.TabIndex = 26;
            modeloLabel.Text = "Modelo:";
            // 
            // btnguardar
            // 
            btnguardar.Enabled = false;
            btnguardar.Location = new Point(506, 383);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(75, 23);
            btnguardar.TabIndex = 25;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // txtcolor
            // 
            txtcolor.Enabled = false;
            txtcolor.Location = new Point(594, 330);
            txtcolor.Name = "txtcolor";
            txtcolor.Size = new Size(212, 23);
            txtcolor.TabIndex = 24;
            txtcolor.KeyPress += txtcolor_KeyPress;
            // 
            // txtprecio
            // 
            txtprecio.Enabled = false;
            txtprecio.Location = new Point(594, 287);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(212, 23);
            txtprecio.TabIndex = 23;
            txtprecio.KeyPress += txtprecio_KeyPress;
            // 
            // txtmarca
            // 
            txtmarca.Enabled = false;
            txtmarca.Location = new Point(594, 162);
            txtmarca.Name = "txtmarca";
            txtmarca.Size = new Size(212, 23);
            txtmarca.TabIndex = 22;
            txtmarca.KeyPress += txtmarca_KeyPress;
            // 
            // txtid
            // 
            txtid.Enabled = false;
            txtid.Location = new Point(594, 122);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(212, 23);
            txtid.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(506, 330);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 20;
            label4.Text = "Color:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(506, 287);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 19;
            label3.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(506, 162);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 18;
            label5.Text = "Marca:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(506, 124);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 17;
            label6.Text = "ID:";
            // 
            // dgvehiculo
            // 
            dgvehiculo.AllowUserToAddRows = false;
            dgvehiculo.AllowUserToDeleteRows = false;
            dgvehiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvehiculo.Location = new Point(38, 202);
            dgvehiculo.Name = "dgvehiculo";
            dgvehiculo.ReadOnly = true;
            dgvehiculo.Size = new Size(394, 150);
            dgvehiculo.TabIndex = 13;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(357, 127);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 130);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el id del auto:";
            // 
            // ListaAutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 450);
            Controls.Add(panel1);
            Name = "ListaAutos";
            Text = "Gestionar Autos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvehiculo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dgvehiculo;
        private TextBox txtAño;
        private TextBox txtModelo;
        private Label añoLabel;
        private Label modeloLabel;
        private Button btnguardar;
        private TextBox txtcolor;
        private TextBox txtprecio;
        private TextBox txtmarca;
        private TextBox txtid;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private CheckBox checkBox1;
        private Button btnEliminar;
        private Panel panel2;
    }
}