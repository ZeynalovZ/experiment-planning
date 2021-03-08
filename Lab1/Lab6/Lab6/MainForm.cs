using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ZedGraph;

namespace Lab6
{
    public partial class MainForm : Form
    {
        private ZedGraphControl zedGraph1;
        private readonly int xPlotSize = 700;
        private readonly int yPlotSize = 350;

        public MainForm()
        {
            InitializeComponent();

            zedGraph1 = new ZedGraphControl();
            zedGraph1.Location = new Point(200, 15);
            zedGraph1.Size = new Size(xPlotSize, yPlotSize);

            tbTimeInterval.Text = Constants.TimeInterval.ToString(CultureInfo.InvariantCulture);
            tbGenCount.Text = "1";
            tbGenIntensity.Text = "3";
            //tbMaxArrivalInt.Text = Constants.MaxClientArrivalTime.ToString(CultureInfo.InvariantCulture);
            tbOAIntensity.Text = "5";
            //tbMaxStyleTime.Text = Constants.MaxStyleTime.ToString(CultureInfo.InvariantCulture);
            //tbMinDelay.Text = Constants.MinStylistDelay.ToString(CultureInfo.InvariantCulture);
            //tbMaxDelay.Text = Constants.MaxStylistDelay.ToString(CultureInfo.InvariantCulture);
            tbTime.Text = Constants.SimulationTime.ToString(CultureInfo.InvariantCulture);
            //tbClientHasStylistProb.Text = Constants.ClientHasStylistProbability.ToString(CultureInfo.InvariantCulture);
            lblResult.Text = String.Empty;
            tbdispersion.Text = "1";

            this.Controls.Add(zedGraph1);

        }

        private double f(double x)
        {
            return Math.Sin(x);
        }

        private void drawGraph(ZedGraphControl zedGraph, PointPairList list, string xTitle, string yTitle, string tableName)
        {
            GraphPane pane = zedGraph.GraphPane;
            pane.CurveList.Clear();

            pane.XAxis.Title.Text = xTitle;
            pane.YAxis.Title.Text = yTitle;
            pane.Title.Text = tableName;

            LineItem Curve = pane.AddCurve("func", list, Color.Red, SymbolType.None);
            Curve.Line.IsSmooth = true;
            zedGraph.Refresh();
            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            try
            {
                var model = new Model();
                model.TimeInterval = double.Parse(tbTimeInterval.Text.Replace('.', ','));
                model.QueueLengthLimit = Constants.QueueLengthLimit;
                model.ClientHasStylistProbability = 0;
                model.MinClientArrivalTime = 0;
                model.MaxClientArrivalTime = 1;
                model.MinStyleTime = 0;
                model.MaxStyleTime = 1;
                model.MinStylistDelay = 0;
                model.MaxStylistDelay = 1;

                var modelingTime = int.Parse(tbTime.Text);
                var GenIntensity = double.Parse(tbGenIntensity.Text);
                var OperatorIntensity = double.Parse(tbOAIntensity.Text);
                var GenCount = int.Parse(tbGenCount.Text);
                var OperatorsCount = int.Parse(tbOACount.Text);
                var dispersion = double.Parse(tbdispersion.Text);

                int numStyles = int.Parse("1");
                int numStylists = int.Parse(tbOACount.Text);
                double simTime = double.Parse(tbTime.Text.Replace('.', ','));

                var intensityStep = OperatorIntensity / 10;

                string xTitle = "Нагрузка";
                string yTitle = "t обр";
                string tableName = "График";
                PointPairList pointPairs = new PointPairList();

                for (double inten = 1; inten < 100; inten += 1)
                {
                    model.Initialize(modelingTime, OperatorsCount, GenCount, OperatorIntensity, dispersion, inten);

                    var time = model.Simulate(simTime);
                    pointPairs.Add(new PointPair(inten / 100, time));
                }

                

                double p = (double)model.ClientsDeclined /
                    (model.ClientsServed + model.ClientsDeclined);



                drawGraph(zedGraph1, pointPairs, xTitle, yTitle, tableName);


                lblResult.Text = "Прибыло клиентов: " + model.ClientsArrived +
                                 Environment.NewLine + "Обслужено клиентов: " + model.ClientsServed +
                                 Environment.NewLine + "Отказов в обслуживании: " + model.ClientsDeclined +
                                 Environment.NewLine + "Вероятность отказа: " + p +
                                 Environment.NewLine + "Загрузка теоретическая: " + GenIntensity/OperatorIntensity;
                                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, String.Empty,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
