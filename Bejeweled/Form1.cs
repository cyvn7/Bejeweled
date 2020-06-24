using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Bejeweled
{
    public partial class Bejeweled : Form
    {
        //int[] x;
        //int[] y;
        ArrayList x = new ArrayList();
        ArrayList y = new ArrayList();
        ArrayList globalXs = new ArrayList();
        ArrayList globalYs = new ArrayList();
        public int posMax = 2;
        //List<int> x = new List<int>();
        int count = -1;
        int[,] jewels_img = new int[8, 8];
        bool firstClick = false; //mówi czy kliknięto kryształ po raz pierwszy czy drugi
        bool lineCrash = false;
        bool beforePlay = true;
        public int globalX = 0;
        int globalY = 0;
        string direction;
        int punktyInt = 0;
        int tempMax = 2;
        int i = 0;
        int ifFound = 0;
        int givePoints = 0;
        public Bejeweled()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.Write("coś");
            Console.Write("coś3");
            GPictureBox();
            Random rnd = new Random();
            punkty.Text = punktyInt.ToString();
        }

        public void GPictureBox()
        {
            Random rnd = new Random();

            for (int tmp_a = 0; tmp_a <= 7; tmp_a++)
            {
                for (int tmp_b = 0; tmp_b <= 7; tmp_b++)
                {
                    jewels_img[tmp_a, tmp_b] = 5;
                }
            }

            //Losowanie cyfr do grafik
            for (int tmp_img = 0; tmp_img <= 7; tmp_img++)
            {
                for (int tmp_img2 = 0; tmp_img2 <= 7; tmp_img2++)
                {
                    int los = rnd.Next(0, 4);
                    jewels_img[tmp_img, tmp_img2] = los;
                }
            }
            CheckRepeats();

        }

        public void CheckRepeats()
        {
            Bitmap[] jewels = new Bitmap[5];
            jewels[0] = global::Bejeweled.Properties.Resources.red;
            jewels[1] = global::Bejeweled.Properties.Resources.blue;
            jewels[2] = global::Bejeweled.Properties.Resources.purple;
            jewels[3] = global::Bejeweled.Properties.Resources.cherry;
            jewels[4] = global::Bejeweled.Properties.Resources.yellow;

            Color[] colors = new Color[5];
            colors[0] = System.Drawing.Color.Red;
            colors[1] = System.Drawing.Color.Blue;
            colors[2] = System.Drawing.Color.Purple;
            colors[3] = System.Drawing.Color.Chartreuse;
            colors[4] = System.Drawing.Color.Yellow;
            int repeat3 = 0;
            int repeat4 = 0;
            ifFound = 0;
            tempMax = 2;
            Random rnd = new Random();
            bool stop = false;
            for (int tmp_che = 0; tmp_che <= 7; tmp_che++)
            {
                
                for (int tmp_che2 = 0; tmp_che2 <= 7; tmp_che2++)
                {
                    int repeat1 = 0;
                    int repeat2 = 0;

                    if (beforePlay == false)
                    {
                        posMax = 4;
                    }

                    #region
                    //do
                    //{
                    //    pos++;

                    //    if (0 <= tmp_che - pos && jewels_img[tmp_che, tmp_che2] == jewels_img[tmp_che - pos, tmp_che2])
                    //    {
                    //            repeat1++;
                    //            if(repeat1 > 1)
                    //            {
                    //                direction = "up";
                    //            }
                    //            if(pos == 1)
                    //            {
                    //                repeat3++;
                    //            }
                    //            repeatC++;

                    //    }
                    //    if (0 <= tmp_che2 - pos && jewels_img[tmp_che, tmp_che2] == jewels_img[tmp_che, tmp_che2 - pos])
                    //    {
                    //            repeat2++;
                    //            if(repeat2 > 1)
                    //            {
                    //                direction = "left";
                    //            }
                    //            if (pos == 1)
                    //            {
                    //                repeat4++;
                    //            }
                    //            repeatC++;

                    //    }

                    //    if((repeat3 > 2|| repeat4 > 2) && beforePlay == true)
                    //    {
                    //            if(repeat3 > 2)
                    //            {
                    //                repeat3--;
                    //            }
                    //            else
                    //            {
                    //                repeat4--;
                    //            }
                    //            //Console.WriteLine("przed: " + jewels_img[tmp_che, tmp_che2]);
                    //            int old = jewels_img[tmp_che, tmp_che2];
                    //            while (jewels_img[tmp_che, tmp_che2] == old)
                    //            {
                    //                jewels_img[tmp_che, tmp_che2] = rnd.Next(0, 4);
                    //            }

                    //            // jewels_img[tmp_che, tmp_che2] = rnd.Next(0, 4);
                    //            //Console.WriteLine("po: " + jewels_img[tmp_che, tmp_che2]);
                    //            tmp_che2--;
                    //            break;
                    //    }
                    //    if (repeat1 > 1 || repeat2 > 1)
                    //    {
                    //        if (beforePlay == true)
                    //        {
                    //            //Console.WriteLine("przed: " + jewels_img[tmp_che, tmp_che2]);
                    //            int old = jewels_img[tmp_che, tmp_che2];
                    //            while (jewels_img[tmp_che, tmp_che2] == old)
                    //            {
                    //                jewels_img[tmp_che, tmp_che2] = rnd.Next(0, 4);
                    //            }

                    //            // jewels_img[tmp_che, tmp_che2] = rnd.Next(0, 4);
                    //            //Console.WriteLine("po: " + jewels_img[tmp_che, tmp_che2]);
                    //            tmp_che2--;
                    //            break;
                    //        }
                    //        else
                    //        {
                    //            if(repeatC == 4)
                    //            {
                    //                direction = "Cross";
                    //            }
                    //            globalX = tmp_che;
                    //            globalY = tmp_che2;
                    //            for(int pos2 = 3; pos2 <= 4; pos2++)
                    //            {

                    //                if (direction.Equals("up"))
                    //                {
                    //                    if ((0 <= tmp_che - pos2) && (jewels_img[tmp_che, tmp_che2] == jewels_img[tmp_che  - pos2, tmp_che2]))
                    //                    {
                    //                        repeat1++;
                    //                    }
                    //                }
                    //                else
                    //                {
                    //                    if ((0 <= tmp_che2  - pos2) && (jewels_img[tmp_che, tmp_che2] == jewels_img[tmp_che, tmp_che2 - pos2]))
                    //                    {
                    //                        repeat2++;
                    //                    }
                    //                }
                    //                if (direction.Equals("up"))
                    //                {
                    //                    if ((((tmp_che - 2) + pos2) <= 7) && (jewels_img[tmp_che, tmp_che2] == jewels_img[((tmp_che - 2) + pos2), tmp_che2]))
                    //                    {
                    //                        repeat1++;
                    //                    }
                    //                }
                    //                else
                    //                {
                    //                    if ((((tmp_che2 - 2) + pos2) <= 7) && (jewels_img[tmp_che, tmp_che2] == jewels_img[tmp_che, ((tmp_che2 - 2) + pos2)]))
                    //                    {
                    //                        repeat2++;
                    //                    }
                    //                }
                    //            }
                    //            if(repeat1 == 3 || repeat2 == 3)
                    //            {
                    //                tempMax = 3;
                    //            }
                    //            else if(repeat1 == 4 || repeat2 == 4)
                    //            {
                    //                tempMax = 4;
                    //            }
                    //            lineCrash = true;
                    //            stop = true;
                    //            break;

                    //        }
                    //    }
                    //    else
                    //    {
                    //            lineCrash = false;

                    //    }

                    //}
                    //while (pos < 2);
                    #endregion
                    for (int pos = 1; pos <= posMax; pos++)
                    {
                        if (stop == true)
                        {
                            break;
                        }

                        if (0 <= tmp_che - pos && jewels_img[tmp_che, tmp_che2] == jewels_img[tmp_che - pos, tmp_che2])
                        {
                            repeat1++;
                            if (repeat1 == 2 && pos == 2)
                            {
                                direction = "up";
                            }
                            if (pos == 1)
                            {
                                repeat3++;
                            }

                        }
                        if (0 <= tmp_che2 - pos && jewels_img[tmp_che, tmp_che2] == jewels_img[tmp_che, tmp_che2 - pos])
                        {
                            repeat2++;
                            if (repeat2 == 2 && pos == 2)
                            {
                                direction = "left";
                            }
                            if (pos == 1)
                            {
                                repeat4++;
                            }

                        }

                        if ((repeat3 > 2 || repeat4 > 2) && beforePlay == true)
                        {
                            if (repeat3 > 2)
                            {
                                repeat3--;
                            }
                            else
                            {
                                repeat4--;
                            }
                            int old = jewels_img[tmp_che, tmp_che2];
                            while (jewels_img[tmp_che, tmp_che2] == old)
                            {
                                jewels_img[tmp_che, tmp_che2] = rnd.Next(0, 4);
                            }
                            tmp_che2--;
                            break;
                        }
                        if (repeat1 > 1 || repeat2 > 1)
                        {
                            if (beforePlay == true)
                            {
                                int old = jewels_img[tmp_che, tmp_che2];
                                while (jewels_img[tmp_che, tmp_che2] == old)
                                {
                                    jewels_img[tmp_che, tmp_che2] = rnd.Next(0, 4);
                                }
                                tmp_che2--;
                                break;
                            }
                            else
                            {
                                if (pos == 2 && (repeat1 == 2 || repeat2 == 2))
                                {
                                    globalX = tmp_che;
                                    globalY = tmp_che2;
                                    lineCrash = true;
                                    ifFound++;
                                }

                                if ((repeat1 == 3 || repeat2 == 3) && pos == 3 && ifFound == 0)
                                {
                                    tempMax = 3;
                                }
                                else if (pos == 4 && (repeat1 == 4 || repeat2 == 4) && ifFound == 0)
                                {
                                    tempMax = 4;
                                }

                                //if(pos == 4 && lineCrash == true && (repeat1 == 4 || repeat2 == 4))
                                //{
                                //    stop = true;
                                //    break;
                                //}
                                //tmp_che2--;
                                //break;
                            }
                        }
                        if(ifFound == 0)
                        {
                                lineCrash = false;
                        }

                    }
                }
            }
            if(stop == false)
            {
                MakeMap();
            }
            for (int tempor = 0; tempor <= 7; tempor++)
            {
                for (int tempor2 = 0; tempor2 <= 7; tempor2++)
                {
                    Button bxB = this.Controls.Find("box_" + tempor + "_" + tempor2, true).FirstOrDefault() as Button;
                    bxB.BackgroundImage = jewels[jewels_img[tempor, tempor2]];
                    bxB.BackColor = colors[jewels_img[tempor, tempor2]];
                }
            }
        }

        public void Check()
        {
            bool option = false;
            for (int tmp_1 = 0; tmp_1 <= 7; tmp_1++)
            {
                for (int tmp_2 = 0; tmp_2 <= 7; tmp_2++)
                {
                    if (0 <= tmp_1 - 2)
                    {
                        if (jewels_img[tmp_1, tmp_2] == jewels_img[tmp_1 - 1, tmp_2])
                        {
                                if (jewels_img[tmp_1, tmp_2] == jewels_img[tmp_1 - 2, tmp_2])
                                {
                                    option = true;
                                }
                        }
                        if (jewels_img[tmp_1, tmp_2] == jewels_img[tmp_1 - 2, tmp_2])
                        {
                            if (0 <= tmp_2 - 1)
                            {
                                if (jewels_img[tmp_1, tmp_2] == jewels_img[tmp_1 - 1, tmp_2 - 1])
                                {
                                    option = true;
                                }
                            }
                        }
                    }
                    if (0 <= tmp_2 - 2)
                    {
                        if (jewels_img[tmp_1, tmp_2] == jewels_img[tmp_1, tmp_2 - 1])
                        {
                            
                            
                                if (jewels_img[tmp_1, tmp_2] == jewels_img[tmp_1, tmp_2 - 2])
                                {
                                    option = true;
                                }
                            
                        }
                        
                        
                            if (jewels_img[tmp_1, tmp_2] == jewels_img[tmp_1, tmp_2 - 2])
                            {
                                if (0 <= tmp_1 - 1 && 0 <= tmp_2 - 1)
                                {
                                    if (jewels_img[tmp_1, tmp_2] == jewels_img[tmp_1 - 1, tmp_2 - 1])
                                    {
                                        option = true;
                                    }
                                }
                            }
                        
                    }
                    if (7 >= tmp_1 + 2)
                    {
                        if (jewels_img[tmp_1, tmp_2] == jewels_img[tmp_1 + 1, tmp_2] 
                         && jewels_img[tmp_1, tmp_2] == jewels_img[tmp_1 + 2, tmp_2])
                        {
                            option = true;
                            
                        }
                        
                            if (jewels_img[tmp_1, tmp_2] == jewels_img[tmp_1 + 2, tmp_2])
                            {
                                if ( 7 >= tmp_2 + 1)
                                {
                                    if (jewels_img[tmp_1, tmp_2] == jewels_img[tmp_1 + 1, tmp_2 + 1])
                                    {
                                        option = true;
                                    }
                                }
                            }
                        

                    }
                    if (7 >= tmp_2 + 2)
                    {
                        if (jewels_img[tmp_1, tmp_2] == jewels_img[tmp_1, tmp_2 + 1] && jewels_img[tmp_1, tmp_2] == jewels_img[tmp_1, tmp_2 + 2])
                            option = true;
                        
                        
                        
                            if (jewels_img[tmp_1, tmp_2] == jewels_img[tmp_1, tmp_2 + 2])
                            {
                                if (7 >= tmp_1 + 1 )
                                {
                                    if (jewels_img[tmp_1, tmp_2] == jewels_img[tmp_1 + 1, tmp_2 + 1])
                                    {
                                        option = true;
                                    }
                                }
                            }
                        
                    }
                }
            }
            if (option == false)
            {
                if (beforePlay == false)
                {
                    MessageBox.Show("Skończyły się możliwości ruchów. Nastąpi ponowne losowanie", "", MessageBoxButtons.OK);
                    beforePlay = true;
                }
                GPictureBox();
            }
        }

        private void p_glowny_Paint(object sender, PaintEventArgs e)
        {

        }
        private void start_Click(object sender, EventArgs e)
        {
            Bitmap[] jewels = new Bitmap[5];
            jewels[0] = global::Bejeweled.Properties.Resources.red;
            jewels[1] = global::Bejeweled.Properties.Resources.blue;
            jewels[2] = global::Bejeweled.Properties.Resources.purple;
            jewels[3] = global::Bejeweled.Properties.Resources.cherry;
            jewels[4] = global::Bejeweled.Properties.Resources.yellow;

            Color[] colors = new Color[5];
            colors[0] = System.Drawing.Color.Red;
            colors[1] = System.Drawing.Color.Blue;
            colors[2] = System.Drawing.Color.Purple;
            colors[3] = System.Drawing.Color.Chartreuse;
            colors[4] = System.Drawing.Color.Yellow;
            for (int tempor = 0; tempor <= 7; tempor++)
            {
                for (int tempor2 = 0; tempor2 <= 7; tempor2++)
                {
                    Button bxB = this.Controls.Find("box_" + tempor + "_" + tempor2, true).FirstOrDefault() as Button;
                    bxB.BackgroundImage = jewels[jewels_img[tempor, tempor2]];
                    bxB.BackColor = colors[jewels_img[tempor, tempor2]];
                    bxB.Refresh();
                }
            }
        }

        protected void box_Click(object sender, EventArgs e)
        {
            Bitmap[] jewels = new Bitmap[5];
            jewels[0] = global::Bejeweled.Properties.Resources.red;
            jewels[1] = global::Bejeweled.Properties.Resources.blue;
            jewels[2] = global::Bejeweled.Properties.Resources.purple;
            jewels[3] = global::Bejeweled.Properties.Resources.cherry;
            jewels[4] = global::Bejeweled.Properties.Resources.yellow;

            Color[] colors = new Color[5];
            colors[0] = System.Drawing.Color.Red;
            colors[1] = System.Drawing.Color.Blue;
            colors[2] = System.Drawing.Color.Purple;
            colors[3] = System.Drawing.Color.Chartreuse;
            colors[4] = System.Drawing.Color.Yellow;

            Random rnd = new Random();

            Button bt = sender as Button;

           // Console.WriteLine(bt.Name);
            count++;
            string name = bt.Name;
            string line;

            line = name.Substring(name.Length - 3, 1);
            x.Add(line);

            line = name.Substring(name.Length - 1, 1);
            y.Add(line);
            
            bool go = true;
            if (firstClick == false)
            {
                firstClick = true;
            }
            else
            {
                int tempx1 = Convert.ToInt32(x[count - 1]);
                int tempx2 = Convert.ToInt32(x[count]);
                int tempy1 = Convert.ToInt32(y[count - 1]);
                int tempy2 = Convert.ToInt32(y[count]);

                Console.WriteLine("Krzyształek numer "+jewels_img[tempx2, tempy2]);
                Console.WriteLine(x[count]+ "_" + y[count]);
                if (((tempx1 - tempx2) == 0 && (((tempy1 - tempy2) == 1 || (tempy1 - tempy2) == -1))) || ((tempy1 - tempy2) == 0 && (((tempx1 - tempx2) == 1 || (tempx1 - tempx2) == -1))))
                {
                    int temp = jewels_img[tempx2, tempy2];
                    jewels_img[tempx2, tempy2] = jewels_img[tempx1, tempy1];
                    jewels_img[tempx1, tempy1] = temp;
                    
                    Button bx1 = this.Controls.Find("box_" + tempx1 + "_" + tempy1, true).FirstOrDefault() as Button;
                    bx1.BackgroundImage = jewels[jewels_img[tempx1, tempy1]];
                    bx1.BackColor = colors[jewels_img[tempx1, tempy1]];

                    Button bx2 = this.Controls.Find("box_" + tempx2 + "_" + tempy2, true).FirstOrDefault() as Button;
                    bx2.BackgroundImage = jewels[jewels_img[tempx2, tempy2]];
                    bx2.BackColor = colors[jewels_img[tempx2, tempy2]];
                    
                    while (go == true)
                    {
                        //p_glowny.Refresh();
                        //System.Threading.Thread.Sleep(1000);

                        firstClick = false;

                        CheckRepeats();

                        if (lineCrash == true)
                        {

                            if (direction.Equals("up"))
                            {
                               for (int intig = 0; intig <= tempMax; intig++)
                               {
                                   Button bx = this.Controls.Find("box_" + (globalX - intig) + "_" + globalY, true).FirstOrDefault() as Button;
                                   bx.BackColor = Color.Black;
                               }

                                p_glowny.Refresh();
                                System.Threading.Thread.Sleep(750);
                                for (int trzy = 0; trzy <= tempMax; trzy++)
                                {

                                    int toBreak = globalX;
                                    while (toBreak > 0)
                                    {
                                        jewels_img[toBreak, globalY] = jewels_img[toBreak - 1, globalY];
                                        Button bx = this.Controls.Find("box_" + toBreak + "_" + globalY, true).FirstOrDefault() as Button;
                                        bx.BackgroundImage = jewels[jewels_img[toBreak, globalY]];
                                        bx.BackColor = colors[jewels_img[toBreak, globalY]];
                                        toBreak--;
                                    }
                                    if (toBreak == 0)
                                    {
                                        jewels_img[0, globalY] = rnd.Next(0, 4);
                                        Button bx = this.Controls.Find("box_" + 0 + "_" + globalY, true).FirstOrDefault() as Button;
                                        bx.BackgroundImage = jewels[jewels_img[globalX, globalY]];
                                        bx.BackColor = colors[jewels_img[globalX, globalY]];
                                    }
                                }
                            }
                            else if(direction.Equals("Cross"))
                            {
                                Console.WriteLine("działa kris");
                            }
                            else
                            {
                                for (int intig = 0; intig <= tempMax; intig++)
                                {
                                    Button bx = this.Controls.Find("box_" + globalX + "_" + (globalY - intig), true).FirstOrDefault() as Button;
                                    bx.BackColor = Color.Black;
                                }

                                p_glowny.Refresh();
                                System.Threading.Thread.Sleep(750);

                                for (int trzy = 0; trzy <= tempMax; trzy++)
                                {
                                    for (int toBreak = globalX;  toBreak > 0; toBreak--)
                                    {
                                        jewels_img[toBreak, globalY - trzy] = jewels_img[toBreak - 1, (globalY - trzy)];
                                        Button bx = this.Controls.Find("box_" + toBreak + "_" + (globalY - trzy), true).FirstOrDefault() as Button;
                                        bx.BackgroundImage = jewels[jewels_img[toBreak, (globalY - trzy)]];
                                        bx.BackColor = colors[jewels_img[toBreak, (globalY - trzy)]];
                                    }
                                    jewels_img[0, globalY - trzy] = rnd.Next(0, 4);
                                    Button bx0 = this.Controls.Find("box_" + globalX + "_" + (globalY - trzy), true).FirstOrDefault() as Button;
                                    bx0.BackgroundImage = jewels[jewels_img[globalX, (globalY - trzy)]];
                                    bx0.BackColor = colors[jewels_img[globalX, (globalY - trzy)]];



                                    for (int tempor = 0; tempor <= 7; tempor++)
                                    {
                                        for (int tempor2 = 0; tempor2 <= 7; tempor2++)
                                        {
                                            Button bxB = this.Controls.Find("box_" + tempor + "_" + tempor2, true).FirstOrDefault() as Button;
                                            bxB.BackgroundImage = jewels[jewels_img[tempor, tempor2]];
                                            bxB.BackColor = colors[jewels_img[tempor, tempor2]];
                                        }
                                    }
                                }
                            }
                            // break;
                            Console.WriteLine("tempMax"+tempMax);
                            givePoints += 15;
                            if(givePoints > 15)
                            {
                                givePoints += (givePoints / 15) * 5;
                            }
                            i++;
                        }
                        else
                        {
                            punktyInt += givePoints;
                            punkty.Text = punktyInt.ToString();
                            zd_punkty.Text = "+" + givePoints.ToString();
                            zd_punkty.BackColor = colors[rnd.Next(0, 4)];
                            givePoints = 0;
                            go = false;

                            if (i == 0)
                            {
                                temp = jewels_img[tempx2, tempy2];
                                jewels_img[tempx2, tempy2] = jewels_img[tempx1, tempy1];
                                jewels_img[tempx1, tempy1] = temp;
                                //MakeMap();
                                bx1 = this.Controls.Find("box_" + tempx1 + "_" + tempy1, true).FirstOrDefault() as Button;
                                bx1.BackgroundImage = jewels[jewels_img[tempx1, tempy1]];
                                bx1.BackColor = colors[jewels_img[tempx1, tempy1]];

                                bx2 = this.Controls.Find("box_" + tempx2 + "_" + tempy2, true).FirstOrDefault() as Button;
                                bx2.BackgroundImage = jewels[jewels_img[tempx2, tempy2]];
                                bx2.BackColor = colors[jewels_img[tempx2, tempy2]];

                                for (int tempor = 0; tempor <= 7; tempor++)
                                {
                                    for (int tempor2 = 0; tempor2 <= 7; tempor2++)
                                    {
                                        Button bxB = this.Controls.Find("box_" + tempor + "_" + tempor2, true).FirstOrDefault() as Button;
                                        bxB.BackgroundImage = jewels[jewels_img[tempor, tempor2]];
                                        bxB.BackColor = colors[jewels_img[tempor, tempor2]];
                                    }
                                }
                            }
                            else
                            {
                                i = 0;
                            }
                        }
                    }
                }
                else
                {
                    firstClick = true;
                }
                    #region
                //    if((tempy1 + 1) <= 7 && (tempy1 - 1) >= 0)
                //    {
                //        if(jewels_img[tempx1, tempy1 - 1] == jewels_img[tempx1, tempy1] && jewels_img[tempx1, tempy1 + 1] == jewels_img[tempx1, tempy1])
                //        {
                //            Console.WriteLine("działa ---");
                //            lineCrash = true;
                //        }
                //    }
                //    if ((tempy2 + 1) <= 7 && (tempy2 - 1) >= 0)
                //    {
                //        if (jewels_img[tempx2, tempy2 - 1] == jewels_img[tempx2, tempy2] && jewels_img[tempx2, tempy2 + 1] == jewels_img[tempx2, tempy2])
                //        {
                //            Console.WriteLine("działa2");
                //            lineCrash = true;
                //        }
                //    }


                //    if ((tempx1 + 1) <= 7 && (tempx1 - 1) >= 0)
                //    {
                //        if (jewels_img[tempx1 - 1, tempy1] == jewels_img[tempx1, tempy1] && jewels_img[tempx1 + 1, tempy1] == jewels_img[tempx1, tempy1])
                //        {
                //            Console.WriteLine("działa");
                //            lineCrash = true;
                //        }
                //    }
                //    if ((tempx2 + 1) <= 7 && (tempx2 - 1) >= 0)
                //    {
                //        if (jewels_img[tempx2 - 1, tempy2] == jewels_img[tempx2, tempy2] && jewels_img[tempx2 + 1, tempy2] == jewels_img[tempx2, tempy2])
                //        {
                //            Console.WriteLine("działa");
                //            lineCrash = true;
                //        }
                //    }

                //    //PIERWSZY KLIKNIĘTY
                //    if ((tempy1 + 2) <= 7)
                //    {
                //        if (jewels_img[tempx1, tempy1 + 1] == jewels_img[tempx1, tempy1] && jewels_img[tempx1, tempy1] == jewels_img[tempx1, tempy1 + 2])
                //        {
                //            Console.WriteLine("działa 3");
                //            lineCrash = true;
                //        }
                //    }

                //    if ((tempy1 - 2) >= 0)
                //    {
                //        if (jewels_img[tempx1, tempy1 - 1] == jewels_img[tempx1, tempy1] && jewels_img[tempx1, tempy1] == jewels_img[tempx1, tempy1 - 2])
                //        {
                //            Console.WriteLine("działa 6");
                //            lineCrash = true;
                //        }

                //    }

                //    if ((tempx1 + 2) <= 7)
                //    {
                //        if (jewels_img[tempx1 + 1, tempy1] == jewels_img[tempx1, tempy1] && jewels_img[tempx1, tempy1] == jewels_img[tempx1 + 2, tempy1])
                //        {
                //            Console.WriteLine("działa 4");
                //            lineCrash = true;
                //        }
                //    }

                //    if ((tempx1 - 2) >= 0)
                //    {
                //        if (jewels_img[tempx1 - 1, tempy1] == jewels_img[tempx1, tempy1] && jewels_img[tempx1, tempy1] == jewels_img[tempx1 - 2, tempy1])
                //        {
                //            Console.WriteLine("działa 5");
                //            lineCrash = true;
                //        }

                //    }

                //    //DRUGI KLIKNIĘTY
                //    if ((tempy2 + 2) <= 7)
                //    {
                //        if (jewels_img[tempx2, tempy2 + 1] == jewels_img[tempx2, tempy2] && jewels_img[tempx2, tempy2] == jewels_img[tempx1, tempy2 + 2])
                //        {
                //            Console.WriteLine("działa 7");
                //            lineCrash = true;
                //        }
                //    }

                //    if ((tempy2 - 2) >= 0)
                //    {
                //        if (jewels_img[tempx2, tempy2 - 1] == jewels_img[tempx2, tempy2] && jewels_img[tempx2, tempy2] == jewels_img[tempx2, tempy2 - 2])
                //        {
                //            Console.WriteLine("działa 8");
                //            lineCrash = true;
                //        }

                //    }

                //    if ((tempx2 + 2) <= 7)
                //    {
                //        if (jewels_img[tempx2 + 1, tempy2] == jewels_img[tempx2, tempy2] && jewels_img[tempx2, tempy2] == jewels_img[tempx2 + 2, tempy2])
                //        {
                //            Console.WriteLine("działa 9");
                //            lineCrash = true;
                //        }
                //    }

                //    if ((tempx2 - 2) >= 0)
                //    {
                //        if (jewels_img[tempx2 - 1, tempy2] == jewels_img[tempx2, tempy2] && jewels_img[tempx2, tempy2] == jewels_img[tempx2 - 2, tempy2])
                //        {
                //            Console.WriteLine("działa 10k");
                //            lineCrash = true;
                //        }

                //    }

                //}

                /*f (lineCrash == false)
                {
                    Console.WriteLine("Przed zamianą jewel #1 = " + jewels_img[tempx1, tempy1] + " a 2 = " + jewels_img[tempx2, tempy2]);
                    int temp = jewels_img[tempx2, tempy2];
                    jewels_img[tempx2, tempy2] = jewels_img[tempx1, tempy1];
                    jewels_img[tempx1, tempy1] = temp;
                    //MakeMap();
                    Button bx1 = this.Controls.Find("box_" + tempx1 + "_" + tempy1, true).FirstOrDefault() as Button;
                    bx1.BackgroundImage = jewels[jewels_img[tempx1, tempy1]];
                    bx1.BackColor = colors[jewels_img[tempx1, tempy1]];

                    Button bx2 = this.Controls.Find("box_" + tempx2 + "_" + tempy2, true).FirstOrDefault() as Button;
                    bx2.BackgroundImage = jewels[jewels_img[tempx2, tempy2]];
                    bx2.BackColor = colors[jewels_img[tempx2, tempy2]];

                    zd_punkty.Text = "+0";
                }
                 if ((tempy1 - tempy2) == 0 && (((tempx1 - tempx2) == 1 || (tempx1 - tempx2) == -1)))
                 {
                     Console.WriteLine("Przed zamianą jewel #1 = " + jewels_img[tempx1, tempy1] + " a 2 = " + jewels_img[tempx2, tempy2]);

                     int temp = jewels_img[tempx2, tempy2];
                     jewels_img[tempx2, tempy2] = jewels_img[tempx1, tempy1];
                     jewels_img[tempx1, tempy1] = temp;

                     Button bx1 = this.Controls.Find("box_" + tempx1 + "_" + tempy1, true).FirstOrDefault() as Button;
                     bx1.BackgroundImage = jewels[jewels_img[tempx1, tempy1]];
                     bx1.BackColor = colors[jewels_img[tempx1, tempy1]];

                     Button bx2 = this.Controls.Find("box_" + tempx2 + "_" + tempy2, true).FirstOrDefault() as Button;
                     bx2.BackgroundImage = jewels[jewels_img[tempx2, tempy2]];
                     bx2.BackColor = colors[jewels_img[tempx2, tempy2]];

                     Console.WriteLine("Po zamianie jewel #1 = " + jewels_img[tempx1, tempy1] + " a 2 = " + jewels_img[tempx2, tempy2]);

                     Console.WriteLine("działa");


                 }
                 */
                #endregion //beta
                lineCrash = false;
                Console.WriteLine(tempMax);
            }

        }
        public void MakeMap()
        {
            ushort loc_x = 3;
            ushort loc_y = 3;
            Bitmap[] jewels = new Bitmap[5];
            jewels[0] = global::Bejeweled.Properties.Resources.red;
            jewels[1] = global::Bejeweled.Properties.Resources.blue;
            jewels[2] = global::Bejeweled.Properties.Resources.purple;
            jewels[3] = global::Bejeweled.Properties.Resources.cherry;
            jewels[4] = global::Bejeweled.Properties.Resources.yellow;
            Color[] colors = new Color[5];
            colors[0] = System.Drawing.Color.Red;
            colors[1] = System.Drawing.Color.Blue;
            colors[2] = System.Drawing.Color.Purple;
            colors[3] = System.Drawing.Color.Chartreuse;
            colors[4] = System.Drawing.Color.Yellow;
            //jewels_img[0, 0] = 0;
            //jewels_img[0, 1] = 0;
            //jewels_img[1, 2] = 0;
            //jewels_img[0, 3] = 0;
            //jewels_img[0, 4] = 0;

            for (int tmp_x = 0; tmp_x <= 7; tmp_x++)
            {
                loc_x = 3;
                for (int tmp_y = 0; tmp_y <= 7; tmp_y++)
                {
                    Button bt = new Button();
                    bt.Name = "box_" + (tmp_x) + "_" + (tmp_y);
                    bt.BackgroundImage = jewels[jewels_img[tmp_x, tmp_y]];
                    bt.BackColor = colors[jewels_img[tmp_x, tmp_y]];
                    bt.Size = new System.Drawing.Size(32, 32);
                    bt.Location = new System.Drawing.Point(loc_x, loc_y);
                    bt.Click += new EventHandler(box_Click);
                    p_glowny.Controls.Add(bt);
                    loc_x += 38;
                }
                loc_y += 38;
            }
            if(beforePlay == true)
            {
                beforePlay = false;
                Check();
            }
        }
    }
}

/* KOD NA ZBIJANIE DIAMENTÓW
if (leftJewel[x,y] == leftJewel[x - 1, y])
{
      if(leftJewel[x - 1, y] - 1 == leftJewel[x - 2, y])
      {
          RemoveBlock();
      }
 }
 if (leftJewel == leftJewel[x, y - 1])
 {
      if(leftJewel[x, y - 1] == leftJewel[x, y - 2])
      {
          RemoveBlock();
      }
 }
 
 if (leftJewel == leftJewel[x, y + 1])
 {
      if(leftJewel[x, y + 1] == leftJewel[x, y + 2])
      {
          RemoveBlock();
      }
 }
 
 if (leftJewel[x,y] == leftJewel[x + 1, y])
 {
      if(leftJewel[x + 1, y] - 1 == leftJewel[x + 2, y])
      {
          RemoveBlock();
      }
 }
 */

     