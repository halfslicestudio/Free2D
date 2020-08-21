# Free2D
Free2D is a Donationware open source game engine being developed by "Expressed Unity(Laurence)"

Feel free to make games with it for personal or commercial use.(no need to donate)

###### Documentation
## Placing Objects
```
new Object2D(Texture2D Texture, int RoomID);
new Object2D(Texture2D Texture,Vector2 Position, Vector2 Rotation, Vector2 Scale, int RoomID);

Object2D player = new Object2D(new Texture2D("Sprites/test.png"), 1);
```

## Textures
Using textures is very simple and all you need to pass into them is a director to the image location
```
new Texture2D("Sprites/test.png")
```
