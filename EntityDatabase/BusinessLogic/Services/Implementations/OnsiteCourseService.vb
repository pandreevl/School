Imports BusinessLogic.Services.Interfaces
Imports BusinessObjects.Helpers
Namespace BusinessLogic.Services.Implementations
    Public Class OnsiteCourseService
        Implements IOnlineCourseService

        Public Function GetAllOnlineCourse() As IQueryable(Of OnlineCourse) Implements IOnlineCourseService.GetAllOnlineCourse
            Return DataContext.DBEntities.OnsiteCourse
        End Function
    End Class
End Namespace
