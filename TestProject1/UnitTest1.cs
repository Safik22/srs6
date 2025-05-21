namespace TestProject1
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void TestEmployeeCreation()
        {
            var employee = new Employee { Name = "Иван Иванов", Position = "Преподаватель" };
            Assert.IsNotNull(employee);
            Assert.AreEqual("Иван Иванов", employee.Name);
            Assert.AreEqual("Преподаватель", employee.Position);
        }

        [TestMethod]
        public void TestEmployeeValidation_NameEmpty()
        {
            var employee = new Employee { Name = "", Position = "Преподаватель" };
            var validationResult = ValidateEmployee(employee);
            Assert.IsFalse(validationResult);
        }

        private bool ValidateEmployee(Employee employee)
        {
            return !string.IsNullOrWhiteSpace(employee.Name) && !string.IsNullOrWhiteSpace(employee.Position);
        }
    }
}