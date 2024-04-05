namespace NayttoTyo
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_nimi = new TextBox();
            txt_salasana = new TextBox();
            button_kirjaudu = new Button();
            button_alusta = new Button();
            button_poistu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(320, 47);
            label1.Name = "label1";
            label1.Size = new Size(162, 32);
            label1.TabIndex = 0;
            label1.Text = "Tervetuloa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 147);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Nimi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 198);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 1;
            label3.Text = "Salasana";
            // 
            // txt_nimi
            // 
            txt_nimi.Location = new Point(298, 147);
            txt_nimi.Name = "txt_nimi";
            txt_nimi.Size = new Size(211, 27);
            txt_nimi.TabIndex = 2;
            // 
            // txt_salasana
            // 
            txt_salasana.Location = new Point(298, 198);
            txt_salasana.Name = "txt_salasana";
            txt_salasana.Size = new Size(211, 27);
            txt_salasana.TabIndex = 2;
            // 
            // button_kirjaudu
            // 
            button_kirjaudu.Location = new Point(415, 247);
            button_kirjaudu.Name = "button_kirjaudu";
            button_kirjaudu.Size = new Size(94, 29);
            button_kirjaudu.TabIndex = 3;
            button_kirjaudu.Text = "Kirjaudu";
            button_kirjaudu.UseVisualStyleBackColor = true;
            button_kirjaudu.Click += button_kirjaudu_Click;
            // 
            // button_alusta
            // 
            button_alusta.Location = new Point(298, 247);
            button_alusta.Name = "button_alusta";
            button_alusta.Size = new Size(94, 29);
            button_alusta.TabIndex = 3;
            button_alusta.Text = "Tyhjennä";
            button_alusta.UseVisualStyleBackColor = true;
            button_alusta.Click += button_alusta_Click;
            // 
            // button_poistu
            // 
            button_poistu.Location = new Point(174, 333);
            button_poistu.Name = "button_poistu";
            button_poistu.Size = new Size(94, 29);
            button_poistu.TabIndex = 3;
            button_poistu.Text = "Poistu";
            button_poistu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_poistu);
            Controls.Add(button_alusta);
            Controls.Add(button_kirjaudu);
            Controls.Add(txt_salasana);
            Controls.Add(txt_nimi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_nimi;
        private TextBox txt_salasana;
        private Button button_kirjaudu;
        private Button button_alusta;
        private Button button_poistu;
    }
}
