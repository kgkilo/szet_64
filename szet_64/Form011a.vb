Imports System.Data.SqlClient

Public Class Form011a
    Private sqlConn As SqlConnection

    Private Sub Form011a_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor.Current = Cursors.WaitCursor
        Me.Sp_Q323TableAdapter.Fill(Me.SZETAVDataSet.sp_Q323)
        Me.Sp_Q324TableAdapter.Fill(Me.SZETAVDataSet.sp_Q324)
        Me.Sp_Q363TableAdapter.Fill(Me.SZETAVDataSet.sp_Q363)
        Me.Sp_Q362TableAdapter.Fill(Me.SZETAVDataSet.sp_Q362)
        Me.Sp_Q360TableAdapter.Fill(Me.SZETAVDataSet.sp_Q360)
        Me.Sp_Q361TableAdapter.Fill(Me.SZETAVDataSet.sp_Q361)
        Me.Sp_Q359TableAdapter.Fill(Me.SZETAVDataSet.sp_Q359)
        Me.Sp_Q358TableAdapter.Fill(Me.SZETAVDataSet.sp_Q358)
        Me.Sp_Q357TableAdapter.Fill(Me.SZETAVDataSet.sp_Q357)
        Me.Sp_Q356TableAdapter.Fill(Me.SZETAVDataSet.sp_Q356)
        Me.Sp_Q355TableAdapter.Fill(Me.SZETAVDataSet.sp_Q355)
        Me.Sp_Q354TableAdapter.Fill(Me.SZETAVDataSet.sp_Q354)
        Me.Sp_Q364TableAdapter.Fill(Me.SZETAVDataSet.sp_Q364)
        Me.Sp_Q353TableAdapter.Fill(Me.SZETAVDataSet.sp_Q353)
        Me.Sp_Q352TableAdapter.Fill(Me.SZETAVDataSet.sp_Q352)
        Me.Sp_Q351TableAdapter.Fill(Me.SZETAVDataSet.sp_Q351)
        Me.Sp_Q350TableAdapter.Fill(Me.SZETAVDataSet.sp_Q350)
        Me.Sp_Q349TableAdapter.Fill(Me.SZETAVDataSet.sp_Q349)
        Me.Sp_Q322TableAdapter.Fill(Me.SZETAVDataSet.sp_Q322)
        Me.Sp_Q325TableAdapter.Fill(Me.SZETAVDataSet.sp_Q325)
        Me.Sp_Q320TableAdapter.Fill(Me.SZETAVDataSet.sp_Q320)
        Me.Sp_Q319TableAdapter.Fill(Me.SZETAVDataSet.sp_Q319)
        Me.Sp_Q272TableAdapter.Fill(Me.SZETAVDataSet.sp_Q272)
        Me.Sp_Q318TableAdapter.Fill(Me.SZETAVDataSet.sp_Q318)
        Me.Sp_Q326TableAdapter.Fill(Me.SZETAVDataSet.sp_Q326)
        Me.Sp_Q285TableAdapter.Fill(Me.SZETAVDataSet.sp_Q285)
        Me.Sp_Q315TableAdapter.Fill(Me.SZETAVDataSet.sp_Q315)
        Me.Sp_Q310TableAdapter.Fill(Me.SZETAVDataSet.sp_Q310)
        Me.Sp_Q279TableAdapter.Fill(Me.SZETAVDataSet.sp_Q279)
        Me.Sp_Q314TableAdapter.Fill(Me.SZETAVDataSet.sp_Q314)
        Me.Sp_Q297TableAdapter.Fill(Me.SZETAVDataSet.sp_Q297)
        Me.Sp_Q313TableAdapter.Fill(Me.SZETAVDataSet.sp_Q313)
        Me.Sp_Q289TableAdapter.Fill(Me.SZETAVDataSet.sp_Q289)
        Me.Sp_Q317TableAdapter.Fill(Me.SZETAVDataSet.sp_Q317)
        Me.Sp_Q312TableAdapter.Fill(Me.SZETAVDataSet.sp_Q312)

        If Me.Tag > 0 Then  'Tag fel volt toltve ertelmes indexszel, be kell tolteni azt a rekordot
            Me.TabControl1.TabPages(1).Enabled = True
            Me.TabControl1.TabPages(2).Enabled = True
            Me.TabControl1.TabPages(3).Enabled = True
            Me.TabControl1.TabPages(4).Enabled = True
            Me.TabControl1.TabPages(5).Enabled = True
            LoadAltalanos()
            LoadEgyedi()
        Else
            'Uj rekord insert
            'Az objektum tipusat -1-gyel szorozva kaptuk meg a Form.Tag-ben
            txtOBJTIP.Text = (-1 * CInt(Me.Tag)).ToString("00")

            cmbALAIR.SelectedIndex = -1
            cmbFKOD.SelectedIndex = -1
            cmbFSZAM.SelectedIndex = -1
            cmbGYARTO.SelectedIndex = -1
            cmbKATEG.SelectedIndex = -1
            cmbNEVLTELJME.SelectedIndex = -1
            cmbUZALL.SelectedIndex = -1
            cmbVAROS.SelectedIndex = -1
            cmbVESZO.SelectedIndex = -1
            Me.TabControl1.TabPages(1).Enabled = False
            Me.TabControl1.TabPages(2).Enabled = False
            Me.TabControl1.TabPages(3).Enabled = False
            Me.TabControl1.TabPages(4).Enabled = False
            Me.TabControl1.TabPages(5).Enabled = False
        End If

        HideUnusedControls()
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub cmdCANCEL_Click(sender As Object, e As EventArgs) Handles cmdCANCEL.Click
        Me.Close()
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        If Me.Tag < 0 Then 'Uj rekordot kell rogziteni
            InsertNew()
        Else    'Meglevo rekord update
            UpdateObj()
        End If

        Me.Close()
    End Sub

    Private Sub Form011a_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        lblTitle.Left = (Me.Width - lblTitle.Size.Width) / 2
    End Sub

    Private Sub HideUnusedControls()
        'Ez a tomb tartalmazza azoknak a control elemeknek a nevet,
        'amiknek meg kell jelenni a dialog-on
        Dim EnableThese(130) As String

        'Beolvassuk a PERMIS tablabol, hogy az adott objektumtipusnak melyik mezok kellenek
        sqlConn = New SqlConnection(GlobalVars.sConnStr)
        Dim sqlComm As New SqlCommand("sp_GetPermis", sqlConn)
        sqlComm.CommandType = CommandType.StoredProcedure
        sqlComm.Parameters.Add("@pOBJTIP", SqlDbType.VarChar, 2).Value = txtOBJTIP.Text
        sqlConn.Open()
        Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
        If sqlReader.HasRows Then
            While (sqlReader.Read())    'A PERMIS tablaban a mezo neve=a control neve.
                Try                     'Ha 1 a mezo erteke, akkor meg kell jeleniteni,
                    Dim j As Integer = 0    'azaz akkor betesszuk a string tombbe
                    For i As Integer = 0 To 129 Step 1  '129 oszlop van a PERMIS tablaban...
                        If sqlReader.Item(i) > 0 Then
                            EnableThese(j) = sqlReader.GetName(i).ToString()    'tomb<-mezo neve
                            j = j + 1
                        End If
                    Next    'For i
                Catch ex As Exception
                    MsgBox("túlsok")
                End Try
            End While   'sqlReader.Read
        End If   'HasRows
        sqlReader.Close()
        sqlReader.Dispose()
        sqlComm.Dispose()
        sqlConn.Dispose()

        'Most pedig vegigmegyunk a dialogbox osszes control-jan es megnezzuk,
        'hogy a neve szerepel-e a megjelenitendok listajan. Ha igen, akkor kirakjuk,
        'ha nem, akkor elrejtjuk es letiltjuk.
        'Ezt csak azokra a control-okra kell lejatszani, amiknek a neve txt, cmb, dt, lbl, chk kezdetu.
        Dim t As TabPage
        For Each t In Me.TabControl1.TabPages
            Dim o As Control
            For Each o In t.Controls
                With o.Name
                    Dim sName As String = If(.StartsWith("dt"), .Substring(2), .Substring(3))   'A mezo neve
                    If .StartsWith("txt") Or .StartsWith("cmb") Or .StartsWith("lbl") _
                        Or .StartsWith("dt") Or .StartsWith("chk") Then
                        If EnableThese.Contains(sName) Then
                            o.Visible = True
                            o.Enabled = True
                            Try
                                t.Controls.Item("lbl" + sName + "_X").Visible = True
                                t.Controls.Item("lbl" + sName + "_X").Enabled = True
                            Catch
                            End Try
                        Else
                            'o.Visible = False
                            o.Enabled = False
                            Try
                                't.Controls.Item("lbl" + sName + "_X").Visible = False
                                t.Controls.Item("lbl" + sName + "_X").Enabled = False
                            Catch
                            End Try
                        End If
                    End If  'o.Name.StartsWith
                End With    'o.Name
            Next    'o
        Next    't
    End Sub

    'Feltolti az elso, Altalanos lap control-jait
    Sub LoadAltalanos()
        Try
            sqlConn = New SqlConnection(GlobalVars.sConnStr)
            Dim sqlComm As New SqlCommand("sp_LoadObjAlt", sqlConn)
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.Add("@pID", SqlDbType.Int).Value = Me.Tag

            sqlConn.Open()
            Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
            If sqlReader.HasRows Then
                While (sqlReader.Read())
                    txtOBJTIP.Text = sqlReader.Item("OBJTIP").ToString

                    Dim o As Control
                    For Each o In Me.TabControl1.TabPages(0).Controls
                        Try
                            Dim sName As String
                            sName = If(o.Name.StartsWith("dt"), o.Name.Substring(2), o.Name.Substring(3))
                            If o.Name.StartsWith("txt") Then
                                o.Text = sqlReader.Item(sName).ToString
                            ElseIf o.Name.StartsWith("cmb") Then
                                CType(o, ComboBox).SelectedValue = sqlReader.Item(sName)
                            ElseIf o.Name.StartsWith("dt") Then
                                CType(o, DateTimePicker).Value = If(sqlReader.Item(sName), Nothing)
                            ElseIf o.Name.StartsWith("chk") Then
                                CType(o, CheckBox).Checked = sqlReader.Item(sName).Equals("y")
                            End If
                        Catch
                            'Ez a catch azert ures, mert sok olyan mezo lehet a form-on, amit
                            'az SQL lekerdezes nem ad vissza. Ez nem gond, menni kell tovabb!
                        End Try
                    Next
                End While
            End If   'HasRows
            sqlReader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, , ex.ToString)
        End Try
    End Sub

    'Feltolti az osszes egyeb lap control-jait
    Sub LoadEgyedi()
        Try
            sqlConn = New SqlConnection(GlobalVars.sConnStr)
            Dim sqlComm As New SqlCommand("sp_LoadObjEgyedi", sqlConn)
            sqlComm.CommandType = CommandType.StoredProcedure
            sqlComm.Parameters.Add("@pID", SqlDbType.Int).Value = Me.Tag

            sqlConn.Open()
            Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
            If sqlReader.HasRows Then
                While (sqlReader.Read())
                    Dim t As TabPage
                    For Each t In Me.TabControl1.TabPages
                        If t.Text <> "Általános" Then   'Az elso oldalt mar feltoltotte a LoadAltalanos()
                            Dim o As Control
                            For Each o In t.Controls
                                Try
                                    Dim sName As String
                                    sName = If(o.Name.StartsWith("dt"), o.Name.Substring(2), o.Name.Substring(3))
                                    If o.Name.StartsWith("txt") Then
                                        o.Text = sqlReader.Item(sName).ToString
                                    ElseIf o.Name.StartsWith("cmb") Then
                                        CType(o, ComboBox).SelectedValue = sqlReader.Item(sName)
                                    ElseIf o.Name.StartsWith("dt") Then
                                        CType(o, DateTimePicker).Value = sqlReader.Item(sName)
                                    ElseIf o.Name.StartsWith("chk") Then
                                        CType(o, CheckBox).Checked = sqlReader.Item(sName).Equals("y")
                                    End If
                                Catch
                                    'Ez a catch azert ures, mert sok olyan mezo lehet a form-on, amit
                                    'az SQL lekerdezes nem ad vissza. Ez nem gond, menni kell tovabb!
                                End Try
                            Next    'o in t.Controls
                        End If  'if <> Altalanos
                    Next    't in TabControl1.TabPages
                End While   'SqlReader.Read
            End If   'HasRows
            sqlReader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, , ex.ToString)
        End Try
    End Sub

    Sub InsertNew()
        Try
            sqlConn = New SqlConnection(GlobalVars.sConnStr)
            Dim sqlComm As New SqlCommand("sp_InsObjAlt", sqlConn)

            With sqlComm
                .CommandType = CommandType.StoredProcedure

                .Parameters.AddWithValue("pOBJTIP", txtOBJTIP.Text)

                .Parameters.AddWithValue("MEGNEV", txtMEGNEV.Text)
                .Parameters.AddWithValue("TIPUS", txtTIPUS.Text)
                .Parameters.AddWithValue("VAROS", cmbVAROS.SelectedValue)
                .Parameters.AddWithValue("UTCA", txtUTCA.Text)
                .Parameters.AddWithValue("HSZ", txtHSZ.Text)
                .Parameters.AddWithValue("ELHELYEZ", txtELHELYEZ.Text)
                .Parameters.AddWithValue("GYSZAM", txtGYSZAM.Text)
                .Parameters.AddWithValue("GYARTO", cmbGYARTO.SelectedValue)
                .Parameters.AddWithValue("UZALL", cmbUZALL.SelectedValue)
                .Parameters.AddWithValue("UZEMIDO", dtUZEMIDO.Value)
                .Parameters.AddWithValue("HITIDO", dtHITIDO.Value)
                .Parameters.AddWithValue("GYARTM", txtGYARTM.Text)
                .Parameters.AddWithValue("TELEPHSZ", txtTELEPHSZ.Text)
                .Parameters.AddWithValue("VESZO", cmbVESZO.SelectedValue)
                .Parameters.AddWithValue("FKOD", cmbFKOD.SelectedValue)
                .Parameters.AddWithValue("ALAIR", cmbALAIR.SelectedValue)
                If txtNEVLTELJ.Text <> "" Then
                    .Parameters.AddWithValue("NEVLTELJ", Double.Parse(txtNEVLTELJ.Text))
                End If
                .Parameters.AddWithValue("NEVLTELJME", cmbNEVLTELJME.SelectedValue)
                .Parameters.AddWithValue("KATEG", cmbKATEG.SelectedValue)
                .Parameters.AddWithValue("FSZAM", cmbFSZAM.SelectedValue)
                .Parameters.AddWithValue("MEGJ", txtMEGJ.Text)
                .Parameters.AddWithValue("AKTIV", "y")

                sqlConn.Open()
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, , ex.ToString)
        End Try
    End Sub

    Sub UpdateObj()
        Try
            Using sqlConn As New SqlConnection(GlobalVars.sConnStr)
                Dim sqlComm As New SqlCommand("sp_UpdObjAlt", sqlConn)
                sqlComm.CommandType = CommandType.StoredProcedure
                With sqlComm.Parameters
                    .AddWithValue("pID", Me.Tag)
                    'Altalanos
                    .AddWithValue("MEGNEV", txtMEGNEV.Text)
                    .AddWithValue("TIPUS", txtTIPUS.Text)
                    .AddWithValue("VAROS", cmbVAROS.SelectedValue)
                    .AddWithValue("UTCA", txtUTCA.Text)
                    .AddWithValue("HSZ", txtHSZ.Text)
                    .AddWithValue("ELHELYEZ", txtELHELYEZ.Text)
                    .AddWithValue("GYSZAM", txtGYSZAM.Text)
                    .AddWithValue("GYARTO", cmbGYARTO.SelectedValue)
                    .AddWithValue("UZALL", cmbUZALL.SelectedValue)
                    .AddWithValue("UZEMIDO", dtUZEMIDO.Value)
                    .AddWithValue("HITIDO", dtHITIDO.Value)
                    .AddWithValue("GYARTM", txtGYARTM.Text)
                    .AddWithValue("TELEPHSZ", txtTELEPHSZ.Text)
                    .AddWithValue("VESZO", cmbVESZO.SelectedValue)
                    .AddWithValue("FKOD", cmbFKOD.SelectedValue)
                    .AddWithValue("ALAIR", cmbALAIR.SelectedValue)
                    If txtNEVLTELJ.Text <> "" Then .AddWithValue("NEVLTELJ", Double.Parse(txtNEVLTELJ.Text))
                    .AddWithValue("NEVLTELJME", cmbNEVLTELJME.SelectedValue)
                    .AddWithValue("KATEG", cmbKATEG.SelectedValue)
                    .AddWithValue("FSZAM", cmbFSZAM.SelectedValue)
                    .AddWithValue("MEGJ", txtMEGJ.Text)
                    .AddWithValue("AKTIV", "y")
                End With
                sqlConn.Open()
                sqlComm.ExecuteNonQuery()
            End Using

            Using sqlConn As New SqlConnection(GlobalVars.sConnStr)
                Dim sqlComm = New SqlCommand("sp_UpdObjGep", sqlConn)
                sqlComm.CommandType = CommandType.StoredProcedure
                With sqlComm.Parameters
                    .AddWithValue("pID", Me.Tag)
                    'Gepeszeti - altalanos
                    .AddWithValue("SZAL_KOZ", cmbSZAL_KOZ.SelectedValue)
                    If txtMKHOM.Text <> "" Then .AddWithValue("SZAL_MENNY", Double.Parse(txtSZAL_MENNY.Text))
                    .AddWithValue("MERET", txtMERET.Text)
                    .AddWithValue("MERETME", cmbMERETME.SelectedValue)
                    If txtATMERO.Text <> "" Then .AddWithValue("ATMERO", Double.Parse(txtATMERO.Text))
                    If txtFUTOFEL.Text <> "" Then .AddWithValue("FUTOFEL", Double.Parse(txtFUTOFEL.Text))
                    .AddWithValue("HOHOR_KO", cmbHOHOR_KO.SelectedValue)
                    .AddWithValue("FU_KOZ", cmbFU_KOZ.SelectedValue)
                    If txtTERFOGAT.Text <> "" Then .AddWithValue("TERFOGAT", Double.Parse(txtTERFOGAT.Text))
                    If txtHOSSZ.Text <> "" Then .AddWithValue("HOSSZ", Double.Parse(txtHOSSZ.Text))
                    If txtMKHOM.Text <> "" Then .AddWithValue("MKHOM", Double.Parse(txtMKHOM.Text))
                    .AddWithValue("OSZLSZAM", txtOSZLSZAM.Text)
                    .AddWithValue("FELEP", cmbFELEP.SelectedValue)
                    .AddWithValue("FORDSZ", txtFORDSZ.Text)
                    .AddWithValue("BEALL_ERTEK", txtBEALL_ERTEK.Text)
                    If txtUZEMINYOM.Text <> "" Then .AddWithValue("UZEMINYOM", Double.Parse(txtUZEMINYOM.Text))
                    .AddWithValue("SZABMOD", cmbSZABMOD.SelectedValue)
                    .AddWithValue("HOLEP", cmbHOLEP.SelectedValue)
                    If txtTERFARAM.Text <> "" Then .AddWithValue("TERFARAM", Double.Parse(txtTERFARAM.Text))
                    If txtEMEL_MAG.Text <> "" Then .AddWithValue("EMEL_MAG", Double.Parse(txtEMEL_MAG.Text))
                    .AddWithValue("BECSOV", txtBECSOV.Text)
                    .AddWithValue("FELUGY", chkFELUGY.Checked)
                    .AddWithValue("FAGYVED", chkFAGYVED.Checked)
                    'Gepeszeti - egyedi
                    If txtHOTELJ.Text <> "" Then .AddWithValue("HOTELJ", Double.Parse(txtHOTELJ.Text))
                    If txtGAZCSUCS.Text <> "" Then .AddWithValue("GAZCSUCS", Double.Parse(txtGAZCSUCS.Text))
                    If txtPRIM_ARAM.Text <> "" Then .AddWithValue("PRIM_ARAM", Double.Parse(txtPRIM_ARAM.Text))
                    If txtHOSSZ_KICS.Text <> "" Then .AddWithValue("HOSSZ_KICS", Double.Parse(txtHOSSZ_KICS.Text))
                    If txtHOSSZ_NAGY.Text <> "" Then .AddWithValue("HOSSZ_NAGY", Double.Parse(txtHOSSZ_NAGY.Text))
                    If txtVEGNYOM.Text <> "" Then .AddWithValue("VEGNYOM", Double.Parse(txtVEGNYOM.Text))
                    If txtTERHEL.Text <> "" Then .AddWithValue("TERHEL", Double.Parse(txtTERHEL.Text))
                    .AddWithValue("SZIVFOK", cmbSZIVFOK.SelectedValue)
                    If txtLEGSZAL.Text <> "" Then .AddWithValue("LEGSZAL", Double.Parse(txtLEGSZAL.Text))
                    If txtNYITNYOM.Text <> "" Then .AddWithValue("NYITNYOM", Double.Parse(txtNYITNYOM.Text))
                    If txtZARNYOM.Text <> "" Then .AddWithValue("ZARNYOM", Double.Parse(txtZARNYOM.Text))
                    .AddWithValue("BOYTIP", cmbBOYTIP.SelectedValue)
                    .AddWithValue("SZELTIP", cmbSZELTIP.SelectedValue)
                    If txtLEVNYOM.Text <> "" Then .AddWithValue("LEVNYOM", Double.Parse(txtLEVNYOM.Text))
                    If txtVIZNYOM.Text <> "" Then .AddWithValue("VIZNYOM", Double.Parse(txtVIZNYOM.Text))
                    .AddWithValue("SZURTIP", cmbSZURTIP.SelectedValue)
                    If txtELLENALL.Text <> "" Then .AddWithValue("ELLENALL", Double.Parse(txtELLENALL.Text))
                    If txtLEMSZAM.Text <> "" Then .AddWithValue("LEMSZAM", Integer.Parse(txtLEMSZAM.Text))
                    If txtBEVTELJ.Text <> "" Then .AddWithValue("BEVTELJ", Double.Parse(txtBEVTELJ.Text))
                    If txtDB.Text <> "" Then .AddWithValue("DB", Integer.Parse(txtDB.Text))
                    If txtIMPULZUS.Text <> "" Then .AddWithValue("IMPULZUS", Double.Parse(txtIMPULZUS.Text))
                    If txtVIZSZ.Text <> "" Then .AddWithValue("VIZSZ", Double.Parse(txtVIZSZ.Text))
                    'Gepeszeti - jegyzokonyv
                    .AddWithValue("GAZMIN", cmbGAZMIN.SelectedValue)
                    .AddWithValue("GAZMAX", cmbGAZMAX.SelectedValue)
                    .AddWithValue("EGMIN", cmbEGMIN.SelectedValue)
                    .AddWithValue("POROLAJ_MIN", cmbPOROLAJ_MIN.SelectedValue)
                    .AddWithValue("PORLEV_MIN", cmbPORLEV_MIN.SelectedValue)
                    .AddWithValue("PORGOZ_MIN", cmbPORGOZ_MIN.SelectedValue)
                    .AddWithValue("GOZMAX", cmbGOZMAX.SelectedValue)
                    .AddWithValue("VIZMAX", cmbVIZMAX.SelectedValue)
                    .AddWithValue("VESZVIZ_MIN", cmbVESZVIZ_MIN.SelectedValue)
                    .AddWithValue("FUSTCSAP_RET", cmbFUSTCSAP_RET.SelectedValue)
                    .AddWithValue("EGYEB_RET", cmbEGYEB_RET.SelectedValue)
                    .AddWithValue("KETPONTSZAB", cmbKETPONTSZAB.SelectedValue)
                    .AddWithValue("HAROMPONTSZAB", cmbHAROMPONTSZAB.SelectedValue)
                    .AddWithValue("FOLYSZAB", cmbFOLYSZAB.SelectedValue)
                    .AddWithValue("EGYEB", cmbEGYEB.SelectedValue)
                    .AddWithValue("FUST_TOM", cmbFUST_TOM.SelectedValue)
                End With
                sqlConn.Open()
                sqlComm.ExecuteNonQuery()
            End Using

            Using sqlConn As New SqlConnection(GlobalVars.sConnStr)
                Dim sqlComm = New SqlCommand("sp_UpdObjVill", sqlConn)
                sqlComm.CommandType = CommandType.StoredProcedure
                With sqlComm.Parameters
                    .AddWithValue("pID", Me.Tag)
                    'Villamos
                    If txtARAMFELV.Text <> "" Then .AddWithValue("ARAMFELV", Double.Parse(txtARAMFELV.Text))
                    If txtFESZULTS.Text <> "" Then .AddWithValue("FESZULTS", Double.Parse(txtFESZULTS.Text))
                    If txtVEZHOSSZ.Text <> "" Then .AddWithValue("VEZHOSSZ", Double.Parse(txtVEZHOSSZ.Text))
                    If txtBENYHOSSZ.Text <> "" Then .AddWithValue("BENYHOSSZ", Double.Parse(txtBENYHOSSZ.Text))
                    If txtNYOMATEK.Text <> "" Then .AddWithValue("NYOMATEK", Double.Parse(txtNYOMATEK.Text))
                    If txtERZEKENY.Text <> "" Then .AddWithValue("ERZEKENY", Double.Parse(txtERZEKENY.Text))
                    .AddWithValue("MUKMOD", cmbMUKMOD.SelectedValue)
                    If txtKVS.Text <> "" Then .AddWithValue("KVS", Double.Parse(txtKVS.Text))
                    If txtKIMARAM.Text <> "" Then .AddWithValue("KIMARAM", Double.Parse(txtKIMARAM.Text))
                    If txtTELJT.Text <> "" Then .AddWithValue("TELJT", Double.Parse(txtTELJT.Text))
                    If txtFOGYMERHELY.Text <> "" Then .AddWithValue("FOGYMERHELY", txtERZEKENY.Text)
                    .AddWithValue("KIMENET", cmbKIMENET.SelectedValue)
                    If txtCSATLMERET.Text <> "" Then .AddWithValue("CSATLMERET", Double.Parse(txtCSATLMERET.Text))
                    If txtMEDDTELJ.Text <> "" Then .AddWithValue("MEDDTELJ", Double.Parse(txtMEDDTELJ.Text))
                    If txtKISMEGSZAK.Text <> "" Then .AddWithValue("KISMEGSZAK", Double.Parse(txtKISMEGSZAK.Text))
                    If txtLEKVILLTELJ.Text <> "" Then .AddWithValue("LEKVILLTELJ", Double.Parse(txtLEKVILLTELJ.Text))
                    If txtVILLCSUCSNY.Text <> "" Then .AddWithValue("VILLCSUCSNY", Double.Parse(txtVILLCSUCSNY.Text))
                    If txtVILLCSUCST.Text <> "" Then .AddWithValue("VILLCSUCST", Double.Parse(txtVILLCSUCST.Text))
                    If txtVILLFORDSZ.Text <> "" Then .AddWithValue("VILLFORDSZ", Double.Parse(txtVILLFORDSZ.Text))
                End With
                sqlConn.Open()
                sqlComm.ExecuteNonQuery()
            End Using

            Using sqlConn As New SqlConnection(GlobalVars.sConnStr)
                Dim sqlComm As New SqlCommand("sp_UpdObjUzem", sqlConn)
                sqlComm.CommandType = CommandType.StoredProcedure
                With sqlComm.Parameters
                    .AddWithValue("pID", Me.Tag)
                    'Uzemeltetes
                    'If txt.Text <> "" Then .AddWithValue("", Double.Parse(txt.Text))
                    If txtFUR_ATM.Text <> "" Then .AddWithValue("FUR_ATM", Double.Parse(txtFUR_ATM.Text))
                    If txtPRIMELL.Text <> "" Then .AddWithValue("PRIMELL", Double.Parse(txtPRIMELL.Text))
                    If txtKAPCSOLAS.Text <> "" Then .AddWithValue("KAPCSOLAS", Double.Parse(txtKAPCSOLAS.Text))
                    .AddWithValue("TOLTESMOD", cmbTOLTESMOD.SelectedValue)
                    If txtSZABALYOZAS.Text <> "" Then .AddWithValue("SZABALYOZAS", Double.Parse(txtSZABALYOZAS.Text))
                    If txtKUTFNYOM.Text <> "" Then .AddWithValue("KUTFNYOM", Double.Parse(txtKUTFNYOM.Text))
                    If txtNYUGVIZSZ.Text <> "" Then .AddWithValue("NYUGVIZSZ", Double.Parse(txtNYUGVIZSZ.Text))
                    If txtUZEMIVIZSZ.Text <> "" Then .AddWithValue("UZEMIVIZSZ", Double.Parse(txtUZEMIVIZSZ.Text))
                    If txtCIRKTERFARAM.Text <> "" Then .AddWithValue("CIRKTERFARAM", Double.Parse(txtCIRKTERFARAM.Text))
                    If txtHOMERS.Text <> "" Then .AddWithValue("HOMERS", Double.Parse(txtHOMERS.Text))
                    If txtNYOMTARTTIP.Text <> "" Then .AddWithValue("NYOMTARTTIP", txtNYOMTARTTIP.Text)
                    If txtHMVHOMERS.Text <> "" Then .AddWithValue("HMVHOMERS", Double.Parse(txtHMVHOMERS.Text))
                    If txtFUT_LAKAS.Text <> "" Then .AddWithValue("FUT_LAKAS", Integer.Parse(txtFUT_LAKAS.Text))
                    If txtHMV_LAKAS.Text <> "" Then .AddWithValue("HMV_LAKAS", Integer.Parse(txtHMV_LAKAS.Text))
                    If txtFUT_KOZULET.Text <> "" Then .AddWithValue("FUT_KOZULET", Integer.Parse(txtFUT_KOZULET.Text))
                    If txtHMV_KOZULET.Text <> "" Then .AddWithValue("HMV_KOZULET", Integer.Parse(txtHMV_KOZULET.Text))
                    If txtHOKOZP_SZAM.Text <> "" Then .AddWithValue("HOKOZP_SZAM", Integer.Parse(txtHOKOZP_SZAM.Text))
                    If txtSZEKU_TOM.Text <> "" Then .AddWithValue("SZEKU_TOM", Double.Parse(txtSZEKU_TOM.Text))
                    If txtNYOMKUL.Text <> "" Then .AddWithValue("NYOMKUL", Double.Parse(txtNYOMKUL.Text))
                    If txtTOMEGARAM.Text <> "" Then .AddWithValue("TOMEGARAM", Double.Parse(txtTOMEGARAM.Text))
                    If txtNYOMAS_K.Text <> "" Then .AddWithValue("NYOMAS_K", Double.Parse(txtNYOMAS_K.Text))
                    If txtHOMER_SZ.Text <> "" Then .AddWithValue("HOMER_SZ", Double.Parse(txtHOMER_SZ.Text))
                    .AddWithValue("FUTOTT", chkFUTOTT.Checked)
                End With
                sqlConn.Open()
                sqlComm.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, , ex.ToString)
        End Try
    End Sub


End Class