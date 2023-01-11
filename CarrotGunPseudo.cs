Game Flow and Mechanics
=========================
Complete - A gun object will be oscillating back and forth, aiming towards some target objects on the right side of the screen
1-2h - The targets are wiggling
Complete - The user's face shall appear behind in the back
Complete - The user fires the gun by opening their mouth
  Complete - Only one projectile at a time
  10m - During a shot the gun must stop oscillating
  30m - If the projectile doesn't hit anything it just keeps going until it goes out of the screen
    30m - Once the projectile is offscreen the gun is able to move again
2h - Once a target is hit:
  - Topic text will appear
  - Animate: Shake, glow, shine, explode, disappear
  - Text will also disappear with target
  - Remember which topics were hit
- Continue on until time runs out or all targets are hit
- Once the time runs out, the results will be displayed as a list of text images:
  - For every topic hit it will show you a randomized topic message
  - For every topic not hit there will be a prefixed text image saying "You have missed:" followed by a randomized topic message
  - There will be an button to restart after 10 seconds or so


Oscillating cannon
==================
• Linear
  Rotate Z
• Sinoidal
  Rotate using sin
• Tweening
  Use "Transit in Time" nodes

Functionality required
==================
Shoot
1. Position and rotate object at desired muzzle point
2. For every frame move forward by a specified amount in the facing direction
  Velocity
  bullet.pos.x = bullet.pos.x + cos(bullet.rotation) * speed * Time.deltaTime;
  bullet.pos.y = bullet.pos.y + sin(bullet.rotation) * speed * Time.deltaTime;

  bullet.movement = cos/sin(bullet.rotation) * speed * Time.deltaTime;


  position = curPosition;
  velocity = newVelocity;

  newVelocity = velocity + gravity * Time.deltaTime;
  newPosition = position + velocity * Time.deltaTime;