using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FLASH_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            FormPaint(Color.FromArgb(7, 44, 39), Color.FromArgb(26, 88, 103), 45);
        }

        public void FormPaint(Color color1, Color color2, int angle)
        {
            void OnPaintEventHandler(object s, PaintEventArgs a)
            {
                if (ClientRectangle == Rectangle.Empty)
                    return;

                var lgb = new LinearGradientBrush(ClientRectangle, Color.Empty, Color.Empty, angle);
                var cblend = new ColorBlend { Colors = new[] { color1, color1, color2, color2 }, Positions = new[] { 0, 0.12f, 0.5f, 1 } };

                lgb.InterpolationColors = cblend;
                a.Graphics.FillRectangle(lgb, ClientRectangle);
            }

            Paint -= OnPaintEventHandler;
            Paint += OnPaintEventHandler;

            Invalidate();
        }
        string flashCommand = @"/c bin\fastboot flash";

        void Cmd(string command, bool noWindow)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = command,
                UseShellExecute = false,
                CreateNoWindow = noWindow,
                RedirectStandardOutput = true
            });
            process.BeginOutputReadLine();
            process.OutputDataReceived += (s, e) => { textBox1.Text = textBox1.Text + "\n" + e.Data + Environment.NewLine; };
            process.WaitForExit();
        }

        void Checker(string arg)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            Cmd($@"/c bin\{arg} devices", true);
            textBox2.Text = textBox1.Text.TrimEnd();
            if (textBox2.Text.EndsWith("device") | textBox2.Text.EndsWith("fastboot"))
            {
                {
                    label2.Text = $"Connected {arg}";
                    label2.ForeColor = Color.Green;
                }
            }
            else
            {
                label2.Text = "Disconnected";
                label2.ForeColor = Color.Red;
            }

        }
        void ConnectionTest()
        {
            Checker("ADB");
            if (!label2.Text.Contains("Connected"))
            {
                Checker("fastboot");
            }
        }
        void Form1_Load(object sender, EventArgs e)
        {
            ConnectionTest();
        }

        void button1_Click(object sender, EventArgs e)
        {
            ConnectionTest();
        }


        async void button2_Click(object sender, EventArgs e)
        {
            if (label2.Text.EndsWith("fastboot"))
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Text += "Start flashing to B slot = ";
                await Task.Delay(150);
                textBox1.Text += "\n\rFlash boot";
                await Task.Delay(150);
                Cmd($@"{flashCommand} boot_b payload\boot.img", false);
                textBox1.Text += "Flash dtbo";
                await Task.Delay(150);
                Cmd($@"{flashCommand} dtbo_b payload\dtbo.img", false);
                textBox1.Text += "Flash odm";
                await Task.Delay(150);
                Cmd($@"{flashCommand} odm_b payload\odm.img", false);
                textBox1.Text += "Flash system";
                await Task.Delay(150);
                Cmd($@"{flashCommand} system_b payload\system.img", false);
                textBox1.Text += "Flash vbmeta";
                await Task.Delay(150);
                Cmd($@"{flashCommand} vbmeta_b payload\vbmeta.img", false);
                textBox1.Text += "Flash vendor";
                await Task.Delay(150);
                Cmd($@"{flashCommand} vendor_b payload\vendor.img", false);
                textBox1.Text += "\nFlash finished";
            }
            else
            {
                MessageBox.Show("Before Flash/Switch Slot you should reboot into Bootloader");
            }
            ConnectionTest();
        }

        async void flas_A_Click(object sender, EventArgs e)
        {
            if (label2.Text.EndsWith("fastboot"))
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Text += "Start flashing to A slot = ";
                await Task.Delay(150);
                textBox1.Text += "\n\rFlash boot";
                await Task.Delay(150);
                Cmd($@"{flashCommand} boot_a payload\boot.img", false);
                textBox1.Text += "Flash dtbo";
                await Task.Delay(150);
                Cmd($@"{flashCommand} dtbo_a payload\dtbo.img", false);
                textBox1.Text += "Flash odm";
                await Task.Delay(150);
                Cmd($@"{flashCommand} odm_a payload\odm.img", false);
                textBox1.Text += "Flash system";
                await Task.Delay(150);
                Cmd($@"{flashCommand} system_a payload\system.img", false);
                textBox1.Text += "Flash vbmeta";
                await Task.Delay(150);
                Cmd($@"{flashCommand} vbmeta_a payload\vbmeta.img", false);
                textBox1.Text += "Flash vendor";
                await Task.Delay(150);
                Cmd($@"{flashCommand} vendor_a payload\vendor.img", false);
                textBox1.Text += "\nFlash finished";
            }
            else
            {
                MessageBox.Show("Before Flash/Switch Slot you should reboot into Bootloader");
            }
            ConnectionTest();

        }

        void change_A_Click(object sender, EventArgs e)
        {
            if (label2.Text.EndsWith("fastboot"))
            {
                Cmd($@"/c bin\fastboot --set-active=a", true);
            }
            else
            {
                MessageBox.Show("Before Flash/Switch Slot you should reboot into Bootloader");
            }
            ConnectionTest();
        }

        void change_B_Click(object sender, EventArgs e)
        {
            if (label2.Text.EndsWith("fastboot"))
            {
                Cmd($@"/c bin\fastboot --set-active=b", true);
            }
            else
            {
                MessageBox.Show("Before Flash/Switch Slot you should reboot into Bootloader");
            }
            ConnectionTest();
        }

        void reboot_to_bootloader_Click(object sender, EventArgs e)
        {
            ConnectionTest();
            Cmd($@"/c bin\adb reboot bootloader", true);
            Cmd($@"/c bin\fastboot reboot bootloader", true);
            ConnectionTest();
        }

        void logcat_Click(object sender, EventArgs e)
        {
            Cmd($@"/c bin\adb -d logcat -d>Logcat/log.txt", true);
            textBox2.Text = comboBox1.Text.Remove(1);
            MessageBox.Show("Log saved to Logacat folder");
        }

        async void button2_Click_1(object sender, EventArgs e)
        {
            if (label2.Text.EndsWith("fastboot"))
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Text += "Start regular flashing = ";
                await Task.Delay(150);
                textBox1.Text += "\n\rFlash boot";
                await Task.Delay(150);
                Cmd($@"{flashCommand} boot payload\boot.img", false);
                textBox1.Text += "Flash dtbo";
                await Task.Delay(150);
                Cmd($@"{flashCommand} dtbo payload\dtbo.img", false);
                textBox1.Text += "Flash odm";
                await Task.Delay(150);
                Cmd($@"{flashCommand} odm payload\odm.img", false);
                textBox1.Text += "Flash system";
                await Task.Delay(150);
                Cmd($@"{flashCommand} system payload\system.img", false);
                textBox1.Text += "Flash vbmeta";
                await Task.Delay(150);
                Cmd($@"{flashCommand} vbmeta payload\vbmeta.img", false);
                textBox1.Text += "Flash vendor";
                await Task.Delay(150);
                Cmd($@"{flashCommand} vendor payload\vendor.img", false);
                textBox1.Text += "\nFlash finished";
            }
            else
            {
                MessageBox.Show("Before Flash/Switch Slot you should reboot into Bootloader");
            }
            ConnectionTest();
        }

        async void payload_Click(object sender, EventArgs e)
        {
            Cmd($@"/c python -m pip install protobuf", false);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Text = "Start payload, be patience..." + "\n";
            await Task.Delay(300);
            Cmd($@"/c python payload\payload_dumper.py payload\payload.bin", true);
            textBox1.Text += "Payload done";
        }

        private void formatUserdata_Click(object sender, EventArgs e)
        {
            if (label2.Text.EndsWith("fastboot"))
            {
                textBox1.Text += "Start format userdata for disabling encryption" + "\n";
                Cmd($@"/c bin\fastboot format userdata", true);
            }
            else
            {
                MessageBox.Show("Before format you should reboot into Bootloader\nThis action will delete all of your data like music, photos, applications etc.");
            }
            ConnectionTest();
        }

        private void bootTWRP_Click(object sender, EventArgs e)
        {
            if (label2.Text.EndsWith("fastboot"))
            {
                textBox1.Text += "Boot to TWRP" + "\n";
                Cmd($@"/c bin\fastboot boot TWRP/TWRP.img", true);
            }
            else
            {
                MessageBox.Show("Before boot to TWRP you should reboot into Bootloader");
            }
            ConnectionTest();
        }

        private void OEMunlock_Click(object sender, EventArgs e)
        {
            if(label2.Text.EndsWith("fastboot"))
            {
                textBox1.Text += "Unlocking bootloader" + "\n";
                Cmd($@"/c bin\fastboot oem unlock", true);
                textBox1.Text += "Check your phone" + "\n";
            }
            else
            {
                MessageBox.Show("Before boot to TWRP you should reboot into Bootloader");
            }
            ConnectionTest();
        }
    }
}
