using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace PPE4_Stars_up
{
    public enum CaptureMode
    {
        Screen, Window
    }

    public class ScreenCapture
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);

        [StructLayout(LayoutKind.Sequential)]
        private struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetDesktopWindow();

        /// <summary> Capture Active Window, Desktop, Window or Control 
        /// by hWnd or .NET Contro/Form and save it to a specified file.  </summary>
        /// <param name="filename">Filename.
        /// <para>* If extension is omitted, it's calculated from the type of file</para>
        /// <para>* If path is omitted, defaults to %TEMP%</para>
        /// <para>* Use %NOW% to put a timestamp in the filename</para></param>
        /// <param name="mode">Optional. 
        /// The default value is CaptureMode.Window.</param>
        /// <param name="format">Optional file save mode.  
        /// Default is PNG</param>
        public void CaptureAndSave(string filename, CaptureMode mode, ImageFormat format)
        {
            mode = CaptureMode.Window;
            format = null;
            ImageSave(filename, format, Capture(mode));
        }

        /// <summary> Capture a specific window (or control) 
        /// and save it to a specified file.  </summary>
        /// <param name="filename">Filename.
        /// <para>* If extension is omitted, it's calculated from the type of file</para>
        /// <para>* If path is omitted, defaults to %TEMP%</para>
        /// <para>* Use %NOW% to put a timestamp in the filename</para></param>
        /// <param name="handle">hWnd (handle) of the window to capture</param>
        /// <param name="format">Optional file save mode.  Default is PNG</param>
        public void CaptureAndSave(string filename, IntPtr handle, ImageFormat format)
        {
            format = null;
            ImageSave(filename, format, Capture(handle));
        }

        /// <summary> Capture a specific window (or control) and 
        /// save it to a specified file.  </summary>
        /// <param name="filename">Filename.
        /// <para>* If extension is omitted, it's calculated from the type of file</para>
        /// <para>* If path is omitted, defaults to %TEMP%</para>
        /// <para>* Use %NOW% to put a timestamp in the filename</para></param>
        /// <param name="c">Object to capture</param>
        /// <param name="format">Optional file save mode.  Default is PNG</param>
        public void CaptureAndSave(string filename, Control c, ImageFormat format)
        {
            format = null;
            ImageSave(filename, format, Capture(c));
        }
        /// <summary> Capture the active window (default) or 
        /// the desktop and return it as a bitmap </summary>
        /// <param name="mode">Optional. 
        /// The default value is CaptureMode.Window.</param>
        public Bitmap Capture(CaptureMode mode)
        {
            mode = CaptureMode.Window;
            return Capture(mode == CaptureMode.Screen ?
                        GetDesktopWindow() : GetForegroundWindow());
        }

        /// <summary> Capture a .NET Control, Form, UserControl, etc. </summary>
        /// <param name="c">Object to capture</param>
        /// <returns> Bitmap of control's area </returns>
        public Bitmap Capture(Control c)
        {
            return Capture(c.Handle);
        }

        /// <summary> Capture a specific window and return it as a bitmap </summary>
        /// <param name="handle">hWnd (handle) of the window to capture</param>
        public Bitmap Capture(IntPtr handle)
        {
            Rectangle bounds;
            Rect rect = new Rect();
            GetWindowRect(handle, ref rect);
            bounds = new Rectangle(rect.Left, rect.Top,
                    rect.Right - rect.Left, rect.Bottom - rect.Top);
            CursorPosition = new Point(Cursor.Position.X - rect.Left,
                        Cursor.Position.Y - rect.Top);

            Bitmap result = new Bitmap(bounds.Width, bounds.Height);
            using (Graphics g = Graphics.FromImage(result))
                g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);

            return result;
        }

        /// <summary> Position of the cursor relative 
        /// to the start of the capture </summary>

        public Point CursorPosition;

        /// <summary> Save an image to a specific file </summary>
        /// <param name="filename">Filename.
        /// <para>* If extension is omitted, it's calculated from the type of file</para>
        /// <para>* If path is omitted, defaults to %TEMP%</para>
        /// <para>* Use %NOW% to put a timestamp in the filename</para></param>
        /// <param name="format">Optional file save mode.  Default is PNG</param>
        /// <param name="image">Image to save.  Usually a BitMap, but can be any
        /// Image.</param>
        void ImageSave(string filename, ImageFormat format, Image image)
        {
            format = format ?? ImageFormat.Png;
            if (!filename.Contains("."))
                filename = filename.Trim() + "." + format.ToString().ToLower();

            if (!filename.Contains(@"\"))
                filename = Path.Combine(Environment.GetEnvironmentVariable
                    ("TEMP") ?? @"C:\Temp", filename);

            filename = filename.Replace("%NOW%",
                        DateTime.Now.ToString("yyyy-MM-dd@hh.mm.ss"));
            image.Save(filename, format);
        }
    }
}
