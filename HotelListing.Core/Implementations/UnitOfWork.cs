using HotelListing.Core.interfaces;
using HotelListing.Data;
using HotelListing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListing.Core.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private IGenericRepository<Country> _countries;
        private IGenericRepository<Hotel> _hotels;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Returns a new instance of GenericRepositoy<Country> if _countries null
        /// </summary>
        public IGenericRepository<Country> CountrieRepository => _countries ??= new GenericRepository<Country>(_context);

        /// <summary>
        /// Returns a new instance of GenericRepositoy<Hotels> if _hotels null
        /// </summary>
        public IGenericRepository<Hotel> HotelRepository => _hotels ??= new GenericRepository<Hotel>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
