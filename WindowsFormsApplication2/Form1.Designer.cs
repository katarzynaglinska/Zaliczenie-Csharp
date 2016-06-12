namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.btndodajzalacznik = new System.Windows.Forms.Button();
            this.txtzalacznik = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTwojmail = new System.Windows.Forms.TextBox();
            this.txthaslo = new System.Windows.Forms.TextBox();
            this.txtodbiorca = new System.Windows.Forms.TextBox();
            this.txttemat = new System.Windows.Forms.TextBox();
            this.txttresc = new System.Windows.Forms.TextBox();
            this.btnwyslij = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.itemsListboxLabel = new System.Windows.Forms.Label();
            this.produktyListbox = new System.Windows.Forms.ListBox();
            this.btndodaj = new System.Windows.Forms.Button();
            this.koszykListbox = new System.Windows.Forms.ListBox();
            this.shoppingcardListboxLabel = new System.Windows.Forms.Label();
            this.btnkup = new System.Windows.Forms.Button();
            this.labelcena = new System.Windows.Forms.Label();
            this.labelsuma = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndodajzalacznik
            // 
            this.btndodajzalacznik.Location = new System.Drawing.Point(257, 80);
            this.btndodajzalacznik.Name = "btndodajzalacznik";
            this.btndodajzalacznik.Size = new System.Drawing.Size(57, 28);
            this.btndodajzalacznik.TabIndex = 0;
            this.btndodajzalacznik.Text = "Dodaj";
            this.btndodajzalacznik.UseVisualStyleBackColor = true;
            this.btndodajzalacznik.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtzalacznik
            // 
            this.txtzalacznik.Enabled = false;
            this.txtzalacznik.Location = new System.Drawing.Point(78, 85);
            this.txtzalacznik.Name = "txtzalacznik";
            this.txtzalacznik.Size = new System.Drawing.Size(173, 20);
            this.txtzalacznik.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "hasło";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Załącznik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tytuł";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Treść";
            // 
            // txtTwojmail
            // 
            this.txtTwojmail.Location = new System.Drawing.Point(50, 23);
            this.txtTwojmail.Name = "txtTwojmail";
            this.txtTwojmail.Size = new System.Drawing.Size(134, 20);
            this.txtTwojmail.TabIndex = 8;
            // 
            // txthaslo
            // 
            this.txthaslo.Location = new System.Drawing.Point(224, 23);
            this.txthaslo.Name = "txthaslo";
            this.txthaslo.PasswordChar = '*';
            this.txthaslo.Size = new System.Drawing.Size(90, 20);
            this.txthaslo.TabIndex = 9;
            // 
            // txtodbiorca
            // 
            this.txtodbiorca.Location = new System.Drawing.Point(50, 52);
            this.txtodbiorca.Name = "txtodbiorca";
            this.txtodbiorca.Size = new System.Drawing.Size(201, 20);
            this.txtodbiorca.TabIndex = 10;
            // 
            // txttemat
            // 
            this.txttemat.Location = new System.Drawing.Point(44, 20);
            this.txttemat.Name = "txttemat";
            this.txttemat.Size = new System.Drawing.Size(264, 20);
            this.txttemat.TabIndex = 11;
            // 
            // txttresc
            // 
            this.txttresc.Location = new System.Drawing.Point(44, 42);
            this.txttresc.Multiline = true;
            this.txttresc.Name = "txttresc";
            this.txttresc.Size = new System.Drawing.Size(264, 104);
            this.txttresc.TabIndex = 12;
            // 
            // btnwyslij
            // 
            this.btnwyslij.Location = new System.Drawing.Point(218, 148);
            this.btnwyslij.Name = "btnwyslij";
            this.btnwyslij.Size = new System.Drawing.Size(90, 26);
            this.btnwyslij.TabIndex = 13;
            this.btnwyslij.Text = "Wyślij";
            this.btnwyslij.UseVisualStyleBackColor = true;
            this.btnwyslij.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtodbiorca);
            this.groupBox1.Controls.Add(this.txthaslo);
            this.groupBox1.Controls.Add(this.txtTwojmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtzalacznik);
            this.groupBox1.Controls.Add(this.btndodajzalacznik);
            this.groupBox1.Location = new System.Drawing.Point(445, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 295);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "W razie pytań napisz do nas maila używając Gmail";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnwyslij);
            this.groupBox2.Controls.Add(this.txttemat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txttresc);
            this.groupBox2.Location = new System.Drawing.Point(6, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 180);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // itemsListboxLabel
            // 
            this.itemsListboxLabel.AutoSize = true;
            this.itemsListboxLabel.Location = new System.Drawing.Point(9, 51);
            this.itemsListboxLabel.Name = "itemsListboxLabel";
            this.itemsListboxLabel.Size = new System.Drawing.Size(129, 13);
            this.itemsListboxLabel.TabIndex = 15;
            this.itemsListboxLabel.Text = "Lista produktów w sklepie";
            // 
            // produktyListbox
            // 
            this.produktyListbox.FormattingEnabled = true;
            this.produktyListbox.Location = new System.Drawing.Point(12, 67);
            this.produktyListbox.Name = "produktyListbox";
            this.produktyListbox.Size = new System.Drawing.Size(186, 212);
            this.produktyListbox.TabIndex = 16;
            // 
            // btndodaj
            // 
            this.btndodaj.Location = new System.Drawing.Point(210, 67);
            this.btndodaj.Name = "btndodaj";
            this.btndodaj.Size = new System.Drawing.Size(57, 43);
            this.btndodaj.TabIndex = 17;
            this.btndodaj.Text = "Dodaj produkt";
            this.btndodaj.UseVisualStyleBackColor = true;
            this.btndodaj.Click += new System.EventHandler(this.purchaseitem_Click);
            // 
            // koszykListbox
            // 
            this.koszykListbox.FormattingEnabled = true;
            this.koszykListbox.Location = new System.Drawing.Point(279, 67);
            this.koszykListbox.Name = "koszykListbox";
            this.koszykListbox.Size = new System.Drawing.Size(155, 147);
            this.koszykListbox.TabIndex = 19;
            // 
            // shoppingcardListboxLabel
            // 
            this.shoppingcardListboxLabel.AutoSize = true;
            this.shoppingcardListboxLabel.Location = new System.Drawing.Point(276, 51);
            this.shoppingcardListboxLabel.Name = "shoppingcardListboxLabel";
            this.shoppingcardListboxLabel.Size = new System.Drawing.Size(66, 13);
            this.shoppingcardListboxLabel.TabIndex = 18;
            this.shoppingcardListboxLabel.Text = "Twój koszyk";
            // 
            // btnkup
            // 
            this.btnkup.Location = new System.Drawing.Point(336, 275);
            this.btnkup.Name = "btnkup";
            this.btnkup.Size = new System.Drawing.Size(98, 20);
            this.btnkup.TabIndex = 20;
            this.btnkup.Text = "Kup";
            this.btnkup.UseVisualStyleBackColor = true;
            this.btnkup.Click += new System.EventHandler(this.podlicz_Click);
            // 
            // labelcena
            // 
            this.labelcena.AutoSize = true;
            this.labelcena.Location = new System.Drawing.Point(276, 254);
            this.labelcena.Name = "labelcena";
            this.labelcena.Size = new System.Drawing.Size(65, 13);
            this.labelcena.TabIndex = 21;
            this.labelcena.Text = "Do zapłaty: ";
            // 
            // labelsuma
            // 
            this.labelsuma.AutoSize = true;
            this.labelsuma.Location = new System.Drawing.Point(382, 254);
            this.labelsuma.Name = "labelsuma";
            this.labelsuma.Size = new System.Drawing.Size(22, 13);
            this.labelsuma.TabIndex = 22;
            this.labelsuma.Text = "$ 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(66, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Sklep ze słodyczami ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepPink;
            this.label8.Location = new System.Drawing.Point(218, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "\'\'Cukiereczek\'\'";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 22);
            this.button2.TabIndex = 26;
            this.button2.Text = "Podlicz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(783, 312);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelsuma);
            this.Controls.Add(this.labelcena);
            this.Controls.Add(this.btnkup);
            this.Controls.Add(this.koszykListbox);
            this.Controls.Add(this.shoppingcardListboxLabel);
            this.Controls.Add(this.btndodaj);
            this.Controls.Add(this.produktyListbox);
            this.Controls.Add(this.itemsListboxLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndodajzalacznik;
        private System.Windows.Forms.TextBox txtzalacznik;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTwojmail;
        private System.Windows.Forms.TextBox txthaslo;
        private System.Windows.Forms.TextBox txtodbiorca;
        private System.Windows.Forms.TextBox txttemat;
        private System.Windows.Forms.TextBox txttresc;
        private System.Windows.Forms.Button btnwyslij;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label itemsListboxLabel;
        private System.Windows.Forms.ListBox produktyListbox;
        private System.Windows.Forms.Button btndodaj;
        private System.Windows.Forms.ListBox koszykListbox;
        private System.Windows.Forms.Label shoppingcardListboxLabel;
        private System.Windows.Forms.Button btnkup;
        private System.Windows.Forms.Label labelcena;
        private System.Windows.Forms.Label labelsuma;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}

