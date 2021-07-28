<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControleForm
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
        Me.botaoExclur = New System.Windows.Forms.Button()
        Me.botaoEditar = New System.Windows.Forms.Button()
        Me.alunoTexto = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.botaoPesquisar = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.textMatricula = New System.Windows.Forms.TextBox()
        Me.textNome = New System.Windows.Forms.TextBox()
        Me.botaoLimpar = New System.Windows.Forms.Button()
        Me.botaoAdicionar = New System.Windows.Forms.Button()
        Me.textCpf = New System.Windows.Forms.TextBox()
        Me.textNascimento = New System.Windows.Forms.TextBox()
        Me.textSexo = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.boxSexo = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'botaoExclur
        '
        Me.botaoExclur.Location = New System.Drawing.Point(683, 415)
        Me.botaoExclur.Name = "botaoExclur"
        Me.botaoExclur.Size = New System.Drawing.Size(103, 23)
        Me.botaoExclur.TabIndex = 0
        Me.botaoExclur.Text = "Excluir"
        Me.botaoExclur.UseVisualStyleBackColor = True
        '
        'botaoEditar
        '
        Me.botaoEditar.Location = New System.Drawing.Point(572, 415)
        Me.botaoEditar.Name = "botaoEditar"
        Me.botaoEditar.Size = New System.Drawing.Size(105, 23)
        Me.botaoEditar.TabIndex = 1
        Me.botaoEditar.Text = "Editar"
        Me.botaoEditar.UseVisualStyleBackColor = True
        '
        'alunoTexto
        '
        Me.alunoTexto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.alunoTexto.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.alunoTexto.ForeColor = System.Drawing.Color.Black
        Me.alunoTexto.Location = New System.Drawing.Point(12, 12)
        Me.alunoTexto.Name = "alunoTexto"
        Me.alunoTexto.Size = New System.Drawing.Size(290, 17)
        Me.alunoTexto.TabIndex = 2
        Me.alunoTexto.Text = "Novo Aluno/ Editando aluno"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.MaskedTextBox5)
        Me.Panel1.Controls.Add(Me.boxSexo)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.MaskedTextBox4)
        Me.Panel1.Controls.Add(Me.textSexo)
        Me.Panel1.Controls.Add(Me.textNascimento)
        Me.Panel1.Controls.Add(Me.textCpf)
        Me.Panel1.Controls.Add(Me.botaoAdicionar)
        Me.Panel1.Controls.Add(Me.botaoLimpar)
        Me.Panel1.Controls.Add(Me.textNome)
        Me.Panel1.Controls.Add(Me.textMatricula)
        Me.Panel1.Controls.Add(Me.MaskedTextBox3)
        Me.Panel1.Controls.Add(Me.MaskedTextBox2)
        Me.Panel1.Location = New System.Drawing.Point(12, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(774, 154)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(12, 253)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(776, 147)
        Me.Panel2.TabIndex = 4
        '
        'botaoPesquisar
        '
        Me.botaoPesquisar.Location = New System.Drawing.Point(683, 224)
        Me.botaoPesquisar.Name = "botaoPesquisar"
        Me.botaoPesquisar.Size = New System.Drawing.Size(103, 23)
        Me.botaoPesquisar.TabIndex = 5
        Me.botaoPesquisar.Text = "Pesquisar"
        Me.botaoPesquisar.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(12, 224)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(626, 23)
        Me.MaskedTextBox1.TabIndex = 6
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(15, 20)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(112, 23)
        Me.MaskedTextBox2.TabIndex = 0
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Location = New System.Drawing.Point(154, 20)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(600, 23)
        Me.MaskedTextBox3.TabIndex = 1
        '
        'textMatricula
        '
        Me.textMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textMatricula.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textMatricula.Location = New System.Drawing.Point(15, 3)
        Me.textMatricula.Name = "textMatricula"
        Me.textMatricula.Size = New System.Drawing.Size(100, 17)
        Me.textMatricula.TabIndex = 2
        Me.textMatricula.Text = "Matrícula"
        '
        'textNome
        '
        Me.textNome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textNome.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textNome.Location = New System.Drawing.Point(154, 3)
        Me.textNome.Name = "textNome"
        Me.textNome.Size = New System.Drawing.Size(100, 17)
        Me.textNome.TabIndex = 3
        Me.textNome.Text = "Nome"
        '
        'botaoLimpar
        '
        Me.botaoLimpar.Location = New System.Drawing.Point(548, 106)
        Me.botaoLimpar.Name = "botaoLimpar"
        Me.botaoLimpar.Size = New System.Drawing.Size(100, 31)
        Me.botaoLimpar.TabIndex = 4
        Me.botaoLimpar.Text = "Limpar"
        Me.botaoLimpar.UseVisualStyleBackColor = True
        '
        'botaoAdicionar
        '
        Me.botaoAdicionar.Location = New System.Drawing.Point(654, 106)
        Me.botaoAdicionar.Name = "botaoAdicionar"
        Me.botaoAdicionar.Size = New System.Drawing.Size(100, 30)
        Me.botaoAdicionar.TabIndex = 5
        Me.botaoAdicionar.Text = "Adicionar"
        Me.botaoAdicionar.UseVisualStyleBackColor = True
        '
        'textCpf
        '
        Me.textCpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textCpf.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textCpf.ForeColor = System.Drawing.Color.Black
        Me.textCpf.Location = New System.Drawing.Point(357, 81)
        Me.textCpf.Name = "textCpf"
        Me.textCpf.Size = New System.Drawing.Size(100, 17)
        Me.textCpf.TabIndex = 6
        Me.textCpf.Text = "CPF"
        '
        'textNascimento
        '
        Me.textNascimento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textNascimento.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textNascimento.ForeColor = System.Drawing.Color.Black
        Me.textNascimento.Location = New System.Drawing.Point(154, 81)
        Me.textNascimento.Name = "textNascimento"
        Me.textNascimento.Size = New System.Drawing.Size(100, 17)
        Me.textNascimento.TabIndex = 7
        Me.textNascimento.Text = "Nascimento"
        '
        'textSexo
        '
        Me.textSexo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textSexo.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textSexo.ForeColor = System.Drawing.Color.Black
        Me.textSexo.Location = New System.Drawing.Point(15, 81)
        Me.textSexo.Name = "textSexo"
        Me.textSexo.Size = New System.Drawing.Size(100, 17)
        Me.textSexo.TabIndex = 8
        Me.textSexo.Text = "Sexo"
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.Location = New System.Drawing.Point(357, 106)
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(177, 23)
        Me.MaskedTextBox4.TabIndex = 9
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(100, 106)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(0, 23)
        Me.DateTimePicker1.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-1, -4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(776, 150)
        Me.DataGridView1.TabIndex = 11
        '
        'boxSexo
        '
        Me.boxSexo.BackColor = System.Drawing.SystemColors.Window
        Me.boxSexo.FormattingEnabled = True
        Me.boxSexo.Location = New System.Drawing.Point(3, 109)
        Me.boxSexo.Name = "boxSexo"
        Me.boxSexo.Size = New System.Drawing.Size(121, 23)
        Me.boxSexo.TabIndex = 12
        '
        'MaskedTextBox5
        '
        Me.MaskedTextBox5.Location = New System.Drawing.Point(154, 106)
        Me.MaskedTextBox5.Mask = "00/00/0000"
        Me.MaskedTextBox5.Name = "MaskedTextBox5"
        Me.MaskedTextBox5.Size = New System.Drawing.Size(177, 23)
        Me.MaskedTextBox5.TabIndex = 13
        Me.MaskedTextBox5.ValidatingType = GetType(Date)
        '
        'ControleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(798, 450)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.botaoPesquisar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.alunoTexto)
        Me.Controls.Add(Me.botaoEditar)
        Me.Controls.Add(Me.botaoExclur)
        Me.Name = "ControleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Controle de Aluno"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents botaoExclur As Button
    Friend WithEvents botaoEditar As Button
    Friend WithEvents alunoTexto As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents botaoPesquisar As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents textMatricula As TextBox
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents textCpf As TextBox
    Friend WithEvents botaoAdicionar As Button
    Friend WithEvents botaoLimpar As Button
    Friend WithEvents textNome As TextBox
    Friend WithEvents textSexo As TextBox
    Friend WithEvents textNascimento As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents boxSexo As ComboBox
    Friend WithEvents MaskedTextBox5 As MaskedTextBox
End Class
