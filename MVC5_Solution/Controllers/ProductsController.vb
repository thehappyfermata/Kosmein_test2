﻿Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports MVC5_Solution.Models

Namespace Controllers
    Public Class ProductsController
        Inherits System.Web.Mvc.Controller

        Private db As New ProductDbContext

        ' GET: Products
        Function Index() As ActionResult
            Return View(db.Product.ToList())
        End Function

        ' GET: Products/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim product As Product = db.Product.Find(id)
            If IsNothing(product) Then
                Return HttpNotFound()
            End If
            Return View(product)
        End Function

        ' GET: Products/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Products/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID,Title,Description,Remaining,Price")> ByVal product As Product) As ActionResult
            If ModelState.IsValid Then
                db.Product.Add(product)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(product)
        End Function

        ' GET: Products/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim product As Product = db.Product.Find(id)
            If IsNothing(product) Then
                Return HttpNotFound()
            End If
            Return View(product)
        End Function

        ' POST: Products/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID,Title,Description,Remaining,Price")> ByVal product As Product) As ActionResult
            If ModelState.IsValid Then
                db.Entry(product).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(product)
        End Function

        ' GET: Products/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim product As Product = db.Product.Find(id)
            If IsNothing(product) Then
                Return HttpNotFound()
            End If
            Return View(product)
        End Function

        ' POST: Products/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim product As Product = db.Product.Find(id)
            db.Product.Remove(product)
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
