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
    Public Class AdminVentasController
        Inherits System.Web.Mvc.Controller

        Private db As New ViajeEstelarEntities2

        ' GET: AdminVentas
        Function Index() As ActionResult
            Return View(db.Venta.ToList())
        End Function

        ' GET: AdminVentas/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim venta As Venta = db.Venta.Find(id)
            If IsNothing(venta) Then
                Return HttpNotFound()
            End If
            Return View(venta)
        End Function

        ' GET: AdminVentas/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: AdminVentas/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID_VENTA,PaqueteVendido,Total,FechaVenta,UsuarioComprador")> ByVal venta As Venta) As ActionResult
            If ModelState.IsValid Then
                db.Venta.Add(venta)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(venta)
        End Function

        ' GET: AdminVentas/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim venta As Venta = db.Venta.Find(id)
            If IsNothing(venta) Then
                Return HttpNotFound()
            End If
            Return View(venta)
        End Function

        ' POST: AdminVentas/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID_VENTA,PaqueteVendido,Total,FechaVenta,UsuarioComprador")> ByVal venta As Venta) As ActionResult
            If ModelState.IsValid Then
                db.Entry(venta).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(venta)
        End Function

        ' GET: AdminVentas/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim venta As Venta = db.Venta.Find(id)
            If IsNothing(venta) Then
                Return HttpNotFound()
            End If
            Return View(venta)
        End Function

        ' POST: AdminVentas/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim venta As Venta = db.Venta.Find(id)
            db.Venta.Remove(venta)
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
