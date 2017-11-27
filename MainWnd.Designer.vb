<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWnd
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWnd))
    Me.btnOff = New System.Windows.Forms.Button
    Me.btnOn = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'btnOff
    '
    Me.btnOff.Location = New System.Drawing.Point(34, 28)
    Me.btnOff.Name = "btnOff"
    Me.btnOff.Size = New System.Drawing.Size(123, 23)
    Me.btnOff.TabIndex = 0
    Me.btnOff.Text = "Turn Off Screen Saver"
    Me.btnOff.UseVisualStyleBackColor = True
    '
    'btnOn
    '
    Me.btnOn.Enabled = False
    Me.btnOn.Location = New System.Drawing.Point(34, 67)
    Me.btnOn.Name = "btnOn"
    Me.btnOn.Size = New System.Drawing.Size(123, 23)
    Me.btnOn.TabIndex = 1
    Me.btnOn.Text = "Turn On Screen Saver"
    Me.btnOn.UseVisualStyleBackColor = True
    '
    'MainWnd
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(195, 113)
    Me.Controls.Add(Me.btnOn)
    Me.Controls.Add(Me.btnOff)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.Name = "MainWnd"
    Me.Text = "Screen Saver"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnOff As System.Windows.Forms.Button
  Friend WithEvents btnOn As System.Windows.Forms.Button

End Class
