using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPokedex.Models
{
    public class PaginationMetaData
    {
        public int CurrentPage { get; set; }//pagina que el usuario esta viendo
        public int TotalPages { get; set; }//cuantas paginas hay
        public int TotalCount { get; set; }//cuantos registros totales hay
        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;
    }
}
