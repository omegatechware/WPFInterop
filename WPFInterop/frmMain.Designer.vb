<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.hstMain = New System.Windows.Forms.Integration.ElementHost()
        Me.txtXAML = New System.Windows.Forms.RichTextBox()
        Me.splMain = New System.Windows.Forms.SplitContainer()
        Me.lblXAML = New System.Windows.Forms.Label()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.lblOut = New System.Windows.Forms.Label()
        CType(Me.splMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splMain.Panel1.SuspendLayout()
        Me.splMain.Panel2.SuspendLayout()
        Me.splMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'hstMain
        '
        Me.hstMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hstMain.BackgroundImage = CType(resources.GetObject("hstMain.BackgroundImage"), System.Drawing.Image)
        Me.hstMain.Location = New System.Drawing.Point(3, 30)
        Me.hstMain.Name = "hstMain"
        Me.hstMain.Size = New System.Drawing.Size(662, 583)
        Me.hstMain.TabIndex = 5
        Me.hstMain.Child = Nothing
        '
        'txtXAML
        '
        Me.txtXAML.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtXAML.Font = New System.Drawing.Font("Courier New", 10.0!)
        Me.txtXAML.Location = New System.Drawing.Point(3, 30)
        Me.txtXAML.Name = "txtXAML"
        Me.txtXAML.Size = New System.Drawing.Size(338, 583)
        Me.txtXAML.TabIndex = 1
        Me.txtXAML.Text = resources.GetString("txtXAML.Text")
        '
        'splMain
        '
        Me.splMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splMain.Location = New System.Drawing.Point(12, 12)
        Me.splMain.Name = "splMain"
        '
        'splMain.Panel1
        '
        Me.splMain.Panel1.Controls.Add(Me.lblXAML)
        Me.splMain.Panel1.Controls.Add(Me.txtXAML)
        '
        'splMain.Panel2
        '
        Me.splMain.Panel2.Controls.Add(Me.cmdRefresh)
        Me.splMain.Panel2.Controls.Add(Me.lblOut)
        Me.splMain.Panel2.Controls.Add(Me.hstMain)
        Me.splMain.Size = New System.Drawing.Size(1034, 616)
        Me.splMain.SplitterDistance = 344
        Me.splMain.SplitterWidth = 7
        Me.splMain.TabIndex = 2
        '
        'lblXAML
        '
        Me.lblXAML.AutoSize = True
        Me.lblXAML.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblXAML.Location = New System.Drawing.Point(3, 6)
        Me.lblXAML.Name = "lblXAML"
        Me.lblXAML.Size = New System.Drawing.Size(72, 13)
        Me.lblXAML.TabIndex = 0
        Me.lblXAML.Text = "XAML Input"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRefresh.Location = New System.Drawing.Point(590, 3)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(75, 21)
        Me.cmdRefresh.TabIndex = 4
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'lblOut
        '
        Me.lblOut.AutoSize = True
        Me.lblOut.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblOut.Location = New System.Drawing.Point(3, 6)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(104, 13)
        Me.lblOut.TabIndex = 3
        Me.lblOut.Text = "Rendered Output"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 640)
        Me.Controls.Add(Me.splMain)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WPF Interop Testbed"
        Me.splMain.Panel1.ResumeLayout(False)
        Me.splMain.Panel1.PerformLayout()
        Me.splMain.Panel2.ResumeLayout(False)
        Me.splMain.Panel2.PerformLayout()
        CType(Me.splMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents hstMain As Integration.ElementHost
    Friend WithEvents txtXAML As RichTextBox
    Friend WithEvents splMain As SplitContainer
    Friend WithEvents lblXAML As Label
    Friend WithEvents cmdRefresh As Button
    Friend WithEvents lblOut As Label
End Class
