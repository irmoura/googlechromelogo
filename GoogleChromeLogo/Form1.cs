using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleChromeLogo
{
    public partial class Form1 : Form
    {

        private Graphics graphics = null;
        private int centralHorizontalLine;
        private int centralVerticalLine;
        private int circleSize = 200;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Draw();
        }

        private void Draw()
        {
            centralHorizontalLine = (this.Width / 2) - 8;
            centralVerticalLine = (this.Height / 2) - 7;
            //
            DrawVerticalLine(Color.Red, centralHorizontalLine - 252, 0, centralHorizontalLine + 199, this.Height, 180);//#2 RED
            //
            DrawVerticalLine(Color.Yellow, centralHorizontalLine + 450, 0, centralHorizontalLine, this.Height, 180);
            //
            DrawVerticalLine(Color.LimeGreen, centralHorizontalLine + 255, 0, centralHorizontalLine - 196, this.Height, 180);//#2 GREEN
            //
            DrawVerticalLine(Color.LimeGreen, centralHorizontalLine - 450, 0, centralHorizontalLine, this.Height, 185);//
            //
            DrawHorizontalLine(Color.Red, centralHorizontalLine - 107, centralHorizontalLine + 277, centralVerticalLine - 209, 180);//TARJA SUPERIOR VERMELHA
            //
            DrawHorizontalLine(Color.Yellow, centralHorizontalLine, centralHorizontalLine + 300, centralVerticalLine - 29, 180);//FAIXA AMARELA MENOR
            //
            DrawEllipse(Color.Black, centralHorizontalLine, centralVerticalLine - (((circleSize + 22) * 5) / 2), ((circleSize + 22) * 5));//
            //
            DrawFilledCircle(Color.White, centralHorizontalLine, centralVerticalLine - ((circleSize + 40) / 2), circleSize + 40);
            DrawFilledCircle(Color.Blue, centralHorizontalLine, centralVerticalLine - (circleSize / 2), circleSize);
        }

        private void DrawHorizontalLine(Color color, int x1, int x2, int y, int brushSize)
        {
            graphics = this.CreateGraphics();
            graphics.DrawLine(new Pen(new SolidBrush(color), brushSize), x1, y, x2, y);
        }

        private void DrawVerticalLine(Color color, int x1, int y1, int x2, int y2, int brushSize)
        {
            graphics = this.CreateGraphics();
            graphics.DrawLine(new Pen(new SolidBrush(color), brushSize), x1, y1, x2, y2);
        }

        private void DrawFilledCircle(Color color, int x, int y, int circleSize)
        {
            graphics = this.CreateGraphics();
            Rectangle rectangle = new Rectangle((x - (circleSize / 2)), y, circleSize, circleSize);
            graphics.FillEllipse(new SolidBrush(color), rectangle);
        }

        private void DrawEllipse(Color color, int x, int y, int circleSize)
        {
            graphics = this.CreateGraphics();
            Rectangle rectangle = new Rectangle((x - (circleSize / 2)), y, circleSize, circleSize);
            graphics.DrawEllipse(new Pen(new SolidBrush(color), 512), rectangle);
        }
    }
}
