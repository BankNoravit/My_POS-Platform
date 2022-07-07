using AutoMapper;
using POS.BackOffice.Application.v1.Zone.ViewModels;
using POS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BackOffice.Application.v1.Zone.Profiles
{
    public class ZoneProfile : Profile
    {
        public ZoneProfile()
        {
            // Model => View Model
            // ----------------------------------------------------

            // View Model => Model
            CreateMap<VMPARAM_CREATE_ORG_ZONE, ORG_ZONE>();

        }
    }
}
