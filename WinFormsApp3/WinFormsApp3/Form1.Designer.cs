namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            resultTextBox = new TextBox();
            yenioyunbtn = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 217);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ədəd axtarışı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 39);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Axtarılan ədəd";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(38, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(38, 130);
            button1.Name = "button1";
            button1.Size = new Size(214, 36);
            button1.TabIndex = 2;
            button1.Text = "Yoxla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.BackColor = Color.White;
            resultTextBox.Location = new Point(358, 28);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.ScrollBars = ScrollBars.Vertical;
            resultTextBox.Size = new Size(232, 181);
            resultTextBox.TabIndex = 1;
            // 
            // yenioyunbtn
            // 
            yenioyunbtn.Location = new Point(358, 222);
            yenioyunbtn.Name = "yenioyunbtn";
            yenioyunbtn.Size = new Size(232, 36);
            yenioyunbtn.TabIndex = 2;
            yenioyunbtn.Text = "Yeni oyun";
            yenioyunbtn.UseVisualStyleBackColor = true;
            yenioyunbtn.Click += yenioyunbtn_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 0, 0);
            ClientSize = new Size(616, 276);
            Controls.Add(yenioyunbtn);
            Controls.Add(resultTextBox);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Random number";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private TextBox resultTextBox;
        private Button yenioyunbtn;
        private ErrorProvider errorProvider1;

        #endregion
    }
}
