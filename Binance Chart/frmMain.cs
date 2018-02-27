using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json.Linq;

namespace Binance_Chart
{
    public partial class frmMain : Form
    {
        private const string SERIES_VOLUME = "Volume";
        private const string SERIES_PRICE = "Close Price";
        private const int MAXZOOM = 100;
        private const double ZOOMFACTOR = 1.1;

        private List<String> lstBTCMarket = new List<String>();
        private List<String> lstETHMarket = new List<String>();
        private List<String> lstBNBMarket = new List<String>();
        private List<String> lstUSDTMarket = new List<String>();
        private List<CurrencyForChart> lstChartData = new List<CurrencyForChart>();
        private ReadAPI api = new ReadAPI();
        private DatabaseAccess db = new DatabaseAccess(DatabaseAccess.onlineServer);
        private double chartX_Size = 0;
        private double chartY_Size = 0;
        private int zoomRate = 0;
        private double delta_X, delta_Y, pos_X, pos_Y, pos_X0, pos_Y0;
        private bool ismove = false;

        public frmMain()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(0, 0);
            btnClose.Location = new Point(this.Size.Width - btnClose.Size.Width - 5, 3);
            btnMinimumSize.Location = new Point(btnClose.Location.X - btnClose.Size.Width -  6, 0);

            getAllListCoin();

            setInitChart();

        }

        private void getAllListCoin()
        {
            String json24h = api.getExchangeData24h();
            JArray json24hData = JArray.Parse(json24h);

            foreach (JObject jo in json24hData.Children<JObject>())
            {
                string symbol = jo.Property("symbol").Value.ToString();

                if (symbol.Substring((symbol.Length - 4)) == "USDT")
                    lstUSDTMarket.Add(symbol);
                else
                {
                    switch (symbol.Substring((symbol.Length - 3)))
                    {
                        case "BTC":
                            lstBTCMarket.Add(symbol);
                            break;
                        case "ETH":
                            lstETHMarket.Add(symbol);
                            break;
                        case "BNB":
                            lstBNBMarket.Add(symbol);
                            break;
                    }
                }
                
            }
        }

