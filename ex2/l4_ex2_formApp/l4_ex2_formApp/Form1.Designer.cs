namespace l4_ex2_formApp
{
    partial class Form1
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
            this.textBox_f = new System.Windows.Forms.TextBox();
            this.button_convFtoC = new System.Windows.Forms.Button();
            this.textBox_convFtoC_result = new System.Windows.Forms.TextBox();
            this.textBox_convRontoE_result = new System.Windows.Forms.TextBox();
            this.button_convRonToE = new System.Windows.Forms.Button();
            this.textBox_Ron = new System.Windows.Forms.TextBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.button_getDate = new System.Windows.Forms.Button();
            this.listBox_showElement = new System.Windows.Forms.ListBox();
            this.button_showList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_f
            // 
            this.textBox_f.Location = new System.Drawing.Point(53, 94);
            this.textBox_f.Name = "textBox_f";
            this.textBox_f.Size = new System.Drawing.Size(100, 20);
            this.textBox_f.TabIndex = 0;
            // 
            // button_convFtoC
            // 
            this.button_convFtoC.Location = new System.Drawing.Point(53, 281);
            this.button_convFtoC.Name = "button_convFtoC";
            this.button_convFtoC.Size = new System.Drawing.Size(88, 42);
            this.button_convFtoC.TabIndex = 2;
            this.button_convFtoC.Text = "Convert F to C";
            this.button_convFtoC.UseVisualStyleBackColor = true;
            this.button_convFtoC.Click += new System.EventHandler(this.Button_convFtoC_Click);
            // 
            // textBox_convFtoC_result
            // 
            this.textBox_convFtoC_result.Location = new System.Drawing.Point(53, 187);
            this.textBox_convFtoC_result.Name = "textBox_convFtoC_result";
            this.textBox_convFtoC_result.ReadOnly = true;
            this.textBox_convFtoC_result.Size = new System.Drawing.Size(100, 20);
            this.textBox_convFtoC_result.TabIndex = 3;
            // 
            // textBox_convRontoE_result
            // 
            this.textBox_convRontoE_result.Location = new System.Drawing.Point(238, 187);
            this.textBox_convRontoE_result.Name = "textBox_convRontoE_result";
            this.textBox_convRontoE_result.ReadOnly = true;
            this.textBox_convRontoE_result.Size = new System.Drawing.Size(100, 20);
            this.textBox_convRontoE_result.TabIndex = 7;
            // 
            // button_convRonToE
            // 
            this.button_convRonToE.Location = new System.Drawing.Point(238, 281);
            this.button_convRonToE.Name = "button_convRonToE";
            this.button_convRonToE.Size = new System.Drawing.Size(88, 42);
            this.button_convRonToE.TabIndex = 6;
            this.button_convRonToE.Text = "Convert Ron to E";
            this.button_convRonToE.UseVisualStyleBackColor = true;
            this.button_convRonToE.Click += new System.EventHandler(this.Button_convRonToE_Click);
            // 
            // textBox_Ron
            // 
            this.textBox_Ron.Location = new System.Drawing.Point(238, 94);
            this.textBox_Ron.Name = "textBox_Ron";
            this.textBox_Ron.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ron.TabIndex = 4;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(392, 187);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.ReadOnly = true;
            this.textBox_date.Size = new System.Drawing.Size(133, 20);
            this.textBox_date.TabIndex = 8;
            // 
            // button_getDate
            // 
            this.button_getDate.Location = new System.Drawing.Point(392, 281);
            this.button_getDate.Name = "button_getDate";
            this.button_getDate.Size = new System.Drawing.Size(88, 42);
            this.button_getDate.TabIndex = 9;
            this.button_getDate.Text = "Current Date";
            this.button_getDate.UseVisualStyleBackColor = true;
            this.button_getDate.Click += new System.EventHandler(this.Button_getDate_Click);
            // 
            // listBox_showElement
            // 
            this.listBox_showElement.FormattingEnabled = true;
            this.listBox_showElement.Location = new System.Drawing.Point(621, 112);
            this.listBox_showElement.Name = "listBox_showElement";
            this.listBox_showElement.Size = new System.Drawing.Size(120, 95);
            this.listBox_showElement.TabIndex = 10;
            // 
            // button_showList
            // 
            this.button_showList.Location = new System.Drawing.Point(637, 281);
            this.button_showList.Name = "button_showList";
            this.button_showList.Size = new System.Drawing.Size(88, 42);
            this.button_showList.TabIndex = 11;
            this.button_showList.Text = "Show List";
            this.button_showList.UseVisualStyleBackColor = true;
            this.button_showList.Click += new System.EventHandler(this.Button_showList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_showList);
            this.Controls.Add(this.listBox_showElement);
            this.Controls.Add(this.button_getDate);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.textBox_convRontoE_result);
            this.Controls.Add(this.button_convRonToE);
            this.Controls.Add(this.textBox_Ron);
            this.Controls.Add(this.textBox_convFtoC_result);
            this.Controls.Add(this.button_convFtoC);
            this.Controls.Add(this.textBox_f);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_f;
        private System.Windows.Forms.Button button_convFtoC;
        private System.Windows.Forms.TextBox textBox_convFtoC_result;
        private System.Windows.Forms.TextBox textBox_convRontoE_result;
        private System.Windows.Forms.Button button_convRonToE;
        private System.Windows.Forms.TextBox textBox_Ron;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.Button button_getDate;
        private System.Windows.Forms.ListBox listBox_showElement;
        private System.Windows.Forms.Button button_showList;
    }
}

