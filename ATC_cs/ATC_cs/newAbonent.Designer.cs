namespace ATC_cs
{
    partial class newAbonent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.btn_done = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Новый абонент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "ФИО абонента";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(16, 76);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(221, 22);
            this.tb_name.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Домашний адрес";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(16, 134);
            this.tb_address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(221, 22);
            this.tb_address.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Дата";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(16, 187);
            this.date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(221, 22);
            this.date.TabIndex = 11;
            // 
            // btn_done
            // 
            this.btn_done.Location = new System.Drawing.Point(157, 245);
            this.btn_done.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(80, 28);
            this.btn_done.TabIndex = 14;
            this.btn_done.Text = "Создать";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(16, 245);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 28);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // newAbonent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 292);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "newAbonent";
            this.Text = "newAbonent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_name;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_address;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker date;
        public System.Windows.Forms.Button btn_done;
        public System.Windows.Forms.Button btn_cancel;
    }
}