using Blood_bank_system.Models;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;

namespace Blood_bank_system
{
    public partial class stats : UserControl
    {
        private Statistics model;
        private System.Windows.Forms.ToolTip tooltip;
        public stats()
        {
            InitializeComponent();
            tooltip = new System.Windows.Forms.ToolTip();

            model = new Statistics();

            labelKey.Visible = false;

            LoadData("CurrentMonth");
        }

        public void LoadData(string filterType)
        {
            model.LoadData(filterType);
            
            CandidatsLabel.Text = model.NumberCandidats.ToString();
            ActivedonorsLabel.Text = model.NumberActiveDonors.ToString();
            DesactiveDonors.Text = model.NumberDesactiveDonors.ToString();

            chart2.DataSource = model.CandidatsList;
            chart2.Series["s2"].XValueMember = "Date";
            chart2.Series["s2"].YValueMembers = "Total";
            chart2.ChartAreas[0].AxisX.Interval = 1;
            chart2.DataBind();

            if (filterType == "CurrentMonth" || filterType == "CurrentYear")
            {
                chart2.ChartAreas[0].AxisX.LabelStyle.Angle = 90;
            }
            else 
            {
                chart2.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            }

            chart1.DataSource = model.MagazinSangList;
            chart1.Series["s1"].XValueMember = "Key";
            chart1.Series["s1"].YValueMembers = "Value";
            chart1.DataBind();

            chart3.ChartAreas[0].AxisY.Enabled = AxisEnabled.False; 
            chart3.ChartAreas[0].AxisX.MajorGrid.Enabled = false;   
            chart3.Series["s1"].LabelForeColor = Color.White; 
            chart3.DataSource = model.DonorTypesList;
            chart3.Series["s1"].XValueMember = "Key";
            chart3.Series["s1"].YValueMembers = "Value";
            chart3.DataBind();

            Color[] classyReds = {
                                    Color.FromArgb(0, 114, 189),   
                                    Color.FromArgb(217, 83, 25),  
                                    Color.FromArgb(119, 172, 48), 
                                    Color.FromArgb(126, 47, 142) 
                                 };

            for (int i = 0; i < chart3.Series["s1"].Points.Count; i++)
            {
                chart3.Series["s1"].Points[i].Color = classyReds[i % classyReds.Length]; 
            }

            chart3.Series["s1"].IsValueShownAsLabel = true;


            Color[] matlabColors = {
                                        Color.FromArgb(0, 114, 189),    
                                        Color.FromArgb(217, 83, 25),   
                                        Color.FromArgb(237, 177, 32),   
                                        Color.FromArgb(126, 47, 142),  
                                        Color.FromArgb(119, 172, 48),  
                                        Color.FromArgb(77, 190, 238), 
                                        Color.FromArgb(162, 20, 47),   
                                        Color.FromArgb(163, 165, 165)  
                                    };


            for (int i = 0; i < chart1.Series["s1"].Points.Count; i++)
            {
                chart1.Series["s1"].Points[i].Color = matlabColors[i % matlabColors.Length];
            }

            chart1.Series["s1"].IsValueShownAsLabel = true;
            chart1.Series["s1"].LabelForeColor = Color.White; 

        }

        private void chart2_MouseMove(object sender, MouseEventArgs e)
        {
            HitTestResult result = chart2.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint && result.Series != null)
            {
                DataPoint point = result.Series.Points[result.PointIndex];
                double yValue = point.YValues[0];

                tooltip.Show($" Nbr : {yValue}", chart2, e.Y - 10);
            }
            else
            {
                tooltip.Hide(chart2);
            }
        }

        private int lastHoveredIndex = -1; 

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            HitTestResult result = chart1.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint && result.Series != null)
            {
                int currentIndex = result.PointIndex;

                if (currentIndex != lastHoveredIndex)
                {
                    if (lastHoveredIndex != -1)
                    {
                        chart1.Series["s1"].Points[lastHoveredIndex]["Exploded"] = "false";
                    }

                    chart1.Series["s1"].Points[currentIndex]["Exploded"] = "true";

                    string key = chart1.Series["s1"].Points[currentIndex].AxisLabel.Trim();
                    double value = chart1.Series["s1"].Points[currentIndex].YValues[0];

                    labelKey.Text = key + ", " + value.ToString();

                    labelKey.Visible = true;

                    int centerX = chart1.Left + chart1.Width / 2;

                    labelKey.Location = new Point(centerX - (labelKey.Width / 2), labelKey.Location.Y);

                    lastHoveredIndex = currentIndex;
                }
            }
            else
            {
                if (lastHoveredIndex != -1)
                {
                    chart1.Series["s1"].Points[lastHoveredIndex]["Exploded"] = "false";
                    lastHoveredIndex = -1;

                    labelKey.Visible = false;
                }
            }
        }

        private void chart3_MouseMove(object sender, MouseEventArgs e)
        {
            HitTestResult result = chart3.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint && result.Series != null)
            {
                DataPoint point = result.Series.Points[result.PointIndex];
                double yValue = point.YValues[0];

                tooltip.Show($"nbr : {yValue}", chart3, e.Y - 10);
            }
            else
            {
                tooltip.Hide(chart3);
            }
        }
    }
}
