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
        txtValor = New TextBox()
        txtResultado = New TextBox()
        cmbUnidadOrigen = New ComboBox()
        cmbUnidadDestino = New ComboBox()
        btnConvertir = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(486, 146)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(162, 23)
        txtValor.TabIndex = 0
        ' 
        ' txtResultado
        ' 
        txtResultado.Location = New Point(486, 188)
        txtResultado.Name = "txtResultado"
        txtResultado.Size = New Size(162, 23)
        txtResultado.TabIndex = 1
        ' 
        ' cmbUnidadOrigen
        ' 
        cmbUnidadOrigen.FormattingEnabled = True
        cmbUnidadOrigen.Location = New Point(195, 146)
        cmbUnidadOrigen.Name = "cmbUnidadOrigen"
        cmbUnidadOrigen.Size = New Size(121, 23)
        cmbUnidadOrigen.TabIndex = 2
        ' 
        ' cmbUnidadDestino
        ' 
        cmbUnidadDestino.FormattingEnabled = True
        cmbUnidadDestino.Location = New Point(195, 188)
        cmbUnidadDestino.Name = "cmbUnidadDestino"
        cmbUnidadDestino.Size = New Size(121, 23)
        cmbUnidadDestino.TabIndex = 3
        ' 
        ' btnConvertir
        ' 
        btnConvertir.ForeColor = Color.IndianRed
        btnConvertir.Location = New Point(371, 237)
        btnConvertir.Name = "btnConvertir"
        btnConvertir.Size = New Size(75, 23)
        btnConvertir.TabIndex = 4
        btnConvertir.Text = "Calcular"
        btnConvertir.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.IndianRed
        Label1.Location = New Point(364, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 15)
        Label1.TabIndex = 5
        Label1.Text = "Cantidad a Convertir"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.IndianRed
        Label2.Location = New Point(421, 191)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 6
        Label2.Text = "Resultado"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.IndianRed
        Label3.Location = New Point(234, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(333, 36)
        Label3.TabIndex = 7
        Label3.Text = "Conversor de Unidades"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.IndianRed
        Label4.Location = New Point(65, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 15)
        Label4.TabIndex = 8
        Label4.Text = "Unidad de Conversion"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.IndianRed
        Label5.Location = New Point(83, 191)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 15)
        Label5.TabIndex = 9
        Label5.Text = "Unidad a Convertir"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._76cbb9c840da886e5dc35e33ba870230
        PictureBox1.Location = New Point(351, 266)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(115, 107)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.unidades_de_longitud
        PictureBox2.Location = New Point(592, 226)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(138, 137)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.images__3_
        PictureBox3.Location = New Point(100, 226)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(137, 137)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 12
        PictureBox3.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnConvertir)
        Controls.Add(cmbUnidadDestino)
        Controls.Add(cmbUnidadOrigen)
        Controls.Add(txtResultado)
        Controls.Add(txtValor)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents cmbUnidadOrigen As ComboBox
    Friend WithEvents cmbUnidadDestino As ComboBox
    Friend WithEvents btnConvertir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox

End Class
