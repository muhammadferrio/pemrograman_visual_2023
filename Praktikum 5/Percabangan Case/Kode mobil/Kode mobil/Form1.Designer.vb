﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKodeMobil = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Mobil"
        '
        'txtKodeMobil
        '
        Me.txtKodeMobil.Location = New System.Drawing.Point(8, 39)
        Me.txtKodeMobil.Name = "txtKodeMobil"
        Me.txtKodeMobil.Size = New System.Drawing.Size(196, 22)
        Me.txtKodeMobil.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(226, 39)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(130, 40)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Keterangan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(142, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "M.Ferrio Nur Widodo"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(8, 178)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(196, 22)
        Me.txtKeterangan.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 372)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtKodeMobil)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Kode Mobil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtKodeMobil As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKeterangan As TextBox
End Class
