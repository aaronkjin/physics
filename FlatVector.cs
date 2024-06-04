/* 
 * Lightweight, high-performing vector class.
 *
 * Building block of physics engine,
 * Representing all objects on a 2-dimensional grid.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatPhysics
{
  public readonly struct FlatVector
  {
    public readonly float X;
    public readonly float Y;

    // Constructor for vector struct
    public FlatVector (float x, float y)
    {
      this.X = x;
      this.Y = y;
    }
  }
}