using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace mat_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Go_button = new Button();
            label1 = new Label();
            cueTextBox2 = new YOUR_NAMESPACE_HERE.CueTextBox();
            SuspendLayout();
            // 
            // Go_button
            // 
            Go_button.Location = new Point(450, 280);
            Go_button.Name = "Go_button";
            Go_button.Size = new Size(100, 29);
            Go_button.TabIndex = 1;
            Go_button.Text = "Go";
            Go_button.UseVisualStyleBackColor = true;
            Go_button.Click += Go_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 330);
            label1.MaximumSize = new Size(400, 100);
            label1.MinimumSize = new Size(400, 200);
            label1.Name = "label1";
            label1.Size = new Size(400, 200);
            label1.TabIndex = 2;
            label1.Text = " ";
            label1.Visible = false;
            // 
            // cueTextBox2
            // 
            cueTextBox2.AutoCompleteMode = AutoCompleteMode.Append;
            cueTextBox2.Cue = "Enter number";
            cueTextBox2.Location = new Point(300, 230);
            cueTextBox2.Name = "cueTextBox2";
            cueTextBox2.Size = new Size(400, 27);
            cueTextBox2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 653);
            Controls.Add(cueTextBox2);
            Controls.Add(label1);
            Controls.Add(Go_button);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1000, 700);
            MinimumSize = new Size(1000, 700);
            Name = "Form1";
            Text = "Matematyka dyskretna";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button Go_button;
        private Label label1;
        private YOUR_NAMESPACE_HERE.CueTextBox cueTextBox2;
    }
}