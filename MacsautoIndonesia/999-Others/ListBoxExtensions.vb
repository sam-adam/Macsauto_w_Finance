Imports System.Runtime.InteropServices
Imports System.Runtime.CompilerServices

Module ListBoxExtensions
    ' Set tab stops inside a ListBox.
    <Extension()> _
    Public Sub SetTabs(ByVal lst As ListBox, ByVal tabs As  _
        IList(Of Integer))
        ' Make sure the control will use them.
        lst.UseTabStops = True
        lst.UseCustomTabOffsets = True

        ' Get the control's tab offset collection.
        Dim offsets As ListBox.IntegerCollection = _
            lst.CustomTabOffsets

        ' Define the tabs.
        For Each tab As Integer In tabs
            offsets.Add(tab)
        Next tab
    End Sub

    <DllImport("user32.dll", SetLastError:=True, _
        CharSet:=CharSet.Auto)> _
    Private Function SendMessage(ByVal hWnd As IntPtr, ByVal _
        Msg As UInteger, ByVal wParam As Integer, ByVal _
        lParam As Integer()) As IntPtr
    End Function

    Private Const EM_SETTABSTOPS As Integer = &HCB

    ' Set tab stops inside a TextBox.
    <Extension()> _
    Public Sub SetTabs(ByVal txt As TextBox, ByVal tabs As _
        Integer())
        SendMessage(txt.Handle, EM_SETTABSTOPS, tabs.Length, _
            tabs)
    End Sub
End Module
