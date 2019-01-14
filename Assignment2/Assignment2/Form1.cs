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
using System.Collections;

namespace Assignment2
{
    /// <summary>
    /// This is the main class form1 which is inherit from form
    /// A factory creates objects. We implement the factory design pattern in a C# program
    ///  The Hashtable class represents a collection of key-and-value pairs that 
    ///  are organized based on the hash code of the key.
    /// 
    //
    /// </summary>
    public partial class Form1 : Form
    {
        ShapeFactory sp = new ShapeFactory();       //object created of Shapefactory class
        String[] line;
        String[] value;
        Hashtable hashtable = new Hashtable();            //for the collection of the key pass from users
        public int[] par = new int[4];
        public int[] par3 = new int[10];
        public int[] par2 = new int[6];
        /// <summary>
        /// this is the constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();                        //default constrcutor
        }

  
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
        /// <summary>
        /// this is the method to open read and write the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();       //to select file in the computer
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";                 //verification of the file as .txt
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
        /// <summary>
        /// this is the method which is used to take the
        /// value of loop and pass to next method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            //stored counted length in string
            //int x = 100;
            //loop 10:
            //endloop

            
            Boolean loop = false;
            Boolean if1 = false;
            int loop_num = 0;
            int indexfrom = 0;
            int indexto = 0;

            int if_num = 0;
            string hashvalue = "";
            int ifindexfrom = 0;
            int ifindexto = 0;
            for (int i = 0; i < edit.Lines.Length; i++)//counting length of program
            {
                line = edit.Lines;                       //count the line
                value = line[i].Split(' ');              //split the line and set the value

                Boolean ifb = false;
                if (line[i].Contains("loop") == true && line[i].Contains(":") == true && loop == false)
                {
                    indexfrom = i;
                    loop = true;
                    int pFrom = line[i].IndexOf("loop") + "loop".Length;
                    int pTo = line[i].LastIndexOf(":");

                    loop_num = Int32.Parse(line[i].Substring(pFrom, pTo - pFrom).Replace(" ",""));
                }
                if (line[i].Contains("endloop"))
                {
                    indexto = i;
                    
                    for (int b = 0; b < loop_num; b++)
                    {
                        
                        for (int a = indexfrom; a < indexto; a++)
                        {
                            check(e, value, a);
                        }
                    }
                    loop = false;
                    loop_num = 0;
                    indexfrom = 0;
                    indexto = 0;
                }
                else if (line[i].Contains("if") == true && line[i].Contains(":") == true && line[i].Contains("==") == true)
                {
                    ifb = true;

                    ifindexfrom = i;
                    int pFrom = line[i].IndexOf("if") + "if".Length;
                    int pTo = line[i].LastIndexOf("==");

                    hashvalue = line[i].Substring(pFrom, pTo - pFrom);
                    int pFrom1 = line[i].IndexOf("==") + "==".Length;
                    int pTo1 = line[i].LastIndexOf(":");

                    if_num = Int32.Parse(line[i].Substring(pFrom1, pTo1 - pFrom1));
                    
                }
                else if (line[i].Contains("endif") )
                {
                    ifindexto = i;
                    MessageBox.Show(hashtable[hashvalue] + "");

                    if (Int32.Parse(hashtable[hashvalue] + "") == if_num)
                    {
                        for (int a = ifindexfrom; a < ifindexto; a++)
                        {
                            check(e, value, i);
                        }
                    }
                    ifindexfrom = 0;
                    ifindexto = 0;
                    ifb = false;
                }
                else
                {
                    if (ifb == false)
                    {
                      check(e, value, i);
                    }

                }
                
            }
        }
        /// <summary>
        /// this is the method which check the
        /// value pass by user and create shape as per the user command
        ///
        /// </summary>
        /// <param name="e"></param>
        /// <param name="value"></param>
        /// <param name="i"></param>

        public void check(PaintEventArgs e,string[] value,int i)
        {
            //stored counted length in string
            if (value[0].Equals("DrawTo", StringComparison.OrdinalIgnoreCase))  //parsing the command
            {
                //rectangle
                par[0] = Convert.ToInt32(value[1]);
                par[1] = Convert.ToInt32(value[2]);
                MessageBox.Show("" + par[0]);
                MessageBox.Show("" + par[1]);
            }
            if (value[0].Equals("Circle", StringComparison.OrdinalIgnoreCase))  //parsing the command
            {
                //circle
                Shape sh = sp.getShape("Circle");

                sh.draw(e.Graphics, value, i, hashtable);
            }

            if (value[0].Equals("int"))
            {
                
                if (value[2].Equals("=") == true && value[4].Equals(";") == true)    //checking the condition
                {
                    int From = line[i].IndexOf("int") + "int".Length;
                    int To = line[i].LastIndexOf("=");

                    String res = line[i].Substring(From, To - From).Replace(" ", String.Empty);           //set the value in res

                    int From1 = line[i].IndexOf("=") + "=".Length;
                    int To1 = line[i].LastIndexOf(";");

                    int res1 = Int32.Parse(line[i].Substring(From1, To1 - From1).Replace(" ", String.Empty));
                    try
                    {
                        hashtable.Add(res, res1);                     //passing the value to hashtable 
                    }
                    catch (Exception x)
                    {
                        hashtable[res] = res1;
                    }
                }
            }
            //x =+ 10 ;
            
           
            if (value[0].Equals("Rectangle", StringComparison.OrdinalIgnoreCase))  //parsing the command
            {
                //rectangle
                Shape sh = sp.getShape("Rectangle");
                sh.draw(e.Graphics, value, i, hashtable);
            }
            
            if (value[0].Equals("Triangle", StringComparison.OrdinalIgnoreCase))  //parsing the command
            {
                //Triangle
                Shape sh = sp.getShape("Triangle");
                sh.draw(e.Graphics, value, i, hashtable);
            }
            
            if (value[0].Equals("Polygon", StringComparison.OrdinalIgnoreCase))  //parsing the command
            {
                //Triangle
                Shape sh = sp.getShape("Polygon");
                sh.draw(e.Graphics, value, i, hashtable);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paint p = new paint();

            p.Show();
        }
    }
}
