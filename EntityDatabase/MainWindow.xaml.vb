Imports Modules.Departments.ViewModels
Imports Modules.Courses.ViewModels 
Class MainWindow
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DepartmenstUserControl.MainGrid.DataContext = New DepartmentsViewModel()
        Me.CoursesUserControl.MainGrid.DataContext = New CoursesViewModel()
    End Sub
End Class
