namespace Notenplana23
{
    partial class ViewLoggin
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
            buttonLoggin = new Button();
            buttonRegestrieren = new Button();
            labelLoggin = new Label();
            labelBenutzername = new Label();
            labelPasswort = new Label();
            textBoxBenutzername = new TextBox();
            textBoxPasswort = new TextBox();
            SuspendLayout();
            // 
            // buttonLoggin
            // 
            buttonLoggin.Location = new Point(220, 184);
            buttonLoggin.Margin = new Padding(2);
            buttonLoggin.Name = "buttonLoggin";
            buttonLoggin.Size = new Size(79, 20);
            buttonLoggin.TabIndex = 0;
            buttonLoggin.Text = "Loggin";
            buttonLoggin.UseVisualStyleBackColor = true;
            buttonLoggin.Click += buttonLoggin_Click;
            // 
            // buttonRegestrieren
            // 
            buttonRegestrieren.Location = new Point(214, 220);
            buttonRegestrieren.Margin = new Padding(2);
            buttonRegestrieren.Name = "buttonRegestrieren";
            buttonRegestrieren.Size = new Size(91, 20);
            buttonRegestrieren.TabIndex = 1;
            buttonRegestrieren.Text = "Regestrieren";
            buttonRegestrieren.UseVisualStyleBackColor = true;
            buttonRegestrieren.Click += buttonRegestrieren_Click;
            // 
            // labelLoggin
            // 
            labelLoggin.AutoSize = true;
            labelLoggin.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelLoggin.Location = new Point(220, 38);
            labelLoggin.Margin = new Padding(2, 0, 2, 0);
            labelLoggin.Name = "labelLoggin";
            labelLoggin.Size = new Size(73, 28);
            labelLoggin.TabIndex = 2;
            labelLoggin.Text = "Loggin";
            // 
            // labelBenutzername
            // 
            labelBenutzername.AutoSize = true;
            labelBenutzername.Location = new Point(85, 100);
            labelBenutzername.Margin = new Padding(2, 0, 2, 0);
            labelBenutzername.Name = "labelBenutzername";
            labelBenutzername.Size = new Size(89, 15);
            labelBenutzername.TabIndex = 3;
            labelBenutzername.Text = "Benutzername :";
            // 
            // labelPasswort
            // 
            labelPasswort.AutoSize = true;
            labelPasswort.Location = new Point(85, 140);
            labelPasswort.Margin = new Padding(2, 0, 2, 0);
            labelPasswort.Name = "labelPasswort";
            labelPasswort.Size = new Size(60, 15);
            labelPasswort.TabIndex = 4;
            labelPasswort.Text = "Passwort :";
            // 
            // textBoxBenutzername
            // 
            textBoxBenutzername.Location = new Point(192, 98);
            textBoxBenutzername.Margin = new Padding(2);
            textBoxBenutzername.Name = "textBoxBenutzername";
            textBoxBenutzername.Size = new Size(165, 23);
            textBoxBenutzername.TabIndex = 5;
            // 
            // textBoxPasswort
            // 
            textBoxPasswort.Location = new Point(192, 140);
            textBoxPasswort.Margin = new Padding(2);
            textBoxPasswort.Name = "textBoxPasswort";
            textBoxPasswort.PasswordChar = '*';
            textBoxPasswort.Size = new Size(165, 23);
            textBoxPasswort.TabIndex = 6;
            // 
            // ViewLoggin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(textBoxPasswort);
            Controls.Add(textBoxBenutzername);
            Controls.Add(labelPasswort);
            Controls.Add(labelBenutzername);
            Controls.Add(labelLoggin);
            Controls.Add(buttonRegestrieren);
            Controls.Add(buttonLoggin);
            Margin = new Padding(2);
            Name = "ViewLoggin";
            Text = "ViewLoggin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLoggin;
        private Button buttonRegestrieren;
        private Label labelLoggin;
        private Label labelBenutzername;
        private Label labelPasswort;
        private TextBox textBoxBenutzername;
        private TextBox textBoxPasswort;
    }
}