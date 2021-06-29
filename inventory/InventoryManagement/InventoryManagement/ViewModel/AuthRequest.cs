using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.ViewModel
{
    public class AuthRequest
    {
        [Required(ErrorMessage = "Please enter name"), MaxLength(30), MinLength(8)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
