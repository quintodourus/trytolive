using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace trytolive
{
    internal class LoadForAnimals3
    {
        public static void LoadPictureForAnimals3(int index, PictureBox pictureBox)
        {
            try
            {
                string[] imagePaths = {
                    "C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\Animals3\\Wolf.png",
                    "C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\Animals3\\Fish.png",
                    "C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\Animals3\\Leopard.png",
                    "C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\Animals3\\Bear.png",
                    "C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\Animals3\\Jackal.png"
                };
                Image image = Image.FromFile(imagePaths[index]);
                image = new Bitmap(image, new Size(200, 200));

                if (index >= 0 && index < imagePaths.Length)
                {
                    pictureBox.Image = Image.FromFile(imagePaths[index]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження зображення: " + ex.Message);
            }
        }
    }
}
