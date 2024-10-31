using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task Commit();
        void Rollback();

        TRepository SetRepository<TRepository>();
        TRepository GetRepository<TRepository>() where TRepository : class;

        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IAddressRepository AddressRepository { get; }
        ICardItemsRepository CardItemsRepository { get; }
        ICountryRepository CountryRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        IImageRepository ImageRepository { get; }
        IOrderRepository OrderRepository { get; }
        IReviewRepository ReviewRepository { get; }
        ISubCategoryRepository SubCategoryRepository { get; }
        ITypesRepository TypeRepository { get; }
        IVendorRepository VendorRepository { get; }


    }
}
