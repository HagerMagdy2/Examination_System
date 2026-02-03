namespace Examination_System.Models
{
    public class BaseModel
    {
        public int ID { get; set; }
        public int IsDelected { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
    }
}
