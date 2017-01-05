using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Reflection;
using System.Windows.Forms;
using System.Management;
using System.Threading;
using System.Net.NetworkInformation;
using System.Windows;



//amazon use:
using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Transfer;
using Amazon.S3.Model;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;

using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
//using Amazon.SimpleEmail;

namespace Helios_ATM
{
    class Lib
    {
        public List<string> listOfDates=new List<string>() ;
        public List<int> listOfAmounts;

        public static void listOperations()
        {
            AmazonDynamoDBClient client = new AmazonDynamoDBClient();
            var request = new QueryRequest
            {
                TableName = "transaction2",
                KeyConditionExpression = "transactionID =:v_Id ",
                ExpressionAttributeValues = new Dictionary<string, AttributeValue>
        {
            {":v_Id",new AttributeValue {S="0002"} } 
    },
                ProjectionExpression="transactionDate",
                ConsistentRead=true
            };
            var response = client.Query(request);
        
         foreach(Dictionary<string, AttributeValue> item in response.Items)
            {
                PrintItem(item);
            }
        }


        public Boolean ScanTable(int Amount)
            {
            DateTime threeWeeksAgoDate =DateTime.UtcNow-TimeSpan.FromDays(21);
            
            string threeWeeksAgoDateStr = threeWeeksAgoDate.ToString();
            //MessageBox.Show(threeWeeksAgoDateStr);
            
            AmazonDynamoDBClient cl = new AmazonDynamoDBClient();
            var ScRequest = new ScanRequest
            {
         
                TableName = "transaction2",
                ExpressionAttributeValues = new Dictionary<string, AttributeValue> { {":val",new AttributeValue{S= Lib.getName("ATM",useCaseVariables.useCase)}}, },
                FilterExpression = "transactioner= :val",
                ProjectionExpression ="transactionDate, transactionAmount",
                ExclusiveStartKey=null
                
            };
            var Response = cl.Scan(ScRequest);
            List<string> l = new List<string>();
            List<string> l2 = new List<string>();


            List<int> lindex = new List<int>();
            int total = 0;
            foreach (Dictionary<string,AttributeValue> item in Response.Items)
            {
                //PrintItem2(item);
                String s = PrintItem2(item);
                l.Add(s);
                String t = PrintItem2(item, false);
                l2.Add(t);
            };
            foreach(String el in l){
               if (DateTime.Parse(el).Date > threeWeeksAgoDate.Date)
                {
                    int a=l.IndexOf(el);
                    total += Int32.Parse(l2[a]);
                }
            }
            //MessageBox.Show(String.Join(",",lindex));
            //MessageBox.Show(total.ToString());
            if (total+Amount>500 )
            {
                //MessageBox.Show("You took more than 500 pesos in a month");
                AutoClosingMessageBox.Show("You took more than 500 pesos in a month. Wait until next month to be able to withdraw agein.", "Monthly limit exceeded!", 2500, Parent: Form.ActiveForm);

                return false;
            }
            else
            {
                return true;
            }

        }





        public static void PrintItem(Dictionary<string,AttributeValue> attList)
        {

           //foreach(KeyValuePair<string,AttributeValue> item in attList)
           // {
           //    if (item.Value.S != null)
           //     {
           //         //MessageBox.Show(item.Value.S.ToString());
                    
                 

           //     }
           //     if (item.Value.N != null)
           //     {
           //         //MessageBox.Show(item.Value.N.ToString());
                   
           //     }
           // }
        }



        public string PrintItem2(Dictionary<string, AttributeValue> attList, Boolean flag=true)
        {
            string a = "";

            if (flag)
            {
                foreach (KeyValuePair<string, AttributeValue> item in attList)
            {
                if (item.Value.S != null)
                {

                    //MessageBox.Show(item.Value.S.ToString());

                    a= (item.Value.S.ToString());
                    //MessageBox.Show(Lib.listOfDates.ToString());

                }
            //   else if (item.Value.N != null)
            //    {
            //        //MessageBox.Show(item.Value.N.ToString());
            //        a= (item.Value.N.ToString());
            //    }
            }
            }
            else
            {
                foreach (KeyValuePair<string, AttributeValue> item in attList)
                    if (item.Value.N != null)
            {

                //MessageBox.Show(item.Value.N.ToString());

                a = (item.Value.N.ToString());
                //MessageBox.Show(Lib.listOfDates.ToString());

            }
            }
            return a;
        }

        // all the functions "get" retrieve a field of the table

