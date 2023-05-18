namespace new_calculator
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
            this.components = new System.ComponentModel.Container();
            this.txt_valueOne = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.txt_valueTwo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_subtraction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_valueOne
            // 
            this.txt_valueOne.Location = new System.Drawing.Point(294, 94);
            this.txt_valueOne.Name = "txt_valueOne";
            this.txt_valueOne.Size = new System.Drawing.Size(222, 26);
            this.txt_valueOne.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_answer
            // 
            this.txt_answer.Location = new System.Drawing.Point(294, 249);
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(222, 26);
            this.txt_answer.TabIndex = 4;
            // 
            // txt_valueTwo
            // 
            this.txt_valueTwo.Location = new System.Drawing.Point(294, 146);
            this.txt_valueTwo.Name = "txt_valueTwo";
            this.txt_valueTwo.Size = new System.Drawing.Size(222, 26);
            this.txt_valueTwo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ValueOne: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Answer: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "ValueTwo:";
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(294, 194);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(89, 32);
            this.btn_sum.TabIndex = 3;
            this.btn_sum.Text = "sum";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_subtraction
            // 
            this.btn_subtraction.Location = new System.Drawing.Point(427, 194);
            this.btn_subtraction.Name = "btn_subtraction";
            this.btn_subtraction.Size = new System.Drawing.Size(89, 32);
            this.btn_subtraction.TabIndex = 9;
            this.btn_subtraction.Text = "sub";
            this.btn_subtraction.UseVisualStyleBackColor = true;
            this.btn_subtraction.Click += new System.EventHandler(this.btn_subtraction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_subtraction);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_valueTwo);
            this.Controls.Add(this.txt_answer);
            this.Controls.Add(this.txt_valueOne);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_valueOne;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_answer;
        private System.Windows.Forms.TextBox txt_valueTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_subtraction;
    }
}

