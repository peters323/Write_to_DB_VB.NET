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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContactName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContactTitle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRegion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostalCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.OliveDrab
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(120, 554)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 35)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtCustomerID
        '
        Me.txtCustomerID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CustomerID", True))
        Me.txtCustomerID.Location = New System.Drawing.Point(120, 59)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(353, 22)
        Me.txtCustomerID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer ID:"
        '
        'DataGridView
        '
        Me.DataGridView.AutoGenerateColumns = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.CompanyNameDataGridViewTextBoxColumn, Me.ContactNameDataGridViewTextBoxColumn, Me.ContactTitleDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.RegionDataGridViewTextBoxColumn, Me.PostalCodeDataGridViewTextBoxColumn, Me.CountryDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.FaxDataGridViewTextBoxColumn})
        Me.DataGridView.DataSource = Me.CustomerBindingSource
        Me.DataGridView.Location = New System.Drawing.Point(503, 59)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowHeadersWidth = 51
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.Size = New System.Drawing.Size(1087, 475)
        Me.DataGridView.TabIndex = 3
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.IndianRed
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(215, 554)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 35)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.SteelBlue
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(307, 554)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 35)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkViolet
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(399, 554)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 35)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Company Name:"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CompanyName", True))
        Me.txtCompanyName.Location = New System.Drawing.Point(120, 97)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(353, 22)
        Me.txtCompanyName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Contact Name:"
        '
        'txtContactName
        '
        Me.txtContactName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "ContactName", True))
        Me.txtContactName.Location = New System.Drawing.Point(120, 138)
        Me.txtContactName.Name = "txtContactName"
        Me.txtContactName.Size = New System.Drawing.Size(353, 22)
        Me.txtContactName.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Contact Title:"
        '
        'txtContactTitle
        '
        Me.txtContactTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "ContactTitle", True))
        Me.txtContactTitle.Location = New System.Drawing.Point(120, 173)
        Me.txtContactTitle.Name = "txtContactTitle"
        Me.txtContactTitle.Size = New System.Drawing.Size(353, 22)
        Me.txtContactTitle.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Address", True))
        Me.txtAddress.Location = New System.Drawing.Point(120, 214)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(353, 95)
        Me.txtAddress.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 346)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "City:"
        '
        'txtCity
        '
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "City", True))
        Me.txtCity.Location = New System.Drawing.Point(120, 346)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(129, 22)
        Me.txtCity.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 391)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Postal Code:"
        '
        'txtPostalCode
        '
        Me.txtPostalCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "PostalCode", True))
        Me.txtPostalCode.Location = New System.Drawing.Point(120, 391)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(129, 22)
        Me.txtPostalCode.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(273, 351)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Region:"
        '
        'txtRegion
        '
        Me.txtRegion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Region", True))
        Me.txtRegion.Location = New System.Drawing.Point(336, 348)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.Size = New System.Drawing.Size(137, 22)
        Me.txtRegion.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(273, 393)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Country:"
        '
        'txtCountry
        '
        Me.txtCountry.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Country", True))
        Me.txtCountry.Location = New System.Drawing.Point(336, 393)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(137, 22)
        Me.txtCountry.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 440)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 17)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Phone:"
        '
        'txtPhone
        '
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Phone", True))
        Me.txtPhone.Location = New System.Drawing.Point(120, 435)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(129, 22)
        Me.txtPhone.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(273, 440)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 17)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Fax:"
        '
        'txtFax
        '
        Me.txtFax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Fax", True))
        Me.txtFax.Location = New System.Drawing.Point(336, 435)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(137, 22)
        Me.txtFax.TabIndex = 10
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(Write_to_DB_VB.NET.Customer)
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.Width = 125
        '
        'CompanyNameDataGridViewTextBoxColumn
        '
        Me.CompanyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName"
        Me.CompanyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName"
        Me.CompanyNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CompanyNameDataGridViewTextBoxColumn.Name = "CompanyNameDataGridViewTextBoxColumn"
        Me.CompanyNameDataGridViewTextBoxColumn.Width = 125
        '
        'ContactNameDataGridViewTextBoxColumn
        '
        Me.ContactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName"
        Me.ContactNameDataGridViewTextBoxColumn.HeaderText = "ContactName"
        Me.ContactNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ContactNameDataGridViewTextBoxColumn.Name = "ContactNameDataGridViewTextBoxColumn"
        Me.ContactNameDataGridViewTextBoxColumn.Width = 125
        '
        'ContactTitleDataGridViewTextBoxColumn
        '
        Me.ContactTitleDataGridViewTextBoxColumn.DataPropertyName = "ContactTitle"
        Me.ContactTitleDataGridViewTextBoxColumn.HeaderText = "ContactTitle"
        Me.ContactTitleDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ContactTitleDataGridViewTextBoxColumn.Name = "ContactTitleDataGridViewTextBoxColumn"
        Me.ContactTitleDataGridViewTextBoxColumn.Width = 125
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 125
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.Width = 125
        '
        'RegionDataGridViewTextBoxColumn
        '
        Me.RegionDataGridViewTextBoxColumn.DataPropertyName = "Region"
        Me.RegionDataGridViewTextBoxColumn.HeaderText = "Region"
        Me.RegionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RegionDataGridViewTextBoxColumn.Name = "RegionDataGridViewTextBoxColumn"
        Me.RegionDataGridViewTextBoxColumn.Width = 125
        '
        'PostalCodeDataGridViewTextBoxColumn
        '
        Me.PostalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode"
        Me.PostalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode"
        Me.PostalCodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PostalCodeDataGridViewTextBoxColumn.Name = "PostalCodeDataGridViewTextBoxColumn"
        Me.PostalCodeDataGridViewTextBoxColumn.Width = 125
        '
        'CountryDataGridViewTextBoxColumn
        '
        Me.CountryDataGridViewTextBoxColumn.DataPropertyName = "Country"
        Me.CountryDataGridViewTextBoxColumn.HeaderText = "Country"
        Me.CountryDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CountryDataGridViewTextBoxColumn.Name = "CountryDataGridViewTextBoxColumn"
        Me.CountryDataGridViewTextBoxColumn.Width = 125
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.Width = 125
        '
        'FaxDataGridViewTextBoxColumn
        '
        Me.FaxDataGridViewTextBoxColumn.DataPropertyName = "Fax"
        Me.FaxDataGridViewTextBoxColumn.HeaderText = "Fax"
        Me.FaxDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FaxDataGridViewTextBoxColumn.Name = "FaxDataGridViewTextBoxColumn"
        Me.FaxDataGridViewTextBoxColumn.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1626, 662)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRegion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPostalCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtContactTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtContactName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.btnAdd)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Write to DB-VB.Net"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContactName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtContactTitle As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPostalCode As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRegion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFax As TextBox
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompanyNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PostalCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
