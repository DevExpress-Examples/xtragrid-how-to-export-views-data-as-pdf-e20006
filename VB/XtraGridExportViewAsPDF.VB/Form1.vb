Imports System.Diagnostics
Imports DevExpress.XtraGrid.Views.Grid

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NwindDataSet.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.NwindDataSet.Orders)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim View As GridView = TryCast(GridControl1.MainView, GridView)
        If Not (View Is Nothing) Then
            View.ExportToPdf("MainViewData.pdf")

            ' The following requires Adobe Reader to be installed on the system
            Dim pdfExport As New Process()
            pdfExport.StartInfo.FileName = "AcroRd32.exe"
            pdfExport.StartInfo.Arguments = "MainViewData.pdf"
            pdfExport.Start()
        End If
    End Sub
End Class
