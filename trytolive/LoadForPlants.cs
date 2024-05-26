using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace trytolive
{
    internal class LoadForPlants
    {
        public static void LoadPictureForPlants(int index, PictureBox pictureBox)
        {
            try
            {
                string[] imagePaths = {
                     "C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\Plants\\Algae.png",
                    "C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\Plants\\Algae.png",
                    "C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\Plants\\Wheat.png",
                    "C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\Plants\\Cabbage.png",
                    "C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\Plants\\Sunflower.png",
                    "C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\Plants\\Phytoplankton.png",
                    "C:\\Users\\yakaz\\source\\repos\\trytolive\\trytolive\\Images\\Plants\\Cactus.png"
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
