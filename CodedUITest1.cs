using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using System.IO;

namespace CodedUITestProject1
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        ApplicationUnderTest App = null;
        public CodedUITest1()
        {
        }

        public UIWpfWindow GetMainWindow()
        {
            var mainWindow = new UIWpfWindow();
            mainWindow.SearchProperties.Add(new PropertyExpression(WpfControl.PropertyNames.AutomationId, "Main_Window"));
            mainWindow.Find();
            return mainWindow;
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            var mainWindow = GetMainWindow();

            var btn = new WpfButton(mainWindow);
            btn.SearchProperties.Add(new PropertyExpression(WpfControl.PropertyNames.AutomationId, "btn_AddShape"));
            btn.Find();
            btn.WaitForControlReady();
            Mouse.Click(btn);

            var diagram = new WpfCustom(mainWindow);
            diagram.SearchProperties.Add(new PropertyExpression(WpfControl.PropertyNames.AutomationId, "diagram"));
            diagram.Find();
            diagram.WaitForControlReady();

            var element = new WpfCustom(diagram);
            element.SearchProperties.Add(new PropertyExpression(WpfControl.PropertyNames.AutomationId, "CustomElement_1"));
            element.Find();
            element.WaitForControlReady();

            var itemsControl = new WpfList(element);
            itemsControl.SearchProperties.Add(new PropertyExpression(WpfControl.PropertyNames.AutomationId, "itemsC"));

            //The CodedUI can't find the ItemsControl
            itemsControl.Find();
            itemsControl.WaitForControlReady();
            string[] s = itemsControl.Items.GetValuesOfControls();
        }
        #region Additional test attributes

        [TestMethod]
        public void GenerateMethod()
        {

            this.UIMap.ClickOnItemsControlInShape();

        }

        [TestInitialize()]
        public void MyTestInitialize()
        {
            App = ApplicationUnderTest.Launch(@"D:\Projects\Sample\Project_Telerik\Project_Telerik\bin\Debug\Project_Telerik.exe");
            var window = new WpfWindow();
            window.SearchProperties.Add(new PropertyExpression(WpfControl.PropertyNames.Name, "Telerik UI for WPF Trial"));
            window.Find();
            window.SetFocus();
            Keyboard.SendKeys(window, "{F4}", ModifierKeys.Alt);
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            App.Close();
        }

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
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
