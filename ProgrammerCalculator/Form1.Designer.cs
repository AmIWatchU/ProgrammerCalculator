
namespace ProgrammerCalculator
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
            this.textBox_Hex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Oct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Dec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Bin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Hex
            // 
            this.textBox_Hex.Location = new System.Drawing.Point(72, 9);
            this.textBox_Hex.Name = "textBox_Hex";
            this.textBox_Hex.Size = new System.Drawing.Size(225, 22);
            this.textBox_Hex.TabIndex = 0;
            this.textBox_Hex.TextChanged += new System.EventHandler(this.All_tb_TextChanged);
            this.textBox_Hex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.All_tb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Octane";
            // 
            // textBox_Oct
            // 
            this.textBox_Oct.Location = new System.Drawing.Point(72, 52);
            this.textBox_Oct.Name = "textBox_Oct";
            this.textBox_Oct.Size = new System.Drawing.Size(225, 22);
            this.textBox_Oct.TabIndex = 2;
            this.textBox_Oct.TextChanged += new System.EventHandler(this.All_tb_TextChanged);
            this.textBox_Oct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.All_tb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Decimal";
            // 
            // textBox_Dec
            // 
            this.textBox_Dec.Location = new System.Drawing.Point(72, 101);
            this.textBox_Dec.Name = "textBox_Dec";
            this.textBox_Dec.Size = new System.Drawing.Size(225, 22);
            this.textBox_Dec.TabIndex = 4;
            this.textBox_Dec.TextChanged += new System.EventHandler(this.All_tb_TextChanged);
            this.textBox_Dec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.All_tb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Binary";
            // 
            // textBox_Bin
            // 
            this.textBox_Bin.Location = new System.Drawing.Point(72, 148);
            this.textBox_Bin.Name = "textBox_Bin";
            this.textBox_Bin.Size = new System.Drawing.Size(225, 22);
            this.textBox_Bin.TabIndex = 6;
            this.textBox_Bin.TextChanged += new System.EventHandler(this.All_tb_TextChanged);
            this.textBox_Bin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.All_tb_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(320, 182);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Bin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Dec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Oct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Hex);
            this.Name = "Form1";
            this.Text = "Programmer Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Hex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Oct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Dec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Bin;
    }
}

