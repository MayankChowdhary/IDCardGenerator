Imports System.Data.SqlClient
Imports System.IO
Imports System
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Font
Imports System.Drawing.FontFamily
Imports System.Drawing.FontConverter


Public Class HomeScreen
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim adapter As SqlDataAdapter
    Dim ds As DataSet
    Dim rno As Integer
    Dim strSQLConn As String = "Data Source=.;AttachDbFilename=C:\Users\THOR\Documents\Visual Studio 2010\Projects\ID-Card Generator\ID-Card Generator\IdCard_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
    Dim strQuery As String
    Public Roll As Integer
    Public preview As Boolean
    Dim photo_array() As Byte
    Dim i As Integer = 0



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        Try
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        Catch ex As Exception
            MessageBox.Show("Please Select a Photo !!", "No Photos Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub
    Private Sub BindCombo()
        ComboBox1.DrawMode = DrawMode.OwnerDrawFixed
        ComboBox1.Font = New Font("Microsoft Sans Serif, 11.25pt", 11.25)
        ComboBox1.ItemHeight = 20
        Dim objFontFamily As FontFamily
        Dim objFontCollection As System.Drawing.Text.FontCollection

        objFontCollection = New System.Drawing.Text.InstalledFontCollection()
        For Each objFontFamily In objFontCollection.Families
            ComboBox1.Items.Add(objFontFamily.Name)

        Next
    End Sub
    Private Sub BindCombo2()
        ComboBox2.DrawMode = DrawMode.OwnerDrawFixed
        ComboBox2.Font = New Font("Microsoft Sans Serif, 11.25pt", 11.25)
        ComboBox2.ItemHeight = 20
        Dim objFontFamily As FontFamily
        Dim objFontCollection As System.Drawing.Text.FontCollection

        objFontCollection = New System.Drawing.Text.InstalledFontCollection()
        For Each objFontFamily In objFontCollection.Families
            ComboBox2.Items.Add(objFontFamily.Name)

        Next
    End Sub




    Private Sub ComboBox1_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ComboBox1.DrawItem
        e.DrawBackground()
        If (e.State And DrawItemState.Focus) <> 0 Then
            e.DrawFocusRectangle()
        End If
        Dim objBrush As Brush = Nothing
        Try
            objBrush = New SolidBrush(e.ForeColor)
            Dim _FontName As String = ComboBox1.Items(e.Index)
            Dim _font As Font
            Dim _fontfamily = New FontFamily(_FontName)
            If _fontfamily.IsStyleAvailable(FontStyle.Regular) Then
                _font = New Font(_fontfamily, 14, FontStyle.Regular)
            ElseIf _fontfamily.IsStyleAvailable(FontStyle.Bold) Then
                _font = New Font(_fontfamily, 14, FontStyle.Bold)
            ElseIf _fontfamily.IsStyleAvailable(FontStyle.Italic) Then
                _font = New Font(_fontfamily, 14, FontStyle.Italic)
            End If
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
            e.Graphics.DrawString(_FontName, _font, objBrush, e.Bounds)
#Enable Warning BC42104 ' Variable is used before it has been assigned a value

        Finally
            If objBrush IsNot Nothing Then
                objBrush.Dispose()
            End If
            objBrush = Nothing
        End Try
    End Sub
    Private Sub ComboBox2_DrawItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ComboBox2.DrawItem
        e.DrawBackground()
        If (e.State And DrawItemState.Focus) <> 0 Then
            e.DrawFocusRectangle()
        End If
        Dim objBrush As Brush = Nothing
        Try
            objBrush = New SolidBrush(e.ForeColor)
            Dim _FontName As String = ComboBox1.Items(e.Index)
            Dim _font As Font
            Dim _fontfamily = New FontFamily(_FontName)
            If _fontfamily.IsStyleAvailable(FontStyle.Regular) Then
                _font = New Font(_fontfamily, 14, FontStyle.Regular)
            ElseIf _fontfamily.IsStyleAvailable(FontStyle.Bold) Then
                _font = New Font(_fontfamily, 14, FontStyle.Bold)
            ElseIf _fontfamily.IsStyleAvailable(FontStyle.Italic) Then
                _font = New Font(_fontfamily, 14, FontStyle.Italic)
            End If
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
            e.Graphics.DrawString(_FontName, _font, objBrush, e.Bounds)
#Enable Warning BC42104 ' Variable is used before it has been assigned a value

        Finally
            If objBrush IsNot Nothing Then
                objBrush.Dispose()
            End If
            objBrush = Nothing
        End Try
    End Sub

    Private Sub HomeScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.CenterToScreen()

        SplashScreen.BarLong(100)

        While i < 25
            SplashScreen.SetStatus("Initializing...[" + i.ToString + "%]")
            SplashScreen.ShowBar(i)
            i += 1
            Threading.Thread.Sleep(40)
        End While
        SplashScreen.SetColor("Teal")
        While i < 50
            SplashScreen.SetStatus("Loading Components... [" + i.ToString + "%]")
            SplashScreen.ShowBar(i)
            i += 1
            Threading.Thread.Sleep(40)
        End While
        SplashScreen.SetColor("DarkMagenta")
        BindCombo()
        BindCombo2()
        Button2.Image = ImageList1.Images(3)
        'Image.FromFile("D:/images/setting.png").GetThumbnailImage(34, 34, Nothing, IntPtr.Zero)
        Button3.Image = ImageList1.Images(5)
        Button4.Image = ImageList1.Images(4).GetThumbnailImage(30, 30, Nothing, IntPtr.Zero)
        Button5.Image = ImageList1.Images(2)
        Button6.Image = ImageList1.Images(6)
        Button1.Image = ImageList1.Images(0)
        Button7.Image = ImageList1.Images(8)
        Button8.Image = ImageList1.Images(11)

        Button13.Image = ImageList1.Images(9).GetThumbnailImage(40, 40, Nothing, IntPtr.Zero)
        Button14.Image = ImageList1.Images(10)
        'Image.FromFile("D:/images/fill59.png").GetThumbnailImage(33, 33, Nothing, IntPtr.Zero)
        PictureBox1.Image = PictureBox1.InitialImage
        PictureBox2.Image = PictureBox2.InitialImage
        ' Button9.Image = Image.FromFile("D:/images/clpicker.jpg").GetThumbnailImage(30, 30, Nothing, IntPtr.Zero)

        While i < 75
            SplashScreen.SetStatus("Connecting Database...[" + i.ToString + "%]")
            SplashScreen.ShowBar(i)
            i += 1
            Threading.Thread.Sleep(40)
        End While
        SplashScreen.SetColor("DarkGreen")

        con = New SqlConnection(strSQLConn)
        loaddata()
        SplashScreen.ShowBar(100)
        SplashScreen.SetColor("DarkBlue")
        SplashScreen.SetStatus("Loading Completed... [100%]")
        Threading.Thread.Sleep(600)




    End Sub
    Sub loaddata()

        While i < 99
            SplashScreen.SetStatus("Loading Database...[" + i.ToString + "%]")
            SplashScreen.ShowBar(i)
            i += 1
            Threading.Thread.Sleep(40)
        End While

        adapter = New SqlDataAdapter("select * from IDcard", con)
        adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        ds = New DataSet

        adapter.Fill(ds, "IDcards")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Then

            MessageBox.Show("Please fillup all fields first!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Try
                con = New SqlConnection(strSQLConn)
                strQuery = "Insert into IDcard(Roll, Sname,Cname, dob, Blood_Grp, Program, Guardian, Address, Image, Description, Session,logo) Values (@Roll, @Sname, @Cname, @dob, @Blood_Grp,@Program,@Guardian, @Address, @Image,@Description,@Session, @logo)"
                Using con
                    cmd = New SqlCommand(strQuery, con)
                    con.ConnectionString = strSQLConn


                    cmd.Parameters.AddWithValue("Roll", TextBox1.Text)
                    cmd.Parameters.AddWithValue("Sname", TextBox2.Text)
                    cmd.Parameters.AddWithValue("Cname", TextBox8.Text)
                    cmd.Parameters.AddWithValue("dob", DateTimePicker1.Value.ToShortDateString)
                    cmd.Parameters.AddWithValue("Blood_Grp", TextBox4.Text)
                    cmd.Parameters.AddWithValue("Program", TextBox5.Text)
                    cmd.Parameters.AddWithValue("Guardian", TextBox6.Text)
                    cmd.Parameters.AddWithValue("Address", TextBox7.Text)
                    cmd.Parameters.AddWithValue("Description", TextBox9.Text)
                    cmd.Parameters.AddWithValue("Session", TextBox10.Text)
                    conv_photo()
                    conv_logo()
                    con.Open()
                    Dim n As Integer = cmd.ExecuteNonQuery
                    IDcardTableAdapter.Update(IdCard_DBDataSet)
                    con.Close()
                    If (n > 0) Then
                        MessageBox.Show("Record Successfully inserted !!", "Insert Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        loaddata()


                    Else
                        MessageBox.Show("Insertion Faild !!", "Insert Result", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
                GeneratorScreen.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Generation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try



        End If




    End Sub
    Public Sub conv_photo()
        If (PictureBox1.Image IsNot Nothing) Then
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, ImageFormat.Jpeg)

            Dim photo_array(ms.Length) As Byte

            ms.Position = 0
            ms.Read(photo_array, 0, photo_array.Length)
            cmd.Parameters.AddWithValue("Image", photo_array)






        End If
    End Sub
    Public Sub conv_logo()
        If (PictureBox2.Image IsNot Nothing) Then
            Dim ms As New MemoryStream
            PictureBox2.Image.Save(ms, ImageFormat.Jpeg)

            Dim photo_array(ms.Length) As Byte

            ms.Position = 0
            ms.Read(photo_array, 0, photo_array.Length)
            cmd.Parameters.AddWithValue("logo", photo_array)






        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Then

            MessageBox.Show("Please fillup all fields first!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Try


                Using con
                    strQuery = "update IDcard set Sname= @Sname, Cname= @Cname, dob= @dob, Blood_Grp= @Blood_Grp, Program= @Program, Guardian= @Guardian, Address=@Address, Image=@Image, Description=@Description, Session= @Session, logo=@logo where Roll = @Roll "
                    cmd = New SqlCommand(strQuery, con)
                    con.ConnectionString = strSQLConn
                    cmd.Parameters.AddWithValue("Roll", TextBox1.Text)
                    cmd.Parameters.AddWithValue("Sname", TextBox2.Text)
                    cmd.Parameters.AddWithValue("Cname", TextBox8.Text)
                    cmd.Parameters.AddWithValue("dob", DateTimePicker1.Value.ToShortDateString)
                    cmd.Parameters.AddWithValue("Blood_Grp", TextBox4.Text)
                    cmd.Parameters.AddWithValue("Program", TextBox5.Text)
                    cmd.Parameters.AddWithValue("Guardian", TextBox6.Text)
                    cmd.Parameters.AddWithValue("Address", TextBox7.Text)
                    cmd.Parameters.AddWithValue("Description", TextBox9.Text)
                    cmd.Parameters.AddWithValue("Session", TextBox10.Text)
                    conv_photo()
                    conv_logo()
                    con.Open()
                    Dim n As Integer = cmd.ExecuteNonQuery
                    IDcardTableAdapter.Update(IdCard_DBDataSet)
                    con.Close()

                    If (n > 0) Then
                        MessageBox.Show("Record Successfully Updated !!", "Update Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        loaddata()


                    Else
                        MessageBox.Show("Updation Faild !!", "Update Result", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
                GeneratorScreen.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Modification Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim temp As String = ""
            temp = Interaction.InputBox("Enter Roll no.", "Delete", "", 450, 300)


            If (temp <> "") Then

                Roll = CInt(temp)
                strQuery = "Delete  from IDcard where Roll = " + Roll.ToString
                cmd = New SqlCommand(strQuery, con)
                con.ConnectionString = strSQLConn
                con.Open()
                Dim n As Integer = cmd.ExecuteNonQuery()
                con.Close()
                If (n > 0) Then
                    MessageBox.Show("Record Successfully Deleted!!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loaddata()
                    IdCard_DBDataSet.Clear()
                    IDcardTableAdapter.Update(IdCard_DBDataSet)
                Else
                    MessageBox.Show("Record Not Found!!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub





    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        OpenFileDialog1.ShowDialog()
        Try
            PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)
        Catch ex As Exception
            MessageBox.Show("Please Select a Photo !!", "No Photos Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ComboBox1.Text = "Microsoft Sans Serif"
        ComboBox2.Text = "Century Gothic"
        DomainUpDown1.Text = "9"
        DomainUpDown2.Text = "10"
        DateTimePicker1.Value = Today

        Label14.Font = New Font(ComboBox1.Text, 8, FontStyle.Regular)
        Label15.Font = New Font(ComboBox1.Text, 10, FontStyle.Regular)
        Button9.BackColor = Color.LightSalmon
        Button10.BackColor = Color.Bisque
        PictureBox1.Image = PictureBox1.InitialImage
        PictureBox2.Image = PictureBox2.InitialImage
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()

        TextBox9.Clear()
        TextBox10.Clear()
        Interaction.Beep()

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                If Asc(e.KeyChar) > 65 Then

                    MessageBox.Show("Numbers Only!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If

            End If

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try

            If TextBox1.Text <> "" Then
                Roll = CInt(TextBox1.Text)
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("Roll Number Overflow!!", "Overflow Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim temp As String = ""
            temp = Interaction.InputBox("Enter Roll no.", "Retrieve", "", 450, 300)
            If (temp <> "") Then

                Roll = CInt(temp)
                'CInt(Interaction.InputBox("Enter Roll no.", "Retrieve", "1505005984", 250, 250))
                GeneratorScreen.Show()
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Retrieve Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        DatabaseScreen.Show()

    End Sub



    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Button9.BackColor = ColorDialog1.Color

        End If
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Button10.BackColor = ColorDialog1.Color
        End If
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label14.Font = New Font(ComboBox1.Text, CInt(DomainUpDown1.Text), FontStyle.Regular)
    End Sub


    Private Sub DomainUpDown1_SelectedItemChanged(sender As System.Object, e As System.EventArgs) Handles DomainUpDown1.SelectedItemChanged
        Try
            Label14.Font = New Font(ComboBox1.Text, CInt(DomainUpDown1.Text), FontStyle.Regular)
        Catch ex As Exception


        End Try
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Label15.Font = New Font(ComboBox2.Text, CInt(DomainUpDown2.Text), FontStyle.Regular)
    End Sub

    Private Sub DomainUpDown2_SelectedItemChanged(sender As System.Object, e As System.EventArgs) Handles DomainUpDown2.SelectedItemChanged
        Try
            Label15.Font = New Font(ComboBox2.Text, CInt(DomainUpDown2.Text), FontStyle.Regular)
        Catch ex As Exception


        End Try
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click

        preview = "True"
        GeneratorScreen.Show()
        preview = "False"


    End Sub



    Private Sub Button14_Click_1(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        Try
            Dim temp As String = ""
            temp = Interaction.InputBox("Enter Roll no.", "Quick Fill", "", 450, 300)
            If (temp <> "") Then

                Roll = CInt(temp)
                'CInt(Interaction.InputBox("Enter Roll no.", "Retrieve", "1505005984", 250, 250))
                strQuery = "Select * from IDcard where Roll =" + (Roll).ToString
                con = New SqlConnection(strSQLConn)
                con.ConnectionString = strSQLConn
                cmd = New SqlCommand(strQuery, con)
                con.ConnectionString = strSQLConn
                con.Open()
                Dim sqlReader As SqlDataReader = cmd.ExecuteReader
                If sqlReader.HasRows Then
                    While sqlReader.Read
                        TextBox1.Text = sqlReader.GetValue(0)
                        TextBox2.Text = sqlReader.GetString(1)
                        TextBox8.Text = sqlReader.GetString(2)
                        DateTimePicker1.Value = CDate(sqlReader.GetString(3))
                        TextBox4.Text = sqlReader.GetString(4)
                        TextBox5.Text = sqlReader.GetString(5)
                        TextBox6.Text = sqlReader.GetString(6)
                        TextBox7.Text = sqlReader.GetString(7)
                        If (sqlReader.Item(8) IsNot DBNull.Value) Then
                            photo_array = (sqlReader.GetValue(8))
                            Dim ms As New MemoryStream(photo_array)
                            PictureBox1.Image = Image.FromStream(ms)

                        End If
                        TextBox9.Text = sqlReader.GetString(9)
                        TextBox10.Text = sqlReader.GetString(10)
                        If (sqlReader.Item(11) IsNot DBNull.Value) Then
                            photo_array = (sqlReader.GetValue(11))
                            Dim ms2 As New MemoryStream(photo_array)
                            PictureBox2.Image = Image.FromStream(ms2)


                        End If
                    End While
                    con.Close()
                    MessageBox.Show("Quick Fill Succesfully Completed!", "Quick Fill", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    MessageBox.Show("ID-Card Not Found", "ID-card Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Quick Fill Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
