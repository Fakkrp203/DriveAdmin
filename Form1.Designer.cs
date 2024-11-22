namespace CRUD_TEST
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtid = new TextBox();
            txtmarca = new TextBox();
            txtprecio = new TextBox();
            txtcolor = new TextBox();
            btnguardar = new Button();
            dgvehiculo = new DataGridView();
            form1BindingSource = new BindingSource(components);
            txtAño = new TextBox();
            txtModelo = new TextBox();
            añoLabel = new Label();
            modeloLabel = new Label();
            buttonCatalogo = new Button();
            panel1 = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvehiculo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 108);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 146);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 271);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 314);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Color:";
            // 
            // txtid
            // 
            txtid.Location = new Point(147, 106);
            txtid.Name = "txtid";
            txtid.Size = new Size(212, 23);
            txtid.TabIndex = 4;
            txtid.KeyPress += txtid_KeyPress;
            // 
            // txtmarca
            // 
            txtmarca.Location = new Point(147, 146);
            txtmarca.Name = "txtmarca";
            txtmarca.Size = new Size(212, 23);
            txtmarca.TabIndex = 5;
            txtmarca.KeyPress += txtmarca_KeyPress;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(147, 271);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(212, 23);
            txtprecio.TabIndex = 6;
            txtprecio.KeyPress += txtprecio_KeyPress;
            // 
            // txtcolor
            // 
            txtcolor.Location = new Point(147, 314);
            txtcolor.Name = "txtcolor";
            txtcolor.Size = new Size(212, 23);
            txtcolor.TabIndex = 7;
            txtcolor.KeyPress += txtcolor_KeyPress;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(59, 367);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(75, 23);
            btnguardar.TabIndex = 9;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // dgvehiculo
            // 
            dgvehiculo.AllowUserToAddRows = false;
            dgvehiculo.AllowUserToDeleteRows = false;
            dgvehiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvehiculo.Location = new Point(59, 432);
            dgvehiculo.Name = "dgvehiculo";
            dgvehiculo.ReadOnly = true;
            dgvehiculo.Size = new Size(442, 150);
            dgvehiculo.TabIndex = 12;
            // 
            // form1BindingSource
            // 
            form1BindingSource.DataSource = typeof(Form1);
            // 
            // txtAño
            // 
            txtAño.Location = new Point(147, 227);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(212, 23);
            txtAño.TabIndex = 16;
            txtAño.KeyPress += txtAño_KeyPress;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(147, 184);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(212, 23);
            txtModelo.TabIndex = 15;
            txtModelo.KeyPress += txtModelo_KeyPress;
            // 
            // añoLabel
            // 
            añoLabel.AutoSize = true;
            añoLabel.Location = new Point(59, 227);
            añoLabel.Name = "añoLabel";
            añoLabel.Size = new Size(32, 15);
            añoLabel.TabIndex = 14;
            añoLabel.Text = "Año:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new Point(59, 184);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new Size(51, 15);
            modeloLabel.TabIndex = 13;
            modeloLabel.Text = "Modelo:";
            // 
            // buttonCatalogo
            // 
            buttonCatalogo.Location = new Point(426, 105);
            buttonCatalogo.Name = "buttonCatalogo";
            buttonCatalogo.Size = new Size(75, 23);
            buttonCatalogo.TabIndex = 17;
            buttonCatalogo.Text = "Gestionar";
            buttonCatalogo.UseVisualStyleBackColor = true;
            buttonCatalogo.Click += buttonCatalogo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label5);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 45);
            panel1.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(225, 10);
            label5.Name = "label5";
            label5.Size = new Size(102, 21);
            label5.TabIndex = 1;
            label5.Text = "Nuevo Auto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(536, 605);
            Controls.Add(panel1);
            Controls.Add(buttonCatalogo);
            Controls.Add(txtAño);
            Controls.Add(txtModelo);
            Controls.Add(añoLabel);
            Controls.Add(modeloLabel);
            Controls.Add(dgvehiculo);
            Controls.Add(btnguardar);
            Controls.Add(txtcolor);
            Controls.Add(txtprecio);
            Controls.Add(txtmarca);
            Controls.Add(txtid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Crear un nuevo auto";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvehiculo).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtid;
        private TextBox txtmarca;
        private TextBox txtprecio;
        private TextBox txtcolor;
        private Button btnguardar;
        private DataGridView dgvehiculo;
        private BindingSource form1BindingSource;
        private TextBox txtAño;
        private TextBox txtModelo;
        private Label añoLabel;
        private Label modeloLabel;
        private Button buttonCatalogo;
        private Panel panel1;
        private Label label5;
    }
}
