using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TangTinhCac.Models;

namespace TangTinhCac.Services.DBFactory
{
    public class DBFactory : IDBFactory
    {
        private ApplicationDbContext dbContext;

        public ApplicationDbContext Init()
        {
            return dbContext ?? (dbContext = new ApplicationDbContext());
        }
    }
}