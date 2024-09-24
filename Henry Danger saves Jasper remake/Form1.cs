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
        ButonPictura Flashlight, Superglue, Witch, Guitar, Watergun;
        ButonPictura RightArrow, LeftArrow, X, Green;
        ButonPictura BackToGame, Lose1, Slenderman, Paper, Mess, CloseMessage, Entrance;
        ButonPictura RightArrow2, Box, Termite, Six, JeffTheKiller, LightSwitch, Lose2, Lose3;
        int no_clicks_park_map = 0, combined_glue_with_watergun = 0, x_was_glued = 0, subway_defeated = 0, pressed_light_switch = 0;
        int message_read = 0;
        int slendy = 0;
        int entrance = 0;

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
            Subway = new ButonPictura("Subway.png", 0, 0, 800, 480, this, SubwayClick);
            Hideout = new ButonPictura("Hideout.png", 0, 0, 800, 480, this);
            ParkMap = new ButonPictura("ParkMap.png", 0, 0, 400, 240, this, ParkMapClick);
            SubwayMap = new ButonPictura("SubwayMap.png", 400, 0, 400, 240, this, SubwayMapClick);
            HideoutMap = new ButonPictura("HideoutMap.png", 0, 240, 800, 240, this, HideoutMapClick);
            Map = new ButonPictura("Map.png", 745, 0, 40, 40, this, MapClick);
            Inventory = new ButonPictura("Inventory.png", 0, 0, 220, 150, this);
            Slot1 = new ButonPictura("Slot.png", 10, 10, 60, 60, this);
            Slot2 = new ButonPictura("Slot.png", 10, 80, 60, 60, this);
            Slot3 = new ButonPictura("Slot.png", 80, 10, 60, 60, this);
            Slot4 = new ButonPictura("Slot.png", 80, 80, 60, 60, this);
            Slot5 = new ButonPictura("Slot.png", 150, 10, 60, 60, this);
            Slot6 = new ButonPictura("Slot.png", 150, 80, 60, 60, this);
            Flashlight = new ButonPictura("Slot.png", 10, 10, 60, 60, this);
            Superglue = new ButonPictura("Slot.png", 10, 80, 60, 60, this);
            Witch = new ButonPictura("Slot.png", 80, 10, 60, 60, this);
            Watergun = new ButonPictura("Slot.png", 80, 80, 60, 60, this);
            Guitar = new ButonPictura("Slot.png", 150, 10, 60, 60, this);
            RightArrow = new ButonPictura("RightArrow.png", 730, 380, 50, 50, this, RightArrowClick);
            Green = new ButonPictura("Green.png", 0, 0, 74, 74, this);
            Lose1 = new ButonPictura("Lose1.png", 0, 0, 800, 480, this);
            BackToGame = new ButonPictura("BackToGame.png", 300, 350, 200, 100, this, BackToGameClick);
            ButonPictura.variableFreeze(Flashlight, Superglue, Guitar, Watergun, Witch);
            X = new ButonPictura("X.png", 530, 380, 40, 40, this, XClick);
            ButonPictura.variableDisappear(Flashlight, Superglue, Witch, Watergun, Guitar, Green, Lose1, BackToGame);
            ButonPictura.variableDisappear(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Map, RightArrow, X);
            LeftArrow = new ButonPictura("LeftArrow.png", 30, 380, 50, 50, this, LeftArrowClick);
            LeftArrow.disappear();
            Slenderman = new ButonPictura("Slenderman.png", 540, 207, 100, 240, this, SlendermanClick);
            Slenderman.disappear();
            Tex.Visible = false;
            Tex.BorderStyle = BorderStyle.None;
            NameOfObject.Visible = false;
            Paper = new ButonPictura("Paper.png", 400, 400, 60, 30, this, PaperClick);
            Paper.disappear();
            Mess = new ButonPictura("Message.png", 0, 0, 800, 480, this);
            CloseMessage = new ButonPictura("CloseMessage.png", 700, 400, 50, 50, this, CloseMessageClick);
            Entrance = new ButonPictura("Entrance.png", 350, 150, 50, 50, this, EntranceClick);
            RightArrow2 = new ButonPictura("RightArrow2.png", 10000, 10000, 50, 50, this, RightArrow2Click);
            Box = new ButonPictura("Box.png", 10000, 10000, 50, 50, this, BoxClick);
            Six = new ButonPictura("6.png", 10000, 10000, 60, 60, this, SixClick);
            Termite = new ButonPictura("Termite.png", 10000, 10000, 60, 60, this, TermiteClick);
            JeffTheKiller = new ButonPictura("JeffTheKiller.png", 470, 165, 100, 270, this, JeffTheKillerClick);
            LightSwitch = new ButonPictura("LightSwitch.png", 120, 200, 20, 20, this, LightSwitchClick);
            Lose2 = new ButonPictura("Lose2.png", 0, 0, 800, 480, this);
            Lose3 = new ButonPictura("Lose3.png", 0, 0, 800, 480, this);
            ButonPictura.variableDisappear(Mess, CloseMessage, Entrance, RightArrow2, JeffTheKiller, LightSwitch, Lose2, Lose3);
        }

        private async void ParkMapClick(object sender, EventArgs e)
        {
            no_clicks_park_map++;
            if (no_clicks_park_map == 1)
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
                Flashlight.setImage("Flashlight.jpg");
                Superglue.setImage("Superglue.jpg");
                Witch.setImage("Witch.png");
                Watergun.setImage("Watergun.jpg");
                Guitar.setImage("Guitar.jpg");
                ButonPictura.variableReactivate(Flashlight, Superglue, Witch, Watergun, Guitar);
                ButonPictura.variableAppear(true, Flashlight, Superglue, Witch, Watergun, Guitar);
                Flashlight.setClick(FlashlightClick);
                Superglue.setClick(SuperglueClick);
                Witch.setClick(WitchClick);
                Watergun.setClick(WatergunClick);
                Guitar.setClick(GuitarClick);
                return;
            }
            ButonPictura.variableDisappear(SubwayMap, HideoutMap, ParkMap, Subway, Hideout);
            ButonPictura.variableAppear(true, Park, Map);
            ButonPictura.variableAppear(true, Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6);
            ButonPictura.variableAppear(true, Flashlight, Superglue, Witch, Watergun, Guitar, Termite, Six);
        }

        private void SubwayMapClick(object sender, EventArgs e)
        {
            ButonPictura.variableDisappear(SubwayMap, HideoutMap, ParkMap, Park, Hideout);
            ButonPictura.variableAppear(true, Subway, Map);
            ButonPictura.variableAppear(true, Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6);
            ButonPictura.variableAppear(true, Flashlight, Superglue, Witch, Watergun, Guitar, RightArrow, X,
                Termite, Six);
            if(slendy == 1)
            {
                Slenderman.appear(true);
                Paper.appear(true);
            }
        }

        private void HideoutMapClick(object sender, EventArgs e)
        {
            ButonPictura.variableDisappear(SubwayMap, HideoutMap, ParkMap, Park, Subway);
            ButonPictura.variableAppear(true, Hideout, Map);
            ButonPictura.variableAppear(true, Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6);
            ButonPictura.variableAppear(true, Flashlight, Superglue, Witch, Watergun, Guitar, Box,
                Termite, Six, RightArrow2);
            if(entrance == 1)
            {
                Entrance.appear(true);
            }
        }

        private void MapClick(object sender, EventArgs e)
        {
            if (!Map.isFrozen())
            {
                NameOfObject.Visible = false;
                ButonPictura.variableDisappear(Park, Subway, Hideout, Map, Box);
                ButonPictura.variableAppear(true, SubwayMap, HideoutMap, ParkMap);
                ButonPictura.variableDisappear(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Green);
                ButonPictura.variableDisappear(Flashlight, Superglue, Witch, Watergun, Guitar, RightArrow, 
                X, Slenderman, Paper, Entrance, Termite, Six, RightArrow2);
            }
        }

        public void Slot1Click(object sender, EventArgs e)
        {

        }

        public void Slot2Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        public async void RightArrowClick(object sender, EventArgs e)
        {
            if (RightArrow.isFrozen())
            {
                return;
            }
            if (subway_defeated == 0)
            {
                ButonPictura.variableFreeze(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Map, RightArrow);
                ButonPictura.variableFreeze(Flashlight, Superglue, Guitar, Watergun, Witch);
                NameOfObject.Visible = false;
                Green.disappear();
                Subway.setImage("Subway1.png");
                await Task.Delay(500);
                Subway.setImage("Subway2.png");
                speak("Now you'll see, Kid Danger... or should I say, Henry Hart?", 500, 200, 100, 50);
                await Task.Delay(3000);
                Tex.Visible = false;
                Lose1.appear(true);
                BackToGame.appear(true);
                return;
            }
            RightArrow.dispose();
            Subway.setImage("Subway8.png");
            Slenderman.appear(true);
            Paper.appear(true);
            slendy = 1;
        }

        public async void LeftArrowClick(object sender, EventArgs e)
        {

        }

        public void SubwayClick(object sender, EventArgs e)
        {
            
        }

        public void XClick(object sender, EventArgs e)
        {
            if (x_was_glued == 1)
            {
                return;
            }
            if (Green.getP().Location.X + 7 == Watergun.getP().Location.X && Green.getP().Visible == true
                && Green.getP().Location.Y + 7 == Watergun.getP().Location.Y)
            {
                if (combined_glue_with_watergun == 1)
                {
                    X.setImage("X Glued.png");
                    Green.disappear();
                    NameOfObject.Visible = false;
                    x_was_glued = 1;
                }
            }
        }

        public void FlashlightClick(object sender, EventArgs e)
        {
            if (Flashlight.isFrozen())
            {
                return;
            }
            if (Green.getP().Location.X + 7 == Flashlight.getP().Location.X && Green.getP().Visible == true
                && Green.getP().Location.Y + 7 == Flashlight.getP().Location.Y)
            {
                NameOfObject.Visible = false;
                Green.disappear();
                return;
            }
            Green.setCoordinates(Flashlight.getP().Location.X - 7, Flashlight.getP().Location.Y - 7);
            NameOfObject.Text = "Flashlight";
            NameOfObject.Visible = true;
            NameOfObject.BringToFront();
            ButonPictura.variableAppear(true, Green, Flashlight);
        }

        public void WatergunClick(object sender, EventArgs e)
        {
            if (Watergun.isFrozen())
            {
                return;
            }
            if (Green.getP().Location.X + 7 == Watergun.getP().Location.X && Green.getP().Visible == true
                && Green.getP().Location.Y + 7 == Watergun.getP().Location.Y)
            {
                NameOfObject.Visible = false;
                Green.disappear();
                return;
            }
            if (Green.getP().Location.X + 7 == Superglue.getP().Location.X && Green.getP().Visible == true
                && Green.getP().Location.Y + 7 == Superglue.getP().Location.Y)
            {
                combined_glue_with_watergun = 1;
                Watergun.setCoordinates(Superglue.getCoordinates().X, Superglue.getCoordinates().Y);
                Superglue.dispose();
                Green.disappear();
                NameOfObject.Visible = false;
                return;
            }
            if (combined_glue_with_watergun == 0)
                NameOfObject.Text = "Watergun";
            else NameOfObject.Text = "Glue gun";
            NameOfObject.Visible = true;
            NameOfObject.BringToFront();
            Green.setCoordinates(Watergun.getP().Location.X - 7, Watergun.getP().Location.Y - 7);
            ButonPictura.variableAppear(true, Green, Watergun);
        }

        public void SuperglueClick(object sender, EventArgs e)
        {
            if (Superglue.isFrozen())
            {
                return;
            }
            if (Green.getP().Location.X + 7 == Superglue.getP().Location.X && Green.getP().Visible == true
                && Green.getP().Location.Y + 7 == Superglue.getP().Location.Y)
            {
                NameOfObject.Visible = false;
                Green.disappear();
                return;
            }
            NameOfObject.Text = "Superglue";
            NameOfObject.Visible = true;
            NameOfObject.BringToFront();
            Green.setCoordinates(Superglue.getP().Location.X - 7, Superglue.getP().Location.Y - 7);
            ButonPictura.variableAppear(true, Green, Superglue);
        }

        public async void GuitarClick(object sender, EventArgs e)
        {
            if (Guitar.isFrozen())
            {
                return;
            }
            if(message_read == 1 && Hideout.isVisible() && entrance == 0)
            {
                Green.disappear();
                Hideout.setImage("HenryPlayingGuitar.png");
                NameOfObject.Visible = false;
                ButonPictura.variableFreeze(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Map);
                ButonPictura.variableFreeze(Flashlight, Guitar, Watergun);
                speak("I guess I have to play the guitar...", 230, 200, 100, 80);
                await Task.Delay(3000);
                Tex.Visible = false;
                ButonPictura.variableReactivate(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Map);
                ButonPictura.variableReactivate(Flashlight, Guitar, Watergun);
                entrance = 1;
                Entrance.appear(true);
                Hideout.setImage("Hideout.png");
                return;
            }
            if (Green.getP().Location.X + 7 == Guitar.getP().Location.X && Green.getP().Visible == true &&
                Green.getP().Location.Y + 7 == Guitar.getP().Location.Y)
            {
                NameOfObject.Visible = false;
                Green.disappear();
                return;
            }
            NameOfObject.Text = "Guitar";
            NameOfObject.Visible = true;
            NameOfObject.BringToFront();
            Green.setCoordinates(Guitar.getP().Location.X - 7, Guitar.getP().Location.Y - 7);
            ButonPictura.variableAppear(true, Green, Guitar);
        }

        public async void WitchClick(object sender, EventArgs e)
        {
            if (Witch.isFrozen())
            {
                return;
            }
            Green.disappear();
            if (Park.isVisible())
            {
                ButonPictura.variableFreeze(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Map);
                ButonPictura.variableFreeze(Flashlight, Superglue, Guitar, Watergun, Witch);
                NameOfObject.Text = "Witch costume";
                NameOfObject.Visible = true;
                NameOfObject.BringToFront();
                speak("It has no use here...", 510, 120, 150, 22);
                await Task.Delay(2000);
                NameOfObject.Visible = false;
                Tex.Visible = false;
                ButonPictura.variableReactivate(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Map);
                ButonPictura.variableReactivate(Flashlight, Superglue, Guitar, Watergun, Witch);
                return;
            }
            if (Hideout.isVisible())
            {
                ButonPictura.variableFreeze(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Map);
                ButonPictura.variableFreeze(Flashlight, Superglue, Guitar, Watergun, Witch);
                NameOfObject.Text = "Witch costume";
                NameOfObject.Visible = true;
                NameOfObject.BringToFront();
                speak("It has no use here...", 200, 270, 150, 22);
                await Task.Delay(2000);
                NameOfObject.Visible = false;
                Tex.Visible = false;
                ButonPictura.variableReactivate(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Map);
                ButonPictura.variableReactivate(Flashlight, Superglue, Guitar, Watergun, Witch);
                return;
            }
            if (Subway.isVisible())
            {
                if (x_was_glued == 0)
                {
                    ButonPictura.variableFreeze(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Map, RightArrow);
                    ButonPictura.variableFreeze(Flashlight, Superglue, Guitar, Watergun, Witch);
                    speak("I could trick that guy, but it's useless without a strategy...", 230, 250, 150, 27);
                    NameOfObject.Text = "Witch costume";
                    NameOfObject.Visible = true;
                    NameOfObject.BringToFront();
                    await Task.Delay(2000);
                    Tex.Visible = false;
                    NameOfObject.Visible = false;
                    ButonPictura.variableReactivate(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Map, RightArrow);
                    ButonPictura.variableReactivate(Flashlight, Superglue, Guitar, Watergun, Witch);
                    return;
                }
                ButonPictura.variableFreeze(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Map, RightArrow);
                ButonPictura.variableFreeze(Flashlight, Superglue, Guitar, Watergun, Witch);
                Subway.setImage("Subway3.png");
                speak("Let the show begin...", 260, 240, 150, 27);
                await Task.Delay(2000);
                speak("Excuse me sir...", 260, 240, 150, 27);
                await Task.Delay(2000);
                Subway.setImage("Subway4.png");
                speak("Trick or treat?", 260, 240, 150, 27);
                await Task.Delay(2000);
                speak("It's not Halloween! Are you crazy?", 500, 200, 100, 50);
                await Task.Delay(4000);
                speak("Trick or treat?", 260, 240, 150, 27);
                await Task.Delay(2000);
                speak("Wow. You know what, why don't you take a candy and leave me alone? Let me just look " +
                    "for it...", 500, 200, 100, 80);
                await Task.Delay(8000);
                speak("I have to put the gun down though...", 500, 200, 100, 40);
                await Task.Delay(4000);
                Subway.setImage("Subway5.png");
                X.setImage("GunLeftOnX.png");
                speak("Wait a minute, did I just leave my gun on superglue?!", 500, 200, 100, 40);
                await Task.Delay(6000);
                speak("Yes, and now I will call the police...", 260, 240, 150, 27);
                await Task.Delay(4000);
                Subway.setImage("Subway6.png");
                speak("Yeah, run away, after you were sooo brave with that gun...", 260, 240, 150, 27);
                await Task.Delay(6000);
                Tex.Visible = false;
                Subway.setImage("Subway7.png");
                X.dispose();
                ButonPictura.variableReactivate(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Map, RightArrow);
                ButonPictura.variableReactivate(Flashlight, Superglue, Guitar, Watergun, Witch);
                subway_defeated = 1;
                Guitar.setCoordinates(Witch.getCoordinates().X, Witch.getCoordinates().Y);
                Witch.dispose();
                return;
            }
        }
        
        private void BackToGameClick(object sender, EventArgs e)
        {
            if (Lose1.isVisible())
            {
                Lose1.disappear();
                ButonPictura.variableReactivate(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Map, RightArrow);
                ButonPictura.variableReactivate(Flashlight, Superglue, Guitar, Watergun, Witch);
                BackToGame.disappear();
                Subway.setImage("Subway.png");
                return;
            }

            if (Lose2.isVisible())
            {
                Lose2.disappear();
                ButonPictura.variableReactivate(Map);
                BackToGame.disappear();
                ButonPictura.variableDisappear(JeffTheKiller, LightSwitch);
                Tex.Visible = false;
                ButonPictura.variableAppear(true, RightArrow2);
                Green.disappear();
                NameOfObject.Visible = false;
                return;
            }

            if (Lose3.isVisible())
            {
                Lose2.disappear();
                ButonPictura.variableReactivate(Map);
                BackToGame.disappear();
                ButonPictura.variableDisappear(JeffTheKiller, LightSwitch);
                Tex.Visible = false;
                ButonPictura.variableAppear(true, RightArrow2);
                pressed_light_switch = 1;
                Hideout.setImage("Room.png");
                JeffTheKiller.setImage("JeffTheKiller.png");
                Lose2.setCoordinates(0, 0);
                LightSwitch.setCoordinates(120, 200);
                ButonPictura.variableDisappear(Lose3, BackToGame);
                return;
            }
        }

        private async void SlendermanClick(object sender, EventArgs e)
        {
            Green.disappear();
            ButonPictura.variableFreeze(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Map);
            ButonPictura.variableFreeze(Flashlight, Guitar, Watergun, Paper, Slenderman, Six, Termite);
            speak("Talking to Slenderman without a very, very, very good reason is a bad idea...", 230, 200, 100, 80);
            NameOfObject.Visible = false;
            await Task.Delay(3000);
            Tex.Visible = false;
            ButonPictura.variableReactivate(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Map);
            ButonPictura.variableReactivate(Flashlight, Guitar, Watergun, Paper, Slenderman, Six, Termite);
            return;
        }

        private void PaperClick(object sender, EventArgs e)
        {
            if(Paper.isFrozen())
            {
                return;
            }
            Green.disappear();
            NameOfObject.Visible = false;
            ButonPictura.variableAppear(true, Mess, CloseMessage);
            message_read = 1;
            return;
        }

        private void CloseMessageClick(object sender, EventArgs e)
        {
            if (CloseMessage.isFrozen())
            {
                return;
            }
            ButonPictura.variableDisappear(Mess, CloseMessage);
            return;
        }

        private void EntranceClick(object sender, EventArgs e)
        {
            Entrance.dispose();
            Hideout.setImage("Room.png");
            Box.setCoordinates(375, 375);
            return;
        }

        private void BoxClick(object sender, EventArgs e)
        {
            Box.dispose();
            RightArrow2.setCoordinates(675, 370);
            Termite.setCoordinates(80, 80);
            Six.setCoordinates(150, 10);
        }

        private void SixClick(object sender, EventArgs e)
        {
            if (Six.isFrozen())
            {
                return;
            }
            if (Green.getP().Location.X + 7 == Six.getP().Location.X && Green.getP().Visible == true
                && Green.getP().Location.Y + 7 == Six.getP().Location.Y)
            {
                NameOfObject.Visible = false;
                Green.disappear();
                return;
            }
            Green.setCoordinates(Six.getP().Location.X - 7, Six.getP().Location.Y - 7);
            NameOfObject.Text = "A 6 made of metal";
            NameOfObject.Visible = true;
            NameOfObject.BringToFront();
            ButonPictura.variableAppear(true, Green, Six);
        }

        private void TermiteClick(object sender, EventArgs e)
        {
            if (Termite.isFrozen())
            {
                return;
            }
            if (Green.getP().Location.X + 7 == Termite.getP().Location.X && Green.getP().Visible == true
                && Green.getP().Location.Y + 7 == Termite.getP().Location.Y)
            {
                NameOfObject.Visible = false;
                Green.disappear();
                return;
            }
            Green.setCoordinates(Termite.getP().Location.X - 7, Termite.getP().Location.Y - 7);
            NameOfObject.Text = "Termite";
            NameOfObject.Visible = true;
            NameOfObject.BringToFront();
            ButonPictura.variableAppear(true, Green, Termite);
        }

        private async void RightArrow2Click(object sender, EventArgs e)
        {
            Green.disappear();
            NameOfObject.Visible = false;
            ButonPictura.variableDisappear(RightArrow2);
            ButonPictura.variableAppear(true, JeffTheKiller, LightSwitch);
            ButonPictura.variableFreeze(Map);
            speak("Time to sleep, Henry Hart...", 365, 160, 100, 30);
            await Task.Delay(3000);
            ButonPictura.variableAppear(true, Lose2, BackToGame);
            if(pressed_light_switch == 0)
            {
                Green.disappear();
                NameOfObject.Visible = false;
            }
            
        }

        private async void LightSwitchClick(object sender, EventArgs e)
        {
            pressed_light_switch = 1;
            Green.disappear();
            NameOfObject.Visible = false;
            speak("You think you're smart huh? I can still see you you know...", 365, 160, 100, 60);
            Lose2.setCoordinates(10000, 10000);
            LightSwitch.setCoordinates(10000, 10000);
            BackToGame.setCoordinates(10000, 10000);
            Hideout.setImage("RoomDark.png");
            JeffTheKiller.setImage("JeffDark.png");
            await Task.Delay(3000);
            ButonPictura.variableAppear(true, Lose3, BackToGame);
            BackToGame.setCoordinates(300, 350);
            Lose2.disappear();
            Green.disappear();
            NameOfObject.Visible = false;
        }

        private void JeffTheKillerClick(object sender, EventArgs e)
        {

        }
    }
}
