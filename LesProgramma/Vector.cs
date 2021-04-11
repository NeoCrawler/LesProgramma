using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesProgramma
{
    sealed class Vector3
    {
        // Properties.
        public static Vector3 Zero  { get { return new Vector3(0, 0, 0); } }
        public static Vector3 One   { get { return new Vector3(1, 1, 1); } }
        public static Vector3 Up    { get { return new Vector3(0, 1, 0); } }
        public static Vector3 Right { get { return new Vector3(1, 0, 0); } }

        // Variables
        public float x, y, z;

        // Operator overloading.
        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }

        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }

        public static Vector3 operator *(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        }

        public static Vector3 operator /(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        }

        // Constructors
        public Vector3()
        {
            x = y = z = 0;
        }

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Methods, for example Dot or Cross
    }
}
