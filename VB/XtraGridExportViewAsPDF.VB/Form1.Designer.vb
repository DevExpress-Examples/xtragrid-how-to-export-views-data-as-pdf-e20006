<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NwindDataSet = New XtraGridExportViewAsPDF.VB.nwindDataSet
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colShippedDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colShipName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colShipCountry = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.OrdersTableAdapter = New XtraGridExportViewAsPDF.VB.nwindDataSetTableAdapters.OrdersTableAdapter
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.OrdersBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(690, 302)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.NwindDataSet
        '
        'NwindDataSet
        '
        Me.NwindDataSet.DataSetName = "nwindDataSet"
        Me.NwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustomerID, Me.colOrderDate, Me.colShippedDate, Me.colShipName, Me.colShipCountry})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colCustomerID
        '
        Me.colCustomerID.FieldName = "CustomerID"
        Me.colCustomerID.Name = "colCustomerID"
        Me.colCustomerID.Visible = True
        Me.colCustomerID.VisibleIndex = 0
        '
        'colOrderDate
        '
        Me.colOrderDate.FieldName = "OrderDate"
        Me.colOrderDate.Name = "colOrderDate"
        Me.colOrderDate.Visible = True
        Me.colOrderDate.VisibleIndex = 1
        '
        'colShippedDate
        '
        Me.colShippedDate.FieldName = "ShippedDate"
        Me.colShippedDate.Name = "colShippedDate"
        Me.colShippedDate.Visible = True
        Me.colShippedDate.VisibleIndex = 2
        '
        'colShipName
        '
        Me.colShipName.FieldName = "ShipName"
        Me.colShipName.Name = "colShipName"
        Me.colShipName.Visible = True
        Me.colShipName.VisibleIndex = 3
        '
        'colShipCountry
        '
        Me.colShipCountry.FieldName = "ShipCountry"
        Me.colShipCountry.Name = "colShipCountry"
        Me.colShipCountry.Visible = True
        Me.colShipCountry.VisibleIndex = 4
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Location = New System.Drawing.Point(0, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(690, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Export As PDF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 325)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NwindDataSet As XtraGridExportViewAsPDF.VB.nwindDataSet
    Friend WithEvents OrdersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrdersTableAdapter As XtraGridExportViewAsPDF.VB.nwindDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipCountry As DevExpress.XtraGrid.Columns.GridColumn

End Class
