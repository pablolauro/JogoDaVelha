
namespace JogoDaVelha
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
            this.btnC1L1 = new System.Windows.Forms.Button();
            this.btnC1L2 = new System.Windows.Forms.Button();
            this.btnC1L3 = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnRecomeca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVez = new System.Windows.Forms.Label();
            this.lblVencedor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnC2L3 = new System.Windows.Forms.Button();
            this.btnC2L2 = new System.Windows.Forms.Button();
            this.btnC2L1 = new System.Windows.Forms.Button();
            this.btnC3L3 = new System.Windows.Forms.Button();
            this.btnC3L2 = new System.Windows.Forms.Button();
            this.btnC3L1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnC1L1
            // 
            this.btnC1L1.Enabled = false;
            this.btnC1L1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnC1L1.Location = new System.Drawing.Point(175, 80);
            this.btnC1L1.Name = "btnC1L1";
            this.btnC1L1.Size = new System.Drawing.Size(50, 51);
            this.btnC1L1.TabIndex = 0;
            this.btnC1L1.UseVisualStyleBackColor = true;
            this.btnC1L1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnC1L2
            // 
            this.btnC1L2.Enabled = false;
            this.btnC1L2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnC1L2.Location = new System.Drawing.Point(175, 137);
            this.btnC1L2.Name = "btnC1L2";
            this.btnC1L2.Size = new System.Drawing.Size(50, 51);
            this.btnC1L2.TabIndex = 3;
            this.btnC1L2.UseVisualStyleBackColor = true;
            this.btnC1L2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnC1L3
            // 
            this.btnC1L3.Enabled = false;
            this.btnC1L3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnC1L3.Location = new System.Drawing.Point(175, 194);
            this.btnC1L3.Name = "btnC1L3";
            this.btnC1L3.Size = new System.Drawing.Size(50, 51);
            this.btnC1L3.TabIndex = 6;
            this.btnC1L3.UseVisualStyleBackColor = true;
            this.btnC1L3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(12, 12);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(90, 28);
            this.btnX.TabIndex = 9;
            this.btnX.Text = "X começa";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnO
            // 
            this.btnO.Location = new System.Drawing.Point(12, 46);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(90, 28);
            this.btnO.TabIndex = 10;
            this.btnO.Text = "O começa";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // btnRecomeca
            // 
            this.btnRecomeca.Location = new System.Drawing.Point(12, 80);
            this.btnRecomeca.Name = "btnRecomeca";
            this.btnRecomeca.Size = new System.Drawing.Size(90, 28);
            this.btnRecomeca.TabIndex = 11;
            this.btnRecomeca.Text = "Recomeçar";
            this.btnRecomeca.UseVisualStyleBackColor = true;
            this.btnRecomeca.Click += new System.EventHandler(this.btnRecomeca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(175, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Vez do:";
            // 
            // lblVez
            // 
            this.lblVez.AutoSize = true;
            this.lblVez.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVez.Location = new System.Drawing.Point(287, 19);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(22, 30);
            this.lblVez.TabIndex = 13;
            this.lblVez.Text = "-";
            // 
            // lblVencedor
            // 
            this.lblVencedor.AutoSize = true;
            this.lblVencedor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVencedor.Location = new System.Drawing.Point(369, 286);
            this.lblVencedor.Name = "lblVencedor";
            this.lblVencedor.Size = new System.Drawing.Size(22, 30);
            this.lblVencedor.TabIndex = 15;
            this.lblVencedor.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(175, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "O vencedor é o:";
            // 
            // btnC2L3
            // 
            this.btnC2L3.Enabled = false;
            this.btnC2L3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnC2L3.Location = new System.Drawing.Point(231, 194);
            this.btnC2L3.Name = "btnC2L3";
            this.btnC2L3.Size = new System.Drawing.Size(50, 51);
            this.btnC2L3.TabIndex = 18;
            this.btnC2L3.UseVisualStyleBackColor = true;
            this.btnC2L3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnC2L2
            // 
            this.btnC2L2.Enabled = false;
            this.btnC2L2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnC2L2.Location = new System.Drawing.Point(231, 137);
            this.btnC2L2.Name = "btnC2L2";
            this.btnC2L2.Size = new System.Drawing.Size(50, 51);
            this.btnC2L2.TabIndex = 17;
            this.btnC2L2.UseVisualStyleBackColor = true;
            this.btnC2L2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnC2L1
            // 
            this.btnC2L1.Enabled = false;
            this.btnC2L1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnC2L1.Location = new System.Drawing.Point(231, 80);
            this.btnC2L1.Name = "btnC2L1";
            this.btnC2L1.Size = new System.Drawing.Size(50, 51);
            this.btnC2L1.TabIndex = 16;
            this.btnC2L1.UseVisualStyleBackColor = true;
            this.btnC2L1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnC3L3
            // 
            this.btnC3L3.Enabled = false;
            this.btnC3L3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnC3L3.Location = new System.Drawing.Point(289, 194);
            this.btnC3L3.Name = "btnC3L3";
            this.btnC3L3.Size = new System.Drawing.Size(50, 51);
            this.btnC3L3.TabIndex = 21;
            this.btnC3L3.UseVisualStyleBackColor = true;
            this.btnC3L3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnC3L2
            // 
            this.btnC3L2.Enabled = false;
            this.btnC3L2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnC3L2.Location = new System.Drawing.Point(289, 137);
            this.btnC3L2.Name = "btnC3L2";
            this.btnC3L2.Size = new System.Drawing.Size(50, 51);
            this.btnC3L2.TabIndex = 20;
            this.btnC3L2.UseVisualStyleBackColor = true;
            this.btnC3L2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnC3L1
            // 
            this.btnC3L1.Enabled = false;
            this.btnC3L1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnC3L1.Location = new System.Drawing.Point(287, 80);
            this.btnC3L1.Name = "btnC3L1";
            this.btnC3L1.Size = new System.Drawing.Size(50, 51);
            this.btnC3L1.TabIndex = 19;
            this.btnC3L1.UseVisualStyleBackColor = true;
            this.btnC3L1.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnC3L3);
            this.Controls.Add(this.btnC3L2);
            this.Controls.Add(this.btnC3L1);
            this.Controls.Add(this.btnC2L3);
            this.Controls.Add(this.btnC2L2);
            this.Controls.Add(this.btnC2L1);
            this.Controls.Add(this.lblVencedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblVez);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRecomeca);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnC1L3);
            this.Controls.Add(this.btnC1L2);
            this.Controls.Add(this.btnC1L1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnC1L1;
        private System.Windows.Forms.Button btnC1L2;
        private System.Windows.Forms.Button btnC1L3;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnRecomeca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVez;
        private System.Windows.Forms.Label lblVencedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnC2L3;
        private System.Windows.Forms.Button btnC2L2;
        private System.Windows.Forms.Button btnC2L1;
        private System.Windows.Forms.Button btnC3L3;
        private System.Windows.Forms.Button btnC3L2;
        private System.Windows.Forms.Button btnC3L1;
    }
}

