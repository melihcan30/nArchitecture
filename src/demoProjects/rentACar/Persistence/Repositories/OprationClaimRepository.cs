using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class OprationClaimRepository : EfRepositoryBase<OperationClaim, BaseDbContext>, IOperationClaimRepository
    {
        public OprationClaimRepository(BaseDbContext context) : base(context)
        {

        }

        public class RefreshTokenRepository : EfRepositoryBase<RefreshToken, BaseDbContext>, IRefreshTokenRepository
        {
            public RefreshTokenRepository(BaseDbContext context) : base(context)
            {

            }
        }
    }
}
