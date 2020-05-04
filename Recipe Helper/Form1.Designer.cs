namespace Recipe_Helper
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
            this.btnFahrenheit = new System.Windows.Forms.Button();
            this.btnCups = new System.Windows.Forms.Button();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtMilliliters = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCups = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.Location = new System.Drawing.Point(78, 95);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(143, 66);
            this.btnFahrenheit.TabIndex = 0;
            this.btnFahrenheit.Text = "Convert to Fahrenheit";
            this.btnFahrenheit.UseVisualStyleBackColor = true;
            this.btnFahrenheit.Click += new System.EventHandler(this.btnFahrenheit_Click);
            // 
            // btnCups
            // 
            this.btnCups.Location = new System.Drawing.Point(340, 95);
            this.btnCups.Name = "btnCups";
            this.btnCups.Size = new System.Drawing.Size(144, 66);
            this.btnCups.TabIndex = 1;
            this.btnCups.Text = "Convert to Cups";
            this.btnCups.UseVisualStyleBackColor = true;
            this.btnCups.Click += new System.EventHandler(this.btnCups_Click);
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(151, 34);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 31);
            this.txtCelsius.TabIndex = 2;
            // 
            // txtMillilitres
            // 
            this.txtMilliliters.Location = new System.Drawing.Point(412, 31);
            this.txtMilliliters.Name = "txtMillilitres";
            this.txtMilliliters.Size = new System.Drawing.Size(100, 31);
            this.txtMilliliters.TabIndex = 3;
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(151, 186);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.ReadOnly = true;
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 31);
            this.txtFahrenheit.TabIndex = 4;
            // 
            // txtCups
            // 
            this.txtCups.Location = new System.Drawing.Point(412, 180);
            this.txtCups.Name = "txtCups";
            this.txtCups.ReadOnly = true;
            this.txtCups.Size = new System.Drawing.Size(100, 31);
            this.txtCups.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fahrenheit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cups";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Millilitres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 248);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCups);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtMilliliters);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.btnCups);
            this.Controls.Add(this.btnFahrenheit);
            this.Name = "Form1";
            this.Text = "Recipe Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFahrenheit;
        private System.Windows.Forms.Button btnCups;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtMilliliters;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.TextBox txtCups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

