﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// ClickOnItemsControlInShape
        /// </summary>
        public void ClickOnItemsControlInShape()
        {
            #region Variable Declarations
            WpfButton uIClickHereButton = this.UIWpfWindow.UIClickHereButton;
            WpfCustom uICustomElement_4Custom = this.UIWpfWindow.UIDiagramCustom.UICustomElement_4Custom;
            #endregion

            // Click 'Click Here!' button
            Mouse.Click(uIClickHereButton, new Point(69, 21));

            // Move 'CustomElement_4' custom control
            Mouse.StartDragging(uICustomElement_4Custom, new Point(179, 134));
            Mouse.StopDragging(uICustomElement_4Custom, 832, 285);

            //The CodedUI Test Builder can't find the ItemsControl

            // Click 'CustomElement_4' custom control
            Mouse.Click(uICustomElement_4Custom, new Point(193, 117));

            // Click 'CustomElement_4' custom control
            Mouse.Click(uICustomElement_4Custom, new Point(190, 62));
        }
        
        #region Properties
        public UIWpfWindow UIWpfWindow
        {
            get
            {
                if ((this.mUIWpfWindow == null))
                {
                    this.mUIWpfWindow = new UIWpfWindow();
                }
                return this.mUIWpfWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIWpfWindow mUIWpfWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIWpfWindow : WpfWindow
    {
        
        public UIWpfWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            #endregion
        }
        
        #region Properties
        public WpfButton UIClickHereButton
        {
            get
            {
                if ((this.mUIClickHereButton == null))
                {
                    this.mUIClickHereButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIClickHereButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "btn_AddShape";
                    #endregion
                }
                return this.mUIClickHereButton;
            }
        }
        
        public UIDiagramCustom UIDiagramCustom
        {
            get
            {
                if ((this.mUIDiagramCustom == null))
                {
                    this.mUIDiagramCustom = new UIDiagramCustom(this);
                }
                return this.mUIDiagramCustom;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUIClickHereButton;
        
        private UIDiagramCustom mUIDiagramCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIDiagramCustom : WpfCustom
    {
        
        public UIDiagramCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.RadDiagram";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "diagram";
            #endregion
        }
        
        #region Properties
        public WpfCustom UICustomElement_4Custom
        {
            get
            {
                if ((this.mUICustomElement_4Custom == null))
                {
                    this.mUICustomElement_4Custom = new WpfCustom(this);
                    #region Search Criteria
                    this.mUICustomElement_4Custom.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.RadDiagramShape";
                    this.mUICustomElement_4Custom.SearchProperties[WpfControl.PropertyNames.AutomationId] = "CustomElement_4";
                    #endregion
                }
                return this.mUICustomElement_4Custom;
            }
        }
        #endregion
        
        #region Fields
        private WpfCustom mUICustomElement_4Custom;
        #endregion
    }
}
