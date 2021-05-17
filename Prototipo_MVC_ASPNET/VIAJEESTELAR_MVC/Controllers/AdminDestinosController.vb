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
    Public Class AdminDestinosController
        Inherits System.Web.Mvc.Controller

        Private db As New ViajeEstelarEntities2

        ' GET: AdminDestinos
        Function Index() As ActionResult
            Return View(db.Destino.ToList())
        End Function

        ' GET: AdminDestinos/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim destino As Destino = db.Destino.Find(id)
            If IsNothing(destino) Then
                Return HttpNotFound()
            End If
            Return View(destino)
        End Function

        ' GET: AdminDestinos/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: AdminDestinos/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID_DESTINO,NombreDestino,DescripcionDestino,UrlImagen")> ByVal destino As Destino) As ActionResult
            If ModelState.IsValid Then
                db.Destino.Add(destino)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(destino)
        End Function

        ' GET: AdminDestinos/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim destino As Destino = db.Destino.Find(id)
            If IsNothing(destino) Then
                Return HttpNotFound()
            End If
            Return View(destino)
        End Function

        ' POST: AdminDestinos/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID_DESTINO,NombreDestino,DescripcionDestino,UrlImagen")> ByVal destino As Destino) As ActionResult
            If ModelState.IsValid Then
                db.Entry(destino).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(destino)
        End Function

        ' GET: AdminDestinos/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim destino As Destino = db.Destino.Find(id)
            If IsNothing(destino) Then
                Return HttpNotFound()
            End If
            Return View(destino)
        End Function

        ' POST: AdminDestinos/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim destino As Destino = db.Destino.Find(id)
            db.Destino.Remove(destino)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
