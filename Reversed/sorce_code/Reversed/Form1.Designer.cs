namespace Reversed
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
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.brev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(160, 84);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(338, 20);
            this.t1.TabIndex = 0;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(160, 110);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(338, 20);
            this.t2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type some thig";
            // 
            // brev
            // 
            this.brev.Location = new System.Drawing.Point(160, 171);
            this.brev.Name = "brev";
            this.brev.Size = new System.Drawing.Size(338, 23);
            this.brev.TabIndex = 3;
            this.brev.Text = "Reverse";
            this.brev.UseVisualStyleBackColor = true;
            this.brev.Click += new System.EventHandler(this.brev_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 419);
            this.Controls.Add(this.brev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Reversed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brev;
    }
}

