namespace InterfaceUser
{
    partial class Chat
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.cdnnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_inmsg = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_outmsg = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(104, 21);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(285, 28);
            this.tb_name.TabIndex = 0;
            this.tb_name.Text = "name";
            // 
            // cdnnect
            // 
            this.cdnnect.Location = new System.Drawing.Point(6, 21);
            this.cdnnect.Name = "cdnnect";
            this.cdnnect.Size = new System.Drawing.Size(92, 28);
            this.cdnnect.TabIndex = 1;
            this.cdnnect.Text = "Connect";
            this.cdnnect.UseVisualStyleBackColor = true;
            this.cdnnect.Click += new System.EventHandler(this.cdnnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cdnnect);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_inmsg);
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 253);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // tb_inmsg
            // 
            this.tb_inmsg.Enabled = false;
            this.tb_inmsg.Location = new System.Drawing.Point(6, 13);
            this.tb_inmsg.Multiline = true;
            this.tb_inmsg.Name = "tb_inmsg";
            this.tb_inmsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_inmsg.Size = new System.Drawing.Size(383, 234);
            this.tb_inmsg.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_outmsg);
            this.groupBox3.Location = new System.Drawing.Point(12, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 105);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // tb_outmsg
            // 
            this.tb_outmsg.Location = new System.Drawing.Point(6, 12);
            this.tb_outmsg.Multiline = true;
            this.tb_outmsg.Name = "tb_outmsg";
            this.tb_outmsg.Size = new System.Drawing.Size(383, 87);
            this.tb_outmsg.TabIndex = 1;
            this.tb_outmsg.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Chat_KeyDown);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Chat";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chat_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button cdnnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_inmsg;
        private System.Windows.Forms.TextBox tb_outmsg;
    }
}

