using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Device.Location;

namespace PokemonGoTeleporter
{
    public partial class appForm : Form
    {

        public float currentLatitude;
        public float currentLongitude;
        public string tempCurrentCoords;
        float currentLat, currentLong;
        float latitudeFloat;
        float longitudeFloat;
        float latFloat1, latFloat2, longFloat1, longFloat2;
        Process process = new Process();
        ProcessStartInfo startInfo = new ProcessStartInfo();
        bool isServiceRunning = false;
        TimeSpan t;
        int timeSeconds;
        bool orderCoordsByDistance = true;
        List<float> listLatitude = new List<float>();
        List<float> listLongitude = new List<float>();
        List<float> listSortedLatitude = new List<float>();
        List<float> listSortedLongitude = new List<float>();
        List<float> listSortedDistances = new List<float>();
        List<string> coords = new List<string>();
        float[][] distances = new float[1][];
        double smallestDist = 0;
        bool firstCoord = true;
        bool checkBtnAvailable = false;
        int adbWaitTime = 1000;


        public appForm()
        {
            InitializeComponent();
            timer1.Stop();
        }

        private int getSmallestDist()
        {
            smallestDist = 50000;
            int loc = 0;
            for(int i = 0; i < listLatitude.Count; i++)
            {
                if(calcDistance(currentLat, listLatitude[i], currentLong, listLongitude[i]) < smallestDist)
                {
                    smallestDist = calcDistance(currentLat, listLatitude[i], currentLong, listLongitude[i]);
                    loc = i;
                }
            }

            return loc;
        }

        private float calcDistance(float lat1, float lat2, float long1, float long2)
        {
            GeoCoordinate loc1 = new GeoCoordinate(lat1, long1);
            GeoCoordinate loc2 = new GeoCoordinate(lat2, long2);

            double distance = loc1.GetDistanceTo(loc2) / 1000;

            return Convert.ToSingle(distance);
        }
        //--> UI element setups START here <--//

        private void teleportBtn_Click(object sender, EventArgs e)
        {

            if (checkBtnAvailable)
            {
                startService();
                currentCoordinateTextBox.Text = nextCoordinateTextBox.Text;
                try
                {
                    int i = getSmallestDist();
                    currentLat = listLatitude[i];
                    currentLong = listLongitude[i];
                    nextCoordinateTextBox.Text = currentLat.ToString() + ", " + currentLong.ToString();
                    listLatitude.RemoveAt(i);
                    listLongitude.RemoveAt(i);
                    listBox1.Items.RemoveAt(i);

                    returnDistanceTime();

                    teleportBtn.Enabled = false;
                    teleportBtn.BackColor = Color.Gray;
                    teleportBtn.Text = "Be Patient!";

                    timeLeftToTeleport.Text = t.ToString();
                    timeLeftToTeleport.ForeColor = Color.Red;
                }
                catch (Exception error)
                {
                    nextCoordinateTextBox.Text = "";
                    teleportBtn.Enabled = false;
                    teleportBtn.BackColor = Color.Gray;
                    teleportBtn.Text = "FINISHED!";
                    coordListBox.Enabled = true;
                    coordListBox.BackColor = Color.White;
                }
            }
            else
            {

            }

        }

        private void returnDistanceTime()
        {
            if (smallestDist <= 1)
            {
                timeSeconds = 30;

            }
            else if (smallestDist <= 5)
            {
                timeSeconds = 180;
            }
            else if (smallestDist <= 10)
            {
                timeSeconds = 420;
            }
            else if (smallestDist <= 25)
            {
                timeSeconds = 720;
            }
            else if (smallestDist <= 30)
            {
                timeSeconds = 900;
            }
            else if (smallestDist <= 65)
            {
                timeSeconds = 1380;
            }
            else if (smallestDist <= 81)
            {
                timeSeconds = 1560;
            }
            else if (smallestDist <= 100)
            {
                timeSeconds = 2160;
            }
            else if (smallestDist <= 250)
            {
                timeSeconds = 2760;
            }
            else if (smallestDist <= 500)
            {
                timeSeconds = 3660;
            }
            else if (smallestDist <= 750)
            {
                timeSeconds = 4740;
            }
            else if (smallestDist <= 1000)
            {
                timeSeconds = 5460;
            }
            else if (smallestDist <= 1500)
            {
                timeSeconds = 7260;
            }

            
        }

        private void moveNextCoordToCurrent()
        {
            nextCoordinateTextBox.Text = currentCoordinateTextBox.Text;
        }
        
        private void parseCoordinatesBtn_Click(object sender, EventArgs e)
        {
            coordsParser();
            coordListBox.Clear();
            checkBtnAvailable = true;
        }

