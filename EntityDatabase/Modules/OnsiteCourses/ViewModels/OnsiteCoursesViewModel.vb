Imports BusinessLogic.Helpers
Imports BusinessLogic.Services.Implementations
Imports BusinessLogic.Services.Interfaces
Imports System.Collections.ObjectModel

Namespace Modules.OnsiteCourses.ViewModels
    Public Class OnsiteCoursesViewModel
        Inherits ViewModelBase

        Private _onsitecourses As ObservableCollection(Of OnsiteCourse)
        Private dataAccess As IOnsiteCourse

        Public Property OnsiteCourses As ObservableCollection(Of OnsiteCourse)
            Get
                Return Me._onsitecourses
            End Get
            Set(value As ObservableCollection(Of OnsiteCourse))
                Me._onsitecourses = value
                OnPropertyChanged("OnsiteCourse")
            End Set
        End Property

        ' Function to get all departments from service
        Private Function GetAllOnsiteCourse() As IQueryable(Of OnsiteCourse)
            Return Me.dataAccess.GetAllOnsiteCourse
        End Function

        Sub New()
            'Initialize property variable of departments
            Me._onsitecourses = New ObservableCollection(Of OnsiteCourse)
            ' Register service with ServiceLocator
            ServiceLocator.RegisterService(Of IOnsiteCourse)(New OnsiteCourseService)
            ' Initialize dataAccess from service
            Me.dataAccess = GetService(Of IOnsiteCourse)()
            ' Populate departments property variable 
            For Each element In Me.GetAllOnsiteCourse
                Me._onsitecourses.Add(element)
            Next
        End Sub
    End Class
End Namespace
