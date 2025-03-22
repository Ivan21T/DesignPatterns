using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class BrakeSystem
    {
        private string leftBrakeState;
        private string rightBrakeState;

        public void SetState(string leftState, string rightState)
        {
            leftBrakeState = leftState;
            rightBrakeState = rightState;
        }
        public BrakeSystemMemento SaveStateToMemento()
        {
            return new BrakeSystemMemento(leftBrakeState, rightBrakeState);
        }
        public void RestoreStateFromMemento(BrakeSystemMemento memento)
        {
            leftBrakeState = memento.LeftBrake;
            rightBrakeState = memento.RightBrake;
        }
        public void PrintState()
        {
            Console.WriteLine($"Left Brake: {leftBrakeState}, Right Brake: {rightBrakeState}");
        }
    }
}
