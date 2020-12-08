
namespace Consultorio_Medico
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.btnentrar = new System.Windows.Forms.Button();
            this.txtlogin = new ZBobb.AlphaBlendTextBox();
            this.txtsenha = new ZBobb.AlphaBlendTextBox();
            this.SuspendLayout();
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.Color.Transparent;
            this.btnentrar.BackgroundImage = global::Consultorio_Medico.Properties.Resources.Login;
            this.btnentrar.FlatAppearance.BorderSize = 0;
            this.btnentrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnentrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnentrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnentrar.Location = new System.Drawing.Point(184, 323);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(99, 29);
            this.btnentrar.TabIndex = 4;
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // txtlogin
            // 
            this.txtlogin.BackAlpha = 10;
            this.txtlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtlogin.Location = new System.Drawing.Point(155, 240);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(179, 20);
            this.txtlogin.TabIndex = 6;
            // 
            // txtsenha
            // 
            this.txtsenha.BackAlpha = 10;
            this.txtsenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtsenha.Location = new System.Drawing.Point(155, 274);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(179, 20);
            this.txtsenha.TabIndex = 7;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Consultorio_Medico.Properties.Resources.Login_Pedrinho2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.btnentrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultorio Medico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnentrar;
        private ZBobb.AlphaBlendTextBox txtlogin;
        private ZBobb.AlphaBlendTextBox txtsenha;
    }
}