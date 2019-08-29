﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

public class ContentPipe
{
    public static Texture2D LoadTexture(Texture2D tex)
    {
        if (!File.Exists(tex.Dir))
        {
            throw new FileNotFoundException(tex.Dir + " | Could not be located!");
        }
        //open up space for our texture
        tex.ID = GL.GenTexture();
        GL.BindTexture(TextureTarget.Texture2D, tex.ID);

        Bitmap bmp = new Bitmap(tex.Dir);
        BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

        GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, data.Width, data.Height, 0,
            OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0);

        bmp.UnlockBits(data);

        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Clamp);
        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Clamp);

        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
        tex.Width = bmp.Width;
        tex.Height = bmp.Height;
        return tex;
    }
}

