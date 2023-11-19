using EntityFrameworkL5.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkL5
{
    public partial class Form1 : Form
    {
        private Category categoryModel;
        private Product productModel;
        private KeyLink keyLinkModel;
        private Word wordModel;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (EfLesson3Context db = new EfLesson3Context())
            {
                categoryModel = new Category()
                {
                    Name = categoryName.Text,
                    Icon = categoryIcon.Text
                };
                double.TryParse(productPrice.Text, out double pr);
                double.TryParse(productActionPrice.Text, out double acPr);

                productModel = new Product()
                {
                    Name = productName.Text,
                    Price = pr,
                    ActionPrice = acPr,
                    DescriptionField1 = productDescriptionF1.Text,
                    DescriptionField2 = productDescriptionF2.Text,
                    ImageUrl = productImageUrl.Text,
                    Category = categoryModel
                };

                wordModel = new Word()
                {
                    Header = wordHeader.Text,
                    KeyWord = wordKeyWord.Text
                };

                keyLinkModel = new KeyLink()
                {
                    KeyWords = wordModel,
                    Product = productModel
                };

                db.Categories.Add(categoryModel);
                db.Products.Add(productModel);
                db.Words.Add(wordModel);
                db.KeyLinks.Add(keyLinkModel);

                db.SaveChanges();
            }
            categoryName.Text = "Name";
            categoryIcon.Text = "Icon";
            productName.Text = "Name";
            productPrice.Text = "Price";
            productActionPrice.Text = "ActionPrice";
            productDescriptionF1.Text = "Description1";
            productDescriptionF2.Text = "Description2";
            productImageUrl.Text = "ImageUrl";
            wordHeader.Text = "KeyWord";
            wordHeader.Text = "Header";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (EfLesson3Context db = new EfLesson3Context())
            {
                {
                    // Отримайте вибраний шлях
                    string backupPath = Environment.CurrentDirectory + @$"\{nameOfBackup.Text}.bak";

                    db.Database.ExecuteSqlRaw($"BACKUP DATABASE {db.Database.GetDbConnection().Database} TO DISK = '{backupPath}'");
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Устанавливаем фильтр для файлов с расширением .bak
            openFileDialog.Filter = "BAK Files (*.bak)|*.bak";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = openFileDialog.FileName;

                textBox1.Text = selectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatabaseService.RestoreDatabase(textBox1.Text);
            label4.Text = "Success";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            BaseEntity entity = null;
            switch (comboBox1.Text)
            {
                case "Category":
                    {
                        entity = new Category();
                        break;
                    }
                case "Product":
                    {
                        entity = new Product();
                        break;
                    }
                case "Words":
                    {
                        entity = new Word();
                        break;
                    }
            }

            DeleteForm delete = new DeleteForm(entity);
            delete.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}