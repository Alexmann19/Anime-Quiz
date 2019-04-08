using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anime_Quiz
{
    public partial class Form1 : Form
    {
        public static int game = 1;
        public static int answer = 0;
        public static int youranswer = -1;
        public static int punkte = 0;
        public static int weiter = 0;
        public static string richtig = "";
        public static int punktea = 0;

        public Form1()
        {
            InitializeComponent();
            tbnummer.Text = "1";
            tbanime.Text = "Pretty Cure";
            rtbfrage.Text = "Welche Pretty Cure ist die erste die in Heartcatch Precure erwacht?";
            tba.Text = "Cure Black";
            tbb.Text = "Cure Sunshine";
            tbc.Text = "Cure Blossom";
            tbd.Text = "Cure Whip";
            answer = 3;
            punkte = 5;
            weiter = 2;
            richtig = tbc.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rba.Checked == true)
            {
                youranswer = 1;
            }
            else
            if (rbb.Checked == true)
            {
                youranswer = 2;
            }
            else
            if (rbc.Checked == true)
            {
                youranswer = 3;
            }
            else
            if (rbd.Checked == true)
            {
                youranswer = 4;
            }
            else
            {
                MessageBox.Show("Keine Antwort gewählt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (answer == youranswer)
            {
                punktea = punktea + punkte;
                tbpunkte.Text = Convert.ToString(punktea);
                MessageBox.Show("Richtige Antwort", "Richtig", MessageBoxButtons.OK, MessageBoxIcon.Information);
                game = weiter;
            }
            else
            {
                MessageBox.Show("Falsche Antwort", "Falsch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Richtig ist: " + richtig, "Antwort", MessageBoxButtons.OK, MessageBoxIcon.Information);
                game = weiter;
            }

            

                switch (game)
            {
                case 1:
                    tbnummer.Text = "1";
                    tbanime.Text = "Pretty Cure";
                    rtbfrage.Text = "Welche Pretty Cure ist die erste die in Heartcatch Precure erwacht?";
                    tba.Text = "Cure Black";
                    tbb.Text = "Cure Sunshine";
                    tbc.Text = "Cure Blossom";
                    tbd.Text = "Cure Whip";
                    answer = 3;
                    punkte = 5;
                    weiter = 2;
                    richtig = tbc.Text;
                    break;

                case 2:
                    tbnummer.Text = "2";
                    tbanime.Text = "Pretty Cure";
                    rtbfrage.Text = "Welche Precure hat Baron Salamander im Heartchatch Precure Film versiegelt?";
                    tba.Text = "Cure White";
                    tbb.Text = "Cure Ange";
                    tbc.Text = "Cure Egret";
                    tbd.Text = "Cure Moonlight";
                    answer = 2;
                    punkte = 20;
                    weiter = 3;
                    richtig = tbb.Text;
                    break;

                case 3:
                    tbnummer.Text = "3";
                    tbanime.Text = "Pretty Cure";
                    rtbfrage.Text = "Wie heist die erste Attake aus der ersten Pretty Cure Staffel (Deutsch)?";
                    tba.Text = "Marmorstrahl";
                    tbb.Text = "Regenbogenorkan";
                    tbc.Text = "Hyperstahl";
                    tbd.Text = "Macht des Lichts";
                    answer = 1;
                    punkte = 10;
                    weiter = 4;
                    richtig = tba.Text;
                    break;

                case 4:
                    tbnummer.Text = "4";
                    tbanime.Text = "Pretty Cure";
                    rtbfrage.Text = "Welche von diesen Pretty Cure ist nach der Verwandlung erwachsen?";
                    tba.Text = "Cure Heart";
                    tbb.Text = "Cure Mint";
                    tbc.Text = "Cure Star";
                    tbd.Text = "Cure Ace";
                    answer = 4;
                    punkte = 10;
                    weiter = 5;
                    richtig = tbd.Text;
                    break;

                case 5:
                    tbnummer.Text = "5";
                    tbanime.Text = "Pretty Cure";
                    rtbfrage.Text = "Wie heist die Pretty Cure Staffel die anfang 2019 rauskam?";
                    tba.Text = "Precure Max Heart";
                    tbb.Text = "Star☆Twinkle Pretty Cure";
                    tbc.Text = "Heartcatch Precure";
                    tbd.Text = "Yes Precure 5 Go Go";
                    answer = 2;
                    punkte = 15;
                    weiter = 6;
                    richtig = tbb.Text;
                    break;

                case 6:
                    tbnummer.Text = "6";
                    tbanime.Text = "Pokemon";
                    rtbfrage.Text = "Wie heist der \"Gott\" der Pokemon (Stand 2019)?";
                    tba.Text = "Arceus";
                    tbb.Text = "Pikachu";
                    tbc.Text = "Dialga";
                    tbd.Text = "Mew Two";
                    answer = 1;
                    punkte = 5;
                    weiter = 7;
                    richtig = tba.Text;
                    break;

                case 7:
                    tbnummer.Text = "7";
                    tbanime.Text = "Pokemon";
                    rtbfrage.Text = "Welches Pokemon hat 8 verschiedene Entwicklungen?";
                    tba.Text = "Mauzi";
                    tbb.Text = "Evoli";
                    tbc.Text = "Bisasam";
                    tbd.Text = "Gelatini";
                    answer = 2;
                    punkte = 5;
                    weiter = 8;
                    richtig = tbb.Text;
                    break;

                case 8:
                    tbnummer.Text = "8";
                    tbanime.Text = "Pokemon";
                    rtbfrage.Text = "Welches Pokemon ist sogar im Uber Tier gebannt?";
                    tba.Text = "Dragoran";
                    tbb.Text = "Arceus";
                    tbc.Text = "Mew Two";
                    tbd.Text = "Mega-Rayquaza";
                    answer = 4;
                    punkte = 15;
                    weiter = 9;
                    richtig = tbd.Text;
                    break;

                case 9:
                    tbnummer.Text = "9";
                    tbanime.Text = "Pokemon";
                    rtbfrage.Text = "Wie heist der Wasserstarter aus Sinnoh?";
                    tba.Text = "Plinfa";
                    tbb.Text = "Karnimarni";
                    tbc.Text = "Schiggi";
                    tbd.Text = "Froxy";
                    answer = 1;
                    punkte = 15;
                    weiter = 10;
                    richtig = tba.Text;
                    break;

                case 10:
                    tbnummer.Text = "10";
                    tbanime.Text = "Pokemon";
                    rtbfrage.Text = "In welcher Region spielt die 7. Generation?";
                    tba.Text = "Sinnoh";
                    tbb.Text = "Johto";
                    tbc.Text = "Hoenn";
                    tbd.Text = "Alola";
                    answer = 4;
                    punkte = 15;
                    weiter = 11;
                    richtig = tbd.Text;
                    break;

                case 11:
                    tbnummer.Text = "11";
                    tbanime.Text = "Sailor Moon";
                    rtbfrage.Text = "Wie heist der letzte Gegner der Serie?";
                    tba.Text = "Metalia";
                    tbb.Text = "Köigen Beryl";
                    tbc.Text = "Sailor Galaxia";
                    tbd.Text = "Black Lady";
                    answer = 3;
                    punkte = 10;
                    weiter = 12;
                    richtig = tbc.Text;
                    break;

                case 12:
                    tbnummer.Text = "12";
                    tbanime.Text = "Sailor Moon";
                    rtbfrage.Text = "Wie heist die Sailor Kriegerin der Stille bzw. des Lebens?";
                    tba.Text = "Sailor Uranus";
                    tbb.Text = "Sailor Saturn";
                    tbc.Text = "Sailor Neptun";
                    tbd.Text = "Sailor Pluto";
                    answer = 2;
                    punkte = 20;
                    weiter = 13;
                    richtig = tbb.Text;
                    break;

                case 13:
                    tbnummer.Text = "13";
                    tbanime.Text = "Sailor Moon";
                    rtbfrage.Text = "Wie heist der Pegasus in der Dead Moon Staffel?";
                    tba.Text = "Helios";
                    tbb.Text = "Jedite";
                    tbc.Text = "Prince Diamond";
                    tbd.Text = "Pegasus";
                    answer = 1;
                    punkte = 15;
                    weiter = 14;
                    richtig = tba.Text;
                    break;

                case 14:
                    tbnummer.Text = "14";
                    tbanime.Text = "Sailor Moon";
                    rtbfrage.Text = "Wie heist die mächtigste Waffe der ersten Staffel?";
                    tba.Text = "Mondstein";
                    tbb.Text = "Mondstab";
                    tbc.Text = "Schwert des Vollmonds";
                    tbd.Text = "Magischer Silberkristall";
                    answer = 4;
                    punkte = 10;
                    weiter = 15;
                    richtig = tbd.Text;
                    break;

                case 15:
                    tbnummer.Text = "15";
                    tbanime.Text = "Sailor Moon";
                    rtbfrage.Text = "Wie heisen die 3 Verbündeten die in der letzten Staffel hinzu kommen?";
                    tba.Text = "Die dreisten Drei";
                    tbb.Text = "Das Trio des Lichts";
                    tbc.Text = "Starlights";
                    tbd.Text = "Der Bund der Mächtigen";
                    answer = 3;
                    punkte = 15;
                    weiter = 16;
                    richtig = tbc.Text;
                    break;

                case 16:
                    tbnummer.Text = "-";
                    tbanime.Text = "-";
                    rtbfrage.Text = "-";
                    tba.Text = "-";
                    tbb.Text = "-";
                    tbc.Text = "-";
                    tbd.Text = "-";

                    string punktes = Convert.ToString(punktea);
                    MessageBox.Show("Du hast " + punktes + " Punkte", "Ende", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (punktea <= 30)
                    {
                        MessageBox.Show("Du hast ja gar keine Ahnung, Schande über dich, du kannst ja nichtmal Boku no Piko von Dragonball unterscheiden!", "Bewertung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    if (punktea <= 70 & punktea > 30)
                    {
                        MessageBox.Show("Naja du bist ein Anime Neuling darauf kann man aufbauen!", "Bewertung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    if (punktea <= 130 & punktea > 70)
                    {
                        MessageBox.Show("Du kennst dich ja schon sehr gut mit Animes aus, spitze!", "Bewertung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    if (punktea < 185 & punktea > 130)
                    {
                        MessageBox.Show("Bei den sieben Dragonballs, du bist ja ein richtiger Anime Experte - es ist aber noch Luft nach oben!", "Bewertung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    if (punktea == 185)
                    {
                        MessageBox.Show("D..D..Du bist einfach perfekt, du bist der größte Anime Meister der ganzen Welt!", "Bewertung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                    break;


                default:
                    tbnummer.Text = "N/A";
                    tbanime.Text = "N/A";
                    rtbfrage.Text = "Error";
                    tba.Text = "Error";
                    tbb.Text = "Error";
                    tbc.Text = "Error";
                    tbd.Text = "Error";
                    answer = 0;
                    punkte = 0;
                    weiter = 1;
                    richtig = "N/A";
                    break;


            }
        }

    }
}
