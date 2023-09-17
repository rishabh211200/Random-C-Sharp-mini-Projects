using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ClosedXML.Excel;

namespace ExcelImportUsingEPPlus
{
    public class SpreadSheetLoader
    {
        public static List<Employees> LoadEmployee()
        {
            var employeesList = LoadList.GetList<Employees>(@"C:\Users\Rishabh.Gupta\Desktop\ExcelReadExercise.xlsx", "TeamMember");
            return employeesList;
        }
        public static List<Project> LoadProject()
        {
            var projectList = LoadList.GetList<Project>(@"C:\Users\Rishabh.Gupta\Desktop\ExcelReadExercise.xlsx", "Project");
            return projectList;
        }
        public static List<AssignmentSheet> LoadAssignmentSheet()
        {
            var assignmentSheetList = LoadList.GetList<AssignmentSheet>(@"C:\Users\Rishabh.Gupta\Desktop\ExcelReadExercise.xlsx", "Assignment");
            return assignmentSheetList;
        }
        public static List<Assignment> LoadAssignment()
        {
            List<Employees> employeeList = SpreadSheetLoader.LoadEmployee();
            List<Project> projectList = SpreadSheetLoader.LoadProject();
            List<AssignmentSheet> assignmentSheetList = SpreadSheetLoader.LoadAssignmentSheet();
            List<Assignment> assignmentList = new();

            for (int i = 0; i < assignmentSheetList.Count; i++)
            {
                Assignment assignmentObj = new(assignmentSheetList[i]);
                assignmentObj.EmployeeObj = employeeList.FirstOrDefault(x => x.ID == assignmentObj.Employee);
                assignmentObj.ProjectObj = projectList.FirstOrDefault(x => x.ID == assignmentObj.Project);
                assignmentList.Add(assignmentObj);
            }
            return assignmentList;
        }
    }
}
