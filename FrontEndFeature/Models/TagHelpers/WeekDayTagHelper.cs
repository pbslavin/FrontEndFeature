using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace FrontEndFeature.Models.TagHelpers
{
    public class WeekDayTagHelper : TagHelper
    {
        public static string dayOfWeek
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string outputString = $"Today is {dayOfWeek}.";
            output.TagName = "h3";
            output.Content.SetContent(outputString);
        }
    }
}
