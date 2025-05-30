using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrdepartment.Models
{
    internal class Order
    {
        public string Id { get; set; }  //айді приказа
        public DateTime Date { get; set; }  
        public string OrderType { get; set; }  // наприклад звільнення або перевод і тд 
        public Employee Employee { get; set; }  //сотрудник до якого відноситься приказ
        public string Description { get; set; }  //описание приказа (например, детали или причины)


    }
}