        private void stopJoystickBtn_Click(object sender, EventArgs e)
        {
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " shell am start-foreground-service -a theappninjas.gpsjoystick.STOP";
            process.StartInfo = startInfo;
            process.Start();
            isServiceRunning = false;
        }

        //--> UI element setups end here <--//

        private void startService()
        {
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " shell am start-foreground-service -a theappninjas.gpsjoystick.STOP";
            process.StartInfo = startInfo;
            process.Start();
            process.Refresh();
            isServiceRunning = false;
            System.Threading.Thread.Sleep(adbWaitTime);

            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " shell am start-foreground-service -a theappninjas.gpsjoystick.TELEPORT --ef lat " + currentLat + " --ef lng " + currentLong.ToString() + " --ef alt 0.0";
            process.StartInfo = startInfo;
            process.Start();
            isServiceRunning = true;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            timeSeconds = 0;
            teleportBtn.Enabled = true;
            teleportBtn.BackColor = Color.LimeGreen;
            teleportBtn.Text = "TELEPORT!";
        }

        private void startCooldownBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void despawnBtn_Click(object sender, EventArgs e)
        {
            timeSeconds = 1;
            timer1.Start();
        }

        private void paypal_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=6EUUTZCVQNAU8&currency_code=EUR&source=url");
            MessageBox.Show("Paypal Donate Link Copied to clipboard for your convenience!");
        }

