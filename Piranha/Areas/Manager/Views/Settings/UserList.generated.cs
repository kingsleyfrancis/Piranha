﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.Settings
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Piranha.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Settings/UserList.cshtml")]
    public partial class UserList : System.Web.Mvc.WebViewPage<Piranha.Manager.Models.UserListModel>
    {
        public UserList()
        {
        }
        public override void Execute()
        {
DefineSection("Head", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $(document).ready(function () {
            var options = {
                listClass: 'list-js',
                searchId: 'search',
                valueNames: ['login', 'name', 'group', 'updated', 'created']
            };
            var list = new List('list', options);
        });
    </script>
");

});

DefineSection("Toolbar", () => {

WriteLiteral("\r\n");

            
            #line 15 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
Write(Html.Partial("Partial/Tabs"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"toolbar\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n        <ul>\r\n            <li");

WriteLiteral(" id=\"add\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 561), Tuple.Create("\"", 587)
            
            #line 19 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
, Tuple.Create(Tuple.Create("", 568), Tuple.Create<System.Object, System.Int32>(Url.Action("user")
            
            #line default
            #line hidden
, 568), false)
);

WriteLiteral(" class=\"add\"");

WriteLiteral(">");

            
            #line 19 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                              Write(Piranha.Resources.Global.ToolbarAdd);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 666), Tuple.Create("\"", 696)
            
            #line 20 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
, Tuple.Create(Tuple.Create("", 673), Tuple.Create<System.Object, System.Int32>(Url.Action("userlist")
            
            #line default
            #line hidden
, 673), false)
);

WriteLiteral(" class=\"refresh\"");

WriteLiteral(">");

            
            #line 20 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                             Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n        <button");

WriteLiteral(" class=\"search\"");

WriteLiteral("></button>");

            
            #line 22 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                   Write(Html.TextBox("search"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n");

});

WriteLiteral("\r\n<div");

WriteLiteral(" class=\"grid_12\"");

WriteLiteral(">\r\n    <table");

WriteLiteral(" id=\"list\"");

WriteLiteral(" class=\"list\"");

WriteLiteral(">\r\n        <thead>\r\n            <tr>\r\n                <th></th>\r\n                " +
"<th><span");

WriteLiteral(" class=\"sort asc\"");

WriteLiteral(" data-sort=\"login\"");

WriteLiteral(">");

            
            #line 33 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                        Write(Piranha.Resources.Global.Username);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th><span");

WriteLiteral(" class=\"sort\"");

WriteLiteral(" data-sort=\"name\"");

WriteLiteral(">");

            
            #line 34 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                   Write(Piranha.Resources.Global.Name);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th><span");

WriteLiteral(" class=\"sort\"");

WriteLiteral(" data-sort=\"group\"");

WriteLiteral(">");

            
            #line 35 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                    Write(Piranha.Resources.Global.Group);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th");

WriteLiteral(" class=\"date\"");

WriteLiteral("><span");

WriteLiteral(" class=\"sort\"");

WriteLiteral(" data-sort=\"updated\"");

WriteLiteral(">");

            
            #line 36 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                                   Write(Piranha.Resources.Global.Updated);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th");

WriteLiteral(" class=\"date\"");

WriteLiteral("><span");

WriteLiteral(" class=\"sort\"");

WriteLiteral(" data-sort=\"created\"");

WriteLiteral(">");

            
            #line 37 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                                   Write(Piranha.Resources.Global.Created);

            
            #line default
            #line hidden
WriteLiteral("</span></th>\r\n                <th");

WriteLiteral(" class=\"one\"");

WriteLiteral("></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody");

WriteLiteral(" class=\"list-js\"");

WriteLiteral(">\r\n");

            
            #line 42 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 42 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
             foreach (var user in Model.Users) {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td");

WriteLiteral(" class=\"gravatar\"");

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 1792), Tuple.Create("\"", 1815)
            
            #line 44 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
, Tuple.Create(Tuple.Create("", 1798), Tuple.Create<System.Object, System.Int32>(user.GravatarUrl
            
            #line default
            #line hidden
, 1798), false)
);

WriteLiteral(" /></td>\r\n                <td");

WriteLiteral(" class=\"login\"");

WriteLiteral(">\r\n");

            
            #line 46 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 46 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                     if (User.IsMember(user.GroupId)) {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1941), Tuple.Create("\"", 1989)
            
            #line 47 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
, Tuple.Create(Tuple.Create("", 1948), Tuple.Create<System.Object, System.Int32>(Url.Action("user", new { id = user.Id })
            
            #line default
            #line hidden
, 1948), false)
);

WriteLiteral(">");

            
            #line 47 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                                                                   Write(user.Login);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 48 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                    } else {
                    
            
            #line default
            #line hidden
            
            #line 49 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
               Write(user.Login);

            
            #line default
            #line hidden
            
            #line 49 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                               
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>        \r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">");

            
            #line 52 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                            Write(user.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"group\"");

WriteLiteral(">");

            
            #line 53 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                             Write(user.GroupName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"updated\"");

WriteLiteral(">");

            
            #line 54 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                               Write(user.Updated.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"created\"");

WriteLiteral(">");

            
            #line 55 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                               Write(user.Created.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"buttons\"");

WriteLiteral(">\r\n");

            
            #line 57 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 57 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                     if (User.IsMember(user.GroupId)) {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteLiteral(" class=\"icon delete\"");

WriteAttribute("href", Tuple.Create(" href=\"", 2526), Tuple.Create("\"", 2580)
            
            #line 58 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
, Tuple.Create(Tuple.Create("", 2533), Tuple.Create<System.Object, System.Int32>(Url.Action("deleteuser", new { id = user.Id })
            
            #line default
            #line hidden
, 2533), false)
);

WriteLiteral("></a>\r\n");

            
            #line 59 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n            </tr>\r\n");

            
            #line 62 "..\..\Areas\Manager\Views\Settings\UserList.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
