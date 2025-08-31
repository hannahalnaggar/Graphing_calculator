using System.Globalization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SwitchCalc
{

    public partial class Form1 : Form
    {
        private bool isScientificMode = false;
        private string currentExpression = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 390; // Set default width for standard mode
            textPostfix.Width = 335; // Set default width for standard mode
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void AppendToExpression(string value)
        {
            currentExpression += value;
            textPostfix.Text = currentExpression;
        }
        private string InsertImplicitMultiplication(string expr)
        {
            string result = "";
            for (int i = 0; i < expr.Length - 1; i++)
            {
                char curr = expr[i];
                char next = expr[i + 1];

                result += curr;

       
                if ((char.IsDigit(curr) || curr == 'x' || curr == ')' || curr == '.') &&
                    (next == 'x' || next == '(' || char.IsLetter(next)))
                {
                    result += "*";
                }

       
                else if ((curr == 'x' || curr == ')') && char.IsDigit(next))
                {
                    result += "*";
                }
            }
            result += expr[^1]; 
            return result;
        }

        private void ClearExpression()
        {
            currentExpression = "";
            textPostfix.Text = "";
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                string value = btn.Text;

                // If the value is a function, add '(' automatically
                if (value == "sin" || value == "cos" || value == "tan" || value == "√")
                {
                    AppendToExpression(value + "(");
                }
                else
                {
                    AppendToExpression(value);
                }
            }
            }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentExpression))
            {
                currentExpression = currentExpression.Substring(0, currentExpression.Length - 1);
                textPostfix.Text = currentExpression;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearExpression();
            graph.Invalidate();
        }
     
        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                //var postfix = InfixToPostfix(currentExpression);
                //double result = EvaluatePostfix(postfix);
                string expr = InsertImplicitMultiplication(currentExpression);
                var postfix = InfixToPostfix(expr);
                double result = EvaluatePostfix(postfix);
                textPostfix.Text = result.ToString();
                currentExpression = result.ToString(); // update for reuse
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Expression: " + ex.Message);
            }
        }
        private void btnToggleMode_Click(object sender, EventArgs e)
        {
            isScientificMode = !isScientificMode;
            // Example: show/hide buttons or panels based on mode
           
            this.Width = isScientificMode ? 800 : 390;
            textPostfix.Width = isScientificMode ? 735 : 335;

        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            if (!currentExpression.Contains("x"))
            {
                MessageBox.Show("To plot a graph, the expression must contain 'x'.");
                return;
            }

            try
            {
                string expr = currentExpression;
                Bitmap bmp = new Bitmap(graph.Width, graph.Height);
                Graphics g = Graphics.FromImage(bmp);
                g.Clear(Color.White);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                float centerX = graph.Width / 2f;
                float centerY = graph.Height / 2f;
                float scaleX = 20f;
                float scaleY = 20f;

                // Pens and brushes
                Pen axisPen = new Pen(Color.Black, 1.5f);
                Pen gridPen = new Pen(Color.LightGray, 1);
                Pen graphPen = new Pen(Color.Blue, 2);
                Brush textBrush = Brushes.Black;
                Font labelFont = new Font("Arial", 8);

                // Draw grid lines
                for (int i = -10; i <= 10; i++)
                {
                    // Vertical grid lines
                    float xPos = centerX + (i * scaleX);
                    g.DrawLine(gridPen, xPos, 0, xPos, graph.Height);

                    // Horizontal grid lines
                    float yPos = centerY - (i * scaleY);
                    g.DrawLine(gridPen, 0, yPos, graph.Width, yPos);

                    // X-axis numbers (only every 2 units to avoid clutter)
                    if (i % 2 == 0 && i != 0)
                    {
                        g.DrawString(i.ToString(), labelFont, textBrush, xPos - 10, centerY + 5);
                        // Tick mark on X-axis
                        g.DrawLine(axisPen, xPos, centerY - 5, xPos, centerY + 5);
                    }

                    // Y-axis numbers (only every 2 units to avoid clutter)
                    if (i % 2 == 0 && i != 0)
                    {
                        g.DrawString(i.ToString(), labelFont, textBrush, centerX + 5, yPos - 10);
                        // Tick mark on Y-axis
                        g.DrawLine(axisPen, centerX - 5, yPos, centerX + 5, yPos);
                    }
                }

                // Draw axes with arrows
                g.DrawLine(axisPen, 0, centerY, graph.Width, centerY); // X-axis
                g.DrawLine(axisPen, centerX, graph.Height, centerX, 0); // Y-axis



                // Label axes
                g.DrawString("X", labelFont, textBrush, graph.Width - 15, centerY - 20);
                g.DrawString("Y", labelFont, textBrush, centerX + 10, 5);

                // Plot the graph
                List<PointF> points = new List<PointF>();
                for (double x = -10; x <= 10; x += 0.05)
                {
                    try
                    {
                        string exprX = expr.Replace("x", $"({x.ToString(CultureInfo.InvariantCulture)})");
                        exprX = InsertImplicitMultiplication(exprX);

                        var postfix = InfixToPostfix(exprX);
                        double y = EvaluatePostfix(postfix);

                        if (!double.IsNaN(y) && !double.IsInfinity(y))
                        {
                            float scaledX = centerX + (float)(x * scaleX);
                            float scaledY = centerY - (float)(y * scaleY);
                            points.Add(new PointF(scaledX, scaledY));
                        }
                    }
                    catch {  }
                }

                if (points.Count > 1)
                {
                    g.DrawLines(graphPen, points.ToArray());
                }

                graph.Image = bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while plotting: " + ex.Message);
            }
        }
    
        private int Priority(string op)
        {
            return op switch
            {
                "+" or "-" => 1,
                "*" or "/" => 2,
                "^" => 3,
                _ => 0
            };
        }
        private bool IsLeftAssociative(string op) => op != "^";
        //Shunting Yard algorithm:
        private List<string> InfixToPostfix(string expr)
        {
            List<string> output = new();
            Stack<string> ops = new();
            string token = "";

            for (int i = 0; i < expr.Length; i++)
            {
                char c = expr[i];

                if (char.IsLetter(c) && c != 'x') // Handle functions but exclude 'x' variable
                {
                    token += c;
                    while (i + 1 < expr.Length && char.IsLetter(expr[i + 1]))
                    {
                        token += expr[++i];
                    }
                    ops.Push(token);
                    token = "";
                }
                else if (char.IsDigit(c) || c == '.' || c == 'x' ||
                        (c == '-' && (i == 0 || "+-*/^(".Contains(expr[i - 1]))))
                {
                    token += c;
                }
                else
                {
                    if (!string.IsNullOrEmpty(token))
                    {
                        output.Add(token);
                        token = "";
                    }

                    if (c == '(')
                    {
                        ops.Push(c.ToString());
                        
                    }
                    else if (c == ')')
                    {
                        while (ops.Count > 0 && ops.Peek() != "(")
                        {
                            output.Add(ops.Pop());
                        }
                        if (ops.Count == 0 || ops.Pop() != "(")
                            throw new Exception("Mismatched parentheses");

                        if (ops.Count > 0 && IsFunction(ops.Peek()))
                            output.Add(ops.Pop());
                    }
                    else
                    {
                        string op = c.ToString();
                        while (ops.Count > 0 &&
                               Priority(ops.Peek()) > 0 &&
                               (Priority(ops.Peek()) > Priority(op) ||
                               (Priority(ops.Peek()) == Priority(op) && IsLeftAssociative(op))))
                        {
                            output.Add(ops.Pop());
                        }
                        ops.Push(op);
                    }
                }
            }

            if (!string.IsNullOrEmpty(token))
                output.Add(token);

            while (ops.Count > 0)
            {
                string top = ops.Pop();
                if (top == "(" || top == ")")
                    throw new Exception("Mismatched parentheses");
                output.Add(top);
            }

            return output;
        }

        private bool IsFunction(string s)
        {
            return s is "sin" or "cos" or "tan"  or "√";
        }

        private double EvaluatePostfix(List<string> postfix)
        {
            Stack<double> stack = new();

            foreach (string token in postfix)
            {
                
                if (double.TryParse(token, NumberStyles.Float, CultureInfo.InvariantCulture, out double num))
                {
                    stack.Push(num);
                }
                else if (IsFunction(token))
                {
                    if (stack.Count < 1)
                        throw new Exception("Not enough operands for function: " + token);
                    double arg = stack.Pop();
                    double result = token switch
                    {
                        "sin" => Math.Sin(arg),
                        "cos" => Math.Cos(arg),
                        "tan" => Math.Tan(arg),
                        "√" => Math.Sqrt(arg),
                        _ => throw new Exception("Unknown function")
                    };
                    stack.Push(result);
                }
                else
                {
                    if (stack.Count < 2)
                        throw new Exception("Not enough operands for operator: " + token);
                    double b = stack.Pop();
                    double a = stack.Pop();
                    double res = token switch
                    {
                        "+" => a + b,
                        "-" => a - b,
                        "*" => a * b,
                        "/" => a / b,
                        "^" => Math.Pow(a, b),
                        _ => throw new Exception("Invalid operator")
                    };
                    stack.Push(res);
                }
            }

            if (stack.Count != 1)
                throw new Exception("Invalid expression evaluation");

            return stack.Pop();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width =390;
            textPostfix.Width = 335;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 800;
            textPostfix.Width = 735;
        }
    }
}
 