﻿using magicVilla_VillaAPI.Models.Dto;

namespace magicVilla_VillaAPI.Data
{
    public static class VillaStore
    {

        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO {Id=1,Name="Pool View", sqft = 100, Occupancy= 4 },
                new VillaDTO {Id=2,Name="Beach View",  sqft = 200, Occupancy= 8 }
            };
    }
}
