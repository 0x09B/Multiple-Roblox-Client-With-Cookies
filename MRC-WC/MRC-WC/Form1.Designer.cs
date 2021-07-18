
namespace MRC_WC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cookiespath_tb = new System.Windows.Forms.TextBox();
            this.opencookies_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gameid_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clients_tb = new System.Windows.Forms.TextBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.output_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cookies file path:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cookiespath_tb
            // 
            this.cookiespath_tb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cookiespath_tb.Location = new System.Drawing.Point(12, 22);
            this.cookiespath_tb.Name = "cookiespath_tb";
            this.cookiespath_tb.ReadOnly = true;
            this.cookiespath_tb.Size = new System.Drawing.Size(100, 20);
            this.cookiespath_tb.TabIndex = 1;
            this.cookiespath_tb.Text = "Waiting for path";
            // 
            // opencookies_btn
            // 
            this.opencookies_btn.Location = new System.Drawing.Point(12, 48);
            this.opencookies_btn.Name = "opencookies_btn";
            this.opencookies_btn.Size = new System.Drawing.Size(102, 23);
            this.opencookies_btn.TabIndex = 2;
            this.opencookies_btn.Text = "Open cookies";
            this.opencookies_btn.UseVisualStyleBackColor = true;
            this.opencookies_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Game ID:";
            // 
            // gameid_tb
            // 
            this.gameid_tb.Location = new System.Drawing.Point(12, 90);
            this.gameid_tb.Name = "gameid_tb";
            this.gameid_tb.Size = new System.Drawing.Size(100, 20);
            this.gameid_tb.TabIndex = 4;
            this.gameid_tb.Text = "put game id here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(9, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "How many clients? ( Default is 10 )\r\n\r\n\r\n";
            // 
            // clients_tb
            // 
            this.clients_tb.Location = new System.Drawing.Point(12, 132);
            this.clients_tb.Name = "clients_tb";
            this.clients_tb.Size = new System.Drawing.Size(100, 20);
            this.clients_tb.TabIndex = 6;
            this.clients_tb.Text = "10";
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(132, 19);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 52);
            this.start_btn.TabIndex = 7;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_bt);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Output:";
            // 
            // output_tb
            // 
            this.output_tb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.output_tb.Location = new System.Drawing.Point(226, 19);
            this.output_tb.Multiline = true;
            this.output_tb.Name = "output_tb";
            this.output_tb.ReadOnly = true;
            this.output_tb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.output_tb.Size = new System.Drawing.Size(184, 124);
            this.output_tb.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(422, 162);
            this.Controls.Add(this.output_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.clients_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gameid_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.opencookies_btn);
            this.Controls.Add(this.cookiespath_tb);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Multiple Roblox Client - With Cookies";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox cookiespath_tb;
        private System.Windows.Forms.Button opencookies_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gameid_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clients_tb;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox output_tb;
    }
}

