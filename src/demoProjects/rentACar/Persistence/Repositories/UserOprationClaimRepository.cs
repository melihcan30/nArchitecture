using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class UserOprationClaimRepository : EfRepositoryBase<UserOperationClaim, BaseDbContext>, IUserOperationClaimRepository
    {
        public UserOprationClaimRepository(BaseDbContext context) : base(context)
        {

        }
    }
}
