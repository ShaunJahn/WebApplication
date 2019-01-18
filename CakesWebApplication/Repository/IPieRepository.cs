using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakesWebApplication.Models
{
    public interface  IPieRepository
    {
        IEnumerable<PieDto> Pies { get; }
        IEnumerable<PieDto> PiesOfTheWeek { get; }
        IEnumerable<PieDto> PiesWithCategory(string category);

        PieDto PieById(int Id);
    }
}
