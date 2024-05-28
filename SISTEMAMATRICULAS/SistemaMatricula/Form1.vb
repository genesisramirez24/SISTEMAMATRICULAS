Imports System.Data.OleDb
Public Class frmMatricula
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=D:\SistemaMatricula\base de datos\matricula (2002-2003).mdb")
        Try
            con.Open()
            MsgBox("Conecatado")

            Dim query = "Select * from estudiante"
            Dim adap As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adap.Fill(dt)
            DataGridView1.DataSource = dt


        Catch ex As Exception
            MsgBox("No se conecto por: " & ex.Message)

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        FrmBuscar.Show()
    End Sub
End Class
