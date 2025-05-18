using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TodoList_B.Data;
using TodoList_B.Model;
using TodoList_B.Model.Dto;

namespace TodoList_B.Controllers
{
  

    
    [Route("api/Task")]
    [ApiController]
    public class TaskControllers
 : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public TaskControllers(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }


        [HttpGet("filternotchecked")]
        public async Task<ActionResult<IEnumerable<GetTaskDto>>> FilterTaskNotChecked()
        {
           var Tasks=await _db.Tasks.Where(b=>b.Checked==false).ToListAsync();
            return Ok(_mapper.Map<List<GetTaskDto>>(Tasks));

        }
        [HttpGet("filterisstareed")]
        public async Task<ActionResult<IEnumerable<GetTaskDto>>> FilterTaskIsStarred()
        {
            var Tasks = await _db.Tasks.Where(b => b.Starred == true).ToListAsync();
            return Ok(_mapper.Map<List<GetTaskDto>>(Tasks));

        }












        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetTaskDto>>> getTask()
        {

            var Tasks = await _db.Tasks.ToListAsync();
            return Ok(_mapper.Map<List<GetTaskDto>>(Tasks));
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Todo>> getOnTask(int id)
        {

           Todo Todo = await _db.Tasks.FirstOrDefaultAsync(b => b.Id == id);
            return Ok(_mapper.Map<GetTaskDto>(Todo));
        }

        [HttpPost]
        public async Task<ActionResult<CreatTaskDto>> CreateTask([FromBody] CreatTaskDto TaskDto)
        {


            var Todo = _mapper.Map<Todo>(TaskDto);
            await _db.Tasks.AddAsync(Todo);
            await _db.SaveChangesAsync();
            return Ok(Todo);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Todo>> UpdateTask([FromBody] UpdateTaskDto TodoDto, int id)
        {

            var Todo = await _db.Tasks.FirstOrDefaultAsync(b => b.Id == id);
            var updated_Task = _mapper.Map(TodoDto, Todo);
            _db.Tasks.Update(updated_Task);
            await _db.SaveChangesAsync();
            return Ok(Todo);

        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Todo>> DeleteTask(int id)
        {
            var Todo = await _db.Tasks.FirstOrDefaultAsync(b => b.Id == id);
            _db.Tasks.Remove(Todo);
            _db.SaveChanges();
            return Ok(Todo);
        }

    }


}
