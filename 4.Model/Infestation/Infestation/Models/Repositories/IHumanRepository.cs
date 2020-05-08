using System.Collections.Generic;

namespace Infestation.Models.Repositories
{
    public interface IHumanRepository
    {
        IEnumerable<Human> GetAllHumans();

        Human GetHuman(int id);

        void CreateHumans(IEnumerable<Human> humans);

        void KillHumans(IEnumerable<Human> humans);
    }
}
