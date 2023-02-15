using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace auto_mapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMapper _mapper;

        public StudentController(IMapper mapper)
        {
            _mapper = mapper;
        }

        // GET: api/<controller>
        [HttpGet]
        public Student Get()
        {
            StudentDTO studentDTO = new StudentDTO()
            {
                Name = "Student 1",
                Age = 25,
                CurrentCity = "New York"
                ,
              Region=8
            };

            return _mapper.Map<Student>(studentDTO);
        }
    }
}

