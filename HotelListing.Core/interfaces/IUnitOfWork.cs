using HotelListing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListing.Core.interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Country> CountrieRepository {  get; }
        IGenericRepository<Hotel> HotelRepository {  get; }

        Task Save();
    }
}
