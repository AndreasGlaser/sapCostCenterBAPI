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
namespace CostCenterGroupBAPI
{


    public partial class Overview : Form
    {
        RfcDestination rfcDestination= Connection.rfcDestination;
        public Overview()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                RfcRepository rfcRepository = rfcDestination.Repository;
                var getList = rfcRepository.CreateFunction("BAPI_COSTCENTERGROUP_GETLIST");
                getList.Invoke(rfcDestination);
                getList.SetValue("CONTROLLINGAREAMASK", CostAreaSearch.Text);
                getList.Invoke(rfcDestination);

                var table = getList.GetTable("GROUPLIST");
                getListGridView.Rows.Clear();
                for (int i = 0; i < table.RowCount; i++)
                {
                    String costArea = table[i].GetString("CO_AREA");
                    String groupname = table[i].GetString("GROUPNAME");
                    String descript = table[i].GetString("DESCRIPT");
                    String[] row = { costArea, groupname, descript };
                    getListGridView.Rows.Add(row);
                }
            }
            catch (RfcCommunicationException ex)
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
            }
            catch(Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
            }



        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void getDetailBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RfcRepository rfcRepository = rfcDestination.Repository;
                var getDetail = rfcRepository.CreateFunction("BAPI_COSTCENTERGROUP_GETDETAIL");
                getDetail.Invoke(rfcDestination);
                

                String contrArea = getListGridView.SelectedRows[0].Cells[0].Value.ToString();
                String groupName = getListGridView.SelectedRows[0].Cells[1].Value.ToString();

                getDetail.SetValue("CONTROLLINGAREA", contrArea);
                getDetail.SetValue("GROUPNAME", groupName);
                getDetail.Invoke(rfcDestination);

                var table = getDetail.GetTable("HIERARCHYNODES");
                var table2 = getDetail.GetTable("HIERARCHYVALUES");
                getDetailGridView.Rows.Clear();
                for (int i = 0; i < table.RowCount; i++)
                {
                    String hierlevel = table[i].GetString("HIERLEVEL");
                    String groupname = table[i].GetString("GROUPNAME");
                    String valcount = table[i].GetString("VALCOUNT");
                    String descript = table[i].GetString("DESCRIPT");
                    String[] row = { groupname, hierlevel, valcount, descript };
                    getDetailGridView.Rows.Add(row);
                }
            }
            catch (RfcCommunicationException ex)
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
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.Message);
            }
        }

        private void getListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

                //for (int i = 0; i < createGridView.RowCount; i++)
                //{

                    String groupName = createGridView.Rows[0].Cells[1].Value.ToString();
                    String hierLevel = createGridView.Rows[0].Cells[2].Value.ToString();
                    String valcount = createGridView.Rows[0].Cells[3].Value.ToString();
                    String descript = createGridView.Rows[0].Cells[4].Value.ToString();

                hierarchyTable.SetValue("GROUPNAME", "test");
                hierarchyTable.SetValue("HIERLEVEL", hierLevel);
                    hierarchyTable.SetValue("VALCOUNT", valcount);
                    hierarchyTable.SetValue("DESCRIPT", descript);
                //}


                
                create.SetValue("HIERARCHYNODES", hierarchyTable);
                //create.SetValue("HIERARCHYVALUES", hierarchyValuesTable);
                create.SetValue("CONTROLLINGAREAIMP", contrArea);
                create.Invoke(rfcDestination);
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
