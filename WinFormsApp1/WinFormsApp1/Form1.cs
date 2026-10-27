namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double number1; // safe first number
        double number2; // safe second number
        string Operators; // safe the operators
        double ergebnis;
        int operatorsInRow = 0; // How many times does this occur? because I need to know how many times operators are used before pressing "="
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)// pressing numbers Methode, when you press something write it as text in textbox(Ausgabe)
        {
            Button Button = (Button)sender; //
            Ausgabe.Text += Button.Text; // add the new numbers to the last
        }

        private void OperatorenClick(object sender, EventArgs e) // Operators Methode
        {
          operatorsInRow++; // increase this to know it is the first time

           if (operatorsInRow == 1) // if this is the first time you used operator
           { 
            number1 = Convert.ToDouble(Ausgabe.Text); // safe the number that was written at first
            Ausgabe.Text = ""; // make textBox empty to be ready to write next numbers
            Button button = (Button)sender;
            Operators = button.Text; // Safe the operator you made
           }


            if (operatorsInRow == 2) 
            {
                number2 = Convert.ToDouble(Ausgabe.Text); // safe the number that was written at first
                Ausgabe.Text = ""; // make textBox empty to be ready to write next numbers
                button17_Click(null,EventArgs.Empty);
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
            // reset value of number1, number2 and operator
            number1 = 0;
            number2 = 0;
            Operators = "";
        }

        private void Clear_Click(object sender, EventArgs e) // when you press clear reset everything
        {
            Ausgabe.Text = "0";
            number1 = 0;
            number2 = 0;
            ergebnis = 0;
            Operators = "";
        }
    }
}
