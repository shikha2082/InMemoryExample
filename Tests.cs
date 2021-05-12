using System.Linq;
using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using Interview.Models;

namespace Interview
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CanGetDepartmentList()
        {
            Repository<Department> repository = new Repository<Department>();

            var result = repository.All();

            Assert.IsInstanceOf<IEnumerable<Department>>(result);
        }

        [Test]
        public void CanSaveDepartment()
        {
            Department department = new Department() { Id = 1, DepartmentName = "XRey" };

            Repository<Department> repository = new Repository<Department>();

            repository.Save(department);

            var result = repository.All();

            Assert.IsTrue(((IEnumerable<Department>)result).Contains(department));
        }

        [Test]
        public void CanDeleteDepartment()
        {
            Department department = new Department() { Id = 1, DepartmentName = "XRey" };

            Repository<Department> repository = new Repository<Department>();

            repository.Save(department);

            var result = repository.All();

            Assert.IsTrue(((IEnumerable<Department>)result).Contains(department));

            repository.Delete(1);

            result = repository.All();

            Assert.IsFalse(((IEnumerable<Department>)result).Contains(department));

        }

        [Test]
        public void CanFindDepartmentById()
        {
            Repository<Department> repository = new Repository<Department>();

            Department salesDepartment = new Department() { Id = 1, DepartmentName = "Sales" };
            repository.Save(salesDepartment);
            Department hrDepartment = new Department() { Id = 2, DepartmentName = "HR" };
            repository.Save(hrDepartment);
            Department accountDepartment = new Department() { Id = 3, DepartmentName = "Accounts" };
            repository.Save(accountDepartment);

            Department department = repository.FindById(3);

            Assert.AreSame(department, accountDepartment, "Invalid Result");

        }

    }
}