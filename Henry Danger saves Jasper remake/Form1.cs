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

        ButonPictura Presentation;
        ButonPictura Park;
        ButonPictura Subway;
        ButonPictura Hideout;
        ButonPictura ParkMap;
        ButonPictura SubwayMap;
        ButonPictura HideoutMap;
        ButonPictura Map;
        ButonPictura Inventory;
        ButonPictura Slot1, Slot2, Slot3, Slot4, Slot5, Slot6;
        ButonPictura Flashlight, Superglue, Witch, Guitar, Watergun, Ladder, Anvil;
        ButonPictura RightArrow, LeftArrow, X, Green, RightArrow3;
        ButonPictura BackToGame, Lose1, Slenderman, Paper, Mess, CloseMessage, Entrance;
        ButonPictura RightArrow2, Box, Termite, Six, JeffTheKiller, LightSwitch, Lose2, Lose3, Lose4, JeffInventory, Lose5, SlendermanInventory;
        ButonPictura DoorButton, TimeJerker, But, Lose6, Lose7, Lose8, Box2, DoorButton2, Lose9, Transparent, DreamBeam, But2, RightArrow4, Lose10, Timer;
        ButonPictura Lose11, Lose12;
        int no_clicks_park_map = 0, combined_glue_with_watergun = 0, x_was_glued = 0, subway_defeated = 0, pressed_light_switch = 0;
        int jeff_blinded_with_flashlight = 0, jeff_attacked = 0;
        int message_read = 0;
        int slendy = 0;
        int drex_attacked = 0, allowed2 = 0, drex_defeated = 0;
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        int entrance = 0;
        int no_clicks_rightarrow3 = 0, turned = 0, six_thrown_wrong = 0, six_thrown_right = 0, time_jerker_defeated = 0, box2taken = 0;
        int minyak_state = 0, allowed = 0, no_clicks_right_arrow_4 = 0;

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
            RightArrow3 = new ButonPictura("RightArrow2.png", 10000, 10000, 50, 50, this, RightArrow3Click);
            RightArrow4 = new ButonPictura("RightArrow2.png", 10000, 10000, 50, 50, this, RightArrow4Click);
            Box = new ButonPictura("Box.png", 10000, 10000, 50, 50, this, BoxClick);
            Six = new ButonPictura("6.png", 10000, 10000, 60, 60, this, SixClick);
            Termite = new ButonPictura("Termite.png", 10000, 10000, 60, 60, this, TermiteClick);
            Ladder = new ButonPictura("Ladder.png", 10000, 10000, 60, 60, this, LadderClick);
            Anvil = new ButonPictura("Anvil.png", 10000, 10000, 60, 60, this, AnvilClick);
            Box2 = new ButonPictura("Box.png", 10000, 10000, 50, 50, this, Box2Click);
            DreamBeam = new ButonPictura("DreamBeam.png", 10000, 10000, 60, 60, this, DreamBeamClick);
            JeffTheKiller = new ButonPictura("JeffTheKiller.png", 470, 165, 100, 270, this, JeffTheKillerClick);
            JeffInventory = new ButonPictura("JeffInventory.png", 10000, 10000, 60, 60, this, JeffInventoryClick);
            SlendermanInventory = new ButonPictura("SlendermanInventory.png", 10000, 10000, 60, 60, this, SlendermanInventoryClick);
            LightSwitch = new ButonPictura("LightSwitch.png", 120, 200, 20, 20, this, LightSwitchClick);
            Lose2 = new ButonPictura("Lose2.png", 0, 0, 800, 480, this);
            Lose3 = new ButonPictura("Lose3.png", 0, 0, 800, 480, this);
            Lose4 = new ButonPictura("Lose4.png", 0, 0, 800, 480, this);
            Lose5 = new ButonPictura("Lose5.png", 0, 0, 800, 480, this);
            Lose6 = new ButonPictura("Lose6.png", 0, 0, 800, 480, this);
            Lose7 = new ButonPictura("Lose7.png", 0, 0, 800, 480, this);
            Lose8 = new ButonPictura("Lose8.png", 0, 0, 800, 480, this);
            Lose9 = new ButonPictura("Lose9.png", 0, 0, 800, 480, this);
            Lose10 = new ButonPictura("Lose10.png", 0, 0, 800, 480, this);
            Lose11 = new ButonPictura("Lose11.png", 0, 0, 800, 480, this);
            Lose12 = new ButonPictura("Lose12.png", 0, 0, 800, 480, this);
            DoorButton = new ButonPictura("Slot.png", 10000, 10000, 44, 168, this, DoorButtonClick);
            DoorButton2 = new ButonPictura("Slot.png", 10000, 10000, 44, 168, this, DoorButton2Click);
            But = new ButonPictura("Button.png", 10000, 10000, 40, 40, this, ButClick);
            But2 = new ButonPictura("Button.png", 10000, 10000, 40, 40, this, But2Click);
            TimeJerker = new ButonPictura("TimeJerker.png", 10000, 10000, 100, 270, this, TimeJerkerClick);
            ButonPictura.variableDisappear(Mess, CloseMessage, Entrance, RightArrow2, JeffTheKiller, LightSwitch, Lose2, Lose3, Lose4, Lose5,
                Lose6, Lose7, Lose8, Lose9, Lose10, Lose11, Lose12);
            Transparent = new ButonPictura("Transparent.png", 10000, 10000, 500, 500, this, TransparentClick);
            Timer = new ButonPictura("Time_00_03.png", 354, 0, 92, 30, this);
            Timer.disappear();
            Presentation = new ButonPictura("Presentation.png", 0, 0, 800, 480, this, PresentationClick);
        }

        private void PresentationClick(object arg1, EventArgs args)
        {
            Presentation.dispose();
        }

        private async void RightArrow4Click(object arg1, EventArgs args)
        {
            if(RightArrow4.isFrozen())
            {
                return;
            }
            if(drex_defeated == 1)
            {
                Inventory.dispose();
                Slot1.dispose();
                Slot2.dispose();
                Slot3.dispose();
                Slot4.dispose();
                Slot5.dispose();
                Slot6.dispose();
                Watergun.dispose();
                Flashlight.dispose();
                DreamBeam.dispose();
                Guitar.dispose();
                Map.dispose();
                RightArrow4.dispose();
                Hideout.setImage("Jasper.png");
                speak("Jasper! You're alive!", 265, 160, 100, 20);
                await Task.Delay(2000);
                speak("I knew you'd come Henry! I can always count on you...", 455, 160, 100, 40);
                await Task.Delay(3000);
                speak("Where is Ray though?", 455, 160, 100, 30);
                await Task.Delay(3000);
                speak("Ray is on vacation...", 265, 160, 100, 20);
                await Task.Delay(2000);
                speak("Seriously???", 455, 160, 100, 20);
                await Task.Delay(2000);
                Hideout.setImage("Beach1.png");
                speak("What a nice beach...", 365, 160, 100, 20);
                await Task.Delay(2000);
                Tex.Visible = false;
                Hideout.setImage("Beach2.png");
                await Task.Delay(1000);
                speak("Hmm, obviously you don't need me anymore Toddler...", 565, 160, 100, 40);
                await Task.Delay(3000);
                Hideout.setImage("Beach3.png");
                Tex.Visible = false;
                await Task.Delay(1000);
                speak("What is happening???", 365, 160, 100, 30);
                await Task.Delay(3000);
                Tex.Visible = false;
                Hideout.setImage("Logo.png");
                return;
            }
            if(no_clicks_right_arrow_4 == 0)
            {
                no_clicks_right_arrow_4 = 1;
                return;
            }
            if(no_clicks_right_arrow_4 == 1)
            {
                no_clicks_right_arrow_4 = 2;
                Hideout.setImage("RoomLaser.png");
                But2.setCoordinates(But.getCoordinates().X, But.getCoordinates().Y);
                But2.appear(true);
                Transparent.setCoordinates(300, 30);
                Transparent.setWidth(100);
                Transparent.setHeight(100);
                return;
            }
            But.disappear();
            ButonPictura.variableFreeze(Guitar, Flashlight, Watergun, DreamBeam, Map);
            Green.disappear();
            NameOfObject.Visible = false;
            RightArrow4.disappear();
            But2.disappear();
            Hideout.setImage("Drex1.png");
            Lose8.disappear();
            Lose9.disappear();
            await Task.Delay(1000);
            Hideout.setImage("Drex2.png");
            await Task.Delay(1000);
            Hideout.setImage("Drex3.png");
            await Task.Delay(1000);
            speak("I was always the better sidekick Henry Hart, never forget that...", 455, 160, 100, 80);
            await Task.Delay(3000);
            Tex.Visible = false;
            BackToGame.setCoordinates(300, 350);
            ButonPictura.variableAppear(true, Lose10, BackToGame);
            return;
        }

        private async void DreamBeamClick(object arg1, EventArgs args)
        {
            if (DreamBeam.isFrozen())
            {
                return;
            }
            if (allowed2 == 1)
            {
                drex_defeated = 1;
                ButonPictura.variableFreeze(Watergun, DreamBeam, Flashlight, Guitar);
                Green.disappear();
                NameOfObject.Visible = false;
                Lose12.dispose();
                Lose11.dispose();
                Timer.disappear();
                speak("This is the end Drex...", 455, 160, 100, 40);
                await Task.Delay(2000);
                Tex.Visible = false;
                Hideout.setImage("Drex11.png");
                await Task.Delay(1000);
                Hideout.setImage("Drex7.png");
                speak("Finally! It's finally over...", 455, 160, 100, 30);
                await Task.Delay(2000);
                RightArrow4.appear(true);
                RightArrow4.reactivate();
                Tex.Visible = false;
                But2.dispose();
                ButonPictura.variableReactivate(Watergun, DreamBeam, Flashlight, Guitar, Map);
                return;
            }
            if (Green.getP().Location.X + 7 == DreamBeam.getP().Location.X && Green.getP().Visible == true
                && Green.getP().Location.Y + 7 == DreamBeam.getP().Location.Y)
            {
                NameOfObject.Visible = false;
                Green.disappear();
                return;
            }
            Green.setCoordinates(DreamBeam.getP().Location.X - 7, DreamBeam.getP().Location.Y - 7);
            NameOfObject.Text = "Dream Beam";
            NameOfObject.Visible = true;
            NameOfObject.BringToFront();
            ButonPictura.variableAppear(true, Green, DreamBeam);
        }

        private async void TransparentClick(object arg1, EventArgs args)
        {
            if(Transparent.isFrozen())
            {
                return;
            }
            if(minyak_state == 0)
            {
                if (Green.getP().Location.X + 7 == Ladder.getP().Location.X && Green.getP().Visible == true
                    && Green.getP().Location.Y + 7 == Ladder.getP().Location.Y)
                {
                    Ladder.dispose();
                    Green.disappear();
                    NameOfObject.Visible = false;
                    Hideout.setImage("DrMinyak5.png");
                    minyak_state = 1;
                    return;
                }
                return;
            }
            if (minyak_state == 1)
            {
                if (Green.getP().Location.X + 7 == Anvil.getP().Location.X && Green.getP().Visible == true
                    && Green.getP().Location.Y + 7 == Anvil.getP().Location.Y)
                {
                    Anvil.dispose();
                    Green.disappear();
                    NameOfObject.Visible = false;
                    Hideout.setImage("DrMinyak9.png");
                    minyak_state = 2;
                    Transparent.setCoordinates(Transparent.getCoordinates().X - 200, Transparent.getCoordinates().Y);
                    Transparent.increaseWidth(200);
                    return;
                }
                return;
            }
            if (minyak_state == 2)
            {
                if (Green.getP().Location.X + 7 == Termite.getP().Location.X && Green.getP().Visible == true
                    && Green.getP().Location.Y + 7 == Termite.getP().Location.Y && allowed == 1)
                {
                    ButonPictura.variableFreeze(Guitar, Flashlight, Watergun);
                    Green.disappear();
                    NameOfObject.Visible = false;
                    minyak_state = 3;
                    RightArrow3.dispose();
                    ButonPictura.variableDispose(Lose9);
                    Hideout.setImage("DrMinyak13.png");
                    Termite.dispose();
                    DoorButton2.dispose();
                    ButonPictura.variableMoveAway(BackToGame);
                    Tex.Visible = false;
                    await Task.Delay(1000);
                    Hideout.setImage("DrMinyak14.png");
                    speak("Well, well, well... A ladder specially prepared for Super Termite...", 300, 100, 100, 80);
                    await Task.Delay(3000);
                    Tex.Visible = false;
                    Hideout.setImage("DrMinyak15.png");
                    await Task.Delay(1000);
                    Hideout.setImage("DrMinyak16.png");
                    await Task.Delay(1500);
                    Hideout.setImage("Room.png");
                    speak("This reminds me of Obama Guantanamo Escape, he he he... Now I have Minyak's Dream Beam in my inventory.", 265, 160, 100, 80);
                    await Task.Delay(3000);
                    Tex.Visible = false;
                    DreamBeam.setCoordinates(80, 80);
                    DreamBeam.appear(true);
                    ButonPictura.variableReactivate(Guitar, Flashlight, Watergun, Map);
                    RightArrow4.setCoordinates(675, 370);
                    RightArrow4.appear(true);
                    Lose9.disappear();
                    Lose8.disappear();
                    return;
                }
                return;
            }

            if (Green.getP().Location.X + 7 == Guitar.getP().Location.X && Green.getP().Visible == true
                && Green.getP().Location.Y + 7 == Guitar.getP().Location.Y)
            {
                ButonPictura.variableFreeze(Guitar, Watergun, Flashlight, DreamBeam, Map, RightArrow4, Transparent);
                NameOfObject.Visible = false;
                Green.disappear();
                RightArrow4.disappear();
                But2.disappear();
                Hideout.setImage("RoomLaser3.png");
                await Task.Delay(1000);
                Hideout.setImage("RoomLaser4.png");
                But2.appear(true);
                Timer.appear(true);
                Timer.setImage("Time_00_03.png");
                await Task.Delay(1000);
                Timer.setImage("Time_00_02.png");
                await Task.Delay(1000);
                Timer.setImage("Time_00_01.png");
                await Task.Delay(1000);
                Timer.disappear();
                But2.freeze();
                But2.disappear();
                if (drex_attacked == 1)
                    return;
                Hideout.setImage("Drex.png");
                speak("My smartwatch tells me someone moved the laser in the other room, let's give them a lesson...", 455, 160, 100, 80);
                await Task.Delay(3000);
                Hideout.setImage("RoomLaser4.png");
                But2.appear(true);
                speak("I feel a funny smell...", 245, 160, 100, 20);
                await Task.Delay(2000);
                Tex.Visible = false;
                Hideout.setImage("RoomLaser5.png");
                await Task.Delay(1500);
                BackToGame.setCoordinates(300, 350);
                ButonPictura.variableAppear(true, Lose11, BackToGame);
                Lose10.disappear();
                But2.disappear();
                return;
            }
            speak("It's too high...", 245, 160, 100, 20);
            ButonPictura.variableFreeze(Guitar, Watergun, Flashlight, DreamBeam, Map, RightArrow4, Transparent, But2);
            await Task.Delay(2000);
            Tex.Visible = false;
            ButonPictura.variableReactivate(Guitar, Watergun, Flashlight, DreamBeam, Map, RightArrow4, Transparent, But2);
            return;
        }

        private async void But2Click(object arg1, EventArgs args)
        {
            if (But2.isFrozen())
            {
                return;
            }
            if (Timer.isVisible())
            {
                Timer.disappear();
                drex_attacked = 1;
                Hideout.setImage("Drex.png");
                speak("My smartwatch tells me someone moved the laser in the other room, let's give them a lesson...", 455, 160, 100, 80);
                But2.disappear();
                await Task.Delay(3000);
                Tex.Visible = false;
                Hideout.setImage("Drex4.png");
                await Task.Delay(1000);
                Hideout.setImage("RoomLaser6.png");
                But2.appear(true);
                But2.freeze();
                await Task.Delay(1000);
                But2.disappear();
                Hideout.setImage("Drex5.png");
                await Task.Delay(1000);
                Hideout.setImage("Drex6.png");
                await Task.Delay(1000);
                Hideout.setImage("RoomLaser4.png");
                But2.appear(true);
                But2.freeze();
                speak("Now I have to neutralize Drex...", 245, 160, 100, 40);
                await Task.Delay(2000);
                Tex.Visible = false;
                But2.disappear();
                Hideout.setImage("Drex7.png");
                allowed2 = 1;
                ButonPictura.variableReactivate(DreamBeam, Watergun, Guitar, Flashlight);
                Timer.appear(true);
                Timer.setImage("Time_00_04.png");
                await Task.Delay(1000);
                Timer.setImage("Time_00_03.png");
                await Task.Delay(1000);
                Timer.setImage("Time_00_02.png");
                await Task.Delay(1000);
                Timer.setImage("Time_00_01.png");
                await Task.Delay(1000);
                Timer.disappear();
                allowed2 = 0;
                ButonPictura.variableFreeze(DreamBeam, Watergun, Guitar, Flashlight);
                Green.disappear();
                NameOfObject.Visible = false;
                if (drex_defeated == 1)
                    return;
                Hideout.setImage("Drex8.png");
                speak("Now I'll show you to mess with me...", 245, 160, 100, 40);
                await Task.Delay(2000);
                Tex.Visible = false;
                Hideout.setImage("Drex9.png");
                await Task.Delay(1000);
                Hideout.setImage("Drex10.png");
                await Task.Delay(1000);
                BackToGame.setCoordinates(300, 350);
                Lose11.disappear();
                Lose10.disappear();
                ButonPictura.variableAppear(true, Lose12, BackToGame);
                return;
            }
            Hideout.setImage("RoomLaser2.png");
            ButonPictura.variableFreeze(Guitar, Watergun, Flashlight, DreamBeam, Map, But2, RightArrow4);
            NameOfObject.Visible = false;
            Green.disappear();
            await Task.Delay(1000);
            ButonPictura.variableReactivate(Guitar, Watergun, Flashlight, DreamBeam, Map, But2, RightArrow4);
            Hideout.setImage("RoomLaser.png");
            return;
        }

        private async void DoorButton2Click(object arg1, EventArgs args)
        {
            if (Green.getP().Location.X + 7 == Guitar.getP().Location.X && Green.getP().Visible == true
                && Green.getP().Location.Y + 7 == Guitar.getP().Location.Y)
            {
                ButonPictura.variableFreeze(Guitar, Flashlight, Ladder, Anvil, Termite, Watergun, Map);
                ButonPictura.variableDisappear(DoorButton2, Green, RightArrow3, Lose8);
                NameOfObject.Visible = false;
                Hideout.setImage("DrMinyak4.png");
                speak("WHAT IS THIS NOISE??? WHO DARES TO DO THIS?!", 435, 160, 100, 60);
                await Task.Delay(3000);
                if (minyak_state == 0)
                    Hideout.setImage("DrMinyak1.png");
                else if (minyak_state == 1)
                    Hideout.setImage("DrMinyak6.png");
                else
                    Hideout.setImage("DrMinyak10.png");
                if (minyak_state == 0)
                    speak("Thinkin' you're very clever Henry?", 465, 160, 100, 30);
                else
                    speak("Thinkin' you're very clever Henry?", 580, 160, 100, 30);
                if(minyak_state == 2)
                {
                    ButonPictura.variableReactivate(Guitar, Flashlight, Watergun, Termite);
                    allowed = 1;
                }
                await Task.Delay(3000);
                allowed = 0;
                if (minyak_state != 3)
                    Tex.Visible = false;
                if (minyak_state >= 2)
                {
                    ButonPictura.variableFreeze(Guitar, Flashlight, Watergun, Termite);
                    Green.disappear();
                    NameOfObject.Visible = false;
                }
                if (minyak_state == 0)
                    Hideout.setImage("DrMinyak2.png");
                else if (minyak_state == 1)
                    Hideout.setImage("DrMinyak7.png");
                else if(minyak_state == 2)
                    Hideout.setImage("DrMinyak11.png");
                await Task.Delay(1000);
                if (minyak_state == 0)
                    Hideout.setImage("DrMinyak3.png");
                else if (minyak_state == 1)
                    Hideout.setImage("DrMinyak8.png");
                else if(minyak_state == 2)
                    Hideout.setImage("DrMinyak12.png");
                await Task.Delay(1500);
                ButonPictura.variableAppear(true, Lose9, BackToGame);
                return;
            }
            
        }

        private void Box2Click(object arg1, EventArgs args)
        {
            Anvil.setCoordinates(150, 10);
            Ladder.setCoordinates(150, 80);
            Box2.dispose();
            RightArrow3.appear(true);
            DoorButton2.setCoordinates(729, 200);
            Transparent.setCoordinates(600, 0);
            ButonPictura.variableAppear(true, Transparent, Map, RightArrow3);
            Transparent.setImage(null);
            Transparent.getP().BackColor = Color.Transparent;
            Transparent.getP().Parent = Hideout.getP();
            return;
        }

        private void AnvilClick(object arg1, EventArgs args)
        {
            if (Anvil.isFrozen())
            {
                return;
            }
            if (Green.getP().Location.X + 7 == Anvil.getP().Location.X && Green.getP().Visible == true
                && Green.getP().Location.Y + 7 == Anvil.getP().Location.Y)
            {
                NameOfObject.Visible = false;
                Green.disappear();
                return;
            }
            Green.setCoordinates(Anvil.getP().Location.X - 7, Anvil.getP().Location.Y - 7);
            NameOfObject.Text = "Anvil";
            NameOfObject.Visible = true;
            NameOfObject.BringToFront();
            ButonPictura.variableAppear(true, Green, Anvil);
        }

        private void LadderClick(object arg1, EventArgs args)
        {
            if (Ladder.isFrozen())
            {
                return;
            }
            if (Green.getP().Location.X + 7 == Ladder.getP().Location.X && Green.getP().Visible == true
                && Green.getP().Location.Y + 7 == Ladder.getP().Location.Y)
            {
                NameOfObject.Visible = false;
                Green.disappear();
                return;
            }
            Green.setCoordinates(Ladder.getP().Location.X - 7, Ladder.getP().Location.Y - 7);
            NameOfObject.Text = "Ladder";
            NameOfObject.Visible = true;
            NameOfObject.BringToFront();
            ButonPictura.variableAppear(true, Green, Ladder);
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
            ButonPictura.variableAppear(true, Flashlight, Superglue, Witch, Watergun, Guitar, Termite, Six, JeffInventory, SlendermanInventory,
                Anvil, Ladder, DreamBeam);
        }

        private void SubwayMapClick(object sender, EventArgs e)
        {
            ButonPictura.variableDisappear(SubwayMap, HideoutMap, ParkMap, Park, Hideout);
            ButonPictura.variableAppear(true, Subway, Map);
            ButonPictura.variableAppear(true, Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6);
            ButonPictura.variableAppear(true, Flashlight, Superglue, Witch, Watergun, Guitar, RightArrow, X,
                Termite, Six, JeffInventory, SlendermanInventory, Anvil, Ladder, DreamBeam);
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
                Termite, Six, RightArrow2, JeffInventory, SlendermanInventory, DoorButton, RightArrow3, Box2, Anvil, Ladder, DoorButton2, DreamBeam,
                But2, RightArrow4);
            if(entrance == 1)
            {
                Entrance.appear(true);
            }
            if(time_jerker_defeated == 1)
            {
                But.appear(true);
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
                X, Slenderman, Paper, Entrance, Termite, Six, RightArrow2, JeffInventory, SlendermanInventory,
                DoorButton, RightArrow3, Box2, Anvil, Ladder, DoorButton2, DreamBeam, But2, RightArrow4);
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
                pressed_light_switch = 0;
                Hideout.setImage("Room.png");
                JeffTheKiller.setImage("JeffTheKiller.png");
                Lose2.setCoordinates(0, 0);
                LightSwitch.setCoordinates(120, 200);
                ButonPictura.variableDisappear(Lose3, BackToGame);
                return;
            }

            if (Lose4.isVisible())
            {
                
                Lose2.disappear();
                Lose4.disappear();
                ButonPictura.variableReactivate(Map);
                BackToGame.disappear();
                ButonPictura.variableDisappear(JeffTheKiller, LightSwitch);
                Tex.Visible = false;
                ButonPictura.variableAppear(true, RightArrow2);
                pressed_light_switch = 0;
                jeff_blinded_with_flashlight = 0;
                Hideout.setImage("Room.png");
                JeffTheKiller.setImage("JeffTheKiller.png");
                Lose2.setCoordinates(0, 0);
                Lose3.setCoordinates(0, 0);
                LightSwitch.setCoordinates(120, 200);
                ButonPictura.variableDisappear(Lose3, BackToGame);
                ButonPictura.variableReactivate(Flashlight, Termite, Guitar, Watergun, Six);
                return;
            }

            if(Lose5.isVisible())
            {
                ButonPictura.variableReactivate(Flashlight, Watergun, JeffInventory, Guitar, Six, Termite, Map, SlendermanInventory);
                ButonPictura.variableAppear(true, RightArrow2);
                ButonPictura.variableDisappear(Lose5, BackToGame);
                Tex.Visible = false;
                Hideout.setImage("Room.png");
                return;
            }

            if(Lose6.isVisible())
            {
                ButonPictura.variableDisappear(Lose6, BackToGame);
                Green.disappear();
                NameOfObject.Visible = false;
                BackToGame.setCoordinates(10000, 10000);
                Tex.Visible = false;
                TimeJerker.setImage("TimeJerker.png");
                turned = 0;
                ButonPictura.variableDisappear(But, TimeJerker);
                Hideout.setImage("Room.png");
                RightArrow3.appear(true);
                ButonPictura.variableReactivate(Map);
                return;
            }

            if (Lose7.isVisible())
            {
                ButonPictura.variableDisappear(Lose7, BackToGame);
                six_thrown_wrong = 0;
                turned = 0;
                ButonPictura.variableReactivate(Flashlight, Watergun, Termite, Guitar, Map);
                Six.setCoordinates(150, 10);
                Lose6.setCoordinates(0, 0);
                BackToGame.setCoordinates(300, 350);
                RightArrow3.appear(true);
                Hideout.setImage("Room.png");
                ButonPictura.variableDisappear(But, TimeJerker);
                Tex.Visible = false;
                TimeJerker.setImage("TimeJerker.png");
                TimeJerker.setCoordinates(470, 165);
                return;
            }

            if(Lose8.isVisible())
            {
                RightArrow3.appear(true);
                ButonPictura.variableReactivate(Termite, Anvil, Watergun, Guitar, Flashlight, Ladder, Map);
                if (minyak_state == 0)
                    Hideout.setImage("Room.png");
                else if (minyak_state == 1)
                    Hideout.setImage("DrMinyak5.png");
                else
                    Hideout.setImage("DrMinyak9.png");
                ButonPictura.variableDisappear(Lose8, BackToGame);
                return;
            }

            if(Lose9.isVisible())
            {
                ButonPictura.variableReactivate(Guitar, Flashlight, Ladder, Anvil, Termite, Watergun, Map);
                ButonPictura.variableAppear(true, DoorButton2, RightArrow3);
                if (minyak_state == 0)
                    Hideout.setImage("Room.png");
                else if(minyak_state == 1)
                    Hideout.setImage("DrMinyak5.png");  
                else
                    Hideout.setImage("DrMinyak9.png");
                ButonPictura.variableDisappear(Lose9, BackToGame);
                return;
            }

            if(Lose10.isVisible())
            {
                ButonPictura.variableReactivate(Guitar, Flashlight, Watergun, DreamBeam, Map);
                RightArrow4.appear(true);
                But2.appear(true);
                Hideout.setImage("RoomLaser.png");
                ButonPictura.variableDisappear(Lose10, BackToGame);
                return;
            }

            if(Lose11.isVisible())
            {
                ButonPictura.variableReactivate(Guitar, Watergun, Flashlight, DreamBeam, Map, But2, RightArrow4, Transparent);
                But2.appear(true);
                RightArrow4.appear(true);
                Hideout.setImage("RoomLaser.png");                                      
                ButonPictura.variableDisappear(Lose11, BackToGame);
                return;                
            }

            if (Lose12.isVisible())
            {
                ButonPictura.variableReactivate(Guitar, Watergun, Flashlight, DreamBeam, Map, RightArrow4, Transparent, But2);
                RightArrow4.appear(true);
                But2.appear(true);
                Hideout.setImage("RoomLaser.png");               
                But2.reactivate();
                drex_attacked = 0;                                                          
                ButonPictura.variableDisappear(Lose12, BackToGame);
                return;
            }
        }

        private async void SlendermanClick(object sender, EventArgs e)
        {
            if(Slenderman.isFrozen())
            {
                return;
            }
            if (Green.getP().Location.X + 7 == JeffInventory.getP().Location.X && Green.getP().Visible == true
                && Green.getP().Location.Y + 7 == JeffInventory.getP().Location.Y)
            {
                Green.disappear();
                NameOfObject.Visible = false;
                ButonPictura.variableFreeze(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Map);
                ButonPictura.variableFreeze(Flashlight, Guitar, Watergun, Slenderman, Six, Termite);
                JeffInventory.dispose();
                Paper.dispose();
                Slenderman.freeze();
                speak("Hello Slenderman, I have a deal for you...", 230, 200, 100, 40);
                await Task.Delay(3000);
                speak("It better be good Kid Danger, you think I can't kidnap you too?", 430, 200, 100, 60);
                await Task.Delay(4000);
                speak("I need your help in a mission, in exchange I have your nemesis...", 230, 200, 100, 60);
                await Task.Delay(4000);
                speak("I'll believe it when I see it man...", 430, 200, 100, 40);
                await Task.Delay(4000);
                Subway.setImage("HenryBringingJeff.png");
                speak("Is this believable enough?...", 230, 200, 100, 40);
                await Task.Delay(3000);
                speak("Oh boy, finally I have Jeff at my mercy... I owe you. Fine. I'll come with you...", 430, 200, 100, 80);
                await Task.Delay(5000);
                Tex.Visible = false;
                SlendermanInventory.setCoordinates(150, 80);
                Subway.setImage("Subway8.png");
                Slenderman.dispose();
                ButonPictura.variableReactivate(Inventory, Slot1, Slot2, Slot3, Slot4, Slot5, Slot6, Map);
                ButonPictura.variableReactivate(Flashlight, Guitar, Watergun, Slenderman, Six, Termite);
                DoorButton.setCoordinates(729, 200);
                return;
            }
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
            if(RightArrow2.isFrozen())
            {
                return;
            }
            if(jeff_attacked == 0)
            {
                Green.disappear();
                NameOfObject.Visible = false;
                ButonPictura.variableDisappear(RightArrow2);
                ButonPictura.variableAppear(true, JeffTheKiller, LightSwitch);
                ButonPictura.variableFreeze(Map);
                speak("Time to sleep, Henry Hart...", 365, 160, 100, 30);
                await Task.Delay(3000);
                ButonPictura.variableAppear(true, Lose2, BackToGame);
                if (pressed_light_switch == 0)
                {
                    Green.disappear();
                    NameOfObject.Visible = false;
                }
                return;
            }
            ButonPictura.variableFreeze(Flashlight, Watergun, JeffInventory, Guitar, Six, Termite, Map, SlendermanInventory);
            Green.disappear();
            NameOfObject.Visible = false;
            RightArrow2.disappear();
            Hideout.setImage("Toddler1.png");
            await Task.Delay(1000);
            Hideout.setImage("Toddler2.png");
            await Task.Delay(1000);
            Hideout.setImage("Toddler3.png");
            await Task.Delay(1000);
            Hideout.setImage("Toddler4.png");
            await Task.Delay(1000);
            speak("Remember the bottomless ball pit Henry Hart? This is even worse my friend...", 365, 160, 100, 80);
            await Task.Delay(3000);
            BackToGame.setCoordinates(300, 350);
            ButonPictura.variableAppear(true, Lose5, BackToGame);
            return;
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
            if(jeff_blinded_with_flashlight == 0)
            {
                BackToGame.setCoordinates(300, 350);
                Green.disappear();
                NameOfObject.Visible = false;
                ButonPictura.variableAppear(true, Lose3, BackToGame);
            }
            Lose2.disappear();
        }

        private async void JeffTheKillerClick(object sender, EventArgs e)
        {
            if(JeffTheKiller.isFrozen())
            {
                return;
            }
            if (Green.getP().Location.X + 7 == Flashlight.getP().Location.X && Green.getP().Visible == true
                && Green.getP().Location.Y + 7 == Flashlight.getP().Location.Y && pressed_light_switch == 1)
            {
                ButonPictura.variableFreeze(Flashlight, Termite, Guitar, Watergun, Six);
                Green.disappear();
                NameOfObject.Visible = false;
                jeff_blinded_with_flashlight = 1;
                Lose3.disappear();
                JeffTheKiller.disappear();
                Lose3.setCoordinates(10000, 10000);
                BackToGame.setCoordinates(10000, 10000);
                Hideout.setImage("HenryLanternAttack.png");
                Tex.Visible = false;             
                await Task.Delay(1500);
                Hideout.setImage("RoomDark.png");
                ButonPictura.variableReactivate(Flashlight, Termite, Guitar, Watergun, Six);
                JeffTheKiller.appear(true);
                speak("Ahhhh!! I can't see dammit...", 365, 160, 100, 60);
                await Task.Delay(3000);
                ButonPictura.variableFreeze(Flashlight, Termite, Guitar, Watergun, Six);
                if (jeff_attacked == 0)
                {
                    speak("Hehehe, I can see again, you'll pay dearly for this...", 365, 160, 100, 60);
                }
                Green.disappear();
                NameOfObject.Visible = false;
                await Task.Delay(3000);
                if(jeff_attacked == 0)
                {
                    BackToGame.setCoordinates(300, 350);
                    ButonPictura.variableAppear(true, Lose4, BackToGame);
                }         
                return;
            }

            if (Green.getP().Location.X + 7 == Guitar.getP().Location.X && Green.getP().Visible == true
                && Green.getP().Location.Y + 7 == Guitar.getP().Location.Y && jeff_blinded_with_flashlight == 1)
            {
                jeff_attacked = 1;
                ButonPictura.variableFreeze(Flashlight, Termite, Guitar, Watergun, Six);
                Green.disappear();
                NameOfObject.Visible = false;
                Lose4.disappear();
                ButonPictura.variableDispose(Lose2, Lose3, Lose4, JeffTheKiller);
                BackToGame.setCoordinates(10000, 10000);
                speak("Guess what Jeff, you're the one who will see...", 285, 160, 100, 60);
                Hideout.setImage("HenryJeffAttack.png");
                await Task.Delay(3000);
                Tex.Visible = false;
                Hideout.setImage("Fight1.png");
                await Task.Delay(1000);
                Hideout.setImage("Fight2.png");
                await Task.Delay(1000);
                Hideout.setImage("Fight1.png");
                await Task.Delay(1000);
                Hideout.setImage("Fight2.png");
                await Task.Delay(1000);
                Hideout.setImage("Room.png");
                speak("I captured Jeff the Killer, now I have him in the inventory.", 285, 160, 100, 60);
                await Task.Delay(5000);
                RightArrow2.appear(true);
                ButonPictura.variableReactivate(Flashlight, Termite, Guitar, Watergun, Six, Map);
                Tex.Visible = false;
                JeffInventory.setCoordinates(150, 80);
                return;
            }
        }

        private void JeffInventoryClick(object sender, EventArgs e)
        {
            if (JeffInventory.isFrozen())
            {
                return;
            }
            if (Green.getP().Location.X + 7 == JeffInventory.getP().Location.X && Green.getP().Visible == true
                && Green.getP().Location.Y + 7 == JeffInventory.getP().Location.Y)
            {
                NameOfObject.Visible = false;
                Green.disappear();
                return;
            }
            Green.setCoordinates(JeffInventory.getP().Location.X - 7, JeffInventory.getP().Location.Y - 7);
            NameOfObject.Text = "Jeff captured";
            NameOfObject.Visible = true;
            NameOfObject.BringToFront();
            ButonPictura.variableAppear(true, Green, JeffInventory);
        }

        private void SlendermanInventoryClick(object sender, EventArgs e)
        {
            if (SlendermanInventory.isFrozen())
            {
                return;
            }
            if (Green.getP().Location.X + 7 == SlendermanInventory.getP().Location.X && Green.getP().Visible == true
                && Green.getP().Location.Y + 7 == SlendermanInventory.getP().Location.Y)
            {
                NameOfObject.Visible = false;
                Green.disappear();
                return;
            }
            Green.setCoordinates(SlendermanInventory.getP().Location.X - 7, SlendermanInventory.getP().Location.Y - 7);
            NameOfObject.Text = "Slenderman";
            NameOfObject.Visible = true;
            NameOfObject.BringToFront();
            ButonPictura.variableAppear(true, Green, SlendermanInventory);
        }

        private async void DoorButtonClick(object sender, EventArgs e)
        {
            if(DoorButton.isFrozen()) { 
                return;
            }
            if (Green.getP().Location.X + 7 == SlendermanInventory.getP().Location.X && Green.getP().Visible == true
                && Green.getP().Location.Y + 7 == SlendermanInventory.getP().Location.Y)
            {
                RightArrow2.dispose();
                DoorButton.dispose();
                SlendermanInventory.dispose();
                ButonPictura.variableFreeze(Flashlight, Watergun, Guitar, Six, Termite, Map);
                Green.disappear();
                NameOfObject.Visible = false;
                Hideout.setImage("Toddler5.png");
                await Task.Delay(1000);
                Hideout.setImage("Toddler6.png");
                speak("Oh shit...", 465, 160, 100, 20);
                await Task.Delay(2000);
                Hideout.setImage("Toddler7.png");
                speak("Henry Hart! This is your doing?", 465, 160, 100, 40);
                await Task.Delay(3000);
                speak("How do you even know my identity?", 205, 160, 100, 40);
                await Task.Delay(3000);
                speak("Well Jasper was forced by my boss Drex to tell him everything...", 465, 160, 100, 80);
                await Task.Delay(4000);
                speak("Drex is behind this? Seriously?", 205, 160, 100, 40);
                await Task.Delay(3000);
                speak("Now you're coming with me...", 365, 160, 100, 40);
                await Task.Delay(3000);
                Tex.Visible = false;
                Hideout.setImage("Toddler8.png");
                ButonPictura.variableReactivate(Flashlight, Watergun, Guitar, Six, Termite, Map);
                RightArrow3.setCoordinates(675, 370);
                Lose5.disappear();
                return;
            }
        }

        private async void RightArrow3Click(object sender, EventArgs e)
        {
            if(box2taken == 1)
            {
                RightArrow3.disappear();
                Green.disappear();
                NameOfObject.Visible = false;
                ButonPictura.variableFreeze(Termite, Anvil, Watergun, Guitar, Flashlight, Ladder, Map);
                Hideout.setImage("DrMinyak1.png");
                await Task.Delay(1000);
                Hideout.setImage("DrMinyak2.png");
                await Task.Delay(1000);
                Hideout.setImage("DrMinyak3.png");
                await Task.Delay(1500);
                ButonPictura.variableAppear(true, Lose8, BackToGame);
                BackToGame.setCoordinates(300, 350);
                return;
            }
            if(time_jerker_defeated == 1)
            {
                RightArrow3.disappear();
                Box2.setCoordinates(Box.getCoordinates().X, Box.getCoordinates().Y);
                But.dispose();
                box2taken = 1;
                return;
            }
            no_clicks_rightarrow3++;
            if(no_clicks_rightarrow3 == 1)
            {
                Hideout.setImage("Room.png");
                But.freeze();
                return;
            }
            ButonPictura.variableFreeze(Map);
            Green.disappear();
            RightArrow3.disappear();
            NameOfObject.Visible = false;
            Hideout.setImage("TimeJerker1.png");
            ButonPictura.variableAppear(true, But, TimeJerker);
            But.setCoordinates(300, 225);
            TimeJerker.setCoordinates(470, 165);
            speak("Hello Henry! I know your identity now, don't I?", 365, 160, 100, 40);
            await Task.Delay(3000);
            turned = 1;
            TimeJerker.setImage("TimeJerkerTurned.png");
            if(six_thrown_wrong == 0 && six_thrown_right == 0)
            {
                speak("Now that you're here I'm leaving. I don't have TIME to talk to you.", 365, 160, 100, 60);
                await Task.Delay(3000);
                if (six_thrown_wrong == 0 && six_thrown_right == 0)
                {
                    BackToGame.setCoordinates(300, 350);
                    ButonPictura.variableAppear(true, Lose6, BackToGame);
                }             
            }         
            Green.disappear();
            NameOfObject.Visible = false;         
        }

        private async void TimeJerkerClick(object sender, EventArgs e)
        {
            if(turned == 0)
            {
                if (Green.getP().Location.X + 7 == Six.getP().Location.X && Green.getP().Visible == true
                    && Green.getP().Location.Y + 7 == Six.getP().Location.Y)
                {
                    six_thrown_wrong = 1;
                    Green.disappear();
                    NameOfObject.Visible = false;
                    ButonPictura.variableFreeze(Flashlight, Watergun, Termite, Guitar);
                    ButonPictura.variableMoveAway(Six, Lose6, TimeJerker, BackToGame);
                    ButonPictura.variableDisappear(Lose6);
                    Hideout.setImage("TimeJerker2.png");
                    speak("You're planning to hit me with that? I want to see you try, honestly...", 365, 160, 100, 80);
                    await Task.Delay(3000);
                    speak("Well, now that you're here, I'm leaving. I don't have TIME to talk to you.", 365, 160, 100, 60);
                    await Task.Delay(3000);
                    BackToGame.setCoordinates(300, 350);
                    ButonPictura.variableAppear(true, Lose7, BackToGame);
                }
                return;
            }
            if (turned == 1)
            {
                if (Green.getP().Location.X + 7 == Six.getP().Location.X && Green.getP().Visible == true
                    && Green.getP().Location.Y + 7 == Six.getP().Location.Y)
                {
                    six_thrown_right = 1;
                    Green.disappear();
                    NameOfObject.Visible = false;
                    ButonPictura.variableFreeze(Flashlight, Watergun, Termite, Guitar);
                    ButonPictura.variableMoveAway(Six, TimeJerker, BackToGame, RightArrow3);
                    ButonPictura.variableDisappear(Lose6, Lose7);
                    ButonPictura.variableDispose(Lose6, Lose7, Six);                   
                    Tex.Visible = false;
                    Hideout.setImage("TimeJerker3.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker4.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker5.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker6.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker7.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker8.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker9.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker10.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker11.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker12.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker13.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker14.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker15.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker16.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker17.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker18.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker19.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker20.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker21.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker22.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker23.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker24.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker25.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker26.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker27.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker28.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker29.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker30.png");
                    await Task.Delay(25);
                    Hideout.setImage("TimeJerker31.png");
                    await Task.Delay(1000);
                    Hideout.setImage("TimeJerker1.png");
                    speak("I guess defeating him took just a little TIME...", 205, 160, 100, 40);
                    await Task.Delay(3000);
                    Tex.Visible = false;
                    ButonPictura.variableReactivate(Flashlight, Watergun, Termite, Guitar, Map, But);
                    time_jerker_defeated = 1;
                    BackToGame.setCoordinates(300, 350);
                }
                return;
            }
        }

        private void ButClick(object sender, EventArgs e)
        {
            if(But.isFrozen())
            {
                return;
            }
            But.freeze();
            Hideout.setImage("Room.png");
            RightArrow3.setCoordinates(675, 370);
            RightArrow3.appear(true);
        }
    }
}
