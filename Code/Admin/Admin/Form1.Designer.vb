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
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BCall = New System.Windows.Forms.Button()
        Me.Bclear = New System.Windows.Forms.Button()
        Me.BEnd = New System.Windows.Forms.Button()
        Me.B1 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.B4 = New System.Windows.Forms.Button()
        Me.B5 = New System.Windows.Forms.Button()
        Me.B6 = New System.Windows.Forms.Button()
        Me.B7 = New System.Windows.Forms.Button()
        Me.B8 = New System.Windows.Forms.Button()
        Me.B9 = New System.Windows.Forms.Button()
        Me.Star = New System.Windows.Forms.Button()
        Me.B0 = New System.Windows.Forms.Button()
        Me.Hash = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContestantDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VotingDBDataSet = New WindowsApplication1.VotingDBDataSet()
        Me.ContestantDBTableAdapter = New WindowsApplication1.VotingDBDataSetTableAdapters.ContestantDBTableAdapter()
        Me.MSVDDataSet = New WindowsApplication1.MSVDDataSet()
        Me.MSVDDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MSVDDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MSVDDataSetBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContestantNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContestantnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConstituencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContestantDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VotingDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSVDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSVDDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSVDDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSVDDataSetBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(285, 53)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BCall
        '
        Me.BCall.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCall.Location = New System.Drawing.Point(12, 81)
        Me.BCall.Name = "BCall"
        Me.BCall.Size = New System.Drawing.Size(86, 35)
        Me.BCall.TabIndex = 1
        Me.BCall.Text = "Call"
        Me.BCall.UseVisualStyleBackColor = True
        '
        'Bclear
        '
        Me.Bclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bclear.Location = New System.Drawing.Point(104, 81)
        Me.Bclear.Name = "Bclear"
        Me.Bclear.Size = New System.Drawing.Size(98, 35)
        Me.Bclear.TabIndex = 1
        Me.Bclear.Text = "Clear"
        Me.Bclear.UseVisualStyleBackColor = True
        '
        'BEnd
        '
        Me.BEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEnd.ForeColor = System.Drawing.Color.Red
        Me.BEnd.Location = New System.Drawing.Point(208, 81)
        Me.BEnd.Name = "BEnd"
        Me.BEnd.Size = New System.Drawing.Size(89, 35)
        Me.BEnd.TabIndex = 1
        Me.BEnd.Text = "END"
        Me.BEnd.UseVisualStyleBackColor = True
        '
        'B1
        '
        Me.B1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B1.Location = New System.Drawing.Point(12, 122)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(86, 35)
        Me.B1.TabIndex = 1
        Me.B1.Text = "1"
        Me.B1.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B2.Location = New System.Drawing.Point(104, 122)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(98, 35)
        Me.B2.TabIndex = 1
        Me.B2.Text = "2"
        Me.B2.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B3.Location = New System.Drawing.Point(208, 122)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(89, 35)
        Me.B3.TabIndex = 1
        Me.B3.Text = "3"
        Me.B3.UseVisualStyleBackColor = True
        '
        'B4
        '
        Me.B4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B4.Location = New System.Drawing.Point(12, 163)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(86, 35)
        Me.B4.TabIndex = 1
        Me.B4.Text = "4"
        Me.B4.UseVisualStyleBackColor = True
        '
        'B5
        '
        Me.B5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B5.Location = New System.Drawing.Point(104, 163)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(98, 35)
        Me.B5.TabIndex = 1
        Me.B5.Text = "5"
        Me.B5.UseVisualStyleBackColor = True
        '
        'B6
        '
        Me.B6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B6.Location = New System.Drawing.Point(208, 163)
        Me.B6.Name = "B6"
        Me.B6.Size = New System.Drawing.Size(89, 35)
        Me.B6.TabIndex = 1
        Me.B6.Text = "6"
        Me.B6.UseVisualStyleBackColor = True
        '
        'B7
        '
        Me.B7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B7.Location = New System.Drawing.Point(12, 204)
        Me.B7.Name = "B7"
        Me.B7.Size = New System.Drawing.Size(86, 35)
        Me.B7.TabIndex = 1
        Me.B7.Text = "7"
        Me.B7.UseVisualStyleBackColor = True
        '
        'B8
        '
        Me.B8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B8.Location = New System.Drawing.Point(104, 204)
        Me.B8.Name = "B8"
        Me.B8.Size = New System.Drawing.Size(98, 35)
        Me.B8.TabIndex = 1
        Me.B8.Text = "8"
        Me.B8.UseVisualStyleBackColor = True
        '
        'B9
        '
        Me.B9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B9.Location = New System.Drawing.Point(208, 204)
        Me.B9.Name = "B9"
        Me.B9.Size = New System.Drawing.Size(89, 35)
        Me.B9.TabIndex = 1
        Me.B9.Text = "9"
        Me.B9.UseVisualStyleBackColor = True
        '
        'Star
        '
        Me.Star.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Star.Location = New System.Drawing.Point(12, 245)
        Me.Star.Name = "Star"
        Me.Star.Size = New System.Drawing.Size(86, 35)
        Me.Star.TabIndex = 1
        Me.Star.Text = "*"
        Me.Star.UseVisualStyleBackColor = True
        '
        'B0
        '
        Me.B0.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B0.Location = New System.Drawing.Point(104, 245)
        Me.B0.Name = "B0"
        Me.B0.Size = New System.Drawing.Size(98, 35)
        Me.B0.TabIndex = 1
        Me.B0.Text = "0"
        Me.B0.UseVisualStyleBackColor = True
        '
        'Hash
        '
        Me.Hash.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hash.Location = New System.Drawing.Point(208, 245)
        Me.Hash.Name = "Hash"
        Me.Hash.Size = New System.Drawing.Size(89, 35)
        Me.Hash.TabIndex = 1
        Me.Hash.Text = "#"
        Me.Hash.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(9, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Your Number:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(12, 318)
        Me.TextBox2.MaxLength = 10
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(285, 53)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ContestantNameDataGridViewTextBoxColumn, Me.ContestantnoDataGridViewTextBoxColumn, Me.ConIDDataGridViewTextBoxColumn, Me.ConstituencyDataGridViewTextBoxColumn, Me.PostDataGridViewTextBoxColumn, Me.PartyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ContestantDBBindingSource
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(303, 12)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(357, 359)
        Me.DataGridView1.TabIndex = 4
        '
        'ContestantDBBindingSource
        '
        Me.ContestantDBBindingSource.DataMember = "ContestantDB"
        Me.ContestantDBBindingSource.DataSource = Me.VotingDBDataSet
        '
        'VotingDBDataSet
        '
        Me.VotingDBDataSet.DataSetName = "VotingDBDataSet"
        Me.VotingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContestantDBTableAdapter
        '
        Me.ContestantDBTableAdapter.ClearBeforeFill = True
        '
        'MSVDDataSet
        '
        Me.MSVDDataSet.DataSetName = "MSVDDataSet"
        Me.MSVDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MSVDDataSetBindingSource
        '
        Me.MSVDDataSetBindingSource.DataSource = Me.MSVDDataSet
        Me.MSVDDataSetBindingSource.Position = 0
        '
        'MSVDDataSetBindingSource1
        '
        Me.MSVDDataSetBindingSource1.DataSource = Me.MSVDDataSet
        Me.MSVDDataSetBindingSource1.Position = 0
        '
        'MSVDDataSetBindingSource2
        '
        Me.MSVDDataSetBindingSource2.DataSource = Me.MSVDDataSet
        Me.MSVDDataSetBindingSource2.Position = 0
        '
        'ContestantNameDataGridViewTextBoxColumn
        '
        Me.ContestantNameDataGridViewTextBoxColumn.DataPropertyName = "ContestantName"
        Me.ContestantNameDataGridViewTextBoxColumn.HeaderText = "ContestantName"
        Me.ContestantNameDataGridViewTextBoxColumn.Name = "ContestantNameDataGridViewTextBoxColumn"
        Me.ContestantNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContestantNameDataGridViewTextBoxColumn.Width = 111
        '
        'ContestantnoDataGridViewTextBoxColumn
        '
        Me.ContestantnoDataGridViewTextBoxColumn.DataPropertyName = "Contestantno"
        Me.ContestantnoDataGridViewTextBoxColumn.HeaderText = "Contestantno"
        Me.ContestantnoDataGridViewTextBoxColumn.Name = "ContestantnoDataGridViewTextBoxColumn"
        Me.ContestantnoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContestantnoDataGridViewTextBoxColumn.Width = 95
        '
        'ConIDDataGridViewTextBoxColumn
        '
        Me.ConIDDataGridViewTextBoxColumn.DataPropertyName = "ConID"
        Me.ConIDDataGridViewTextBoxColumn.HeaderText = "ConID"
        Me.ConIDDataGridViewTextBoxColumn.Name = "ConIDDataGridViewTextBoxColumn"
        Me.ConIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConIDDataGridViewTextBoxColumn.Width = 62
        '
        'ConstituencyDataGridViewTextBoxColumn
        '
        Me.ConstituencyDataGridViewTextBoxColumn.DataPropertyName = "Constituency"
        Me.ConstituencyDataGridViewTextBoxColumn.HeaderText = "Constituency"
        Me.ConstituencyDataGridViewTextBoxColumn.Name = "ConstituencyDataGridViewTextBoxColumn"
        Me.ConstituencyDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConstituencyDataGridViewTextBoxColumn.Width = 93
        '
        'PostDataGridViewTextBoxColumn
        '
        Me.PostDataGridViewTextBoxColumn.DataPropertyName = "Post"
        Me.PostDataGridViewTextBoxColumn.HeaderText = "Post"
        Me.PostDataGridViewTextBoxColumn.Name = "PostDataGridViewTextBoxColumn"
        Me.PostDataGridViewTextBoxColumn.ReadOnly = True
        Me.PostDataGridViewTextBoxColumn.Width = 53
        '
        'PartyDataGridViewTextBoxColumn
        '
        Me.PartyDataGridViewTextBoxColumn.DataPropertyName = "Party"
        Me.PartyDataGridViewTextBoxColumn.HeaderText = "Party"
        Me.PartyDataGridViewTextBoxColumn.Name = "PartyDataGridViewTextBoxColumn"
        Me.PartyDataGridViewTextBoxColumn.ReadOnly = True
        Me.PartyDataGridViewTextBoxColumn.Width = 56
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 377)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Hash)
        Me.Controls.Add(Me.B9)
        Me.Controls.Add(Me.B6)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B0)
        Me.Controls.Add(Me.BEnd)
        Me.Controls.Add(Me.B8)
        Me.Controls.Add(Me.B5)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.Star)
        Me.Controls.Add(Me.Bclear)
        Me.Controls.Add(Me.B7)
        Me.Controls.Add(Me.B4)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.BCall)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Mobile"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContestantDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VotingDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSVDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSVDDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSVDDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSVDDataSetBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BCall As System.Windows.Forms.Button
    Friend WithEvents Bclear As System.Windows.Forms.Button
    Friend WithEvents BEnd As System.Windows.Forms.Button
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents B2 As System.Windows.Forms.Button
    Friend WithEvents B3 As System.Windows.Forms.Button
    Friend WithEvents B4 As System.Windows.Forms.Button
    Friend WithEvents B5 As System.Windows.Forms.Button
    Friend WithEvents B6 As System.Windows.Forms.Button
    Friend WithEvents B7 As System.Windows.Forms.Button
    Friend WithEvents B8 As System.Windows.Forms.Button
    Friend WithEvents B9 As System.Windows.Forms.Button
    Friend WithEvents Star As System.Windows.Forms.Button
    Friend WithEvents B0 As System.Windows.Forms.Button
    Friend WithEvents Hash As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents VotingDBDataSet As WindowsApplication1.VotingDBDataSet
    Friend WithEvents ContestantDBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContestantDBTableAdapter As WindowsApplication1.VotingDBDataSetTableAdapters.ContestantDBTableAdapter
    Friend WithEvents MSVDDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MSVDDataSet As WindowsApplication1.MSVDDataSet
    Friend WithEvents MSVDDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MSVDDataSetBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ContestantNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContestantnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConstituencyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PartyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
