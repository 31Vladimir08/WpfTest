
using AutoMapper;

using ServiceReference;

using WpfApp.Models;
using WpfApp.Models.Dto;

namespace WpfApp.AutoMapperProfile
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateProfile();
        }

        private void CreateProfile()
        {
            CreateMap<СontractUi, СontractDto>();
            CreateMap<СontractDto, СontractUi>().ForMember(x => x.IsActual, y => y.Ignore());

            CreateMap<СontractDto, СontractEntity>();
            CreateMap<СontractEntity, СontractDto>();
        }
    }
}
