Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports VIAJEESTELAR_MVC

Namespace Controllers
    Public Class DestinosController
        Inherits System.Web.Mvc.Controller

        Private db As New ViajeEstelarEntities2

        ' GET: Destinos
        Function Index() As ActionResult
            Return View(db.Destinos.ToList())
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
