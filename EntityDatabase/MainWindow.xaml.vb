Imports Modules.Departments.ViewModels
Imports Modules.Courses.ViewModels
Imports Modules.OfficeAssignments.ViewModels
Class MainWindow
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DepartmenstUserControl.MainGrid.DataContext = New DepartmentsViewModel()
        Me.CoursesUserControl.MainGrid.DataContext = New CoursesViewModel()
        Me.OfficeAssignmentUserControl.MainGrid.DataContext = New OfficeAssignmentsViewModel()
    End Sub
End Class
