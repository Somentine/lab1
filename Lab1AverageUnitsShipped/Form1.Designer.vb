<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.txtUserInputUnits = New System.Windows.Forms.TextBox()
        Me.lblDaysCounter = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtUnitsList = New System.Windows.Forms.TextBox()
        Me.lblAverageUnitsShipped = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.AverageUnitsShippedTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtUserInputUnits
        '
        Me.txtUserInputUnits.Location = New System.Drawing.Point(94, 22)
        Me.txtUserInputUnits.Name = "txtUserInputUnits"
        Me.txtUserInputUnits.Size = New System.Drawing.Size(80, 20)
        Me.txtUserInputUnits.TabIndex = 1
        Me.AverageUnitsShippedTips.SetToolTip(Me.txtUserInputUnits, "Enter The Amount Of Units Shipped")
        '
        'lblDaysCounter
        '
        Me.lblDaysCounter.Location = New System.Drawing.Point(191, 22)
        Me.lblDaysCounter.Name = "lblDaysCounter"
        Me.lblDaysCounter.Size = New System.Drawing.Size(41, 20)
        Me.lblDaysCounter.TabIndex = 5
        Me.lblDaysCounter.Text = "Day 1"
        Me.lblDaysCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(34, 22)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(41, 20)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUnitsList
        '
        Me.txtUnitsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnitsList.Location = New System.Drawing.Point(37, 61)
        Me.txtUnitsList.Multiline = True
        Me.txtUnitsList.Name = "txtUnitsList"
        Me.txtUnitsList.ReadOnly = True
        Me.txtUnitsList.Size = New System.Drawing.Size(195, 130)
        Me.txtUnitsList.TabIndex = 6
        Me.txtUnitsList.TabStop = False
        Me.txtUnitsList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AverageUnitsShippedTips.SetToolTip(Me.txtUnitsList, "Lists Your Previously Entered Units Shipped For Each Day Of The Week")
        '
        'lblAverageUnitsShipped
        '
        Me.lblAverageUnitsShipped.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageUnitsShipped.Location = New System.Drawing.Point(37, 194)
        Me.lblAverageUnitsShipped.Name = "lblAverageUnitsShipped"
        Me.lblAverageUnitsShipped.Size = New System.Drawing.Size(195, 20)
        Me.lblAverageUnitsShipped.TabIndex = 7
        Me.lblAverageUnitsShipped.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(32, 224)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(69, 27)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnEnter, "Click To Add Your Number To the List And Calculates The Average Once Seven Number" &
        "s Have Been Inputted")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(107, 224)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(67, 27)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnReset, "Click To Reset The Form To The Original State")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(180, 224)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(61, 27)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShippedTips.SetToolTip(Me.btnExit, "Click To Close The Program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblAverageUnitsShipped)
        Me.Controls.Add(Me.txtUnitsList)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblDaysCounter)
        Me.Controls.Add(Me.txtUserInputUnits)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUserInputUnits As TextBox
    Friend WithEvents lblDaysCounter As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtUnitsList As TextBox
    Friend WithEvents lblAverageUnitsShipped As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents AverageUnitsShippedTips As ToolTip
End Class
