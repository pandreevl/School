﻿Imports BusinessLogic.Services.Interfaces
Imports BusinessObjects.Helpers
Namespace BusinessLogic.Services.Implementations
    Public Class StudentGradeService
        Implements IStudentGradeService

        Public Function GetAllStudenGrade() As IQueryable(Of StudentGrade) Implements IStudentGradeService.GetAllStudentGrade
            Return DataContext.DBEntities.StudentGrade
        End Function
    End Class
End Namespace
