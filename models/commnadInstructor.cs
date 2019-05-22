namespace ToyRobotSimulator 
{
    public class CommandInstructor 
    {
        private int _x = 0;

        private int _y = 0;

        private Direction _direction;

        public CommandInstructor(int x, int y, Direction direction) 
        {
            _x = x; 
            _y = y;
            _direction = direction;
        }

        public void RunRobot(Robot robot) 
        {
            if (robot.Board.IsValidPosition(_x, _y)) 
            {
                robot.CoorinateX = _x;
                robot.CoorinateY = _y;
                robot.Direction = _direction;
                robot.IsOnBoard = true;
            }
        }
    }
}