using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trytolive
{
    public partial class SupplyChain : Form
    {

        private int selectedButton = -1;
        public SupplyChain()
        {
            InitializeComponent();
            
        dataGridView1.DefaultCellStyle.Font = new Font("Verdana", 12, FontStyle.Regular);

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;

            label1.Visible = false;
            label2.Visible = false; 
            label3.Visible = false;

            dataGridView1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            

            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;

            
        }

        private void startProcces_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            MessageBox.Show("Оберіть кількість ланок у ланцюгу харчування");


            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
        }

        public void ShowControls()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

            dataGridView1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;

            
        }
        
       

        

        private void Organism1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Може бути обрано мінімум 2 ланки");
        }

        private void Organism2_Click(object sender, EventArgs e)
        {
            
            selectedButton = 1;

                comboBox1.Visible = true;
                comboBox2.Visible = true;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;

            button6.Visible = true;
            button7.Visible = true;

            button3.Visible = false;
            button4.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;

            ShowControls();
        }

        private void Organism3_Click(object sender, EventArgs e)
        {
           
            selectedButton = 2;

            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;


            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

            button6.Visible = true;
            button7.Visible = true;

            comboBox4.Visible=false;
            button4.Visible = false;

            ShowControls();
        }

        private void Organism4_Click(object sender, EventArgs e)
        {
            
            selectedButton = 3;

            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox4.Visible = true;

            button6.Visible = true;
            button7.Visible = true;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;

            ShowControls();
        }

       

        private void BackButton_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;



            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;

            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;

            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            
        }

       

        private void PicturesForPlants(object sender, EventArgs e)
        {
            int indexOfOrganism = comboBox1.SelectedIndex;

            LoadForPlants.LoadPictureForPlants(indexOfOrganism, pictureBox1);


        }

        private void PicturesForFirstAnimals(object sender, EventArgs e)
        {
            int indexOfOrganism = comboBox2.SelectedIndex;

            LoadForAnimals1.LoadPictureForFirstAnimals(indexOfOrganism, pictureBox2);

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexOfOrganism = comboBox3.SelectedIndex;

            LoadForAnimals2.LoadPictureForAnimals2(indexOfOrganism, pictureBox3);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexOfOrganism = comboBox4.SelectedIndex;

            LoadForAnimals3.LoadPictureForAnimals3(indexOfOrganism, pictureBox4);
        }

        
        
        private void Calculate_Click(object sender, EventArgs e)
        {
            button8.Visible = true;

            dataGridView1.ColumnCount = 5;
            dataGridView1.RowCount = 2;

            dataGridView1[0, 0].Value = "Можна отримати";
            dataGridView1[0, 1].Value = "Потрібно";

            double square;
            double productively;
            
            double drymass = 0;
            double lank2CanTake = 0;
            double lank3CanTake = 0;
            double lank4CanTake = 0;

            double needForLast;
            double penultimate = 0;
            double forOne = 0;
            double forTwo = 0;


            try
            {
                switch (selectedButton)
                {

                    case 1:
                        needForLast = double.Parse(textBox3.Text);
                        square = double.Parse(textBox1.Text);
                        productively = double.Parse(textBox2.Text);

                        if (needForLast <= 0 || square <= 0 || productively <= 0)
                        {
                            throw new ArgumentException("Введені значення повинні бути додатніми.");
                        }

                        drymass = square * productively;
                        lank2CanTake = drymass * 0.1;
                        penultimate = needForLast * 10;


                        dataGridView1[1, 1].Value = penultimate.ToString();
                        dataGridView1[2, 1].Value = needForLast.ToString();
                        break;

                    case 2:
                        needForLast = double.Parse(textBox3.Text);
                        square = double.Parse(textBox1.Text);
                        productively = double.Parse(textBox2.Text);

                        if (needForLast <= 0 || square <= 0 || productively <= 0)
                        {
                            throw new ArgumentException("Введені значення повинні бути додатніми.");
                        }


                        drymass = square * productively;
                        lank2CanTake = drymass * 0.1;
                        lank3CanTake = lank2CanTake * 0.1;

                        penultimate = needForLast * 10;
                        forOne = penultimate * 10;

                        dataGridView1[1, 1].Value = forOne.ToString();
                        dataGridView1[2, 1].Value = penultimate.ToString();
                        dataGridView1[3, 1].Value = needForLast.ToString();
                        break;

                    case 3:
                        needForLast = double.Parse(textBox3.Text);
                        square = double.Parse(textBox1.Text);
                        productively = double.Parse(textBox2.Text);

                        if (needForLast <= 0 || square <= 0 || productively <= 0)
                        {
                            throw new ArgumentException("Введені значення повинні бути додатніми.");
                        }


                        drymass = square * productively;
                        lank2CanTake = drymass * 0.1;
                        lank3CanTake = lank2CanTake * 0.1;
                        lank4CanTake = lank3CanTake * 0.1;

                        penultimate = needForLast * 10;
                        forOne = penultimate * 10;
                        forTwo = forOne * 10;

                        dataGridView1[1, 1].Value = forTwo.ToString();
                        dataGridView1[2, 1].Value = forOne.ToString();
                        dataGridView1[3, 1].Value = penultimate.ToString();
                        dataGridView1[4, 1].Value = needForLast.ToString();
                        break;
                }
            }
            catch(Exception ex) {
                MessageBox.Show("Дані введено некоректно" + ex);
                    }

            if (dataGridView1.Rows.Count >= 1 && dataGridView1.Columns.Count >= 1)
            {
                dataGridView1[1, 0].Value = drymass.ToString();
                dataGridView1[2, 0].Value = lank2CanTake.ToString();
                dataGridView1[3, 0].Value = lank3CanTake.ToString();
                dataGridView1[4, 0].Value = lank4CanTake.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool isMessageBoxShown = false;

            for (int col = 1; col <= 4; col++)
            {
                
                object upperValueObj = dataGridView1[col, 0].Value;
                object lowerValueObj = dataGridView1[col, 1].Value;

                
                if (upperValueObj != null && lowerValueObj != null &&
                    double.TryParse(upperValueObj.ToString(), out double upperValue) &&
                    double.TryParse(lowerValueObj.ToString(), out double lowerValue))
                {
                    
                    if (lowerValue > upperValue && !isMessageBoxShown)
                    {
                        isMessageBoxShown = true;
                        
                        MessageBox.Show("Екосистема не стійка, бо організму не вистачає біомаси для нормального життя, і" +
                            " популяція вимирає", "Екосистема не стійка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if(!isMessageBoxShown)
                    {
                        isMessageBoxShown = true;
                        MessageBox.Show("Екосистема стійка, популяція в нормальному стані",
                            "Екосистема стійка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("У таблиці неправильний тип даних або значення не можуть бути конвертовані");
                }
            }

            }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
