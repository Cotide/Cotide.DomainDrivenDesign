﻿ 
using System;
using System.ComponentModel.Composition;
using System.Linq;
using Cotide.Domain.Contracts.Repositories;
using Cotide.Domain.Entity;
using Cotide.Infrastructure.Repositories.Base; 


namespace Cotide.Infrastructure.Repositories
{
	/// <summary>
    ///   仓储操作层实现——User
    /// </summary> 
    public partial class UserRepository : EFRepositoryBase<User, Guid>, IUserRepository
    { 
	}
}
