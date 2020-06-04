using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GridLookUpEdit_MultiAutoSearch {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nwindDataSet.Customers);
        }

        private void gridLookUpEdit1_AutoSearch(object sender, DevExpress.XtraEditors.Controls.LookUpEditAutoSearchEventArgs e) {
            e.SetParameters(DevExpress.Data.Filtering.FindPanelParserKind.Exact, DevExpress.Data.Filtering.FilterCondition.Contains);
        }
    }
}