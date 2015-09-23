Imports BusinessLogic.Helpers
Imports BusinessLogic.Services.Implementations
Imports BusinessLogic.Services.Interfaces
Imports System.Collections.ObjectModel

Namespace Modules.OfficeAssignments.ViewModels
    Public Class OfficeAssignmentsViewModel
        Inherits ViewModelBase

        Private _officeAsignments As ObservableCollection(Of OfficeAssignment)
        Private dataAccess As IOfficeAssignment

        Public Property OfficeAssignments As ObservableCollection(Of OfficeAssignment)
            Get
                Return Me._officeAsignments
            End Get
            Set(value As ObservableCollection(Of OfficeAssignment))
                Me._officeAsignments = value
                OnPropertyChanged("OfficeAssignments")
            End Set
        End Property

        ' Function to get all departments from service
        Private Function GetAllOfficeAssignment() As IQueryable(Of OfficeAssignment)
            Return Me.dataAccess.GetAllOfficeAssignment
        End Function

        Sub New()
            'Initialize property variable of departments
            Me._officeAsignments = New ObservableCollection(Of OfficeAssignment)
            ' Register service with ServiceLocator
            ServiceLocator.RegisterService(Of IOfficeAssignment)(New OfficeAssignmentService)
            ' Initialize dataAccess from service
            Me.dataAccess = GetService(Of IOfficeAssignment)()
            ' Populate departments property variable 
            For Each element In Me.GetAllOfficeAssignment
                Me._officeAsignments.Add(element)
            Next
        End Sub
    End Class
End Namespace
