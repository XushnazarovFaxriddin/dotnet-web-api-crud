using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Talabalar.Models;

namespace Talabalar.Data
{
    public interface ITalabaRepository
    {
        Task<IEnumerable<Talaba>> GetAllTalabalar();

        Task<Talaba> GetTalabaById(int id);

        Task CreateTalaba(Talaba talaba);

        Task UpdataTalaba(Talaba talaba);

        void DeleteTalaba(Talaba talaba);

        Task<bool> SaveChanges();
    }
}
