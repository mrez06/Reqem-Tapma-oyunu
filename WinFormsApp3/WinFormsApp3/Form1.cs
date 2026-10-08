namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private readonly Random random = new();
        private int num;
        private int attemptCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void yenioyunbtn_Click(object sender, EventArgs e)
        {
            num = random.Next(0, 101);
            attemptCount = 0;
            textBox1.Clear();
            textBox1.Enabled = true;
            button1.Enabled = true;
            errorProvider1.Clear();
            resultTextBox.Clear();
            resultTextBox.AppendText("Yeni oyun başladı. Ədəd daxil edin.");
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Ədəd daxil edin.");
                textBox1.Focus();
                return;
            }

            if (!int.TryParse(textBox1.Text, out int enteredNumber) || enteredNumber < 0 || enteredNumber > 100)
            {
                errorProvider1.SetError(textBox1, "0-100 arasında tam ədəd daxil edin.");
                textBox1.Focus();
                return;
            }

            attemptCount++;
            resultTextBox.Clear();

            if (enteredNumber == num)
            {
                resultTextBox.AppendText("Oyunu qazandınız\r\n");
                resultTextBox.AppendText($"Cəhd sayı: {attemptCount}");
                textBox1.Enabled = false;
                button1.Enabled = false;
                return;
            }

            resultTextBox.AppendText("Daxil edilən ədəd yanlışdır\r\n");
            resultTextBox.AppendText(enteredNumber < num
                ? "Təsadüfi ədəddən kiçikdir\r\n"
                : "Təsadüfi ədəddən böyükdür\r\n");
            resultTextBox.AppendText($"Cəhd sayı: {attemptCount}");
            textBox1.SelectAll();
            textBox1.Focus();
        }
    }
}
