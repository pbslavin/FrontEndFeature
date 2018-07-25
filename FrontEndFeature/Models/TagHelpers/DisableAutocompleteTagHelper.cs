using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace FrontEndFeature.Models.TagHelpers
{
    [HtmlTargetElement("input")]
    public class DisableAutocompleteTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("autocomplete", "off");
        }
    }
}
