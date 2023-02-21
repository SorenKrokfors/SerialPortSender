using System.IO.Ports;
using File = System.IO.File;


namespace SerialPortSender;
public partial class frmMain : Form
{
    private SerialPort serialPort=null;

    public frmMain()
    {
        InitializeComponent();
    }
    private void frmMain_Load(object sender, EventArgs e)
    {
        btnSend.Enabled = false;
        if (File.Exists("data.txt")) txtData.Text = File.ReadAllText("data.txt");
        var ports = SerialPort.GetPortNames();
        if (ports.Length == 0)
        {
            MessageBox.Show("No serial ports found");
            return;
        }

        if (File.Exists("Commands.txt"))
        {
            var commands = File.ReadAllLines("Commands.txt");
            listBox1.Items.Clear();
            foreach (var command in commands)
            {
                listBox1.Items.Add(command);
            }
        }

        foreach (var port in ports)
        {
            cmbPorts.Items.Add(port);
        }

        cmbPorts.SelectedIndex = 0;
    }
    
    private async Task SendData(SerialPort serialPort)
    {
        var dataRows = txtData.Text.Split('\r');
        foreach (var dataRow in dataRows)
        {
            if (dataRow.Contains("WAIT "))
            {
                var millisecondsDelay = int.Parse(dataRow.Replace("WAIT ", string.Empty));
                await Task.Delay(millisecondsDelay);
            }
            else
            {
                var data = dataRow.Replace("\r", string.Empty);
                if (!string.IsNullOrEmpty(data) && data!=Environment.NewLine) serialPort.WriteLine(data + '\r');
            }
        }
    }

    private async void btnSend_Click(object sender, EventArgs e)
    {
        try
        {
            await File.WriteAllTextAsync("data.txt", txtData.Text);
            btnSend.Enabled = false;
            await SendData(serialPort);
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
        }
        finally
        {
            btnSend.Enabled = true;
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtReveiveData.Text = string.Empty;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtNewCommand.Text))
        {
            listBox1.Items.Add(txtNewCommand.Text);
            File.AppendAllLines("Commands.txt", new[] { txtNewCommand.Text });
        }
    }

    private void btnAddtoSend_Click(object sender, EventArgs e)
    {
        txtData.Text += listBox1.SelectedItem.ToString() + Environment.NewLine;
    }

    private void listBox1_DoubleClick(object sender, EventArgs e)
    {
        if (listBox1.SelectedItem == null) return;
        txtData.Text += listBox1.SelectedItem.ToString() + Environment.NewLine;
    }

    private async void frmMain_FormClosed(object sender, FormClosedEventArgs e)
    {
        try
        {
            serialPort?.Close();
            btnSend.Enabled = false;
        }
        catch (Exception exception)
        {
        }
        await File.WriteAllTextAsync("data.txt", txtData.Text);
    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
        try
        {
            serialPort = new SerialPort(cmbPorts.Text);
            serialPort.BaudRate = int.Parse(txtBaud.Text);
            serialPort.DataReceived += SerialPort_DataReceived;
            serialPort.Open();
            btnSend.Enabled = true;
        }
        catch (Exception exception)
        {
            MessageBox.Show("Check settings!");
        }

    }

    private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
        try
        {
            var data = serialPort.ReadExisting();
            UpdateData(data);
        }
        catch (Exception exception)
        {
            var ee=exception;
        }

    }

    private void UpdateData(string data)
    {
        if (txtData.InvokeRequired)
        {
            this.Invoke(new Action<string>(UpdateData), new object[] { data });
            return;
        }
        else
        {
            txtReveiveData.Text += data;
            txtReveiveData.Focus();
            txtReveiveData.SelectionStart = txtReveiveData.Text.Length;
            txtReveiveData.ScrollToCaret();
        }
    }

}
