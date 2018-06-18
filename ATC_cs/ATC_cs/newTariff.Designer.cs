namespace ATC_cs
{
    partial class newTariff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.nud_balance = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_tariff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_done = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_balance)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Баланс";
            // 
            // nud_balance
            // 
            this.nud_balance.DecimalPlaces = 2;
            this.nud_balance.Location = new System.Drawing.Point(16, 127);
            this.nud_balance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nud_balance.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nud_balance.Name = "nud_balance";
            this.nud_balance.Size = new System.Drawing.Size(221, 22);
            this.nud_balance.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Тариф";
            // 
            // tb_tariff
            // 
            this.tb_tariff.Location = new System.Drawing.Point(16, 73);
            this.tb_tariff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_tariff.Name = "tb_tariff";
            this.tb_tariff.Size = new System.Drawing.Size(221, 22);
            this.tb_tariff.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Новый тариф";
            // 
            // btn_done
            // 
            this.btn_done.Location = new System.Drawing.Point(159, 196);
            this.btn_done.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(80, 28);
            this.btn_done.TabIndex = 15;
            this.btn_done.Text = "Создать";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(16, 196);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 28);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // newTariff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 239);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nud_balance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_tariff);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "newTariff";
            this.Text = "newTariff";
            ((System.ComponentModel.ISupportInitialize)(this.nud_balance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown nud_balance;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_tariff;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_done;
        public System.Windows.Forms.Button btn_cancel;
    }
}