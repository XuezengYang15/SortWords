namespace SortWords
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.sortWords = new System.Windows.Forms.Button();
            this.outputMessage = new System.Windows.Forms.Label();
            this.submitWordButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(182, 169);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(125, 27);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(195, 202);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(94, 29);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // sortWords
            // 
            this.sortWords.Location = new System.Drawing.Point(195, 272);
            this.sortWords.Name = "sortWords";
            this.sortWords.Size = new System.Drawing.Size(94, 29);
            this.sortWords.TabIndex = 2;
            this.sortWords.Text = "Sort Words";
            this.sortWords.UseVisualStyleBackColor = true;
            this.sortWords.Click += new System.EventHandler(this.sortWords_Click);
            // 
            // outputMessage
            // 
            this.outputMessage.AutoSize = true;
            this.outputMessage.Location = new System.Drawing.Point(182, 108);
            this.outputMessage.Name = "outputMessage";
            this.outputMessage.Size = new System.Drawing.Size(273, 20);
            this.outputMessage.TabIndex = 3;
            this.outputMessage.Text = "How many words do you want to enter?";
            this.outputMessage.Click += new System.EventHandler(this.outputMessage_Click);
            // 
            // submitWordButton
            // 
            this.submitWordButton.Location = new System.Drawing.Point(195, 237);
            this.submitWordButton.Name = "submitWordButton";
            this.submitWordButton.Size = new System.Drawing.Size(94, 29);
            this.submitWordButton.TabIndex = 5;
            this.submitWordButton.Text = "Submit";
            this.submitWordButton.UseVisualStyleBackColor = true;
            this.submitWordButton.Visible = false;
            this.submitWordButton.Click += new System.EventHandler(this.submitWordButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(502, 169);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 20);
            this.label.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.submitWordButton);
            this.Controls.Add(this.outputMessage);
            this.Controls.Add(this.sortWords);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox;
        private Button submitButton;
        private Button sortWords;
        private Label outputMessage;
        private Button submitWordButton;
        private Label label;
    }
}