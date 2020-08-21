# Free2D
Free2D is a Donationware open source game engine being developed by "Expressed Unity(Laurence)"

Feel free to make games with it for personal or commercial use.(no need to donate)

###### Documentation
## Placing Objects
Objects should only be created in the "Content Load" or "Start" methods. But should work in any other method
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

## Vector2
```
new Vector2(0,0);

Vector2.Zero();
Vector2.One();
Vector2.Two();

Vector2.Add(new Vector2(1,1), new Vector2(2,2));
Vector2.Subtract(new Vector2(1,1), new Vector2(2,2));
Vector2.Multiply(new Vector2(1,1), new Vector2(2,2));
Vector2.Devide(new Vector2(1,1), new Vector2(2,2));
```

## Logging
```
Log.Normal(string msg);
Log.Info(string msg);
Log.Warning(string msg);
Log.Error(string msg);
```

##Exposed Engine Variables
```
//ColorRGB -  Used to change the background colour
ClearColor = new ColorRGBA(1f,1f,1f,1f);
//int - Used to render different objects in other rooms
RoomID = 1
```
###### Functions / Methods
Engine functions are displayed as tabs, some tabs will have exposed values that can be used only in that tab.
```
LoadContent
Start
Update(GameTime deltaTime, int RoomID);
Draw(GameTime deltaTime, int RoomID);
OnKeyUp(string key)// key == "a"
OnKeyDown(string key)//key == "a"
```
