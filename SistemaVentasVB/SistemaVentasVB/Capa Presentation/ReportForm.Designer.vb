<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.comboBoxReportType = New System.Windows.Forms.ComboBox()
        Me.dateTimePickerStart = New System.Windows.Forms.DateTimePicker()
        Me.dateTimePickerEnd = New System.Windows.Forms.DateTimePicker()
        Me.dataGridViewReport = New System.Windows.Forms.DataGridView()
        Me.buttonGenerateReport = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dataGridViewReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comboBoxReportType
        '
        Me.comboBoxReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxReportType.Items.AddRange(New Object() {"Ventas", "Productos"})
        Me.comboBoxReportType.Location = New System.Drawing.Point(87, 20)
        Me.comboBoxReportType.Margin = New System.Windows.Forms.Padding(2)
        Me.comboBoxReportType.Name = "comboBoxReportType"
        Me.comboBoxReportType.Size = New System.Drawing.Size(151, 21)
        Me.comboBoxReportType.TabIndex = 0
        '
        'dateTimePickerStart
        '
        Me.dateTimePickerStart.Location = New System.Drawing.Point(62, 73)
        Me.dateTimePickerStart.Margin = New System.Windows.Forms.Padding(2)
        Me.dateTimePickerStart.Name = "dateTimePickerStart"
        Me.dateTimePickerStart.Size = New System.Drawing.Size(198, 20)
        Me.dateTimePickerStart.TabIndex = 1
        '
        'dateTimePickerEnd
        '
        Me.dateTimePickerEnd.Location = New System.Drawing.Point(324, 73)
        Me.dateTimePickerEnd.Margin = New System.Windows.Forms.Padding(2)
        Me.dateTimePickerEnd.Name = "dateTimePickerEnd"
        Me.dateTimePickerEnd.Size = New System.Drawing.Size(197, 20)
        Me.dateTimePickerEnd.TabIndex = 2
        '
        'dataGridViewReport
        '
        Me.dataGridViewReport.AllowUserToAddRows = False
        Me.dataGridViewReport.AllowUserToDeleteRows = False
        Me.dataGridViewReport.AllowUserToResizeColumns = False
        Me.dataGridViewReport.AllowUserToResizeRows = False
        Me.dataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridViewReport.Location = New System.Drawing.Point(22, 109)
        Me.dataGridViewReport.Margin = New System.Windows.Forms.Padding(2)
        Me.dataGridViewReport.Name = "dataGridViewReport"
        Me.dataGridViewReport.ReadOnly = True
        Me.dataGridViewReport.RowHeadersVisible = False
        Me.dataGridViewReport.RowHeadersWidth = 51
        Me.dataGridViewReport.RowTemplate.Height = 24
        Me.dataGridViewReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridViewReport.Size = New System.Drawing.Size(499, 291)
        Me.dataGridViewReport.TabIndex = 3
        '
        'buttonGenerateReport
        '
        Me.buttonGenerateReport.Location = New System.Drawing.Point(286, 20)
        Me.buttonGenerateReport.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonGenerateReport.Name = "buttonGenerateReport"
        Me.buttonGenerateReport.Size = New System.Drawing.Size(235, 42)
        Me.buttonGenerateReport.TabIndex = 4
        Me.buttonGenerateReport.Text = "Generar Reporte"
        Me.buttonGenerateReport.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Reporte de:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(283, 77)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hasta:"
        '
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonGenerateReport)
        Me.Controls.Add(Me.dataGridViewReport)
        Me.Controls.Add(Me.dateTimePickerEnd)
        Me.Controls.Add(Me.dateTimePickerStart)
        Me.Controls.Add(Me.comboBoxReportType)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportForm"
        Me.Text = "Generar Reportes"
        CType(Me.dataGridViewReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
