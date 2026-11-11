using Paint;
using System.Net;
namespace WinAppPaint1
{
    public partial class frmPaint : Form
    {
        private bool isDrawing = false;
        private Point previousPoint;
        private Point StartPoint;
        private Point EndPoint;
        private Color currentColor = Color.Black;
        private float brushsize = 4f;
        private string currentTool = "None";
        private Bitmap bmp;
        private Pen pen = new Pen(Color.Black, 7f);
        public Graphics g;
        private struct LineData
        {
            public Point Start;
            public Point End;
            public Color Color;
            public float Width;
        }
        private List<LineData > lines = new List<LineData>();
        public frmPaint()
        {
            InitializeComponent();
            toolStripButton7.Image = global::Paint.Properties.Resources.вставить;
            toolStripButton1.Image = global::Paint.Properties.Resources.карандаш; 
            toolStripButton4.Image = global::Paint.Properties.Resources.текст;
            toolStripButton5.Image = global::Paint.Properties.Resources.фигуры;
            toolStripButton6.Image = global::Paint.Properties.Resources.палитра;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void âèäToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void видToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (currentTool == "Pen" || currentTool == "Eraser" || currentTool == "Square" || currentTool == "Circle" )
                {
                    isDrawing = true;
                    previousPoint = e.Location;
                    StartPoint = e.Location;
                }
                if (currentTool == "Eraser")
                {
                    currentColor = pictureBox1.BackColor;
                    brushsize = 20f;
                }
                else
                {
                    currentColor = Color.Black;
                    brushsize = 4f;
                }
            }
        }


           


                private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && (currentTool == "Pen" || currentTool == "Eraser"))
            {

                LineData newLine = new LineData
                {
                    Start = previousPoint,
                    End = e.Location,
                    Color = currentColor,
                    Width = brushsize,
                };
                lines.Add(newLine);
                previousPoint = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isDrawing)
            {
                if (currentTool == "Square")
                {
                    EndPoint = e.Location;
                    int x = Math.Min(StartPoint.X, EndPoint.X);
                    int y = Math.Min(StartPoint.Y, EndPoint.Y);
                    int width = Math.Abs(StartPoint.X - EndPoint.X);
                    int height = Math.Abs(StartPoint.Y - EndPoint.Y);
                    if (currentTool == "Square")
                    {
                        g.DrawRectangle(pen, x, y, width, height);
                    }
                    else if (currentTool == "Circle")
                    {
                        g.DrawEllipse(pen, x, y, width, height);
                    }
                    else if (currentTool == "Triangle")
                    {
                        EndPoint = e.Location;
                        Point Top = new Point(x + width / 2, y);       
                        Point Left = new Point(x, y + height);         
                        Point Right= new Point(x + width, y + height); 
                        g.DrawPolygon(pen, new Point[] { Top, Left, Right });
                    }

                    isDrawing = false;
                }
                {
                        isDrawing = false;
                    }
                }
            }
        
                     

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var line in lines)
            {
                using Pen pen = new Pen(line.Color, line.Width);
                {
                    e.Graphics.DrawLine(pen, line.Start, line.End);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            currentTool = "Pen";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            currentTool = "Eraser";
        }
            private void btnSquare_Click(object sender, EventArgs e)
        {
            currentTool = "Square";
        }
        private void btnCircle_Click(object sender, EventArgs e)
        {
            currentTool = "Circle";
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            currentTool = "Triangle";
        }
        }
        

        
}