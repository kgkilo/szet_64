Imports System.Data.SqlClient

Public Class Form001a
    Public sConnStr As String

    Private Sub Form001a_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Me.Sp_Q300TableAdapter.Fill(Me.SZETAVDataSet.sp_Q300)
        Me.Sp_Q309TableAdapter.Fill(Me.SZETAVDataSet.sp_Q309)
        Me.Sp_Q306TableAdapter.Fill(Me.SZETAVDataSet.sp_Q306)
        Me.Sp_Q298TableAdapter.Fill(Me.SZETAVDataSet.sp_Q298)
        Me.Sp_Q293TableAdapter.Fill(Me.SZETAVDataSet.sp_Q293)
        Me.Sp_Q310ATableAdapter.Fill(Me.SZETAVDataSet.sp_Q310A)
        Me.Sp_Q291TableAdapter.Fill(Me.SZETAVDataSet.sp_Q291)
        Me.Sp_Q334TableAdapter.Fill(Me.SZETAVDataSet.sp_Q334)
        Me.Sp_Q271TableAdapter.Fill(Me.SZETAVDataSet.sp_Q271)

        'Kezdeti ertekek beallitasa
        If Me.Tag = -1 Then
            Me.Text = "Form001a - Új munkalap"
            txtBEJDAT.Text = DateValue(Now())
            txtKIALLDAT.Text = DateValue(Now())
            txtMUNELV.Text = DateValue(Now())
            cmbSZEREGYS.SelectedValue = "01"
            cmbMUNSZ.SelectedIndex = -1
            cmbMFDOLG.SelectedIndex = -1
            cmbSZOLGJELL.SelectedIndex = -1
            cmbFSZAM.SelectedIndex = -1
            cmbTIPUSH.SelectedIndex = -1
            cmbMKAP.SelectedIndex = -1
            cmbMUVEL.SelectedIndex = -1
            cmbMUNVEGZ.SelectedIndex = -1
            cmbSZOLTIP.SelectedIndex = -1
            cmbMUNSZ.SelectedIndex = -1
            cmbKARBTIP.SelectedIndex = -1
        Else
            Me.Text = "Form001a - " + Me.Tag.ToString + " munkalap módosítása"
        End If

        Cursor.Current = Cursors.Default
    End Sub

    'Ha a fokonyvi szam combo valtozik, a mellette levo text mezobe kiirjuk
    ' a hozza tartozo fokonyvi megnevezest
    Private Sub cmbFSZAM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFSZAM.SelectedIndexChanged

        If cmbFSZAM.SelectedValue <> "" Then
            Dim dbadpFszam As New SqlDataAdapter("SELECT FSZNEV FROM KONTIR WHERE FSZAM = @pFSZAM", sConnStr)
            With dbadpFszam
                With .SelectCommand
                    '.CommandType = CommandType.StoredProcedure
                    Dim sParam As SqlParameter = .Parameters.Add("@pFSZAM", SqlDbType.VarChar, 12)
                    sParam.Value = cmbFSZAM.SelectedValue.ToString()
                End With

                Dim dtFszam As New DataTable
                .Fill(dtFszam)
                .Dispose()
                txtFNEV.Text = dtFszam.Rows(0).Item(0).ToString
            End With
        End If
    End Sub

    Private Sub cmbSZOLGJELL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSZOLGJELL.SelectedIndexChanged
        If Me.Tag = -1 Then 'Csak uj munkalapnal
            Select Case cmbSZOLGJELL.SelectedValue
                Case "LE", "LA"
                    cmbMUVEL.SelectedValue = "BHJ"
                    cmbFSZAM.SelectedValue = "736"

                Case "LF"
                    cmbMUVEL.SelectedValue = "BHJ"
                    cmbFSZAM.SelectedValue = "737"

                Case "HK"
                    cmbMUVEL.SelectedValue = "BHJ"
                    'If iWorkMode = DISZPECSER Then
                    '    If spcOBJTIP = "03" Then
                    '        SetComboVal(cmbFSZAM, "62317")
                    '    ElseIf spcOBJTIP = "17" Then
                    '        SetComboVal(cmbFSZAM, "62325")
                    '    End If
                    'End If

                Case Else
                    cmbFSZAM.SelectedValue = "62317"
            End Select
        End If
    End Sub

    Private Sub cmbTIPUSH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTIPUSH.SelectedIndexChanged
        Dim tipusHiba As String = cmbTIPUSH.SelectedValue

        If Me.Tag = -1 Then 'Uj munkalap, tehat szabadon modosithatjuk a hibaleirast
            If tipusHiba = "" Then
                txtHIBLEIR.Text = ""
            Else
                txtHIBLEIR.Text = cmbTIPUSH.GetItemText(cmbTIPUSH.SelectedItem())
            End If

            Select Case tipusHiba
                Case "229"
                    cmbMUVEL.SelectedValue = "SZV"
                    cmbKARBTIP.SelectedValue = "1"

                Case "007", "008", "009"
                    cmbMUVEL.SelectedValue = "HIT"
                    cmbKARBTIP.SelectedValue = "1"

                Case "246", "247", "027"
                    cmbMUVEL.SelectedValue = "SAV"
                    cmbKARBTIP.SelectedValue = "1"

                Case Else
                    cmbMUVEL.SelectedIndex = -1
                    cmbKARBTIP.SelectedIndex = -1
            End Select
        End If

        Select Case tipusHiba
            Case "272"
                lblPLOMBAZAS.Visible = True
                cmbPLOMBAZAS.Visible = True

            Case "028", "029", "015", "016"
                lblFELUJITOTT.Visible = True
                lblUJ.Visible = True
                txtFELUJITOTT.Visible = True
                txtUJ.Visible = True

            Case Else
                lblPLOMBAZAS.Visible = False
                cmbPLOMBAZAS.Visible = False
                lblFELUJITOTT.Visible = False
                lblUJ.Visible = False
                txtFELUJITOTT.Visible = False
                txtUJ.Visible = False
        End Select

    End Sub

End Class