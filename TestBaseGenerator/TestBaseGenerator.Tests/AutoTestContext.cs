using System;
using Moq;
using TestBaseGenerator.Repository;

namespace TestBaseGenerator.Tests
{
	public partial class TestContext
	{
		public Mock<DepartmentRepository> MockDepartmentRepository = new Mock<DepartmentRepository>();
		public Mock<ProductRepository> MockProductRepository = new Mock<ProductRepository>();
		public Mock<UserRepository> MockUserRepository = new Mock<UserRepository>();
	}
}