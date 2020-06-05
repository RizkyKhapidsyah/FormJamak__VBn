<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.tombolTampilkanForm = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tombolTampilkanForm
        '
        Me.tombolTampilkanForm.Location = New System.Drawing.Point(23, 39)
        Me.tombolTampilkanForm.Name = "tombolTampilkanForm"
        Me.tombolTampilkanForm.Size = New System.Drawing.Size(129, 40)
        Me.tombolTampilkanForm.TabIndex = 0
        Me.tombolTampilkanForm.Text = "Tampilkan Form"
        Me.tombolTampilkanForm.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(197, 39)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(129, 40)
        Me.tombolKeluar.TabIndex = 1
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 125)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolTampilkanForm)
        Me.Name = "FormUtama"
        Me.Text = "Latihan Form Jamak"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tombolTampilkanForm As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button

End Class
