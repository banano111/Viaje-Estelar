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
    Public Class AdminProveedorController
        Inherits System.Web.Mvc.Controller

        Private db As New ViajeEstelarEntities2

        ' GET: AdminProveedor
        Function Index() As ActionResult
            Return View(db.Proveedor.ToList())
        End Function

        ' GET: AdminProveedor/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim proveedor As Proveedor = db.Proveedor.Find(id)
            If IsNothing(proveedor) Then
                Return HttpNotFound()
            End If
            Return View(proveedor)
        End Function

        ' GET: AdminProveedor/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: AdminProveedor/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID_PROVEEDOR,Nombre,RFC,Direccion,Telefono")> ByVal proveedor As Proveedor) As ActionResult
            If ModelState.IsValid Then
                db.Proveedor.Add(proveedor)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(proveedor)
        End Function

        ' GET: AdminProveedor/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim proveedor As Proveedor = db.Proveedor.Find(id)
            If IsNothing(proveedor) Then
                Return HttpNotFound()
            End If
            Return View(proveedor)
        End Function

        ' POST: AdminProveedor/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID_PROVEEDOR,Nombre,RFC,Direccion,Telefono")> ByVal proveedor As Proveedor) As ActionResult
            If ModelState.IsValid Then
                db.Entry(proveedor).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(proveedor)
        End Function

        ' GET: AdminProveedor/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim proveedor As Proveedor = db.Proveedor.Find(id)
            If IsNothing(proveedor) Then
                Return HttpNotFound()
            End If
            Return View(proveedor)
        End Function

        ' POST: AdminProveedor/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim proveedor As Proveedor = db.Proveedor.Find(id)
            db.Proveedor.Remove(proveedor)
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
