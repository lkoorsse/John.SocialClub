
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace CodedUITestProject1
{
    /// <summary>
    /// Summary description for MembershipsTests
    /// </summary>
    [CodedUITest]
    public class MembershipsTests
    {
        public MembershipsTests() // empty default constructor
        {
        }

        [TestInitialize]
        public void TestInitialize()
        {

            ApplicationUnderTest.Launch(@"C:\Codep\John.SocialClub\John.SocialClub.Desktop\bin\Debug\John.SocialClub.Desktop.exe");
        }
        

        [TestMethod]
        public void MembershipUpdate()
        {
         
            this.UIMap.LoginSuccess();
            this.UIMap.NewRegistrationForCheckEntry();
            this.UIMap.UpdateNewMemberNoChildren();
            this.UIMap.UpdateMemberSalary();
            this.UIMap.NewMemberSalaryUpdateCheck();
            this.UIMap.DeleteNewMember();
            this.UIMap.SocialClubApplicationClose();

        }

        [TestMethod]
        public void MembershipPageControls()
        {
            this.UIMap.LoginSuccess();
            this.UIMap.NewRegistrationForCheckEntry();
            this.UIMap.DeleteNewMember();
            this.UIMap.SocialClubApplicationClose();
          
         }

        [TestMethod]
        public void MembershipPageFilterSearchOnOR()
        {
            this.UIMap.LoginSuccess();
            this.UIMap.NewRegistrationForCheckEntry();
            this.UIMap.ManageMemberSearchORFilter();
            this.UIMap.CheckEntryExistFilterOnOR();
            this.UIMap.DeleteNewMember();
            this.UIMap.SocialClubApplicationClose();

        }

        [TestMethod]
        public void MembershipPageFilterSearchOnAnd()
        {

            this.UIMap.LoginSuccess();
            this.UIMap.NewRegistrationForCheckEntry();
            this.UIMap.ManageMemebrSearchAndFilter();
            this.UIMap.CheckEntryExistFilterOnAnd();
            this.UIMap.DeleteNewMember();
            this.UIMap.SocialClubApplicationClose();

        }

        [TestMethod]
        public void MembershipRefreshFilter()
        {

            this.UIMap.LoginSuccess();
            this.UIMap.NewRegistrationForCheckEntry();
            this.UIMap.ManageSelectFitlerRefresh();
            this.UIMap.ManageRefreshFilterClearsOccupationField();
            this.UIMap.ManageRefreshFilterClearsMaritalStatusField();
            this.UIMap.DeleteNewMember();
            this.UIMap.SocialClubApplicationClose();

        }

        [TestMethod]
        public void MembershipRefreshNoFilterSearch()
        {

            this.UIMap.LoginSuccess();
            this.UIMap.NewRegistrationForCheckEntry();
            this.UIMap.MemberNoFiterSearch();
            this.UIMap.MemberSearchAndRefresh();
            this.UIMap.MemberSearchNoValueFilterNoMemberResults();
            this.UIMap.DeleteNewMember();
            this.UIMap.SocialClubApplicationClose();

        }

        [TestMethod]
        public void MembershipPageActionPrint()
        {
            this.UIMap.LoginSuccess();
            this.UIMap.NewRegistrationForCheckEntry();
            this.UIMap.SelectPrintButton();
            this.UIMap.ManageMemberPrintModalDisplay();
            this.UIMap.ManageMemberClosePrint();
            this.UIMap.SocialClubApplicationClose();

        }

        [TestMethod]
        public void MembershipPageActionPrintPreview()
        {
            this.UIMap.LoginSuccess();
            this.UIMap.NewRegistrationForCheckEntry();
            this.UIMap.ManageMemberSelectPrintPreview();
            this.UIMap.CheckPrintPreviewDisplay();
            this.UIMap.ClosePrintPreview();
            this.UIMap.SocialClubApplicationClose();

        }


        [TestMethod]
        public void MembershipPageActionPrintExport()
        {

            this.UIMap.LoginSuccess();
            this.UIMap.NewRegistrationForCheckEntry();
            this.UIMap.ManageMemberSelectExport();
            this.UIMap.ManageMemberSelectExportExcelDisplay();
            this.UIMap.CloseExcelSheetDisplayed();
            this.UIMap.SocialClubApplicationClose();

        }


        [TestMethod]
        public void DeleteMemberClearFields()
        {

            this.UIMap.LoginSuccess();
            this.UIMap.NewRegistrationForCheckEntry();
            this.UIMap.DeleteMember();
            this.UIMap.DeleteClearUpdateFields();
            this.UIMap.UpdateFieldDisabled();
            this.UIMap.DeleteNewMember();
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
