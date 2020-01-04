using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangTinhCac.Models;

namespace TangTinhCac.Services.DBFactory
{
    public interface IDBFactory
    {
        ApplicationDbContext Init();
    }
}
