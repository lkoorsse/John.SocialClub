using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CodedUITestProject1
{
    class LoginClass
    {
        public class UITxtUsernameWindow : WinWindow
        {

            public UITxtUsernameWindow(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
            {
                #region Search Criteria

                this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtUsername";
                this.WindowTitles.Add("Social club - Login");

                #endregion
            }

        }

        public class UITxtPasswordWindow : WinWindow
        {

            public UITxtPasswordWindow(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
            {
                #region Search Criteria

                this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtPassword";
                this.WindowTitles.Add("Social club - Login");

                #endregion
            }
        }

        public class UILoginWindow : WinWindow
        {

            public UILoginWindow(UITestControl searchLimitContainer) :
                base(searchLimitContainer)
            {
                #region Search Criteria

                this.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnLogin";
                this.WindowTitles.Add("Social club - Login");

                #endregion
            }
        }
    }
}

