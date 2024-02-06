using nms_backend_api.Entity;

namespace nms_backend_api.Logics.Contract
{
    public interface IScheduleClass
    {
        void Create(ScheduleClass clas);
        void Update(ScheduleClass clas);
        void Delete(int id);
        List< ScheduleClass> GetClassByTeacherID(int teacherId);
        List<ScheduleClass> GetClassByClassID(int classId);
        List<ScheduleClass> GetAll();


    }
}