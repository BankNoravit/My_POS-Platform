using AutoMapper;
using POS.BackOffice.Application.v1.Branch.ViewModels;
using POS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BackOffice.Application.v1.Branch.Commands
{
    public class BranchProfile : Profile
    {
        public BranchProfile()
        {
            // Model => View Model
            // ----------------------------------------------------

            // View Model => Model
            CreateMap<VMPARAM_CREATE_ORG_BRANCH, ORG_BRANCH>();
        }
    }
}
