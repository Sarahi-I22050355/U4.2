Public Class Computadora
    Inherits Electronico
    Private Property Os As String
    Private Property Processor As String
    Public Property Os_() As String
        Get
            Return Os
        End Get
        Set(ByVal value As String)
            Os = value
        End Set
    End Property
    Public Property Processor_() As String
        Get
            Return Processor
        End Get
        Set(ByVal value As String)
            Processor = value
        End Set
    End Property
    Public Sub New()
        Os = String.Empty
        Processor = String.Empty
    End Sub
    Public Sub New(ByRef Price As Double, ByVal Brand As String, ByVal Model As String, ByVal Os As String, ByVal Processor As String)
        MyBase.New(Price, Brand, Model)
        Me.Processor_ = Processor
        Me.Os_ = Os
    End Sub
End Class
