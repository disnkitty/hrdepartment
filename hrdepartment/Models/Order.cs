using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace hrdepartment.Models
{
    internal class Order
    {
        public string Id { get; set; }  //айді приказа
        public DateTime Date { get; set; }
        public string OrderType { get; set; } 
        public Employee Employee { get; set; }  
        public string Description { get; set; }  

        public void GenerateOrderTextFile(string path)
        {
            var lines = new List<string>
            {
                $"Наказ №{Id}",
                $"Дата: {Date.ToShortDateString()}",
                $"Тип: {OrderType}",
                $"Співробітник: {Employee.LastName} {Employee.FirstName} {Employee.MiddleName}",
                $"Опис: {Description}"
            };
            File.WriteAllLines(path, lines);
        }


    }
}
