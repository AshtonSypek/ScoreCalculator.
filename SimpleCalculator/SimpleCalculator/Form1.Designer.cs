
namespace SimpleCalculator
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
            btnCalculate = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtOperand1 = new TextBox();
            txtOperator = new TextBox();
            txtOperand2 = new TextBox();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(12, 176);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "&Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            btnCalculate.Enter += btnCalculate_Click;
            btnCalculate.KeyDown += btnCalculate_KeyDown;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(147, 176);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            btnExit.Leave += btnExit_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = "Operand 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Operator:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 4;
            label3.Text = "Operand 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 140);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 5;
            label4.Text = "Result:";
            // 
            // txtOperand1
            // 
            txtOperand1.Location = new Point(122, 20);
            txtOperand1.Name = "txtOperand1";
            txtOperand1.Size = new Size(100, 23);
            txtOperand1.TabIndex = 6;
            // 
            // txtOperator
            // 
            txtOperator.Location = new Point(122, 60);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(100, 23);
            txtOperator.TabIndex = 7;
            // 
            // txtOperand2
            // 
            txtOperand2.Location = new Point(122, 100);
            txtOperand2.Name = "txtOperand2";
            txtOperand2.Size = new Size(100, 23);
            txtOperand2.TabIndex = 8;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(122, 140);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 9;
            txtResult.TextChanged += txtResult_TextChanged;
            txtResult.KeyDown += txtResult_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 211);
            Controls.Add(txtResult);
            Controls.Add(txtOperand2);
            Controls.Add(txtOperator);
            Controls.Add(txtOperand1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtResult_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnCalculate_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Button btnCalculate;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtOperand1;
        private TextBox txtOperator;
        private TextBox txtOperand2;
        private TextBox txtResult;
    }
}
