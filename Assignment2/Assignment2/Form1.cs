using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Assignment2
{
    public partial class Form1 : Form
    {
        ShapeFactory sp = new ShapeFactory();
        String[] line;
        String[] value;
        public int[] par = new int[4];
        public int[] par3 = new int[10];
        public int[] par2 = new int[6];
        public Form1()
        {
            InitializeComponent();
        }

  
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            edit.Text = File.ReadAllText(theDialog.FileName);


                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < edit.Lines.Length; i++)//counting length of program
            {
                //stored counted length in string
                line = edit.Lines;
                value = line[i].Split(' ');
                if (value[0].Equals("DrawTo", StringComparison.OrdinalIgnoreCase))  //parsing the command
                {
                    //rectangle
                   par[0] = Convert.ToInt32(value[1]);
                   par[1] = Convert.ToInt32(value[2]);
                   MessageBox.Show("" + par[0]);
                   MessageBox.Show("" + par[1]);
                }
               else if (value[0].Equals("Circle", StringComparison.OrdinalIgnoreCase))  //parsing the command
               {
                    //circle
                    Shape sh = sp.getShape("Circle");
                    par[0] = Convert.ToInt32(value[1]);
                    par[1] = Convert.ToInt32(value[2]);
                    MessageBox.Show("" + par[0]);
                    MessageBox.Show("" + par[1]);
                    sh.draw(e.Graphics,value,i);
                }
              
                else if (value[0].Equals("Rectangle", StringComparison.OrdinalIgnoreCase))  //parsing the command
                {
                    //rectangle
                    Shape sh = sp.getShape("Rectangle");

                    par[0] = Convert.ToInt32(value[1]);
                    par[1] = Convert.ToInt32(value[2]);
                    MessageBox.Show("" + par[0]);
                    MessageBox.Show("" + par[1]);
                    sh.draw(e.Graphics, value,i);
                }
                else if (value[0].Equals("Triangle", StringComparison.OrdinalIgnoreCase))  //parsing the command
                {
                    //Triangle
                    Shape sh = sp.getShape("Triangle");
                    
                    par2[0] = Convert.ToInt32(value[1]);
                    par2[1] = Convert.ToInt32(value[2]);
                    par2[2] = Convert.ToInt32(value[3]);
                    par2[3] = Convert.ToInt32(value[4]);
                    par2[4] = Convert.ToInt32(value[5]);
                    par2[5] = Convert.ToInt32(value[6]);
                    MessageBox.Show("" + par2[0]);
                    MessageBox.Show("" + par2[1]);
                    sh.draw(e.Graphics, value,i);
                }
                else if (value[0].Equals("Polygon", StringComparison.OrdinalIgnoreCase))  //parsing the command
                {
                    //Triangle
                    Shape sh = sp.getShape("Polygon");

                    par3[0] = Convert.ToInt32(value[1]);
                    par3[1] = Convert.ToInt32(value[2]);
                    par3[2] = Convert.ToInt32(value[3]);
                    par3[3] = Convert.ToInt32(value[4]);
                    par3[4] = Convert.ToInt32(value[5]);
                    par3[5] = Convert.ToInt32(value[6]);
                    par3[6] = Convert.ToInt32(value[7]);
                    par3[7] = Convert.ToInt32(value[8]);
                   
                    MessageBox.Show("" + par3[0]);
                    MessageBox.Show("" + par3[1]);
                    sh.draw(e.Graphics, value,i);
                }
            }

        }
    }
}
