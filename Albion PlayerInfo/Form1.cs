using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Albion_PlayerInfo
{
    public partial class Form1 : Form
    {

        public static string Death_Player_URL = "";
        public static string Kill_Player_URL = "";
        public Form1()
        {
            InitializeComponent();
        }

        public static void Console_Debug(string output, string color)
        {
            var colors = new Dictionary<string, ConsoleColor>()
            {
                ["normal"] = ConsoleColor.White,
                ["warning"] = ConsoleColor.Yellow,
                ["error"] = ConsoleColor.Red
            };

            if (!colors.TryGetValue(color, out var variable)) return;

            Console.ForegroundColor = colors[color];
            Console.WriteLine("{0} DEBUG EVENT >> {1}", DateTime.Now.ToString("[HH:mm:ss]"), output);

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                label6.Text = "Loading...";
                var op = Api.GetPlayerInfoByName(textBox1.Text);
                var op2 = Api.GetPlayerDeaths(op.players[0].Id.ToString());
                var op3 = Api.GetPlayerKills(op.players[0].Id.ToString());
                label4.Text = op.players[0].AllianceName;
                label1.Text = op.players[0].GuildName;
                label2.Text = op.players[0].Name;
                label3.Text = op.players[0].KillFame.ToString("n0");
                Console_Debug(op2[0].EventId.ToString(), "normal");
                Console_Debug(op2[0].EventId.ToString(), "nosrmal");
                DateTime d2 = DateTime.Parse(op2[0].TimeStamp.ToString(), null, System.Globalization.DateTimeStyles.RoundtripKind);
                DateTime d3 = DateTime.Parse(op3[0].TimeStamp.ToString(), null, System.Globalization.DateTimeStyles.RoundtripKind);
                Console_Debug(op3[0].EventId.ToString(), "normal");
                label5.Text = String.Format("{3} {0} - {1} - {2} - IP: {4} - A: {5}", op2[0].killer.Name, d2.AddHours(-3).ToString("dd/MM/yyyy HH:mm:ss"), "", op2[0].killer.GuildName == "" ? "" : "["  + op2[0].killer.GuildName + "]", op2[0].killer.AverageItemPower.ToString("n0"), op2[0].Participants.Count);
                label7.Text = String.Format("{3} {0} - {1} - {2} - IP: {4} - A: {5}", op3[0].victim.Name, d3.AddHours(-3).ToString("dd/MM/yyyy HH:mm:ss"), "", op3[0].victim.GuildName == "" ? "" : "["  + op3[0].victim.GuildName + "]", op3[0].victim.AverageItemPower.ToString("n0"), op3[0].Participants.Count);
                Death_Player_URL = "https://albiononline.com/killboard/kill/" + op2[0].EventId.ToString();
                Kill_Player_URL = "https://albiononline.com/killboard/kill/" + op3[0].EventId.ToString();
                label6.Text = String.Empty;
            }
            catch(Exception E)
            {
                Console_Debug(E.Message, "error");
            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Death_Player_URL == string.Empty) return;

            try
            {

                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = Death_Player_URL,
                    UseShellExecute = true
                });
                //Process.Start("chrome", Death_Player_URL);
            }
            catch(Exception E)
            {

                MessageBox.Show(E.Message);

            }

        }

        public void VisitLink(string url)
        {
  
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            button1_Click(sender, e);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Kill_Player_URL == string.Empty) return;

            try
            {

                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = Kill_Player_URL,
                    UseShellExecute = true
                });
                //Process.Start("chrome", Death_Player_URL);
            }
            catch (Exception E)
            {

                Console_Debug(E.Message, "error");

            }
        }
    }
}