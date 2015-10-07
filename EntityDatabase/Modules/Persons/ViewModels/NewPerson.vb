Imports BusinessLogic.Helpers
Imports BusinessLogic.Services.Implementations
Imports BusinessLogic.Services.Interfaces
Imports System.Collections
Imports BusinessObjects.Helpers
Imports Estructure.Command
Imports Modules.Persons.ViewModel
Namespace Modules.Persons.ViewModel
    Public Class NewPerson
        Inherits ViewModelBase
        Public _Person As New Person
        Public _aceptAdd As ICommand
        Public _window As NewPersons

        Public Property FirstName As String
            Get
                Return Me._Person.FirstName
            End Get
            Set(value As String)
                Me._Person.FirstName = value
                OnPropertyChanged("FirstName")
            End Set

        End Property

        Public ReadOnly Property AceptedAdd As ICommand
            Get
                Return Me._aceptAdd

            End Get
        End Property

        Sub New(ByRef newWindow As NewPersons)
            Me._window = newWindow
        End Sub

    End Class
End Namespace