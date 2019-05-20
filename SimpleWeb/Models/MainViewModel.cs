using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;

using SimpleWeb.Entities;

namespace SimpleWeb.Models
{
    public class MainViewModel
    {
        public Race Race { get; set; }

        public IEnumerable<SelectListItem> Races { get; set; } = 
            Enum.GetValues(typeof(Race)).Cast<Race>()
                .Select(x => new SelectListItem { Text = x.ToString(), Value = ((int)x).ToString() });

        public IEnumerable<Person> People { get; set; } = new List<Person>();
    }
}