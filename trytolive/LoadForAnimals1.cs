using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace trytolive
{
    internal class LoadForAnimals1
    {
        public static void LoadPictureForFirstAnimals(int index, PictureBox pictureBox)
        {
            try
            {
                string[] imagePaths = {
                    "C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\Animals1\\Rodent.png",
                    "C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\Animals1\\Plant_eating.png",
                    "C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\Animals1\\Hare.png",
                    "C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\Animals1\\Zooplankton.png",
                    "C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\Animals1\\Goat.png",
                    "C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\Animals1\\Shellfish.png"
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
