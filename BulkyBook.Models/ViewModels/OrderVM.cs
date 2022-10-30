using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BulkyBook.Models.ViewModels
{
    public class OrderVM
    {
        public OrderHeader OrderHeader  {get; set;}
 
        public IEnumerable<OrderDetail> OrderDetail {get; set;}
       

    }
}