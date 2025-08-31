namespace SwitchCalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ToolStripMenuItem = new ToolStripMenuItem();
            standardToolStripMenuItem = new ToolStripMenuItem();
            scientificToolStripMenuItem = new ToolStripMenuItem();
            standardToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            textPostfix = new TextBox();
            btnDel = new Button();
            btnClearEntry = new Button();
            btnClear = new Button();
            btnPM = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnAdd = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSub = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMul = new Button();
            btn0 = new Button();
            btnDecimal = new Button();
            btnEqual = new Button();
            btnDiv = new Button();
            btnSin = new Button();
            btnCos = new Button();
            btnTan = new Button();
            btnX = new Button();
            btnSqrt = new Button();
            btnPow = new Button();
            btnPi = new Button();
            btnPlot = new Button();
            button2 = new Button();
            button1 = new Button();
            graph = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)graph).BeginInit();
            SuspendLayout();
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { standardToolStripMenuItem, scientificToolStripMenuItem, standardToolStripMenuItem1 });
            ToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.Size = new Size(82, 29);
            ToolStripMenuItem.Text = "MODE";
            // 
            // standardToolStripMenuItem
            // 
            standardToolStripMenuItem.ForeColor = Color.Crimson;
            standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            standardToolStripMenuItem.Size = new Size(192, 34);
            standardToolStripMenuItem.Text = "Standard";
            standardToolStripMenuItem.Click += standardToolStripMenuItem_Click;
            // 
            // scientificToolStripMenuItem
            // 
            scientificToolStripMenuItem.ForeColor = Color.Crimson;
            scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            scientificToolStripMenuItem.Size = new Size(192, 34);
            scientificToolStripMenuItem.Text = "Scientific";
            scientificToolStripMenuItem.Click += scientificToolStripMenuItem_Click;
            // 
            // standardToolStripMenuItem1
            // 
            standardToolStripMenuItem1.Name = "standardToolStripMenuItem1";
            standardToolStripMenuItem1.Size = new Size(192, 34);
            standardToolStripMenuItem1.Text = "Standard";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(759, 33);
            menuStrip1.TabIndex = 62;
            menuStrip1.Text = "menuStrip1";
            // 
            // textPostfix
            // 
            textPostfix.BackColor = Color.LightBlue;
            textPostfix.Font = new Font("Lucida Console", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textPostfix.ForeColor = Color.MidnightBlue;
            textPostfix.Location = new Point(20, 44);
            textPostfix.Multiline = true;
            textPostfix.Name = "textPostfix";
            textPostfix.Size = new Size(732, 42);
            textPostfix.TabIndex = 41;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.DeepPink;
            btnDel.Font = new Font("Sitka Small", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel.ForeColor = Color.LemonChiffon;
            btnDel.Location = new Point(20, 92);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(78, 68);
            btnDel.TabIndex = 42;
            btnDel.Text = "⌫";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDelete_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.BackColor = Color.DeepPink;
            btnClearEntry.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnClearEntry.ForeColor = Color.LemonChiffon;
            btnClearEntry.Location = new Point(106, 92);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(78, 68);
            btnClearEntry.TabIndex = 43;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = false;
            btnClearEntry.Click += btnClear_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DeepPink;
            btnClear.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnClear.ForeColor = Color.LemonChiffon;
            btnClear.Location = new Point(192, 92);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 68);
            btnClear.TabIndex = 44;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnPM
            // 
            btnPM.BackColor = Color.LightSkyBlue;
            btnPM.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPM.ForeColor = Color.DeepPink;
            btnPM.Location = new Point(278, 92);
            btnPM.Name = "btnPM";
            btnPM.Size = new Size(78, 68);
            btnPM.TabIndex = 45;
            btnPM.Text = "M";
            btnPM.UseVisualStyleBackColor = false;
            btnPM.Click += btnToggleMode_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Navy;
            btn7.Font = new Font("Lucida Console", 14F);
            btn7.ForeColor = SystemColors.ActiveCaption;
            btn7.Location = new Point(20, 168);
            btn7.Name = "btn7";
            btn7.Size = new Size(78, 68);
            btn7.TabIndex = 46;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += Button_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Navy;
            btn8.Font = new Font("Lucida Console", 14F);
            btn8.ForeColor = SystemColors.ActiveCaption;
            btn8.Location = new Point(106, 168);
            btn8.Name = "btn8";
            btn8.Size = new Size(78, 68);
            btn8.TabIndex = 47;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += Button_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Navy;
            btn9.Font = new Font("Lucida Console", 14F);
            btn9.ForeColor = SystemColors.ActiveCaption;
            btn9.Location = new Point(192, 168);
            btn9.Name = "btn9";
            btn9.Size = new Size(78, 68);
            btn9.TabIndex = 48;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += Button_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSkyBlue;
            btnAdd.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Blue;
            btnAdd.Location = new Point(278, 168);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 68);
            btnAdd.TabIndex = 49;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += Button_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Navy;
            btn4.Font = new Font("Lucida Console", 14F);
            btn4.ForeColor = SystemColors.ActiveCaption;
            btn4.Location = new Point(20, 244);
            btn4.Name = "btn4";
            btn4.Size = new Size(78, 68);
            btn4.TabIndex = 50;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += Button_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Navy;
            btn5.Font = new Font("Lucida Console", 14F);
            btn5.ForeColor = SystemColors.ActiveCaption;
            btn5.Location = new Point(106, 244);
            btn5.Name = "btn5";
            btn5.Size = new Size(78, 68);
            btn5.TabIndex = 51;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += Button_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Navy;
            btn6.Font = new Font("Lucida Console", 14F);
            btn6.ForeColor = SystemColors.ActiveCaption;
            btn6.Location = new Point(192, 244);
            btn6.Name = "btn6";
            btn6.Size = new Size(78, 68);
            btn6.TabIndex = 52;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += Button_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.LightSkyBlue;
            btnSub.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnSub.ForeColor = Color.Blue;
            btnSub.Location = new Point(278, 244);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(78, 68);
            btnSub.TabIndex = 53;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += Button_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Navy;
            btn1.Font = new Font("Lucida Console", 14F);
            btn1.ForeColor = SystemColors.ActiveCaption;
            btn1.Location = new Point(20, 320);
            btn1.Name = "btn1";
            btn1.Size = new Size(78, 68);
            btn1.TabIndex = 54;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += Button_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Navy;
            btn2.Font = new Font("Lucida Console", 14F);
            btn2.ForeColor = SystemColors.ActiveCaption;
            btn2.Location = new Point(106, 320);
            btn2.Name = "btn2";
            btn2.Size = new Size(78, 68);
            btn2.TabIndex = 55;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += Button_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Navy;
            btn3.Font = new Font("Lucida Console", 14F);
            btn3.ForeColor = SystemColors.ActiveCaption;
            btn3.Location = new Point(192, 320);
            btn3.Name = "btn3";
            btn3.Size = new Size(78, 68);
            btn3.TabIndex = 56;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += Button_Click;
            // 
            // btnMul
            // 
            btnMul.BackColor = Color.LightSkyBlue;
            btnMul.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnMul.ForeColor = Color.Blue;
            btnMul.Location = new Point(278, 320);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(78, 68);
            btnMul.TabIndex = 57;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = false;
            btnMul.Click += Button_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Navy;
            btn0.Font = new Font("Lucida Console", 14F);
            btn0.ForeColor = SystemColors.ActiveCaption;
            btn0.Location = new Point(20, 396);
            btn0.Name = "btn0";
            btn0.Size = new Size(78, 68);
            btn0.TabIndex = 58;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += Button_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.HotPink;
            btnDecimal.Font = new Font("Tahoma", 12F);
            btnDecimal.ForeColor = Color.DeepPink;
            btnDecimal.Location = new Point(106, 396);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(78, 68);
            btnDecimal.TabIndex = 59;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.HotPink;
            btnEqual.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnEqual.ForeColor = Color.DeepPink;
            btnEqual.Location = new Point(192, 396);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(78, 68);
            btnEqual.TabIndex = 60;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.LightSkyBlue;
            btnDiv.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnDiv.ForeColor = Color.Blue;
            btnDiv.Location = new Point(278, 396);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(78, 68);
            btnDiv.TabIndex = 61;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += Button_Click;
            // 
            // btnSin
            // 
            btnSin.BackColor = Color.Navy;
            btnSin.Font = new Font("Lucida Console", 14F);
            btnSin.ForeColor = SystemColors.ActiveCaption;
            btnSin.Location = new Point(372, 94);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(78, 68);
            btnSin.TabIndex = 63;
            btnSin.Text = "sin";
            btnSin.UseVisualStyleBackColor = false;
            btnSin.Click += Button_Click;
            // 
            // btnCos
            // 
            btnCos.BackColor = Color.Navy;
            btnCos.Font = new Font("Lucida Console", 14F);
            btnCos.ForeColor = SystemColors.ActiveCaption;
            btnCos.Location = new Point(458, 94);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(78, 68);
            btnCos.TabIndex = 64;
            btnCos.Text = "cos";
            btnCos.UseVisualStyleBackColor = false;
            btnCos.Click += Button_Click;
            // 
            // btnTan
            // 
            btnTan.BackColor = Color.Navy;
            btnTan.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTan.ForeColor = SystemColors.ActiveCaption;
            btnTan.Location = new Point(544, 94);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(78, 68);
            btnTan.TabIndex = 65;
            btnTan.Text = "tan";
            btnTan.UseVisualStyleBackColor = false;
            btnTan.Click += Button_Click;
            // 
            // btnX
            // 
            btnX.BackColor = Color.Navy;
            btnX.Font = new Font("Lucida Console", 14F);
            btnX.ForeColor = SystemColors.ActiveCaption;
            btnX.Location = new Point(630, 94);
            btnX.Name = "btnX";
            btnX.Size = new Size(78, 68);
            btnX.TabIndex = 66;
            btnX.Text = "x";
            btnX.UseVisualStyleBackColor = false;
            btnX.Click += Button_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = Color.Navy;
            btnSqrt.Font = new Font("Lucida Console", 14F);
            btnSqrt.ForeColor = SystemColors.ActiveCaption;
            btnSqrt.Location = new Point(372, 168);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(78, 68);
            btnSqrt.TabIndex = 67;
            btnSqrt.Text = "√";
            btnSqrt.UseVisualStyleBackColor = false;
            btnSqrt.Click += Button_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.Navy;
            btnPow.Font = new Font("Lucida Console", 14F);
            btnPow.ForeColor = SystemColors.ActiveCaption;
            btnPow.Location = new Point(458, 168);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(78, 68);
            btnPow.TabIndex = 68;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += Button_Click;
            // 
            // btnPi
            // 
            btnPi.BackColor = Color.Navy;
            btnPi.Font = new Font("Lucida Console", 14F);
            btnPi.ForeColor = SystemColors.ActiveCaption;
            btnPi.Location = new Point(544, 168);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(78, 68);
            btnPi.TabIndex = 69;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = false;
            btnPi.Click += Button_Click;
            // 
            // btnPlot
            // 
            btnPlot.BackColor = Color.DeepPink;
            btnPlot.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlot.ForeColor = Color.White;
            btnPlot.Location = new Point(630, 168);
            btnPlot.Name = "btnPlot";
            btnPlot.Size = new Size(78, 68);
            btnPlot.TabIndex = 70;
            btnPlot.Text = "PLOT";
            btnPlot.UseVisualStyleBackColor = false;
            btnPlot.Click += btnPlot_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.Font = new Font("Lucida Console", 14F);
            button2.ForeColor = SystemColors.ActiveCaption;
            button2.Location = new Point(714, 166);
            button2.Name = "button2";
            button2.Size = new Size(38, 70);
            button2.TabIndex = 73;
            button2.Text = ")";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.Font = new Font("Lucida Console", 14F);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(714, 94);
            button1.Name = "button1";
            button1.Size = new Size(38, 66);
            button1.TabIndex = 72;
            button1.Text = "(";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button_Click;
            // 
            // graph
            // 
            graph.Location = new Point(372, 242);
            graph.Name = "graph";
            graph.Size = new Size(380, 222);
            graph.TabIndex = 74;
            graph.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.Font = new Font("Lucida Console", 14F);
            button3.ForeColor = SystemColors.ActiveCaption;
            button3.Location = new Point(104, 396);
            button3.Name = "button3";
            button3.Size = new Size(78, 68);
            button3.TabIndex = 59;
            button3.Text = ".";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSkyBlue;
            button4.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            button4.ForeColor = Color.Blue;
            button4.Location = new Point(190, 396);
            button4.Name = "button4";
            button4.Size = new Size(78, 68);
            button4.TabIndex = 60;
            button4.Text = "=";
            button4.UseVisualStyleBackColor = false;
            button4.Click += btnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(759, 479);
            Controls.Add(graph);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnPlot);
            Controls.Add(btnPi);
            Controls.Add(btnPow);
            Controls.Add(btnSqrt);
            Controls.Add(btnX);
            Controls.Add(btnTan);
            Controls.Add(btnCos);
            Controls.Add(btnSin);
            Controls.Add(btnDiv);
            Controls.Add(button4);
            Controls.Add(btnEqual);
            Controls.Add(button3);
            Controls.Add(btnDecimal);
            Controls.Add(btn0);
            Controls.Add(btnMul);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnSub);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnAdd);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnPM);
            Controls.Add(btnClear);
            Controls.Add(btnClearEntry);
            Controls.Add(btnDel);
            Controls.Add(textPostfix);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Calculator";
            TransparencyKey = Color.Fuchsia;
            Load += Form1_Load;
            Click += Button_Click;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)graph).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem ToolStripMenuItem;
        private ToolStripMenuItem standardToolStripMenuItem;
        private ToolStripMenuItem scientificToolStripMenuItem;
        private MenuStrip menuStrip1;
        private TextBox textPostfix;
        private Button btnDel;
        private Button btnClearEntry;
        private Button btnClear;
        private Button btnPM;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnAdd;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSub;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnMul;
        private Button btn0;
        private Button btnDecimal;
        private Button btnEqual;
        private Button btnDiv;
        private Button btnSin;
        private Button btnCos;
        private Button btnTan;
        private Button btnX;
        private Button btnSqrt;
        private Button btnPow;
        private Button btnPi;
        private Button btnPlot;
        private Button button2;
        private Button button1;
        private PictureBox graph;
        private Button button3;
        private Button button4;
        private ToolStripMenuItem standardToolStripMenuItem1;
    }
}
