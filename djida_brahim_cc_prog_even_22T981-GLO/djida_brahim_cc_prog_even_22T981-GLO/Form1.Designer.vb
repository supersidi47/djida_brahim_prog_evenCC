<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBoxMedicaments = New System.Windows.Forms.ListBox()
        Me.TextBoxNomMedicament = New System.Windows.Forms.TextBox()
        Me.ButtonSupprimer = New System.Windows.Forms.Button()
        Me.ButtonModifier = New System.Windows.Forms.Button()
        Me.ButtonAjouter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBoxMedicaments
        '
        Me.ListBoxMedicaments.FormattingEnabled = True
        Me.ListBoxMedicaments.Location = New System.Drawing.Point(67, 171)
        Me.ListBoxMedicaments.Name = "ListBoxMedicaments"
        Me.ListBoxMedicaments.Size = New System.Drawing.Size(534, 212)
        Me.ListBoxMedicaments.TabIndex = 0
        '
        'TextBoxNomMedicament
        '
        Me.TextBoxNomMedicament.Font = New System.Drawing.Font("Poppins Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNomMedicament.Location = New System.Drawing.Point(67, 109)
        Me.TextBoxNomMedicament.Name = "TextBoxNomMedicament"
        Me.TextBoxNomMedicament.Size = New System.Drawing.Size(206, 36)
        Me.TextBoxNomMedicament.TabIndex = 1
        '
        'ButtonSupprimer
        '
        Me.ButtonSupprimer.BackColor = System.Drawing.Color.Red
        Me.ButtonSupprimer.Location = New System.Drawing.Point(504, 109)
        Me.ButtonSupprimer.Name = "ButtonSupprimer"
        Me.ButtonSupprimer.Size = New System.Drawing.Size(97, 36)
        Me.ButtonSupprimer.TabIndex = 2
        Me.ButtonSupprimer.Text = "supprimer"
        Me.ButtonSupprimer.UseVisualStyleBackColor = False
        '
        'ButtonModifier
        '
        Me.ButtonModifier.BackColor = System.Drawing.SystemColors.Highlight
        Me.ButtonModifier.Location = New System.Drawing.Point(401, 109)
        Me.ButtonModifier.Name = "ButtonModifier"
        Me.ButtonModifier.Size = New System.Drawing.Size(97, 36)
        Me.ButtonModifier.TabIndex = 3
        Me.ButtonModifier.Text = "Modifier"
        Me.ButtonModifier.UseVisualStyleBackColor = False
        '
        'ButtonAjouter
        '
        Me.ButtonAjouter.BackColor = System.Drawing.Color.Lime
        Me.ButtonAjouter.Location = New System.Drawing.Point(298, 109)
        Me.ButtonAjouter.Name = "ButtonAjouter"
        Me.ButtonAjouter.Size = New System.Drawing.Size(97, 36)
        Me.ButtonAjouter.TabIndex = 4
        Me.ButtonAjouter.Text = "Ajouter"
        Me.ButtonAjouter.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Royal Acid", 47.99999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label1.Location = New System.Drawing.Point(108, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 76)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PHARMAGIT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 34)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nom"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(654, 427)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonAjouter)
        Me.Controls.Add(Me.ButtonModifier)
        Me.Controls.Add(Me.ButtonSupprimer)
        Me.Controls.Add(Me.TextBoxNomMedicament)
        Me.Controls.Add(Me.ListBoxMedicaments)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxMedicaments As ListBox
    Friend WithEvents TextBoxNomMedicament As TextBox
    Friend WithEvents ButtonSupprimer As Button
    Friend WithEvents ButtonModifier As Button
    Friend WithEvents ButtonAjouter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
