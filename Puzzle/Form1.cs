using Puzzle.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Puzzle
{

    /*
     * ROPECABEZAS
     ANTONIO TORRES ITI 707 
     UNIVERSIDAD TECNOLÓGICA DE LEÓN
    */
    public partial class Form1 : Form
    {

        // private bool isDragging = false;
        private int counter = 0;
        // private int clickOffsetX, clickOffsetY;
        private int l1Countdown, l2Countdown, l3Countdown;

        List<Image> imagenes = new List<Image>();

        static Random random = new Random();

        private List<Image> imagenesOrd = new List<Image>();

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (l1Countdown > 0 && l1Countdown <= 100)
            {
                label3.ForeColor = Color.Black;
                l1Countdown--;
                label3.Text = "Segundos restantes: " + l1Countdown.ToString();

                if (l1Countdown < 11)
                {
                    label3.ForeColor = Color.Red;
                }
            }
            else
            {
                reset();
                MessageBox.Show("SE TE ACABÓ EL TIEMPO");

            }
        }

        private void reset()
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();

            l1Countdown = 100;
            l2Countdown = 60;
            l3Countdown = 45;

            imagenes.Clear();
            imagenesOrd.Clear();
            limpiarImagenes();
            counter = 0;
            label4.Text = "";
            pictureBox33.Image = null;

        }

        private void limpiarImagenes()
        {
            pictureBox17.Image = null;
            pictureBox18.Image = null;
            pictureBox19.Image = null;
            pictureBox20.Image = null;
            pictureBox21.Image = null;
            pictureBox22.Image = null;
            pictureBox23.Image = null;
            pictureBox24.Image = null;
            pictureBox25.Image = null;
            pictureBox26.Image = null;
            pictureBox27.Image = null;
            pictureBox28.Image = null;
            pictureBox29.Image = null;
            pictureBox30.Image = null;
            pictureBox31.Image = null;
            pictureBox32.Image = null;

        }


        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (l2Countdown > 0 && l2Countdown <= 60)
            {
                label3.ForeColor = Color.Black;
                l2Countdown--;
                label3.Text = "Segundos restantes: " + l2Countdown.ToString();

                if (l2Countdown < 11)
                {
                    label3.ForeColor = Color.Red;
                }
            }
            else
            {
                reset();
                MessageBox.Show("SE TE ACABÓ EL TIEMPO");

            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            if (l3Countdown > 0 && l3Countdown <= 45)
            {
                label3.ForeColor = Color.Black;
                l3Countdown--;
                label3.Text = "Segundos restantes: " + l3Countdown.ToString();

                if (l3Countdown < 11)
                {
                    label3.ForeColor = Color.Red;
                }
            }
            else
            {
                reset();
                MessageBox.Show("SE TE ACABÓ EL TIEMPO");

            }
        }

        public Form1()
        {
            InitializeComponent();
            reset();
            AllowDrops();
        }

        private void AllowDrops()
        {
            pictureBox17.AllowDrop = true;
            pictureBox18.AllowDrop = true;
            pictureBox19.AllowDrop = true;
            pictureBox20.AllowDrop = true;
            pictureBox21.AllowDrop = true;
            pictureBox22.AllowDrop = true;
            pictureBox23.AllowDrop = true;
            pictureBox24.AllowDrop = true;
            pictureBox25.AllowDrop = true;
            pictureBox26.AllowDrop = true;
            pictureBox27.AllowDrop = true;
            pictureBox28.AllowDrop = true;
            pictureBox29.AllowDrop = true;
            pictureBox30.AllowDrop = true;
            pictureBox31.AllowDrop = true;
            pictureBox32.AllowDrop = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            reset();

            if (comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1)
            {

                if (comboBox2.SelectedIndex == 0)
                {
                    timer1.Start();
                }

                if (comboBox2.SelectedIndex == 1)
                {
                    timer2.Start();
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    timer3.Start();
                }

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        loadImages();
                        pictureBox33.Image = Resources.giphy;
                        break;
                    case 1:
                        loadImages();
                        pictureBox33.Image = Resources.Ballon;
                        break;

                }
            }
            else if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("SELECCIONE IMAGEN Y DIFICULTAD");
            }


        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox1.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                pictureBox1.Image = null;
            }
        }

        private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox2.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                pictureBox2.Image = null;
            }
        }

        private void PictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox3.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                pictureBox3.Image = null;
            }
        }

        private void PictureBox17_DragEnter(object sender, DragEventArgs e)
        {
            if (pictureBox17.Image == null) {
                if (e.Data.GetDataPresent(DataFormats.Bitmap))
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void PictureBox17_DragDrop(object sender, DragEventArgs e)
        {
                var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                pictureBox17.Image = bmp;
        }

        private void PictureBox18_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox18.Image = bmp;
        }

        private void PictureBox18_DragEnter(object sender, DragEventArgs e)
        {
            if (pictureBox18.Image == null)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap))
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //var imgpb17 = pictureBox17.Image;

            try
            {
                if (pictureBox17.Image == imagenesOrd[0])
                {
                    counter++;
                }
                if (pictureBox18.Image == imagenesOrd[1])
                {
                    counter++;
                }
                if (pictureBox19.Image == imagenesOrd[2])
                {
                    counter++;
                }
                if (pictureBox20.Image == imagenesOrd[3])
                {
                    counter++;
                }
                if (pictureBox21.Image == imagenesOrd[4])
                {
                    counter++;
                }
                if (pictureBox22.Image == imagenesOrd[5])
                {
                    counter++;
                }
                if (pictureBox23.Image == imagenesOrd[6])
                {
                    counter++;
                }
                if (pictureBox24.Image == imagenesOrd[7])
                {
                    counter++;
                }
                if (pictureBox25.Image == imagenesOrd[8])
                {
                    counter++;
                }
                if (pictureBox26.Image == imagenesOrd[9])
                {
                    counter++;
                }
                if (pictureBox27.Image == imagenesOrd[10])
                {
                    counter++;
                }
                if (pictureBox28.Image == imagenesOrd[11])
                {
                    counter++;
                }
                if (pictureBox29.Image == imagenesOrd[12])
                {
                    counter++;
                }
                if (pictureBox30.Image == imagenesOrd[13])
                {
                    counter++;
                }
                if (pictureBox31.Image == imagenesOrd[14])
                {
                    counter++;
                }
                if (pictureBox32.Image == imagenesOrd[15])
                {
                    counter++;
                }


                if (counter == 16)
                {
                    MessageBox.Show("¡Completaste el rompecabezas!");
                }

                label4.Text = "Imagenes correctas: " + Convert.ToString(counter);
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();


            }
            catch (Exception) {
                MessageBox.Show("Hubo un error, reinicie el puzzle");
            }
        }

        private void PictureBox19_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox19.Image = bmp;
        }

        private void PictureBox19_DragEnter(object sender, DragEventArgs e)
        {
            if (pictureBox19.Image == null)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap))
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void PictureBox20_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox20.Image = bmp;
        }

        private void PictureBox20_DragEnter(object sender, DragEventArgs e)
        {
            if (pictureBox20.Image == null)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap))
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void PictureBox21_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox21.Image = bmp;
        }

        private void PictureBox21_DragEnter(object sender, DragEventArgs e)
        {
            if (pictureBox21.Image == null)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap))
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void PictureBox22_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox22.Image = bmp;
        }

        private void PictureBox22_DragEnter(object sender, DragEventArgs e)
        {
            if (pictureBox22.Image == null)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap))
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void PictureBox23_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox23.Image = bmp;
        }

        private void PictureBox23_DragEnter(object sender, DragEventArgs e)
        {
            if (pictureBox23.Image == null)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap))
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void PictureBox24_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox24.Image = bmp;
        }

        private void PictureBox24_DragEnter(object sender, DragEventArgs e)
        {
            if (pictureBox24.Image == null)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap))
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void PictureBox25_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox25.Image = bmp;
        }

        private void PictureBox25_DragEnter(object sender, DragEventArgs e)
        {
            if (pictureBox25.Image == null)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap))
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void PictureBox26_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox26.Image = bmp;
        }

        private void PictureBox26_DragEnter(object sender, DragEventArgs e)
        {
            if (pictureBox26.Image == null)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap))
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void PictureBox27_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox27.Image = bmp;
        }

        private void PictureBox27_DragEnter(object sender, DragEventArgs e)
        {
            if (pictureBox27.Image == null)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap))
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void PictureBox28_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox28.Image = bmp;
        }

        private void PictureBox28_DragEnter(object sender, DragEventArgs e)
        {
            if (pictureBox28.Image == null)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap))
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void PictureBox29_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox29.Image = bmp;
        }

        private void PictureBox29_DragEnter(object sender, DragEventArgs e)
        {
            if (pictureBox29.Image == null)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap))
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void PictureBox30_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox30.Image = bmp;
        }

        private void PictureBox30_DragEnter(object sender, DragEventArgs e)
        {
            if (pictureBox30.Image == null)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap))
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void PictureBox31_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox31.Image = bmp;
        }

        private void PictureBox31_DragEnter(object sender, DragEventArgs e)
        {
            if (pictureBox31.Image == null)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap))
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void PictureBox32_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pictureBox32.Image = bmp;
        }

        private void PictureBox32_DragEnter(object sender, DragEventArgs e)
        {
            if (pictureBox32.Image == null)
            {
                if (e.Data.GetDataPresent(DataFormats.Bitmap))
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void PictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox4.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                pictureBox4.Image = null;
            }
        }

        private void PictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox5.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                pictureBox5.Image = null;
            }
        }

        private void PictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox6.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                pictureBox6.Image = null;
            }
        }

        private void PictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox7.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                pictureBox7.Image = null;
            }
        }

        private void PictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox8.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                pictureBox8.Image = null;
            }
        }

        private void PictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox9.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                pictureBox9.Image = null;
            }
        }

        private void PictureBox10_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox10.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                pictureBox10.Image = null;
            }
        }

        private void PictureBox11_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox11.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                pictureBox11.Image = null;
            }
        }

        private void PictureBox12_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox12.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                pictureBox12.Image = null;
            }
        }

        private void PictureBox13_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox13.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                pictureBox13.Image = null;
            }
        }

        private void PictureBox14_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox14.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                pictureBox14.Image = null;
            }
        }

        private void PictureBox15_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox15.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                pictureBox15.Image = null;
            }
        }

        private void PictureBox16_MouseDown(object sender, MouseEventArgs e)
        {
            var img = pictureBox16.Image;
            if (img == null) return;
            if (DoDragDrop(img, DragDropEffects.Move) == DragDropEffects.Move)
            {
                pictureBox16.Image = null;
            }
        }

        private void loadImages()
        {
            createList();
            List<Image> shuffledImages = combinarItems(imagenes);
            if (imagenes.Count > 0)
            {
                pictureBox1.Image = shuffledImages[0];
                pictureBox2.Image = shuffledImages[1];
                pictureBox3.Image = shuffledImages[2];
                pictureBox4.Image = shuffledImages[3];
                pictureBox5.Image = shuffledImages[4];
                pictureBox6.Image = shuffledImages[5];
                pictureBox7.Image = shuffledImages[6];
                pictureBox8.Image = shuffledImages[7];
                pictureBox9.Image = shuffledImages[8];
                pictureBox10.Image = shuffledImages[9];
                pictureBox11.Image = shuffledImages[10];
                pictureBox12.Image = shuffledImages[11];
                pictureBox13.Image = shuffledImages[12];
                pictureBox14.Image = shuffledImages[13];
                pictureBox15.Image = shuffledImages[14];
                pictureBox16.Image = shuffledImages[15];

                shuffledImages.Clear();
            }
            else
            {
                MessageBox.Show("NO HAY RUTAS ESPECIFICADAS PARA LAS IMAGENES");
            }
        }

        private List<Image> combinarItems(List<Image> imagenes)
        {
            int n = imagenes.Count;

            while (n > 1)
            {
                n--;
                int index = random.Next(n + 1);
                Image value = imagenes[index];
                imagenes[index] = imagenes[n];
                imagenes[n] = value;
            }

            return imagenes;
        }

        private void createList()
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    imagenes.Add(Resources.w1_1);
                    imagenes.Add(Resources.w1_2);
                    imagenes.Add(Resources.w1_3);
                    imagenes.Add(Resources.w1_4);

                    imagenes.Add(Resources.w2_1);
                    imagenes.Add(Resources.w2_2);
                    imagenes.Add(Resources.w2_3);
                    imagenes.Add(Resources.w2_4);

                    imagenes.Add(Resources.w3_1);
                    imagenes.Add(Resources.w3_2);
                    imagenes.Add(Resources.w3_3);
                    imagenes.Add(Resources.w3_4);

                    imagenes.Add(Resources.w4_1);
                    imagenes.Add(Resources.w4_2);
                    imagenes.Add(Resources.w4_3);
                    imagenes.Add(Resources.w4_4);

                }

                if (comboBox1.SelectedIndex == 1)
                {

                    imagenes.Add(Resources.g1_1);
                    imagenes.Add(Resources.g1_2);
                    imagenes.Add(Resources.g1_3);
                    imagenes.Add(Resources.g1_4);

                    imagenes.Add(Resources.g2_1);
                    imagenes.Add(Resources.g2_2);
                    imagenes.Add(Resources.g2_3);
                    imagenes.Add(Resources.g2_4);

                    imagenes.Add(Resources.g3_1);
                    imagenes.Add(Resources.g3_2);
                    imagenes.Add(Resources.g3_3);
                    imagenes.Add(Resources.g3_4);

                    imagenes.Add(Resources.g4_1);
                    imagenes.Add(Resources.g4_2);
                    imagenes.Add(Resources.g4_3);
                    imagenes.Add(Resources.g4_4);
                }


                for (int i = 0; i < imagenes.Count; i++)
                {
                    imagenesOrd.Add(imagenes[i]);
                }
                //MessageBox.Show(imagenes.Count.ToString());

        }
    }
}