        //get the Balance of a given account based on a table name and an account id
        public static String getBalance(String myAccountId,String tablename = "ATM")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            //AutoClosingMessageBox.Show("\n*** Executing RetrieveAccount() ***", "Data retrieval", 1000, Parent: Form.ActiveForm);

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
            //AutoClosingMessageBox.Show("\n*** Executing RetrieveAccount() ***", "Data retrieval", 1000, Parent: Form.ActiveForm);

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



        public static string getKilled(string tablename="KILLSWITCH",string myAccountId="0001")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            //AutoClosingMessageBox.Show("\n*** Executing RetrieveAccount() ***", "Data retrieval", 1000, Parent: Form.ActiveForm);

            // We define the Attributes to fetch (here Balance)
            GetItemOperationConfig config = new GetItemOperationConfig
            {
                AttributesToGet = new List<String> { "SHUTDOWN" },
                ConsistentRead = true
            };

            //from the table, get the item described in the config & return print result of PrintDoc function
            Document document = LoadProduct.GetItem(myAccountId, config);
            return strPrintDocument(document);

        }
 
        public static void stfu()
        {

            if (Boolean.Parse(Lib.getKilled()))
            {
                //log operation:
                s3log.logOperation(null, "KILLSWITCH utilized. ATM shutdown inaugurated.");

                //Alert:
                AutoClosingMessageBox.Show("ATM has been remotely shut down. /nYes, over the air!", "KILLSWITCH", 2000, Parent: Form.ActiveForm);

                //resetting the Kill for future uses
                Lib.updateKILL(false);

                //exit the forms:
                Environment.Exit(0);
            }


        }



        public static String getNummer(String tablename = "ATM", String myAccountId = "0002")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            //AutoClosingMessageBox.Show("\n*** Executing RetrieveAccount() ***", "Data retrieval", 1000, Parent: Form.ActiveForm);

