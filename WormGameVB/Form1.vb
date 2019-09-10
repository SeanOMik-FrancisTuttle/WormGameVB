Public Class Form1
    Dim boolCanFinish As Boolean = False
    Dim decSlidingWallY As Decimal = 0.0

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        MoveToStart()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub LblFinish_Enter(sender As Object, e As EventArgs) Handles lblFinish.MouseEnter
        If boolCanFinish Then
            MessageBox.Show("Well Done!")
            Close()
        End If
    End Sub

    Private Sub MoveToStart()
        Dim StartingPoint = Panel1.Location
        StartingPoint.Offset(10, 35)
        Cursor.Position = PointToScreen(StartingPoint)
    End Sub

    Private Sub Wall_MouseEnter(sender As Object, e As EventArgs) Handles Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label5.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter, lblDoor.MouseEnter
        boolCanFinish = False
        MoveToStart()
    End Sub

    Private Sub LblStart_Enter(sender As Object, e As EventArgs) Handles lblStart.MouseEnter
        boolCanFinish = True
    End Sub

    Private Sub BtnDoor_Click(sender As Object, e As EventArgs) Handles btnDoor.Click
        If boolCanFinish Then
            lblDoor.Visible = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If lblSlidingWall1.Location.Y >= 50 Then
        '    decSlidingWallY -= 1
        '    lblSlidingWall1.Location = New Point(lblSlidingWall1.Location.Y - 1)
        'ElseIf lblSlidingWall1.Location.Y <= 22 Then
        '    decSlidingWallY += 1
        '    lblSlidingWall1.Location = New Point(lblSlidingWall1.Location.Y + 1)
        'End If

    End Sub
End Class
