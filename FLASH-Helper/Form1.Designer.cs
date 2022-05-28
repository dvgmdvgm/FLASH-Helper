
namespace FLASH_Helper
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.flash_B = new System.Windows.Forms.Button();
            this.flas_A = new System.Windows.Forms.Button();
            this.change_A = new System.Windows.Forms.Button();
            this.change_B = new System.Windows.Forms.Button();
            this.reboot_to_bootloader = new System.Windows.Forms.Button();
            this.logcat = new System.Windows.Forms.Button();
            this.flash_Regular = new System.Windows.Forms.Button();
            this.payload = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.formatUserdata = new System.Windows.Forms.Button();
            this.bootTWRP = new System.Windows.Forms.Button();
            this.OEMunlock = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(77, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wait";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(578, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(329, 220);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(15, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.toolTip1.SetToolTip(this.button1, "Recheck state of connected phone");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(578, 251);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(329, 160);
            this.textBox2.TabIndex = 4;
            // 
            // flash_B
            // 
            this.flash_B.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flash_B.FlatAppearance.BorderSize = 0;
            this.flash_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flash_B.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flash_B.ForeColor = System.Drawing.Color.MidnightBlue;
            this.flash_B.Location = new System.Drawing.Point(139, 62);
            this.flash_B.Name = "flash_B";
            this.flash_B.Size = new System.Drawing.Size(106, 33);
            this.flash_B.TabIndex = 5;
            this.flash_B.Text = "FlashAll to B slot";
            this.toolTip1.SetToolTip(this.flash_B, "Flash all *.img files located in \"payload\" folder only in B slot.\r\nPhone should b" +
        "e connected via fastboot");
            this.flash_B.UseVisualStyleBackColor = false;
            this.flash_B.Click += new System.EventHandler(this.button2_Click);
            // 
            // flas_A
            // 
            this.flas_A.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flas_A.FlatAppearance.BorderSize = 0;
            this.flas_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flas_A.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flas_A.ForeColor = System.Drawing.Color.MidnightBlue;
            this.flas_A.Location = new System.Drawing.Point(15, 62);
            this.flas_A.Name = "flas_A";
            this.flas_A.Size = new System.Drawing.Size(106, 33);
            this.flas_A.TabIndex = 6;
            this.flas_A.Text = "FlashAll to A slot";
            this.toolTip1.SetToolTip(this.flas_A, "Flash all *.img files located in \"payload\" folder only in A slot.\r\nPhone should b" +
        "e connected via fastboot");
            this.flas_A.UseVisualStyleBackColor = false;
            this.flas_A.Click += new System.EventHandler(this.flas_A_Click);
            // 
            // change_A
            // 
            this.change_A.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.change_A.FlatAppearance.BorderSize = 0;
            this.change_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_A.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_A.ForeColor = System.Drawing.Color.MidnightBlue;
            this.change_A.Location = new System.Drawing.Point(15, 107);
            this.change_A.Name = "change_A";
            this.change_A.Size = new System.Drawing.Size(106, 33);
            this.change_A.TabIndex = 7;
            this.change_A.Text = "Switch to A slot";
            this.toolTip1.SetToolTip(this.change_A, "Set current active slot to A.\r\nPhone should be connected via fastboot\r\n");
            this.change_A.UseVisualStyleBackColor = false;
            this.change_A.Click += new System.EventHandler(this.change_A_Click);
            // 
            // change_B
            // 
            this.change_B.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.change_B.FlatAppearance.BorderSize = 0;
            this.change_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_B.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_B.ForeColor = System.Drawing.Color.MidnightBlue;
            this.change_B.Location = new System.Drawing.Point(139, 107);
            this.change_B.Name = "change_B";
            this.change_B.Size = new System.Drawing.Size(106, 33);
            this.change_B.TabIndex = 8;
            this.change_B.Text = "Switch to B slot";
            this.toolTip1.SetToolTip(this.change_B, "Set current active slot to B.\r\nPhone should be connected via fastboot");
            this.change_B.UseVisualStyleBackColor = false;
            this.change_B.Click += new System.EventHandler(this.change_B_Click);
            // 
            // reboot_to_bootloader
            // 
            this.reboot_to_bootloader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reboot_to_bootloader.FlatAppearance.BorderSize = 0;
            this.reboot_to_bootloader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reboot_to_bootloader.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.reboot_to_bootloader.ForeColor = System.Drawing.Color.MidnightBlue;
            this.reboot_to_bootloader.Location = new System.Drawing.Point(138, 48);
            this.reboot_to_bootloader.Name = "reboot_to_bootloader";
            this.reboot_to_bootloader.Size = new System.Drawing.Size(106, 33);
            this.reboot_to_bootloader.TabIndex = 9;
            this.reboot_to_bootloader.Text = "Goto bootloader";
            this.toolTip1.SetToolTip(this.reboot_to_bootloader, "Reboot to bootloader from system or bootloader");
            this.reboot_to_bootloader.UseVisualStyleBackColor = false;
            this.reboot_to_bootloader.Click += new System.EventHandler(this.reboot_to_bootloader_Click);
            // 
            // logcat
            // 
            this.logcat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logcat.FlatAppearance.BorderSize = 0;
            this.logcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logcat.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.logcat.ForeColor = System.Drawing.Color.MidnightBlue;
            this.logcat.Location = new System.Drawing.Point(139, 21);
            this.logcat.Name = "logcat";
            this.logcat.Size = new System.Drawing.Size(106, 33);
            this.logcat.TabIndex = 10;
            this.logcat.Text = "Save logcat";
            this.toolTip1.SetToolTip(this.logcat, "Save current logcat with debug key in \"Logcat\" folder.\r\nPhone should be connected" +
        " via ADB");
            this.logcat.UseVisualStyleBackColor = false;
            this.logcat.Click += new System.EventHandler(this.logcat_Click);
            // 
            // flash_Regular
            // 
            this.flash_Regular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flash_Regular.FlatAppearance.BorderSize = 0;
            this.flash_Regular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flash_Regular.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flash_Regular.ForeColor = System.Drawing.Color.MidnightBlue;
            this.flash_Regular.Location = new System.Drawing.Point(76, 20);
            this.flash_Regular.Name = "flash_Regular";
            this.flash_Regular.Size = new System.Drawing.Size(106, 33);
            this.flash_Regular.TabIndex = 11;
            this.flash_Regular.Text = "Regular Flash";
            this.toolTip1.SetToolTip(this.flash_Regular, "Flash all *.img files located in \"payload\" folder.\r\nPhone should be connected via" +
        " fastboot");
            this.flash_Regular.UseVisualStyleBackColor = false;
            this.flash_Regular.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // payload
            // 
            this.payload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.payload.FlatAppearance.BorderSize = 0;
            this.payload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payload.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.payload.ForeColor = System.Drawing.Color.MidnightBlue;
            this.payload.Location = new System.Drawing.Point(16, 21);
            this.payload.Name = "payload";
            this.payload.Size = new System.Drawing.Size(106, 33);
            this.payload.TabIndex = 12;
            this.payload.Text = "Payload ROM";
            this.toolTip1.SetToolTip(this.payload, "Dump all *.img files from ROM to \"payload\" folder.\r\npayload.bin should be extract" +
        "ed from your ROM zip file into \"payload\" folder");
            this.payload.UseVisualStyleBackColor = false;
            this.payload.Click += new System.EventHandler(this.payload_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "v — Verbose",
            "d — Debug",
            "i — Info",
            "w — Warning",
            "e — Error",
            "f — Fatal",
            "s — Silent"});
            this.comboBox1.Location = new System.Drawing.Point(139, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "Logcat arguments";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.reboot_to_bootloader);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 100);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.logcat);
            this.panel2.Controls.Add(this.payload);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(15, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 100);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.flash_B);
            this.panel3.Controls.Add(this.flas_A);
            this.panel3.Controls.Add(this.change_A);
            this.panel3.Controls.Add(this.flash_Regular);
            this.panel3.Controls.Add(this.change_B);
            this.panel3.Location = new System.Drawing.Point(15, 251);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 160);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.OEMunlock);
            this.panel4.Controls.Add(this.formatUserdata);
            this.panel4.Controls.Add(this.bootTWRP);
            this.panel4.Location = new System.Drawing.Point(296, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 117);
            this.panel4.TabIndex = 15;
            // 
            // formatUserdata
            // 
            this.formatUserdata.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.formatUserdata.FlatAppearance.BorderSize = 0;
            this.formatUserdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formatUserdata.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.formatUserdata.ForeColor = System.Drawing.Color.MidnightBlue;
            this.formatUserdata.Location = new System.Drawing.Point(17, 66);
            this.formatUserdata.Name = "formatUserdata";
            this.formatUserdata.Size = new System.Drawing.Size(106, 33);
            this.formatUserdata.TabIndex = 3;
            this.formatUserdata.Text = "Format uData";
            this.toolTip1.SetToolTip(this.formatUserdata, "Will format your data. All of yours Apps, Settings, Photos, Music, etc. will dele" +
        "ted.\r\nIt\'s necessary to decrypt your data partition.\r\nPhone should be connected " +
        "via fastboot");
            this.formatUserdata.UseVisualStyleBackColor = false;
            this.formatUserdata.Click += new System.EventHandler(this.formatUserdata_Click);
            // 
            // bootTWRP
            // 
            this.bootTWRP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bootTWRP.FlatAppearance.BorderSize = 0;
            this.bootTWRP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootTWRP.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.bootTWRP.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bootTWRP.Location = new System.Drawing.Point(140, 66);
            this.bootTWRP.Name = "bootTWRP";
            this.bootTWRP.Size = new System.Drawing.Size(106, 33);
            this.bootTWRP.TabIndex = 9;
            this.bootTWRP.Text = "boot TWRP";
            this.toolTip1.SetToolTip(this.bootTWRP, "Temporary boot into recovery located in \"TWRP\" folder.\r\nFile shoud be named \"TWRP" +
        ".img\"\r\nPhone should be connected via fastboot");
            this.bootTWRP.UseVisualStyleBackColor = false;
            this.bootTWRP.Click += new System.EventHandler(this.bootTWRP_Click);
            // 
            // OEMunlock
            // 
            this.OEMunlock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OEMunlock.FlatAppearance.BorderSize = 0;
            this.OEMunlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OEMunlock.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Bold);
            this.OEMunlock.ForeColor = System.Drawing.Color.MidnightBlue;
            this.OEMunlock.Location = new System.Drawing.Point(17, 16);
            this.OEMunlock.Name = "OEMunlock";
            this.OEMunlock.Size = new System.Drawing.Size(106, 33);
            this.OEMunlock.TabIndex = 10;
            this.OEMunlock.Text = "OEM Unlock";
            this.toolTip1.SetToolTip(this.OEMunlock, "Perform OEM unlock to unlock your bootloader.\r\nPhone should be connected via fast" +
        "boot");
            this.OEMunlock.UseVisualStyleBackColor = false;
            this.OEMunlock.Click += new System.EventHandler(this.OEMunlock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 422);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button flash_B;
        private System.Windows.Forms.Button flas_A;
        private System.Windows.Forms.Button change_A;
        private System.Windows.Forms.Button change_B;
        private System.Windows.Forms.Button reboot_to_bootloader;
        private System.Windows.Forms.Button logcat;
        private System.Windows.Forms.Button flash_Regular;
        private System.Windows.Forms.Button payload;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button formatUserdata;
        private System.Windows.Forms.Button bootTWRP;
        private System.Windows.Forms.Button OEMunlock;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

