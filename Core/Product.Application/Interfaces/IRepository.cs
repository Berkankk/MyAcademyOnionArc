using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Application.Interfaces
{
    public interface IRepository<T> where T : class //T nin bir sınıf olduğunu belirttik
    {
        //metotlar asenkron yazılmalı  Crud işlemleri

        Task<List<T>> GetListAsync(); //Geriye liste türünde dönüyor ve asenkron
        Task<T> GetByIdAsync(int id); // id ye göre getirme
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity); 
        Task DeleteAsync(int id); // id ye göre silme
    }
}
