namespace EntityFrameworkL5
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
            this.label1 = new System.Windows.Forms.Label();
            this.categoryName = new System.Windows.Forms.TextBox();
            this.categoryIcon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.productActionPrice = new System.Windows.Forms.TextBox();
            this.productDescriptionF1 = new System.Windows.Forms.TextBox();
            this.productDescriptionF2 = new System.Windows.Forms.TextBox();
            this.productImageUrl = new System.Windows.Forms.TextBox();
            this.wordKeyWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.wordHeader = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nameOfBackup = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter category";
            // 
            // categoryName
            // 
            this.categoryName.Location = new System.Drawing.Point(15, 34);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(125, 27);
            this.categoryName.TabIndex = 1;
            this.categoryName.Text = "Name";
            // 
            // categoryIcon
            // 
            this.categoryIcon.Location = new System.Drawing.Point(15, 67);
            this.categoryIcon.Name = "categoryIcon";
            this.categoryIcon.Size = new System.Drawing.Size(125, 27);
            this.categoryIcon.TabIndex = 2;
            this.categoryIcon.Text = "Icon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter product";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(15, 125);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(125, 27);
            this.productName.TabIndex = 4;
            this.productName.Text = "Name";
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(15, 158);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(125, 27);
            this.productPrice.TabIndex = 5;
            this.productPrice.Text = "Price";
            // 
            // productActionPrice
            // 
            this.productActionPrice.Location = new System.Drawing.Point(15, 191);
            this.productActionPrice.Name = "productActionPrice";
            this.productActionPrice.Size = new System.Drawing.Size(125, 27);
            this.productActionPrice.TabIndex = 6;
            this.productActionPrice.Text = "ActionPrice";
            // 
            // productDescriptionF1
            // 
            this.productDescriptionF1.Location = new System.Drawing.Point(15, 224);
            this.productDescriptionF1.Name = "productDescriptionF1";
            this.productDescriptionF1.Size = new System.Drawing.Size(125, 27);
            this.productDescriptionF1.TabIndex = 7;
            this.productDescriptionF1.Text = "Description1";
            // 
            // productDescriptionF2
            // 
            this.productDescriptionF2.Location = new System.Drawing.Point(15, 257);
            this.productDescriptionF2.Name = "productDescriptionF2";
            this.productDescriptionF2.Size = new System.Drawing.Size(125, 27);
            this.productDescriptionF2.TabIndex = 8;
            this.productDescriptionF2.Text = "Description2";
            // 
            // productImageUrl
            // 
            this.productImageUrl.Location = new System.Drawing.Point(15, 290);
            this.productImageUrl.Name = "productImageUrl";
            this.productImageUrl.Size = new System.Drawing.Size(125, 27);
            this.productImageUrl.TabIndex = 9;
            this.productImageUrl.Text = "ImageUrl";
            // 
            // wordKeyWord
            // 
            this.wordKeyWord.Location = new System.Drawing.Point(15, 343);
            this.wordKeyWord.Name = "wordKeyWord";
            this.wordKeyWord.Size = new System.Drawing.Size(125, 27);
            this.wordKeyWord.TabIndex = 10;
            this.wordKeyWord.Text = "KeyWord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter word";
            // 
            // wordHeader
            // 
            this.wordHeader.Location = new System.Drawing.Point(15, 376);
            this.wordHeader.Name = "wordHeader";
            this.wordHeader.Size = new System.Drawing.Size(125, 27);
            this.wordHeader.TabIndex = 12;
            this.wordHeader.Text = "Header";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "Create Backup";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nameOfBackup
            // 
            this.nameOfBackup.Location = new System.Drawing.Point(305, 67);
            this.nameOfBackup.Name = "nameOfBackup";
            this.nameOfBackup.Size = new System.Drawing.Size(152, 27);
            this.nameOfBackup.TabIndex = 15;
            this.nameOfBackup.Text = "Enter name of backup";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(303, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 29);
            this.button3.TabIndex = 16;
            this.button3.Text = "Restore database";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(306, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 29);
            this.button4.TabIndex = 17;
            this.button4.Text = "Choose restore file";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 325);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "result";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Category",
            "Product",
            "Words"});
            this.comboBox1.Location = new System.Drawing.Point(306, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Choose table to delete-update";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(303, 215);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(154, 29);
            this.deleteBtn.TabIndex = 20;
            this.deleteBtn.Text = "Delete update data";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(498, 461);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.nameOfBackup);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wordHeader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wordKeyWord);
            this.Controls.Add(this.productImageUrl);
            this.Controls.Add(this.productDescriptionF2);
            this.Controls.Add(this.productDescriptionF1);
            this.Controls.Add(this.productActionPrice);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryIcon);
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label label1;
        private TextBox categoryName;
        private TextBox categoryIcon;
        private Label label2;
        private TextBox productName;
        private TextBox productPrice;
        private TextBox productActionPrice;
        private TextBox productDescriptionF1;
        private TextBox productDescriptionF2;
        private TextBox productImageUrl;
        private TextBox wordKeyWord;
        private Label label3;
        private TextBox wordHeader;
        private Button button1;
        private Button button2;
        private TextBox nameOfBackup;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private Button deleteBtn;
    }
}