        private void setInitChart()
        {
            chartMain.Series[SERIES_VOLUME].XValueType = ChartValueType.DateTime;
            chartMain.Series[SERIES_VOLUME].YValueType = ChartValueType.Double;
            chartMain.Series[SERIES_PRICE].XValueType = ChartValueType.DateTime;
            chartMain.Series[SERIES_PRICE].YValueType = ChartValueType.Double;

            chartMain.Series[SERIES_VOLUME].ToolTip = "Time: #VALX{yy/MM/dd HH:mm}" + "\n" + "Volume: #VALY{0.00000000}";
            chartMain.Series[SERIES_PRICE].ToolTip = "Time:  #VALX{yy/MM/dd HH:mm}" + "\n" + "Close Price: #VALY{0.00000000}";

            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBTC_Click(object sender, EventArgs e)
        {
            addCoinToListView(lstBTCMarket);
        }

        private void btnETH_Click(object sender, EventArgs e)
        {
            addCoinToListView(lstETHMarket);
        }

        private void btnBNB_Click(object sender, EventArgs e)
        {
            addCoinToListView(lstBNBMarket);
        }

        private void btnUSDT_Click(object sender, EventArgs e)
        {
            addCoinToListView(lstUSDTMarket);
        }

    

        private void addCoinToListView(List<string> lstCoin)
        {
            lbCoin.DataSource = null;
            lbCoin.Items.Clear();
            if (lstCoin.Count > 0)
            {
                lbCoin.DataSource = lstCoin;
            }
        }

        private void lbCoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCoin.DataSource != null)
            {
                string symbol = lbCoin.SelectedItem.ToString();
                if (symbol.Substring((symbol.Length - 4)) == "USDT")
                    lstChartData = db.getCoinsBySymbol(symbol, DatabaseAccess.USDTABLE);
                else
                {
                    switch (symbol.Substring((symbol.Length - 3)))
                    {
                        case "BTC":
                            lstChartData = db.getCoinsBySymbol(symbol, DatabaseAccess.BTCTABLE);
                            break;
                        case "ETH":
                            lstChartData = db.getCoinsBySymbol(symbol, DatabaseAccess.ETHTABLE);
                            break;
                        case "BNB":
                            lstChartData = db.getCoinsBySymbol(symbol, DatabaseAccess.BNBTABLE);
                            break;
                    }
                }

                lblCoin.Text = symbol;
                //Vẽ chart
                drawChart(lstChartData);
            }
            
        }

        private void drawChart(List<CurrencyForChart> lstCoin)
        {

            

            chartMain.Series[SERIES_VOLUME].Points.Clear();
            chartMain.Series[SERIES_PRICE].Points.Clear();
            foreach (CurrencyForChart coin in lstCoin)
            {
                chartMain.Series[SERIES_VOLUME].Points.AddXY(coin.openTime.ToOADate(), coin.volume);
                chartMain.Series[SERIES_PRICE].Points.AddXY(coin.openTime.ToOADate(), coin.closePrice);
            }


            chartMain.ChartAreas[0].AxisX.Maximum = lstCoin.Last().openTime.ToOADate();
            chartMain.ChartAreas[0].AxisX.Minimum = lstCoin.First().openTime.ToOADate();
            //chartMain.ChartAreas[0].AxisX.Interval = 1;
            //chartMain.ChartAreas[0].CursorX.IsUserEnabled = true;
            //chartMain.ChartAreas[0].AxisY.Maximum = lstCoin.Max()
            chartX_Size = chartMain.ChartAreas[0].AxisX.Maximum - chartMain.ChartAreas[0].AxisX.Minimum;
            chartY_Size = chartMain.ChartAreas[0].AxisY.Maximum;

            //chartMain.ChartAreas[0].AxisX.ScaleView.Size = chartX_Size;
            chartMain.ChartAreas[0].AxisX.ScaleView.Size = chartX_Size * 24 / lstCoin.Count;
            
        }

        private void chartMain_MouseWheel(object sender, MouseEventArgs e)
        {
            
            if(e.Delta < 1)
            {
                if (zoomRate > 0)
                    zoomRate -= 1;
            }
            else if(e.Delta >1)
            {
                if (zoomRate < MAXZOOM)
                    zoomRate += 1;
            }

            if (zoomRate == 0)
            {
                chartMain.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                chartMain.ChartAreas[0].AxisY.ScaleView.ZoomReset();
            }
            else
            {
                chartMain.ChartAreas[0].AxisX.ScaleView.Size = chartX_Size / (zoomRate * ZOOMFACTOR);
                //chartMain.ChartAreas[0].AxisY.ScaleView.Size = chartY_Size / (zoomRate * ZOOMFACTOR);
            }
        }


        private void chartMain_MouseDown(object sender, MouseEventArgs e)
        {
            // Call Hit Test Method
            HitTestResult result = chartMain.HitTest(e.X, e.Y);
            if (result.ChartElementType == ChartElementType.ScrollBarThumbTracker ||
                result.ChartElementType == ChartElementType.ScrollBarLargeDecrement ||
                result.ChartElementType == ChartElementType.ScrollBarSmallDecrement ||
                result.ChartElementType == ChartElementType.ScrollBarSmallIncrement ||
                result.ChartElementType == ChartElementType.ScrollBarZoomReset 
                ) return;

            if (e.Button == MouseButtons.Left)
            {
                ismove = true;
                pos_X0 = e.X;  //Xác định vị trí của trỏ chuột ban đầu trục x
                pos_Y0 = e.Y;  //Xác định vị trí trỏ chuột bann đâu trục y

                if(chartMain.ChartAreas[0].AxisX.ScaleView.IsZoomed == true)
                {
                    //Lấy khoảng mà đồ thị hiển thị từ viewminumum đến viewmaximum trục X
                    delta_X = chartMain.ChartAreas[0].AxisX.ScaleView.ViewMaximum - chartMain.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    // get vị trí bắt đầu hiện thị X tại viewminimum trục X
                    pos_X = chartMain.ChartAreas[0].AxisX.ScaleView.Position;
                }
            }
        }

        private void chartMain_MouseUp(object sender, MouseEventArgs e)
        {
            ismove = false;
            chartMain.Cursor = Cursors.Default;
        }

        private void chartMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismove)
            {
                //chartMain.ChartAreas[0].AxisX.Interval = 1;
                chartMain.Cursor = Cursors.SizeAll;
                if (chartMain.ChartAreas[0].AxisX.ScaleView.IsZoomed == true && chartMain.ChartAreas[0].AxisX.ScaleView.Position >= 0)
                {
                    chartMain.ChartAreas[0].AxisX.ScaleView.Position = pos_X - (e.X - pos_X0) / chartMain.ChartAreas[0].AxisX.ScaleView.Size;

                    if (chartMain.ChartAreas[0].AxisX.ScaleView.Position <= (chartMain.ChartAreas[0].AxisX.Minimum + delta_X))
                    {
                        chartMain.ChartAreas[0].AxisX.ScaleView.Position = (chartMain.ChartAreas[0].AxisX.Minimum);
                    } 

                    if(chartMain.ChartAreas[0].AxisX.ScaleView.Position >= (chartMain.ChartAreas[0].AxisX.Maximum - delta_X))
                    {
                        chartMain.ChartAreas[0].AxisX.ScaleView.Position = (chartMain.ChartAreas[0].AxisX.Maximum - delta_X);
                    }

                    chartMain.ChartAreas[0].AxisX.ScaleView.Size = delta_X;
                }
            }
        }
    }
}
