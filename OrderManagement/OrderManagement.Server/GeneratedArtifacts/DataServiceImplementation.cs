﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using global::System.Linq;

namespace LightSwitchApplication.Implementation
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataDataService
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataService<global::LightSwitchApplication.Implementation.ApplicationData>
    {
    
        public ApplicationDataDataService() : base()
        {
        }
    
        protected override global::Microsoft.LightSwitch.IDataService GetDataService(global::Microsoft.LightSwitch.IDataWorkspace dataWorkspace)
        {
            return ((global::LightSwitchApplication.DataWorkspace)dataWorkspace).ApplicationData;
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class ApplicationDataServiceImplementation
        : global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation<global::LightSwitchApplication.Implementation.ApplicationData>
    {
        public ApplicationDataServiceImplementation(global::Microsoft.LightSwitch.IDataService dataService) : base(dataService)
        {
        }
    
    #region Queries
        public global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.OrderHeader> OpenOrders()
        {
            global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.OrderHeader> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::LightSwitchApplication.Implementation.OrderHeader>("OrderHeaders"),
                (o) => (o.ShipDate.HasValue == false));
            return query;
        }
    
        public global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Product> CurrentProducts()
        {
            global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Product> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::LightSwitchApplication.Implementation.Product>("SortedProducts"),
                (p) => (p.IsDiscontinued == false));
            return query;
        }
    
        public global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Product> ProductsWithoutDesc()
        {
            global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Product> query;
            query = global::System.Linq.Queryable.Where(
                this.GetQuery<global::LightSwitchApplication.Implementation.Product>("SortedProducts"),
                (p) => (p.Description == null));
            return query;
        }
    
        public global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Product> SortedProducts()
        {
            global::System.Linq.IQueryable<global::LightSwitchApplication.Implementation.Product> query;
            query = global::System.Linq.Queryable.OrderBy(
                this.GetQuery<global::LightSwitchApplication.Implementation.Product>("Products"),
                (p) => p.ProductName);
            return query;
        }
    
    #endregion

    #region Protected Methods
        protected override object CreateObject(global::System.Type type)
        {
            if (type == typeof(global::LightSwitchApplication.Implementation.Customer))
            {
                return new global::LightSwitchApplication.Implementation.Customer();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.OrderDetail))
            {
                return new global::LightSwitchApplication.Implementation.OrderDetail();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.OrderHeader))
            {
                return new global::LightSwitchApplication.Implementation.OrderHeader();
            }
            if (type == typeof(global::LightSwitchApplication.Implementation.Product))
            {
                return new global::LightSwitchApplication.Implementation.Product();
            }
    
            return base.CreateObject(type);
        }
    
        protected override global::LightSwitchApplication.Implementation.ApplicationData CreateObjectContext()
        {
            string assemblyName = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            return new global::LightSwitchApplication.Implementation.ApplicationData(this.GetEntityConnectionString(
                "_IntrinsicData",
                "res://" + assemblyName + "/ApplicationData.csdl|res://" + assemblyName + "/ApplicationData.ssdl|res://" + assemblyName + "/ApplicationData.msl",
                "System.Data.SqlClient",
                true));
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Customer))
            {
                return new global::LightSwitchApplication.Implementation.Customer();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.OrderDetail))
            {
                return new global::LightSwitchApplication.Implementation.OrderDetail();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.OrderHeader))
            {
                return new global::LightSwitchApplication.Implementation.OrderHeader();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Product))
            {
                return new global::LightSwitchApplication.Implementation.Product();
            }
            return null;
        }
    
    #endregion
    
    }
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __DataServiceFactory :
        global::Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationDataService))
            {
                return new global::LightSwitchApplication.ApplicationDataService();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationDataService))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationDataServiceImplementation(dataService);
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Customer) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Customer);
            }
            if (typeof(global::LightSwitchApplication.OrderDetail) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.OrderDetail);
            }
            if (typeof(global::LightSwitchApplication.OrderHeader) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.OrderHeader);
            }
            if (typeof(global::LightSwitchApplication.Product) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Product);
            }
            return null;
        }
    }
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Customer :
        global::LightSwitchApplication.Customer.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Customer.DetailsClass.IImplementation.OrderHeaders
        {
            get
            {
                return this.OrderHeaders;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class OrderDetail :
        global::LightSwitchApplication.OrderDetail.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.OrderDetail.DetailsClass.IImplementation.Product
        {
            get
            {
                return this.Product;
            }
            set
            {
                this.Product = (global::LightSwitchApplication.Implementation.Product)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Product");
                }
            }
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.OrderDetail.DetailsClass.IImplementation.OrderHeader
        {
            get
            {
                return this.OrderHeader;
            }
            set
            {
                this.OrderHeader = (global::LightSwitchApplication.Implementation.OrderHeader)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("OrderHeader");
                }
            }
        }
        
        partial void OnOrderDetail_ProductChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Product");
            }
        }
        
        partial void OnOrderDetail_OrderHeaderChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("OrderHeader");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class OrderHeader :
        global::LightSwitchApplication.OrderHeader.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.OrderHeader.DetailsClass.IImplementation.Customer
        {
            get
            {
                return this.Customer;
            }
            set
            {
                this.Customer = (global::LightSwitchApplication.Implementation.Customer)value;
                if (this.__host != null)
                {
                    this.__host.RaisePropertyChanged("Customer");
                }
            }
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.OrderHeader.DetailsClass.IImplementation.OrderDetails
        {
            get
            {
                return this.OrderDetails;
            }
        }
        
        partial void OnOrderHeader_CustomerChanged()
        {
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged("Customer");
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Product :
        global::LightSwitchApplication.Product.DetailsClass.IImplementation,
        global::Microsoft.LightSwitch.Internal.ICreatedModifiedPropertiesImplementation
    
    {
    
        global::System.Collections.IEnumerable global::LightSwitchApplication.Product.DetailsClass.IImplementation.OrderDetails
        {
            get
            {
                return this.OrderDetails;
            }
        }
        
        #region IEntityImplementation Members
        private global::Microsoft.LightSwitch.Internal.IEntityImplementationHost __host;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementationHost global::Microsoft.LightSwitch.Internal.IEntityImplementation.Host
        {
            get
            {
                return this.__host;
            }
        }
        
        void global::Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize(global::Microsoft.LightSwitch.Internal.IEntityImplementationHost host)
        {
            this.__host = host;
        }
        
        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            if (this.__host != null)
            {
                this.__host.RaisePropertyChanged(propertyName);
            }
        }
        #endregion
    }
    
}

