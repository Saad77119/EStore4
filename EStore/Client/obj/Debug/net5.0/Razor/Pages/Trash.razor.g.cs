#pragma checksum "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\Pages\Trash.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee8c63f30f62b73917de6b6e2e24d63802927fb8"
// <auto-generated/>
#pragma warning disable 1591
namespace EStore.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using EStore.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using EStore.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\saadr\OneDrive\Desktop\EAD Semes\eStore-EADProject\EStore\Client\_Imports.razor"
using EStore.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Trash")]
    public partial class Trash : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"app sidebar-mini rtl\"><header class=\"app-header\"><a class=\"app-header__logo\" href=\"Index2\">Estore</a>\r\n        <a class=\"app-sidebar__toggle\" href=\"#\" data-toggle=\"sidebar\" aria-label=\"Hide Sidebar\"></a>\r\n        \r\n        <ul class=\"app-nav\"><li class=\"dropdown\"><a class=\"app-nav__item\" href=\"LoginDashboard\" data-toggle=\"dropdown\" aria-label=\"Open Profile Menu\"><i class=\"fa fa-user fa-lg\"></i></a>\r\n            <ul class=\"dropdown-menu settings-menu dropdown-menu-right\"><li><a class=\"dropdown-item\" href=\"LoginDashboard\"><i class=\"fa fa-sign-out fa-lg\"></i> Logout</a></li></ul></li></ul></header>\r\n    \r\n    <div class=\"app-sidebar__overlay\" data-toggle=\"sidebar\"></div>\r\n    <aside class=\"app-sidebar\"><div><p class=\"app-sidebar__user-name\">Estore</p>\r\n            <p class=\"app-sidebar__user-designation\">Admin</p></div>\r\n\r\n        <ul class=\"app-menu\"><li><a class=\"app-menu__item active\" href=\"Index2\"><i class=\"app-menu__icon fa fa-dashboard\"></i><span class=\"app-menu__label\">Dashboard</span></a></li>\r\n\r\n\r\n\r\n            <li><a class=\"app-menu__item\" href=\"Formsamples\" data-toggle=\"treeview\"><i class=\"app-menu__icon fa fa-edit\"></i><span class=\"app-menu__label\"> Product</span></a></li>\r\n\r\n\r\n            <li><a class=\"app-menu__item\" href=\"Tablebasic\" data-toggle=\"treeview\"><i class=\"app-menu__icon fa fa-th-list\"></i><span class=\"app-menu__label\">Data</span></a></li>\r\n            <li><a class=\"app-menu__item\" href=\"Pageinvoice\" data-toggle=\"treeview\"><i class=\"app-menu__icon fa fa-th-list\"></i><span class=\"app-menu__label\">Invoice</span></a></li>\r\n            <li><a class=\"app-menu__item\" href=\"Pagemailbox\" data-toggle=\"treeview\"><i class=\"app-menu__icon fa fa-th-list\"></i><span class=\"app-menu__label\"> Mailbox</span></a></li></ul></aside>\r\n    <main class=\"app-content\"><div class=\"app-title\"><div><h1><i class=\"fa fa-envelope-o\"></i> Trash</h1></div>\r\n            <ul class=\"app-breadcrumb breadcrumb\"><li class=\"breadcrumb-item\"><i class=\"fa fa-home fa-lg\"></i></li>\r\n                <li class=\"breadcrumb-item\"><a href=\"#\">HOME</a></li></ul></div>\r\n        <div class=\"row\"><div class=\"col-md-3\"><a class=\"mb-2 btn btn-primary btn-block\" href>Compose Mail</a>\r\n                <div class=\"tile p-0\"><h4 class=\"tile-title folder-head\">Folders</h4>\r\n                    <div class=\"tile-body\"><ul class=\"nav nav-pills flex-column mail-nav\"><li class=\"nav-item active\"><a class=\"nav-link\" href=\"Pagemailbox\"><i class=\"fa fa-inbox fa-fw\"></i> Inbox<span class=\"badge badge-pill badge-primary float-right\">12</span></a></li>\r\n                            <li class=\"nav-item\"><a class=\"nav-link\" href=\"Sent\"><i class=\"fa fa-envelope-o fa-fw\"></i> Sent</a></li>\r\n                            <li class=\"nav-item\"><a class=\"nav-link\" href=\"Draft\"><i class=\"fa fa-file-text-o fa-fw\"></i> Drafts</a></li>\r\n                            <li class=\"nav-item\"><a class=\"nav-link\" href=\"Junk\"><i class=\"fa fa-filter fa-fw\"></i> Junk <span class=\"badge badge-pill badge-primary float-right\">8</span></a></li>\r\n                            <li class=\"nav-item\"><a class=\"nav-link\" href=\"Trash\"><i class=\"fa fa-trash-o fa-fw\"></i> Trash</a></li></ul></div></div></div>\r\n            <div class=\"col-md-9\"><div class=\"tile\"><div class=\"mailbox-controls\"><div class=\"animated-checkbox\"><label><input type=\"checkbox\"><span class=\"label-text\"></span></label></div>\r\n                        <div class=\"btn-group\"><button class=\"btn btn-primary btn-sm\" type=\"button\"><i class=\"fa fa-trash-o\"></i></button>\r\n                            <button class=\"btn btn-primary btn-sm\" type=\"button\"><i class=\"fa fa-reply\"></i></button>\r\n                            <button class=\"btn btn-primary btn-sm\" type=\"button\"><i class=\"fa fa-share\"></i></button>\r\n                            <button class=\"btn btn-primary btn-sm\" type=\"button\"><i class=\"fa fa-refresh\"></i></button></div></div>\r\n                    <div class=\"table-responsive mailbox-messages\"><table class=\"table table-hover\"><tbody><tr><td><div class=\"animated-checkbox\"><label><input type=\"checkbox\"><span class=\"label-text\"></span></label></div></td>\r\n                                    <td><a href=\"#\"><i class=\"fa fa-star-o\"></i></a></td>\r\n                                    <td><a href=\"read-mail.html\">aqsa</a></td>\r\n                                    <td class=\"mail-subject\"><b>A report on project almanac</b> - Lorem ipsum dolor sit amet adipisicing elit...</td>\r\n                                    <td><i class=\"fa fa-paperclip\"></i></td>\r\n                                    <td>8 mins ago</td></tr>\r\n                                <tr><td><div class=\"animated-checkbox\"><label><input type=\"checkbox\"><span class=\"label-text\"></span></label></div></td>\r\n                                    <td><a href=\"#\"><i class=\"fa fa-star\"></i></a></td>\r\n                                    <td><a href=\"read-mail.html\">John Doe</a></td>\r\n                                    <td><b>A report on some good project</b> - Lorem ipsum dolor sit amet adipisicing elit...</td>\r\n                                    <td></td>\r\n                                    <td>15 mins ago</td></tr>\r\n                                <tr><td><div class=\"animated-checkbox\"><label><input type=\"checkbox\"><span class=\"label-text\"></span></label></div></td>\r\n                                    <td><a href=\"#\"><i class=\"fa fa-star-o\"></i></a></td>\r\n                                    <td><a href=\"read-mail.html\">John Doe</a></td>\r\n                                    <td class=\"mail-subject\"><b>A report on project almanac</b> - Lorem ipsum dolor sit amet adipisicing elit...</td>\r\n                                    <td><i class=\"fa fa-paperclip\"></i></td>\r\n                                    <td>30 mins ago</td></tr>\r\n                                <tr><td><div class=\"animated-checkbox\"><label><input type=\"checkbox\"><span class=\"label-text\"></span></label></div></td>\r\n                                    <td><a href=\"#\"><i class=\"fa fa-star\"></i></a></td>\r\n                                    <td><a href=\"read-mail.html\">John Doe</a></td>\r\n                                    <td class=\"mail-subject\"><b>A report on project almanac</b> - Lorem ipsum dolor sit amet adipisicing elit...</td>\r\n                                    <td></td>\r\n                                    <td>25 December</td></tr>\r\n                                <tr><td><div class=\"animated-checkbox\"><label><input type=\"checkbox\"><span class=\"label-text\"></span></label></div></td>\r\n                                    <td><a href=\"#\"><i class=\"fa fa-star-o\"></i></a></td>\r\n                                    <td><a href=\"read-mail.html\">John Doe</a></td>\r\n                                    <td class=\"mail-subject\"><b>A report on project almanac</b> - Lorem ipsum dolor sit amet adipisicing elit...</td>\r\n                                    <td><i class=\"fa fa-paperclip\"></i></td>\r\n                                    <td>20 December</td></tr>\r\n                                <tr><td><div class=\"animated-checkbox\"><label><input type=\"checkbox\"><span class=\"label-text\"></span></label></div></td>\r\n                                    <td><a href=\"#\"><i class=\"fa fa-star\"></i></a></td>\r\n                                    <td><a href=\"read-mail.html\">John Doe</a></td>\r\n                                    <td class=\"mail-subject\"><b>A report on project almanac</b> - Lorem ipsum dolor sit amet adipisicing elit...</td>\r\n                                    <td></td>\r\n                                    <td>20 December</td></tr>\r\n                                <tr><td><div class=\"animated-checkbox\"><label><input type=\"checkbox\"><span class=\"label-text\"></span></label></div></td>\r\n                                    <td><a href=\"#\"><i class=\"fa fa-star\"></i></a></td>\r\n                                    <td><a href=\"read-mail.html\">John Doe</a></td>\r\n                                    <td class=\"mail-subject\"><b>A report on project almanac</b> - Lorem ipsum dolor sit amet adipisicing elit...</td>\r\n                                    <td><i class=\"fa fa-paperclip\"></i></td>\r\n                                    <td>20 December</td></tr>\r\n                                <tr><td><div class=\"animated-checkbox\"><label><input type=\"checkbox\"><span class=\"label-text\"></span></label></div></td>\r\n                                    <td><a href=\"#\"><i class=\"fa fa-star-o\"></i></a></td>\r\n                                    <td><a href=\"read-mail.html\">John Doe</a></td>\r\n                                    <td class=\"mail-subject\"><b>A report on project almanac</b> - Lorem ipsum dolor sit amet adipisicing elit...</td>\r\n                                    <td></td>\r\n                                    <td>20 December</td></tr></tbody></table></div>\r\n                    <div class=\"text-right\"><span class=\"text-muted mr-2\">Showing 1-15 out of 60</span>\r\n                        <div class=\"btn-group\"><button class=\"btn btn-primary btn-sm\" type=\"button\"><i class=\"fa fa-chevron-left\"></i></button>\r\n                            <button class=\"btn btn-primary btn-sm\" type=\"button\"><i class=\"fa fa-chevron-right\"></i></button></div></div></div></div></div></main></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
