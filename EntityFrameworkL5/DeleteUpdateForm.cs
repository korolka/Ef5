using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkL5.Models;

namespace EntityFrameworkL5
{
    public partial class DeleteForm : Form
    {
        BaseEntity baseEntity;

        public DeleteForm(BaseEntity entity)
        {
            InitializeComponent();

            baseEntity = entity;

            AddItems(baseEntity);
            AddItemsToUpdate(baseEntity);
        }
        public void AddItemsToUpdate(BaseEntity entity)
        {
            if (entity is Category)
            {
                textBox1.Text = "Name";
                textBox2.Text = "Icon";
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
            }
            else if (entity is Product)
            {
                textBox1.Text = "Name";
                textBox2.Text = "Price";
                textBox3.Text = "ActionPrice";
                textBox4.Text = "Description 1";
                textBox5.Text = "Description 2";
                textBox6.Text = "ImageUrl";

            }
            if (entity is Word)
            {
                textBox1.Text = "Header";
                textBox2.Text = "KeyWord";
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
            }
        }

        public void AddItems(BaseEntity entity)
        {
            if (entity is Product)
            {
                BaseRepository<Product> repository = new BaseRepository<Product>();

                List<Product> products = repository.Select();
                foreach (Product product in products)
                {
                    listBox1.Items.Add($"Id: {product.Id} Name: {product.Name}");
                }
                comboBox1.Items.AddRange(products.Select(w => (object)w.Id).ToArray());
            }
            else if (entity is Category)
            {
                BaseRepository<Category> repository = new BaseRepository<Category>();

                List<Category> categories = repository.Select();
                foreach (Category category in categories)
                {
                    listBox1.Items.Add($"Id: {category.Id} Name: {category.Name}");
                }
                comboBox1.Items.AddRange(categories.Select(w => (object)w.Id).ToArray());
            }
            else
            {
                if (entity is Word)
                {
                    BaseRepository<Word> repository = new BaseRepository<Word>();

                    List<Word> words = repository.Select();
                    foreach (Word word in words)
                    {
                        listBox1.Items.Add($"Id: {word.Id} Name: {word.KeyWord}");
                    }
                    comboBox1.Items.AddRange(words.Select(w => (object)w.Id).ToArray());

                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            bool res;
            int.TryParse(comboBox1.Text, out int id);
            if (baseEntity is Product)
            {
                BaseRepository<Product> repository = new BaseRepository<Product>();
                res = repository.Delete(repository.GetById(id));
                if (res)
                    label2.Text = "Delete success";
            }
            else if (baseEntity is Category)
            {
                BaseRepository<Category> repository = new BaseRepository<Category>();
                res = repository.Delete(repository.GetById(id));
                if (res)
                    label2.Text = "Delete success";
            }
            else
            {
                BaseRepository<Word> repository = new BaseRepository<Word>();
                res = repository.Delete(repository.GetById(id));
                if (res)
                    label2.Text = "Delete success";
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (baseEntity is Product)
            {
                int.TryParse(comboBox1.Text, out int id);
                double.TryParse(textBox2.Text,out double price);
                double.TryParse(textBox3.Text, out double actionPrice);

                Product product = new Product()
                {
                    Id = id,
                    Name = textBox1.Text,
                    Price = price,
                    ActionPrice = actionPrice,
                    DescriptionField1= textBox4.Text,
                    DescriptionField2= textBox5.Text,
                    ImageUrl = textBox6.Text

                };
                BaseRepository<Product> repository = new BaseRepository<Product>();
                bool res = repository.Update(product);
                if (res)
                    label3.Text = "Update success";
            }
            else if (baseEntity is Category)
            {
                int.TryParse(comboBox1.Text, out int id);
                Category category = new Category()
                {
                    Id = id,
                    Name = textBox1.Text,
                    Icon = textBox2.Text
                };
                BaseRepository<Category> repository = new BaseRepository<Category>();
                bool res = repository.Update(category);
                if (res)
                    label3.Text = "Update success";
            }
            if (baseEntity is Word)
            {
                int.TryParse(comboBox1.Text, out int id);
                Word word = new Word()
                {
                    Id = id,
                    Header = textBox1.Text,
                    KeyWord = textBox2.Text
                };
                BaseRepository<Word> repository = new BaseRepository<Word>();
                bool res = repository.Update(word);
                if (res)
                    label3.Text = "Update success";
            }
        }
    }

    public class BaseRepository<TEntity> where TEntity : BaseEntity
    {
        public bool Delete(TEntity entity)
        {
            using (EfLesson3Context db = new EfLesson3Context())
            {
                db.Remove(entity);
                db.SaveChanges();
                return true;
            }
        }

        public TEntity GetById(int id)
        {
            using (EfLesson3Context db = new EfLesson3Context())
            {
                return db.GetDbSet<TEntity>().SingleOrDefault(o => o.Id == id);
            }
        }

        public List<TEntity> Select()
        {
            using (EfLesson3Context db = new EfLesson3Context())
            {
                List<TEntity> entities = db.GetDbSet<TEntity>().ToList();
                return entities;
            }
        }
        public bool Update(TEntity entity)
        {
            using (EfLesson3Context db = new EfLesson3Context())
            {
                db.Update(entity);
                db.SaveChanges();
                return true;
            }
        }
    }
}
