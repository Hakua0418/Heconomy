using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Heconomy
{

    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Console.Read();

        }

        public static void FirstEasySql()
        {
            try
            {
                string connStr = "server=hakuaserver.ddns.net:41184;user id=root;password=Ikawa$$0418;database=Cdata";

                MySqlConnection conn = new MySqlConnection(connStr);

                Form2 form2 = new Form2();
                string company = form2.Cname;
                string president = form2.mcid;
                int money = form2.money;
                string category1 = form2.BigC;
                string category2 = form2.MidC;



                string SqlWord = "INSERT INTO EasyDB Orders (name,mcid,money,bigname,midname) Values (company, president, money, category1, category2)";
                using (MySqlCommand cmd = new MySqlCommand(SqlWord))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }


            }
            catch (MySqlException mse)
            {
                Console.WriteLine(mse.Message);
            }
        }
    }
}
