Imports System.ComponentModel.DataAnnotations
Imports System.Globalization
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Public Class Form1
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvInventory.View = View.Details
        lvInventory.FullRowSelect = True
        lvInventory.Clear()
        Dim rutaArchivo As String = "C:\Users\Sarah\OneDrive\Escritorio\inventario.txt"
        Dim SR As New StreamReader(rutaArchivo, Encoding.UTF8)
        Dim Columnas As String = SR.ReadLine()
        Dim Separador() As String = Columnas.Split(","c)
        For i As Integer = 0 To Separador.Length - 1
            lvInventory.Columns.Add(Separador(i), 100)
        Next

        Dim renglon As String
        While InlineAssignHelper(renglon, SR.ReadLine()) IsNot Nothing
            Dim datos() As String = renglon.Split(",")
            Dim item As New ListViewItem(datos(0))
            For i As Integer = 1 To datos.Length - 1
                item.SubItems.Add(datos(i))
            Next
            lvInventory.Items.Add(item)
        End While
        SR.Close()
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If String.IsNullOrEmpty(txtPrice.Text) OrElse String.IsNullOrEmpty(txtModel.Text) OrElse String.IsNullOrEmpty(cbBrand.Text) OrElse String.IsNullOrEmpty(cbOS.Text) OrElse String.IsNullOrEmpty(cbProcessor.text)Then
            MessageBox.Show("Please enter the complete data.")
            Return
        End If
        Dim electronicos As New Computadora(txtPrice.Text, cbBrand.Text, txtModel.Text, cbOS.Text, cbProcessor.Text)
        Dim item As New ListViewItem(New String() {electronicos.Price_, electronicos.IVA, electronicos.Brand_, electronicos.Model_, electronicos.Processor_, electronicos.Os_})
        lvInventory.Items.Add(item)
        txtPrice.Clear()
        txtModel.Clear()
        cbBrand.Focus()
        cbOS.Focus()
        cbProcessor.Focus()
    End Sub
    Private Sub lvInventory_KeyDown(sender As Object, e As KeyEventArgs) Handles lvInventory.KeyDown
        If e.KeyCode = Keys.Delete Then
            For Each seleccion As ListViewItem In lvInventory.SelectedItems
                seleccion.Remove()
            Next
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim rutaArchivo As String = "C:\Users\Sarah\OneDrive\Escritorio\inventario.txt"
        Dim sw As New StreamWriter(rutaArchivo)
        Dim Header As String = ""
        For i As Integer = 0 To lvInventory.Columns.Count - 2
            Header += lvInventory.Columns(i).Text & ","
        Next
        Header += lvInventory.Columns(lvInventory.Columns.Count - 1).Text
        sw.WriteLine(Header)
        For Each renglon As ListViewItem In lvInventory.Items
            Dim r As String = ""
            For i As Integer = 0 To renglon.SubItems.Count - 2
                r += renglon.SubItems(i).Text & ","
            Next
            r += renglon.SubItems(renglon.SubItems.Count - 1).Text
            sw.WriteLine(r)
        Next
        sw.Close()
    End Sub
End Class
