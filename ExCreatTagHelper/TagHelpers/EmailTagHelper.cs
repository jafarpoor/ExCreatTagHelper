using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExCreatTagHelper.TagHelpers
{
    //ححتما باید  ارث برای داشته باشه

    //[HtmlTargetElement("tag-name")]
    public class EmailTagHelper :TagHelper
    {
        private string Domain = "gmail.com";
        private string MailTo { get; set; }
        
        public override void Process(TagHelperContext tagHelperContext , TagHelperOutput tagHelperOutput)
        {
            tagHelperOutput.TagName = "a";
            string adress = MailTo + "@" + Domain;
            tagHelperOutput.Attributes.SetAttribute("href", "mailto:" + adress);
            tagHelperOutput.Content.SetContent(adress);
        }
    }
}
