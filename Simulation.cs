/*
 * MonoGame to simulate games for the physics engine.
 *
 * Logic for key inputs, movements, camera, and more.
*/

using System;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Flat;
using Flat.Graphics;
using Flat.Input;

namespace FlatPhysics
{
  public class Simulation : Game
  {
    private GraphicsDeviceManager graphics;
    private Screen screen;
    private Sprites sprites;
    private Shapes shapes;
    private Camera camera;
  }
}
