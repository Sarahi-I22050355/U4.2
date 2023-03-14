Imports System.Net.Http.Headers

Public Class Electronico
    Private Property Price As Double
    Private Property Brand As String
    Private Property Model As String
    Public Property Price_() As Double
        Get
            Return Price
        End Get
        Set(ByVal value As Double)
            Price = value
        End Set
    End Property
    Public Property Brand_() As String
        Get
            Return Brand
        End Get
        Set(ByVal value As String)
            Brand = value
        End Set
    End Property
    Public Property Model_() As String
        Get
            Return Model
        End Get
        Set(ByVal value As String)
            Model = value
        End Set
    End Property
    Public ReadOnly Property IVA() As String
        Get
            Return Price * 0.16 + Price
        End Get
    End Property
    Public Sub New()
        Price = String.Empty
        Brand = String.Empty
        Model = String.Empty
    End Sub
    Public Sub New(ByVal Price As Double, ByVal Brand As String, ByVal Model As String)
        Me.Price_ = Price
        Me.Brand_ = Brand
        Me.Model_ = Model
    End Sub
End Class
