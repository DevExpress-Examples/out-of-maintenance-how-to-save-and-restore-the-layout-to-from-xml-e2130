Imports System.Windows
Imports HowToBindToMDB.NwindDataSetTableAdapters

Namespace HowToBindToMDB

    Public Partial Class MainWindow
        Inherits Window

        Private salesPersonDataTable As NwindDataSet.SalesPersonDataTable = New NwindDataSet.SalesPersonDataTable()

        Private salesPersonDataAdapter As SalesPersonTableAdapter = New SalesPersonTableAdapter()

        Public Sub New()
            Me.InitializeComponent()
            Me.pivotGridControl1.DataSource = salesPersonDataTable
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            salesPersonDataAdapter.Fill(salesPersonDataTable)
        End Sub

        Private Sub buttonSave_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.pivotGridControl1.SaveLayoutToXml("layout.xml")
        End Sub

        Private Sub buttonLoad_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.pivotGridControl1.RestoreLayoutFromXml("layout.xml")
        End Sub
    End Class
End Namespace
