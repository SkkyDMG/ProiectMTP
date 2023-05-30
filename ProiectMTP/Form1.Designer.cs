namespace ProiectMTP
{
    partial class LoginForm
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
            this.boxNume = new System.Windows.Forms.TextBox();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelParola = new System.Windows.Forms.Label();
            this.boxParola = new System.Windows.Forms.TextBox();
            this.btnAutentificare = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxNume
            // 
            this.boxNume.Location = new System.Drawing.Point(322, 115);
            this.boxNume.Name = "boxNume";
            this.boxNume.Size = new System.Drawing.Size(190, 20);
            this.boxNume.TabIndex = 0;
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(235, 122);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(81, 13);
            this.labelNume.TabIndex = 1;
            this.labelNume.Text = "Nume Utilizator:";
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelParola.Location = new System.Drawing.Point(276, 161);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(40, 13);
            this.labelParola.TabIndex = 2;
            this.labelParola.Text = "Parola:";
            // 
            // boxParola
            // 
            this.boxParola.Location = new System.Drawing.Point(322, 154);
            this.boxParola.Name = "boxParola";
            this.boxParola.PasswordChar = '#';
            this.boxParola.Size = new System.Drawing.Size(190, 20);
            this.boxParola.TabIndex = 3;
            // 
            // btnAutentificare
            // 
            this.btnAutentificare.Location = new System.Drawing.Point(310, 204);
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.Size = new System.Drawing.Size(218, 81);
            this.btnAutentificare.TabIndex = 4;
            this.btnAutentificare.Text = "Autentificare";
            this.btnAutentificare.UseVisualStyleBackColor = true;
            this.btnAutentificare.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Location = new System.Drawing.Point(360, 335);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 42);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAutentificare);
            this.Controls.Add(this.boxParola);
            this.Controls.Add(this.labelParola);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.boxNume);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxNume;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.TextBox boxParola;
        private System.Windows.Forms.Button btnAutentificare;
        private System.Windows.Forms.Button btnExit;
    }
}

