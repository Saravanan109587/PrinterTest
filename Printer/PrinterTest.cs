using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Management;
using System.Security.Principal;

namespace Printer
{
    public partial class PrinterTest : Form
    {
        public PrinterTest()
        {
            InitializeComponent();
            if (IsAdministrator())
            {
                if (PrinterSettings.InstalledPrinters.Count > 0)
                {
                    foreach (string printers in PrinterSettings.InstalledPrinters)
                    {
                        availablePrinters.Items.Add(printers);

                    }
                }
                else
                {
                    MessageBox.Show("No Printer Installed on this System");
                }
            }
            else
            {
                MessageBox.Show("Please open Application as Admistrator");
                if (System.Windows.Forms.Application.MessageLoop)
                {
                    // WinForms app
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    // Console app
                    System.Environment.Exit(1);
                }
            }
            


           
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (availablePrinters.SelectedItem != null)
            {
                var test = availablePrinters.SelectedItem;
                SetDefaultPrinter(test.ToString());
                Print(test.ToString());
            }
            else
            {
                MessageBox.Show("No Printer Selected,Please Select Valid Printer fro Drop down");
            }

        }


        public static void SetDefaultPrinter(string printerName)
        {
            try
            {
                string sPrintername = printerName;

                //create an instance of a reflection type
                Type t = Type.GetTypeFromProgID("WScript.Network");

                //create an instance using the system activator, consuming the type
                Object o = Activator.CreateInstance(t);

                //invoke the method using the object we created

                t.InvokeMember("SetDefaultPrinter", System.Reflection.BindingFlags.InvokeMethod, null, o, new object[] { sPrintername });

            }
            catch (Exception)
            {
                MessageBox.Show("Unable to set a default printer. The printer may not exist or the WScript.Network com object may have a problem.");
                //throw new Exception("Unable to set a default printer. The printer may not exist or the WScript.Network com object may have a problem.");

            }
        }

        public void Print(string PrinterName)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrinterSettings.PrinterName = PrinterName;
            try
            {
                doc.PrintPage += new PrintPageEventHandler(PrintHandler);
                doc.Print();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        private void PrintHandler(object sender, PrintPageEventArgs ppeArgs)
        {
            Font FontNormal = new Font("Verdana", 12);
            Graphics g = ppeArgs.Graphics;
            g.DrawString("Test Print Success", FontNormal, Brushes.Black, 10, 10, new StringFormat());
        }

        private void PrinterStatus(string printern)
        {
            string query = string.Format("SELECT * from Win32_Printer WHERE Name LIKE '%{0}'", printern);

            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
                using (ManagementObjectCollection coll = searcher.Get())
                {
                    try
                    {
                        List<PrinterInfo> printerInfo = new List<PrinterInfo>();
                        foreach (ManagementObject printer in coll)
                        {
                            foreach (PropertyData property in printer.Properties)
                            {
                                printerInfo.Add(new PrinterInfo
                                {
                                    PropertyName = property.Name,
                                    Status = property.Value != null ? property.Value.ToString() : ""
                                });
                            }
                        }

                        data_Printer.DataSource = printerInfo;
                    }
                    catch (ManagementException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            
        }

        public class PrinterInfo
        {
            public string PropertyName { get; set; }
            public string Status { get; set; }
        }
 
        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((availablePrinters.SelectedItem != null))
                PrinterStatus(availablePrinters.SelectedItem.ToString());
            else
                MessageBox.Show("No Printer Selected,Please Select Valid Printer fro Drop down");
        }


        public static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        private void checkOnline(string printernm)
        {
            // Set management scope
            ManagementScope scope = new ManagementScope(@"\root\cimv2");
            scope.Connect();
            string query = string.Format("SELECT * from Win32_Printer WHERE Name LIKE '%{0}'", printernm);        
            string printerName = "";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
                try
                {
                    foreach (ManagementObject printer in searcher.Get())
                    {
                        printerName = printer["Name"].ToString().ToLower();
                        if (printerName.Equals(printernm.ToLower()))
                        {
                            Console.WriteLine("Printer = " + printer["Name"]);
                            if (printer["WorkOffline"].ToString().ToLower().Equals("true"))
                            {

                                MessageBox.Show("Your Plug-N-Play printer is not connected.");
                            }
                            else
                            {
                                // printer is not offline
                                MessageBox.Show("Your Plug-N-Play printer is connected.");
                            }
                        }
                    }
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }
              
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if ((availablePrinters.SelectedItem != null))
                checkOnline(availablePrinters.SelectedItem.ToString());

            else
                MessageBox.Show("No Printer Selected,Please Select Valid Printer fro Drop down");

        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            availablePrinters.SelectedItem = null;
        }
    }
}


