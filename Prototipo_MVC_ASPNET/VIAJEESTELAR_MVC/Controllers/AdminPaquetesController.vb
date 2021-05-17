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
    Public Class AdminPaquetesController
        Inherits System.Web.Mvc.Controller

        Private db As New ViajeEstelarEntities2

        ' GET: AdminPaquetes
        Function Index() As ActionResult
            Return View(db.Paquete.ToList())
        End Function

        ' GET: AdminPaquetes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim paquete As Paquete = db.Paquete.Find(id)
            If IsNothing(paquete) Then
                Return HttpNotFound()
            End If
            Return View(paquete)
        End Function

        ' GET: AdminPaquetes/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: AdminPaquetes/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID_PAQUETE,NombrePaquete,DescripcionPaquete,UrlImagen,Precio,Descuento,PrecioFinal,Fecha")> ByVal paquete As Paquete) As ActionResult
            If ModelState.IsValid Then
                db.Paquete.Add(paquete)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(paquete)
        End Function

        ' GET: AdminPaquetes/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim paquete As Paquete = db.Paquete.Find(id)
            If IsNothing(paquete) Then
                Return HttpNotFound()
            End If
            Return View(paquete)
        End Function

        ' POST: AdminPaquetes/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID_PAQUETE,NombrePaquete,DescripcionPaquete,UrlImagen,Precio,Descuento,PrecioFinal,Fecha")> ByVal paquete As Paquete) As ActionResult
            If ModelState.IsValid Then
                db.Entry(paquete).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(paquete)
        End Function

        ' GET: AdminPaquetes/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim paquete As Paquete = db.Paquete.Find(id)
            If IsNothing(paquete) Then
                Return HttpNotFound()
            End If
            Return View(paquete)
        End Function

        ' POST: AdminPaquetes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim paquete As Paquete = db.Paquete.Find(id)
            db.Paquete.Remove(paquete)
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
