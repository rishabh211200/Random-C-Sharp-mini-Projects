using System;
using Xunit;
using ExcelImportUsingEPPlus;

namespace ExcelImportTesting
{
    public class ExcelImportTest
    {
        [Fact]
        public void EmployeeObjNameTest()
        {
            SpreadSheetLoader loader = new();
            var assignments = SpreadSheetLoader.LoadAssignment();
            Assert.Equal("John Smith", assignments[0].EmployeeObj.Name);
        }
        [Fact]
        public void EmployeeObjTitleTest()
        {
            SpreadSheetLoader loader = new();
            var assignments = SpreadSheetLoader.LoadAssignment();
            Assert.Equal("Project Manager", assignments[5].EmployeeObj.Title);
        }
        [Fact]
        public void EmployeeObjIdMatch()
        {
            SpreadSheetLoader loader = new();
            var assignments = SpreadSheetLoader.LoadAssignment();
            Assert.Equal(assignments[2].Employee , assignments[2].EmployeeObj.ID);
        }
        [Fact]
        public void ProjectObjIdMatch()
        {
            SpreadSheetLoader loader = new();
            var assignments = SpreadSheetLoader.LoadAssignment();
            Assert.Equal(assignments[3].Project, assignments[3].ProjectObj.ID);
        }
        [Fact]
        public void ProjectObjDescriptionMatch()
        {
            SpreadSheetLoader loader = new();
            var assignments = SpreadSheetLoader.LoadAssignment();
            Assert.Equal("Global Container Management System", assignments[7].ProjectObj.Description);
        }
    }
}
