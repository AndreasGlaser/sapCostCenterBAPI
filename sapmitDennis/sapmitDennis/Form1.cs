using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAP.Middleware.Connector;
namespace sapmitDennis
{


    public partial class Form1 : Form
    {
        RfcDestination rfcDestination=null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connector sapconnector = new connector();
            RfcDestinationManager.RegisterDestinationConfiguration(sapconnector);
            rfcDestination = null;
            rfcDestination = RfcDestinationManager.GetDestination("costCenter");
            try
            {
                if (rfcDestination != null)
                {
                    rfcDestination.Ping();
                    lbl.Text = "conected";
                }

            }catch (Exception e1){
                Console.WriteLine(e1.Message);
                lbl.Text = "failed";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                RfcRepository rfcRepository = rfcDestination.Repository;
                var getList = rfcRepository.CreateFunction("BAPI_COSTCENTERGROUP_GETLIST");
                getList.Invoke(rfcDestination);
                getList.SetValue("CONTROLLINGAREAMASK", "0001");
                getList.Invoke(rfcDestination);

                var table = getList.GetTable("GROUPLIST");

                for (int i = 0; i < table.RowCount; i++)
                {
                    lbl2.Text += table[i].GetString("DESCRIPT") + " || ";
                }
            }
            catch (RfcCommunicationException ex)
            {

            }
            catch (RfcLogonException ex)
            {

            }
            catch (RfcAbapRuntimeException ex)
            {

            }
            catch(Exception ex)
            {

            }



        }
    }
}
