<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Num1 = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Num2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsuma = New System.Windows.Forms.Button()
        Me.btnresta = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnmultiplicación = New System.Windows.Forms.Button()
        Me.btndivision = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Num1
        '
        Me.Num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num1.Location = New System.Drawing.Point(402, 37)
        Me.Num1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(1017, 45)
        Me.Num1.TabIndex = 0
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(56, 43)
        Me.Label.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(247, 39)
        Me.Label.TabIndex = 1
        Me.Label.Text = "Primer Numero"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1219, 483)
        Me.Button1.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 81)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Duplica el numeor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1213, 237)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Resultado"
        '
        'Num2
        '
        Me.Num2.Location = New System.Drawing.Point(402, 117)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(1017, 38)
        Me.Num2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Segundo numero"
        '
        'btnsuma
        '
        Me.btnsuma.Location = New System.Drawing.Point(69, 223)
        Me.btnsuma.Name = "btnsuma"
        Me.btnsuma.Size = New System.Drawing.Size(214, 45)
        Me.btnsuma.TabIndex = 6
        Me.btnsuma.Text = "Suma"
        Me.btnsuma.UseVisualStyleBackColor = True
        '
        'btnresta
        '
        Me.btnresta.Location = New System.Drawing.Point(69, 294)
        Me.btnresta.Name = "btnresta"
        Me.btnresta.Size = New System.Drawing.Size(214, 45)
        Me.btnresta.TabIndex = 7
        Me.btnresta.Text = "Resta"
        Me.btnresta.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1275, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 31)
        Me.Label3.TabIndex = 8
        '
        'btnmultiplicación
        '
        Me.btnmultiplicación.Location = New System.Drawing.Point(69, 355)
        Me.btnmultiplicación.Name = "btnmultiplicación"
        Me.btnmultiplicación.Size = New System.Drawing.Size(214, 40)
        Me.btnmultiplicación.TabIndex = 9
        Me.btnmultiplicación.Text = "Multiplicación"
        Me.btnmultiplicación.UseVisualStyleBackColor = True
        '
        'btndivision
        '
        Me.btndivision.Location = New System.Drawing.Point(69, 421)
        Me.btndivision.Name = "btndivision"
        Me.btndivision.Size = New System.Drawing.Size(214, 38)
        Me.btndivision.TabIndex = 10
        Me.btndivision.Text = "Division"
        Me.btndivision.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1061)
        Me.Controls.Add(Me.btndivision)
        Me.Controls.Add(Me.btnmultiplicación)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnresta)
        Me.Controls.Add(Me.btnsuma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Num2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Num1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Num1 As TextBox
    Friend WithEvents Label As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Num2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnsuma As Button
    Friend WithEvents btnresta As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnmultiplicación As Button
    Friend WithEvents btndivision As Button
End Class
