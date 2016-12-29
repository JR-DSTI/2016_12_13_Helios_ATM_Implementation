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
using System.Management;


using System.Threading;
using System.Net.NetworkInformation;
using System.Windows;








//using Amazon.SimpleEmail;

namespace Helios_ATM
{
    class Lib
    {

        // all the functions "get" retrieve a field of the table

        //get the Balance of a given account based on a table name and an account id
        public static String getBalance(String tablename = "ATM", String myAccountId = "0002")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            AutoClosingMessageBox.Show("\n*** Executing RetrieveAccount() ***", "Data retrieval", 1000, Parent: Form.ActiveForm);

            // We define the Attributes to fetch (here Balance)
            GetItemOperationConfig config = new GetItemOperationConfig
            {
                AttributesToGet = new List<string> { "Balance" },
                ConsistentRead = true
            };

            //from the table, get the item described in the config
            Document document = LoadProduct.GetItem(myAccountId, config);
            return strPrintDocument(document);

        }
            
        //get the Code of a given account based on a table name and an account id

        public static String getCode(String tablename = "ATM", String myAccountId = "0002")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            AutoClosingMessageBox.Show("\n*** Executing RetrieveAccount() ***", "Data retrieval", 1000, Parent: Form.ActiveForm);

            // We define the Attributes to fetch (here Balance)
            GetItemOperationConfig config = new GetItemOperationConfig
            {
                AttributesToGet = new List<string> { "Code" },
                ConsistentRead = true
            };

