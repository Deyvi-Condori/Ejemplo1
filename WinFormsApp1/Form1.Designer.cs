namespace WinFormsApp1
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
            lblResultado = new TextBox();
            button2 = new Button();
            label1 = new Label();
            Usted = new Label();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.Location = new Point(453, 46);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(100, 23);
            lblResultado.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(453, 114);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Verificar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 54);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 6;
            label1.Text = "Edad";
            label1.Click += label1_Click;
            // 
            // Usted
            // 
            Usted.AutoSize = true;
            Usted.Location = new Point(357, 170);
            Usted.Name = "Usted";
            Usted.Size = new Size(88, 15);
            Usted.TabIndex = 7;
            Usted.Text = "Usted es mayor";
            Usted.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 244);
            Controls.Add(Usted);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(lblResultado);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox lblResultado;
        private Button button2;
        private Label label1;
        private Label Usted;
    }
}