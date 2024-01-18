namespace Uczelnia
{
    partial class DodajKierownikaWydzialuForm
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
            buttonAddKierownik = new Button();
            textBoxName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxWydzialID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonAddKierownik
            // 
            buttonAddKierownik.Location = new Point(114, 302);
            buttonAddKierownik.Name = "buttonAddKierownik";
            buttonAddKierownik.Size = new Size(233, 29);
            buttonAddKierownik.TabIndex = 0;
            buttonAddKierownik.Text = "Dodaj Kierownika Wydzialu";
            buttonAddKierownik.UseVisualStyleBackColor = true;
            buttonAddKierownik.Click += buttonAddKierownik_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(162, 126);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(163, 179);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(125, 27);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxWydzialID
            // 
            textBoxWydzialID.Location = new Point(162, 234);
            textBoxWydzialID.Name = "textBoxWydzialID";
            textBoxWydzialID.Size = new Size(125, 27);
            textBoxWydzialID.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 92);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 4;
            label1.Text = "Imie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 156);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 5;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 209);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 6;
            label3.Text = "ID Wydziału";
            // 
            // DodajKierownikaWydzialuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxWydzialID);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxName);
            Controls.Add(buttonAddKierownik);
            Name = "DodajKierownikaWydzialuForm";
            Text = "DodajKierownikaWydzialuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddKierownik;
        private TextBox textBoxName;
        private TextBox textBoxLastName;
        private TextBox textBoxWydzialID;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}