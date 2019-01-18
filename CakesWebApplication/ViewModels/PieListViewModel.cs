using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakesWebApplication.Models;

namespace CakesWebApplication.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<PieDto> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
