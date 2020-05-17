using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNetCoreWebAPI.API.Helpers
{
    public static class DateTimeOffsetExtensions
    {
        public static int GetPublishedAge(this DateTime dateTime)
        {
            var today = DateTime.Today;
            var age = today.Year - dateTime.Year;

            if (dateTime.Date > today.AddYears(-age)) age--;

            return age;
        } 
    }
}
