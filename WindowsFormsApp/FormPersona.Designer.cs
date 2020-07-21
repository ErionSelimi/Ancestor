namespace WindowsFormsApp
{
    partial class FormPersona
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxPadre = new System.Windows.Forms.TextBox();
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewLista = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNomeCerca = new System.Windows.Forms.TextBox();
            this.buttonCercaGenitore = new System.Windows.Forms.Button();
            this.textBoxAncestor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Person Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Father Name: ";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(240, 20);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(199, 26);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxPadre
            // 
            this.textBoxPadre.Location = new System.Drawing.Point(240, 62);
            this.textBoxPadre.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPadre.Name = "textBoxPadre";
            this.textBoxPadre.Size = new System.Drawing.Size(199, 26);
            this.textBoxPadre.TabIndex = 2;
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Location = new System.Drawing.Point(240, 101);
            this.buttonAggiungi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(134, 32);
            this.buttonAggiungi.TabIndex = 3;
            this.buttonAggiungi.Text = "Add";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            this.buttonAggiungi.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "List";
            // 
            // dataGridViewLista
            // 
            this.dataGridViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLista.Location = new System.Drawing.Point(240, 159);
            this.dataGridViewLista.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewLista.Name = "dataGridViewLista";
            this.dataGridViewLista.ReadOnly = true;
            this.dataGridViewLista.Size = new System.Drawing.Size(328, 243);
            this.dataGridViewLista.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 452);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Person Name: ";
            // 
            // textBoxNomeCerca
            // 
            this.textBoxNomeCerca.Location = new System.Drawing.Point(240, 452);
            this.textBoxNomeCerca.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomeCerca.Name = "textBoxNomeCerca";
            this.textBoxNomeCerca.Size = new System.Drawing.Size(199, 26);
            this.textBoxNomeCerca.TabIndex = 5;
            // 
            // buttonCercaGenitore
            // 
            this.buttonCercaGenitore.Location = new System.Drawing.Point(472, 452);
            this.buttonCercaGenitore.Name = "buttonCercaGenitore";
            this.buttonCercaGenitore.Size = new System.Drawing.Size(188, 26);
            this.buttonCercaGenitore.TabIndex = 6;
            this.buttonCercaGenitore.Text = "Search Ancestor";
            this.buttonCercaGenitore.UseVisualStyleBackColor = true;
            this.buttonCercaGenitore.Click += new System.EventHandler(this.buttonSearchAncestor_Click);
            // 
            // textBoxAncestor
            // 
            this.textBoxAncestor.Location = new System.Drawing.Point(240, 496);
            this.textBoxAncestor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAncestor.Name = "textBoxAncestor";
            this.textBoxAncestor.ReadOnly = true;
            this.textBoxAncestor.Size = new System.Drawing.Size(199, 26);
            this.textBoxAncestor.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 496);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ancestor";
            // 
            // FormPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 558);
            this.Controls.Add(this.buttonCercaGenitore);
            this.Controls.Add(this.dataGridViewLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAggiungi);
            this.Controls.Add(this.textBoxPadre);
            this.Controls.Add(this.textBoxAncestor);
            this.Controls.Add(this.textBoxNomeCerca);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormPersona";
            this.Text = "Dr. Jekelius ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxPadre;
        private System.Windows.Forms.Button buttonAggiungi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewLista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNomeCerca;
        private System.Windows.Forms.Button buttonCercaGenitore;
        private System.Windows.Forms.TextBox textBoxAncestor;
        private System.Windows.Forms.Label label5;
    }
}

