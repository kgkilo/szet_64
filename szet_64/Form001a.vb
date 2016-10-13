Imports System.Data.SqlClient

Public Class Form001a
    Private sqlConn As SqlConnection

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
            'Uj munkalap
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
            'Meglevo munkalap betoltese
            Me.Text = "Form001a - " + Me.Tag.ToString + " sz. munkalap módosítása"

            Using sqlConn As New SqlConnection(GlobalVars.sConnStr)
                Dim sqlComm As SqlCommand = New SqlCommand("sp_LoadMunkalap", sqlConn)
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.Add("@pID", SqlDbType.Int).Value = Me.Tag

                sqlConn.Open()
                Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
                If sqlReader.HasRows Then
                    While (sqlReader.Read())
                        txtNAPSZAM.Text = sqlReader.Item("NAPSZAM").ToString
                        txtBEJDAT.Text = sqlReader.Item("BEJDAT").ToString
                        txtKIALLDAT.Text = sqlReader.Item("KIALLDAT").ToString
                        cmbSZEREGYS.SelectedValue = sqlReader.Item("SZEREGYS")
                        cmbMFDOLG.SelectedValue = sqlReader.Item("MFDOLG")
                        cmbSZOLGJELL.SelectedValue = sqlReader.Item("SZOLGJELL")
                        txtBEJNEV.Text = sqlReader.Item("BEJNEV").ToString
                        cmbFSZAM.SelectedValue = sqlReader.Item("FSZAM")
                        cmbTIPUSH.SelectedValue = sqlReader.Item("TIPUSH")
                        txtMUNELV.Text = sqlReader.Item("MUNELV").ToString
                        txtIDOTOL.Text = sqlReader.Item("IDOTOL").ToString
                        txtIDOIG.Text = sqlReader.Item("IDOIG").ToString
                        cmbMKAP.SelectedValue = sqlReader.Item("MKAP")
                        cmbPLOMBAZAS.SelectedValue = sqlReader.Item("PLOMBAZAS")
                        txtUJ.Text = sqlReader.Item("UJ").ToString
                        txtFELUJITOTT.Text = sqlReader.Item("FELUJITOTT").ToString
                        cmbMUVEL.SelectedValue = sqlReader.Item("MUVEL")
                        cmbMUNVEGZ.SelectedValue = sqlReader.Item("MUNVEGZ")
                        cmbSZOLTIP.SelectedValue = sqlReader.Item("SZOLTIP")
                        cmbMUNSZ.SelectedValue = sqlReader.Item("MUNSZ")
                        cmbKARBTIP.SelectedValue = sqlReader.Item("KARBTIP")
                        txtHIBLEIR.Text = sqlReader.Item("HIBLEIR").ToString
                        txtOBJID.Text = sqlReader.Item("OBJID").ToString
                        txtLAKAS.Text = sqlReader.Item("LAKAS").ToString
                        txtREF.Text = sqlReader.Item("REF").ToString
                        txtALLAPOT.Text = sqlReader.Item("ALLAPOT").ToString
                        Select Case txtALLAPOT.Text
                            Case "1"
                                optALLAPOT1.Checked = True
                            Case "2"
                                optALLAPOT2.Checked = True
                            Case "3"
                                optALLAPOT3.Checked = True
                            Case "4"
                                optALLAPOT4.Checked = True
                        End Select
                        'Sztorno munkalapot nem lehet masmilyen allapotura allitani,
                        'orokre sztorno marad.
                        If txtALLAPOT.Text = "3" Then
                            spcALLAPOT.Enabled = False
                        End If

                        txtKIALLDAT.Enabled = False   'Kiallitas datuma nem javithato utolag (altalaban)

                        If txtREF.Text <> "" Then   'Ha van mar errol a munkalaprol masolat, azaz a referencia mezo nem ures
                            txtNAPSZAM.Enabled = False    'egy csomo minden nem javithato utolag.
                            txtBEJDAT.ReadOnly = True
                            cmbSZEREGYS.Enabled = False
                            cmbMFDOLG.Enabled = False
                            cmbSZOLGJELL.Enabled = False
                            'txtBEJNEV.readonly = True
                            cmbFSZAM.Enabled = False
                            cmbMKAP.Enabled = False
                            cmbMUVEL.Enabled = False
                            cmbMUNVEGZ.Enabled = False
                            cmbSZOLTIP.Enabled = False
                            cmbMUNSZ.Enabled = False
                            cmbKARBTIP.Enabled = False
                            'Me.txtIDOTOL.ReadOnly = True
                            'Me.txtIDOIG.ReadOnly = True

                            txtMUNELV.ReadOnly = False
                            cmbTIPUSH.Enabled = True
                            txtHIBLEIR.ReadOnly = False

                            'Osszesito keszitese csak plombazashoz engedelyezett!
                            'Plombazas csak bizonyos tipushiba eseten lehetseges,
                            'ezert lekerdezzuk, hogy mi is a tipushiba.
                            Dim tipusHiba As String
                            tipusHiba = If(cmbTIPUSH.SelectedIndex <> -1, cmbTIPUSH.SelectedValue.ToString, 0)

                            If tipusHiba = "272" Then
                                cmbPLOMBAZAS.Visible = True
                                lblPLOMBAZAS.Visible = True
                            Else
                                cmbPLOMBAZAS.Visible = False
                                lblPLOMBAZAS.Visible = False
                            End If

                            Select Case tipusHiba   'Ezek a plombazassal kapcsolatos tipushibak
                                Case "272", "028", "029", "015", "016"
                                    cmdOSSZESITO.Enabled = True
                            End Select
                        Else
                            cmdOSSZESITO.Enabled = False
                        End If  'txtREF
                    End While
                End If
                sqlReader.Close()
            End Using
        End If

        Cursor.Current = Cursors.Default
    End Sub

    'Ha a fokonyvi szam combo valtozik, a mellette levo text mezobe kiirjuk
    ' a hozza tartozo fokonyvi megnevezest
    Private Sub cmbFSZAM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFSZAM.SelectedIndexChanged

        If cmbFSZAM.SelectedIndex <> -1 Then
            Try
                sqlConn = New SqlConnection(GlobalVars.sConnStr)
                Dim sqlComm As SqlCommand = New SqlCommand("SELECT FSZAM + ' ' + FSZNEV AS FNEV FROM KONTIR WHERE FSZAM = @pFSZAM", sqlConn)
                sqlComm.Parameters.Add("@pFSZAM", SqlDbType.VarChar, 12).Value = cmbFSZAM.SelectedValue.ToString()
                sqlConn.Open()

                Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
                If sqlReader.HasRows Then
                    While (sqlReader.Read())
                        txtFNEV.Text = sqlReader.Item("FNEV").ToString
                    End While
                End If
                sqlReader.Close()
            Catch ex As Exception
                MsgBox(ex.ToString(), MsgBoxStyle.Critical, ex.Message)
                Me.Close()
            End Try
        End If
    End Sub

    'Ha a szolgaltatas jellege valtozik, az meghataroz egy csomo mindent a formon.
    'Ezeket automatikusan be kell allitani.
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
                    '    If spcOBJTIP.Text = "03" Then
                    '        cmbFSZAM.SelectedValue = "62317"
                    '    ElseIf spcOBJTIP.Text = "17" Then
                    '        cmbFSZAM.SelectedValue = "62325"
                    '    End If
                    'End If

                Case Else
                    cmbFSZAM.SelectedValue = "62317"
            End Select
        End If
    End Sub

    'Ha a tipushiba valtozik, az meghataroz egy csomo mindent a formon, pl kitolti automatikusan
    ' a hibaleiras mezot.
    'A plombazashoz kapcsolodo mezok lathatosaga is ez alapjan valtozik.
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

        'Plombazashoz kapcsolodo mezok lathatosaga
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

    Private Sub cmdCANCEL_Click(sender As Object, e As EventArgs) Handles cmdCANCEL.Click
        Me.Close()
    End Sub

    'Rekord mentese
    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        'Allapot radiobutton lekerdezese
        If optALLAPOT1.Checked Then         'Elojegyzett
            txtALLAPOT.Text = "1"
        ElseIf optALLAPOT2.Checked Then     'Nyomtatott
            txtALLAPOT.Text = "2"
        ElseIf optALLAPOT3.Checked Then     'Sztorno
            txtALLAPOT.Text = "3"
        ElseIf optALLAPOT4.Checked Then     'Visszaerkezett
            txtALLAPOT.Text = "4"
        End If

        Try
            sqlConn = New SqlConnection(GlobalVars.sConnStr)
            Dim sqlComm As New SqlCommand()

            If Me.Tag = -1 Then 'Uj rekordot kell rogziteni
                With sqlComm
                    .Connection = sqlConn
                    .CommandText = "sp_InsMunkalap"
                    .CommandType = CommandType.StoredProcedure

                    'Dim sParam As SqlParameter = .Parameters.Add("@pObjTip", SqlDbType.VarChar, 2)
                    'sParam.Value = cmbOBJTIP.SelectedValue

                    '.Parameters.Add("MTIP", SqlDbType.VarChar, 2).Value = txtMTIP.Text
                    .Parameters.AddWithValue("MTIP", txtMTIP.Text)
                    .Parameters.AddWithValue("BEJDAT", Date.Parse(txtBEJDAT.Text))
                    .Parameters.AddWithValue("BEJNEV", txtBEJNEV.Text) 'Integer.Parse(txtAge.Text))
                    .Parameters.AddWithValue("TIPUSH", cmbTIPUSH.SelectedValue)
                    .Parameters.AddWithValue("HIBLEIR", txtHIBLEIR.Text)
                    .Parameters.AddWithValue("SZEREGYS", cmbSZEREGYS.SelectedValue)
                    .Parameters.AddWithValue("MFDOLG", cmbMFDOLG.SelectedValue)
                    .Parameters.AddWithValue("MUNELV", Date.Parse(txtMUNELV.Text))
                    .Parameters.AddWithValue("IDOTOL", txtIDOTOL.Text)
                    .Parameters.AddWithValue("IDOIG", txtIDOIG.Text)
                    .Parameters.AddWithValue("SZOLGTIP", cmbSZOLTIP.SelectedValue)
                    .Parameters.AddWithValue("MUNVEGZ", cmbMUNVEGZ.SelectedValue)
                    .Parameters.AddWithValue("SZOLGJELL", cmbSZOLGJELL.SelectedValue)
                    .Parameters.AddWithValue("OBJID", txtOBJID.Text)
                    .Parameters.AddWithValue("KARBTIP", cmbKARBTIP.SelectedValue)
                    .Parameters.AddWithValue("MUVEL", cmbMUVEL.SelectedValue)
                    .Parameters.AddWithValue("NAPSZAM", txtNAPSZAM.Text)
                    .Parameters.AddWithValue("KIALLDAT", Date.Parse(txtKIALLDAT.Text))
                    .Parameters.AddWithValue("FSZAM", cmbFSZAM.SelectedValue)
                    .Parameters.AddWithValue("SZOLTIP", cmbSZOLTIP.SelectedValue)
                    .Parameters.AddWithValue("MUNSZ", cmbMUNSZ.SelectedValue)
                    .Parameters.AddWithValue("MKAP", cmbMKAP.SelectedValue)
                    .Parameters.AddWithValue("ALLAPOT", txtALLAPOT.Text)
                    .Parameters.AddWithValue("LAKAS", txtLAKAS.Text)
                    .Parameters.AddWithValue("PLOMBAZAS", cmbPLOMBAZAS.SelectedValue)
                    .Parameters.AddWithValue("UJ", txtUJ.Text)
                    .Parameters.AddWithValue("FELUJITOTT", txtFELUJITOTT.Text)

                    Dim retval As SqlParameter = .Parameters.Add("@RET", SqlDbType.Int)
                    retval.Direction = ParameterDirection.ReturnValue
                End With

                sqlConn.Open()
                'sqlComm.ExecuteNonQuery()
                'Alapvetoen az ExecuteNonQuery is jo lenne, de szuksegunk van a visszateresi ertekre...
                ' (ami az uj munkalap ID-je)
                Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
                sqlReader.Close()   'Az SqlDataReader a Close utan adja csak vissza a return value-t!
                Dim iMunkalap_ID As Integer = sqlComm.Parameters.Item("@RET").Value

                If MsgBox("Kívánja nyomtatni a munkalapot?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Nyomtatás") = vbYes Then
                    Me.PrintMunkalap("1", iMunkalap_ID)
                    '    Nyomtat("munuf.rpt", 1)
                End If

            Else    'Meglevo rekord update
                With sqlComm
                    .Connection = sqlConn
                    .CommandText = "sp_UpdMunkalap"
                    .CommandType = CommandType.StoredProcedure

                    .Parameters.AddWithValue("pID", Integer.Parse(Me.Tag))
                    .Parameters.AddWithValue("BEJDAT", Date.Parse(txtBEJDAT.Text))
                    .Parameters.AddWithValue("BEJNEV", txtBEJNEV.Text) 'Integer.Parse(txtAge.Text))
                    .Parameters.AddWithValue("TIPUSH", cmbTIPUSH.SelectedValue)
                    .Parameters.AddWithValue("HIBLEIR", txtHIBLEIR.Text)
                    .Parameters.AddWithValue("SZEREGYS", cmbSZEREGYS.SelectedValue)
                    .Parameters.AddWithValue("MFDOLG", cmbMFDOLG.SelectedValue)
                    .Parameters.AddWithValue("MUNELV", Date.Parse(txtMUNELV.Text))
                    .Parameters.AddWithValue("IDOTOL", txtIDOTOL.Text)
                    .Parameters.AddWithValue("IDOIG", txtIDOIG.Text)
                    .Parameters.AddWithValue("SZOLGTIP", cmbSZOLTIP.SelectedValue)
                    .Parameters.AddWithValue("MUNVEGZ", cmbMUNVEGZ.SelectedValue)
                    .Parameters.AddWithValue("SZOLGJELL", cmbSZOLGJELL.SelectedValue)
                    .Parameters.AddWithValue("KARBTIP", cmbKARBTIP.SelectedValue)
                    .Parameters.AddWithValue("MUVEL", cmbMUVEL.SelectedValue)
                    .Parameters.AddWithValue("NAPSZAM", txtNAPSZAM.Text)
                    .Parameters.AddWithValue("KIALLDAT", Date.Parse(txtKIALLDAT.Text))
                    .Parameters.AddWithValue("FSZAM", cmbFSZAM.SelectedValue)
                    .Parameters.AddWithValue("SZOLTIP", cmbSZOLTIP.SelectedValue)
                    .Parameters.AddWithValue("MUNSZ", cmbMUNSZ.SelectedValue)
                    .Parameters.AddWithValue("MKAP", cmbMKAP.SelectedValue)
                    .Parameters.AddWithValue("ALLAPOT", txtALLAPOT.Text)
                    .Parameters.AddWithValue("LAKAS", txtLAKAS.Text)
                    .Parameters.AddWithValue("OBJID", Integer.Parse(txtOBJID.Text))
                    .Parameters.AddWithValue("PLOMBAZAS", cmbPLOMBAZAS.SelectedValue)
                    .Parameters.AddWithValue("UJ", txtUJ.Text)
                    .Parameters.AddWithValue("FELUJITOTT", txtFELUJITOTT.Text)
                End With

                sqlConn.Open()
                sqlComm.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, ex.Message)
        End Try
        Me.Close()
    End Sub

    Private Sub cmdHELY_Click(sender As Object, e As EventArgs) Handles cmdHELY.Click
        Form001b.Tag = -1
        Form001b.Show(Me)
        'If iWorkMode = DISZPECSER Then cmbSZOLGJELL_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cmdOSSZESITO_Click(sender As Object, e As EventArgs) Handles cmdOSSZESITO.Click
        'Dim tipusHiba As String = cmbTIPUSH.SelectedValue

        'If MsgBox("Biztosan nyomtatni szeretné az összesítõt?", vbYesNo + vbExclamation, "Tisztelt felhasználó!") = vbYes Then
        '    If tipusHiba = 272 Then 'Vizora plombazas
        '        util.PrintMunkalapSok(txtREF, 1)
        '        Nyomtat("plombossz.rpt", 0)
        '    Else
        '        util.PrintMunkalapSok(txtREF, 2)
        '        Nyomtat("vizoraossz.rpt", 0)
        '    End If
        'End If
    End Sub

    Private Sub Form001a_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If txtOBJID.Text <> "" Then Me.MunkalapObjKiir(CInt(txtOBJID.Text))

        If txtREF.Text <> "" Then
            MsgBox(txtREF.Text & ". munkalapról készített másolat! Bizonyos adatai nem módosíthatóak!", vbExclamation, "Tisztelt felhasználó!")
        End If
    End Sub

    'A munkalaphoz kapcsolodo objektum adatait kiirja a bal also sarokban levo info mezokre
    Private Function MunkalapObjKiir(ByVal objid As Integer) As Boolean
        Dim ret As Boolean = False

        If objid > 0 Then
            Try
                sqlConn = New SqlConnection(GlobalVars.sConnStr)
                Dim sqlComm As SqlCommand = New SqlCommand("sp_GetMunkalapObj", sqlConn)
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.Add("@OBJID", SqlDbType.Int).Value = objid
                sqlConn.Open()

                Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
                If sqlReader.HasRows Then
                    While (sqlReader.Read())
                        txt1.Text = sqlReader.Item("OBJTIP").ToString
                        txt2.Text = sqlReader.Item("MEGNEV").ToString
                        txt3.Text = sqlReader.Item("INFO").ToString
                    End While
                End If
                sqlReader.Close()
                ret = True
            Catch ex As Exception
                MsgBox(ex.ToString(), MsgBoxStyle.Critical, ex.Message)
                ret = False
            End Try
        End If

        Return ret
    End Function

    'A munkalap allapotat atallitja a parameterben megadottra
    Private Function MunkalapAllapot(ByVal objid As Integer, ByVal allapot As Integer) As Boolean
        Dim ret As Boolean = False

        If objid > 0 Then
            Try
                Using sqlConn As New SqlConnection(GlobalVars.sConnStr)
                    Dim sqlComm As SqlCommand = New SqlCommand("sp_SetMunkalapAllapot", sqlConn)
                    With sqlComm
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@pID", SqlDbType.Int).Value = objid
                        .Parameters.Add("@pALLAPOT", SqlDbType.Int).Value = allapot
                        sqlConn.Open()
                        .ExecuteNonQuery()
                    End With
                End Using
                ret = True
            Catch ex As Exception
                MsgBox(ex.ToString(), MsgBoxStyle.Critical, ex.Message)
                ret = False
            End Try
        End If

        Return ret
    End Function

    'Kinyomtatja a megadott munkalapot
    Private Function PrintMunkalap(ByVal sMunkalapTipus As String, ByVal iMunkalap_ID As Integer) As Boolean
        Dim ret As Boolean = False

        If iMunkalap_ID > 0 Then
            Try
                'A munkalap allapotat 'Nyomtatott'-ra allitjuk
                Using sqlConn As New SqlConnection(GlobalVars.sConnStr)
                    Dim sqlComm As SqlCommand = New SqlCommand("sp_SetMunkalapAllapot", sqlConn)
                    With sqlComm
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@pID", SqlDbType.Int).Value = iMunkalap_ID
                        .Parameters.Add("@pALLAPOT", SqlDbType.Int).Value = 2    '2 = Nyomtatott
                        sqlConn.Open()
                        .ExecuteNonQuery()
                    End With    'sqlComm
                End Using   'sqlConn

                'A munkalaprol megcsinaljuk a nyomtatasra varo rekordot a MLAPTAB tablaban
                Using sqlConn As New SqlConnection(GlobalVars.sConnStr)
                    Dim sqlComm As SqlCommand = New SqlCommand("sp_WriteMlapTab", sqlConn)
                    With sqlComm
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@pMTIP", SqlDbType.VarChar, 1).Value = "1" '1 = Uzemfenntartas
                        .Parameters.Add("@pID", SqlDbType.Int).Value = iMunkalap_ID
                        sqlConn.Open()
                        .ExecuteNonQuery()
                    End With    'sqlComm
                End Using   'sqlConn

                ret = True
            Catch ex As Exception
                MsgBox(ex.ToString(), MsgBoxStyle.Critical, ex.Message)
                ret = False
            End Try
        End If

        'Sub Nyomtat(reportname As String, iDestination As Integer)
        '    With Form001.rep
        '        .Destination = iDestination ' 0 - privju ablak, 1 - kozvetlenul nyomtat
        '        .WindowBorderStyle = 3
        '        .WindowState = 2
        '        .Connect = sConnectString
        '        .ReportFileName = sReportDir & reportname
        '        .Action = 1
        '    End With
        'End Sub

        Return ret
    End Function

End Class