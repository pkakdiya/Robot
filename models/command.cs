namespace ToyRobotSimulator
{
    public interface ICommand 
    {
        void Execute(Robot robot);
    }


    public class MoveForwordCommand : ICommand
    {
        public void Execute(Robot robot)
        {
            robot.MoveForword();
        }
    }

    public class TurnLeftCommand : ICommand
    {
        public void Execute(Robot robot)
        {
            robot.TurnLeft();
        }
    }


    public class TurnRightCommand : ICommand
    {
        public void Execute(Robot robot)
        {
            robot.TurnRight();
        }
    }
}