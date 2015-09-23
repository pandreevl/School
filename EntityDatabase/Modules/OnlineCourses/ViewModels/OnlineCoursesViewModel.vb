Imports BusinessLogic.Helpers
Imports BusinessLogic.Services.Implementations
Imports BusinessLogic.Services.Interfaces
Imports System.Collections.ObjectModel
Namespace Modules.OnlineCourses.ViewModels
    Public Class OnlineCoursesViewModel
        Inherits ViewModelBase

        Private _online As ObservableCollection(Of OnlineCourse)
        Private dataAccess As IOnlineCourseService

        Public Property OnlineCourse As ObservableCollection(Of OnlineCourse)
            Get
                Return Me._online
            End Get
            Set(value As ObservableCollection(Of OnlineCourse))
                Me._online = value
                OnPropertyChanged("OnlineCourse")
            End Set
        End Property

        ' Function to get all departments from service
        Private Function GetAllOnlineCourses() As IQueryable(Of OnlineCourse)
            Return Me.dataAccess.GetAllOnlineCourse
        End Function

        Sub New()
            'Initialize property variable of departments
            Me._online = New ObservableCollection(Of OnlineCourse)
            ' Register service with ServiceLocator
            ServiceLocator.RegisterService(Of IOnlineCourseService)(New OnlineCourseService)
            ' Initialize dataAccess from service
            Me.dataAccess = GetService(Of IOnlineCourseService)()
            ' Populate departments property variable 
            For Each element In Me.GetAllOnlineCourses
                Me._online.Add(element)
            Next
        End Sub
    End Class
End Namespace
