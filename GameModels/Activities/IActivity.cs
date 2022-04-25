using CircularListExample.GameModels.PlayerData;

namespace CircularListExample.GameModels.Activities
{
    internal interface IActivity
    {
        public void Print();
        public void DoActivity(Player player);
        public void CompletedTaskMessage(ActivityOutcome? outcome);
    }
}