            // We define the Attributes to fetch (here Balance)
            GetItemOperationConfig config = new GetItemOperationConfig
            {
                AttributesToGet = new List<string> { "CARD NUMBER" },
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
            //AutoClosingMessageBox.Show("\n*** Executing RetrieveAccount() ***", "Data retrieval", 1000, Parent: Form.ActiveForm);

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
            //AutoClosingMessageBox.Show("\n*** Executing RetrieveAccount() ***", "Data retrieval", 1000, Parent: Form.ActiveForm);


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
            //AutoClosingMessageBox.Show("\n*** Executing RetrieveAccount() ***", "Data retrieval", 1000, Parent: Form.ActiveForm);


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
            //AutoClosingMessageBox.Show("\n*** Executing RetrieveAccount() ***", "Data retrieval", 1000, Parent: Form.ActiveForm);

            // We define the Attributes to fetch (here Balance)
            GetItemOperationConfig config = new GetItemOperationConfig
            {
                AttributesToGet = new List<String> { "Blocked" },
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
            //AutoClosingMessageBox.Show("\n*** Finding your info ***", "Data check", 1000, Parent: Form.ActiveForm);

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
            //AutoClosingMessageBox.Show("\n*** Finding your info ***", "Data check", 1000, Parent: Form.ActiveForm);

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
        public static String RetrieveAccount( String myAccountId,String tablename = "ATM")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            //AutoClosingMessageBox.Show("\n*** Retrieving Account Details ***", "Data retrieval", 1000, Parent: Form.ActiveForm);

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
            //AutoClosingMessageBox.Show("\n*** Finding bank's name ***", "Data retrieval", 1000, Parent: Form.ActiveForm);

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











        public static String getATMCash(String tablename = "ATM", String myAccountId = "0005")
        {
            //Creation of a new Client
            AmazonDynamoDBClient dbc = new AmazonDynamoDBClient();

            //Load into a table called ATM thx to a DB client
            Table LoadProduct = Table.LoadTable(dbc, tablename);
            //AutoClosingMessageBox.Show("\n*** Finding bank's name ***", "Data retrieval", 1000, Parent: Form.ActiveForm);

            // We define the Attributes to fetch (here Balance)
            GetItemOperationConfig config = new GetItemOperationConfig
            {
                AttributesToGet = new List<string> { "ATMcash" },
                ConsistentRead = true
            };

            //from the table, get the item described in the config
            Document document = LoadProduct.GetItem(myAccountId, config);
            return strPrintDocument(document);
            //Checker(document);

        }



     
        //deprecated
        public static void update(String tablename = "ATM", String ID = "0002", int Pinentry = 0, Boolean blocked = false, Double Balance = 0, String Code = "1111")
        {
            var client = new AmazonDynamoDBClient();
            var request = new PutItemRequest()
            {
                TableName = tablename,
                ExpressionAttributeNames = new Dictionary<string, string>
                {{"#id","ID"}},

                ExpressionAttributeValues = new Dictionary<string, AttributeValue>
                {{ ":value", new AttributeValue{S="0002"}}},

                ConditionExpression = "#id=:value",
                Item = CreateItemData(ID, Pinentry, blocked, Balance, Code)
            };
            client.PutItem(request);
        }

        //deprecated
        public static void updateATM(String tablename = "AccountATM", String ID = "0002", int ATMcash = 0)
        {
            var client = new AmazonDynamoDBClient();
            var request = new PutItemRequest()
            {
                TableName = tablename,
                ExpressionAttributeNames = new Dictionary<string, string>
                {{"#id","ID"}},

                ExpressionAttributeValues = new Dictionary<string, AttributeValue>
                {{ ":value", new AttributeValue{ S=ID}}},

                ConditionExpression = "#id=:value",
                Item = CreateItemData("0005", 0, false, 0, "")

            };
            client.PutItem(request);
        }

        //deprecated
        public static Dictionary<string, AttributeValue> CreateItemDataATM(String ID, double ATMcash)
        {
            var itemData = new Dictionary<string, AttributeValue>
            {{"ID", new AttributeValue{S=ID} },
            {"ATMcash", new AttributeValue{N=ATMcash.ToString()}}};

            return itemData;
        }

        //deprecated

        public static Dictionary<String, AttributeValue> CreateItemData(String ID, int Pinentry, Boolean blocked, Double Balance = 2000, String Code = "1111")
        {
            var itemData = new Dictionary<String, AttributeValue>
            {{"ID", new AttributeValue{S=ID} },
            {"Balance", new AttributeValue{N=Balance.ToString()}},
            {"BankName", new AttributeValue{S="Credit Agricole"}},
            {"Blocked", new AttributeValue{BOOL=blocked}},
            {"Name", new AttributeValue{S="Jonas Rathke"}},
            {"Trials", new AttributeValue{N=Pinentry.ToString()}},
            {"Code", new AttributeValue{S=Code}},
            {"CheckingBalance", new AttributeValue{S="2000"}},
            {"SavingsBalance", new AttributeValue{S="4567"}},
            {"ATMcash", new AttributeValue{N="0"}},
            {"CARD NUMBER", new AttributeValue{S="0"}}
            };

            return itemData;
        }



        public static void updateATM(int AmountATM)
        {
            AmazonDynamoDBClient client = new AmazonDynamoDBClient();

        string tableName = "AccountATM";
        Table essaiTable = Table.LoadTable(client, tableName);
        var entry = new Document();
        entry["ID"]="0001";
        entry["ATMcash"] = AmountATM.ToString();
        essaiTable.PutItem(entry);
        }


        public static void updateKILL(Boolean f)
        {
            AmazonDynamoDBClient client = new AmazonDynamoDBClient();

            string tableName = "KILLSWITCH";
            Table essaiTable = Table.LoadTable(client, tableName);
            var entry = new Document();
            entry["IDNO"] = "0001";
            entry["SHUTDOWN"] = f.ToString();
            essaiTable.PutItem(entry);
        }







        public static void Newupdate(String id,
                                    int atMcash, 
                                    int balance, 
                                    String bankName,
                                    Boolean blocked, 
                                    String nummer, 
                                    int checkingBalance, 
                                    String code, 
                                    String name, 
                                    String savingsBalance, 
                                    int trials)
                                {
                                    AmazonDynamoDBClient client = new AmazonDynamoDBClient();

                                    string tableName = "ATM";
                                    Table essaiTable = Table.LoadTable(client, tableName);
                                    var entry = new Document();
                                    entry["ID"] = id;
                                    entry["ATMcash"] = atMcash.ToString();
                                    entry["Balance"] = balance.ToString();
                                    entry["BankName"] = bankName;
                                    entry["Blocked"] = blocked;
                                    entry["CARD NUMBER"] = nummer;
                                    entry["CheckingBalance"] = checkingBalance;
                                    entry["Code"] = code;
                                    entry["Name"] = name;
                                    entry["SavingsBalance"] = savingsBalance;
                                    entry["Trials"] = trials ;
            
                                    essaiTable.PutItem(entry);
                                }


        public static void updateTransactions(String transactionID,
                                            int transactionAmount,
                                            DateTime transactionDate, 
                                            string transactioner){
            AmazonDynamoDBClient client = new AmazonDynamoDBClient();

            string tableName = "transaction2";
            Table essaiTable = Table.LoadTable(client, tableName);
            var entry = new Document();
            entry["transactionID"] = transactionID;
            entry["transactionAmount"] = transactionAmount;
            entry["transactionDate"] = DateTime.UtcNow.ToString();
            entry["transactioner"] = transactioner;
            essaiTable.PutItem(entry);
        }




        public static void sendText(int amount, string a ="")
        {
            AmazonSimpleNotificationServiceClient snsClient = new AmazonSimpleNotificationServiceClient();
            SetSMSAttributesRequest s = new SetSMSAttributesRequest();
            s.Attributes.Add("DefaultSenderID", "HeliosBank");
            s.Attributes.Add("DefaultSMSType", "Promotional");

            snsClient.SetSMSAttributes(s);

            //Set the correct number:
            a = useCaseVariables.strNotificationAddress;

            try {
                PublishResponse resp = snsClient.Publish(new PublishRequest
                {
                    Message = "Thank you for using HELIOS Banking" +
               Environment.NewLine + "Operation successful " +
               DateTime.Now.ToString() +
               Environment.NewLine +
               "Amount(Pesos)" +
               amount.ToString() + Environment.NewLine + "This is future banking sh***. Be glad you are on it :-)",
                    PhoneNumber = a
                });
            }
            catch (Exception ex)
            {
                AutoClosingMessageBox.Show("Problem. \n Message could not be sent." , "ERROR", 1000, Parent: Form.ActiveForm);
                AutoClosingMessageBox.Show("Problem. \n Error message: " + ex.Message, "ERROR", 2000, Parent: Form.ActiveForm);
            }


        }



        //function send email (=receipt)
        public static void sendMail(String subject, String body)
        {
            string strTOAddress = useCaseVariables.strNotificationAddress;// ;
            const String FROM = "assansanogo@gmail.com";          // Replace with your "From" address. This address must be verified.
            string TO = strTOAddress;// = jonas.rathke@edu.dsti.institute";  // Replace with a "To" address. If your account is still in the
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
                        AutoClosingMessageBox.Show("Sending your receipt..", "Notification delivery", 1000, Parent: Form.ActiveForm);
                        client.Send(FROM, TO, SUBJECT, BODY);
                        AutoClosingMessageBox.Show("\n Notification sent!", "Success", 1000, Parent: Form.ActiveForm);

                    }
                    catch (Exception ex)
                    {
                        AutoClosingMessageBox.Show("The notification was not sent! \n Error message: " + ex.Message, "ERROR", 10000, Parent: Form.ActiveForm);
                    }
                }
            }
            catch (Exception ex)
            {
                AutoClosingMessageBox.Show("Problem. \n Error message: " + ex.Message, "ERROR", 1000, Parent: Form.ActiveForm);
            }


        }


        //Helpers functions
        public static void Checker(Document document)
        {
            //if the the query succeeds
            if (document.Count() > 0)
            {
                //AutoClosingMessageBox.Show("\n RetrieveBalance: Balance retrieved...", "Data retrieval", 1000, Parent: Form.ActiveForm);
                PrintDocument(document);
            }
            //if the query fails
            else
            {
                AutoClosingMessageBox.Show("\n*** RetrieveBalance: Account unknown... *** \n Please contact your bank! \n Please enter a key", "Data retrieval", 10000, Parent: Form.ActiveForm);
                //Console.ReadKey();
            }
        }


        //the function print a message Box
        public static Boolean PrintDocument(Document updatedDocument)
        {
            Boolean val = true;
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
                //AutoClosingMessageBox.Show(attribute + " : " + val, "Info", 1000, Parent: Form.ActiveForm);


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


                //AutoClosingMessageBox.Show(attribute + " - " + stringValue, "Info", 1000, Parent: Form.ActiveForm);
                val = (updatedDocument[attribute]).ToString();
                //express //MessageBox.Show(val.ToString());
                //AutoClosingMessageBox.Show(attribute + " - " + val, "Info", 1000, Parent: Form.ActiveForm);
            }
            return val;
        }

        public static void NotEnoughCash(double amount, String s)
        {
            if (amount> Int32.Parse(s)) {
                AutoClosingMessageBox.Show("This ATM doesn't have enough cash. Move your booty to the next one. Ask people for the way :-)", "No sufficient cash", 1000, Parent: Form.ActiveForm);
                Environment.Exit(0);
            }
        }


        // header displayed when using a Console
        public static void displayheader()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("              ATM Bank Account");
            Console.WriteLine("===============================================");
        }

        public static double Pinger(string host = "stackoverflow.com", int echoNum = 4)
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
            String mystring = "";
            if (p > 100)
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
    

    //Class to store log and send it to AWS S3 if transaction finished = Abortion of operation
    public class s3log
    {
        public static string strLog;
        static int iFormCount = 0;

        static List<string> listVisits = new List<string>();

        public static void uploadLogToS3()
        {
            string s = s3log.strLog;
            var sb = new StringBuilder();
            sb.Append(s);
            File.WriteAllText("afile.txt", sb.ToString());
            s3log.uploadtoS3("afile.txt");
        }
       

        public static bool logOperation(object sender=null, string strAdditionalLogtext="")
        {
            //if there is no logtext provided, log all parameters
            if (sender != null)
            {       
                //if log all operations and constraints:    
                listVisits.Add(Form.ActiveForm.Name);

                //count all occurences of formname in the list:
                iFormCount = listVisits.Where(s => s == Form.ActiveForm.Name).Count();
                strLog += "\n" + "========================"
                            + "\n" + "Date and time: " + (DateTime.Now).ToString()
                            + "\n" + "Form: " + Form.ActiveForm.Name
                            + "\n" + "Operation: Button " + ((Button)sender).Name
                            + "\n" + "Battery life: " + battery.charge + "% "
                            + "\n" + "# of form visits: " + (iFormCount).ToString()
                            + "\n" + "Ping: " + (networkConnection.Pinger("stackoverflow.com", 5)).ToString();
                
                //if the abortion button was clicked, send log to s3
                if (((Button)sender).Name.IndexOf("Abort") > -1)
                {
                    //send total log to AWS S3
                    s3log.uploadLogToS3();

                    //resetting the log for next customer:
                    strLog = "";
                    listVisits.Clear();

                }
            }
            else
            {
                if (strAdditionalLogtext.IndexOf("Initialization") >-1)
                {
                    strLog += "========================"
                            + "\n" + "========================"
                            + "\n" + "Initialization of ATM"
                            + "\n" + "HELIOS ATM Project"
                            + "\n" + "Built by Assan Sanogo, Jonas Rathke"
                            + "\n" + "(c) 2017"
                            + "\n" + "'Let's ping that...!'"
                            + "\n" + "========================"
                            + "\n" + "Date and time: " + (DateTime.Now).ToString()
                            + "\n" + "Account use case: " + useCaseVariables.useCase
                            + "\n" + "cases: 0: Zero cash in Account, 1: No more PIN entries left, 2: Standard case"
                            + "\n" + "Battery powered: " + useCaseVariables.bCheckBoxPowerSourceBattery
                            + "\n" + "Network connection unstable: " + useCaseVariables.bCheckBoxNetworkConnectionUnstable
                            + "\n" + "Provided notification number: " + useCaseVariables.strNotificationAddress
                            + "\n" + "Ping: " + (networkConnection.Pinger("stackoverflow.com", 5)).ToString()
                            + "\n" + "========================";                   

                    }
                else
                {
                    listVisits.Add(Form.ActiveForm.Name);
                    iFormCount = listVisits.Where(s => s == Form.ActiveForm.Name).Count();
                    strLog += "\n" + "========================"
                               + "\n" + "Date and time: " + (DateTime.Now).ToString()
                               + "\n" + "Form: " + Form.ActiveForm.Name
                               + "\n" + "Operation: Logtext: " + strAdditionalLogtext
                               + "\n" + "Battery life: " + battery.charge + "% "
                               + "\n" + "# of form visits: " + (iFormCount).ToString()
                               + "\n" + "Ping: " + (networkConnection.Pinger("stackoverflow.com", 5)).ToString();
                }
                    
            }


            //AutoClosingMessageBox.Show(strLog, "Info", 5000, Parent: Form.ActiveForm);
            //System.Diagnostics.Debug.WriteLine(strLog);
            
            return true;
        }



   public static void uploadtoS3(String filePath)
    {
        string existingBucketName = "dstiawsml";
        Random rand = new Random(DateTime.Now.Millisecond);
        string keyName = "logHeliosATM_" + (DateTime.Now).ToString("yyyy_MM_dd_hh_mm_ss")+ rand.Next().ToString();
        try
        {
            TransferUtility fileTransferUtility = new
            TransferUtility(new AmazonS3Client(Amazon.RegionEndpoint.USEast1));


            // Upload data from a type of System.IO.Stream.
            using (FileStream fileToUpload =
                new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                fileTransferUtility.Upload(fileToUpload,
                                            existingBucketName, keyName);
            }
            Console.WriteLine("Upload completed");

                  
        }
        catch (AmazonS3Exception s3Exception)
        {
            Console.WriteLine(s3Exception.Message,
                                s3Exception.InnerException);
        }
            }
    }
}







