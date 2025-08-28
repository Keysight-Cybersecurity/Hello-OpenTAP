using OpenTap;

namespace MyOpenTAPProject3
{
    [Display("MyTestStep", Description: "Insert a description here", Group: "MyOpenTAPProject3")]

    public class MyTestStep : TestStep
    {
        #region Settings
        // ToDo: Add property here for each parameter the end user should be able to change
        #endregion
        public MyTestStep()
        {
            // ToDo: Set default values for properties / settings.
        }

        public override void PrePlanRun()
        {
            base.PrePlanRun();
            // ToDo: Optionally add any setup code this step needs to run before the testplan starts
        }
        public override void Run()
        {
            Log.Info("Hello, OpenTAP world!");

            // Example parameter usage:
            Log.Info($"This step is running in project: {nameof(MyOpenTAPProject3)}");

            UpgradeVerdict(Verdict.Pass);
        }


        public override void PostPlanRun()
        {
            // ToDo: Optionally add any cleanup code this step needs to run after the entire testplan has finished
            base.PostPlanRun();
        }
    }
}
