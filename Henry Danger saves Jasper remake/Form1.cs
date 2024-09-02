using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Henry_Danger_saves_Jasper_remake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 500;
        }

        ButonPictura Park;
        ButonPictura Subway;
        ButonPictura Hideout;
        ButonPictura ParkMap;
        ButonPictura SubwayMap;
        ButonPictura HideoutMap;
        ButonPictura Map;
        ButonPictura Inventory;
        ButonPictura Slot1, Slot2, Slot3, Slot4, Slot5, Slot6;
        int no_clicks_park_map = 0;

        public void speak(String text, int x, int y, int width, int height)
        {
            Tex.Location = new Point(x, y);
            Tex.Text = text;
            Tex.Height = height;
            Tex.Width = width;
            Tex.Visible = true;
            Tex.BringToFront();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Park = new ButonPictura("Park.png", 0, 0, 800, 480, this);
            Subway = new ButonPictura("Subway.png", 0, 0, 800, 480, this);
            Hideout = new ButonPictura("Hideout.png", 0, 0, 800, 480, this);
            ParkMap = new ButonPictura("ParkMap.png", 0, 0, 400, 240, this, ParkMapClick);
            SubwayMap = new ButonPictura("SubwayMap.png", 400, 0, 400, 240, this, SubwayMapClick);
            HideoutMap = new ButonPictura("HideoutMap.png", 0, 240, 800, 240, this, HideoutMapClick);
            Map = new ButonPictura("Map.png", 745, 0, 40, 40, this, MapClick);
            Inventory = new ButonPictura("Inventory.png", 0, 0, 220, 150, this);
            Slot1 = new ButonPictura("Slot.png", 10, 10, 60, 60, this, Slot1Click);
            Slot2 = new ButonPictura("Slot.png", 10, 80, 60, 60, this, Slot2Click);
            Slot3 = new ButonPictura("Slot.png", 80, 10, 60, 60, this, Slot3Click);
            Slot4 = new ButonPictura("Slot.png", 80, 80, 60, 60, this, Slot4Click);
            Slot5 = new ButonPictura("Slot.png", 150, 10, 60, 60, this, Slot5Click);
            Slot6 = new ButonPictura("Slot.png", 150, 80, 60, 60, this, Slot6Click);
            ButonPictura.variableDisappear(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Map);
            Tex.Visible = false;
            Tex.BorderStyle = BorderStyle.None;
        }

        private async void ParkMapClick(object sender, EventArgs e)
        {
            no_clicks_park_map++;
            if(no_clicks_park_map == 1)
            {
                ButonPictura.variableDisappear(SubwayMap, HideoutMap, ParkMap, Subway, Hideout);
                ButonPictura.variableAppear(true, Park, Map);
                ButonPictura.variableAppear(true, Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6);
                Map.freeze();
                ButonPictura.variableFreeze(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6);
                Park.setImage("ParkWithRay.png");
                speak("Hey Ray!", 560, 140, 50, 22);
                await Task.Delay(2000);
                speak("Hey Henry!", 520, 140, 50, 30);
                await Task.Delay(2000);
                speak("Jasper has been kidnapped by a criminal, I don't know " +
                    "who they are but I got a note about the kidnapping this morning...", 520, 40, 100, 100);
                await Task.Delay(8000);
                speak("As if I care about that idiot... I have objects that can help you, but that's all. " +
                    "I am going on vacation today...", 510, 40, 100, 100);
                await Task.Delay(8000);
                speak("Are you serious?!", 520, 120, 100, 22);
                await Task.Delay(2000);
                speak("See you soon Henry...", 500, 120, 120, 22);
                await Task.Delay(2000);
                Park.setImage("Park.png");
                speak("You gotta be kidding me...", 510, 120, 150, 22);
                await Task.Delay(2000);
                Tex.Visible = false;
                ButonPictura.variableReactivate(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Map);
                Slot1.setImage("Flashlight.jpg");
                Slot2.setImage("Superglue.jpg");
                Slot3.setImage("Witch.png");
                Slot4.setImage("Guitar.jpg");
                Slot5.setImage("Watergun.jpg");
                return;
            }
            ButonPictura.variableDisappear(SubwayMap, HideoutMap, ParkMap, Subway, Hideout);
            ButonPictura.variableAppear(true, Park, Map);
            ButonPictura.variableAppear(true, Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6);
        }

        private void SubwayMapClick(object sender, EventArgs e)
        {
            ButonPictura.variableDisappear(SubwayMap, HideoutMap, ParkMap, Park, Hideout);
            ButonPictura.variableAppear(true, Subway, Map);
            ButonPictura.variableAppear(true, Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6);
        }

        private void HideoutMapClick(object sender, EventArgs e)
        {
            ButonPictura.variableDisappear(SubwayMap, HideoutMap, ParkMap, Park, Subway);
            ButonPictura.variableAppear(true, Hideout, Map);
            ButonPictura.variableAppear(true, Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6);
        }

        private void MapClick(object sender, EventArgs e)
        {
            if (!Map.isFrozen())
            {
                ButonPictura.variableDisappear(Park, Subway, Hideout, Map);
                ButonPictura.variableAppear(true, SubwayMap, HideoutMap, ParkMap);
                ButonPictura.variableDisappear(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6);
            }
        }

        public void Slot1Click(object sender, EventArgs e)
        {

        }

        public void Slot2Click(object sender, EventArgs e)
        {

        }

        public void Slot3Click(object sender, EventArgs e)
        {

        }

        public void Slot4Click(object sender, EventArgs e)
        {

        }

        public void Slot5Click(object sender, EventArgs e)
        {

        }

        public void Slot6Click(object sender, EventArgs e)
        {

        }

    }
}
