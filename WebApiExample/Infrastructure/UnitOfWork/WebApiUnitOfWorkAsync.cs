using BackEndInfrastructure.Infrastructure.UnitOfWork;
using IDGFAuth.Data;

namespace IDGFAuth.Infrastructure.UnitOfWork
{
    public class WebApiUnitOfWorkAsync : UnitOfWorkAsync<IDGFAuthDbContextSQL>, IWebApiUnitOfWorkAsync
    {
        public WebApiUnitOfWorkAsync(IServiceProvider serviceProvider) : base(new IDGFAuthDbContextSQL(serviceProvider))
        {
            //WebServerUser = new WebServiceUserRepository(base._dbContext);
        }

    }
}
