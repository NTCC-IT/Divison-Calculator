namespace Calculator_App
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
            this.outputBox1 = new System.Windows.Forms.TextBox();
            this.outputBox2 = new System.Windows.Forms.TextBox();
            this.labelDivisonSymbol = new System.Windows.Forms.Label();
            this.labelEqualSign = new System.Windows.Forms.Label();
            this.labelCalculator = new System.Windows.Forms.Label();
            this.labelDivison = new System.Windows.Forms.Label();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputBox1
            // 
            this.outputBox1.Location = new System.Drawing.Point(2, 103);
            this.outputBox1.Name = "outputBox1";
            this.outputBox1.Size = new System.Drawing.Size(119, 20);
            this.outputBox1.TabIndex = 0;
            // 
            // outputBox2
            // 
            this.outputBox2.Location = new System.Drawing.Point(186, 103);
            this.outputBox2.Name = "outputBox2";
            this.outputBox2.Size = new System.Drawing.Size(119, 20);
            this.outputBox2.TabIndex = 1;
            // 
            // labelDivisonSymbol
            // 
            this.labelDivisonSymbol.AutoSize = true;
            this.labelDivisonSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDivisonSymbol.Location = new System.Drawing.Point(139, 103);
            this.labelDivisonSymbol.Name = "labelDivisonSymbol";
            this.labelDivisonSymbol.Size = new System.Drawing.Size(30, 31);
            this.labelDivisonSymbol.TabIndex = 2;
            this.labelDivisonSymbol.Text = "÷";
            // 
            // labelEqualSign
            // 
            this.labelEqualSign.AutoSize = true;
            this.labelEqualSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEqualSign.Location = new System.Drawing.Point(334, 103);
            this.labelEqualSign.Name = "labelEqualSign";
            this.labelEqualSign.Size = new System.Drawing.Size(30, 31);
            this.labelEqualSign.TabIndex = 3;
            this.labelEqualSign.Text = "=";
            // 
            // labelCalculator
            // 
            this.labelCalculator.AutoSize = true;
            this.labelCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalculator.Location = new System.Drawing.Point(180, 49);
            this.labelCalculator.Name = "labelCalculator";
            this.labelCalculator.Size = new System.Drawing.Size(137, 31);
            this.labelCalculator.TabIndex = 5;
            this.labelCalculator.Text = "Calculator";
            // 
            // labelDivison
            // 
            this.labelDivison.AutoSize = true;
            this.labelDivison.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDivison.Location = new System.Drawing.Point(12, 49);
            this.labelDivison.Name = "labelDivison";
            this.labelDivison.Size = new System.Drawing.Size(104, 31);
            this.labelDivison.TabIndex = 6;
            this.labelDivison.Text = "Divison";
            // 
            // button_Calculate
            // 
            this.button_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calculate.Location = new System.Drawing.Point(69, 137);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(165, 51);
            this.button_Calculate.TabIndex = 8;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(379, 103);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 31);
            this.labelResult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 222);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.button_Calculate);
            this.Controls.Add(this.labelDivison);
            this.Controls.Add(this.labelCalculator);
            this.Controls.Add(this.labelEqualSign);
            this.Controls.Add(this.labelDivisonSymbol);
            this.Controls.Add(this.outputBox2);
            this.Controls.Add(this.outputBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputBox1;
        private System.Windows.Forms.TextBox outputBox2;
        private System.Windows.Forms.Label labelDivisonSymbol;
        private System.Windows.Forms.Label labelEqualSign;
        private System.Windows.Forms.Label labelCalculator;
        private System.Windows.Forms.Label labelDivison;
        private System.Windows.Forms.Button button_Calculate;
        private System.Windows.Forms.Label labelResult;
    }
}

