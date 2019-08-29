using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System.Drawing.Imaging;
public abstract class Free2DEngine
{
    public const int TARGET_FPS = 60;
    public const float TIME_UNTIL_UPDATE = 1F / TARGET_FPS;
    public ColorRGBA ClearColor = new ColorRGBA(1f, .3f, .2f, 1f);
    public GameTime GAMETIME { get; protected set; }
    public int RoomID { get; set; }
    int SCREEN_WIDTH;
    int SCREEN_HEIGHT;
    string SCREEN_TITLE;
    GameWindow WINDOW;

    static List<Object2D> Objects = new List<Object2D>();
    public Free2DEngine(int width, int height, string title, int RoomID)
    {
        Log.Info(String.Format("Starting new Free2DEngine Instance: W[{0}], H[{1}], N[{2}]", width, height, title));
        this.SCREEN_WIDTH = width;
        this.SCREEN_HEIGHT = height;
        this.SCREEN_TITLE = title;
        WINDOW = new GameWindow(SCREEN_WIDTH, SCREEN_HEIGHT);
        WINDOW.Load += WINDOW_Load;
        WINDOW.RenderFrame += RenderFrame;
        WINDOW.Resize += WINDOW_Resize;
        WINDOW.Title = SCREEN_TITLE;
        WINDOW.KeyDown += WINDOW_KeyDown;
        WINDOW.KeyUp += WINDOW_KeyUp;
        this.RoomID = RoomID;
        WINDOW.Run(1f / 60f);
       
    }

    private void WINDOW_KeyUp(object sender, KeyboardKeyEventArgs e)
    {
        OnKeyUp(e.Key.ToString());
    }

    private void WINDOW_KeyDown(object sender, KeyboardKeyEventArgs e)
    {
        OnKeyDown(e.Key.ToString());
    }

    public static void AddNewObject(Object2D obj)
    {
        Objects.Add(obj);
    }
    public static void RemoveObject(Object2D obj)
    {
        Objects.Remove(obj);
    }
    private void WINDOW_Resize(object sender, EventArgs e)
    {
        Log.Warning(String.Format("Viewport size change, Rebuilding matrix!"));
        GL.Viewport(0,0,WINDOW.Width,WINDOW.Height);
        GL.MatrixMode(MatrixMode.Projection);
        GL.LoadIdentity();
        GL.Ortho(0d, 10d, 0d, 10d,-2d,2d);
        GL.MatrixMode(MatrixMode.Modelview);
    }
    private void WINDOW_Load(object sender, EventArgs e)
    {
        LoadContent();
        Start();
        GL.ClearColor(ClearColor.R, ClearColor.G, ClearColor.B, ClearColor.A);
        GL.Enable(EnableCap.Texture2D);
        GL.Enable(EnableCap.Blend);
        GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
        // tex = ContentPipe.LoadTexture(new Texture2D("car.jpg"));
        //player = new Object2D(new Texture2D("car.jpg"), Vector2.Zero(), Vector2.Zero(), Vector2.One());
        //Object2D player2 = new Object2D(new Texture2D("zombie.png"), new Vector2(.5f,.5f), Vector2.Zero(), Vector2.One());
    }
    public void RenderFrame(object sender, EventArgs e)
    {
        GL.LoadIdentity();
        GL.Clear(ClearBufferMask.ColorBufferBit);
        Draw(GAMETIME, RoomID);

        foreach (Object2D obj in Objects)
        {
           
            GL.PushMatrix();
            if (obj.RoomID == RoomID)
            {
                obj.DrawMe();
                
            }
            GL.PopMatrix();
        }

        Update(GAMETIME, RoomID);
        //player.Rotation.X += 45f;
        WINDOW.SwapBuffers();
    }

    public abstract void LoadContent();
    public abstract void Start();
    public abstract void Update(GameTime gameTime,int RoomID);
    public abstract void Draw(GameTime gameTime,int RoomID);
    public abstract void OnKeyUp(string key);
    public abstract void OnKeyDown(string key);
}


