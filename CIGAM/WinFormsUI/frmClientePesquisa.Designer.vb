<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientePesquisa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientePesquisa))
        btn_buscar = New Button()
        btn_novo = New Button()
        tbx_nome = New TextBox()
        tbx_cpf = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        dtgv_clientes = New DataGridView()
        EDIT = New DataGridViewImageColumn()
        GroupBox1 = New GroupBox()
        CType(dtgv_clientes, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btn_buscar
        ' 
        btn_buscar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_buscar.Location = New Point(628, 37)
        btn_buscar.Name = "btn_buscar"
        btn_buscar.Size = New Size(75, 23)
        btn_buscar.TabIndex = 1
        btn_buscar.Text = "Buscar"
        btn_buscar.UseVisualStyleBackColor = True
        ' 
        ' btn_novo
        ' 
        btn_novo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_novo.Location = New Point(709, 37)
        btn_novo.Name = "btn_novo"
        btn_novo.Size = New Size(75, 23)
        btn_novo.TabIndex = 2
        btn_novo.Text = "Novo"
        btn_novo.UseVisualStyleBackColor = True
        ' 
        ' tbx_nome
        ' 
        tbx_nome.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        tbx_nome.Location = New Point(15, 37)
        tbx_nome.Name = "tbx_nome"
        tbx_nome.Size = New Size(476, 23)
        tbx_nome.TabIndex = 3
        ' 
        ' tbx_cpf
        ' 
        tbx_cpf.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        tbx_cpf.Location = New Point(497, 37)
        tbx_cpf.MaxLength = 11
        tbx_cpf.Name = "tbx_cpf"
        tbx_cpf.Size = New Size(125, 23)
        tbx_cpf.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 15)
        Label2.TabIndex = 6
        Label2.Text = "Nome do Cliente:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(497, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 7
        Label3.Text = "CPF:"
        ' 
        ' dtgv_clientes
        ' 
        dtgv_clientes.AllowUserToAddRows = False
        dtgv_clientes.AllowUserToDeleteRows = False
        dtgv_clientes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dtgv_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dtgv_clientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders
        dtgv_clientes.BorderStyle = BorderStyle.Fixed3D
        dtgv_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgv_clientes.Columns.AddRange(New DataGridViewColumn() {EDIT})
        dtgv_clientes.Location = New Point(12, 77)
        dtgv_clientes.MultiSelect = False
        dtgv_clientes.Name = "dtgv_clientes"
        dtgv_clientes.ReadOnly = True
        dtgv_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgv_clientes.Size = New Size(790, 296)
        dtgv_clientes.TabIndex = 0
        ' 
        ' EDIT
        ' 
        EDIT.FillWeight = 20F
        EDIT.HeaderText = "EDIT"
        EDIT.Image = My.Resources.Resource1.lapis
        EDIT.Name = "EDIT"
        EDIT.ReadOnly = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(btn_novo)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(btn_buscar)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(tbx_nome)
        GroupBox1.Controls.Add(tbx_cpf)
        GroupBox1.Location = New Point(12, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(790, 69)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        ' 
        ' frmClientePesquisa
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(814, 385)
        Controls.Add(GroupBox1)
        Controls.Add(dtgv_clientes)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmClientePesquisa"
        Text = "Pesquisa de Clientes"
        CType(dtgv_clientes, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_novo As Button
    Friend WithEvents tbx_nome As TextBox
    Friend WithEvents tbx_cpf As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtgv_clientes As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents EDIT As DataGridViewImageColumn

End Class
