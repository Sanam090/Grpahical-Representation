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
            for (int i = 0; i < edit.Lines.Length-1; i++)//counting length of program
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
                    sh.draw(e.Graphics,par);
                   
                }
                else if (value[0].Equals("Triangle", StringComparison.OrdinalIgnoreCase))  //parsing the command
                {
                    //rectangle


                    par[0] = Convert.ToInt32(value[1]);
                    par[1] = Convert.ToInt32(value[2]);
                    MessageBox.Show("" + par[0]);
                    MessageBox.Show("" + par[1]);
                }
                else if (value[0].Equals("Rectangle", StringComparison.OrdinalIgnoreCase))  //parsing the command
                {
                    //rectangle
                    Shape sh = sp.getShape("Rectangle");

                    par[0] = Convert.ToInt32(value[1]);
                    par[1] = Convert.ToInt32(value[2]);
                    MessageBox.Show("" + par[0]);
                    MessageBox.Show("" + par[1]);
                    sh.draw(e.Graphics, par);
                }
                else if (value[0].Equals("Triangle", StringComparison.OrdinalIgnoreCase))  //parsing the command
                {
                    //Triangle
                    Shape sh = sp.getShape("Triangle");

                    par[0] = Convert.ToInt32(value[1]);
                    par[1] = Convert.ToInt32(value[2]);
                    MessageBox.Show("" + par[0]);
                    MessageBox.Show("" + par[1]);
                    sh.draw(e.Graphics, par);
                }
            }

        }
    }
}
