namespace NotasApp
{
    partial class RabiscaForm
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
            btnSalvarNota = new Button();
            lblNovaNota = new Label();
            label2 = new Label();
            tbxNota = new TextBox();
            lbxNotas = new ListBox();
            btnExcluirNota = new Button();
            SuspendLayout();
            // 
            // btnSalvarNota
            // 
            btnSalvarNota.BackColor = Color.DarkSeaGreen;
            btnSalvarNota.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalvarNota.Location = new Point(317, 399);
            btnSalvarNota.Name = "btnSalvarNota";
            btnSalvarNota.Size = new Size(128, 42);
            btnSalvarNota.TabIndex = 0;
            btnSalvarNota.Text = "Salvar";
            btnSalvarNota.UseVisualStyleBackColor = false;
            btnSalvarNota.Click += btnSalvarNota_Click;
            // 
            // lblNovaNota
            // 
            lblNovaNota.BackColor = Color.Transparent;
            lblNovaNota.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNovaNota.ForeColor = Color.Green;
            lblNovaNota.Location = new Point(112, 53);
            lblNovaNota.Name = "lblNovaNota";
            lblNovaNota.Size = new Size(84, 35);
            lblNovaNota.TabIndex = 1;
            lblNovaNota.Text = "Nota";
            // 
            // label2
            // 
            label2.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(490, 53);
            label2.Name = "label2";
            label2.Size = new Size(201, 32);
            label2.TabIndex = 2;
            label2.Text = "Minhas notas";
            // 
            // tbxNota
            // 
            tbxNota.BackColor = SystemColors.ControlLightLight;
            tbxNota.BorderStyle = BorderStyle.FixedSingle;
            tbxNota.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxNota.ForeColor = SystemColors.InfoText;
            tbxNota.Location = new Point(112, 91);
            tbxNota.Multiline = true;
            tbxNota.Name = "tbxNota";
            tbxNota.ScrollBars = ScrollBars.Horizontal;
            tbxNota.Size = new Size(333, 290);
            tbxNota.TabIndex = 3;
            // 
            // lbxNotas
            // 
            lbxNotas.BackColor = SystemColors.ControlLightLight;
            lbxNotas.BorderStyle = BorderStyle.FixedSingle;
            lbxNotas.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxNotas.ForeColor = Color.Black;
            lbxNotas.FormattingEnabled = true;
            lbxNotas.Location = new Point(490, 91);
            lbxNotas.Name = "lbxNotas";
            lbxNotas.Size = new Size(503, 290);
            lbxNotas.TabIndex = 4;
            lbxNotas.Click += lbxNotas_Click;
            lbxNotas.DoubleClick += lbxNotas_DoubleClick;
            // 
            // btnExcluirNota
            // 
            btnExcluirNota.BackColor = Color.IndianRed;
            btnExcluirNota.Enabled = false;
            btnExcluirNota.FlatAppearance.BorderColor = Color.White;
            btnExcluirNota.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExcluirNota.Location = new Point(865, 399);
            btnExcluirNota.Name = "btnExcluirNota";
            btnExcluirNota.Size = new Size(128, 42);
            btnExcluirNota.TabIndex = 6;
            btnExcluirNota.Text = "Excluir";
            btnExcluirNota.UseVisualStyleBackColor = false;
            btnExcluirNota.Click += btnExcluirNota_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1085, 489);
            Controls.Add(btnExcluirNota);
            Controls.Add(lbxNotas);
            Controls.Add(tbxNota);
            Controls.Add(label2);
            Controls.Add(lblNovaNota);
            Controls.Add(btnSalvarNota);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RabiscaForm";
            Text = "RabiscaForm";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button btnSalvarNota;
        private Label lblNovaNota;
        private Label label2;
        private TextBox tbxNota;
        private ListBox lbxNotas;
        private Button btnExcluirNota;
    }
}