        private void etheriumPic_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("0xcd578a40a2397cf00d0c3757037652ae2ec0cb3f");
            MessageBox.Show("Etherium Wallet Copied to clipboard for your convenience!");
        }

        private void btcPic_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("35ejfs9GVr8j9sxYnjGcyQggURYZiAxc2o");
            MessageBox.Show("Bitcoin Wallet Copied to clipboard for your convenience!");
        }

        private void currentClipboardBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(currentCoordinateTextBox.Text);
        }

        private void calcDistBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://boulter.com/gps/distance/?from=&to=&units=k");
        }

        private void customTimerBtn_Click(object sender, EventArgs e)
        {
            int selectedCustomDistance = listBox2.SelectedIndex;

            switch (selectedCustomDistance) {
                case 0:
                    timeSeconds = 48;
                    timer1.Start();
                    break;
                case 1:
                    timeSeconds = 60;
                    timer1.Start();
                    break;
                case 2:
                    timeSeconds = 120;
                    timer1.Start();
                    break;
                case 3:
                    timeSeconds = 120;
                    timer1.Start();
                    break;
                case 4:
                    timeSeconds = 180;
                    timer1.Start();
                    break;
                case 5:
                    timeSeconds = 240;
                    timer1.Start();
                    break;
                case 6:
                    timeSeconds = 360;
                    timer1.Start();
                    break;
                case 7:
                    timeSeconds = 480;
                    timer1.Start();
                    break;
                case 8:
                    timeSeconds = 660;
                    timer1.Start();
                    break;
                case 9:
                    timeSeconds = 840;
                    timer1.Start();
                    break;
                case 10:
                    timeSeconds = 1200;
                    timer1.Start();
                    break;
                case 11:
                    timeSeconds = 1380;
                    timer1.Start();
                    break;
                case 12:
                    timeSeconds = 1560;
                    timer1.Start();
                    break;
                case 13:
                    timeSeconds = 2160;
                    timer1.Start();
                    break;
                case 14:
                    timeSeconds = 2460;
                    timer1.Start();
                    break;
                case 15:
                    timeSeconds = 3660;
                    timer1.Start();
                    break;
                case 16:
                    timeSeconds = 4860;
                    timer1.Start();
                    break;
                case 17:
                    timeSeconds = 6060;
                    timer1.Start();
                    break;
                case 18:
                    timeSeconds = 6900;
                    timer1.Start();
                    break;
                case 19:
                    timeSeconds = 7200;
                    timer1.Start();
                    break;
                default:
                    MessageBox.Show("If you want to use the custom timer function, select a distance from the list and THEN press the button!");
                    break;
            }



            

        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (adbWaitTime != 1000) {
                adbWaitTime -= 1000;
                adbTime.Text = (adbWaitTime / 1000).ToString() + " sec";
            }
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            if (adbWaitTime != 10000)
            {
                adbWaitTime += 1000;
                adbTime.Text = (adbWaitTime / 1000).ToString() + " sec";
            }
        }

        private void nextClipboardBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(nextCoordinateTextBox.Text);
        }

        private void appForm_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            paypalPic.ImageLocation = "https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif";
            etheriumPic.ImageLocation = "https://geth.ethereum.org/static/images/ethereum.png";
            btcPic.ImageLocation = "https://en.bitcoin.it/w/images/en/2/29/BC_Logo_.png";

            notifyIcon1.Text = "Pokemon Go Teleporter";
            notifyIcon1.Visible = true;

            teleportBtn.Enabled = false;
            teleportBtn.BackColor = Color.Gray;
            teleportBtn.Text = "TELEPORT!";

            toolTip1.AutoPopDelay = 30000;
            toolTip1.InitialDelay = 250;
            toolTip1.ReshowDelay = 0;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.label7, "Enter coordinates latitude and longitude, separated by commas, and each coordinate in a new line.");
            toolTip1.SetToolTip(this.label8, "Press the \"Parse coordinates\" button");
            toolTip1.SetToolTip(this.label9, "Press the \"TELEPORT!\" button to teleport to the coordinate in the \"Next Coordinate\" field.");
            toolTip1.SetToolTip(this.label10, "After you have catched the 'Mon, or it fled, press the \"Start Cooldown Counter\" button to start the cooldown until you can safely teleport to the next location.");
            toolTip1.SetToolTip(this.label11, "Press this button if the 'Mon despawned or you did not interact with anything at the location and want to move to the next coordinate.");


            adbTime.Text = (adbWaitTime / 1000).ToString() + " sec";


            MessageBox.Show("DISCLAIMER: I am not responsible for any damage this app may cause you, including, but not limited to softbans, literal bans, thermonuclear war and kittys dying. If you do not agree, please close this program and forget about it's existence.");
        }

        //Coordinate parsing
        private void coordsParser()
        {
            //Pre-parsing
            tempCurrentCoords = coordListBox.Text;
            tempCurrentCoords = tempCurrentCoords.Replace(" ", String.Empty);
            tempCurrentCoords = tempCurrentCoords.Replace("\r", String.Empty);
            int tempCurrentCoordsChecker = (Regex.Matches(tempCurrentCoords, @"[a-zA-Z]").Count);

            //Check if there are any illegal characters
            if (tempCurrentCoords != "" && tempCurrentCoordsChecker == 0)
            {
                string[] splittedCoordinates = tempCurrentCoords.Split('\n');

                //Clear the listBox before adding stuff into it
                listBox1.Items.Clear();


                for (int i = 0; i < (splittedCoordinates.Length); i++)
                {
                    
                    //Continue splitting string
                    string[] splittedString = splittedCoordinates[i].Split(',');
                    latitudeFloat = Convert.ToSingle(splittedString[splittedString.Length - 2]);
                    longitudeFloat = Convert.ToSingle(splittedString[splittedString.Length - 1]);

                    listLatitude.Add(latitudeFloat);
                    listLongitude.Add(longitudeFloat);
                    
                    listBox1.Items.Add(latitudeFloat.ToString() + "," + longitudeFloat.ToString());
                }

                //Add the first coordinate to the upcoming coordinate text box
                currentLat = listLatitude[0];
                currentLong = listLongitude[0];
                nextCoordinateTextBox.Text = listBox1.GetItemText(listBox1.Items[0]);
                listBox1.Items.RemoveAt(0);
                listLatitude.RemoveAt(0);
                listLongitude.RemoveAt(0);

                teleportBtn.Enabled = true;
                teleportBtn.BackColor = Color.LimeGreen;
                teleportBtn.Text = "TELEPORT!";

                coordListBox.Enabled = false;
                coordListBox.BackColor = Color.Gray;


            }
            else if (tempCurrentCoordsChecker > 0)
            {
                MessageBox.Show("Remove Any letters and unconventional characters. Leave only numbers, comma and maybe dashes");
            }
        }


        /// <summary>
        /// TIMER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            t = TimeSpan.FromSeconds(timeSeconds);

            timeSeconds = (timeSeconds - 1);

            if (timeSeconds == 0)
            {
                //if the countdown reaches '0', we stop it
                timer1.Stop();
                teleportBtn.Enabled = true;
                teleportBtn.BackColor = Color.LimeGreen;
                teleportBtn.Text = "TELEPORT!";

                timeLeftToTeleport.Text = "Ready to Teleport!";
                timeLeftToTeleport.ForeColor = Color.Green;

                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipText = "You can teleport now!";
                notifyIcon1.BalloonTipTitle = "Pokemon Go Teleporter";

                notifyIcon1.ShowBalloonTip(5000);

            }
            else
            {
                teleportBtn.Enabled = false;
                teleportBtn.BackColor = Color.Gray;
                teleportBtn.Text = "Be Patient!";

                timeLeftToTeleport.Text = t.ToString();
                timeLeftToTeleport.ForeColor = Color.Red;
            }
        }

    }

    class ColoredItem
    {
        public string Text;
        public Color Color;
    };
}
