Public Class Form1
    Sub findsb()
        Label1.Text = nam(Int(Rnd() * 47))
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        nam(0) = "陈韬涵"
        nam(1) = "陈勇昊"
        nam(2) = "戴润骞"
        nam(3) = "董丹兮"
        nam(4) = "顾旻昊"
        nam(5) = "顾生健"
        nam(6) = "何贶"
        nam(7) = "郭家铭"
        nam(8) = "郭贤瑞"
        nam(9) = "金朔平"
        nam(10) = "贾一帆"
        nam(11) = "李欣阳"
        nam(12) = "刘诚平"
        nam(13) = "林照"
        nam(14) = "沈钊"
        nam(15) = "施金羿"
        nam(16) = "汤煜彬"
        nam(17) = "王薪荃"
        nam(18) = "楼秦皓"
        nam(19) = "尚晋杭"
        nam(20) = "王子轩"
        nam(21) = "王詹子杭"
        nam(22) = "王予灿"
        nam(23) = "吴梓劲"
        nam(24) = "杨基伟"
        nam(25) = "王清扬"
        nam(26) = "周子鉴"
        nam(27) = "谢灏"
        nam(28) = "魏嘉"
        nam(29) = "吴赵润成"
        nam(30) = "吴特奥"
        nam(31) = "肖睿阳"
        nam(32) = "张嘉诺"
        nam(33) = "叶厚霖"
        nam(34) = "王侃如"
        nam(35) = "杨子诚"
        nam(36) = "於士杰"
        nam(37) = "周骏"
        nam(38) = "陈烁影"
        nam(39) = "俞高甜"
        nam(40) = "王梓璐"
        nam(41) = "郑理"
        nam(42) = "陈依林"
        nam(43) = "王奕欣"
        nam(44) = "潘彦茜"
        nam(45) = "傅一棋"
        nam(46) = "徐欣怡"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If CheckBox1.Checked Then
            If Int(Rnd() * 2) = 0 Then
                Label1.Text = "陈子休"
            Else
                Call findsb()
            End If
        Else
            Call findsb()
        End If
    End Sub

    Private Sub 关于ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem.Click
        MsgBox("由G_M_H开发，版本1.0beta")
        MsgBox("如果发现功能有误，请联系作者")
    End Sub
End Class
