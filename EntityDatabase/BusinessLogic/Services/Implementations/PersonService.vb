Imports BusinessLogic.Services.Interfaces
Imports BusinessObjects.Helpers
Namespace BusinessLogic.Services.Implementations
    Public Class PersonService
        Implements IPersonService

        Public Function GetAllPerson() As IQueryable(Of Person) Implements IPersonService.GetAllPerson
            Return DataContext.DBEntities.Person
        End Function
    End Class
End Namespace
