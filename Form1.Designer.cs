namespace Notas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtNota = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridViewNotas = new DataGridView();
            btnGuardar = new Button();
            btnRecargar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 31);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 31);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 31);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Nota";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(525, 31);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha de la evaluacion";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(59, 64);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(80, 23);
            txtNombres.TabIndex = 4;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(204, 64);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(78, 23);
            txtApellidos.TabIndex = 5;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(347, 64);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(79, 23);
            txtNota.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(484, 64);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(216, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // dataGridViewNotas
            // 
            dataGridViewNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNotas.Location = new Point(28, 169);
            dataGridViewNotas.Name = "dataGridViewNotas";
            dataGridViewNotas.Size = new Size(739, 263);
            dataGridViewNotas.TabIndex = 8;
            dataGridViewNotas.CellContentClick += dataGridViewNotas_CellContentClick;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(58, 122);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 30);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(596, 122);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(78, 30);
            btnRecargar.TabIndex = 10;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            btnRecargar.Click += btnRecargar_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRecargar);
            Controls.Add(btnGuardar);
            Controls.Add(dataGridViewNotas);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtNota);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtNota;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridViewNotas;
        private Button btnGuardar;
        private Button btnRecargar;
    }
}
