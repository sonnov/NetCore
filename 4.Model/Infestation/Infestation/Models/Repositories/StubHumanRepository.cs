using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infestation.Models.Repositories
{
    public class StubHumanRepository : IHumanRepository
    {
        private List<Human> Humans { get; set; }

        public void CreateHumans(IEnumerable<Human> humans)
        {
            Humans.AddRange(humans);
        }

        public IEnumerable<Human> GetAllHumans()
        {
            return Humans;
        }

        public Human GetHuman(int id)
        {
            return Humans.FirstOrDefault(x => x.Id == id);
        }

        public void KillHumans(IEnumerable<Human> humans)
        {
            foreach (var human in humans)
                Humans.Remove(human);
        }
    }
}
