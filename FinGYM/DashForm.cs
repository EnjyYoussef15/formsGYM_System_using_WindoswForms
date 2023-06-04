using FinGYM.BuisnessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinGYM.DashForm;

namespace FinGYM
{
    public partial class DashForm : Form
    {
        Datacontext datacontext = new Datacontext();
       

        public DashForm()
        {
            InitializeComponent();
        }
        int inc;
        int dec;
        private void LoadData()
        {

            {
               if ( stratDat.Value == null && endDat.Value == null)
                {

                }
                else
                {
                    inc = int.Parse(label14.Text);
                    dec = int.Parse(label16.Text);
                    inc+=70;
                    dec-=50;
                    label14.Text= inc.ToString();
                    label16.Text= dec.ToString();

                    inc = int.Parse(label12.Text);
                    dec = int.Parse(label10.Text);
                    inc += 50;
                    dec -= 30;
                    label12.Text = inc.ToString();
                    label10.Text = dec.ToString();

                    inc = int.Parse(label8.Text);
                    dec = int.Parse(label6.Text);
                    inc += 30;
                    dec -= 10;
                    label8.Text = inc.ToString();
                    label6.Text = dec.ToString();

                    inc = int.Parse(label5.Text);
                    dec = int.Parse(label3.Text);
                    inc += 15;
                    dec -= 10;
                    label5.Text = inc.ToString();
                    label3.Text = dec.ToString();


                    DataTable dt = new DataTable();
                    dt.Columns.Add("equp", typeof(string));
                    dt.Columns.Add("Sales", typeof(int));

                    // Add some sample data to the data table
                    dt.Rows.Add("Turola", 100);
                    dt.Rows.Add("Walking", 150);
                    dt.Rows.Add("Royal", 200);
                    dt.Rows.Add("Threat", 100);
                    dt.Rows.Add("gomba", 150);
                    dt.Rows.Add("hala", 200);

                    // Bind the data table to the chart control
                    chart1.DataSource = dt;
                    chart1.Series[0].XValueMember = "equp";
                    chart1.Series[0].YValueMembers = "Sales";

                    // Refresh the chart control to display the data
                    chart1.DataBind();



                    List<SalesData> salesList = new List<SalesData>();
                    salesList.Add(new SalesData { Year = 2019, Sales = 100 });
                    salesList.Add(new SalesData { Year = 2020, Sales = 50 });
                    salesList.Add(new SalesData { Year = 2021, Sales = 250 });
                    salesList.Add(new SalesData { Year = 2022, Sales = 150 });
                   

                    // Bind the list to the chart control
                    chart2.DataSource = salesList;
                    chart2.Series[0].XValueMember = "Year";
                    chart2.Series[0].YValueMembers = "Sales";

                    // Refresh the chart control to display the data
                    chart2.DataBind();
                    ///////////////////////////////////////////////////////
                    DataTable dt2 = new DataTable();
                    dt2.Columns.Add("Year", typeof(string));
                    dt2.Columns.Add("Sales", typeof(int));

                    // Add some sample data to the data table
                    dt2.Rows.Add("Karateh", 250);
                    dt2.Rows.Add("trulo", 30);
                    dt2.Rows.Add("Gombaz", 100);
                    dt2.Rows.Add("Yoga", 50);
                    dt2.Rows.Add("KickBox", 200);

                    // Bind the data table to the chart control
                    chart3.DataSource = dt2;
                    chart3.Series[0].XValueMember = "Year";
                    chart3.Series[0].YValueMembers = "Sales";

                    // Refresh the chart control to display the data
                    chart3.DataBind();

                }

            }
        }

