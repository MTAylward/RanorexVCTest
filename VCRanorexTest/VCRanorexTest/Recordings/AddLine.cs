﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace VCRanorexTest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddLine recording.
    /// </summary>
    [TestModule("fd718ff5-8d17-4613-8fb4-48314c5ab054", ModuleType.Recording, 1)]
    public partial class AddLine : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::VCRanorexTest.VCRanorexTestRepository repository.
        /// </summary>
        public static global::VCRanorexTest.VCRanorexTestRepository repo = global::VCRanorexTest.VCRanorexTestRepository.Instance;

        static AddLine instance = new AddLine();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddLine()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddLine Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VersionControlTest.MainMenuSelection' at 604;136.", repo.VersionControlTest.MainMenuSelectionInfo, new RecordItemIndex(0));
            repo.VersionControlTest.MainMenuSelection.Click("604;136");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VersionControlTest.SecondaryMenuSelection' at 598;138.", repo.VersionControlTest.SecondaryMenuSelectionInfo, new RecordItemIndex(1));
            repo.VersionControlTest.SecondaryMenuSelection.Click("598;138");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Linework.Add' at 51;24.", repo.Linework.AddInfo, new RecordItemIndex(2));
            repo.Linework.Add.Click("51;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddLine.AddPoints' at 143;34.", repo.AddLine.AddPointsInfo, new RecordItemIndex(3));
            repo.AddLine.AddPoints.Click("143;34");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ContextMenuMf.MenuItem' at 127;22.", repo.ContextMenuMf.MenuItemInfo, new RecordItemIndex(4));
            repo.ContextMenuMf.MenuItem.Click("127;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMap.Button' at 37;30.", repo.FormMap.ButtonInfo, new RecordItemIndex(5));
            repo.FormMap.Button.Click("37;30");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMap.Button1' at 32;24.", repo.FormMap.Button1Info, new RecordItemIndex(6));
            repo.FormMap.Button1.Click("32;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMap.Button' at 34;26.", repo.FormMap.ButtonInfo, new RecordItemIndex(7));
            repo.FormMap.Button.Click("34;26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMap.Element20063' at 259;541.", repo.FormMap.Element20063Info, new RecordItemIndex(8));
            repo.FormMap.Element20063.Click("259;541");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMap.Element20063' at 260;99.", repo.FormMap.Element20063Info, new RecordItemIndex(9));
            repo.FormMap.Element20063.Click("260;99");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMap.Button2' at 33;29.", repo.FormMap.Button2Info, new RecordItemIndex(10));
            repo.FormMap.Button2.Click("33;29");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'AddLine.Button' at 37;29.", repo.AddLine.ButtonInfo, new RecordItemIndex(11));
            repo.AddLine.Button.Click("37;29");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Linework.Home' at 34;29.", repo.Linework.HomeInfo, new RecordItemIndex(12));
            repo.Linework.Home.Click("34;29");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
