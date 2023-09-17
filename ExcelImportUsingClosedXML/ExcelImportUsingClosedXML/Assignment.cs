namespace ExcelImportUsingEPPlus
{
    public class Assignment : AssignmentSheet
    {
        public Employees EmployeeObj { get; set; }
        public Project ProjectObj { get; set; }
        public Assignment() { }
        public Assignment(AssignmentSheet assignmentSheet)
        {
            ID = assignmentSheet.ID;
            Employee = assignmentSheet.Employee;
            Project = assignmentSheet.Project;
            Date = assignmentSheet.Date;
        }

    }
}
