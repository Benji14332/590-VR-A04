# Comp 590 - A04
The small game I built was just a ball shooting simulator, where you can use left/right controller to point at the ball and shoot it. You might want to look aronud for the ball, as it will randomly move around you after it is shot.

Noticed I spent an amount of time trying to figure out how to use the meta ray pointer, and apparently if you don't put at least an object in the scene that has ray-interaction, the ray from you controller won't show. So adding a collider surface was necessary in my case.