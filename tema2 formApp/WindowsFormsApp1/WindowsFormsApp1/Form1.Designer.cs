namespace WindowsFormsApp1
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
            this.dbData = new System.Windows.Forms.ListBox();
            this.showData = new System.Windows.Forms.Button();
            this.textBox_insertNr = new System.Windows.Forms.TextBox();
            this.button_insertNr = new System.Windows.Forms.Button();
            this.textBox_updateValue = new System.Windows.Forms.TextBox();
            this.textBox_updateId = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dbData
            // 
            this.dbData.FormattingEnabled = true;
            this.dbData.Location = new System.Drawing.Point(99, 91);
            this.dbData.Name = "dbData";
            this.dbData.Size = new System.Drawing.Size(149, 121);
            this.dbData.TabIndex = 0;
            // 
            // showData
            // 
            this.showData.Location = new System.Drawing.Point(114, 276);
            this.showData.Name = "showData";
            this.showData.Size = new System.Drawing.Size(95, 47);
            this.showData.TabIndex = 1;
            this.showData.Text = "Show Data";
            this.showData.UseVisualStyleBackColor = true;
            this.showData.Click += new System.EventHandler(this.ShowData_Click);
            // 
            // textBox_insertNr
            // 
            this.textBox_insertNr.Location = new System.Drawing.Point(320, 136);
            this.textBox_insertNr.Name = "textBox_insertNr";
            this.textBox_insertNr.Size = new System.Drawing.Size(100, 20);
            this.textBox_insertNr.TabIndex = 2;
            // 
            // button_insertNr
            // 
            this.button_insertNr.Location = new System.Drawing.Point(325, 276);
            this.button_insertNr.Name = "button_insertNr";
            this.button_insertNr.Size = new System.Drawing.Size(95, 47);
            this.button_insertNr.TabIndex = 3;
            this.button_insertNr.Text = "Insert Nr";
            this.button_insertNr.UseVisualStyleBackColor = true;
            this.button_insertNr.Click += new System.EventHandler(this.Button_insertNr_Click);
            // 
            // textBox_updateValue
            // 
            this.textBox_updateValue.Location = new System.Drawing.Point(535, 105);
            this.textBox_updateValue.Name = "textBox_updateValue";
            this.textBox_updateValue.Size = new System.Drawing.Size(100, 20);
            this.textBox_updateValue.TabIndex = 4;
            // 
            // textBox_updateId
            // 
            this.textBox_updateId.Location = new System.Drawing.Point(535, 167);
            this.textBox_updateId.Name = "textBox_updateId";
            this.textBox_updateId.Size = new System.Drawing.Size(100, 20);
            this.textBox_updateId.TabIndex = 5;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(563, 276);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(95, 47);
            this.button_update.TabIndex = 6;
            this.button_update.Text = "Update Nr";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.Button_update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_updateId);
            this.Controls.Add(this.textBox_updateValue);
            this.Controls.Add(this.button_insertNr);
            this.Controls.Add(this.textBox_insertNr);
            this.Controls.Add(this.showData);
            this.Controls.Add(this.dbData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dbData;
        private System.Windows.Forms.Button showData;
        private System.Windows.Forms.TextBox textBox_insertNr;
        private System.Windows.Forms.Button button_insertNr;
        private System.Windows.Forms.TextBox textBox_updateValue;
        private System.Windows.Forms.TextBox textBox_updateId;
        private System.Windows.Forms.Button button_update;
    }
}

