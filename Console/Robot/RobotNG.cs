using System;

namespace Robot
{
    class RobotNG : Robot
    {

        public RobotNG(string name) : base(name) { }

        public RobotNG(string name, int x, int y, int orientation) : base(name, x, y, orientation) { }

        public void avance(int n)
        {
            for (int i = 0; i < n; i++)
                avance();
        }

        public void TournerGauche()
        {
            tourner();
            tourner();
            tourner();
        }

        public override string ToString() => $"New Robot -> nom robot : {this._name}  Position : ({this._x};{this._y}) Orientation : {this._orientation}";
    }
}