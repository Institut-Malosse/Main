namespace Exo1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrénom = new System.Windows.Forms.TextBox();
            this.TxtDateNaissance = new System.Windows.Forms.TextBox();
            this.TxtAutreDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appuyez sur Run pour lancer le programme";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date de naissance :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date à comparer :";
            // 
            // TxtPrénom
            // 
            this.TxtPrénom.Location = new System.Drawing.Point(66, 18);
            this.TxtPrénom.Name = "TxtPrénom";
            this.TxtPrénom.Size = new System.Drawing.Size(100, 23);
            this.TxtPrénom.TabIndex = 5;
            // 
            // TxtDateNaissance
            // 
            this.TxtDateNaissance.Location = new System.Drawing.Point(118, 84);
            this.TxtDateNaissance.Name = "TxtDateNaissance";
            this.TxtDateNaissance.Size = new System.Drawing.Size(100, 23);
            this.TxtDateNaissance.TabIndex = 6;
            // 
            // TxtAutreDate
            // 
            this.TxtAutreDate.Location = new System.Drawing.Point(111, 158);
            this.TxtAutreDate.Name = "TxtAutreDate";
            this.TxtAutreDate.Size = new System.Drawing.Size(100, 23);
            this.TxtAutreDate.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 323);
            this.Controls.Add(this.TxtAutreDate);
            this.Controls.Add(this.TxtDateNaissance);
            this.Controls.Add(this.TxtPrénom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtPrénom;
        private TextBox TxtDateNaissance;
        private TextBox TxtAutreDate;
    }
}