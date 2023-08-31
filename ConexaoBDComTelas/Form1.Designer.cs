namespace ConexaoBDComTelas
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
            groupBox1 = new GroupBox();
            btnSalvar = new Button();
            cboxConcluido = new CheckBox();
            txtTarefa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPesquisa = new TextBox();
            btnPesquisa = new Button();
            listTarefas = new ListView();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(cboxConcluido);
            groupBox1.Controls.Add(txtTarefa);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(147, 182);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(31, 117);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 29);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cboxConcluido
            // 
            cboxConcluido.AutoSize = true;
            cboxConcluido.Location = new Point(6, 81);
            cboxConcluido.Name = "cboxConcluido";
            cboxConcluido.Size = new Size(81, 19);
            cboxConcluido.TabIndex = 1;
            cboxConcluido.Text = "Concluído";
            cboxConcluido.UseVisualStyleBackColor = true;
            // 
            // txtTarefa
            // 
            txtTarefa.Location = new Point(6, 37);
            txtTarefa.Name = "txtTarefa";
            txtTarefa.Size = new Size(126, 23);
            txtTarefa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Descrição da tarefa: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 31);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 2;
            label2.Text = "Pesquisar uma tarefa:";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(226, 49);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(126, 23);
            txtPesquisa.TabIndex = 2;
            // 
            // btnPesquisa
            // 
            btnPesquisa.Location = new Point(420, 48);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(88, 23);
            btnPesquisa.TabIndex = 2;
            btnPesquisa.Text = "Pesquisar";
            btnPesquisa.UseVisualStyleBackColor = true;
            // 
            // listTarefas
            // 
            listTarefas.Location = new Point(225, 78);
            listTarefas.Name = "listTarefas";
            listTarefas.Size = new Size(283, 168);
            listTarefas.TabIndex = 3;
            listTarefas.UseCompatibleStateImageBehavior = false;
            listTarefas.View = View.List;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 308);
            Controls.Add(listTarefas);
            Controls.Add(btnPesquisa);
            Controls.Add(txtPesquisa);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSalvar;
        private CheckBox cboxConcluido;
        private TextBox txtTarefa;
        private Label label1;
        private Label label2;
        private TextBox txtPesquisa;
        private Button btnPesquisa;
        private ListView listTarefas;
    }
}