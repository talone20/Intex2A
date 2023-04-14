using Intex2A.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex2A.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-blah")]
    public class PaginationTagHelper : TagHelper
    {
        private IUrlHelperFactory uhf;

        public PaginationTagHelper (IUrlHelperFactory temp)
        {
            uhf = temp;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext vc { get; set;  }

        public PageInfo PageBlah { get; set; }

        public string PageAction { get; set; }

        public string PageClass { get; set; }

        public bool PageClassesEnabled { get; set; }

        public string PageClassNormal { get; set; }

        public string PageClassNuts { get; set; }

        public string PageClassSelected { get; set; }
        public override void Process (TagHelperContext thc, TagHelperOutput tho)
        {
            IUrlHelper uh = uhf.GetUrlHelper(vc);

            TagBuilder final = new TagBuilder("div");

            int startPage = PageBlah.CurrentPage - 3;
            int endPage = PageBlah.CurrentPage + 4;
            // Make sure we don't have negative page numbers anymore lmfaooo
            if (PageBlah.CurrentPage == 1 || PageBlah.CurrentPage == 2 || PageBlah.CurrentPage == 3)
            {
                startPage = 1;
            }
            if (PageBlah.CurrentPage == PageBlah.TotalPages || PageBlah.CurrentPage == PageBlah.TotalPages-1 || PageBlah.CurrentPage == PageBlah.TotalPages-2 || PageBlah.CurrentPage == PageBlah.TotalPages - 3)
            {
                endPage = PageBlah.TotalPages;
            }
            

            for (int i = startPage; i < endPage; i++)
            {
                TagBuilder tb = new TagBuilder("a");
                string pageName = "";

                if (i == PageBlah.CurrentPage)
                {
                    pageName = "(" + i.ToString() + ")";
                }
                else
                {
                    pageName = i.ToString();
                }
                tb.Attributes["href"] = uh.Action(PageAction, new { pageNum = i });

                if (PageClassesEnabled)
                {
                    tb.AddCssClass(PageClassNuts);
                    tb.AddCssClass(PageClass);
                    tb.AddCssClass(i == PageBlah.CurrentPage ? PageClassSelected : PageClassNormal);
                }

                tb.AddCssClass(PageClass);
                tb.InnerHtml.Append(pageName.ToString());

                final.InnerHtml.AppendHtml(tb);
            }

            tho.Content.AppendHtml(final.InnerHtml);
        }
    }
}




//for (int i = 1; i < PageBlah.TotalPages; i++)
//{
//    TagBuilder tb = new TagBuilder("a");

//    tb.Attributes["href"] = uh.Action(PageAction, new { pageNum = i });

//    if (PageClassesEnabled)
//    {
//        tb.AddCssClass(PageClass);
//        tb.AddCssClass(i == PageBlah.CurrentPage ? PageClassSelected : PageClassNormal);
//    }

//    tb.AddCssClass(PageClass);
//    tb.InnerHtml.Append(i.ToString());

//    final.InnerHtml.AppendHtml(tb);
//}
