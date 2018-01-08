using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace CodedUITestProject1
{
    /// <summary>
    /// Summary description for RegistrationMandatoryError
    /// </summary>
    [CodedUITest]
    public class RegistrationMandatoryError
    {
        public RegistrationMandatoryError() // empty default constructor
        {
        }

        [TestInitialize]
        public void TestInitialize()
        {

            ApplicationUnderTest.Launch(@"C:\Codep\John.SocialClub\John.SocialClub.Desktop\bin\Debug\John.SocialClub.Desktop.exe");
        }

        [TestMethod]
        public void RegMandatoryError()
        {

            this.UIMap.LoginSuccess();
            this.UIMap.SelectRegisterNoMandatoryItemsCompleted();
            this.UIMap.AssertRegistrationError();
            this.UIMap.RegistrationErrorDismiss();
            this.UIMap.SocialClubApplicationClose();

        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
