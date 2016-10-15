Imports System.Data.SqlClient

Public Class Form002
    Private sqlConn As SqlConnection

    Private Sub Form002_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Sp_Q334TableAdapter.Fill(Me.SZETAVDataSet.sp_Q334)
        Me.Sp_Q336TableAdapter.Fill(Me.SZETAVDataSet.sp_Q336)

        'If Me.Tag <> 0 Then 'A Tag-ban a visszairasra kijelolt munkalap ID-je van
        'Else
        'End If
        cmbMUVLEIRROV.SelectedIndex = -1
        cmbDOLG_ID.SelectedIndex = -1
        dtMUNDAT.Value = Now.Date
        txtMUNORA.Text = ""
    End Sub

    Private Sub Form002_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        LoadGrid()
    End Sub

    Private Sub LoadGrid()
        Cursor.Current = Cursors.WaitCursor

        If Me.Tag <> 0 Then
            'Grid feltoltese tarolt eljarasbol
            Dim dbadp As New SqlDataAdapter("sp_FillTeljm", GlobalVars.sConnStr)
            With dbadp.SelectCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("pMUNKALAP_ID", SqlDbType.Int).Value = CInt(Me.Tag)
                Dim dt As New DataTable
                dbadp.Fill(dt)
                dbadp.Dispose()
                grdTELJ.DataSource = dt
            End With

            'Grid formazasa
            Try
                With grdTELJ
                    .AllowUserToAddRows = False
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .ReadOnly = True
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                    With .ColumnHeadersDefaultCellStyle
                        .BackColor = Color.DarkGray
                        .ForeColor = Color.Gray
                        .Font = New Font(grdTELJ.Font, FontStyle.Bold)
                    End With

                    .Columns(0).Visible = False
                    .Columns(1).HeaderText = "Dolgozó"
                    .Columns(2).HeaderText = "Dátum"
                    .Columns(3).HeaderText = "Óra"
                End With
            Catch ex As Exception
                MsgBox(ex.Message, , ex.ToString)
            End Try

            'Munkaora osszeszamolasa
            Dim iOra As Long = 0
            Dim o As DataGridViewRow
            For Each o In grdTELJ.Rows
                iOra += CLng(If(o.Cells(3).Value, 0))
            Next o
            spcMUNORA.Text = iOra
        End If
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub cmbMUVLEIRROV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMUVLEIRROV.SelectedIndexChanged
        If cmbMUVLEIRROV.SelectedIndex <> -1 Then
            Dim drv As DataRowView
            drv = CType(cmbMUVLEIRROV.SelectedItem, DataRowView)
            Dim valueOfItem As String = drv.Item("KODENEV").ToString()
            'txtMUVLEIR.AppendText(cmbMUVLEIRROV.SelectedItem.ToString)
            txtMUVLEIR.AppendText(valueOfItem & " ")
        End If
    End Sub

    Private Sub cmdCANCEL_Click(sender As Object, e As EventArgs) Handles cmdCANCEL.Click
        Me.Close()
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Try
            sqlConn = New SqlConnection(GlobalVars.sConnStr)
            Dim sqlComm = New SqlCommand("sp_UpdMunkalapVisszair", sqlConn)
            With sqlComm
                .CommandType = CommandType.StoredProcedure

                .Parameters.AddWithValue("pID", Me.Tag)
                .Parameters.AddWithValue("MUVLEIR", txtMUVLEIR.Text)
            End With    'sqlComm
            sqlConn.Open()
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.ToString)
        End Try

        Try
            sqlConn = New SqlConnection(GlobalVars.sConnStr)
            Dim sqlComm = New SqlCommand("sp_InsKarban", sqlConn)
            With sqlComm
                .CommandType = CommandType.StoredProcedure

                .Parameters.AddWithValue("MUN_ID", Me.Tag)
            End With    'sqlComm
            sqlConn.Open()
            sqlComm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.ToString)
        End Try

        Me.Close()
    End Sub

    Private Sub cmdUJ_Click(sender As Object, e As EventArgs) Handles cmdUJ.Click
        If Not txtMUNORA.Text.Equals("") _
            And dtMUNDAT.Checked _
            And cmbDOLG_ID.SelectedIndex <> -1 Then
            Try
                sqlConn = New SqlConnection(GlobalVars.sConnStr)
                Dim sqlComm = New SqlCommand("sp_InsTeljm", sqlConn)
                With sqlComm
                    .CommandType = CommandType.StoredProcedure

                    .Parameters.AddWithValue("MUNKALAP_ID", Me.Tag)
                    .Parameters.AddWithValue("DOLG_ID", cmbDOLG_ID.SelectedValue)
                    .Parameters.AddWithValue("MUNORA", Double.Parse(txtMUNORA.Text))
                    .Parameters.AddWithValue("MUNDAT", dtMUNDAT.Value)
                End With    'sqlComm
                sqlConn.Open()
                sqlComm.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, ex.ToString)
            End Try
            LoadGrid()
        Else
            MsgBox("A teljesítményadatok megadása hibás vagy hiányos!", vbExclamation)
        End If
    End Sub

    Private Sub cmdTOROL_Click(sender As Object, e As EventArgs) Handles cmdTOROL.Click
        If MsgBox("Biztosan törölni szeretné?", vbYesNo + vbExclamation) = vbYes Then
            Try
                sqlConn = New SqlConnection(GlobalVars.sConnStr)
                Dim sqlComm = New SqlCommand("sp_DelTeljm", sqlConn)
                With sqlComm
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("pID", grdTELJ.SelectedRows(0).Cells(0).Value)
                End With    'sqlComm
                sqlConn.Open()
                sqlComm.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, ex.ToString)
            End Try

            LoadGrid()
            'util.TeljListFeltolt(txtID, Me)
        End If

    End Sub
End Class