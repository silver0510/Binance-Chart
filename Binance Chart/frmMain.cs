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

        private List<String> lstBTCMarket = new List<String>();
        private List<String> lstETHMarket = new List<String>();
        private List<String> lstBNBMarket = new List<String>();
        private List<String> lstUSDTMarket = new List<String>();
        private ReadAPI api = new ReadAPI();

        public frmMain()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(0, 0);
            btnClose.Location = new Point(this.Size.Width - btnClose.Size.Width - 5, 3);
            btnMinimumSize.Location = new Point(btnClose.Location.X - btnClose.Size.Width -  6, 3);

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

            chartMain.Series[SERIES_VOLUME].ToolTip = "X = #VALX{yy/MM/dd HH:mm}" + "\n" + "Y= #VALY";
            chartMain.Series[SERIES_PRICE].ToolTip = "X = #VALX" + "\n" + "Y= #VALY";

            DateTime now = DateTime.Now;
            DateTime x = new DateTime(now.Year, now.Month, now.Day, now.Hour,now.Minute,now.Second);
            DateTime x1 = new DateTime(now.Year, now.Month, now.Day, now.Hour+1, now.Minute, now.Second);
            DateTime x2 = new DateTime(now.Year, now.Month, now.Day, now.Hour+2, now.Minute, now.Second);
            DateTime x3 = new DateTime(now.Year, now.Month, now.Day, now.Hour+3, now.Minute, now.Second);
            DateTime x4 = new DateTime(now.Year, now.Month, now.Day, now.Hour+4, now.Minute, now.Second);

            chartMain.Series[SERIES_VOLUME].Points.AddXY(x.ToOADate(), 9);
            chartMain.Series[SERIES_VOLUME].Points.AddXY(x1.ToOADate(), 5);
            chartMain.Series[SERIES_VOLUME].Points.AddXY(x2.ToOADate(), 15);
            chartMain.Series[SERIES_VOLUME].Points.AddXY(x3.ToOADate(), 10);
            chartMain.Series[SERIES_VOLUME].Points.AddXY(x4.ToOADate(), 25);
            


            chartMain.Series[SERIES_PRICE].Points.AddXY(x.ToOADate(), 5);
            chartMain.Series[SERIES_PRICE].Points.AddXY(x1.ToOADate(), 0.15);
            chartMain.Series[SERIES_PRICE].Points.AddXY(x2.ToOADate(), 1);
            chartMain.Series[SERIES_PRICE].Points.AddXY(x3.ToOADate(), 0.5);
            chartMain.Series[SERIES_PRICE].Points.AddXY(x4.ToOADate(), 0.35);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBTC_Click(object sender, EventArgs e)
        {
            addCoinToListView(lstBTCMarket);
            
        }

        private void addCoinToListView(List<string> lstCoin)
        {
            lvCoin.Items.Clear();
            foreach (string coin in lstCoin)
            {
                lvCoin.Items.Add(coin);
            }
        }
    }
}
