using AutoMapper;
using MediatR;
using POS.Common;
using POS.Domain;
using POS.Domain.Models;
using POS.ViewModels;
using POS.ViewModels.v1;
using System.Reflection;

namespace POS.Application.v1
{
    public class PositionProfile : Profile
    {
        public PositionProfile()
        {
            // Model => View Model
            // ----------------------------------------------------

            // View Model => Model
            CreateMap<VMPARAM_CREATE_ORG_POSITION, ORG_POSITION>();
        }
    }
}
