using AutoMapper;
using TodoList_B.Model.Dto;
using TodoList_B.Model;
namespace TodoList_B
{
    public class Mappingconfig : Profile
    {
        public Mappingconfig()
        {
            CreateMap<Todo, GetTaskDto>().ReverseMap();
            CreateMap<Todo, CreatTaskDto>().ReverseMap();
            CreateMap<Todo, UpdateTaskDto>().ReverseMap();
            CreateMap<TodoList, GetListDto>().ReverseMap();
            CreateMap<TodoList, CreatListDto>().ReverseMap();
            CreateMap<TodoList, UpdateListDto>().ReverseMap();
          
        }
    }
}
