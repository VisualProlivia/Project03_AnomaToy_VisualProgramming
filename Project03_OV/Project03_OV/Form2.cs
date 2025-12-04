using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project03_OV
{
    public partial class ManualFrame : Form
    {
        public ManualFrame()
        {
            InitializeComponent();
        }
        
        // This is the Toy Manual page for the player to use
        // when checking a toy Obj's values for anomalous properties

        // If button to Go Back is pushed
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Go back to the GameFrame
            this.Dispose();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.toyManualDataSet);

        }

        private void tableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.toyManualDataSet);

        }

        private void ManualFrame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toyManualDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.toyManualDataSet.Table);

        }

        
    }
}
