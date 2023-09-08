<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtDatatype = New Button()
        Label1 = New Label()
        txtNum = New TextBox()
        SuspendLayout()
        ' 
        ' txtDatatype
        ' 
        txtDatatype.Location = New Point(465, 247)
        txtDatatype.Name = "txtDatatype"
        txtDatatype.Size = New Size(195, 34)
        txtDatatype.TabIndex = 0
        txtDatatype.Text = "Data Type"
        txtDatatype.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(147, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 25)
        Label1.TabIndex = 1
        Label1.Text = "Enter a Number"
        ' 
        ' txtNum
        ' 
        txtNum.Location = New Point(297, 103)
        txtNum.Name = "txtNum"
        txtNum.Size = New Size(150, 31)
        txtNum.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtNum)
        Controls.Add(Label1)
        Controls.Add(txtDatatype)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDatatype As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNum As TextBox
End Class
