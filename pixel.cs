using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace Sample {
    class Program {

		[DllImport("user32.dll")]
		static extern IntPtr GetDC(IntPtr hwnd);

		[DllImport("user32.dll")]
		static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

		[DllImport("gdi32.dll")]
		static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

		static public System.Drawing.Color GetPixelColor(int x, int y)
		{
			IntPtr hdc = GetDC(IntPtr.Zero);
			uint pixel = GetPixel(hdc, x, y);
			ReleaseDC(IntPtr.Zero, hdc);
			Color color = Color.FromArgb((int)(pixel & 0x000000FF),
				(int)(pixel & 0x0000FF00) >> 8,
				(int)(pixel & 0x00FF0000) >> 16);
			return color;

		}


		static void Main(string[] args) {
			int death = 108;
		P: 
			StreamWriter log = new StreamWriter("pixlog.txt", true);
		M:
			Random music = new Random();
			int number;
			number = music.Next(5);
			Color pix1 = GetPixelColor (949, 540);
			string dimon;
			dimon = pix1.ToString();
			if (dimon == "Color [A=255, R=90, G=11, B=11]")
			{
				Process.Start (number + ".mp3");
				log.WriteLine (dimon);
				death++;
				log.WriteLine (death);
				log.Close ();
				File.WriteAllText("death сount.txt", "Количество смертей: " + death);
				Thread.Sleep (8000);
				goto P;
			} 
			else {
				Thread.Sleep (300);
				goto M;
			}
		}

        }
    }
