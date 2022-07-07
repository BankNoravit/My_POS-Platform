using AutoMapper;
using POS.BackOffice.Application.v1.PositionLevel.ViewModels;
using POS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BackOffice.Application.v1.PositionLevel.Profiles
{
    public class PositionLevelProfile : Profile
    {
        public PositionLevelProfile()
        {
            // Model => View Model
            // ----------------------------------------------------

            // View Model => Model
            CreateMap<VMPARAM_CREATE_ORG_POSITION_LEVEL, ORG_POSITION_LEVEL>();
        }
    }
}
