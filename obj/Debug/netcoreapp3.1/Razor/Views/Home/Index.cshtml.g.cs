#pragma checksum "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89b3c7b0163250a0ff0426156d44536f10249b87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\_ViewImports.cshtml"
using PacificProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\_ViewImports.cshtml"
using PacificProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\_ViewImports.cshtml"
using PacificProject.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89b3c7b0163250a0ff0426156d44536f10249b87", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbe76da121f578869a2f2547b02ab992e8b28393", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""hero-wrap js-fullheight"" style=""background-image: url('images/bg_5.jpg');"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters slider-text js-fullheight align-items-center"" data-scrollax-parent=""true"">
            <div class=""col-md-7 ftco-animate"">
                <span class=""subheading"">Welcome to Pacific</span>
                <h1 class=""mb-4"">Discover Your Favorite Place with Us</h1>
                <p class=""caps"">Travel to the any corner of the world, without going around in circles</p>
            </div>
            <a href=""https://vimeo.com/45830194"" class=""icon-video popup-vimeo d-flex align-items-center justify-content-center mb-4"">
                <span class=""fa fa-play""></span>
            </a>
        </div>
    </div>
</div>


<section class=""ftco-section img ftco-select-destination"" style=""background-image: url(images/bg_3.jpg);"">
    <div class=""container"">
        <div class=""row justify-content-center pb-4"">
     ");
            WriteLiteral(@"       <div class=""col-md-12 heading-section text-center ftco-animate"">
                <span class=""subheading"">Pacific Provide Places</span>
                <h2 class=""mb-4"">Select Your Destination</h2>
            </div>
        </div>
    </div>
    <div class=""container container-2"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""carousel-destination owl-carousel ftco-animate"">
");
#nullable restore
#line 32 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
                     foreach (var item in Model.Destinations)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item\">\r\n                            <div class=\"project-destination\">\r\n                                <a href=\"#\" class=\"img\"");
            BeginWriteAttribute("style", " style=\"", 1738, "\"", 1795, 4);
            WriteAttributeValue("", 1746, "background-image:", 1746, 17, true);
            WriteAttributeValue(" ", 1763, "url(images/", 1764, 12, true);
#nullable restore
#line 36 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 1775, item.CountryImage, 1775, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1793, ");", 1793, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"text\">\r\n                                        <h3>");
#nullable restore
#line 38 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
                                       Write(item.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        <span>");
#nullable restore
#line 39 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
                                         Write(item.TourDayCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Tours</span>\r\n                                    </div>\r\n                                </a>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 44 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row justify-content-center pb-4"">
            <div class=""col-md-12 heading-section text-center ftco-animate"">
                <span class=""subheading"">Destination</span>
                <h2 class=""mb-4"">Tour Destination</h2>
            </div>
        </div>
        <div class=""row"">
");
#nullable restore
#line 61 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
             foreach (var item in Model.Destinations)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 ftco-animate\">\r\n                    <div class=\"project-wrap\">\r\n                        <a href=\"#\" class=\"img\"");
            BeginWriteAttribute("style", " style=\"", 2851, "\"", 2906, 4);
            WriteAttributeValue("", 2859, "background-image:", 2859, 17, true);
            WriteAttributeValue(" ", 2876, "url(images/", 2877, 12, true);
#nullable restore
#line 65 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 2888, item.PlaceImage, 2888, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2904, ");", 2904, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <span class=\"price\">$");
#nullable restore
#line 66 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
                                            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("/person</span>\r\n                        </a>\r\n                        <div class=\"text p-4\">\r\n                            <span class=\"days\">");
#nullable restore
#line 69 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
                                          Write(item.TourDayCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Days Tour</span>\r\n                            <h3><a href=\"#\">");
#nullable restore
#line 70 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
                                       Write(item.Place);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            <p class=\"location\"><span class=\"fa fa-map-marker\"></span> ");
#nullable restore
#line 71 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
                                                                                  Write(item.Place);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            <ul>
                                <li><span class=""flaticon-shower""></span>2</li>
                                <li><span class=""flaticon-king-size""></span>3</li>
                                <li><span class=""flaticon-mountains""></span>Near Mountain</li>
                            </ul>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 80 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </div>
    </div>
</section>

<section class=""ftco-section ftco-about img"" style=""background-image: url(images/bg_4.jpg);"">
    <div class=""overlay""></div>
    <div class=""container py-md-5"">
        <div class=""row py-md-5"">
            <div class=""col-md d-flex align-items-center justify-content-center"">
                <a href=""https://vimeo.com/45830194"" class=""icon-video popup-vimeo d-flex align-items-center justify-content-center mb-4"">
                    <span class=""fa fa-play""></span>
                </a>
            </div>
        </div>
    </div>
</section>

