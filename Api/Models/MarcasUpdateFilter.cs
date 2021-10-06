using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.DtoModels.AssetFilters
{
    public class MarcasUpdateFilter
    {
        public MarcasUpdateFilter()
        {
            AssetIds = new List<int>();
        }

        public string CodMarca { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string AssetType { get; set; }
        public bool IsIncrementalLoad { get; set; }
        public List<int> AssetIds { get; set; }
        [JsonIgnore]
        public int PerimeterId { get; set; }
        public DateTime EndDate { get; set; }
    }
}
