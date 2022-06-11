using eTicketsBooking.Data.Base;
using eTicketsBooking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketsBooking.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {

        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context) : base(context) { }
        
      
     
    }
}
