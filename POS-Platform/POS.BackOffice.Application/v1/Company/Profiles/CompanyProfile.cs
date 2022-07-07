using AutoMapper;
using POS.BackOffice.Application.v1.Company.ViewModels;
using POS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BackOffice.Application.v1.Company.Profiles
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            // Model => View Model
            // ----------------------------------------------------

            // View Model => Model
            CreateMap<VMPARAM_CREATE_ORG_COMPANY, ORG_COMPANY>();

        }
    }
}
