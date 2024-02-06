using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using nms_backend_api.DTO;
using nms_backend_api.Entity;
using nms_backend_api.Logics.Concrete;
using nms_backend_api.Logics.Contract;

namespace nms_backend_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleClassController : ControllerBase
    {
        private readonly IMapper _mapper;
        public List<ScheduleClass> classs = new List<ScheduleClass>();


        public ScheduleClassRepository scheduleClassRepository;
        public ScheduleClassController(ScheduleClassRepository scheduleClassRepository, IMapper mapper)
        {
            this._mapper = mapper;
            this.scheduleClassRepository = scheduleClassRepository;
        }

        public IActionResult getAll()
        {
            try
            {
                List<ScheduleClass> class1 = scheduleClassRepository.GetAll();
                List<ScheduleClassDTO> classDTOs = _mapper.Map<List<ScheduleClassDTO>>(class1);
                return Ok(classDTOs);
            }
            catch (Exception ex)
            {
                return StatusCode(404, ex.Message);
            }
        }
        [HttpGet, Route("GetClassByClassId/{id}")]
        public IActionResult getClassByClassId(int id)
        {
            try
            {

                var item = classs.FirstOrDefault(x => x.ClassId == id);


                ScheduleClassDTO classDTOs = _mapper.Map<ScheduleClassDTO>(item);
                return Ok(classDTOs);
            }
            catch (Exception ex)
            {
                return StatusCode(404, ex.Message);

            }
        }
        [HttpGet, Route("GetClassBytrId/{id}")]
        public IActionResult getClassByTrId(int id)
        {
            try
            {

                var item = classs.FirstOrDefault(x => x.Teacher.TeacherId == id);


                ScheduleClassDTO classDTOs = _mapper.Map<ScheduleClassDTO>(item);
                return Ok(classDTOs);
            }
            catch (Exception ex)
            {
                return StatusCode(404, ex.Message);

            }
        }
            [HttpPost, Route("AddClass")]
            public IActionResult Add(ScheduleClassDTO data)
            {
                try
                {
                    //  classRepository.Create(classes);
                    //  return Ok(classes);
                    var _class = _mapper.Map<ScheduleClass>(data); //convert dto to entity


                    if (ModelState.IsValid)
                    {
                        scheduleClassRepository.Create(_class);

                        return Ok(_class);
                    }

                    return new JsonResult("Something went wrong") { StatusCode = 500 };
                }
                catch (Exception ex)
                {

                    return StatusCode(404, ex.Message);

                }
            }
        [HttpPut, Route("UpdateClass")]
        public IActionResult Edit(ScheduleClassDTO data)
        {
            try
            {

                //classRepository.Update(class1);
                //return Ok(class1);
                var _class = _mapper.Map<ScheduleClass>(data); //convert dto to entity


                if (ModelState.IsValid)
                {
                    scheduleClassRepository.Update(_class);

                    return Ok(_class);
                }

                return new JsonResult("Something went wrong") { StatusCode = 500 };
            }
            catch (Exception ex)
            {

                return StatusCode(404, ex.Message);

            }
        }

            [HttpDelete, Route("deleteClassSchedule/{id}")]
            public IActionResult Delete(int id)
            {
                try
                {
                    scheduleClassRepository.Delete(id);
                    return Ok("class deleted");

                }
                catch (Exception ex)
                {

                    return StatusCode(404, ex.Message);

                }

            }
        }
    }
    

