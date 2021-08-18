using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment
{
    public partial class Form1 : Form
    {
        Boolean paintTringle, fill;
        String syntax;
        String[] words;
        int moveX, moveY;
        int thickness;
        string actionCmd, syntaxCmd;
        ArrayList shapes = new ArrayList();
        Variables variable;
        List<Triangle> tringleObjects;
        List<Variables> variableObjects;
        Color c;
        Shape shape;
        ShapeFactory abstractFactory = new ShapeFactory();
        Triangle tringle;
        int counter;
        int loopCounter;
        string storeMethod;
        string methoName;


        private void cmdbox_TextChanged(object sender, EventArgs e)
        {
            actionCmd = cmdbox.Text.ToLower();
            syntaxCmd = cmdtext.Text;
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
                File.WriteAllText(saveFileDialog1.FileName, cmdtext.Text);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (cmdbox.Text == "" && cmdtext.Text == "")
            {
                MessageBox.Show("Both action command and syntax command is empty! pl");
            }
            else
            {
                switch (actionCmd)
                {
                    case "run":
                        try
                        {
                            if (cmdtext.Text == "")
                            {
                                MessageBox.Show("Syntax and Parameter is not Detected");
                            }
                            syntax = cmdtext.Text.ToLower();
                            //delimeters variables holds the array
                            char[] delimiters = new char[] { '\r', '\n' };
                            //Holds invididuals column code line 
                            string[] parts = syntax.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                            //loop through the whole row's code line
                            for (int i = 0; i < parts.Length; i++)
                            {
                                /* Hold single code line,
                                  for example at 0 position paint circle, at 1 position color red 5
                                */
                                String code_line = parts[i];
                                //Splits the code when space 
                                char[] value_code = new char[] { ' ' };
                                //Holds invididuals code line
                                words = code_line.Split(value_code, StringSplitOptions.RemoveEmptyEntries);


                                //Calculation to add value to variable
                                if (Regex.IsMatch(words[0], @"^[a-zA-Z]+$") && words[1].Equals("+"))
                                {
                                    //sets new incremented value to the defined variable and puts it in vaiableObjects class
                                    variableObjects[variableObjects.FindIndex(x => x.variable.Contains(words[0]))].
                                        setValue(variableObjects[variableObjects.FindIndex(x => x.variable.Contains(words[0]))].
                                        getValue() + Convert.ToInt32(words[2]));
                                }
                                if ((Regex.IsMatch(words[0], @"^[a-zA-Z]+$") && words[1].Equals("=")))
                                {
                                    //add new variableObjects if variableObject is empty
                                    if (variableObjects == null || variableObjects.Count == 0)
                                    {
                                        variable = new Variables();
                                        variable.setVariable(words[0]);
                                        int y = Convert.ToInt32(words[2]);
                                        variable.setValue(y);
                                        variableObjects.Add(variable);
                                    }
                                    else
                                    {
                                        //else checks if variable exists or not
                                        if (!variableObjects.Exists(x => x.variable == words[0]))
                                        {
                                            variable = new Variables();
                                            variable.setVariable(words[0]);
                                            int y = Convert.ToInt32(words[2]);
                                            variable.setValue(y);
                                            variableObjects.Add(variable);
                                        }
                                        //else add new variable value to variableObjects
                                        else
                                        {
                                            variable = new Variables();
                                            variable.setVariable(words[0]);
                                            int y = Convert.ToInt32(words[2]);
                                            variable.setValue(y);
                                            variableObjects[variableObjects.FindIndex(x => x.variable.Contains(words[0]))] = variable;
                                        }
                                    }

                                }


                                //If the there is move word in syntax
                                if (words[0] == "move")
                                {
                                    moveX = Convert.ToInt32(words[1]);
                                    moveY = Convert.ToInt32(words[2]);
                                }

                                //If there is fill word in syntax
                                if (words[0] == "fill")
                                {
                                    if (words[1] == "on")//checks if the word[1] holds value'on'
                                    {
                                        fill = true;//sets fill ture
                                    }
                                    if (words[1] == "off")//checks if the word[1] holds value 'off'
                                    {
                                        fill = false;//sets fill false
                                    }
                                }

                                //Checks if syntax has color word of not, if yes then
                                if (words[0] == "color")
                                {
                                    //Convert string value to integer value
                                    thickness = Convert.ToInt32(words[2]);

                                    //If red color
                                    if (words[1] == "red")
                                    {
                                        c = Color.Red;
                                    }
                                    //If blue color
                                    else if (words[1] == "blue")
                                    {
                                        c = Color.Blue;
                                    }
                                    //If green color
                                    else if (words[1] == "green")
                                    {
                                        c = Color.Green;
                                    }
                                    //If pink color
                                    else if (words[1] == "pink")
                                    {
                                        c = Color.Pink;
                                    }
                                    //If yellow color
                                    else if (words[1] == "yellow")
                                    {
                                        c = Color.Yellow;
                                    }
                                    //If purple color
                                    else if (words[1] == "purple")
                                    {
                                        c = Color.Purple;
                                    }
                                    //If brown color
                                    else if (words[1] == "brown")
                                    {
                                        c = Color.Brown;
                                    }
                                    //If not color then, set the deault black color
                                    else
                                    {
                                        c = Color.Red;
                                    }
                                }

                                //Check for 'paint' word
                                if (words[0].Equals("paint"))
                                {
                                    //Checks for 'circle' word
                                    if (words[1] == "circle")
                                    {
                                        if (words.Length != 3)
                                        {
                                            MessageBox.Show("!!! Invalid syntax !!!\n eg.  'paint circle 150'");
                                        }
                                        else
                                        {
                                            if (variableObjects.Exists(x => x.variable == words[2]) == true)
                                            //Assigns variable value to paint code parameter value
                                            {
                                                words[2] = Convert.ToString(variableObjects.ElementAt(variableObjects.
                                                    FindIndex(x => x.variable.Contains(words[2]))).getValue()); //variable value to radius parameter
                                            }
                                            shape = abstractFactory.getShape("circle");
                                            shape.set(c, moveX, moveY, Convert.ToInt32(words[2]));
                                            shapes.Add(shape);
                                        }
                                    }

                                    //Check if the word is rectangle or not
                                    else if (words[1].Equals("rectangle"))
                                    {
                                        if (words.Length != 4)
                                        {
                                            MessageBox.Show("!!! Invalid syntax !!!\n eg. 'paint rectangle 100 150'");
                                        }
                                        else
                                        {
                                            if (variableObjects.Exists(x => x.variable == words[2] == true))
                                            {
                                                //Variable value to height parameter
                                                words[2] = Convert.ToString(variableObjects.ElementAt(variableObjects.
                                                    FindIndex(x => x.variable.Contains(words[2]))).getValue());
                                            }
                                            if (variableObjects.Exists(x => x.variable == words[3]) == true)
                                            {
                                                //Variable value to width parameter
                                                words[3] = Convert.ToString(variableObjects.ElementAt(variableObjects.
                                                    FindIndex(x => x.variable.Contains(words[3]))).getValue());
                                            }
                                            shape = abstractFactory.getShape("rectangle");
                                            shape.set(c, moveX, moveY, Convert.ToInt32(words[2]), Convert.ToInt32(words[3]));
                                            shapes.Add(shape);
                                        }
                                    }

                                    //Check if the word is tringle or not
                                    if (words[1].Equals("triangle"))
                                    {
                                        if (words.Length != 2)
                                        {
                                            MessageBox.Show("!!! Invalid syntax !!!\n eg. 'paint tringle'");
                                        }
                                        else
                                        {
                                            if (variableObjects.Exists(x => x.variable == words[2]) == true)
                                            //Assigns variable value to paint code parameter value
                                            {
                                                words[2] = Convert.ToString(variableObjects.ElementAt(variableObjects.
                                                    FindIndex(x => x.variable.Contains(words[2]))).getValue()); //variable value to side parameter
                                            }
                                            Triangle tringle = new Triangle();
                                            PointF[] points = { new PointF(100, 100), new PointF(200, 100), new PointF(150, 10) };
                                            tringle.setPoints(points);
                                            tringleObjects.Add(tringle);
                                            paintTringle = true;
                                        }
                                    }
                                }
                                if (words[0] == "loop") 
                                {
                                    //Store value of words[1] into loopCounter 
                                    loopCounter = Convert.ToInt32(words[1]);
                                }
                                //Checks if syntax have 'endloop' word or not, then yes
                                if (parts[i] == "end loop") // code for end loop statement
                                {
                                    //If counter to paint is not less than loop counter
                                    if (counter < loopCounter)
                                    {
                                        i = Array.IndexOf(parts, "loop " + loopCounter);
                                        //Value to increment paint circle method
                                        counter += 1;
                                    }
                                    //Keep painting
                                    else
                                    {
                                        i = Array.IndexOf(parts, "end loop");
                                    }
                                }


                                //Function
                                if (words[0] == "method")
                                {
                                    storeMethod = words[0];
                                    methoName = words[1];
                                }

                                if (storeMethod == "method" && methoName == "myMethod")
                                {


                                }

                                //If condition
                                //Check wheather syntax contain 'if' word or not, if yes then  
                                //Code for if statement
                                if (words[0] == "if")
                                {
                                    //Declared string variable with varibale_name and store the value of 'word[1]' into it
                                    string variable_name = words[1];
                                    //Declared integer variable and store the value of of word[3]
                                    int value = Convert.ToInt32(words[3]);
                                    //Checks if condition defined in if condition matches with variable objects list
                                    if (variableObjects.Exists(x => x.variable == words[1]) == true
                                        && variableObjects.Exists(x => x.value == Convert.ToInt32(words[3])) == true)
                                    {
                                        Console.WriteLine("Entered endside the if statement statement");
                                    }
                                    else
                                    {
                                        //Directed to end if line
                                        i = Array.IndexOf(parts, "end if");
                                    }
                                }

                            }
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            Console.WriteLine("Error" + " " + ex);
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Enter the correct parameter" + " " + ex);

                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine("Enter the correct parameter" + " " + ex);
                        }
                        outputbox.Refresh();
                        break;
                    case "clear":
                        shapes.Clear();
                        tringleObjects.Clear();
                        cmdtext.Clear();
                        outputbox.Refresh();
                        break;
                    case "reset":
                        moveX = 0;
                        moveY = 0;
                        outputbox.Refresh();
                        break;
                    default:
                        MessageBox.Show("The action command is empty\n" +
                            "\n" +
                            "Must be: 'run' for Execuit the app\n" +
                            "Must be: 'clear' for Fresh Start"
                            );
                        break;
                }
            }

        }

        private void outputbox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            //Paint shapes
            for (int i = 0; i < shapes.Count; i++)
            {
                shape = (Shape)shapes[i];
                if (shape != null)
                {
                    shape.draw(g, c, thickness);
                    //check if fill is one or not
                    if (fill == true)
                    {
                        shape.fill(g, c);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Shape in array");
                }
            }


            //If paintTringle condition is true then
            if (paintTringle == true)// paint condition is true then
            {
                foreach (Triangle trangleObject in tringleObjects)
                {
                    //If fill is on then fill the shape with color
                    if (fill == true)
                    {
                        trangleObject.fill(g, c);
                    }
                    //If fill is off, then
                    else
                    {
                        trangleObject.draw(g, c, thickness);
                    }
                }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "-------------------HINTS------------------\n" +
            "COMMANDS TO DISPLAY THE SHAPES \n" +
            "-----------------------------\n" +
            "Example :- \n" +
            "paint rectangle 100 150\n" +
            "paint circle 150 \n" +
            "paint tringle \n" +
            "-----------------------------------------\n" +
            "TO CHANGE THE CO-ORDINATE OF THE SHAPES \n" +
            "-----------------------------\n" +
            "Example :- \n" +
            "move 50 50\n" +
            "---------------------------------------\n" +
            "TO CHANGE THE COLOR OF SHAPES \n" +
            "--------------------------------\n" +
            "Example :- \n" +
            "color red 10\n " +
            "-----------------------------------------------\n" +
            "TO FILL AND UNFILL COLOR \n" +
            "--------------------------------\n" +
            "Example :- \n" +
            "fill on \n" +
            "fill off \n" +
            "-----------------------------------------------\n" +
            "TO PAINT THE SAHPES USING VARIABLES \n" +
            "------------------------------------------\n" +
            "Example :- \n" +
            "radius = 150\n" +
            "paint circle radius\n" +
            "-------------------------------------------------\n" +
            "IF STATEMENT:\n" +
            "--------------------------------\n" +
            "Example :- \n" +
            "a = 5 \n if a = 5 then \n paint circle 100 \n end if \n" +
            "--------------------------------------------\n" +
            "FOR LOOPING: \n" +
            "--------------------------------\n" +
            "Example :- \n" +
            "r = 5 \n loop 3 \n r + 50 \n paint circle r \n endloop \n " +
            "--------------------------------\n"
            );

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tringleObjects = new List<Triangle>(); //creates array of new polygon object
            variableObjects = new List<Variables>();//creates array of new variables objects
            //Sets the color on startUp
            c = Color.DarkCyan;
        }

        private void loadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cmdtext.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }
    }
    }

