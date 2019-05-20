using System;
using System.Linq;
using System.Collections.Generic;
using System.Web.Mvc;

using PagedList;

using SimpleWeb.Entities;

namespace SimpleWeb.Models
{
    public class MainViewModel
    {
        public string Race { get; set; }

        public IEnumerable<SelectListItem> Races
        {
            get
            {
                List<SelectListItem> list = Enum.GetValues(typeof(Race)).Cast<Race>()
                    .Select(x => new SelectListItem { Text = x.ToString(), Value = x.ToString() })
                    .ToList();
                return list.Select(l =>
                    new SelectListItem { Selected = l.Value == Race, Text = l.Text, Value = l.Value });
            }
        }

        public IPagedList<Person> OnePageOfPeople { get; set; }
    }
}