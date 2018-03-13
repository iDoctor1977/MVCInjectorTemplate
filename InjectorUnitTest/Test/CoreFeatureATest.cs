using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Injector.Common.DTOEntity;
using Injector.Common.IABase;
using Injector.Common.IBind;
using Injector.Common.IEntity;
using Injector.Common.IFeature;
using Injector.Common.ILogic;
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
    public class CoreFeatureATest
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

            EntityA modelA = new EntityA
            {
                Id = Guid.NewGuid(),
                Name = "Pippo",
                Surname = "Poppi"
            };

            IRepositoryA repositoryASubstitute = Substitute.For<RepositoryAMock>();
            repositoryASubstitute.CreateEntity(modelA);
            repositoryASubstitute.ReadEntityById(Arg.Any<Guid>()).Returns(entityA);

            IDataSupplier dataSupplierSubstitute = Substitute.For<DataSupplierMock>();
            dataSupplierSubstitute.GetRepositoryA.Returns(repositoryASubstitute);

            ICoreBind coreBondSubstitute = Substitute.For<CoreBindMock>();
            coreBondSubstitute.BindDataSupplier.Returns(dataSupplierSubstitute);
            coreBondSubstitute.BindSharingSupplier.GetModelA().Returns(new EntityA());

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
                DTOModelA = new EntityA
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
            Assert.IsInstanceOf<IEntityA>((result as ViewResult).Model);
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

    public class CoreBindMock : ICoreBind
    {
        public IDataSupplier BindDataSupplier
        {
            get { return new DataSupplierMock(); }
            set { throw new NotImplementedException(); }
        }

        public ISharingSupplier BindSharingSupplier { get; set; }
    }

    public class VMDetailsAMock : IVMDetailsA
    {
        public EntityA DTOModelA { get; set; }
    }

    public class VMCreateAMock : IVMCreateA
    {
        public EntityA DTOModelA { get; set; }
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
        public ILogicA GetLogicA { get; }
    }

    public class ABaseDataSupplierMock : IABaseDataSupplier
    {
        public IDataBind ABaseBind { get; set; }
        public IDataStore ABaseStore { get; set; }
    }

    public class DataSupplierMock : IDataSupplier
    {
        public IRepositoryA GetRepositoryA => new RepositoryAMock();

        public IRepositoryB GetRepositoryB { get; }
        public void Commit()
        {
            throw new NotImplementedException();
        }
    }

    public class ABaseRepositoryMock : IABaseRepository
    {
        public IDataStore ABaseStore { get; set; }

        public EntityA ConvertAEntityToModel(IEntityA entityA)
        {
            throw new NotImplementedException();
        }

        public IEntityA ConvertAModelToEntity(EntityA modelA)
        {
            throw new NotImplementedException();
        }

        public EntityB ConvertBEntityToModel(IEntityB entityB)
        {
            throw new NotImplementedException();
        }

        public IEntityB ConvertBModelToEntity(EntityB modelB)
        {
            throw new NotImplementedException();
        }
    }

    public class RepositoryAMock : ABaseRepositoryMock, IRepositoryA
    {
        public Guid CreateEntity(EntityA modelA)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEntity(EntityA modelA)
        {
            throw new NotImplementedException();
        }

        public EntityA ReadEntityById(Guid id)
        {
            EntityAMock entityA = new EntityAMock
            {
                Id = Guid.NewGuid(),
                Name = "Pluto",
                Surname = "Paperino",
            };

            return ConvertAEntityToModel(entityA);
        }

        public EntityA ReadEntityByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EntityA> ReadEntities()
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntity(EntityA modelA)
        {
            throw new NotImplementedException();
        }
    }

    public class EntityAMock : IEntityA
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsDeleted { get; set; }
        public string DeleteBy { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
