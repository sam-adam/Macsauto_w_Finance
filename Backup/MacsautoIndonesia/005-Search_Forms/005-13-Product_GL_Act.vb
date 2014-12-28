Public Class _005_13_Product_GL_Act
    Public flag As String
    Public Sub loadGLData(ByVal actyp As String)
        reader = ExecQueryReader("SELECT GLNUM, GLDES FROM GLACCOUNTMS WHERE actid like '" + actyp + "' ")
        While reader.read
            GLSearch.Rows.Add(reader(0).ToString, reader(1).ToString)
        End While
        Marking(GLSearch)
    End Sub
    Private Sub _005_13_Product_GL_Act_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadGLData(flag)
    End Sub

    Private Sub GLSearch_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GLSearch.DoubleClick
        Dim gl As _002_01_Product = CType(Application.OpenForms("_002_01_Product"), _002_01_Product)
        gl.GLNumber.Text = GLSearch.CurrentRow.Cells(0).Value.ToString
        gl.GLDesc.Text = GLSearch.CurrentRow.Cells(1).Value.ToString
        Me.Close()
    End Sub
End Class