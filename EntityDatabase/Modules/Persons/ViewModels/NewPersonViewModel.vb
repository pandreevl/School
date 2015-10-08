Imports BusinessLogic.Helpers
Imports BusinessLogic.Services.Implementations
Imports BusinessLogic.Services.Interfaces
Imports System.Collections.ObjectModel
Imports BusinessObjects.Helpers
Imports Estructure.Helpers
Imports Modules.Persons.ViewModel

Namespace Modules.Persons.ViewModel
    Public Class NewPersonViewModel
        Inherits ViewModelBase

        Public _per As New Person
        Private _radioCheckedEmpl As Boolean
        Private _radioCheckedStud As Boolean
        Public _okButton As ICommand
        Public _cancelButton As ICommand
        Public _resetButton As ICommand
        Public _Ventana As NewPersonList

        Public Property FirstName As String
            Get
                Return Me._per.FirstName
            End Get
            Set(value As String)
                Me._per.FirstName = value
                OnPropertyChanged("FirstName")
            End Set
        End Property

        Public Property LastName As String
            Get
                Return Me._per.LastName
            End Get
            Set(value As String)
                Me._per.LastName = value
                OnPropertyChanged("LastName")
            End Set
        End Property

        Public ReadOnly Property OkButton As ICommand
            Get
                If Me._okButton Is Nothing Then
                    Me._okButton = New Command(AddressOf OkCommand)
                End If
                Return Me._okButton
            End Get
        End Property

        Public ReadOnly Property CancelButton As ICommand
            Get
                If Me._cancelButton Is Nothing Then
                    Me._cancelButton = New Command(AddressOf CancelCommand)
                End If
                Return Me._cancelButton
            End Get
        End Property

        Public ReadOnly Property ResetButton As ICommand
            Get
                If Me._resetButton Is Nothing Then
                    Me._resetButton = New Command(AddressOf ResetCommand)
                End If
                Return _resetButton
            End Get
        End Property

        Sub OkCommand()
            Try
                DataContext.DBEntities.Person.Add(_per)
                DataContext.DBEntities.SaveChanges()
                _Ventana.Close()
            Catch ex As Exception
                MsgBox("No se ha podido ingresar la persona", MsgBoxStyle.Critical)
            End Try
        End Sub

        Sub CancelCommand()

        End Sub

        Sub ResetCommand()
            _per = New Person
        End Sub

        Sub New(ByRef newVentana As NewPersonList)
            Me._Ventana = newVentana
        End Sub
    End Class
End Namespace
