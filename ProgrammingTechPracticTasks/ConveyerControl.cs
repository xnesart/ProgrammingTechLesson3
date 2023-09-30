using System;

namespace ProgrammingTechPracticTasks
{
    public struct ConveyerControl
    {
        public enum Action
        {
            Start,
            Stop,
            Back,
            Forward
        }

        public Action action;

        public ConveyerControl(Action nowAction) : this()
        {
            action = nowAction;
        }

        public void Conveyer(Action action)
        {
            switch (action)
            {
                case Action.Start:
                    Console.WriteLine("Conveyer started");
                    this.action = Action.Start;
                    break;
                case Action.Stop:
                    Console.WriteLine("Conveyer stopped");
                    this.action = Action.Stop;
                    break;
                case Action.Back:
                    Console.WriteLine("Conveyer get back");
                    this.action = Action.Back;
                    break;
                case Action.Forward:
                    Console.WriteLine("Conveyer get forward");
                    this.action = Action.Forward;
                    break;
                default:
                    Console.WriteLine("conveyer stoped");
                    this.action = Action.Stop;
                    break;
            }
        }
    }
}