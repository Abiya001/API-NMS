namespace nms_backend_api.DTO
{
    public class ScheduleClassDTO
    {
        public int ScheduleId { get; set; }
        public int ClassId { get; set; }
        public int TeacherId { get; set; }
        public string Subject { get; set; }
        public string Sessiontime { get; set; }

    }
}
