namespace ProiectMTP
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCautare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnValidare = new System.Windows.Forms.Button();
            this.boxCautare = new System.Windows.Forms.TextBox();
            this.boxStergere = new System.Windows.Forms.TextBox();
            this.boxValidare1 = new System.Windows.Forms.TextBox();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.boxNewUtilizator = new System.Windows.Forms.TextBox();
            this.boxNewParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxValidare2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Cyan;
            this.dataGridView1.Location = new System.Drawing.Point(458, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(330, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCautare
            // 
            this.btnCautare.Location = new System.Drawing.Point(249, 45);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(113, 44);
            this.btnCautare.TabIndex = 1;
            this.btnCautare.Text = "Cautare";
            this.btnCautare.UseVisualStyleBackColor = true;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(249, 137);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(113, 46);
            this.btnStergere.TabIndex = 2;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnValidare
            // 
            this.btnValidare.Location = new System.Drawing.Point(249, 216);
            this.btnValidare.Name = "btnValidare";
            this.btnValidare.Size = new System.Drawing.Size(113, 46);
            this.btnValidare.TabIndex = 3;
            this.btnValidare.Text = "Validare";
            this.btnValidare.UseVisualStyleBackColor = true;
            this.btnValidare.Click += new System.EventHandler(this.btnValidare_Click);
            // 
            // boxCautare
            // 
            this.boxCautare.Location = new System.Drawing.Point(97, 58);
            this.boxCautare.Name = "boxCautare";
            this.boxCautare.Size = new System.Drawing.Size(114, 20);
            this.boxCautare.TabIndex = 4;
            // 
            // boxStergere
            // 
            this.boxStergere.Location = new System.Drawing.Point(97, 151);
            this.boxStergere.Name = "boxStergere";
            this.boxStergere.Size = new System.Drawing.Size(114, 20);
            this.boxStergere.TabIndex = 5;
            // 
            // boxValidare1
            // 
            this.boxValidare1.Location = new System.Drawing.Point(97, 216);
            this.boxValidare1.Name = "boxValidare1";
            this.boxValidare1.Size = new System.Drawing.Size(114, 20);
            this.boxValidare1.TabIndex = 6;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(249, 343);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(113, 46);
            this.btnAdaugare.TabIndex = 7;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // boxNewUtilizator
            // 
            this.boxNewUtilizator.Location = new System.Drawing.Point(97, 343);
            this.boxNewUtilizator.Name = "boxNewUtilizator";
            this.boxNewUtilizator.Size = new System.Drawing.Size(114, 20);
            this.boxNewUtilizator.TabIndex = 8;
            // 
            // boxNewParola
            // 
            this.boxNewParola.Location = new System.Drawing.Point(97, 369);
            this.boxNewParola.Name = "boxNewParola";
            this.boxNewParola.PasswordChar = '#';
            this.boxNewParola.Size = new System.Drawing.Size(114, 20);
            this.boxNewParola.TabIndex = 9;
            this.boxNewParola.TextChanged += new System.EventHandler(this.boxNewParola_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adaugare Utilizator";
            // 
            // boxValidare2
            // 
            this.boxValidare2.Location = new System.Drawing.Point(97, 242);
            this.boxValidare2.Name = "boxValidare2";
            this.boxValidare2.Size = new System.Drawing.Size(114, 20);
            this.boxValidare2.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxValidare2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxNewParola);
            this.Controls.Add(this.boxNewUtilizator);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.boxValidare1);
            this.Controls.Add(this.boxStergere);
            this.Controls.Add(this.boxCautare);
            this.Controls.Add(this.btnValidare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnValidare;
        private System.Windows.Forms.TextBox boxCautare;
        private System.Windows.Forms.TextBox boxStergere;
        private System.Windows.Forms.TextBox boxValidare1;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.TextBox boxNewUtilizator;
        private System.Windows.Forms.TextBox boxNewParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxValidare2;
    }
}