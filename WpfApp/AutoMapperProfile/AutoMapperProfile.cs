
using AutoMapper;

using WpfApp.Models;
using WpfApp.Services.Model;

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
        }
    }
}
