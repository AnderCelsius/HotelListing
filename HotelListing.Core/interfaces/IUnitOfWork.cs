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
        IGenericRepository<Country> Countries {  get; }
        IGenericRepository<Hotel> Hotels {  get; }

        Task Save();
    }
}
