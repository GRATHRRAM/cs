namespace Math_Game
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.c_anser = new System.Windows.Forms.CheckBox();
            this.mno = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.dziel = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.RichTextBox();
            this.to = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.TextBox();
            this.heck = new System.Windows.Forms.Button();
            this.lab1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // c_anser
            // 
            this.c_anser.AutoSize = true;
            this.c_anser.Location = new System.Drawing.Point(12, 12);
            this.c_anser.Name = "c_anser";
            this.c_anser.Size = new System.Drawing.Size(90, 17);
            this.c_anser.TabIndex = 1;
            this.c_anser.Text = "Show answer";
            this.c_anser.UseVisualStyleBackColor = true;
            this.c_anser.CheckedChanged += new System.EventHandler(this.c_anser_CheckedChanged);
            // 
            // mno
            // 
            this.mno.Location = new System.Drawing.Point(214, 265);
            this.mno.Name = "mno";
            this.mno.Size = new System.Drawing.Size(75, 40);
            this.mno.TabIndex = 3;
            this.mno.Text = "*";
            this.mno.UseVisualStyleBackColor = true;
            this.mno.Click += new System.EventHandler(this.button1_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(214, 222);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 37);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.button2_Click);
            // 
            // dziel
            // 
            this.dziel.Location = new System.Drawing.Point(319, 265);
            this.dziel.Name = "dziel";
            this.dziel.Size = new System.Drawing.Size(78, 40);
            this.dziel.TabIndex = 5;
            this.dziel.Text = "/";
            this.dziel.UseVisualStyleBackColor = true;
            this.dziel.Click += new System.EventHandler(this.dziel_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(319, 222);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(78, 37);
            this.minus.TabIndex = 6;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(170, 25);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(262, 153);
            this.txt.TabIndex = 7;
            this.txt.Text = "";
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(287, 9);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(26, 13);
            this.to.TabIndex = 8;
            this.to.Text = "To?";
            this.to.Click += new System.EventHandler(this.to_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "if you type lether the program be ded : ( ";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(214, 311);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(85, 57);
            this.clear.TabIndex = 10;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // ans
            // 
            this.ans.Location = new System.Drawing.Point(170, 196);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(262, 20);
            this.ans.TabIndex = 11;
            this.ans.Text = "Answer:";
            // 
            // heck
            // 
            this.heck.Location = new System.Drawing.Point(305, 311);
            this.heck.Name = "heck";
            this.heck.Size = new System.Drawing.Size(89, 57);
            this.heck.TabIndex = 12;
            this.heck.Text = "Check";
            this.heck.UseVisualStyleBackColor = true;
            this.heck.Click += new System.EventHandler(this.heck_Click);
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(439, 25);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(35, 13);
            this.lab1.TabIndex = 13;
            this.lab1.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 380);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.heck);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.to);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.dziel);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.mno);
            this.Controls.Add(this.c_anser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Math_Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox c_anser;
        private System.Windows.Forms.Button mno;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button dziel;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear;
        public System.Windows.Forms.RichTextBox txt;
        private System.Windows.Forms.TextBox ans;
        private System.Windows.Forms.Button heck;
        private System.Windows.Forms.Label lab1;
    }
}

