Option Explicit On

Imports ADODB
Imports System.io

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmVistaReportes
    Public CustomerReport As ReportDocument

    Private Sub frmVistaReportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.Refresh()
    End Sub
End Class