            //from the table, get the item described in the config & return print result of PrintDoc function
            Document document = LoadProduct.GetItem(myAccountId, config);
            return strPrintDocument(document);

        }
        
            
        //get the CheckingBalance of a given account based on a table name and an account id
        public static String getCheckingBalance(String tablename = "ATM", String myAccountId = "0002")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            AutoClosingMessageBox.Show("\n*** Executing RetrieveAccount() ***", "Data retrieval", 1000, Parent: Form.ActiveForm);

            // We define the Attributes to fetch (here Balance)
            GetItemOperationConfig config = new GetItemOperationConfig
            {
                AttributesToGet = new List<string> { "CheckingBalance" },
                ConsistentRead = true
            };

            //from the table, get the item described in the config
            Document document = LoadProduct.GetItem(myAccountId, config);
            return strPrintDocument(document);

        }
        

        //get the SavingsBalance of a given account based on a table name and an account id
        public static String getSavingsBalance(String tablename = "ATM", String myAccountId = "0002")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            AutoClosingMessageBox.Show("\n*** Executing RetrieveAccount() ***", "Data retrieval", 1000, Parent: Form.ActiveForm);


            // We define the Attributes to fetch (here Balance)
            GetItemOperationConfig config = new GetItemOperationConfig
            {
                AttributesToGet = new List<string> { "SavingsBalance" },
                ConsistentRead = true
            };

            //from the table, get the item described in the config
            Document document = LoadProduct.GetItem(myAccountId, config);
            return strPrintDocument(document);
        }


        //get the ID of a given account based on a table name and an account id

        public static String getID(String tablename = "ATM", String myAccountId = "0002")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            AutoClosingMessageBox.Show("\n*** Executing RetrieveAccount() ***", "Data retrieval", 1000, Parent: Form.ActiveForm);


            // We define the Attributes to fetch (here Balance)
            GetItemOperationConfig config = new GetItemOperationConfig
            {
                AttributesToGet = new List<string> { "ID" },
                ConsistentRead = true
            };

            //from the table, get the item described in the config
            Document document = LoadProduct.GetItem(myAccountId, config);
            return strPrintDocument(document);

        }


        //get the Blocked Status of a given account based on a table name and an account id
        public static Boolean getBlocked(String tablename = "ATM", String myAccountId = "0002")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            AutoClosingMessageBox.Show("\n*** Executing RetrieveAccount() ***", "Data retrieval", 1000, Parent: Form.ActiveForm);

            // We define the Attributes to fetch (here Balance)
            GetItemOperationConfig config = new GetItemOperationConfig
            {
                AttributesToGet = new List<string> { "Blocked" },
                ConsistentRead = true
            };

            //from the table, get the item described in the config
            Document document = LoadProduct.GetItem(myAccountId, config);
            return PrintDocument(document);

        }


        //get the Name of a given account based on a table name and an account id
        public static String getName(String tablename = "ATM", String myAccountId = "0002")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            AutoClosingMessageBox.Show("\n*** Finding your info ***", "Data check", 1000, Parent: Form.ActiveForm);

            // We define the Attributes to fetch (here Balance)
            GetItemOperationConfig config = new GetItemOperationConfig
            {
                AttributesToGet = new List<string> { "Name" },
                ConsistentRead = true
            };

            //from the table, get the item described in the config
            Document document = LoadProduct.GetItem(myAccountId, config);
            return strPrintDocument(document);

        }


        //get the Name of a given account based on a table name and an account id
        public static String getTrials(String tablename = "ATM", String myAccountId = "0002")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            AutoClosingMessageBox.Show("\n*** Finding your info ***", "Data check", 1000, Parent: Form.ActiveForm);

            // We define the Attributes to fetch (here Balance)
            GetItemOperationConfig config = new GetItemOperationConfig
            {
                AttributesToGet = new List<string> { "Trials" },
                ConsistentRead = true
            };

            //from the table, get the item described in the config
            Document document = LoadProduct.GetItem(myAccountId, config);
            return strPrintDocument(document);

        }

        //Retrieve the details of a given account based on a table name and an account id
        public static String RetrieveAccount(String tablename = "ATM", String myAccountId = "0002")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            AutoClosingMessageBox.Show("\n*** Retrieving Account Details ***", "Data retrieval", 1000, Parent: Form.ActiveForm);

            // We define the Attributes to fetch (here Balance)
            GetItemOperationConfig config = new GetItemOperationConfig
            {
                AttributesToGet = new List<string> { "ID", "Balance", "Blocked", "Name" },
                ConsistentRead = true
            };

            //from the table, get the item described in the config
            Document document = LoadProduct.GetItem(myAccountId, config);
            return strPrintDocument(document);

        }


        //get the Bank Name of a given account based on a table name and an account id
        public static String getBankName(String tablename = "ATM", String myAccountId = "0002")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            AutoClosingMessageBox.Show("\n*** Finding bank's name ***", "Data retrieval", 1000, Parent: Form.ActiveForm);

            // We define the Attributes to fetch (here Balance)
            GetItemOperationConfig config = new GetItemOperationConfig
            {
                AttributesToGet = new List<string> { "BankName" },
                ConsistentRead = true
            };

            //from the table, get the item described in the config
            Document document = LoadProduct.GetItem(myAccountId, config);
            return strPrintDocument(document);
            //Checker(document);

        }


        //function update
        //function itself
        public static void update(String Pinentry, Boolean blocked, Double Balance=0, String Code = "1111")
        {
            var client = new AmazonDynamoDBClient();
            var request = new PutItemRequest()
            {
                TableName = "ATM",
                ExpressionAttributeNames = new Dictionary<string, string>
                {{"#id","ID"}},

                ExpressionAttributeValues = new Dictionary<string, AttributeValue>
                {{ ":value", new AttributeValue{ S="0002"}}},

                ConditionExpression = "#id=:value",
                Item = CreateItemData(Pinentry,blocked, Balance,Code)

            };
            client.PutItem(request);
        }
        // helper function create items
        public static Dictionary<string, AttributeValue> CreateItemData(String Pinentry, Boolean blocked, Double Balance = 2000, String Code="1111")
        {
            var itemData = new Dictionary<string, AttributeValue>
            {{"ID", new AttributeValue{S="0002"} },
             {"Balance", new AttributeValue{N=Balance.ToString()}},
             {"BankName", new AttributeValue{S="Credit Agricole"}},
             {"Blocked", new AttributeValue{BOOL=blocked}},
             {"Name", new AttributeValue{S="Jonas Rathke"}},
              {"Trials", new AttributeValue{N=Pinentry}},
              {"Code", new AttributeValue{S=Code}},
              {"CheckingBalance", new AttributeValue{S="2000"}},
              {"SavingsBalance", new AttributeValue{S="4567"}}
            };

            return itemData;
        }


        //function send email (=receipt)
        public static void sendMail(String subject,String body)
        {
            const String FROM = "assansanogo@gmail.com";          // Replace with your "From" address. This address must be verified.
            const String TO = "jonas.rathke@edu.dsti.institute";  // Replace with a "To" address. If your account is still in the
                                                                  // sandbox, this address must be verified.

            String SUBJECT = subject;
            String BODY = body;
            // Supply your SMTP credentials below. Note that your SMTP credentials are different from your AWS credentials.
            const String SMTP_USERNAME = "AKIAJUGV2F3RTBSNZM5Q";                          // Replace with your SMTP username. 
            const String SMTP_PASSWORD = "Au5mLKbeUTv/CA4ViDQfvLkWTyxMBnUeG0GRD8vRb7MD";  // Replace with your SMTP password.

            // Amazon SES SMTP host name. This example uses the US West (Oregon) region.
            const String HOST = "email-smtp.eu-west-1.amazonaws.com";

            // The port you will connect to on the Amazon SES SMTP endpoint. We are choosing port 587 because we will use
            // STARTTLS to encrypt the connection.
            const int PORT = 587;
            try
            {
                // Create an SMTP client with the specified host name and port.
                using (System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient(HOST, PORT))
            {
                // Create a network credential with your SMTP user name and password.
                client.Credentials = new System.Net.NetworkCredential(SMTP_USERNAME, SMTP_PASSWORD);

                // Use SSL when accessing Amazon SES. The SMTP session will begin on an unencrypted connection, and then 
                // the client will issue a STARTTLS command to upgrade to an encrypted connection using SSL.
                client.EnableSsl = true;

                // Code below to actually Send the email. 
                try
                {
                    AutoClosingMessageBox.Show("Sending your receipt..", "Email delivery", 1000, Parent: Form.ActiveForm);
                    client.Send(FROM, TO, SUBJECT, BODY);
                    AutoClosingMessageBox.Show("\n Email sent!", "Success", 1000, Parent: Form.ActiveForm);

                    }
                    catch (Exception ex)
                    {
                        AutoClosingMessageBox.Show("The email was not sent! \n Error message: " + ex.Message, "ERROR", 1000, Parent: Form.ActiveForm);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        //Helpers functions
        public static void Checker(Document document)
        {
            //if the the query succeeds
            if (document.Count() > 0)
            {
                AutoClosingMessageBox.Show("\n RetrieveBalance: Balance retrieved...", "Data retrieval", 1000, Parent: Form.ActiveForm);
                PrintDocument(document);
            }
            //if the query fails
            else
            {
                AutoClosingMessageBox.Show("\n*** RetrieveBalance: Account unknown... *** \n Please contact your bank! \n Please enter a key", "Data retrieval", 10000, Parent: Form.ActiveForm);
                Console.ReadKey();
            }
        }


        //the function print a message Box
        public static Boolean PrintDocument(Document updatedDocument)
        {
            Boolean val=true;
            //Loop through all the attributes in the list outputed by Document.GetAttributeNames()
            foreach (var attribute in updatedDocument.GetAttributeNames())
            {
                string stringValue = null;
                var value = updatedDocument[attribute];
                if (value is Primitive)
                {
                    stringValue = value.AsPrimitive().Value.ToString();
                    
                }
                else if (value is PrimitiveList)
                {
                    stringValue = string.Join(",", (from primitive in value.AsPrimitiveList().Entries select primitive.Value).ToArray());
                }
                val = (updatedDocument[attribute]).AsBoolean();
                AutoClosingMessageBox.Show(attribute + " - " + val, "Info", 1000, Parent: Form.ActiveForm);


            }
            return val;
        }


        // the fucntion returns a String
        public static String strPrintDocument(Document updatedDocument)
        {
            String val = "";
            //Loop through all the attributes in the list outputed by Document.GetAttributeNames()
            foreach (var attribute in updatedDocument.GetAttributeNames())
            {
                string stringValue = null;
                var value = updatedDocument[attribute];

                if (value is Primitive)
                {
                    stringValue = value.AsPrimitive().Value.ToString();
                }
                else if (value is PrimitiveList)
                {
                    stringValue = string.Join(",", (from primitive in value.AsPrimitiveList().Entries select primitive.Value).ToArray());
                }
                   

                AutoClosingMessageBox.Show(attribute + " - " + stringValue, "Info", 1000, Parent: Form.ActiveForm);
                val = (updatedDocument[attribute]).ToString();
                //express MessageBox.Show(val.ToString());
                AutoClosingMessageBox.Show(attribute + " - " + val, "Info", 1000, Parent: Form.ActiveForm);
            }
            return val;
        }


        // header displayed when using a Console
        public static void displayheader()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("              ATM Bank Account");
            Console.WriteLine("===============================================");
        }

        public static double Pinger(string host="stackoverflow.com", int echoNum=4)
        {

            long totalTime = 0;
            int timeOut = 120;
            for (int i = 0; i < echoNum; i++)
            {
                Ping pingSender = new Ping();
                PingReply r = pingSender.Send(host, timeOut);
                if (r.Status == IPStatus.Success)
                {
                    totalTime += r.RoundtripTime;
                }
            }
            return (totalTime / echoNum);
        }
  

    public static String connectionOK(double p)
    {
            String mystring="";
            if (p > 100 )
            {
                mystring = "NOK";
            }
            else
            {
                mystring = "OK";
            }

            return mystring;
    }
    }
    //static class which holds the public battery charge properties
    public class Lib2
    {
        public static int decrement = 1;
        public static int charge=100;
        public static int form1visit = 0;
        public static int decr()
        {
            return  2;
        }
    }
}

