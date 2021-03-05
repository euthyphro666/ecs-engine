namespace Aphelion.Game.States
{
    public interface IStateMachine
    {
        void ProgressState();
        void RegressState();
    }
}
