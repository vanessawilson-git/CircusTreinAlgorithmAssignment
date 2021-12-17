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
        Me.TextBoxAnimalName = New System.Windows.Forms.TextBox()
        Me.LabelAnimalName = New System.Windows.Forms.Label()
        Me.RadioButtonCarnivore = New System.Windows.Forms.RadioButton()
        Me.RadioButtonHerbivore = New System.Windows.Forms.RadioButton()
        Me.DietLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButtonSmall = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMedium = New System.Windows.Forms.RadioButton()
        Me.RadioButtonLarge = New System.Windows.Forms.RadioButton()
        Me.TBLIstOfAnimalsToBeSorted = New System.Windows.Forms.TextBox()
        Me.LabelAnimalsToBeSortedList = New System.Windows.Forms.Label()
        Me.ButtonAddAnimal = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonClearList = New System.Windows.Forms.Button()
        Me.LabelWagonsSorted = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.SuspendLayout
        '
        'TextBoxAnimalName
        '
        Me.TextBoxAnimalName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBoxAnimalName.Location = New System.Drawing.Point(17, 53)
        Me.TextBoxAnimalName.Multiline = true
        Me.TextBoxAnimalName.Name = "TextBoxAnimalName"
        Me.TextBoxAnimalName.Size = New System.Drawing.Size(200, 38)
        Me.TextBoxAnimalName.TabIndex = 0
        '
        'LabelAnimalName
        '
        Me.LabelAnimalName.AutoSize = true
        Me.LabelAnimalName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelAnimalName.Location = New System.Drawing.Point(12, 24)
        Me.LabelAnimalName.Name = "LabelAnimalName"
        Me.LabelAnimalName.Size = New System.Drawing.Size(151, 26)
        Me.LabelAnimalName.TabIndex = 1
        Me.LabelAnimalName.Text = "Name Animal:"
        '
        'RadioButtonCarnivore
        '
        Me.RadioButtonCarnivore.AutoSize = true
        Me.RadioButtonCarnivore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.RadioButtonCarnivore.Location = New System.Drawing.Point(6, 19)
        Me.RadioButtonCarnivore.Name = "RadioButtonCarnivore"
        Me.RadioButtonCarnivore.Size = New System.Drawing.Size(94, 24)
        Me.RadioButtonCarnivore.TabIndex = 2
        Me.RadioButtonCarnivore.TabStop = true
        Me.RadioButtonCarnivore.Text = "Carnivore"
        Me.RadioButtonCarnivore.UseVisualStyleBackColor = true
        '
        'RadioButtonHerbivore
        '
        Me.RadioButtonHerbivore.AutoSize = true
        Me.RadioButtonHerbivore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.RadioButtonHerbivore.Location = New System.Drawing.Point(6, 49)
        Me.RadioButtonHerbivore.Name = "RadioButtonHerbivore"
        Me.RadioButtonHerbivore.Size = New System.Drawing.Size(95, 24)
        Me.RadioButtonHerbivore.TabIndex = 3
        Me.RadioButtonHerbivore.TabStop = true
        Me.RadioButtonHerbivore.Text = "Herbivore"
        Me.RadioButtonHerbivore.UseVisualStyleBackColor = true
        '
        'DietLabel
        '
        Me.DietLabel.AutoSize = true
        Me.DietLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.DietLabel.Location = New System.Drawing.Point(12, 105)
        Me.DietLabel.Name = "DietLabel"
        Me.DietLabel.Size = New System.Drawing.Size(57, 26)
        Me.DietLabel.TabIndex = 4
        Me.DietLabel.Text = "Diet:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonCarnivore)
        Me.GroupBox1.Controls.Add(Me.RadioButtonHerbivore)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = false
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButtonLarge)
        Me.GroupBox2.Controls.Add(Me.RadioButtonMedium)
        Me.GroupBox2.Controls.Add(Me.RadioButtonSmall)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 291)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 119)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Size:"
        '
        'RadioButtonSmall
        '
        Me.RadioButtonSmall.AutoSize = true
        Me.RadioButtonSmall.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.RadioButtonSmall.Location = New System.Drawing.Point(6, 19)
        Me.RadioButtonSmall.Name = "RadioButtonSmall"
        Me.RadioButtonSmall.Size = New System.Drawing.Size(66, 24)
        Me.RadioButtonSmall.TabIndex = 4
        Me.RadioButtonSmall.TabStop = true
        Me.RadioButtonSmall.Text = "Small"
        Me.RadioButtonSmall.UseVisualStyleBackColor = true
        '
        'RadioButtonMedium
        '
        Me.RadioButtonMedium.AutoSize = true
        Me.RadioButtonMedium.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.RadioButtonMedium.Location = New System.Drawing.Point(6, 49)
        Me.RadioButtonMedium.Name = "RadioButtonMedium"
        Me.RadioButtonMedium.Size = New System.Drawing.Size(83, 24)
        Me.RadioButtonMedium.TabIndex = 5
        Me.RadioButtonMedium.TabStop = true
        Me.RadioButtonMedium.Text = "Medium"
        Me.RadioButtonMedium.UseVisualStyleBackColor = true
        '
        'RadioButtonLarge
        '
        Me.RadioButtonLarge.AutoSize = true
        Me.RadioButtonLarge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.RadioButtonLarge.Location = New System.Drawing.Point(6, 79)
        Me.RadioButtonLarge.Name = "RadioButtonLarge"
        Me.RadioButtonLarge.Size = New System.Drawing.Size(68, 24)
        Me.RadioButtonLarge.TabIndex = 6
        Me.RadioButtonLarge.TabStop = true
        Me.RadioButtonLarge.Text = "Large"
        Me.RadioButtonLarge.UseVisualStyleBackColor = true
        '
        'TBLIstOfAnimalsToBeSorted
        '
        Me.TBLIstOfAnimalsToBeSorted.Location = New System.Drawing.Point(331, 53)
        Me.TBLIstOfAnimalsToBeSorted.Multiline = true
        Me.TBLIstOfAnimalsToBeSorted.Name = "TBLIstOfAnimalsToBeSorted"
        Me.TBLIstOfAnimalsToBeSorted.Size = New System.Drawing.Size(152, 357)
        Me.TBLIstOfAnimalsToBeSorted.TabIndex = 8
        '
        'LabelAnimalsToBeSortedList
        '
        Me.LabelAnimalsToBeSortedList.AutoSize = true
        Me.LabelAnimalsToBeSortedList.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelAnimalsToBeSortedList.Location = New System.Drawing.Point(326, 24)
        Me.LabelAnimalsToBeSortedList.Name = "LabelAnimalsToBeSortedList"
        Me.LabelAnimalsToBeSortedList.Size = New System.Drawing.Size(97, 26)
        Me.LabelAnimalsToBeSortedList.TabIndex = 9
        Me.LabelAnimalsToBeSortedList.Text = "Animals:"
        '
        'ButtonAddAnimal
        '
        Me.ButtonAddAnimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ButtonAddAnimal.Location = New System.Drawing.Point(223, 296)
        Me.ButtonAddAnimal.Name = "ButtonAddAnimal"
        Me.ButtonAddAnimal.Size = New System.Drawing.Size(102, 38)
        Me.ButtonAddAnimal.TabIndex = 10
        Me.ButtonAddAnimal.Text = "Add Animal"
        Me.ButtonAddAnimal.UseVisualStyleBackColor = true
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(508, 53)
        Me.TextBox1.Multiline = true
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(269, 357)
        Me.TextBox1.TabIndex = 11
        '
        'ButtonClearList
        '
        Me.ButtonClearList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ButtonClearList.Location = New System.Drawing.Point(223, 340)
        Me.ButtonClearList.Name = "ButtonClearList"
        Me.ButtonClearList.Size = New System.Drawing.Size(102, 38)
        Me.ButtonClearList.TabIndex = 12
        Me.ButtonClearList.Text = "Clear List"
        Me.ButtonClearList.UseVisualStyleBackColor = true
        '
        'LabelWagonsSorted
        '
        Me.LabelWagonsSorted.AutoSize = true
        Me.LabelWagonsSorted.Font = New System.Drawing.Font("Microsoft Sans Serif", 16!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelWagonsSorted.Location = New System.Drawing.Point(503, 24)
        Me.LabelWagonsSorted.Name = "LabelWagonsSorted"
        Me.LabelWagonsSorted.Size = New System.Drawing.Size(98, 26)
        Me.LabelWagonsSorted.TabIndex = 13
        Me.LabelWagonsSorted.Text = "Wagons:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelWagonsSorted)
        Me.Controls.Add(Me.ButtonClearList)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ButtonAddAnimal)
        Me.Controls.Add(Me.LabelAnimalsToBeSortedList)
        Me.Controls.Add(Me.TBLIstOfAnimalsToBeSorted)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DietLabel)
        Me.Controls.Add(Me.LabelAnimalName)
        Me.Controls.Add(Me.TextBoxAnimalName)
        Me.Name = "Form1"
        Me.Text = "CircusTrein"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents TextBoxAnimalName As TextBox
    Friend WithEvents LabelAnimalName As Label
    Friend WithEvents RadioButtonCarnivore As RadioButton
    Friend WithEvents RadioButtonHerbivore As RadioButton
    Friend WithEvents DietLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButtonLarge As RadioButton
    Friend WithEvents RadioButtonMedium As RadioButton
    Friend WithEvents RadioButtonSmall As RadioButton
    Friend WithEvents TBLIstOfAnimalsToBeSorted As TextBox
    Friend WithEvents LabelAnimalsToBeSortedList As Label
    Friend WithEvents ButtonAddAnimal As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonClearList As Button
    Friend WithEvents LabelWagonsSorted As Label
End Class
