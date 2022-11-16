<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_departments
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
        Me.btn_input = New System.Windows.Forms.Button()
        Me.btn_average = New System.Windows.Forms.Button()
        Me.grd_departments = New UJGrid.UJGrid()
        Me.btn_Rating = New System.Windows.Forms.Button()
        Me.btn_highest = New System.Windows.Forms.Button()
        Me.txt_rating = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_rating = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_input
        '
        Me.btn_input.Location = New System.Drawing.Point(12, 12)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(75, 23)
        Me.btn_input.TabIndex = 0
        Me.btn_input.Text = "Input"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'btn_average
        '
        Me.btn_average.Location = New System.Drawing.Point(12, 61)
        Me.btn_average.Name = "btn_average"
        Me.btn_average.Size = New System.Drawing.Size(75, 23)
        Me.btn_average.TabIndex = 2
        Me.btn_average.Text = "Average"
        Me.btn_average.UseVisualStyleBackColor = True
        '
        'grd_departments
        '
        Me.grd_departments.FixedCols = 1
        Me.grd_departments.FixedRows = 1
        Me.grd_departments.Location = New System.Drawing.Point(112, -3)
        Me.grd_departments.Name = "grd_departments"
        Me.grd_departments.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grd_departments.Size = New System.Drawing.Size(635, 139)
        Me.grd_departments.TabIndex = 3
        '
        'btn_Rating
        '
        Me.btn_Rating.Location = New System.Drawing.Point(12, 113)
        Me.btn_Rating.Name = "btn_Rating"
        Me.btn_Rating.Size = New System.Drawing.Size(75, 23)
        Me.btn_Rating.TabIndex = 4
        Me.btn_Rating.Text = "Rating"
        Me.btn_Rating.UseVisualStyleBackColor = True
        '
        'btn_highest
        '
        Me.btn_highest.Location = New System.Drawing.Point(12, 172)
        Me.btn_highest.Name = "btn_highest"
        Me.btn_highest.Size = New System.Drawing.Size(75, 23)
        Me.btn_highest.TabIndex = 5
        Me.btn_highest.Text = "Highest"
        Me.btn_highest.UseVisualStyleBackColor = True
        '
        'txt_rating
        '
        Me.txt_rating.Location = New System.Drawing.Point(459, 179)
        Me.txt_rating.Name = "txt_rating"
        Me.txt_rating.Size = New System.Drawing.Size(100, 20)
        Me.txt_rating.TabIndex = 6
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(220, 179)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(100, 20)
        Me.txt_name.TabIndex = 7
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(139, 182)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(38, 13)
        Me.lbl_name.TabIndex = 8
        Me.lbl_name.Text = "Name:"
        '
        'lbl_rating
        '
        Me.lbl_rating.AutoSize = True
        Me.lbl_rating.Location = New System.Drawing.Point(373, 186)
        Me.lbl_rating.Name = "lbl_rating"
        Me.lbl_rating.Size = New System.Drawing.Size(41, 13)
        Me.lbl_rating.TabIndex = 9
        Me.lbl_rating.Text = "Rating:"
        '
        'frm_departments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_rating)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_rating)
        Me.Controls.Add(Me.btn_highest)
        Me.Controls.Add(Me.btn_Rating)
        Me.Controls.Add(Me.grd_departments)
        Me.Controls.Add(Me.btn_average)
        Me.Controls.Add(Me.btn_input)
        Me.Name = "frm_departments"
        Me.Text = "Departments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_input As Button
    Friend WithEvents btn_average As Button
    Friend WithEvents grd_departments As UJGrid.UJGrid
    Friend WithEvents btn_Rating As Button
    Friend WithEvents btn_highest As Button
    Friend WithEvents txt_rating As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_rating As Label
End Class
