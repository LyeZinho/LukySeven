Imports LukySeven.SpinFunctions

Public Class Form1
    Dim tryes As Short
    Dim wins As Short

    Private Sub BtSpin_Click(sender As Object, e As EventArgs) Handles BtSpin.Click

        Dim Vaule_1, Vaule_2, Vaule_3 As Integer
        Dim Result As Boolean

        BtWin.Visible = False
        PcbImg1.Visible = False
        PcbImg2.Visible = False
        PcbImg3.Visible = False

        Vaule_1 = SpinFunctions.Gen(1, 7)
        Vaule_2 = SpinFunctions.Gen(1, 7)
        Vaule_3 = SpinFunctions.Gen(1, 7)

        BtDisplay_1.Text = Vaule_1.ToString
        BtDisplay_2.Text = Vaule_2.ToString
        BtDisplay_3.Text = Vaule_3.ToString

        Result = SpinFunctions.WinCheck(Vaule_1, Vaule_2, Vaule_3)
        If Result = True Then
            PcbImg1.Visible = True
            PcbImg2.Visible = True
            PcbImg3.Visible = True
            BtWin.Visible = True
            wins = wins + 1
            BtWinRate.Text = SpinFunctions.WinRate(tryes, wins)
        End If
        tryes = tryes + 1
        BtTryes.Text = tryes.ToString

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtWin.Visible = False
        PcbImg1.Visible = False
        PcbImg2.Visible = False
        PcbImg3.Visible = False
    End Sub

    Private Sub BtEnd_Click(sender As Object, e As EventArgs) Handles BtEnd.Click
        Me.Close()
    End Sub
End Class
