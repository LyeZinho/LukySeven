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
        Me.BtDisplay_1 = New System.Windows.Forms.Button()
        Me.BtDisplay_2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtDisplay_1
        '
        Me.BtDisplay_1.Location = New System.Drawing.Point(214, 69)
        Me.BtDisplay_1.Name = "BtDisplay_1"
        Me.BtDisplay_1.Size = New System.Drawing.Size(139, 140)
        Me.BtDisplay_1.TabIndex = 0
        Me.BtDisplay_1.Text = "Button1"
        Me.BtDisplay_1.UseVisualStyleBackColor = True
        '
        'BtDisplay_2
        '
        Me.BtDisplay_2.Location = New System.Drawing.Point(397, 69)
        Me.BtDisplay_2.Name = "BtDisplay_2"
        Me.BtDisplay_2.Size = New System.Drawing.Size(139, 140)
        Me.BtDisplay_2.TabIndex = 1
        Me.BtDisplay_2.Text = "Button1"
        Me.BtDisplay_2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtDisplay_2)
        Me.Controls.Add(Me.BtDisplay_1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtDisplay_1 As Button
    Friend WithEvents BtDisplay_2 As Button
End Class
