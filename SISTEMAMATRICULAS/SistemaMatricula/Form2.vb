Imports System.Data.OleDb
Public Class frmGrafica
    Private Sub frmGrafica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source= D:\SistemaMatricula\base de datos\matricula (2002-2003).mdb")
        Try
            conexion.Open()
            MsgBox("Conectado")

            Dim query = "Select * from estudiante"
            Dim adap As New OleDbDataAdapter(query, conexion)
            Dim dt As New DataTable
            adap.Fill(dt)
            Chart1.Series("Series1").XValueMember = "nombreestudiante"
            Chart1.Series("Series1").YValueMembers = "edadEstudiante"
            Chart1.DataSource = dt


        Catch ex As Exception
            MsgBox("No se conecto por: " & ex.Message)

        End Try
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
End Class