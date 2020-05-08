using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infestation.Models.Repositories
{
    public class SqlHumanRepository : IHumanRepository
    {
        private InfestationDbContext _dbContext { get; set; }

        public SqlHumanRepository(InfestationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateHumans(IEnumerable<Human> humans)
        {
            throw new NotImplementedException();
        }

        public Human GetHuman(int id)
        {
            return _dbContext.Humans.Find(id);
        }

        public IEnumerable<Human> GetAllHumans()
        {
            return _dbContext.Humans;
        }

        public void KillHumans(IEnumerable<Human> humans)
        {
            throw new NotImplementedException();
        }
    }
}
