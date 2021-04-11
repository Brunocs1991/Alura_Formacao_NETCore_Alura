using Microsoft.EntityFrameworkCore;
using ProjetoMVCECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVCECommerce.Repositories
{
    public class BaseRepository<T> where T: BaseModel
    {
        protected readonly ApplicationContex contexto;
        protected readonly DbSet<T> dbSet;
        public BaseRepository(ApplicationContex contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<T>();
        }
    }
}
