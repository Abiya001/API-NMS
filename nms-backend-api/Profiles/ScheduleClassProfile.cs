using AutoMapper;
using nms_backend_api.DTO;
using nms_backend_api.Entity;

namespace nms_backend_api.Profiles
{
    public class ScheduleClassProfile:Profile
    {
        public ScheduleClassProfile() {
            CreateMap<ScheduleClassDTO, ScheduleClass>();
            CreateMap<ScheduleClass, ScheduleClassDTO>();

        }


    }
}
