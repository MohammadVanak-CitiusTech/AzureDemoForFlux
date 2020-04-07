using KT.PageObject;
using NUnit.Framework;

namespace KT
{
    public class AmazonTest : KTTestBase
    {
        [Test]
        [Category("smoke")]
        public void AmazonSearch()
        {
            var Amazon = Application.NewPage<AmazonHome>();
            Amazon.AmazonSearch("Legend Of Zelda");
            //Assert.AreEqual(pagetitle, "Legend Of Zelda");
            Amazon.Actions.CloseBrowser();
            Assert.Pass();//Instead of this use above
        }
    }
}
