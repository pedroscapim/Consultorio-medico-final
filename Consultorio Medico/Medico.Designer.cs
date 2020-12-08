
namespace Consultorio_Medico
{
    partial class Medico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medico));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.ID_Med = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.txtcrm = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.txtespecialidade = new System.Windows.Forms.TextBox();
            this.btnINSERIR = new System.Windows.Forms.Button();
            this.btnALTERAR = new System.Windows.Forms.Button();
            this.btnEXCLUIR = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CRM:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Especialidade:";
            // 
            // grid1
            // 
            this.grid1.AllowUserToAddRows = false;
            this.grid1.AllowUserToDeleteRows = false;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Med,
            this.Nome,
            this.Idade,
            this.CRM,
            this.CPF,
            this.Especialidade});
            this.grid1.Location = new System.Drawing.Point(17, 200);
            this.grid1.Name = "grid1";
            this.grid1.ReadOnly = true;
            this.grid1.Size = new System.Drawing.Size(399, 238);
            this.grid1.TabIndex = 5;
            this.grid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid1_CellContentClick);
            // 
            // ID_Med
            // 
            this.ID_Med.DataPropertyName = "id";
            this.ID_Med.HeaderText = "ID_Med";
            this.ID_Med.Name = "ID_Med";
            this.ID_Med.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Idade
            // 
            this.Idade.DataPropertyName = "Idade";
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            // 
            // CRM
            // 
            this.CRM.DataPropertyName = "CRM";
            this.CRM.HeaderText = "CRM";
            this.CRM.Name = "CRM";
            this.CRM.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Especialidade
            // 
            this.Especialidade.DataPropertyName = "Especialidade";
            this.Especialidade.HeaderText = "Especialidade";
            this.Especialidade.Name = "Especialidade";
            this.Especialidade.ReadOnly = true;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(82, 27);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(323, 20);
            this.txtnome.TabIndex = 6;
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(82, 54);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(53, 20);
            this.txtidade.TabIndex = 7;
            // 
            // txtcrm
            // 
            this.txtcrm.Location = new System.Drawing.Point(179, 53);
            this.txtcrm.Name = "txtcrm";
            this.txtcrm.Size = new System.Drawing.Size(226, 20);
            this.txtcrm.TabIndex = 8;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(82, 86);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(323, 20);
            this.txtcpf.TabIndex = 9;
            // 
            // txtespecialidade
            // 
            this.txtespecialidade.Location = new System.Drawing.Point(82, 115);
            this.txtespecialidade.Name = "txtespecialidade";
            this.txtespecialidade.Size = new System.Drawing.Size(323, 20);
            this.txtespecialidade.TabIndex = 10;
            // 
            // btnINSERIR
            // 
            this.btnINSERIR.BackgroundImage = global::Consultorio_Medico.Properties.Resources.adduser_añadir_3553;
            this.btnINSERIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnINSERIR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnINSERIR.Location = new System.Drawing.Point(107, 141);
            this.btnINSERIR.Name = "btnINSERIR";
            this.btnINSERIR.Size = new System.Drawing.Size(47, 39);
            this.btnINSERIR.TabIndex = 13;
            this.btnINSERIR.UseVisualStyleBackColor = true;
            this.btnINSERIR.Click += new System.EventHandler(this.btnINSERIR_Click);
            // 
            // btnALTERAR
            // 
            this.btnALTERAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnALTERAR.BackgroundImage = global::Consultorio_Medico.Properties.Resources.Change_User_icon_icons_com_55946;
            this.btnALTERAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnALTERAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnALTERAR.Location = new System.Drawing.Point(197, 141);
            this.btnALTERAR.Name = "btnALTERAR";
            this.btnALTERAR.Size = new System.Drawing.Size(47, 39);
            this.btnALTERAR.TabIndex = 12;
            this.btnALTERAR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnALTERAR.UseVisualStyleBackColor = false;
            this.btnALTERAR.Click += new System.EventHandler(this.btnALTERAR_Click);
            // 
            // btnEXCLUIR
            // 
            this.btnEXCLUIR.BackgroundImage = global::Consultorio_Medico.Properties.Resources.delete_4219;
            this.btnEXCLUIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEXCLUIR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEXCLUIR.Location = new System.Drawing.Point(285, 141);
            this.btnEXCLUIR.Name = "btnEXCLUIR";
            this.btnEXCLUIR.Size = new System.Drawing.Size(47, 39);
            this.btnEXCLUIR.TabIndex = 11;
            this.btnEXCLUIR.UseVisualStyleBackColor = true;
            this.btnEXCLUIR.Click += new System.EventHandler(this.btnEXCLUIR_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(82, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(56, 20);
            this.txtID.TabIndex = 14;
            this.txtID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.btnALTERAR);
            this.groupBox1.Controls.Add(this.btnINSERIR);
            this.groupBox1.Controls.Add(this.txtespecialidade);
            this.groupBox1.Controls.Add(this.txtcpf);
            this.groupBox1.Controls.Add(this.btnEXCLUIR);
            this.groupBox1.Controls.Add(this.txtcrm);
            this.groupBox1.Controls.Add(this.txtidade);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 190);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Medico";
            this.Text = "Registro dos Medicos";
            this.Load += new System.EventHandler(this.Medico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.TextBox txtcrm;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.TextBox txtespecialidade;
        private System.Windows.Forms.Button btnEXCLUIR;
        private System.Windows.Forms.Button btnALTERAR;
        private System.Windows.Forms.Button btnINSERIR;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Med;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidade;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}