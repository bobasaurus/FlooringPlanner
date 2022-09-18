using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlooringPlanner
{
    public partial class BoardLayoutControl : UserControl
    {
        private float screenWidth;//pixels
        private float screenHeight;//pixels

        private float roomWidth = 136.75f;//in
        private float roomLength = 155.0f;//in
        private const float expansionGap = 3.0f / 8.0f;//in
        private const float sawKerf = 3.0f / 32.0f;//in
        //the dimensions of the finished surface of the bamboo planks
        private const float boardWidth = 5 + 1.0f / 8.0f; //in
        private const float boardLength = 36 + 3.0f / 16.0f; //in
        private const float endJointStaggerMinSeparation = 8.0f;//in
        private const float smallestDesiredBoardLength = 10.0f;//in

        private class FlooringRectangle
        {
            public float X, Y, Width, Height;//inches
            public Color FillColor;
            public Color LineColor;
        }
        private List<List<FlooringRectangle>> flooringRectangles = new List<List<FlooringRectangle>>();

        public BoardLayoutControl()
        {
            InitializeComponent();

            screenWidth = this.Width;
            screenHeight = this.Height;

            this.DoubleBuffered = true;
        }

        private float lengthFraction1 = 1.0f;
        private float lengthFraction2 = 0.75f;
        private float lengthFraction3 = 0.25f;

        public void SetStartingLengths(float lengthFraction1, float lengthFraction2, float lengthFraction3)
        {
            this.lengthFraction1 = lengthFraction1;
            this.lengthFraction2 = lengthFraction2;
            this.lengthFraction3 = lengthFraction3;
            this.Refresh();
        }

        

        private float CalcRow(out List<FlooringRectangle> row, float startLocationY, float firstBoardLength, Color lineColor, Color fillColor)
        {
            row = new List<FlooringRectangle>();

            if (firstBoardLength > boardLength) throw new Exception("Invalid first board length: " + firstBoardLength);
            float residualLength = 0;

            float locationX = expansionGap;
            float currentBoardLength = firstBoardLength;
            bool done = false;
            while (!done)
            {


                if ((locationX + currentBoardLength) >= (roomWidth - expansionGap))
                {
                    currentBoardLength = (roomWidth - expansionGap) - locationX;

                    FlooringRectangle fr = new FlooringRectangle();
                    fr.X = locationX;
                    fr.Y = (float)startLocationY;
                    fr.Width = currentBoardLength;
                    fr.Height = (float)boardWidth;
                    fr.LineColor = lineColor;
                    fr.FillColor = fillColor;
                    if (fr.Width < smallestDesiredBoardLength) fr.FillColor = Color.Red;
                    row.Add(fr);



                    residualLength = boardLength - currentBoardLength - sawKerf;
                    done = true;
                }
                else
                {
                    FlooringRectangle fr = new FlooringRectangle();
                    fr.X = locationX;
                    fr.Y = startLocationY;
                    fr.Width = currentBoardLength;
                    fr.Height = boardWidth;
                    fr.LineColor = lineColor;
                    fr.FillColor = fillColor;
                    if (fr.Width < smallestDesiredBoardLength) fr.FillColor = Color.Red;
                    row.Add(fr);

                    locationX += currentBoardLength;
                    currentBoardLength = boardLength;
                }
            }

            return residualLength;
        }

        /*private float DrawRow(Graphics g, Pen pen, Brush fillBrush, float startLocationY, float firstBoardLength)
        {
            if (firstBoardLength > boardLength) throw new Exception("Invalid first board length: " + firstBoardLength);
            float residualLength = 0;

            float locationX = expansionGap;
            float currentBoardLength = firstBoardLength;
            bool done = false;
            while (!done)
            {


                if ((locationX + currentBoardLength) >= (roomWidth - expansionGap))
                {
                    currentBoardLength = (roomWidth - expansionGap) - locationX;
                    g.FillRectangle(fillBrush, InchesToPixelsRect(locationX, startLocationY, currentBoardLength, boardWidth));
                    g.DrawRectangle(pen, InchesToPixelsRect(locationX, startLocationY, currentBoardLength, boardWidth));
                    residualLength = boardLength - currentBoardLength - sawKerf;
                    done = true;
                }
                else
                {
                    g.FillRectangle(fillBrush, InchesToPixelsRect(locationX, startLocationY, currentBoardLength, boardWidth));
                    g.DrawRectangle(pen, InchesToPixelsRect(locationX, startLocationY, currentBoardLength, boardWidth));

                    locationX += currentBoardLength;
                    currentBoardLength = boardLength;
                }
            }

            return residualLength;
        }*/

        private (float xPixels, float yPixels) InchesToPixels2D(float xInches, float yInches)
        {
            float xPixels = xInches / roomWidth * screenWidth;
            float yPixels = yInches / roomLength * screenHeight;
            return (xPixels, yPixels);
        }

        private Rectangle InchesToPixelsRect(float x, float y, float width, float height)
        {
            var originPixels = InchesToPixels2D(x, y);
            var whPixels = InchesToPixels2D(width, height);
            return new Rectangle(
                (int)Math.Round(originPixels.xPixels, 0),
                (int)Math.Round(originPixels.yPixels, 0),
                (int)Math.Round(whPixels.xPixels, 0),
                (int)Math.Round(whPixels.yPixels, 0));
        }

        private void BoardLayoutControl_Resize(object sender, EventArgs e)
        {
            screenWidth = this.Width;
            screenHeight = this.Height;
            this.Refresh();
        }

        private void BoardLayoutControl_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            flooringRectangles.Clear();

            var startingBoardLength = boardLength * lengthFraction1;
            for (float yPos = expansionGap; yPos <= (roomLength - expansionGap); yPos += boardWidth * 3)
            {
                startingBoardLength = CalcRow(out List<FlooringRectangle> row, yPos, startingBoardLength, Color.Black, Color.Orange);
                flooringRectangles.Add(row);
            }

            startingBoardLength = boardLength * lengthFraction2;
            for (float yPos = expansionGap + boardWidth; yPos <= (roomLength - expansionGap); yPos += boardWidth * 3)
            {
                startingBoardLength = CalcRow(out List<FlooringRectangle> row, yPos, startingBoardLength, Color.Black, Color.Teal);
                flooringRectangles.Add(row);
            }

            startingBoardLength = boardLength * lengthFraction3;
            for (float yPos = expansionGap + boardWidth * 2; yPos <= (roomLength - expansionGap); yPos += boardWidth * 3)
            {
                startingBoardLength = CalcRow(out List<FlooringRectangle> row, yPos, startingBoardLength, Color.Black, Color.LightBlue);
                flooringRectangles.Add(row);
            }

            //overly-complicated way of checking if board ends are too close to other board ends on adjacent rows
            /*
            for (int rowIndex = 0; rowIndex < flooringRectangles.Count(); rowIndex++)
            {
                var row = flooringRectangles[rowIndex];
                List<FlooringRectangle> prevRow = (rowIndex > 0) ? flooringRectangles[rowIndex - 1] : null;
                List<FlooringRectangle> nextRow = (rowIndex < (flooringRectangles.Count() - 1))? flooringRectangles[rowIndex + 1] : null;

                for (int colIndex = 0; colIndex < row.Count(); colIndex++)
                {
                    var rect = row[colIndex];

                    if (prevRow != null)
                        foreach (var compareRect in prevRow)
                        {
                            if (Math.Abs(rect.X - (0 + expansionGap)) > 1)
                            {
                                if ((Math.Abs(rect.X - compareRect.X) < endJointStaggerMinSeparation) || (Math.Abs(rect.X - (compareRect.X + compareRect.Width)) < endJointStaggerMinSeparation))
                                {
                                    rect.LineColor = Color.Red;
                                    compareRect.LineColor = Color.Red;
                                }
                            }

                            if (Math.Abs((rect.X + rect.Width) - (roomWidth - expansionGap)) > 1)
                            {
                                if ((Math.Abs((rect.X + rect.Width) - compareRect.X) < endJointStaggerMinSeparation) || (Math.Abs((rect.X + rect.Width) - (compareRect.X + compareRect.Width)) < endJointStaggerMinSeparation))
                                {
                                    rect.LineColor = Color.Red;
                                    compareRect.LineColor = Color.Red;
                                }
                            }
                        }

                    if (nextRow != null)
                        foreach (var compareRect in nextRow)
                        {
                            if (Math.Abs(rect.X - (0 + expansionGap)) > 1)
                            {
                                if ((Math.Abs(rect.X - compareRect.X) < endJointStaggerMinSeparation) || (Math.Abs(rect.X - (compareRect.X + compareRect.Width)) < endJointStaggerMinSeparation))
                                {
                                    rect.LineColor = Color.Red;
                                    compareRect.LineColor = Color.Red;
                                }
                            }

                            if (Math.Abs((rect.X + rect.Width) - (roomWidth - expansionGap)) > 1)
                            {
                                if ((Math.Abs((rect.X + rect.Width) - compareRect.X) < endJointStaggerMinSeparation) || (Math.Abs((rect.X + rect.Width) - (compareRect.X + compareRect.Width)) < endJointStaggerMinSeparation))
                                {
                                    rect.LineColor = Color.Red;
                                    compareRect.LineColor = Color.Red;
                                }
                            }
                        }
                }
            }*/

            foreach (var row in flooringRectangles)
            {
                foreach (var rect in row)
                {
                    Pen pen = new Pen(rect.LineColor, 2);
                    Brush fillBrush = new SolidBrush(rect.FillColor);

                    g.FillRectangle(fillBrush, InchesToPixelsRect(rect.X, rect.Y, rect.Width, rect.Height));
                    g.DrawRectangle(pen, InchesToPixelsRect(rect.X, rect.Y, rect.Width, rect.Height));
                }
            }

            //ControlPaint.DrawBorder(g, this.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }
    }
}
