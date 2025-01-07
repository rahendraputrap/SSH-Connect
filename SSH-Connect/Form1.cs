using Renci.SshNet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            string username = "";
            string password = "";

            if (string.IsNullOrEmpty(stringIP) || string.IsNullOrEmpty(stringPort))
            {
                MessageBox.Show("IP dan Port tidak boleh kosong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            label3.Visible = true;

            try
            {
                int port = int.Parse(stringPort);

                var connectionInfo = new ConnectionInfo(stringIP, port, username,
                    new PasswordAuthenticationMethod(username, password));

                using (var sshClient = new SshClient(connectionInfo))
                {
                    sshClient.Connect();

                    if (sshClient.IsConnected)
                    {
                        MessageBox.Show("Berhasil terhubung ke server SSH!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label3.Text = "Sukses";

                        var command = sshClient.RunCommand("whoami");
                        MessageBox.Show($"User yang terhubung: {command.Result.Trim()}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal terhubung ke server SSH. \nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label3.Text = "Gagal";
            }

            //label3.Visible = true;
            //label4.Visible = true;

            //label3.Text = stringIP;
            //label4.Text = stringPort;

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
