﻿
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
        public MembershipsTests()
        {
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
            //this.UIMap.NewMemberDeleteClearUpdateFields();


            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.


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
