<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Oculus
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
        Me.GroupBox1 = New working_with_dlls_form.GroupBox()
        Me.mandex = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(479, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 285)
        Me.GroupBox1.TabIndex = 0
        '
        'mandex
        '
        Me.mandex.AutoSize = True
        Me.mandex.Location = New System.Drawing.Point(129, 125)
        Me.mandex.Name = "mandex"
        Me.mandex.Size = New System.Drawing.Size(62, 13)
        Me.mandex.TabIndex = 1
        Me.mandex.Text = "Click Below"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(132, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Oculus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 536)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mandex)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Oculus"
        Me.ShowIcon = False
        Me.Text = "Oculus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As working_with_dlls_form.GroupBox
    Friend WithEvents mandex As Label
    Friend WithEvents Button1 As Button
End Class
