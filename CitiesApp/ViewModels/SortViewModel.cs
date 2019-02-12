using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesApp.ViewModels
{
    public class SortViewModel
    {
        public SortState NameSort { get; private set; }
        public SortState RatingSort { get; private set; }
        public SortState Current { get; private set; }

        public SortViewModel(SortState sortOrder)
        {
            NameSort = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;
            RatingSort = sortOrder == SortState.RatingAsc ? SortState.RatingDesc : SortState.RatingAsc;
            Current = sortOrder;
        }

    }
    public enum SortState
    {
        NameAsc, 
        NameDesc,   
        RatingAsc, 
        RatingDesc,   
    }
}
