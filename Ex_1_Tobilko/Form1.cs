using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_1_Tobilko
{
    public partial class Form1 : Form
    {
        private int[] vectorA = new int[3];
        private int[] vectorB = new int[3];
        private int[] vectorC = new int[3];
        private int state = 0;
        private double module_for_state_2 = 0;
        private double scalar_for_state_3 = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxA1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxA1.Text == "" || !(int.TryParse(textBoxA1.Text, out vectorA[0])))
            {
                textBoxA1.Text = "";
                
            

            }


        }

        private void textBoxA2_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(textBoxA2.Text, out vectorA[1])))
                textBoxA2.Text = "";

        }

        private void textBoxA3_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(textBoxA3.Text, out vectorA[2])))
                textBoxA3.Text = "";

        }
        private void textBoxB1_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(textBoxB1.Text, out vectorB[0])))
                textBoxB1.Text = "";

        }

        private void textBoxB2_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(textBoxB2.Text, out vectorB[1])))
                textBoxB2.Text = "";

        }

        private void textBoxB3_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(textBoxB3.Text, out vectorB[2])))
            {
                textBoxB3.Text = "";
                
            }


        }
        private void textBoxScalarA1_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(textBoxModuleA1.Text, out vectorA[0])))
                textBoxModuleA1.Text = "";

        }
        private void textBoxScalarA2_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(textBoxModuleA2.Text, out vectorA[1])))
                textBoxModuleA2.Text = "";
        }
        private void textBoxScalarA3_TextChanged(object sender, EventArgs e)
        {
            if (!(int.TryParse(textBoxModuleA3.Text, out vectorA[2])))
                textBoxModuleA3.Text = "";
        }
        private void showVectorC()
        {
            textBoxC1.Text = vectorC[0].ToString();
            textBoxC2.Text = vectorC[1].ToString();
            textBoxC3.Text = vectorC[2].ToString();
        }
        private void calculate()
        {
            switch (state)
            {
                case 0:
                    for (int i = 0; i < vectorC.Length; i++)
                    {
                        vectorC[i] = vectorA[i] + vectorB[i];
                    }
                    showVectorC();
                    break;
                case 1:
                    for (int i = 0; i < vectorC.Length; i++)
                    {
                        vectorC[i] = vectorA[i] - vectorB[i];
                    }
                    showVectorC();
                    break;
                case 2:
                    module_for_state_2 = 0;
                    for (int i = 0; i < vectorA.Length; i++)
                        module_for_state_2 += (vectorA[i] * vectorA[i]);
                    module_for_state_2 = Math.Sqrt(module_for_state_2);
                    ansForModule.Text = module_for_state_2.ToString();
                    break;
                
                case 3:
                    scalar_for_state_3 = 0;
                    for (int i = 0; i < vectorA.Length; i++)
                        scalar_for_state_3 += (vectorA[i] * vectorB[i]);
                    ansScalar.Text = scalar_for_state_3.ToString();
                    break;

                default:
                    break;
                   
            }
            
        }

       
        private void buttonGetAnswer_Click(object sender, EventArgs e)
        {
            
            calculate();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            calculate();
        }


        private void menuItem0_Click(object sender, EventArgs e)
        {
            state = 0;
            panel4.Visible = false;
            panel3.Visible = false;
            panel1.Visible = true;
            panel2.Visible = true;
            label15.Text = "+";
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            state = 1;
            panel4.Visible = false;
            panel3.Visible = false;
            panel1.Visible = true;
            panel2.Visible = true;
            label15.Text = "-";
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            state = 2;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            label32.Text = "|a| =";

        }


        private void menuItem3_Click(object sender, EventArgs e)
        {
            state = 3;
            panel4.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;
            panel3.Visible = true;
            label15.Text = "*";
            
        }


    
    }
}
