using ProductApp.Domain.Common;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Interfaces.Repository
{
    public interface IGenericRepositoryAsync<T> where T : BaseEntity //Base entity türünden türemiş bir class istiyoruz
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetById(Guid Id);
        Task<T> AddAsync(T entity);
    }
}
