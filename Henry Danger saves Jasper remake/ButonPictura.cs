using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Henry_Danger_saves_Jasper_remake
{
    public class ButonPictura
    {
        private PictureBox p;
        private EventHandler handler;
        private bool frozen;

        public PictureBox getP()
        {
            return p;
        }

        public ButonPictura(String filename, int x, int y, int width, int height, Form1 f, Action<object, EventArgs> func)
        {
            if (!filename.Equals("-"))
                filename = "../../img/" + filename;
            p = new PictureBox();
            if (!filename.Equals("-"))
                p.Image = Image.FromFile(filename);
            p.Visible = true;
            p.Location = new Point(x, y);
            p.Height = height;
            p.Width = width;
            f.Controls.Add(p);
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            handler = (s, e) => func(s, e);
            p.Click += handler;
            p.BringToFront();
            frozen = false;
        }

        public ButonPictura(String filename, int x, int y, int width, int height, Form1 f)
        {
            if (!filename.Equals("-"))
                filename = "../../img/" + filename;
            p = new PictureBox();
            if (!filename.Equals("-"))
                p.Image = Image.FromFile(filename);
            p.Visible = true;
            p.Location = new Point(x, y);
            p.Height = height;
            p.Width = width;
            f.Controls.Add(p);
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            p.BringToFront();
            frozen = false;
        }

        public void front()
        {
            p.BringToFront();
        }

        public void disappear()
        {
            p.Visible = false;
        }

        public void appear(bool front)
        {
            p.Visible = true;
            if (front)
                p.BringToFront();
        }

        public void dispose()
        {
            p.Dispose();
            handler = null;
        }

        public void setClick(Action<object, EventArgs> func)
        {
            p.Click -= handler;
            handler = (s, e) => func(s, e);
            p.Click += handler;
        }

        public void setImage(string filename)
        {
            filename = "../../img/" + filename;
            p.Image = Image.FromFile(filename);
        }

        public void setCoordinates(int x, int y)
        {
            p.Location = new Point(x, y);
        }

        public Point getCoordinates()
        {
            return p.Location;
        }

        public void increaseWidth(int x)
        {
            p.Width += x;
        }

        public void increaseHeight(int x)
        {
            p.Height += x;
        }

        public void freeze()
        {
            frozen = true;
        }

        public void reactivate()
        {
            frozen = false;
        }

        public static void variableDisappear(params ButonPictura[] args)
        {
            foreach(ButonPictura arg in args)
            {
                arg.disappear();
            }
        }

        public static void variableAppear(bool front, params ButonPictura[] args)
        {
            foreach (ButonPictura arg in args)
            {
                arg.appear(front);
            }
        }

        public static void variableFreeze(params ButonPictura[] args)
        {
            foreach (ButonPictura arg in args)
            {
                arg.freeze();
            }
        }

        public static void variableReactivate(params ButonPictura[] args)
        {
            foreach (ButonPictura arg in args)
            {
                arg.reactivate();
            }
        }

        public static void variableDispose(params ButonPictura[] args)
        {
            foreach (ButonPictura arg in args)
            {
                arg.dispose();
            }
        }

        public static void variableMoveAway(params ButonPictura[] args)
        {
            foreach (ButonPictura arg in args)
            {
                arg.setCoordinates(10000, 10000);
            }
        }

        public bool isFrozen()
        {
            return frozen;
        }

        public bool isVisible()
        {
            return p.Visible;
        }
    }
}
