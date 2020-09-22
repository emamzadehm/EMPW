using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Emamzadeh.Models
{
    public class Message
    {
        public int Id { get; set; }
        [DisplayName("نام و نام خانوادگی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفاً {0} خود را وارد نمائید.")]
        [StringLength(100, ErrorMessage = "حداکثر طول {0} تعداد {1} کاراکتر می باشد.")]
        public string Name { get; set; }
        [DisplayName("ایمیل")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفاً {0} خود را وارد نمائید.")]
        [EmailAddress(ErrorMessage = "لطفا {0} خود را بصورت صحیح وارد نمائید.")]
        public string Email { get; set; }
        [DisplayName("عنوان پیام")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفاً {0} خود را وارد نمائید.")]
        [StringLength(250, ErrorMessage = "حداکثر طول {0} تعداد {1} کاراکتر می باشد.")]
        public string Title { get; set; }
        [DisplayName("متن پیام")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "لطفاً {0} خود را وارد نمائید.")]
        [StringLength(1000, ErrorMessage = "حداکثر طول {0} تعداد {1} کاراکتر می باشد.")]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public Message()
        {

        }
        public Message(string name, string email, string title, string description)
        {
            Name = name;
            Email = email;
            Title = title;
            Description = description;
            CreatedDate = DateTime.Now;
        }
    }
}