        private void Today_Click(object sender, EventArgs e)
        {

            LoadData();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public class SalesData
        {
            public int Year { get; set; }
            public int Sales { get; set; }
        }

        private void DashForm_Load(object sender, EventArgs e)
        {
            grdeq.DataSource = datacontext.Equipments.ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("equp", typeof(string));
            dt.Columns.Add("Sales", typeof(int));

            // Add some sample data to the data table
            dt.Rows.Add("Turola", 300);
            dt.Rows.Add("Walking", 50);
            dt.Rows.Add("Royal", 100);
            dt.Rows.Add("Threat", 120);
            dt.Rows.Add("gomba", 150);
            dt.Rows.Add("hala", 250);

            // Bind the data table to the chart control
            chart1.DataSource = dt;
            chart1.Series[0].XValueMember = "equp";
            chart1.Series[0].YValueMembers = "Sales";

            // Refresh the chart control to display the data
            chart1.DataBind();


            List<SalesData> salesList = new List<SalesData>();
            salesList.Add(new SalesData { Year = 2018, Sales = 100 });
            salesList.Add(new SalesData { Year = 2019, Sales = 150 });
            salesList.Add(new SalesData { Year = 2020, Sales = 200 });
            salesList.Add(new SalesData { Year = 2021, Sales = 150 });

            // Bind the list to the chart control
            chart2.DataSource = salesList;
            chart2.Series[0].XValueMember = "Year";
            chart2.Series[0].YValueMembers = "Sales";

            // Refresh the chart control to display the data
            chart2.DataBind();
            ////////////////////////////////////////////////////////////////////

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Year", typeof(string));
            dt2.Columns.Add("Sales", typeof(int));

            // Add some sample data to the data table
            dt2.Rows.Add("Karateh", 150);
            dt2.Rows.Add("trulo", 50);
            dt2.Rows.Add("Gombaz", 200);
            dt2.Rows.Add("Yoga", 250);
            dt2.Rows.Add("KickBox", 100);

            // Bind the data table to the chart control
            chart3.DataSource = dt2;
            chart3.Series[0].XValueMember = "Year";
            chart3.Series[0].YValueMembers = "Sales";

            // Refresh the chart control to display the data
            chart3.DataBind();

        }

        private void last7Days_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("equp", typeof(string));
            dt.Columns.Add("Sales", typeof(int));

            // Add some sample data to the data table
            dt.Rows.Add("Turola", 200);
            dt.Rows.Add("Walking", 150);
            dt.Rows.Add("Royal", 100);
            dt.Rows.Add("Threat", 200);
            dt.Rows.Add("gomba",50);
            dt.Rows.Add("hala", 300);
            // Bind the data table to the chart control
            chart1.DataSource = dt;
            chart1.Series[0].XValueMember = "equp";
            chart1.Series[0].YValueMembers = "Sales";

            // Refresh the chart control to display the data
            chart1.DataBind();


            List<SalesData> salesList = new List<SalesData>();
            salesList.Add(new SalesData { Year = 2018, Sales = 200 });
            salesList.Add(new SalesData { Year = 2019, Sales = 50 });
            salesList.Add(new SalesData { Year = 2020, Sales = 100 });
            salesList.Add(new SalesData { Year = 2021, Sales = 350 });

            // Bind the list to the chart control
            chart2.DataSource = salesList;
            chart2.Series[0].XValueMember = "Year";
            chart2.Series[0].YValueMembers = "Sales";

            // Refresh the chart control to display the data
            chart2.DataBind();
            ////////////////////////////////////////////////////////////////////

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Year", typeof(string));
            dt2.Columns.Add("Sales", typeof(int));

            // Add some sample data to the data table
            dt2.Rows.Add("Karateh", 250);
            dt2.Rows.Add("trulo", 100);
            dt2.Rows.Add("Gombaz", 300);
            dt2.Rows.Add("Yoga", 50);
            dt2.Rows.Add("KickBox", 150);

            // Bind the data table to the chart control
            chart3.DataSource = dt2;
            chart3.Series[0].XValueMember = "Year";
            chart3.Series[0].YValueMembers = "Sales";

            // Refresh the chart control to display the data
            chart3.DataBind();
        }

        private void month_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("equp", typeof(string));
            dt.Columns.Add("Sales", typeof(int));

            // Add some sample data to the data table
            dt.Rows.Add("Turola", 100);
            dt.Rows.Add("Walking", 50);
            dt.Rows.Add("Royal", 300);
            dt.Rows.Add("Threat", 200);
            dt.Rows.Add("gomba", 50);
            dt.Rows.Add("hala", 100);

            // Bind the data table to the chart control
            chart1.DataSource = dt;
            chart1.Series[0].XValueMember = "equp";
            chart1.Series[0].YValueMembers = "Sales";

            // Refresh the chart control to display the data
            chart1.DataBind();


            List<SalesData> salesList = new List<SalesData>();
            salesList.Add(new SalesData { Year = 2018, Sales = 300 });
            salesList.Add(new SalesData { Year = 2019, Sales = 250 });
            salesList.Add(new SalesData { Year = 2020, Sales = 100 });
            salesList.Add(new SalesData { Year = 2021, Sales = 50 });
            salesList.Add(new SalesData { Year = 2020, Sales = 100 });

            // Bind the list to the chart control
            chart2.DataSource = salesList;
            chart2.Series[0].XValueMember = "Year";
            chart2.Series[0].YValueMembers = "Sales";

            // Refresh the chart control to display the data
            chart2.DataBind();
            ////////////////////////////////////////////////////////////////////

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Year", typeof(string));
            dt2.Columns.Add("Sales", typeof(int));

            // Add some sample data to the data table
            dt2.Rows.Add("Karateh", 30);
            dt2.Rows.Add("trulo", 150);
            dt2.Rows.Add("Gombaz", 100);
            dt2.Rows.Add("Yoga", 210);
            dt2.Rows.Add("KickBox", 50);

            // Bind the data table to the chart control
            chart3.DataSource = dt2;
            chart3.Series[0].XValueMember = "Year";
            chart3.Series[0].YValueMembers = "Sales";

            // Refresh the chart control to display the data
            chart3.DataBind();
        }
    }
}
