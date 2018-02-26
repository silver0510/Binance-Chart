﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Binance_Chart
{
    public class DatabaseAccess
    {
        public static string SERVER = "localhost";
        public static string DATABASE = "binance_data";
        public static string BTCTABLE = "btcmarket";
        public static string ETHTABLE = "ethmarket";
        public static string BNBTABLE = "bnbmarket";

        string connetionString = "server=" + SERVER + ";database="+ DATABASE + ";uid=root;pwd=;";
        MySqlConnection con = null;
        

        public void DBConnect()
        {
            try
            {
                if (con == null)
                    con = new MySqlConnection(connetionString);
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                //Console.WriteLine("Connected");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }   
        }

        public void DBClose()
        {
            try
            {
                if (con == null) return;
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void insertData(string tableName ,List<Currency> lst)
        {
            StringBuilder sCommand = new StringBuilder("INSERT INTO " + tableName +
             "(MARKET,OPENTIME,OPENPRICE,HIGHPRICE,LOWPRICE,CLOSEPRICE,VOLUME,CLOSETIME,QUOTE_ASSET_VOLUME,NUMBER_OF_TRADES,TAKER_BUY_BASE_ASSET_VOLUME,TAKER_BUY_QUOTE_ASSET_VOLUME,IGNORE_DATA,CHANGE24H) VALUES ");
            List<string> Rows = new List<string>();
            foreach (Currency coin in lst)
            {
                Rows.Add(string.Format("('{0}',{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13})", 
                                        coin.market,
                                        coin.openTime,
                                        coin.openPrice,
                                        coin.highPrice,
                                        coin.lowPrice,
                                        coin.closePrice,
                                        coin.volume,
                                        coin.closeTime,
                                        coin.quoteAssetVolume,
                                        coin.numberOfTrades,
                                        coin.takerBuyBaseAssetVolume,
                                        coin.takerBuyQuoteAssetVolume,
                                        coin.ignoreData,
                                        coin.change24H));
            }
            sCommand.Append(string.Join(",", Rows));
            sCommand.Append(";");
            DBConnect();
            using (MySqlCommand mySqlCmd = new MySqlCommand(sCommand.ToString(), con))
            {
                mySqlCmd.CommandType = System.Data.CommandType.Text;
                mySqlCmd.ExecuteNonQuery();
            }
            DBClose();

        }

        //kiểm tra đây có phải lần đầu tiên chạy chương trình không
        //nếu đúng thì trả về true
        public bool checkNewDBOrNot()
        {
            DBConnect();
            MySqlCommand mySqlCmd = new MySqlCommand();
            mySqlCmd.Connection = con;
            mySqlCmd.CommandType = System.Data.CommandType.Text;
            string cmd = "SELECT COUNT(*) FROM btcmarket";
            mySqlCmd.CommandText = cmd;
            var obj = mySqlCmd.ExecuteScalar();
            int rowcount = Convert.ToInt32(obj);

            if (rowcount == 0) return true;
            return false;
        }
    }
}
