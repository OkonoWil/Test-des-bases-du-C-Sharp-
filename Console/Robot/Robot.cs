using System;

namespace Robot
{
    public class Robot
    {
        protected string _name;
        protected int _x;
        protected int _y;
        protected int _orientation;
        enum orient
        {
            Nord = 0,
            Est = 1,
            Sud = 2,
            Ouest = 3
        }
        public Robot(string name, int x, int y, int orientation)
        {
            this._name = name;
            this._x = x;
            this._y = y;
            this._orientation = orientation;
        }
        public Robot(string name)
        {
            this._name = name;
            this._x = 0;
            this._y = 0;
            this._orientation = 0;
        }
        public void avance()
        {
            switch (this._orientation)
            {
                case 0:
                    this._y++; // On avance d'un pas vers le Nord
                    break;
                case 1:
                    this._x++; // On avance d'un pas vers l'Est
                    break;
                case 2:
                    this._y--; // On avance d'un pas vers le Sud
                    break;
                case 3:
                    this._x--; //on avance d'un pas vers l'Ouest
                    break;
            }
        }
        public void tourner()
        {
            this._orientation = (this._orientation + 1) % 4;
        }

        public override string ToString() => $"Nom robot : {this._name} Position : ({this._x};{this._y}) Orientation : {this._orientation}";
    }

}
