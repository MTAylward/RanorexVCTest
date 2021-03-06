///////////////////////////////////////////////////////////////////////////////
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
    ///The VC_Setup recording.
    /// </summary>
    [TestModule("3ca2397c-de7d-4c8a-af0d-b95e892b7a47", ModuleType.Recording, 1)]
    public partial class VC_Setup : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::VCRanorexTest.VCRanorexTestRepository repository.
        /// </summary>
        public static global::VCRanorexTest.VCRanorexTestRepository repo = global::VCRanorexTest.VCRanorexTestRepository.Instance;

        static VC_Setup instance = new VC_Setup();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VC_Setup()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VC_Setup Instance
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(0));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files\\MAGNET Field PC\\mf.exe' in normal mode.", new RecordItemIndex(1));
            Host.Local.RunApplication("C:\\Program Files\\MAGNET Field PC\\mf.exe", "", "C:\\Program Files\\MAGNET Field PC", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Default.MainMenuSelection' at 95;148.", repo.Default.MainMenuSelectionInfo, new RecordItemIndex(2));
            repo.Default.MainMenuSelection.Click("95;148");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Default.SecondaryMenuSelection' at 262;141.", repo.Default.SecondaryMenuSelectionInfo, new RecordItemIndex(3));
            repo.Default.SecondaryMenuSelection.Click("262;141");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OpenJob.VersionControlTest' at 120;25.", repo.OpenJob.VersionControlTestInfo, new RecordItemIndex(4));
            repo.OpenJob.VersionControlTest.Click("120;25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'OpenJob.AcceptChanges' at 32;30.", repo.OpenJob.AcceptChangesInfo, new RecordItemIndex(5));
            repo.OpenJob.AcceptChanges.Click("32;30");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(6));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
