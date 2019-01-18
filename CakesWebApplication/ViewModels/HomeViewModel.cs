using System.Collections.Generic;
using CakesWebApplication.Models;

namespace CakesWebApplication.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<PieDto> PiesOfTheWeek { get; set; }
    }
}
