using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Talabalar.Models;

namespace Talabalar.Data
{
    public class SQLTalabaAPIRepository : ITalabaRepository
    {
        private readonly TalabaContext _context;
        public SQLTalabaAPIRepository(TalabaContext context)
        {
            _context = context;
        }
        public async Task CreateTalaba(Talaba talaba)
        {
            if (talaba is null)
            {
                throw new ArgumentNullException(nameof(talaba));
            }

            await _context.Talabalar.AddAsync(talaba);
        }

        public async void DeleteTalaba(Talaba talaba)
        {
            if (talaba is null)
            {
                throw new Exception("There is no talaba with such an id!");
            }
            _context.Talabalar.Remove(talaba);
        }

        public async Task<IEnumerable<Talaba>> GetAllTalabalar()
        {
            return await _context.Talabalar.ToListAsync();
        }

        public async Task<Talaba> GetTalabaById(int id)
        {
            return await _context.Talabalar.FirstOrDefaultAsync(t => t.Id == id);
        }


        public async Task UpdataTalaba(Talaba talaba)
        {
            _context.Entry(await _context.Talabalar.FirstOrDefaultAsync(t => t.Id == talaba.Id)).CurrentValues.SetValues(talaba);
        }
        public async Task<bool> SaveChanges()
        {
            return (await _context.SaveChangesAsync()) >= 0;
        }
    }
}
