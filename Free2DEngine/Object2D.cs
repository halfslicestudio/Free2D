using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
public class Object2D
{
    public Texture2D Texture { get; set; }
    public Vector2 Rotation { get; set; }
    public Vector2 Scale { get; set; }
    public Vector2 Collider = Vector2.One();
    public Vector2 Position { get; set; }
    public int RoomID { get; set; }

    public Object2D(Texture2D Texture, int RoomID)
    {
        this.Texture = ContentPipe.LoadTexture(Texture);
        this.Position = Vector2.Zero();
        this.Rotation = Vector2.One();
        this.Scale = Vector2.One();
        this.RoomID = RoomID;
        Free2DEngine.AddNewObject(this);
    }
    public Object2D(Texture2D Texture,Vector2 Position, Vector2 Rotation, Vector2 Scale, int RoomID)
    {
        this.Texture = ContentPipe.LoadTexture(Texture);

        this.Position = Position;
        this.Rotation = Rotation;
        this.Scale = Scale;
        this.RoomID = RoomID;
        Free2DEngine.AddNewObject(this);
    }

    public void DrawMe()
    {
        
        GL.Rotate(Rotation.X, Rotation.Y, 0d, 1d);
        GL.Scale(Scale.X, Scale.Y, 1);
        GL.Translate((double)Position.X, (double)Position.Y, 0);

        GL.BindTexture(TextureTarget.Texture2D, Texture.ID);

        GL.Begin(PrimitiveType.Quads);

        GL.TexCoord2(0f, 1f);
        GL.Vertex2(0f, 0f);

        GL.TexCoord2(1f, 1f);
        GL.Vertex2(.1f, 0f);

        GL.TexCoord2(1f, 0f);
        GL.Vertex2(.1f, .1f);

        GL.TexCoord2(0f, 0f);
        GL.Vertex2(0f, .1f);

        GL.End();
       
    }
    public static Object2D Destroy(Object2D obj)
    {
        Free2DEngine.RemoveObject(obj);
        obj = null;
        return obj;
    }
    public static bool Intersects(Object2D a, Object2D b, bool UseCustomColliders)
    {
        if (a == null || b == null)
            return false;
        if (!UseCustomColliders)
        {
            if (a.Position.X < b.Position.X + (b.Scale.X / 100) &&
                 a.Position.X + (a.Scale.X / 100) > b.Position.X &&
                 a.Position.Y < b.Position.Y + (b.Scale.Y / 100) &&
                 a.Position.Y + (a.Scale.Y / 100) > b.Position.Y)
            {
                return true;
            }
        }
        else
        {
            if (a.Position.X < b.Position.X + b.Collider.X &&
                 a.Position.X + a.Collider.X > b.Position.X &&
                 a.Position.Y < b.Position.Y + b.Collider.Y &&
                 a.Position.Y + a.Collider.Y > b.Position.Y)
            {
                return true;
            }
        }
        return false;
    }
}
