Imports System.Data.OleDb
Public Class FrmBuscar
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=D:\SistemaMatricula\base de datos\matricula (2002-2003).mdb")
        Try
            con.Open()
            MsgBox("registro encontrado", , "Buscar")

            Dim query = "Select * from estudiante where nombreestudiante like '" & txtBuscar.Text & "%'"
        Dim adap As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adap.Fill(dt)
            DataGridView1.DataSource = dt


        Catch ex As Exception
            MsgBox("No se conecto por: " & ex.Message)

        End Try
    End Sub

    Private Sub btnGrafica_Click(sender As Object, e As EventArgs) Handles btnGrafica.Click
        frmGrafica.show()
    End Sub
End Class