using AutoMapper;
using Examination_System.DTOs.Instructor;
using Examination_System.Models;
using Examination_System.ViewModels.Course;
using Examination_System.ViewModels.Instructor;


namespace Examination_System.DTOs.Course
{
  

    public class CourseProfile:Profile
    {
        public CourseProfile()
        {
            CreateMap<Examination_System.Models.Course, GetAllCoursesDTO>().ReverseMap();
            CreateMap<GetAllCoursesViewModel, GetAllCoursesDTO>().ReverseMap();
            CreateMap<GetInstructorInfoViewModel, GetInstructorInfoDTO>().ReverseMap();
            CreateMap<Examination_System.Models.Instructor, GetInstructorInfoDTO>()
                .ForMember(des=>des.Name,opt=>opt.MapFrom(src => src.FullName))
                .ReverseMap();
        }
          
    }
}
