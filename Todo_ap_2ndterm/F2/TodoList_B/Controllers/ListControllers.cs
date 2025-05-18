using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TodoList_B.Data;
using TodoList_B.Model;
using TodoList_B.Model.Dto;

namespace TodoList_B.Controllers
{
  

    [Route("api/List")]
    [ApiController]
    public class ListControllers
 : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public ListControllers(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetListDto>>> getList()
        {

            var List = await _db.List.ToListAsync();
            return Ok(_mapper.Map<List<GetListDto>>(List));
        }
        [HttpGet("filterlistid")]
        public async Task<ActionResult<IEnumerable<GetListDto>>> FilterListBYListId([FromQuery] int? listid)
        {
            var Lists = await _db.List.Where(b => b.Id == listid).ToListAsync();
            return Ok(_mapper.Map<List<GetListDto>>(Lists));

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<TodoList>> getOnList(int id)
        {

            TodoList TodoList = await _db.List.FirstOrDefaultAsync(b => b.Id == id);
            return Ok(_mapper.Map<GetListDto>(TodoList));
        }

        [HttpPost]
        public async Task<ActionResult<CreatListDto>> CreateList([FromBody] CreatListDto ListDto)
        {


            var TodoList = _mapper.Map<TodoList>(ListDto);
            await _db.List.AddAsync(TodoList);
            await _db.SaveChangesAsync();
            return Ok(TodoList);
        }



        [HttpPut("{id:int}")]
        public async Task<ActionResult<TodoList>> UpdateTask([FromBody] UpdateTaskDto TodoDto, int id)
        {

            var TodoList = await _db.List.FirstOrDefaultAsync(b => b.Id == id);
            var updated_Task = _mapper.Map(TodoDto, TodoList);
            _db.List.Update(updated_Task);
            await _db.SaveChangesAsync();
            return Ok(TodoList);

        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<TodoList>> DeleteList(int id)
        {
            var TodoList = await _db.List.FirstOrDefaultAsync(b => b.Id == id);
            _db.List.Remove(TodoList);
            _db.SaveChanges();
            return Ok(TodoList);
        }

    }


}
