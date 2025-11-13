namespace TaskFormApp
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
            B_GUI_TaskAppAsekronRead = new Button();
            B_GUI_richTextBoxDosyaShow = new RichTextBox();
            B_GUI_SayacCounter = new Button();
            GUI_TextBoxCounter = new TextBox();
            SuspendLayout();
            // 
            // B_GUI_TaskAppAsekronRead
            // 
            B_GUI_TaskAppAsekronRead.BackColor = Color.FromArgb(255, 192, 128);
            B_GUI_TaskAppAsekronRead.Location = new Point(28, 12);
            B_GUI_TaskAppAsekronRead.Name = "B_GUI_TaskAppAsekronRead";
            B_GUI_TaskAppAsekronRead.Size = new Size(319, 35);
            B_GUI_TaskAppAsekronRead.TabIndex = 0;
            B_GUI_TaskAppAsekronRead.Text = "Dosya Oku";
            B_GUI_TaskAppAsekronRead.UseVisualStyleBackColor = false;
            B_GUI_TaskAppAsekronRead.Click += B_GUI_TaskAppAsekronRead_Click;
            // 
            // B_GUI_richTextBoxDosyaShow
            // 
            B_GUI_richTextBoxDosyaShow.Location = new Point(28, 53);
            B_GUI_richTextBoxDosyaShow.Name = "B_GUI_richTextBoxDosyaShow";
            B_GUI_richTextBoxDosyaShow.Size = new Size(319, 515);
            B_GUI_richTextBoxDosyaShow.TabIndex = 1;
            B_GUI_richTextBoxDosyaShow.Text = "";
            // 
            // B_GUI_SayacCounter
            // 
            B_GUI_SayacCounter.Location = new Point(434, 71);
            B_GUI_SayacCounter.Name = "B_GUI_SayacCounter";
            B_GUI_SayacCounter.Size = new Size(148, 45);
            B_GUI_SayacCounter.TabIndex = 2;
            B_GUI_SayacCounter.Text = "+ Sayaç";
            B_GUI_SayacCounter.UseVisualStyleBackColor = true;
            B_GUI_SayacCounter.Click += B_GUI_SayacCounter_Click;
            // 
            // GUI_TextBoxCounter
            // 
            GUI_TextBoxCounter.Location = new Point(434, 12);
            GUI_TextBoxCounter.Multiline = true;
            GUI_TextBoxCounter.Name = "GUI_TextBoxCounter";
            GUI_TextBoxCounter.Size = new Size(148, 42);
            GUI_TextBoxCounter.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 678);
            Controls.Add(GUI_TextBoxCounter);
            Controls.Add(B_GUI_SayacCounter);
            Controls.Add(B_GUI_richTextBoxDosyaShow);
            Controls.Add(B_GUI_TaskAppAsekronRead);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button B_GUI_TaskAppAsekronRead;
        private RichTextBox B_GUI_richTextBoxDosyaShow;
        private Button B_GUI_SayacCounter;
        private TextBox GUI_TextBoxCounter;
    }
}
