namespace FrmAtencion
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
            btnAtender = new Button();
            btnSalir = new Button();
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            label1 = new Label();
            label3 = new Label();
            richTextBoxFichaMedico = new RichTextBox();
            SuspendLayout();
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(786, 12);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(182, 113);
            btnAtender.TabIndex = 0;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(786, 509);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(182, 114);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 30);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(244, 304);
            lstMedicos.TabIndex = 2;
            lstMedicos.SelectedIndexChanged += lstMedicos_SelectedIndexChanged;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(397, 30);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(244, 304);
            lstPacientes.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 4;
            label1.Text = "Personal Medico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 12);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Pacientes";
            // 
            // richTextBoxFichaMedico
            // 
            richTextBoxFichaMedico.Location = new Point(12, 360);
            richTextBoxFichaMedico.Name = "richTextBoxFichaMedico";
            richTextBoxFichaMedico.Size = new Size(629, 263);
            richTextBoxFichaMedico.TabIndex = 7;
            richTextBoxFichaMedico.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 635);
            Controls.Add(richTextBoxFichaMedico);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alumno";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtender;
        private Button btnSalir;
        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private Label label1;
        private Label label3;
        private RichTextBox richTextBoxFichaMedico;
    }
}
