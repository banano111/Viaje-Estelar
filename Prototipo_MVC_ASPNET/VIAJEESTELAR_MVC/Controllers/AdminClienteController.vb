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
    Public Class AdminClienteController
        Inherits System.Web.Mvc.Controller

        Private db As New ViajeEstelarEntities2

        ' GET: AdminCliente
        Function Index() As ActionResult
            Return View(db.Cliente.ToList())
        End Function

        ' GET: AdminCliente/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim cliente As Cliente = db.Cliente.Find(id)
            If IsNothing(cliente) Then
                Return HttpNotFound()
            End If
            Return View(cliente)
        End Function

        ' GET: AdminCliente/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: AdminCliente/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID_CLIENTE,Nombre,ApellidoP,ApellidoM,Edad,Direccion,Telefono")> ByVal cliente As Cliente) As ActionResult
            If ModelState.IsValid Then
                db.Cliente.Add(cliente)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(cliente)
        End Function

        ' GET: AdminCliente/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim cliente As Cliente = db.Cliente.Find(id)
            If IsNothing(cliente) Then
                Return HttpNotFound()
            End If
            Return View(cliente)
        End Function

        ' POST: AdminCliente/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID_CLIENTE,Nombre,ApellidoP,ApellidoM,Edad,Direccion,Telefono")> ByVal cliente As Cliente) As ActionResult
            If ModelState.IsValid Then
                db.Entry(cliente).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(cliente)
        End Function

        ' GET: AdminCliente/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim cliente As Cliente = db.Cliente.Find(id)
            If IsNothing(cliente) Then
                Return HttpNotFound()
            End If
            Return View(cliente)
        End Function

        ' POST: AdminCliente/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim cliente As Cliente = db.Cliente.Find(id)
            db.Cliente.Remove(cliente)
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
