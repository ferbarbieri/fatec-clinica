namespace Clinica
{
    partial class AgendamentoForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.lstMedicos = new System.Windows.Forms.ListBox();
            this.lstConsultas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNovaConsulta = new System.Windows.Forms.Button();
            this.dtConsulta = new System.Windows.Forms.DateTimePicker();
            this.lstPacientes = new System.Windows.Forms.ListBox();
            this.pnNovo = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hrConsulta = new System.Windows.Forms.DateTimePicker();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnNovo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Medicos:";
            // 
            // lstMedicos
            // 
            this.lstMedicos.FormattingEnabled = true;
            this.lstMedicos.Location = new System.Drawing.Point(12, 44);
            this.lstMedicos.Name = "lstMedicos";
            this.lstMedicos.Size = new System.Drawing.Size(204, 368);
            this.lstMedicos.TabIndex = 17;
            this.lstMedicos.SelectedIndexChanged += new System.EventHandler(this.lstMedicos_SelectedIndexChanged);
            // 
            // lstConsultas
            // 
            this.lstConsultas.FormattingEnabled = true;
            this.lstConsultas.Location = new System.Drawing.Point(234, 44);
            this.lstConsultas.Name = "lstConsultas";
            this.lstConsultas.Size = new System.Drawing.Size(318, 329);
            this.lstConsultas.TabIndex = 19;
            this.lstConsultas.SelectedIndexChanged += new System.EventHandler(this.lstConsultas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Consultas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = ">";
            // 
            // btnNovaConsulta
            // 
            this.btnNovaConsulta.Location = new System.Drawing.Point(234, 380);
            this.btnNovaConsulta.Name = "btnNovaConsulta";
            this.btnNovaConsulta.Size = new System.Drawing.Size(165, 32);
            this.btnNovaConsulta.TabIndex = 21;
            this.btnNovaConsulta.Text = "Nova Consulta:";
            this.btnNovaConsulta.UseVisualStyleBackColor = true;
            this.btnNovaConsulta.Click += new System.EventHandler(this.btnNovaConsulta_Click);
            // 
            // dtConsulta
            // 
            this.dtConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtConsulta.Location = new System.Drawing.Point(20, 282);
            this.dtConsulta.Name = "dtConsulta";
            this.dtConsulta.Size = new System.Drawing.Size(96, 20);
            this.dtConsulta.TabIndex = 22;
            // 
            // lstPacientes
            // 
            this.lstPacientes.FormattingEnabled = true;
            this.lstPacientes.Location = new System.Drawing.Point(16, 54);
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.Size = new System.Drawing.Size(204, 212);
            this.lstPacientes.TabIndex = 19;
            // 
            // pnNovo
            // 
            this.pnNovo.BackColor = System.Drawing.Color.Linen;
            this.pnNovo.Controls.Add(this.hrConsulta);
            this.pnNovo.Controls.Add(this.lblId);
            this.pnNovo.Controls.Add(this.label4);
            this.pnNovo.Controls.Add(this.label3);
            this.pnNovo.Controls.Add(this.btnSalvar);
            this.pnNovo.Controls.Add(this.lstPacientes);
            this.pnNovo.Controls.Add(this.dtConsulta);
            this.pnNovo.Location = new System.Drawing.Point(577, 44);
            this.pnNovo.Name = "pnNovo";
            this.pnNovo.Size = new System.Drawing.Size(238, 368);
            this.pnNovo.TabIndex = 23;
            this.pnNovo.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(16, 308);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(204, 32);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Paciente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "ID:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(42, 11);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = ">";
            // 
            // hrConsulta
            // 
            this.hrConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hrConsulta.Location = new System.Drawing.Point(122, 282);
            this.hrConsulta.Name = "hrConsulta";
            this.hrConsulta.ShowUpDown = true;
            this.hrConsulta.Size = new System.Drawing.Size(98, 20);
            this.hrConsulta.TabIndex = 27;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Firebrick;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(405, 380);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(147, 32);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // AgendamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 434);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnNovo);
            this.Controls.Add(this.btnNovaConsulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstConsultas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstMedicos);
            this.Name = "AgendamentoForm";
            this.Text = "AgendamentoForm";
            this.Load += new System.EventHandler(this.AgendamentoForm_Load);
            this.pnNovo.ResumeLayout(false);
            this.pnNovo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstMedicos;
        private System.Windows.Forms.ListBox lstConsultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNovaConsulta;
        private System.Windows.Forms.DateTimePicker dtConsulta;
        private System.Windows.Forms.ListBox lstPacientes;
        private System.Windows.Forms.Panel pnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker hrConsulta;
        private System.Windows.Forms.Button btnExcluir;
    }
}