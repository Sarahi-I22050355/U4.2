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
        Me.lvInventory = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cbBrand = New System.Windows.Forms.ComboBox()
        Me.cbOS = New System.Windows.Forms.ComboBox()
        Me.cbProcessor = New System.Windows.Forms.ComboBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvInventory
        '
        Me.lvInventory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvInventory.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lvInventory.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lvInventory.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.lvInventory.Location = New System.Drawing.Point(4, 218)
        Me.lvInventory.Name = "lvInventory"
        Me.lvInventory.Size = New System.Drawing.Size(574, 242)
        Me.lvInventory.TabIndex = 0
        Me.lvInventory.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(118, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(110, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Brand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(107, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Model"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(4, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Operating System"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtPrice.Location = New System.Drawing.Point(190, 11)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(199, 33)
        Me.txtPrice.TabIndex = 5
        '
        'cbBrand
        '
        Me.cbBrand.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cbBrand.FormattingEnabled = True
        Me.cbBrand.Items.AddRange(New Object() {"HP", "Dell", "Lenovo", "ASUS", "Acer", "MSI", "Toshiba", "Samsung", "LG"})
        Me.cbBrand.Location = New System.Drawing.Point(190, 55)
        Me.cbBrand.Name = "cbBrand"
        Me.cbBrand.Size = New System.Drawing.Size(199, 33)
        Me.cbBrand.TabIndex = 7
        '
        'cbOS
        '
        Me.cbOS.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cbOS.FormattingEnabled = True
        Me.cbOS.Items.AddRange(New Object() {"Windows 10", "Windows 11", "Ubuntu", "Debian", "Fedora", "Red Hat", "Solaris"})
        Me.cbOS.Location = New System.Drawing.Point(190, 138)
        Me.cbOS.Name = "cbOS"
        Me.cbOS.Size = New System.Drawing.Size(199, 33)
        Me.cbOS.TabIndex = 9
        '
        'cbProcessor
        '
        Me.cbProcessor.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cbProcessor.FormattingEnabled = True
        Me.cbProcessor.Items.AddRange(New Object() {"Intel Core (Intel)", "AMD Ryzen (AMD)", "Qualcomm Snapdragon (Qualcomm)", "NVIDIA Tegra (NVIDIA)", "Samsung Exynos (Samsung)", "MediaTek Helio (MediaTek)", "IBM Power (IBM)", "VIA Nano (VIA Technologies)", "ARM Cortex (ARM)", "Rockchip RK (Rockchip)"})
        Me.cbProcessor.Location = New System.Drawing.Point(190, 179)
        Me.cbProcessor.Name = "cbProcessor"
        Me.cbProcessor.Size = New System.Drawing.Size(199, 33)
        Me.cbProcessor.TabIndex = 10
        '
        'txtModel
        '
        Me.txtModel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtModel.Location = New System.Drawing.Point(190, 96)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(199, 33)
        Me.txtModel.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(75, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Processor"
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnAdd.Location = New System.Drawing.Point(422, 90)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(107, 49)
        Me.BtnAdd.TabIndex = 13
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 472)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.cbProcessor)
        Me.Controls.Add(Me.cbOS)
        Me.Controls.Add(Me.cbBrand)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvInventory)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form1"
        Me.Text = "Phone Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvInventory As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cbBrand As ComboBox
    Friend WithEvents cbOS As ComboBox
    Friend WithEvents cbProcessor As ComboBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnAdd As Button
End Class
