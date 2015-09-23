Imports BusinessLogic.Services.Interfaces
Imports BusinessObjects.Helpers
Namespace BusinessLogic.Services.Implementations
    Public Class CourseService
        Implements ICourseService

        Public Function GetAllCourse() As IQueryable(Of Course) Implements ICourseService.GetAllCourse
            Return DataContext.DBEntities.Course
        End Function
    End Class
End Namespace
