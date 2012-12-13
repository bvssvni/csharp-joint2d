using System;
using Matrix2d;

namespace Joint2d
{
    /// <summary>
    /// A joint has a position and a rotation.
    /// It can be thought of as a wheel with 1 degree of rotational freedom.
    /// Can be transformed into momentum and velocity.
    /// </summary>
    public class Joint
    {
        public Point Pos;
        public double Angle;

        public Joint(Point pos, double angle)
        {
            this.Pos = pos;
            this.Angle = angle;
        }

        public static Joint Add(Joint a, Joint b)
        {
            return new Joint(a.Pos + b.Pos, a.Angle + b.Angle);
        }

        public static Joint Subtract(Joint a, Joint b)
        {
            return new Joint(a.Pos - b.Pos, a.Angle - b.Angle);
        }

        public static Joint Multiply(Joint a, double t)
        {
            return new Joint(a.Pos * t, a.Angle * t);
        }

        public static Joint operator + (Joint a, Joint b)
        {
            return Add(a, b);
        }

        public static Joint operator - (Joint a, Joint b)
        {
            return Subtract(a, b);
        }

        public static Joint operator * (Joint a, double t)
        {
            return Multiply(a, t);
        }

        /// <summary>
        /// Multiplies a child joint with a parent joint to create a new one.
        /// </summary>
        /// <param name='child'>
        /// The child joint to be transformed by parent.
        /// </param>
        /// <param name='parent'>
        /// Parent joint to transform child joint.
        /// </param>
        public static Joint Multiply(Joint child, Joint parent)
        {
            var transform = Matrix.Rotation(parent.Angle) * Matrix.Translation(parent.Pos.X, parent.Pos.Y);
            return new Joint(child.Pos.Transform(transform), parent.Angle + child.Angle);
        }

        public static Joint operator * (Joint a, Joint b)
        {
            return a * b;
        }
    }
}

