using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesApp.ViewModels
{
    public class EditPhotoViewModel
    {
        public class EditAlbumViewModel
        {
   
            public string PhotoInfo { get; set; }

            [Display(Name = "Описание места")]
            [StringLength(40)]
            public string NewPhotoInfo { get; set; }
        }
    }
}
