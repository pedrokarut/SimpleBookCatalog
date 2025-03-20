using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleBookCatalog.Entities;

namespace SimpleBookCatalog.Application.Interfaces
{
    public interface IBookRepository
    {
        Task AddASync(Book book);

        Task<List<Book>> GetAllAsync();

        Task<Book> GetByIdAsync(int id);

        Task UpdateAsync(Book book);

        Task DeleteByIdAsync(int id);

    }
}
