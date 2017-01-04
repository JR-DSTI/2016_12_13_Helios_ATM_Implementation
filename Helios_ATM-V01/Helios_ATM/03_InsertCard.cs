using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

using Amazon;
using Amazon.Runtime;

using Amazon.S3;
using Amazon.S3.Transfer;
using Amazon.S3.Model;

//using Amazon.SimpleNotificationService;
//using Amazon.SimpleNotificationService.Model;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using System.Windows.Forms;
//using Amazon.SimpleEmail;

namespace Helios_ATM
{
    public partial class ATM3 : MetroFramework.Forms.MetroForm
    {
        public ATM3()
        {
            InitializeComponent();
        }


        private void ATM3_Load(object sender, EventArgs e)
        {
            //setting the current Batterycharge and Network signal:
            this.BatteryCharge.Value = battery.charge;
            this.BatteryNetworkTimer.Start();
        }



        private void CardInserted_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();

            //Log current operation:
            s3log.logOperation(sender);
            
            //MessageBox.Show(s);

            //continue to next form:            
            //Starting next form and close/hide this one
            Form ATM4 = new ATM4(); // Instantiate a Form object.
            ATM4.Show(); //show the new Form
            this.Visible = false;  //Hide the old form
            this.BatteryNetworkTimer.Stop();

        }



        //public void getBalance(String tablename = "ATM", String myAccountId = "0001")
        //{
        //    //Creation of a new Client
        //    AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

        //    //Load into a table called ATM thx to a DB client
        //    Table LoadProduct = Table.LoadTable(dbc, tablename);
        //    MetroFramework.MetroMessageBox.Show(this,"\n*** Executing RetrieveAccount() ***");

        //    // We define the Attributes to fetch (here Balance)
        //    GetItemOperationConfig config = new GetItemOperationConfig
        //    {
        //        AttributesToGet = new List<string> { "Balance" },
        //        ConsistentRead = true
        //    };

        //    //from the table, get the item described in the config
        //    Document document = LoadProduct.GetItem(myAccountId, config);
        //    //Checker(document);

        //}
        
        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Starting next form and close/hide this one
            Form ATM1 = new ATM1(); // Instantiate a Form object.
            ATM1.Show(); //show the new Form
            this.Visible = false;  //Hide the old form

            //Log current operation:
            //this.log(false);
            s3log.logOperation(sender);

        }

        private void BatteryCharge_Click(object sender, EventArgs e)
        {

        }
        //public void discharge()
        //{
        //    if (BatteryCharge.Value > 1)
        //    {
        //        BatteryCharge.Value -= battery.decrement;
        //        battery.charge = BatteryCharge.Value;
        //    }
        //    else
        //    {
        //        Environment.Exit(0);
        //    }
        //}
        private void timer1_Tick(object sender, EventArgs e)
        {
            //discharge();
        }


        private void log(Boolean flag)
        {
            if (flag)
            {
                string path = @"Y:\Documents\GitHub\2016_12_13_Helios_ATM_Implementation\Project_Supplementary\2016_12_28_AWS_Log.txt";
                string appendText = "Card Inserted" + " " + (DateTime.Now).ToString() +Environment.NewLine;
                File.AppendAllText(path, appendText);
            }
            else
            {
               
                string path = @"Y:\Documents\GitHub\2016_12_13_Helios_ATM_Implementation\Project_Supplementary\2016_12_28_AWS_Log.txt";
                string appendText = "Card Not Inserted" + " " + (DateTime.Today).ToString() + Environment.NewLine;
                string appendText2 = "Battery life: " + battery.charge + "% " + (DateTime.Now).ToString() + Environment.NewLine;

                File.AppendAllText(path, appendText);
                File.AppendAllText(path, appendText2);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Variables.strLog = Variables.strLog + "\n" + "Battery life: " + battery.charge + "% " + (DateTime.Now).ToString();
            //Variables.strLog = Variables.strLog + "\n" + "visit to Main Menu: " + (battery.form1visit).ToString() + " " + (DateTime.Now).ToString();
            //MetroFramework.MetroMessageBox.Show(this, Variables.strLog);

        }

        private void BatteryNetworkTimer_Tick(object sender, EventArgs e)
        {
            //getting the current Batterycharge & discharge and adjust network signal:
            battery.discharge(this.BatteryCharge);
            networkConnection.networkConnectionOK(this.NetworkSignal);
        }
    }
}
