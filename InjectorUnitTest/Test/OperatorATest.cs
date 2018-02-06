using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Injector.Common.DTOModel;
using Injector.Common.IABase;
using Injector.Common.IBind;
using Injector.Common.IEntity;
using Injector.Common.IFeature;
using Injector.Common.IModel;
using Injector.Common.IRepository;
using Injector.Common.IStore;
using Injector.Common.ISupplier;
using Injector.Common.IVModel;
using Injector.Frontend.Controllers;
using Injector.Frontend.Models;
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
                Id = Guid.NewGuid(),
                Name = "Pippo",
                Surname = "Poppi"
            };

            ModelA modelA = new ModelA
            {
                Id = Guid.NewGuid(),
                Name = "Pippo",
                Surname = "Poppi"
            };

            IRepositoryA repositoryASubstitute = Substitute.For<IRepositoryA>();
            repositoryASubstitute.CreateEntity(modelA);
            repositoryASubstitute.ReadEntityById(Arg.Any<Guid>()).Returns(entityA);

            IDataSupplier dataSupplierSubstitute = Substitute.For<IDataSupplier>();
            dataSupplierSubstitute.GetRepositoryA.Returns(repositoryASubstitute);

            ICoreBind coreBondSubstitute = Substitute.For<ICoreBind>();
            coreBondSubstitute.BindDataSupplier.Returns(dataSupplierSubstitute);
            coreBondSubstitute.BindSharingSupplier.GetModelA().Returns(new ModelA());

            VMCreateAMock vmCreateAMock = new VMCreateAMock
            {
                DTOModelA = modelA
            };
            VMDetailsAMock vmDetailsAMock = new VMDetailsAMock();

            //LogicAMock logicA = new LogicAMock();
            //logicA.CreatePost(vmCreateAMock);
            //var result = logicA.DetailsGet(vmDetailsAMock);

            //Assert.IsInstanceOf<IModelA>(result as ModelA);
            //Assert.AreEqual(modelA.Id, result.DTOModelA.Id);
        }

        [Test]
        //[TestCase(ExpectedResult = "Pluto")]
        public void CreateWithValidInput()
        {
            // ARANGE
            VMDetailsA vmDetailsA = new VMDetailsA
            {
                DTOModelA = new ModelA
                {
                    Id = Guid.NewGuid(),
                    Name = "Pippo",
                    Surname = "Foia",
                },
            };

            //IModelA modelASubstitute = Substitute.For<IModelA>();
            //modelASubstitute.Id = 3;
            //modelASubstitute.Name = "Pluto";
            //modelASubstitute.Surname = "Paperino";

            IFeatureA featureASubstitute = Substitute.For<IFeatureA>();
            featureASubstitute.DetailsGet(Arg.Any<VMDetailsA>()).Returns(vmDetailsA);

            //IBusinessStore businessStoreSubstitute = Substitute.For<IBusinessStore>();
            //businessStoreSubstitute.GetOperatorA().Returns(operatorASubstitute);

            ICoreSupplier coreSupplierSubstitute = Substitute.For<ICoreSupplier>();
            coreSupplierSubstitute.GetFeatureA.Returns(featureASubstitute);

            IWebStore webStoreSubstitute = Substitute.For<IWebStore>();
            webStoreSubstitute.NewVMDetailsA.Returns(vmDetailsA);
            webStoreSubstitute.StoreCoreSupplier.Returns(coreSupplierSubstitute);

            // ACT
            var homeController = new AController(webStoreSubstitute);
            ActionResult result = homeController.List();

            // ASSERT
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsInstanceOf<IModelA>((result as ViewResult).Model);
            Assert.AreEqual(vmDetailsA, ((VMCreateA)(result as ViewResult).Model));

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

    public class VMDetailsAMock : IVMDetailsA
    {
        public ModelA DTOModelA { get; set; }
    }

    public class VMCreateAMock : IVMCreateA
    {
        public ModelA DTOModelA { get; set; }
    }

    public class ABaseCoreSupplierMock : IABaseCoreSupplier
    {
        public ICoreBind ABaseBind { get; set; }
        public ICoreStore ABaseStore { get; set; }
    }

    public class CoreSupplierMock : ICoreSupplier
    {
        public IFeatureA GetFeatureA { get; }
        public IFeatureB GetFeatureB { get; }
    }

    public class ABaseDataSupplierMock : IABaseDataSupplier
    {
        public IDataStore SupplierDataStore { get; set; }
    }

    public class DataSupplierMock : IDataSupplier
    {
        public IRepositoryA GetRepositoryA => new RepositoryAMock();

        public IRepositoryB GetRepositoryB { get; }
    }

    public class ABaseRepositoryMock : IABaseRepository
    {
        public IDataStore ABaseStore { get; set; }

        public ModelA ConvertAEntityToModel(IEntityA entityA)
        {
            throw new NotImplementedException();
        }

        public IEntityA ConvertAModelToEntity(ModelA modelA)
        {
            throw new NotImplementedException();
        }

        public ModelB ConvertBEntityToModel(IEntityB entityB)
        {
            throw new NotImplementedException();
        }

        public IEntityB ConvertBModelToEntity(ModelB modelB)
        {
            throw new NotImplementedException();
        }
    }

    public class RepositoryAMock : ABaseRepositoryMock, IRepositoryA
    {
        public Guid CreateEntity(ModelA modelA)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEntity(ModelA modelA)
        {
            throw new NotImplementedException();
        }

        public ModelA ReadEntityById(Guid id)
        {
            EntityAMock entityA = new EntityAMock
            {
                Id = Guid.NewGuid(),
                Name = "Pluto",
                Surname = "Paperino",
            };

            return ConvertAEntityToModel(entityA);
        }

        public ModelA ReadEntityByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ModelA> ReadEntities()
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntity(ModelA modelA)
        {
            throw new NotImplementedException();
        }
    }

    public class EntityAMock : IEntityA
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
