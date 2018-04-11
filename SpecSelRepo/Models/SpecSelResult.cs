using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpecSelRepo.Models
{
    public class SpecSelResult
    {
        public int ID { get; set; }

        [Display(Name = "Data Set")]
        public string DataSet { get; set; }

        [Display(Name = "No. Species")]
        public int NumSpecies { get; set; }

        [Display(Name = "No. Resources")]
        public int NumResources { get; set; }
        public string Option { get; set; }

        [Display(Name = "M")]
        public int SpeciesThresholdM { get; set; }

        [Display(Name = "X")]
        public decimal SdThresholdX { get; set; }

        [Display(Name = "Y")]
        public decimal AreaPrecisionThresholdY { get; set; }
        public string Output { get; set; }
    }



}
