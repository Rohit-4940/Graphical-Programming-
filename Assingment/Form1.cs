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
        

        private void cmdbox_TextChanged(object sender, EventArgs e)
        {
           
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


       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        
        private void outputbox_Click(object sender, EventArgs e)
        {

        }

       

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox2.Text);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void loadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }
    }
    }

