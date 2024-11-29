using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament.Core.Entities;
using Tournament.Core.Dto;

namespace Tournament.Data.Data
{
    public class TournamentMappings: Profile
    {
        public TournamentMappings()
        {
            CreateMap<TournamentDetails, TournamentDto>()
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.StartDate.AddMonths(3)));
            CreateMap<TournamentDto, TournamentDetails>();

            CreateMap<Game, GameDto>();
            CreateMap<GameDto, Game>();
        }
    }
}
