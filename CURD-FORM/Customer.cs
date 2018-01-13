using System.ComponentModel.DataAnnotations;

namespace CURD_FORM
{
    public class Customer
    {
        public int Id { get; set; }
        [Required, StringLength (10)]
        public string Name { get; set; }
        



    }
}