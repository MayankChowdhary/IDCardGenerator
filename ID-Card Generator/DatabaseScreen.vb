Imports System.Data.SqlClient

Public Class DatabaseScreen
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim adapter As SqlDataAdapter
    Dim ds As New DataSet
    Dim rno As Integer
    Dim strSQLConn As String = "Data Source=.;AttachDbFilename=C:\Users\I'M Slave\Documents\IdCard_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
    Dim strQuery As String = "Select  * from IDcard"
    Public Roll As Integer


    Private Sub DatabaseScreen_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Try
            'TODO: This line of code loads data into the 'IdCard_DBDataSet1.IDcard' table. You can move, or remove it, as needed.
            Me.IDcardTableAdapter.Fill(Me.IdCard_DBDataSet.IDcard)
            con = New SqlConnection(strSQLConn)
            cmd = New SqlCommand(strQuery, con)
            con.ConnectionString = strSQLConn
            con.Open()
            adapter = New SqlDataAdapter(cmd)
            adapter.Fill(ds, "IDcards")
            DataGridView1.DataSource = ds.Tables(0)
            Dim flag As Integer

            flag = ds.Tables(0).Rows.Count
            For i As Integer = 0 To flag
                Dim row As DataGridViewRow = DataGridView1.Rows(i)
                row.Height = 128
            Next

            DirectCast(DataGridView1.Columns(8), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom
            DirectCast(DataGridView1.Columns(11), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom
        Catch ex As Exception
            MessageBox.Show(ex.Message, "View Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            HomeScreen.Roll = CInt(DataGridView1.Item(columnIndex:=0, rowIndex:=e.RowIndex).Value)
            GeneratorScreen.Show()
        Catch ex As Exception

        End Try


    End Sub
End Class