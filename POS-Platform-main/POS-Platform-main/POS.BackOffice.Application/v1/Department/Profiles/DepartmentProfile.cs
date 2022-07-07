using AutoMapper;
using POS.BackOffice.Application.v1.Department.ViewModels;
using POS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BackOffice.Application.v1.Department.Profiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            // Model => View Model
            // ----------------------------------------------------

            // View Model => Model
            CreateMap<VMPARAM_CREATE_ORG_DEPARTMENT, ORG_DEPARTMENT>();

        }
    }
}
