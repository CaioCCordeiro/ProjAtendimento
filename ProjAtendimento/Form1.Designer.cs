namespace ProjAtendimento
{
    partial class Form1
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
            this.listBoxSenha = new System.Windows.Forms.ListBox();
            this.buttonGerar = new System.Windows.Forms.Button();
            this.buttonListarSenhas = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonListarAtendimentos = new System.Windows.Forms.Button();
            this.buttonChamar = new System.Windows.Forms.Button();
            this.listBoxChamar = new System.Windows.Forms.ListBox();
            this.textBoxChamar = new System.Windows.Forms.TextBox();
            this.labelQtd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGuiche = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listsenha
            // 
            this.listBoxSenha.FormattingEnabled = true;
            this.listBoxSenha.Location = new System.Drawing.Point(11, 49);
            this.listBoxSenha.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSenha.Name = "listsenha";
            this.listBoxSenha.Size = new System.Drawing.Size(190, 95);
            this.listBoxSenha.TabIndex = 0;
            // 
            // buttonGerar
            // 
            this.buttonGerar.Location = new System.Drawing.Point(75, 17);
            this.buttonGerar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(57, 27);
            this.buttonGerar.TabIndex = 1;
            this.buttonGerar.Text = "Gerar";
            this.buttonGerar.UseVisualStyleBackColor = true;
            this.buttonGerar.Click += new System.EventHandler(this.buttonGerar_Click);
            // 
            // buttonListarSenhas
            // 
            this.buttonListarSenhas.Location = new System.Drawing.Point(51, 152);
            this.buttonListarSenhas.Margin = new System.Windows.Forms.Padding(2);
            this.buttonListarSenhas.Name = "buttonListarSenhas";
            this.buttonListarSenhas.Size = new System.Drawing.Size(98, 28);
            this.buttonListarSenhas.TabIndex = 2;
            this.buttonListarSenhas.Text = "Listar senhas";
            this.buttonListarSenhas.UseVisualStyleBackColor = true;
            this.buttonListarSenhas.Click += new System.EventHandler(this.buttonListarSenhas_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(220, 122);
            this.buttonAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(68, 32);
            this.buttonAdicionar.TabIndex = 3;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonListarAtendimentos
            // 
            this.buttonListarAtendimentos.Location = new System.Drawing.Point(343, 152);
            this.buttonListarAtendimentos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonListarAtendimentos.Name = "buttonListarAtendimentos";
            this.buttonListarAtendimentos.Size = new System.Drawing.Size(180, 28);
            this.buttonListarAtendimentos.TabIndex = 4;
            this.buttonListarAtendimentos.Text = "Listar Atendimentos";
            this.buttonListarAtendimentos.UseVisualStyleBackColor = true;
            this.buttonListarAtendimentos.Click += new System.EventHandler(this.buttonListarAtendimentos_Click);
            // 
            // buttonChamar
            // 
            this.buttonChamar.Location = new System.Drawing.Point(431, 13);
            this.buttonChamar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChamar.Name = "buttonChamar";
            this.buttonChamar.Size = new System.Drawing.Size(71, 26);
            this.buttonChamar.TabIndex = 5;
            this.buttonChamar.Text = "Chamar";
            this.buttonChamar.UseVisualStyleBackColor = true;
            this.buttonChamar.Click += new System.EventHandler(this.buttonChamar_Click);
            // 
            // listchamar
            // 
            this.listBoxChamar.FormattingEnabled = true;
            this.listBoxChamar.Location = new System.Drawing.Point(306, 49);
            this.listBoxChamar.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxChamar.Name = "listchamar";
            this.listBoxChamar.Size = new System.Drawing.Size(258, 95);
            this.listBoxChamar.TabIndex = 6;
            // 
            // txtchamar
            // 
            this.textBoxChamar.Location = new System.Drawing.Point(368, 17);
            this.textBoxChamar.Name = "txtchamar";
            this.textBoxChamar.Size = new System.Drawing.Size(58, 20);
            this.textBoxChamar.TabIndex = 7;
            // 
            // lblQtd
            // 
            this.labelQtd.AutoSize = true;
            this.labelQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtd.Location = new System.Drawing.Point(238, 73);
            this.labelQtd.Name = "lblQtd";
            this.labelQtd.Size = new System.Drawing.Size(26, 29);
            this.labelQtd.TabIndex = 8;
            this.labelQtd.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Qtde guichês";
            // 
            // labelGuiche
            // 
            this.labelGuiche.AutoSize = true;
            this.labelGuiche.Location = new System.Drawing.Point(318, 20);
            this.labelGuiche.Name = "labelGuiche";
            this.labelGuiche.Size = new System.Drawing.Size(44, 13);
            this.labelGuiche.TabIndex = 10;
            this.labelGuiche.Text = "Guichê:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 207);
            this.Controls.Add(this.labelGuiche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelQtd);
            this.Controls.Add(this.textBoxChamar);
            this.Controls.Add(this.listBoxChamar);
            this.Controls.Add(this.buttonChamar);
            this.Controls.Add(this.buttonListarAtendimentos);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.buttonListarSenhas);
            this.Controls.Add(this.buttonGerar);
            this.Controls.Add(this.listBoxSenha);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSenha;
        private System.Windows.Forms.Button buttonGerar;
        private System.Windows.Forms.Button buttonListarSenhas;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonListarAtendimentos;
        private System.Windows.Forms.Button buttonChamar;
        private System.Windows.Forms.ListBox listBoxChamar;
        private System.Windows.Forms.TextBox textBoxChamar;
        private System.Windows.Forms.Label labelQtd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGuiche;
    }
}

