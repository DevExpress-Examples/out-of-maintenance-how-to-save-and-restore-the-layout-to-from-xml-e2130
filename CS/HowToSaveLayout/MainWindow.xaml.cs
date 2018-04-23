using System.Data;
using System.Data.OleDb;
using System.Windows;
using DevExpress.Xpf.PivotGrid;
using HowToBindToMDB.NwindDataSetTableAdapters;

namespace HowToBindToMDB {
    public partial class MainWindow : Window {
        NwindDataSet.SalesPersonDataTable salesPersonDataTable = new NwindDataSet.SalesPersonDataTable();
        SalesPersonTableAdapter salesPersonDataAdapter = new SalesPersonTableAdapter();
        public MainWindow() {
            InitializeComponent();
            pivotGridControl1.DataSource = salesPersonDataTable;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            salesPersonDataAdapter.Fill(salesPersonDataTable);
        }
        private void buttonSave_Click(object sender, RoutedEventArgs e) {
            pivotGridControl1.SaveLayoutToXml("layout.xml");
        }
        private void buttonLoad_Click(object sender, RoutedEventArgs e) {
            pivotGridControl1.RestoreLayoutFromXml("layout.xml");
        }
    }
}