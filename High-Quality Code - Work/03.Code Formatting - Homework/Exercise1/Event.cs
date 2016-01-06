﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Event : IComparable
    {
        public DateTime date;
        public String title;
        public String location;

        public Event(DateTime date, String title, String location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int byDate = this.date.CompareTo(other.date);
            int byTitle = String.Compare(this.title, other.title, StringComparison.Ordinal);

            var byLocation = String.Compare(this.location, other.location, StringComparison.Ordinal);
            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }
                else
                {
                    return byTitle;
                }
            }
            else
            {
                return byDate;
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append(date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + title);
            if (!string.IsNullOrEmpty(location))
            {
                toString.Append(" | " + location);
            }
            return toString.ToString();
        }
    }
}
