using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace KLWalks.API.Profiles
{
    public class RegionsProfile:Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>()
                .ReverseMap();
        }
    }
}
