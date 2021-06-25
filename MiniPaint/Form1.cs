using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class Form1 : Form
    {
        IFactory FigureFactory { get; set; }
        public Form1()
        {
            InitializeComponent();
            List<string> figures = new List<string> { "TriAngle", "Circle", "Rectangle" };
            figureCombobox.Items.AddRange(figures.ToArray());
            figureCombobox.SelectedIndex = 2;
        }
        List<IFigure> Figures = new List<IFigure>();
        private void figureCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = figureCombobox.SelectedItem.ToString();
            if (item == "TriAngle")
            {
                FigureFactory = new TriAngleFactory();
            }
            else if (item == "Rectangle")
            {
                FigureFactory = new RectangleFactory();
            }
            else if (item == "Circle")
            {
                FigureFactory = new CircleFactory();
            }
        }

        interface IFigure
        {
            Point Point { get; set; }
            Size Size { get; set; }
            Color Color { get; set; }
            bool isFilled { get; set; }
        }

        class Rectangle : IFigure
        {
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Color { get; set; }
            public bool isFilled { get; set; }
        }

        class TriAngle : IFigure
        {
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Color { get; set; }
            public bool isFilled { get; set; }
        }


        class Circle : IFigure
        {
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Color { get; set; }
            public bool isFilled { get; set; }
        }

        interface IFactory
        {
            IFigure GetFigure();
        }

        class CircleFactory : IFactory
        {
            public IFigure GetFigure()
            {
                return new Circle();
            }
        }

        class RectangleFactory : IFactory
        {
            public IFigure GetFigure()
            {
                return new Rectangle();
            }
        }

        class TriAngleFactory : IFactory
        {
            public IFigure GetFigure()
            {
                return new TriAngle();
            }
        }
        public Color FigureColor { get; set; }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (FigureFactory.GetFigure() is Rectangle rect)
            {
                if (fillRadiobtn.Checked)
                {
                    rect.isFilled = true;
                    rect.Color = FigureColor;
                    rect.Point = e.Location;
                    rect.Size = new Size(int.Parse(widthTxtb.Text), int.Parse(heightTxtb.Text));
                    Figures.Add(rect);
                }
                else
                {

                    rect.isFilled = false;
                    rect.Color = FigureColor;
                    rect.Point = e.Location;
                    rect.Size = new Size(int.Parse(widthTxtb.Text), int.Parse(heightTxtb.Text));
                    Figures.Add(rect);
                }

            }
            if (FigureFactory.GetFigure() is Circle circ)
            {
                if (fillRadiobtn.Checked)
                {
                    circ.Color = FigureColor;
                    circ.Point = e.Location;
                    circ.Size = new Size(int.Parse(widthTxtb.Text), int.Parse(heightTxtb.Text));
                    circ.isFilled = true;
                    Figures.Add(circ);
                }
                else
                {
                    circ.Color = FigureColor;
                    circ.Point = e.Location;
                    circ.Size = new Size(int.Parse(widthTxtb.Text), int.Parse(heightTxtb.Text));
                    circ.isFilled = false;
                    Figures.Add(circ);
                }
            }
            if (FigureFactory.GetFigure() is TriAngle triangle)
            {
                if (fillRadiobtn.Checked)
                {
                    triangle.Color = FigureColor;
                    triangle.Point = e.Location;
                    triangle.Size = new Size(int.Parse(widthTxtb.Text), int.Parse(heightTxtb.Text));
                    triangle.isFilled = true;
                    Figures.Add(triangle);
                }
                else
                {
                    triangle.Color = FigureColor;
                    triangle.Point = e.Location;
                    triangle.Size = new Size(int.Parse(widthTxtb.Text), int.Parse(heightTxtb.Text));
                    triangle.isFilled = false;
                    Figures.Add(triangle);
                }
            }
            this.Refresh();

        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            var result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                FigureColor = colorDialog.Color;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(FigureColor, 3);
            SolidBrush brush = new SolidBrush(FigureColor);

            using (var a = e.Graphics)
            {
                foreach (var item in Figures)
                {
                    if (item is Rectangle rect)
                    {


                        if (rect.isFilled)
                        {
                            a.FillRectangle(brush, rect.Point.X, rect.Point.Y, rect.Size.Width, rect.Size.Height);
                        }


                        if (rect.isFilled == false)
                        {
                            a.DrawRectangle(pen, rect.Point.X, rect.Point.Y, rect.Size.Width, rect.Size.Height);
                        }

                    }
                    else if (item is Circle circl)
                    {
                        if (circl.isFilled)
                        {
                            a.FillEllipse(brush, circl.Point.X, circl.Point.Y, circl.Size.Width, circl.Size.Height);
                        }
                        if (circl.isFilled == false)
                        {
                            a.DrawEllipse(pen, circl.Point.X, circl.Point.Y, circl.Size.Width, circl.Size.Height);
                        }
                    }
                    else if (item is TriAngle tr)
                    {
                        if (tr.isFilled == true)
                        {
                            Pen blackPen = new Pen(Color.Black, 3);

                            Point top = new Point(tr.Point.X + tr.Size.Width / 2, tr.Point.Y);
                            Point right = new Point(tr.Point.X + tr.Size.Width, tr.Point.Y + tr.Size.Height);
                            Point left = new Point(tr.Point.X, tr.Point.Y + tr.Size.Height);

                            Point[] curvePoints =
                                     {
                 top,
                 right,
                 left,

             };

                            // Draw polygon curve to screen.
                            e.Graphics.FillPolygon(brush, curvePoints);
                        }
                        else
                        {
                            Pen blackPen = new Pen(Color.Black, 3);

                            Point top = new Point(tr.Point.X + tr.Size.Width / 2, tr.Point.Y);
                            Point right = new Point(tr.Point.X + tr.Size.Width, tr.Point.Y + tr.Size.Height);
                            Point left = new Point(tr.Point.X, tr.Point.Y + tr.Size.Height);

                            Point[] curvePoints =
                                     {
                 top,
                 right,
                 left,

             };

                            // Draw polygon curve to screen.
                            e.Graphics.DrawPolygon(pen, curvePoints);
                        }
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
            
        }
    }
}
