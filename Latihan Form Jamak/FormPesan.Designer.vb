﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPesan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tombolTutup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selamat Ulang Tahun!"
        '
        'tombolTutup
        '
        Me.tombolTutup.Location = New System.Drawing.Point(109, 87)
        Me.tombolTutup.Name = "tombolTutup"
        Me.tombolTutup.Size = New System.Drawing.Size(91, 31)
        Me.tombolTutup.TabIndex = 1
        Me.tombolTutup.Text = "Tutup"
        Me.tombolTutup.UseVisualStyleBackColor = True
        '
        'FormPesan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 130)
        Me.Controls.Add(Me.tombolTutup)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPesan"
        Me.Text = "Sebuah Pesan Bagi Anda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tombolTutup As System.Windows.Forms.Button
End Class
