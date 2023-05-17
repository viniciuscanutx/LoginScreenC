
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.Deslogar = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Deslogar
            // 
            this.Deslogar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Deslogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deslogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deslogar.ForeColor = System.Drawing.SystemColors.Control;
            this.Deslogar.Location = new System.Drawing.Point(109, 181);
            this.Deslogar.Name = "Deslogar";
            this.Deslogar.Size = new System.Drawing.Size(75, 23);
            this.Deslogar.TabIndex = 1;
            this.Deslogar.Text = "Deslogar";
            this.Deslogar.UseVisualStyleBackColor = false;
            this.Deslogar.Click += new System.EventHandler(this.Deslogar_Click);
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.ForeColor = System.Drawing.SystemColors.Control;
            this.Sair.Location = new System.Drawing.Point(209, 12);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(75, 23);
            this.Sair.TabIndex = 2;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bem vindo!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(296, 216);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Deslogar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Deslogar;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Label label1;
    }
}