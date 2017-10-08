namespace ExampPrep.UI.WinForms
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
            this.btnGetWithTask = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnGetWithAsync = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetWithTask
            // 
            this.btnGetWithTask.Location = new System.Drawing.Point(79, 164);
            this.btnGetWithTask.Name = "btnGetWithTask";
            this.btnGetWithTask.Size = new System.Drawing.Size(265, 126);
            this.btnGetWithTask.TabIndex = 0;
            this.btnGetWithTask.Text = "Get with Task";
            this.btnGetWithTask.UseVisualStyleBackColor = true;
            this.btnGetWithTask.Click += new System.EventHandler(this.GetWithTask_Click);
            // 
            // listBox1
            // 
            this.listBox1.DisplayMember = "Name";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(624, 181);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(366, 379);
            this.listBox1.TabIndex = 1;
            this.listBox1.ValueMember = "Name";
            // 
            // btnGetWithAsync
            // 
            this.btnGetWithAsync.Location = new System.Drawing.Point(79, 346);
            this.btnGetWithAsync.Name = "btnGetWithAsync";
            this.btnGetWithAsync.Size = new System.Drawing.Size(265, 128);
            this.btnGetWithAsync.TabIndex = 2;
            this.btnGetWithAsync.Text = "Get with Async";
            this.btnGetWithAsync.UseVisualStyleBackColor = true;
            this.btnGetWithAsync.Click += new System.EventHandler(this.GetWithAsync_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(79, 536);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(265, 139);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel Process";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 807);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGetWithAsync);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGetWithTask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetWithTask;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnGetWithAsync;
        private System.Windows.Forms.Button btnCancel;
    }
}

