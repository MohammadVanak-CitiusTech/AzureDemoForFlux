using Flux.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace KT.Base
{
    public class KTPageBase : WebPageBase
    {
        public void TakeScreenShot()
        {

            Actions.TakeScreenshot(ScreenshotImageFormat.Png, TestEnvironment.ApplicationPath, TestContext.CurrentContext.Test.Name + ".png");
            Waits.WaitForPageLoad();
        }
    }
}
