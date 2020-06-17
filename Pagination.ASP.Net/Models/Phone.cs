using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pagination.ASP.Net.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Producer { get; set; }
    }

    public class PageInfo
    {
        public int PageNumber { get; set; } //номер текущей страницы
        public int PageSize { get; set; } //количество выводимых объектов на странице
        public int TotalItems { get; set; } //всего объектов
        //всего страниц
        public int TotalPages { get { return (int)Math.Ceiling((decimal)TotalItems / PageSize); }  }
    }

    public class IndexViewModel 
    {
        public IEnumerable<Phone> Phones { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}   