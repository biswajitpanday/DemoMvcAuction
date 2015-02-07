using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.WebPages;

namespace MvcAuction.App_Start
{
    public class DisplayModes
    {
        public static void ConfigureDisplayModes()
        {
            //Register iPhone-specific Views.
            DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode("iPhone")
            {
                ContextCondition = (ctx => ctx.Request.UserAgent.IndexOf(
                    "iPhone", StringComparison.OrdinalIgnoreCase) >= 0)
            });

            //Register iPand-specific Views.
            DisplayModeProvider.Instance.Modes.Insert(0, new DefaultDisplayMode("iPad")
            {
                ContextCondition = (ctx => ctx.Request.UserAgent.IndexOf(
                    "iPad", StringComparison.OrdinalIgnoreCase) >=0)
            });

        }
    }
}