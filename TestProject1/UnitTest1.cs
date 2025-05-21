namespace TestProject1
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void TestEmployeeCreation()
        {
            var employee = new Employee { Name = "���� ������", Position = "�������������" };
            Assert.IsNotNull(employee);
            Assert.AreEqual("���� ������", employee.Name);
            Assert.AreEqual("�������������", employee.Position);
        }

        [TestMethod]
        public void TestEmployeeValidation_NameEmpty()
        {
            var employee = new Employee { Name = "", Position = "�������������" };
            var validationResult = ValidateEmployee(employee);
            Assert.IsFalse(validationResult);
        }

        private bool ValidateEmployee(Employee employee)
        {
            return !string.IsNullOrWhiteSpace(employee.Name) && !string.IsNullOrWhiteSpace(employee.Position);
        }
    }
}