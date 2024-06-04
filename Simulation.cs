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

    // Constructor for Simulation class
    public Simulation()
    {
      this.graphics = new GraphicsDeviceManager(this);
      this.graphics.SynchronizeWithVerticalRetrace = true;

      this.Content.RootDirectory = "Content";
      this.IsMouseVisible = true;
      this.IsFixedTimeStep = true;

      const double UpdatesPerSecond = 60d;
      this.TargetElapsedTime = TimeSpan.FromTicks((long)Math.Round((double)TimeSpan.TicksPerSecond / UpdatesPerSecond));
    }
  }
}
