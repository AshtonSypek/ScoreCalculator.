namespace SimpleCalculator

    //Name: Ashton and Blake
    //Date: 12/5/23
    //Assignment name:SimpleCalculator Proposal
{


    public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void btnCalculator_Click(object sender, EventArgs e)
            {
                try
                {
                    if (!IsValidData())
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
                        string operator1 = txtOperator.Text;
                        decimal operand2 = Convert.ToDecimal(txtOperand2.Text);

                        decimal result = 0;
                        if (operator1 == "+")
                            result = operand1 + operand2;
                        else if (operator1 == "-")
                            result = operand1 - operand2;
                        else if (operator1 == "*")
                            result = operand1 * operand2;
                        else if (operator1 == "/")
                            result = operand1 / operand2;

                        result = Math.Round(result, 4);
                        txtResult.Text = result.ToString();
                        txtOperand1.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
                }
            }

            public bool IsValidData()
            {
                return
                 IsPresent(txtOperand1, "Operand 1") &&
                 IsDecimal(txtOperand1, "Operand 1") &&
                 IsWithinRange(txtOperand1, "Operand 1", 0, 1000000) &&

                 IsPresent(txtOperator, "Operator") &&
                 IsOperator(txtOperator, "Operator") &&

                 IsPresent(txtOperand2, "Operand 2") &&
                 IsDecimal(txtOperand2, "Operand 2") &&
                 IsWithinRange(txtOperand2, "Operand 2", 0, 1000000);
            }

            private void btnExit_Click(object sender, System.EventArgs e)
            {
                this.Close();
            }

            public bool IsPresent(TextBox textBox, string name)
            {
                if (textBox.Text == "")
                {
                    MessageBox.Show(name + " is a required field.", "Entry Error");
                    textBox.Focus();
                    return false;
                }
                return true;
            }

            public bool IsDecimal(TextBox textBox, string name)
            {
                decimal number = 0m;

                if (Decimal.TryParse(textBox.Text, out number))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                    textBox.Focus();
                    return false;
                }
            }

            public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
            {
                decimal number = Convert.ToDecimal(textBox.Text);
                if (number < min || number > max)
                {
                    MessageBox.Show(name + " must be between " + min.ToString()
                        + " and " + max.ToString() + ".", "Entry Error");
                    textBox.Focus();
                    return false;
                }
                return true;
            }

            public bool IsOperator(TextBox textBox, string name)
            {
                string operator1 = "";
                operator1 = Convert.ToString(textBox.Text);
                if (operator1 != "+" && operator1 != "-" && operator1 != "/" && operator1 != "*")
                {
                    MessageBox.Show("Please enter a valid operator in the operator text box.", "Entry Error");
                    return false;
                }
                return true;
            }

            private void txtOperand1_TextChanged(object sender, EventArgs e)
            {
                this.txtResult.Text = "";
            }

            private void txtOperator_TextChanged(object sender, EventArgs e)
            {
                this.txtResult.Text = "";
            }
        }
    }