<section class=""ftco-section ftco-about ftco-no-pt img"">
    <div class=""container"">
        <div class=""row d-flex"">
            <div class=""col-md-12 about-intro"">
                <div class=""row"">
                    <div class=""col-md-6 d-flex align-items-stretch"">
                        <div class=""img d-flex w-100 align-items-center justify-content-center"" style=""background-image:url(images/about-1.jp");
            WriteLiteral(@"g);"">
                        </div>
                    </div>
                    <div class=""col-md-6 pl-md-5 py-5"">
                        <div class=""row justify-content-start pb-3"">
                            <div class=""col-md-12 heading-section ftco-animate"">
                                <span class=""subheading"">About Us</span>
                                <h2 class=""mb-4"">Make Your Tour Memorable and Safe With Us</h2>
                                <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.</p>
                                <p><a href=""#"" class=""btn btn-primary"">Book Your Destination</a></p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""ftco-section testimon");
            WriteLiteral(@"y-section bg-bottom"" style=""background-image: url(images/bg_1.jpg);"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row justify-content-center pb-4"">
            <div class=""col-md-7 text-center heading-section heading-section-white ftco-animate"">
                <span class=""subheading"">Testimonial</span>
                <h2 class=""mb-4"">Tourist Feedback</h2>
            </div>
        </div>
        <div class=""row ftco-animate"">
            <div class=""col-md-12"">
                <div class=""carousel-testimony owl-carousel"">
");
#nullable restore
#line 137 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
                     foreach (var item in Model.Comments)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""item"">
                            <div class=""testimony-wrap py-4"">
                                <div class=""text"">
                                    <p class=""star"">
                                        <span class=""fa fa-star""></span>
                                        <span class=""fa fa-star""></span>
                                        <span class=""fa fa-star""></span>
                                        <span class=""fa fa-star""></span>
                                        <span class=""fa fa-star""></span>
                                    </p>
                                    <p class=""mb-4"">");
#nullable restore
#line 149 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
                                               Write(item.Explanation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <div class=\"d-flex align-items-center\">\r\n                                        <div class=\"user-img\"");
            BeginWriteAttribute("style", " style=\"", 7295, "\"", 7344, 4);
            WriteAttributeValue("", 7303, "background-image:", 7303, 17, true);
            WriteAttributeValue(" ", 7320, "url(images/", 7321, 12, true);
#nullable restore
#line 151 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 7332, item.Image, 7332, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7343, ")", 7343, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                        <div class=\"pl-3\">\r\n                                            <p class=\"name\">");
#nullable restore
#line 153 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <span class=\"position\">");
#nullable restore
#line 154 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
                                                              Write(item.Job);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 160 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</section>


<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row justify-content-center pb-4"">
            <div class=""col-md-12 heading-section text-center ftco-animate"">
                <span class=""subheading"">Our Blog</span>
                <h2 class=""mb-4"">Recent Post</h2>
            </div>
        </div>
        <div class=""row d-flex"">
");
#nullable restore
#line 179 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
             foreach (var item in Model.Blogs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 d-flex ftco-animate\">\r\n                    <div class=\"blog-entry justify-content-end\">\r\n                        <a href=\"blog-single.html\" class=\"block-20\"");
            BeginWriteAttribute("style", " style=\"", 8519, "\"", 8571, 4);
            WriteAttributeValue("", 8527, "background-image:", 8527, 17, true);
            WriteAttributeValue(" ", 8544, "url(\'images/", 8545, 13, true);
#nullable restore
#line 183 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 8557, item.Image, 8557, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8568, "\');", 8568, 3, true);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                        <div class=""text"">
                            <div class=""d-flex align-items-center mb-4 topp"">
                                <div class=""one"">
                                    <span class=""day"">");
#nullable restore
#line 188 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
                                                 Write(item.Date.ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <div class=\"two\">\r\n                                    <span class=\"yr\">");
#nullable restore
#line 191 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
                                                Write(item.Date.ToString("yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"mos\">");
#nullable restore
#line 192 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
                                                 Write(item.Date.ToString("MMMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                            </div>\r\n                            </div>\r\n                            <h3 class=\"heading\"><a href=\"#\">");
#nullable restore
#line 196 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
                                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            <!-- <p>A small river named Duden flows by their place and supplies it with the necessary regelialia.</p> -->\r\n                            <p><a");
            BeginWriteAttribute("href", " href=\"", 9465, "\"", 9498, 2);
            WriteAttributeValue("", 9472, "Blogs/Details/", 9472, 14, true);
#nullable restore
#line 198 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 9486, item.BlogId, 9486, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Read more</a></p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 202 "C:\Users\anil_\OneDrive\Masaüstü\core-projects\PacificProject\PacificProject\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>

<section class=""ftco-intro ftco-section ftco-no-pt"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-md-12 text-center"">
                <div class=""img"" style=""background-image: url(images/bg_2.jpg);"">
                    <div class=""overlay""></div>
                    <h2>We Are Pacific A Travel Agency</h2>
                    <p>We can manage your dream building A small river named Duden flows by their place</p>
                    <p class=""mb-0""><a href=""#"" class=""btn btn-primary px-4 py-3"">Ask For A Quote</a></p>
                </div>
            </div>
        </div>
    </div>
</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomePageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
