using AutoMapper;
using Nordfin_AssignmentShared.Models;
using Nordfin_AssignmentShared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordfin_AssignmentServices
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Product, ProductResponse>();
        }
    }
}
