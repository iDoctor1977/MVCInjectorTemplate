using System;
using System.Web.Mvc;
using Injector.Business;
using Injector.Business.BusinessLayer;
using Injector.Business.BusinessModel;
using Injector.Common.IEntity;
using Injector.Common.IModel;
using Injector.Common.IOperator;
using Injector.Common.IRepository;
using Injector.Common.ISupplier;
using Injector.Frontend;
using Injector.Frontend.Controllers;
using Injector.Frontend.Models.ViewModelsA;
using NSubstitute;
using NUnit.Framework;

namespace InjectorUnitTest.Test
{
    [TestFixture]
    public class OperatorATest
    {
        [Test]
        public void CreateEntityWithValidInput()
        {
            IEntityA entityA = new EntityAMock
            {
                Id = 1,
                Name = "Pippo",
                Surname = "Poppi"
            };

            IModelA modelA = new ModelA();
            modelA.Id = 1;
            modelA.Name = "Pippo";
            modelA.Surname = "Poppi";

            IRepositoryA repositoryASubstitute = Substitute.For<IRepositoryA>();
            repositoryASubstitute.CreateEntity(entityA);
            repositoryASubstitute.ReadEntityById(Arg.Any<int>()).Returns(entityA);

            IDataSupplier dataSupplierSubstitute = Substitute.For<IDataSupplier>();
            dataSupplierSubstitute.GenerateRepositoryA().Returns(repositoryASubstitute);

            IBusinessStore businessStoreSubstitute = Substitute.For<IBusinessStore>();
            businessStoreSubstitute.GetDataSupplier().Returns(dataSupplierSubstitute);
            businessStoreSubstitute.GetModelA().Returns(new ModelA());

            OperatorA operatorA = new OperatorA(businessStoreSubstitute);
            operatorA.CreateModel(modelA);
            var result = operatorA.ReadModel(1);

            Assert.IsInstanceOf<IModelA>(result as ModelA);
            Assert.AreEqual(modelA.Id, result.Id);
        }

        [Test]
        //[TestCase(ExpectedResult = "Pluto")]
        public void CreateWithValidInput()
        {
            // ARANGE
            IModelA viewModelA = new CreateViewModelA
            {
                Id = 1,
                Name = "Pippo",
                Surname = "Foia",
                TelNumber = "3315787943"
            };

            //IModelA modelASubstitute = Substitute.For<IModelA>();
            //modelASubstitute.Id = 3;
            //modelASubstitute.Name = "Pluto";
            //modelASubstitute.Surname = "Paperino";

            IOperatorA operatorASubstitute = Substitute.For<IOperatorA>();
            operatorASubstitute.ReadModel(Arg.Any<int>()).Returns(viewModelA);
            operatorASubstitute.CreateModel(viewModelA);

            //IBusinessStore businessStoreSubstitute = Substitute.For<IBusinessStore>();
            //businessStoreSubstitute.GetOperatorA().Returns(operatorASubstitute);

            IBusinessSupplier businessSupplierSubstitute = Substitute.For<IBusinessSupplier>();
            businessSupplierSubstitute.GenerateOperatorA().Returns(operatorASubstitute);

            IFrontendStore frontendStoreSubstitute = Substitute.For<IFrontendStore>();
            frontendStoreSubstitute.GetCreateViewModelA().Returns(viewModelA);
            frontendStoreSubstitute.GetBusinessSupplier().Returns(businessSupplierSubstitute);

            // ACT
            var homeController = new AController(frontendStoreSubstitute);
            ActionResult result = homeController.Index();

            // ASSERT
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsInstanceOf<IModelA>((result as ViewResult).Model);
            Assert.AreEqual(viewModelA, ((CreateViewModelA)(result as ViewResult).Model));

            //OperatorA operatorA = new OperatorA(new DataSupplierMock());

            //AController aController = new AController(new BusinessSupplierMock());
            //IModelA value = aController.operatorA.ReadModel(2);

            //viewModelA = operatorA.ReadModel(2);

            //Assert.IsInstanceOf<IModelA>(viewModelA);
            //Assert.AreEqual(3, viewModelA.Id);
            //Assert.AreEqual("Pluto", viewModelA.Name);
            //Assert.AreEqual("Paperino", viewModelA.Surname);

            //return viewModelA.Name;
        }
    }

    public class BusinessSupplierMock : IBusinessSupplier
    {
        public IOperatorA GenerateOperatorA()
        {
            return new OperatorAMock();
        }

        public IOperatorB GenerateOperatorB()
        {
            throw new NotImplementedException();
        }
    }

    public class OperatorAMock : IOperatorA
    {
        public void CreateModel(IModelA modelA)
        {
            throw new NotImplementedException();
        }

        public IModelA ReadModel(int id)
        {
            return new ModelAMock
            {
                Id = 3,
                Name = "Pluto",
                Surname = "Paperino"
            };
        }

        public IModelA ReadModelByName(string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateModel(IModelA modelA)
        {
            throw new NotImplementedException();
        }

        public void DeleteModel(IModelA modelA)
        {
            throw new NotImplementedException();
        }

        public string ToStringOperator()
        {
            throw new NotImplementedException();
        }

        public IModelA ConvertEntityAToModelA(IEntityA entityA)
        {
            throw new NotImplementedException();
        }

        public IEntityA ConvertModelAToEntityA(IModelA modelA)
        {
            throw new NotImplementedException();
        }
    }

    public class ModelAMock : IModelA
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    public class DataSupplierMock : IDataSupplier
    {
        public IRepositoryA GenerateRepositoryA()
        {
            RepositoryAMock repositoryAMock = new RepositoryAMock();
            return repositoryAMock;
        }

        public IRepositoryB GenerateRepositoryB()
        {
            throw new NotImplementedException();
        }
    }

    public class RepositoryAMock : IRepositoryA
    {
        public IEntityA ReadEntityById(int IdA)
        {
            return new EntityAMock
            {
                Id = 3,
                Name = "Pluto",
                Surname = "Paperino",
            };
        }

        public IEntityA ReadEntityByName(string name)
        {
            throw new NotImplementedException();
        }

        public void CreateEntity(IEntityA entityA)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(IEntityA entityA)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(IEntityA entityA)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public IEntityA GetConcreteEntityA()
        {
            throw new NotImplementedException();
        }

        public string ToStringRepository()
        {
            throw new NotImplementedException();
        }
    }

    public class EntityAMock : IEntityA
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
