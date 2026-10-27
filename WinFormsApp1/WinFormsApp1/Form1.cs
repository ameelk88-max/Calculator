namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double number1;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender; // erstell variable von typ Button, weil ich den Text brauche und Sender ein Objekt hier ist
            Ausgabe.Text += b.Text;
        }

        private void OperatorenClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            number1 = Convert.ToDouble(Ausgabe.Text);
            operation = b.Text;
            Ausgabe.Text = "";
        }

        private void button17_Click(object sender, EventArgs e) // für (=) Click
        {
            double number2 = Convert.ToDouble(Ausgabe.Text);
        }
    }
}
