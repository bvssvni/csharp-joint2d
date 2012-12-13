csharp-joint2d
==============

A simple representation of a joint for 2D physics.  
BSD license.  

For more information about license and update log, see "version.md".

##Introduction to joints

In many applications of 2D physics, the angular velocity is independent of the translating velocity.  
A Joint is an object that merges these two together and can represent solid bodies, wheel and similar.  

The angle of a joint does not repeat and start over after one turn.  
By keeping track of the angle, one can interpolate several turns of a wheel.  

A joint is not a complex object, but since it is used in so many applications it deserves it's own attention.  
It is difficult to mix code that might not be reusable with code that is very reusable.  
Therefore it is listed in its own repository.

##Practical use

The source code relies on "csharp-matrix2d".  

A joint is useful when building skeletons for 2D characters.  
With joint multiplication, one can easily describe the skeleton hierarchy with fewer changes.  

Examples of objects with joint behavior in 2D:  

- Body parts.
- Thrown weapons like knives, arrows.
- Flying helicopters.
- Airplanes and vehicles.
- Solid bodies in general.
- Wheels.
- Lazers and pointing devices.
- Bot vision direction.
- Light sources.
