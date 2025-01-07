namespace SSH_Connect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
            label4.Visible = false;

            inPort.Items.AddRange(new string[] { "22", "443" });
            inPort.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stringIP = inIP.Text;
            string stringPort = inPort.Text;

            label3.Visible = true;
            label4.Visible = true;

            label3.Text = stringIP;
            label4.Text = stringPort;

        }

        private void inIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            string currentText = inIP.Text;

            if (e.KeyChar == '.' && (currentText.EndsWith(".") || currentText.Length == 0))
            {
                e.Handled = true;
                return;
            }

            string[] segments = currentText.Split('.');

            if (e.KeyChar == '.' && segments.Length >= 4)
            {
                e.Handled = true;
                return;
            }

            if (char.IsDigit(e.KeyChar) && segments.Length > 0)
            {
                string currentSegment = segments[^1];
                if (currentSegment.Length >= 3 && currentText.EndsWith(currentSegment))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
