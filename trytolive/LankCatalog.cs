using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trytolive
{
    public partial class LankCatalog : Form
    {
        private int targetWidth = 200; 
        private int targetHeight = 200;
        public LankCatalog()
        {
            InitializeComponent();
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
        private Image ResizeImage(Image image)
        {
            Bitmap resizedImage = new Bitmap(targetWidth, targetHeight);
            int posX = (targetWidth - image.Width) / 2;
            int posY = (targetHeight - image.Height) / 2;

            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, targetWidth, targetHeight);
                graphics.DrawImage(image, posX, posY, image.Width, image.Height);
            }
            return resizedImage;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;

            pictureBox5.Image = Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\arrow.png");
            pictureBox6.Image = Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\arrow.png");
            pictureBox7.Image = Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\arrow.png");

            int selectedItem = comboBox1.SelectedIndex;
            try
            {
                switch (selectedItem)
                {      
                    case 0:
                        pictureBox1.Image = ResizeImage( Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\taiga\\pine.png"));
                        pictureBox2.Image = ResizeImage(Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\taiga\\bark_beetle.png"));
                        pictureBox3.Image = ResizeImage(Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\taiga\\Woodpecker.png"));
                        pictureBox4.Image = ResizeImage(Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\taiga\\Hawk.png"));
                        break;

                    case 1:
                        pictureBox1.Image = ResizeImage(Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\desert\\Cactus.png"));
                        pictureBox2.Image = ResizeImage(Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\desert\\locust.png"));
                        pictureBox3.Image = ResizeImage(Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\desert\\Lizard.png"));
                        pictureBox4.Image = ResizeImage(Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\desert\\Snake.png"));
                        break;

                    case 2:
                        pictureBox1.Image = ResizeImage(Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\tropics\\creepers.png"));
                        pictureBox2.Image = ResizeImage(Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\tropics\\Caterpillar.png"));
                        pictureBox3.Image = ResizeImage(Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\tropics\\Monkey.png"));
                        pictureBox4.Image = ResizeImage(Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\tropics\\leopard.png"));
                        break;

                    case 3:
                        pictureBox1.Image = ResizeImage(Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\savannah\\grass.png"));
                        pictureBox2.Image = ResizeImage(Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\savannah\\Zebra.png"));
                        pictureBox3.Image = ResizeImage(Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\savannah\\Hyena.png"));
                        pictureBox4.Image = ResizeImage(Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\savannah\\Lion.png"));
                        break;

                    case 4:
                        pictureBox1.Image = ResizeImage(Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\ocean\\Algae.png"));
                        pictureBox2.Image = ResizeImage(Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\ocean\\Shellfish.png"));
                        pictureBox3.Image = ResizeImage(Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\ocean\\bonito.png"));
                        pictureBox4.Image = ResizeImage(Image.FromFile("C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\For_Catalog\\ocean\\hammer.png"));
                        break;

                    default:
                        pictureBox1.Image = null;
                        pictureBox2.Image = null;
                        pictureBox3.Image = null;
                        pictureBox4.Image = null;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження зображення: " + ex.Message);
            }
        }
    }
}
