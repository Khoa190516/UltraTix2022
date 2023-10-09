﻿using UltraTix2022.API.UltraTix2022.Data.Models.Entities;
using UltraTix2022.Data.Repositories.GenericRepository;

namespace UltraTix2022.API.UltraTix2022.Data.Repositories.ImplementedRepositories.AppTransactionRepo
{
    public class AppTransactionRepo : Repository<AppTransaction>, IAppTransactionRepo
    {
        public AppTransactionRepo(UltraTixDBContext context) : base(context)
        {
        }
    }
}
