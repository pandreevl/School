Imports BusinessLogic.Helpers
Imports BusinessLogic.Services.Implementations
Imports BusinessLogic.Services.Interfaces
Imports System.Collections.ObjectModel
Imports Estructure.Command
Namespace Modules.Persons.ViewModels
    Public Class PersonViewModel
        Inherits ViewModelBase
        Public Shadows person As NewPersons
        Private _person As ObservableCollection(Of Person)
        Private _insertButtonCommand As ICommand
        Private dataAccess As IPersonService

        Public Property Persons As ObservableCollection(Of Person)
            Get
                Return Me._person
            End Get
            Set(value As ObservableCollection(Of Person))
                Me._person = value
                OnPropertyChanged("Persons")
            End Set
        End Property
        Public Property InsertCommand As ICommand
            Get
                If Me._insertButtonCommand Is Nothing Then
                    Me._insertButtonCommand = New Commands(AddressOf InsertPersonDB)
                End If
                Return Me._insertButtonCommand
            End Get
            Set(value As ICommand)
                _insertButtonCommand = value
            End Set
        End Property

        Sub InsertPersonDB()
            Using context As New SchoolEntities
                person = New NewPersons
                Person.ShowDialog()

                refresh()
            End Using
        End Sub

        Sub refresh()
            'Initialize property variable of departments
            Me._person.Clear()
            ' Register service with ServiceLocator
            ServiceLocator.RegisterService(Of IPersonService)(New PersonService)
            ' Initialize dataAccess from service
            Me.dataAccess = GetService(Of IPersonService)()
            ' Populate departments property variable 
            For Each element In Me.GetAllPerson
                Me._person.Add(element)
            Next
        End Sub
        ' Function to get all departments from service
        Private Function GetAllPerson() As IQueryable(Of Person)
            Return Me.dataAccess.GetAllPerson

        End Function

        Sub New()
            'Initialize property variable of departments
            Me._person = New ObservableCollection(Of Person)
            ' Register service with ServiceLocator
            ServiceLocator.RegisterService(Of IPersonService)(New PersonService)
            ' Initialize dataAccess from service
            Me.dataAccess = GetService(Of IPersonService)()
            ' Populate departments property variable 
            For Each element In Me.GetAllPerson
                Me._person.Add(element)
            Next
        End Sub
    End Class
End Namespace
