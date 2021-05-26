using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment
{
    public partial class Form1 : Form
    {
        String input;
        Bitmap drawOutput;
        String command, command2, command3;
        int x, y;

        private void cmdbox_TextChanged(object sender, EventArgs e)
        {
            input = cmdbox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            




        
    }

        private void button2_Click(object sender, EventArgs e)
        {
            // outputbox.InitialImage = null;
            cmdbox.Clear();

        }

        private void cmdbox_KeyDown(object sender, KeyEventArgs e)
        {
    
        }


        private void cmdbox_Enter(object sender, EventArgs e)
        {
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox2.Text);
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var spilt = input.Split(' ');
            //foreach (String words in spilt)

            command = spilt[0];
            command2 = spilt[1];
            command3 = spilt[2];
            
                


                x = Int32.Parse(command2);
                y = Int32.Parse(command3);
          
            

        Graphics g;
                g = Graphics.FromImage(drawOutput);
                Pen pen = new Pen(Color.Red, 5);
            if (command == "circle")
                {
                    g.DrawEllipse(pen, 0, 0, x, y);

                    setImage(g);

                }
                else if (command == "rectangle")
                {
                    g.DrawRectangle(pen, 0, 0, x, y);

                    setImage(g);

                
                }
            else if (command != "rectangle")
            {
                cmdbox.Text = "Invalid user Credintial";
            }
            else if (command != "circle")
            {
                cmdbox.Text = "Invalid user credintial";
            }
            

            }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void setImage(Graphics g)
        {
            g = Graphics.FromImage(drawOutput);

            outputbox.Image = drawOutput;

            g.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<int> inA = new List<int>();
            var inp = Console.ReadLine();
            while (inp != string.Empty)
            {
                inA.Add(Convert.ToInt32(inp));
                inp = Console.ReadLine();

            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.ResetText();
        }

        private void outputbox_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
            drawOutput = new Bitmap(outputbox.Size.Width, outputbox.Size.Height);
            outputbox.Image = drawOutput;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics g;
            g = Graphics.FromImage(drawOutput);

            Pen mypen = new Pen(Color.Black);
            g.Clear(Color.White);
            g.Dispose();

        }
        }
    }

