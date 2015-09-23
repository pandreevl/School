Imports BusinessLogic.Services.Interfaces
Imports BusinessObjects.Helpers
Namespace BusinessLogic.Services.Implementations
    Public Class OnsiteCourseService
        Implements IOnsiteCourse

        Public Function GetAllOnlineCourse() As IQueryable(Of OnsiteCourse) Implements IOnsiteCourse.GetAllOnsiteCourse
            Return DataContext.DBEntities.OnsiteCourse
        End Function
    End Class
End Namespace
