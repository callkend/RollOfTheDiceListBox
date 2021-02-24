<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RollOfTheDice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.RollListBox = New System.Windows.Forms.ListBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(335, 372)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(148, 66)
        Me.RollButton.TabIndex = 0
        Me.RollButton.Text = "&Roll"
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(489, 372)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(152, 66)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(647, 372)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(141, 66)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'RollListBox
        '
        Me.RollListBox.ColumnWidth = 35
        Me.RollListBox.Font = New System.Drawing.Font("Consolas", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RollListBox.FormattingEnabled = True
        Me.RollListBox.ItemHeight = 15
        Me.RollListBox.Location = New System.Drawing.Point(12, 12)
        Me.RollListBox.MultiColumn = True
        Me.RollListBox.Name = "RollListBox"
        Me.RollListBox.Size = New System.Drawing.Size(776, 79)
        Me.RollListBox.TabIndex = 3
        Me.RollListBox.TabStop = False
        '
        'RollOfTheDice
        '
        Me.AcceptButton = Me.RollButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RollListBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RollButton)
        Me.Name = "RollOfTheDice"
        Me.Text = "Roll of the Dice"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RollButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents RollListBox As ListBox
    Friend WithEvents ToolTip As ToolTip
End Class
