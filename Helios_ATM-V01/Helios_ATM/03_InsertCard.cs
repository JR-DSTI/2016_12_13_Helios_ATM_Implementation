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

        }

        private void CardInserted_Click(object sender, EventArgs e)
        {
            //again "sleep" for the form
            
            //getBalance();
            //await Task.Delay(500);

            //continue to next form:
            Form ATM4 = new ATM4(); // Instantiate a Form object.
            ATM4.Show(); //show the new Form


            this.Visible = false;  //Hide the old form
        }



        public void getBalance(String tablename = "ATM", String myAccountId = "0001")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            MetroFramework.MetroMessageBox.Show(this,"\n*** Executing RetrieveAccount() ***");

            // We define the Attributes to fetch (here Balance)
            GetItemOperationConfig config = new GetItemOperationConfig
            {
                AttributesToGet = new List<string> { "Balance" },
                ConsistentRead = true
            };

            //from the table, get the item described in the config
            Document document = LoadProduct.GetItem(myAccountId, config);
            //Checker(document);

        }





        private void CancelButton_Click(object sender, EventArgs e)
        {
            //cancel to initial form, maybe not too necessary here
            Form ATM1 = new ATM1(); // Instantiate a Form object.
            ATM1.Show(); //show the new Form

            this.Visible = false;  //Hide the old form
        }

        
    }
}
