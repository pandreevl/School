Imports BusinessLogic.Services.Interfaces
Imports BusinessObjects.Helpers
Namespace BusinessLogic.Services.Implementations
    Public Class OfficeAssignmentService
        Implements IOfficeAssignment

        Public Function GetAllOfficeAssignment() As IQueryable(Of OfficeAssignment) Implements IOfficeAssignment.GetAllOfficeAssignment
            Return DataContext.DBEntities.OfficeAssignment
        End Function
    End Class
End Namespace
