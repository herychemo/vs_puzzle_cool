<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_play = New System.Windows.Forms.Button()
        Me.btn_stats = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu"
        '
        'btn_play
        '
        Me.btn_play.Location = New System.Drawing.Point(37, 80)
        Me.btn_play.Name = "btn_play"
        Me.btn_play.Size = New System.Drawing.Size(135, 48)
        Me.btn_play.TabIndex = 1
        Me.btn_play.Text = "Jugar"
        Me.btn_play.UseVisualStyleBackColor = True
        '
        'btn_stats
        '
        Me.btn_stats.Location = New System.Drawing.Point(220, 80)
        Me.btn_stats.Name = "btn_stats"
        Me.btn_stats.Size = New System.Drawing.Size(135, 48)
        Me.btn_stats.TabIndex = 2
        Me.btn_stats.Text = "Estadisticas"
        Me.btn_stats.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 158)
        Me.Controls.Add(Me.btn_stats)
        Me.Controls.Add(Me.btn_play)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_play As Button
    Friend WithEvents btn_stats As Button
End Class
