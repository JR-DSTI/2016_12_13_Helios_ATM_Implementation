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
    class Lib
    {


        public static String getBalance(String tablename = "ATM", String myAccountId = "0002")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            MessageBox.Show("\n*** Executing RetrieveAccount() ***");

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

        public static String getID(String tablename = "ATM", String myAccountId = "0002")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            MessageBox.Show("\n*** Executing RetrieveAccount() ***");

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











        public static Boolean getBlocked(String tablename = "ATM", String myAccountId = "0002")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            MessageBox.Show("\n*** Executing RetrieveAccount() ***");

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

        public static String getName(String tablename = "ATM", String myAccountId = "0002")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            MessageBox.Show("\n*** Finding your info ***");

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

        public static String RetrieveAccount(String tablename = "ATM", String myAccountId = "0002")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            MessageBox.Show("***Retrieving Account Details ***");

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

        public static String getBankName(String tablename = "ATM", String myAccountId = "0002")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            MessageBox.Show("*** Finding BankName ***");

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


        public static void update(String Pinentry, Boolean blocked, Double Balance=0)
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
                Item = CreateItemData(Pinentry,blocked, Balance)

            };
            client.PutItem(request);
        }

    
        public static void sendMail(String subject,String body)
        {
            const String FROM = "assansanogo@gmail.com";   // Replace with your "From" address. This address must be verified.
            const String TO = "jonas.rathke@edu.dsti.institute";  // Replace with a "To" address. If your account is still in the
                                                                  // sandbox, this address must be verified.

            String SUBJECT = subject;
            String BODY = body;
            // Supply your SMTP credentials below. Note that your SMTP credentials are different from your AWS credentials.
            const String SMTP_USERNAME = "AKIAJUGV2F3RTBSNZM5Q";  // Replace with your SMTP username. 
            const String SMTP_PASSWORD = "Au5mLKbeUTv/CA4ViDQfvLkWTyxMBnUeG0GRD8vRb7MD";  // Replace with your SMTP password.

            // Amazon SES SMTP host name. This example uses the US West (Oregon) region.
            const String HOST = "email-smtp.eu-west-1.amazonaws.com";

            // The port you will connect to on the Amazon SES SMTP endpoint. We are choosing port 587 because we will use
            // STARTTLS to encrypt the connection.
            const int PORT = 587;

            // Create an SMTP client with the specified host name and port.
            using (System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient(HOST, PORT))
            {
                // Create a network credential with your SMTP user name and password.
                client.Credentials = new System.Net.NetworkCredential(SMTP_USERNAME, SMTP_PASSWORD);

                // Use SSL when accessing Amazon SES. The SMTP session will begin on an unencrypted connection, and then 
                // the client will issue a STARTTLS command to upgrade to an encrypted connection using SSL.
                client.EnableSsl = true;

                // Send the email. 
                try
                {
                    MessageBox.Show("Attempting to send an email through the Amazon SES SMTP interface...");
                    client.Send(FROM, TO, SUBJECT, BODY);
                    MessageBox.Show("Email sent!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The email was not sent.");
                    MessageBox.Show("Error message: " + ex.Message);
                }
            }

            
        }



        public static Dictionary<string, AttributeValue> CreateItemData(String Pinentry, Boolean blocked,Double Balance=2000)
        {
            var itemData = new Dictionary<string, AttributeValue>
            {{"ID", new AttributeValue{S="0002"} },
             {"Balance", new AttributeValue{N=Balance.ToString()} },
             {"BankName", new AttributeValue{S="Credit Agricole"} },
             {"Blocked", new AttributeValue{BOOL=blocked} },
             {"Name", new AttributeValue{S="Jonas Rathke"}},
              {"Trials", new AttributeValue{N=Pinentry}   },
            };

            return itemData;
        }


        //Helpers functions
        public static void Checker(Document document)
        {
            //if the the query succeeds
            if (document.Count() > 0)
            {
                MessageBox.Show("RetrieveBalance: Balance retrieved...");
                PrintDocument(document);
            }
            //if the query fails
            else
            {
                MessageBox.Show("RetrieveBalance: Account unknown...");
                MessageBox.Show("please contact your Bank");

                MessageBox.Show("Please enter a key");
                Console.ReadKey();
            }
        }

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
                MessageBox.Show(attribute +" - " +val);
                
                //MessageBox.Show(val.ToString());
                
            }
            return val;
        }

        public static String strPrintDocument(Document updatedDocument)
        {
            String val = "";
            //Loop through all the attributes in the list outputed by Document.GetAttributeNames()
            foreach (var attribute in updatedDocument.GetAttributeNames())
            {
                string stringValue = null;
                var value = updatedDocument[attribute];
                if (value is Primitive)
                    stringValue = value.AsPrimitive().Value.ToString();
                else if (value is PrimitiveList)
                    stringValue = string.Join(",", (from primitive in value.AsPrimitiveList().Entries select primitive.Value).ToArray());

                MessageBox.Show(attribute + " - " + stringValue);
                val = (updatedDocument[attribute]).ToString();
                //MessageBox.Show(val.ToString());
            }
            return val;
        }


        public static void displayheader()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("              ATM Bank Account");
            Console.WriteLine("===============================================");
        }
    }
}

