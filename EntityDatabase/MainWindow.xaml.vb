Imports Modules.Departments.ViewModels
Imports Modules.Courses.ViewModels
Imports Modules.OfficeAssignments.ViewModels
Imports Modules.OnlineCourses.ViewModels
Imports Modules.OnsiteCourses.ViewModels
Imports Modules.Persons.ViewModels

Class MainWindow
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DepartmenstUserControl.MainGrid.DataContext = New DepartmentsViewModel()
        Me.CoursesUserControl.MainGrid.DataContext = New CoursesViewModel()
        Me.OfficeAssignmentUserControl.MainGrid.DataContext = New OfficeAssignmentsViewModel()
        Me.OnlineCoursesUserControl.MainGrid.DataContext = New OnlineCoursesViewModel()
        Me.OnsiteCoursesUserControl.MainGrid.DataContext = New OnsiteCoursesViewModel()
        Me.PersonsUserControl.MainGrid.Datacontext = New PersonViewModel()


    End Sub
End Class
