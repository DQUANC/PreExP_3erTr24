using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreExP_Dquan
{
    public partial class Form1 : Form
    {
        public Vector NumbersVector0 = new Vector();
        public Vector NumbersVector1 = new Vector();
        public int VectorSize = 10;
        public int varAleatory0 = 0;
        public int varAleatory1 = 0;

        public Form1()
        {
            InitializeComponent();
            NumbersVector0.add(VectorSize);
            NumbersVector1.add(VectorSize);
            ChargeNumbersRND1();
            ChargeNumnersRND0();
            Limpiar();
        }

        public void ChargeNumnersRND0()
        {
            for (int i = 0; i <= VectorSize - 1; i++)
            {
                Random rnd0 = new Random();
                varAleatory0 = rnd0.Next(0, 100);
                Thread.Sleep(20);
                NumbersVector0.AddDataVector(Convert.ToString(varAleatory0));
            }
        }

        public void ChargeNumbersRND1()
        {
            for (int i = 0; i <= VectorSize - 1; i++)
            {
                Random rnd1 = new Random();
                varAleatory1 = rnd1.Next(0, 100);
                Thread.Sleep(20);
                NumbersVector1.AddDataVector(Convert.ToString(varAleatory1));
            }
        }

        public void ReturnValue0()
        {
            for (int i = 0; i <= VectorSize - 1; i++)
            {
                var numero = NumbersVector0.returnValue(i);
                switch (i)
                {
                    case 0:
                        label1.Text = numero; break;
                    case 1:
                        label2.Text = numero; break;
                    case 2:
                        label3.Text = numero; break;
                    case 3:
                        label4.Text = numero; break;
                    case 4:
                        label5.Text = numero; break;
                    case 5:
                        label6.Text = numero; break;
                    case 6:
                        label7.Text = numero; break;
                    case 7:
                        label8.Text = numero; break;
                    case 8:
                        label9.Text = numero; break;
                    case 9:
                        label10.Text = numero; break;
                }
            }
        }

        public void ReturnValue1()
        {
            for (int i = 0; i <= VectorSize - 1; i++)
            {
                var numero = NumbersVector0.returnValue(i);
                switch (i)
                {
                    case 0:
                        label11.Text = numero; break;
                    case 1:
                        label12.Text = numero; break;
                    case 2:
                        label13.Text = numero; break;
                    case 3:
                        label14.Text = numero; break;
                    case 4:
                        label15.Text = numero; break;
                    case 5:
                        label16.Text = numero; break;
                    case 6:
                        label17.Text = numero; break;
                    case 7:
                        label18.Text = numero; break;
                    case 8:
                        label19.Text = numero; break;
                    case 9:
                        label21.Text = numero; break;
                }
            }
        }

        public void BackGroundColor0()
        {
            var color = Color.White; 
           
            for (int i = 0; i <= VectorSize - 1;  i++) 
            {
                var numero = Convert.ToInt32(NumbersVector0.returnValue(i));
                if (numero <= 20)
            {
                color = Color.Green;
            } else if (numero <= 50 && numero >= 21)
            {
                color = Color.Yellow;
            } else if (numero <= 80 && numero >= 51)
            {
                color = Color.Blue;
            } else if (numero >= 81 && numero <= 100)
            {
                color = Color.Red;
            }

                switch(i){
                    case 1: label1.BackColor = color; break;    
                    case 2: label2.BackColor = color; break;
                    case 3: label3.BackColor = color; break;
                    case 4: label4.BackColor = color; break;
                    case 5: label5.BackColor = color; break;
                    case 6: label6.BackColor = color; break;
                    case 7: label7.BackColor = color; break;
                    case 8: label8.BackColor = color; break;
                    case 9: label9.BackColor = color; break;
                    case 10: label10.BackColor = color; break;
                }
            }
        }

        public void BackGroundColor1()
        {
            var color = Color.White;

            for (int i = 0; i <= VectorSize - 1; i++)
            {
                var numero = Convert.ToInt32(NumbersVector1.returnValue(i));
                if (numero <= 20)
                {
                    color = Color.Green;
                }
                else if (numero <= 50 && numero >= 21)
                {
                    color = Color.Yellow;
                }
                else if (numero <= 80 && numero >= 51)
                {
                    color = Color.Blue;
                }
                else if (numero >= 81 && numero <= 100)
                {
                    color = Color.Red;
                }

                switch (i)
                {
                    case 1: label11.BackColor = color; break;
                    case 2: label12.BackColor = color; break;
                    case 3: label13.BackColor = color; break;
                    case 4: label14.BackColor = color; break;
                    case 5: label15.BackColor = color; break;
                    case 6: label16.BackColor = color; break;
                    case 7: label17.BackColor = color; break;
                    case 8: label18.BackColor = color; break;
                    case 9: label19.BackColor = color; break;
                    case 0: label21.BackColor = color; break;
                }
            }
        }

        public void Limpiar()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label21.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnValue0();
            ReturnValue1();
            BackGroundColor0();
            BackGroundColor1();
        }
    }
}
