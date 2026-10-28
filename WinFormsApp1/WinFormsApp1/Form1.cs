namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double number1; // safe first number
        double number2; // safe second number
        string Operators; // safe the operators
        double ergebnis = 0;
        int operatorsInRow = 0; // How many times does this occur? because I need to know how many times operators are used before pressing "="
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)// pressing numbers Methode, when you press something write it as text in textbox(Ausgabe)
        {
            if (Ausgabe.Text == "0") {Ausgabe.Clear(); } // just dont want 0 on the left side of the number, because my textbox starts with a 0
            Button Button = (Button)sender; // to be able to access the text of sender which is the value of the buttons in this project
            Ausgabe.Text += Button.Text; // add the new numbers to the last
        }

        private void OperatorenClick(object sender, EventArgs e) // Operators Methode
        {
          if (Ausgabe.Text == "") { return; } // 
          operatorsInRow++; // increase this to know it is the first time

           if (operatorsInRow == 1) // if this is the first time you used operator
           {
                currentResult.Text = Convert.ToString( ergebnis);
                number1 = Convert.ToDouble(Ausgabe.Text); // safe the number that was written as first number
                Button button = (Button)sender;
                Operators = button.Text; // Safe the operator you made
                Ausgabe.Text = ""; // make textBox empty to be ready to write next numbers
                return;
           }


            if (operatorsInRow == 2) 
            {
               // Button button = (Button)sender;
                button17_Click(null,EventArgs.Empty); // calculate the first Operation at first
                //Operators = button.Text;
                OperatorenClick(sender, e);
            }
       
        
        
        
        }

        private void button17_Click(object sender, EventArgs e) // für (=) Click
        {
            number2 = Convert.ToDouble(Ausgabe.Text); // safe the new number in textBox 
            Ausgabe.Text = ""; // empty textbox

            switch (Operators)  // just make the right Operation according to the value of the variable Operators
            {
                case "+":
                    ergebnis = number1 + number2;
                    break;

                case "-":
                    ergebnis = number1 - number2;
                    break;
                case "*":
                    ergebnis = number1 * number2;
                    break;
                case "/":
                    ergebnis = number1 / number2;
                    break;

            }
            Ausgabe.Text = Convert.ToString(ergebnis); // write the result in textbox
            currentResult.Text = Convert.ToString(ergebnis);
            // reset value of number1,operator and operatorsinRow
            number2 = 0;
            Operators = "";
            operatorsInRow = 0;

            number1 = ergebnis; // new number 1
        }

        private void Clear_Click(object sender, EventArgs e) // when you press clear reset everything
        {
            Ausgabe.Text = "0";
            number1 = 0;
            number2 = 0;
            ergebnis = 0;
            Operators = "";
            operatorsInRow = 0;
            currentResult.Text = "0";
        }
    }
}
