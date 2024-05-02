namespace gestionContacts
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            newFirstname = new TextBox();
            newLastname = new TextBox();
            newPhone = new TextBox();
            ajoutContact = new Button();
            delete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(485, 150);
            dataGridView1.TabIndex = 0;
            // 
            // newFirstname
            // 
            newFirstname.Location = new Point(12, 72);
            newFirstname.Name = "newFirstname";
            newFirstname.Size = new Size(140, 23);
            newFirstname.TabIndex = 1;
            // 
            // newLastname
            // 
            newLastname.Location = new Point(174, 72);
            newLastname.Name = "newLastname";
            newLastname.Size = new Size(140, 23);
            newLastname.TabIndex = 2;
            // 
            // newPhone
            // 
            newPhone.Location = new Point(357, 72);
            newPhone.Name = "newPhone";
            newPhone.Size = new Size(140, 23);
            newPhone.TabIndex = 3;
            // 
            // ajoutContact
            // 
            ajoutContact.Location = new Point(395, 103);
            ajoutContact.Name = "ajoutContact";
            ajoutContact.Size = new Size(75, 23);
            ajoutContact.TabIndex = 4;
            ajoutContact.Text = "Ajouter";
            ajoutContact.UseVisualStyleBackColor = true;
            ajoutContact.Click += ajoutContact_Click;
            // 
            // delete
            // 
            delete.Location = new Point(395, 316);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 5;
            delete.Text = "Supprimer";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 54);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 6;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 54);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 7;
            label2.Text = "LastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(395, 54);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 8;
            label3.Text = "Phone";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(520, 354);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(delete);
            Controls.Add(ajoutContact);
            Controls.Add(newPhone);
            Controls.Add(newLastname);
            Controls.Add(newFirstname);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Contacts";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private TextBox newFirstname;
        private TextBox newLastname;
        private TextBox newPhone;
        private Button ajoutContact;
        private Button delete;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
