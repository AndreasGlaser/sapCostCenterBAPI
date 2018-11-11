using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostCenterGroupBAPI
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            connector sapconnector = new connector();
            RfcDestinationManager.RegisterDestinationConfiguration(sapconnector);
            Connection.rfcDestination = null;
            Connection.rfcDestination = RfcDestinationManager.GetDestination("costCenter");
            try
            {
                if (Connection.rfcDestination != null)
                {
                    Connection.rfcDestination.Ping();
                    connectionlbl.Text = "connected";
                    new Overview().Show();
                    this.Hide();
                }

            }catch (Exception e1){
                Console.WriteLine(e1.Message);
                connectionlbl.Text = "failed";
            }
        }
    }
}
