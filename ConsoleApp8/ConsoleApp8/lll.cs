using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class vectors
    {
        private double x_comp;
        private double y_comp;

        public double X_comp
        {
            get { return x_comp; }
            set { x_comp = value; }
        }
        public double Y_comp
        {
            get { return y_comp; }
            set { y_comp = value; }
        }


        public vectors()
        {
            x_comp = 1;
            y_comp = 1;
        }
        
        public vectors(double x, double y)
        {
            X_comp = x;
            Y_comp = y;
        }

        public static vectors Sum(vectors vectorOne, vectors vectorTwo)
        {
            return new vectors(vectorOne.X_comp + vectorTwo.X_comp, vectorOne.Y_comp + vectorTwo.Y_comp);
        } 

        public static vectors operator +(vectors vectorOne, vectors vectorTwo)
        {
            return new vectors(vectorOne.X_comp +vectorTwo.X_comp, vectorOne.Y_comp + vectorTwo.Y_comp);
        }

        public static vectors subtraction(vectors vectorOne,  vectors vectorTwo)
        {
            return new vectors(vectorOne.X_comp - vectorTwo.X_comp, vectorOne.Y_comp - vectorTwo.Y_comp);
        }

        public static vectors operator -(vectors vectorOne, vectors vectorTwo)
        {
            return new vectors(vectorOne.X_comp - vectorTwo.X_comp, vectorOne.Y_comp - vectorTwo.Y_comp);
        }

        public static vectors multiplication(vectors vectorOne, vectors vectorTwo)
        {
            return new vectors(vectorOne.X_comp * vectorTwo.X_comp, vectorOne.Y_comp * vectorTwo.Y_comp);
        }

        public static vectors operator *(vectors vectorOne, vectors vectorTwo)
        {
            return new vectors(vectorOne.X_comp * vectorTwo.X_comp, vectorOne.Y_comp * vectorTwo.Y_comp);
        }

        public static double length(vectors vector)
        {
            return Math.Sqrt(vector.X_comp * vector.X_comp + vector.Y_comp * vector.Y_comp);
        }

        public static bool isEqual(vectors vectorOne,vectors vectorTwo)
        {
            if (vectorOne.X_comp == vectorTwo.X_comp && vectorOne.Y_comp == vectorTwo.Y_comp)
            {
                return true;
            }
            else return false;
            
        }
        public static bool operator == (vectors vectorOne, vectors vectorTwo)
        {
            if (vectorOne.X_comp == vectorTwo.X_comp && vectorOne.Y_comp == vectorTwo.Y_comp)
            {
                return true;
            }
            else
                return false;
        }
        public static bool operator != (vectors vectorOne, vectors vectorTwo)
        {
            if (vectorOne.X_comp != vectorTwo.X_comp && vectorOne.Y_comp != vectorTwo.Y_comp)
            {
                return true;
            }
            else
                return false;
        }

        public static bool operator <(vectors vectorOne, vectors vectorTwo)
        {
            if(length(vectorOne)<length(vectorTwo))
            {
                return true;
            }
            else { return false; }
        }
        public static bool operator >(vectors vectorOne, vectors vectorTwo)
        {
            if (length(vectorOne) > length(vectorTwo))
            {
                return true;
            }
            else { return false; }
        }



        public override string ToString()
        {
            return $" vector x ={X_comp} y = {Y_comp}";
        }

    }
}
