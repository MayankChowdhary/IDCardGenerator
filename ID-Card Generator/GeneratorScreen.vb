Imports System.Data.SqlClient
Imports System.IO


Public Class GeneratorScreen
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim adapter As SqlDataAdapter
    Dim ds As DataSet
    Dim strCon As String
    Dim strQuery As String
    Dim photo_array() As Byte
    Dim Roll2 As Integer


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Visible = False

        PrintDocument1.DefaultPageSettings.PrinterSettings.PrinterName = "Microsoft XPS Document Writer"
        PrintDocument1.DefaultPageSettings.PaperSize = PrintDocument1.PrinterSettings.PaperSizes(11)
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintDialog1.Document = PrintDocument1

        Dim dialog As DialogResult

        dialog = PrintDialog1.ShowDialog()

        If (dialog = DialogResult.OK) Then
            PrintDocument1.Print()
        End If

        Button1.Visible = True
    End Sub

    Private Sub GeneratorScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Try
            Dim Fs As Integer = CInt(HomeScreen.DomainUpDown1.Text)
            Dim Fx As String = HomeScreen.ComboBox1.Text
            Dim Fs2 As Integer = CInt(HomeScreen.DomainUpDown2.Text)
            Dim Fx2 As String = HomeScreen.ComboBox2.Text

            Label1.Font = New Font(Fx2, Fs2 + 6, FontStyle.Bold)
            'Label17.Font = New Font(Fx2, Fs2 - 1, FontStyle.Bold)
            Label2.Font = New Font(Fx2, Fs2, FontStyle.Bold)
            Label3.Font = New Font(Fx, Fs, FontStyle.Bold)
            Label4.Font = New Font(Fx, Fs, FontStyle.Bold)
            Label5.Font = New Font(Fx, Fs, FontStyle.Bold)
            Label6.Font = New Font(Fx, Fs, FontStyle.Bold)
            Label7.Font = New Font(Fx, Fs, FontStyle.Bold)
            Label8.Font = New Font(Fx, Fs, FontStyle.Bold)
            Label9.Font = New Font(Fx, Fs, FontStyle.Bold)
            Label10.Font = New Font(Fx, Fs, FontStyle.Regular)
            Label11.Font = New Font(Fx, Fs, FontStyle.Regular)
            Label12.Font = New Font(Fx, Fs, FontStyle.Regular)
            Label13.Font = New Font(Fx, Fs, FontStyle.Regular)
            Label14.Font = New Font(Fx, Fs, FontStyle.Regular)
            Label15.Font = New Font(Fx, Fs, FontStyle.Regular)
            Label16.Font = New Font(Fx, Fs, FontStyle.Regular)
            Label18.Font = New Font(Fx, Fs, FontStyle.Bold)
            Label19.Font = New Font(Fx, Fs, FontStyle.Regular)

            GroupBox1.BackColor = HomeScreen.Button9.BackColor
            Panel1.BackColor = HomeScreen.Button10.BackColor
            Button1.Image = ImageList1.Images(0)
            'Button1.Image = Image.FromFile("D:/images/PRINT5.png").GetThumbnailImage(50, 50, Nothing, IntPtr.Zero)
            Roll2 = HomeScreen.Roll
            If HomeScreen.preview = True Then
                If HomeScreen.PictureBox1.Image.Equals(HomeScreen.PictureBox1.InitialImage) Then
                    Exit Sub
                End If
                PictureBox2.Image = HomeScreen.PictureBox1.Image
                PictureBox1.Image = HomeScreen.PictureBox2.Image
                Exit Sub

            End If
            strCon = "Data Source=.;AttachDbFilename=C:\Users\I'M Slave\Documents\IdCard_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
            strQuery = "Select * from IDcard where Roll =" + (Roll2).ToString
            con = New SqlConnection(strCon)
            con.ConnectionString = strCon
            cmd = New SqlCommand(strQuery, con)
            con.ConnectionString = strCon
            con.Open()
            Dim sqlReader As SqlDataReader = cmd.ExecuteReader
            If sqlReader.HasRows Then
                While sqlReader.Read
                    Label11.Text = sqlReader.GetValue(0)
                    Label10.Text = sqlReader.GetString(1)
                    Label1.Text = sqlReader.GetString(2)
                    Label13.Text = sqlReader.GetString(3)
                    Label12.Text = sqlReader.GetString(4)
                    Label14.Text = sqlReader.GetString(5)
                    Label15.Text = sqlReader.GetString(6)
                    Label16.Text = sqlReader.GetString(7)
                    If (sqlReader.Item(8) IsNot DBNull.Value) Then
                        photo_array = (sqlReader.GetValue(8))
                        Dim ms As New MemoryStream(photo_array)
                        PictureBox2.Image = Image.FromStream(ms)

                    End If
                    Label17.Text = sqlReader.GetString(9)
                    Label19.Text = sqlReader.GetString(10)
                    If (sqlReader.Item(11) IsNot DBNull.Value) Then
                        photo_array = (sqlReader.GetValue(11))
                        Dim ms2 As New MemoryStream(photo_array)
                        PictureBox1.Image = Image.FromStream(ms2)


                    End If
                End While
            Else
                MessageBox.Show("ID-Card Not Found", "ID-card Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ID-card Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Using bmp As New Bitmap(800, 546, Imaging.PixelFormat.Format64bppPArgb)
            bmp.SetResolution(300, 300)

            Panel1.DrawToBitmap(bmp, New Rectangle(0, 0, Panel1.Width, Panel1.Height))

            e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
            e.Graphics.DrawImage(bmp, e.MarginBounds)

        End Using

    End Sub

End Class