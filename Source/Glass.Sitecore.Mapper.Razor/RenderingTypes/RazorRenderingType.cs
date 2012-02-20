﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Collections.Specialized;
using Sitecore.Web.UI;
using System.Web.UI;
using System.IO;
using RazorEngine;
using System.Web.UI.WebControls;
using Glass.Sitecore.Mapper.Razor.Web.Ui;

namespace Glass.Sitecore.Mapper.Razor.RenderingTypes
{
    public class RazorRenderingType : RenderingType
    {
        public override Control GetControl(NameValueCollection parameters, bool assert)
        {
            string view = parameters["Name"];

            IRazorControl control = new DynamicControl();
            control.View = view;
            return control as System.Web.UI.WebControls.WebControl;
        }
    }

}
