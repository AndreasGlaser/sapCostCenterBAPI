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
    public partial class CreateGroup : Form
    {
        RfcDestination rfcDestination = Connection.rfcDestination;
        public CreateGroup()
        {
            
            InitializeComponent();
            String[] row = { "1000", "ATEST", "0", "0", "TestTest2" };
            createGridView.Rows.Add(row);
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                

                RfcRepository rfcRepository = rfcDestination.Repository;
                var create = rfcRepository.CreateFunction("BAPI_COSTCENTERGROUP_CREATE");
                create.Invoke(rfcDestination);


                String contrArea = createGridView.Rows[0].Cells[0].Value.ToString();


                var hierarchyTable = create.GetTable("HIERARCHYNODES");
                hierarchyTable.Append();
                IRfcTable hierarchyValuesTable = create.GetTable("HIERARCHYVALUES");


                String groupName = createGridView.Rows[0].Cells[1].Value.ToString();
                String hierLevel = createGridView.Rows[0].Cells[2].Value.ToString();
                String valcount = createGridView.Rows[0].Cells[3].Value.ToString();
                String descript = createGridView.Rows[0].Cells[4].Value.ToString();

                hierarchyTable.SetValue("GROUPNAME", groupName);
                hierarchyTable.SetValue("HIERLEVEL", hierLevel);
                hierarchyTable.SetValue("VALCOUNT", valcount);
                hierarchyTable.SetValue("DESCRIPT", descript);



                create.SetValue("HIERARCHYNODES", hierarchyTable);
                //create.SetValue("HIERARCHYVALUES", hierarchyValuesTable);
                create.SetValue("CONTROLLINGAREAIMP", contrArea);
                create.Invoke(rfcDestination);
                this.Close();
            }
            /*catch (RfcCommunicationException ex)
            {
                Console.Out.WriteLine(ex.Message);
            }
            catch (RfcLogonException ex)
            {
                Console.Out.WriteLine(ex.Message);
            }
            catch (RfcAbapRuntimeException ex)
            {
                Console.Out.WriteLine(ex.Message);
            }*/
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
                Console.Out.WriteLine(ex.StackTrace);
            }
        }
    }
}
