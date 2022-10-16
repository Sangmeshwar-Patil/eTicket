using eTicket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Data.Services
{
   public interface IActorService
    {
        IEnumerable<Actor> GetAll();
        Actor GetById(int id);
        void Add(Actor newActor);
        Actor Update(int id, Actor updateActor);
        void Delete(int id);
    }
}
