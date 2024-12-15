using Pastel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.IO;

namespace text_based_adventure_game
{
    class graphics_settings
    {
        public void display_bp()
        {
            List<string> list = new List<string>
            {
                "██████╗░░█████╗░██████╗░████████╗░█████╗░███╗░░██╗  ██████╗░███████╗██╗░░░██╗███████╗██████╗░██╗██╗░░░░░",
                "██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝██╔══██╗████╗░██║  ██╔══██╗██╔════╝██║░░░██║██╔════╝██╔══██╗██║██║░░░░░",
                "██████╦╝███████║██████╔╝░░░██║░░░██║░░██║██╔██╗██║  ██████╔╝█████╗░░╚██╗░██╔╝█████╗░░██████╔╝██║██║░░░░░",
                "██╔══██╗██╔══██║██╔══██╗░░░██║░░░██║░░██║██║╚████║  ██╔═══╝░██╔══╝░░░╚████╔╝░██╔══╝░░██╔══██╗██║██║░░░░░",
                "██████╦╝██║░░██║██║░░██║░░░██║░░░╚█████╔╝██║░╚███║  ██║░░░░░███████╗░░╚██╔╝░░███████╗██║░░██║██║███████╗",
                "╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚══╝  ╚═╝░░░░░╚══════╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝╚══════╝",
                "                ░░░░░░  ████████╗██╗░░██╗███████╗  ░██████╗░░█████╗░███╗░░░███╗███████╗                 ",
                "                ░░░░░░  ╚══██╔══╝██║░░██║██╔════╝  ██╔════╝░██╔══██╗████╗░████║██╔════╝                 ",
                "                █████╗  ░░░██║░░░███████║█████╗░░  ██║░░██╗░███████║██╔████╔██║█████╗░░                 ",
                "                ╚════╝  ░░░██║░░░██╔══██║██╔══╝░░  ██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░                 ",
                "                ░░░░░░  ░░░██║░░░██║░░██║███████╗  ╚██████╔╝██║░░██║██║░╚═╝░██║███████╗                 ",
                "                ░░░░░░  ░░░╚═╝░░░╚═╝░░╚═╝╚══════╝  ░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝                 "
            };

            Console.CursorTop = 1;
            Console.CursorLeft = 3;
            foreach (string item in list)
            {
                Console.Write(item);
                Console.CursorTop++;
                Console.CursorLeft = 3;
            }
        }
        public void display_testing()
        {
            List<string> list = new List<string> {
                "▀█▀ █▀▀ █▀ ▀█▀ █ █▄░█ █▀▀   █ █▀   █░░ █▀▀ ▄▀█ █▀█ █▄░█ █ █▄░█ █▀▀",
                "░█░ ██▄ ▄█ ░█░ █ █░▀█ █▄█   █ ▄█   █▄▄ ██▄ █▀█ █▀▄ █░▀█ █ █░▀█ █▄█"
            };

            Console.CursorTop = 35;
            Console.CursorLeft = 163;
            foreach (string item in list)
            {
                Console.Write(item);
                Console.CursorTop++;
                Console.CursorLeft = 163;
            }
        }
        public void display_library()
        {
            List<string> list = new List<string>
            {
                "██╗░░░░░██╗██████╗░██████╗░░█████╗░██████╗░██╗░░░██╗",
                "██║░░░░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚██╗░██╔╝",
                "██║░░░░░██║██████╦╝██████╔╝███████║██████╔╝░╚████╔╝░",
                "██║░░░░░██║██╔══██╗██╔══██╗██╔══██║██╔══██╗░░╚██╔╝░░",
                "███████╗██║██████╦╝██║░░██║██║░░██║██║░░██║░░░██║░░░",
                "╚══════╝╚═╝╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░"
            };

            Console.CursorTop = 3;
            Console.CursorLeft = 10;
            foreach (string item in list)
            {
                Console.Write(item);
                Console.CursorTop++;
                Console.CursorLeft = 10;
            }

            // setup rest of library setting
            Random rnd_colours = new Random();

            Console.CursorTop = 61;
            Console.CursorLeft = 10;
            Console.Write($"{"                                                                                                                                                                                                                                                             ".PastelBg(Color.FromArgb(34, 40, 46))}");

            Console.CursorTop = 42;
            Console.CursorLeft = 215;
            Console.Write($"{"                                    ".PastelBg(Color.FromArgb(62, 39, 35))}");

            Console.CursorTop = 44;
            Console.CursorLeft = 218;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    List<int> new_colours = new List<int> { rnd_colours.Next(60, 200), rnd_colours.Next(60, 200), rnd_colours.Next(60, 200) };
                    Console.CursorTop--;
                    Console.Write($"{"  ".PastelBg(Color.FromArgb(new_colours[0], new_colours[1], new_colours[2]))}");
                    Console.CursorTop++;
                    Console.CursorLeft -= 2;
                    Console.Write($"{"  ".PastelBg(Color.FromArgb(new_colours[0], new_colours[1], new_colours[2]))}");
                    Console.CursorLeft += 2;
                }
                Console.CursorTop++;
                Console.CursorLeft = 217;
                Console.Write($"{"                                ".PastelBg(Color.FromArgb(62, 39, 35))}");
                Console.CursorTop += 2;
                Console.CursorLeft = 218;
            }

            Console.CursorTop = 60;
            Console.CursorLeft = 215;
            Console.Write($"{"                                    ".PastelBg(Color.FromArgb(62, 39, 35))}");

            Console.CursorTop = 42;
            Console.CursorLeft = 147;
            Console.Write($"{"                                    ".PastelBg(Color.FromArgb(62, 39, 35))}");

            Console.CursorTop = 44;
            Console.CursorLeft = 150;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    List<int> new_colours = new List<int> { rnd_colours.Next(0, 256), rnd_colours.Next(0, 256), rnd_colours.Next(0, 256) };
                    Console.CursorTop--;
                    Console.Write($"{"  ".PastelBg(Color.FromArgb(new_colours[0], new_colours[1], new_colours[2]))}");
                    Console.CursorTop++;
                    Console.CursorLeft -= 2;
                    Console.Write($"{"  ".PastelBg(Color.FromArgb(new_colours[0], new_colours[1], new_colours[2]))}");
                    Console.CursorLeft += 2;
                }
                Console.CursorTop++;
                Console.CursorLeft = 149;
                Console.Write($"{"                                ".PastelBg(Color.FromArgb(62, 39, 35))}");
                Console.CursorTop += 2;
                Console.CursorLeft = 150;
            }

            Console.CursorTop = 60;
            Console.CursorLeft = 147;
            Console.Write($"{"                                    ".PastelBg(Color.FromArgb(62, 39, 35))}");


            Console.CursorTop = 0;
        }
        public void display_gym()
        {
            List<string> list = new List<string>
            {
                "░██████╗░██╗░░░██╗███╗░░░███╗",
                "██╔════╝░╚██╗░██╔╝████╗░████║",
                "██║░░██╗░░╚████╔╝░██╔████╔██║",
                "██║░░╚██╗░░╚██╔╝░░██║╚██╔╝██║",
                "╚██████╔╝░░░██║░░░██║░╚═╝░██║",
                "░╚═════╝░░░░╚═╝░░░╚═╝░░░░░╚═╝"
            };

            Console.CursorTop = 3;
            Console.CursorLeft = 10;
            foreach (string item in list)
            {
                Console.Write(item);
                Console.CursorTop++;
                Console.CursorLeft = 10;
            }

            // setup rest of gym setting



            Console.CursorTop = 0;
        }
        public void display_menu()
        {
            List<string> list = new List<string>
            {

                "███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗",
                "████╗░████║██╔════╝████╗░██║██║░░░██║",
                "██╔████╔██║█████╗░░██╔██╗██║██║░░░██║",
                "██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║",
                "██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝",
                "╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░"
            };

            Console.CursorTop = 3;
            Console.CursorLeft = 10;
            foreach (string item in list)
            {
                Console.Write(item);
                Console.CursorTop++;
                Console.CursorLeft = 10;
            }
            Console.CursorTop = 0;
        }
        public void display_info()
        {
            List<string> list = new List<string>
            {

                "██╗███╗░░██╗███████╗░█████╗░",
                "██║██╔██╗██║█████╗░░██║░░██║",
                "██║██║╚████║██╔══╝░░██║░░██║",
                "██║██║░╚███║██║░░░░░╚█████╔╝",
                "╚═╝╚═╝░░╚══╝╚═╝░░░░░░╚════╝░"
            };
            Console.CursorTop = 3;
            Console.CursorLeft = 195;
            foreach (string item in list)
            {
                Console.Write(item);
                Console.CursorTop++;
                Console.CursorLeft = 195;
            }
            Console.CursorTop = 0;
        }
        public void display_won()
        {
            List<string> list = new List<string>
            {
                "░██╗░░░░░░░██╗██╗███╗░░██╗███╗░░██╗███████╗██████╗░",
                "░██║░░██╗░░██║██║████╗░██║████╗░██║██╔════╝██╔══██╗",
                "░╚██╗████╗██╔╝██║██╔██╗██║██╔██╗██║█████╗░░██████╔╝",
                "░░████╔═████║░██║██║╚████║██║╚████║██╔══╝░░██╔══██╗",
                "░░╚██╔╝░╚██╔╝░██║██║░╚███║██║░╚███║███████╗██║░░██║",
                "░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚══╝╚══════╝╚═╝░░╚═╝"
            };
            Console.CursorTop = 3;
            Console.CursorLeft = 130;
            foreach (string item in list)
            {
                Console.Write(item);
                Console.CursorTop++;
                Console.CursorLeft = 130;
            }
            Console.CursorTop = 0;
        }
        public void display_student()
        {
            List<string> list = new List<string>
            {
                
                "█▀ ▀█▀ █░█ █▀▄ █▀▀ █▄░█ ▀█▀",
                "▄█ ░█░ █▄█ █▄▀ ██▄ █░▀█ ░█░"
            };

            Console.CursorTop = 17;
            Console.CursorLeft = 90;
            foreach (string item in list)
            {
                Console.Write(item);
                Console.CursorTop++;
                Console.CursorLeft = 150;
            }
            Console.CursorTop = 0;
        }
        public void clear_text()
        {
            Console.CursorTop = 0;
            for (int j = 0; j < 102; j++)
            {
                Console.CursorLeft = 194;
                for (int i = 194; i < 307; i++)
                {
                    Console.Write($"{" ".PastelBg(Color.FromArgb(54, 71, 61))}");
                }
                Console.CursorTop++;
            }
            Console.CursorTop = 0;
        }
        public void background_colour()
        {
            Console.CursorTop = 0;
            for (int j = 0; j < 40; j++)
            {
                Console.CursorLeft = 0;
                for (int i = 0; i < 190; i++)
                {
                    Console.Write($"{" ".PastelBg(Color.FromArgb(66, 89, 78))}");
                }
                Console.CursorTop++;
            }
            Console.CursorTop = 0;
        }
        public void set_controls()
        {
            Console.CursorTop = 41;
            Console.CursorLeft = 0;
            for (int i = 40; i < 80; i++)
            {
                for (int j = 0; j < 190; j++)
                {
                    Console.Write($"{" ".PastelBg(Color.FromArgb(70, 70, 70))}");
                }
                Console.CursorTop++;
                Console.CursorLeft = 0;
            }
        }
        public void set_game_display()
        {
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 190; j++)
                {
                    Console.Write($"{" ".PastelBg(Color.FromArgb(54, 71, 61))}");
                }
            }
        }
        public void set_script()
        {
            Console.CursorTop = 0;
            Console.CursorLeft = 191;
            for (int i = 0; i < 80; i++)
            {
                for (int j = 191; j < 310; j++)
                {
                    Console.Write($"{" ".PastelBg(Color.FromArgb(54, 71, 61))}");
                }
                Console.CursorTop++;
                Console.CursorLeft = 191;
            }
            Console.CursorTop = 0;
        }
        public void seperator_vertical(int x)
        {
            Console.CursorTop = 0;
            Console.CursorLeft = x;
            for (int i = 0; i < 71; i++)
            {
                Console.Write("|");
                Console.CursorTop++;
                Console.CursorLeft = x;
            }

        }
        public void seperator_horizontal(int x)
        {
            Console.CursorTop = x;
            Console.CursorLeft = 0;
            for (int i = 0; i < 191; i++)
            {
                Console.Write("*");
                Console.CursorTop = x;
            }
        }
        public void main_format(int r, int g, int b)
        {
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            for (int i = 0; i < 102; i++)
            {
                for (int j = 0; j < 155; j++)
                {
                    Console.Write($"{"  ".PastelBg(Color.FromArgb(r, g, b))}");
                }
                Console.WriteLine();
            }
        }
        public void display_health(character player)
        {

            Console.CursorTop = 16;
            Console.CursorLeft = 24;
            if (player.health > 69)
            {
                Console.Write($"{"                   ".PastelBg(Color.FromArgb(51, 125, 71))}");
                Console.CursorTop = 16;
                Console.CursorLeft = 32;
                Console.Write($"{(player.health) + "".PastelBg(Color.FromArgb(51, 125, 71))}");
            }
            else if (player.health > 34)
            {
                Console.Write($"{"                   ".PastelBg(Color.FromArgb(232, 237, 83))}");
                Console.CursorTop = 16;
                Console.CursorLeft = 32;
                Console.Write($"{(player.health) + "".PastelBg(Color.FromArgb(232, 237, 83))}");
            }
            else
            {
                Console.Write($"{"                   ".PastelBg(Color.FromArgb(179, 18, 44))}");
                Console.CursorTop = 16;
                Console.CursorLeft = 32;
                Console.Write($"{(player.health) + "".PastelBg(Color.FromArgb(179, 18, 44))}");
            }
        }
        public void display_health_C(enemy Chris)
        {
            Console.CursorTop = 28;
            Console.CursorLeft = 147;

            if (Chris.health > 69)
            {
                Console.Write($"{"                   ".PastelBg(Color.FromArgb(51, 125, 71))}");
                Console.CursorTop = 28;
                Console.CursorLeft = 155;
                Console.Write($"{(Chris.health) + "".PastelBg(Color.FromArgb(51, 125, 71))}");
            }
            else if (Chris.health > 34)
            {
                Console.Write($"{"                   ".PastelBg(Color.FromArgb(232, 237, 83))}");
                Console.CursorTop = 28;
                Console.CursorLeft = 155;
                Console.Write($"{(Chris.health) + "".PastelBg(Color.FromArgb(232, 237, 83))}");
            }
            else
            {
                Console.Write($"{"                   ".PastelBg(Color.FromArgb(179, 18, 44))}");
                Console.CursorTop = 28;
                Console.CursorLeft = 155;
                Console.Write($"{(Chris.health) + "".PastelBg(Color.FromArgb(179, 18, 44))}");
            }
        }
        public void text_box(int x, int y, string words, int desired_length)
        {
            Console.CursorVisible = false;
            string[] word = words.Split(' ');
            int value_length = 0; int counter = 0; double v = words.Length / desired_length;

            Console.CursorTop = y;
            for (int i = 0; i <= Math.Ceiling(v) + 1; i++)
            {
                Console.CursorLeft = x;
                for (int j = 0; j < desired_length - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.CursorTop++;
                Console.CursorLeft = x;
            }

            Console.CursorTop = y; Console.CursorLeft = x;
            foreach (string item in word)
            {
                if (value_length + item.Length <= desired_length - 2)
                {
                    string new_item = item + " ";
                    value_length = value_length + new_item.Length;
                    Console.Write(new_item);
                }
                else
                {
                    Console.CursorTop++;
                    Console.CursorLeft = x;
                    value_length = 0; //something to do with the assigning of item to text we need 
                    counter++;

                    value_length += item.Length + 1;
                    Console.Write(item + " ");
                }
            }

            Console.CursorLeft = x - 1;
            for (int i = 0; i < desired_length; i++)
            {
                Console.CursorTop = y - 1;
                Console.Write("*");
            }

            Console.CursorLeft = x - 1;
            for (int i = 0; i < desired_length; i++)
            {
                Console.CursorTop = y + counter + 1;
                Console.Write("*");
            }

            Console.CursorTop = y;
            Console.CursorLeft = x - 1;
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i <= counter; i++)
                {
                    Console.Write("|");
                    if (j == 0)
                    {
                        Console.CursorTop++;
                        Console.CursorLeft = x - 1;
                    }
                    else
                    {
                        Console.CursorTop++;
                        Console.CursorLeft = x + desired_length - 2;
                    }
                }
                Console.CursorTop = y;
                Console.CursorLeft = x + desired_length - 2;
            }
            Console.CursorVisible = true;
        }
        public int menu_selection(List<string> options, Dictionary<string, string> option_positions, int axis, bool text, Dictionary<string, string[]> character_move_info)
        {
            Console.CursorVisible = false;

            foreach (string item in options)
            {
                int x_item = int.Parse(option_positions[item].Split(',')[0]);
                int y_item = int.Parse(option_positions[item].Split(',')[1]);

                Console.CursorTop = y_item;
                Console.CursorLeft = x_item;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(item);
            }

            string current_selection = options[0]; string current_pos = options[0];


            while (true)
            {

                if (axis == 0) // selection menu is horizontal
                {
                    int y = int.Parse((option_positions[current_selection]).Split(',')[1]) + 2;
                    double half_length = options[options.IndexOf(current_selection)].Length / 2;
                    int x = int.Parse((option_positions[current_selection]).Split(',')[0]) + (int)(Math.Ceiling(half_length));

                    if (text)
                    {
                        Console.ResetColor();
                        Console.CursorTop = int.Parse((option_positions[current_selection]).Split(',')[1]) + 4;
                        Console.CursorLeft = 10;
                        Console.Write($"{"                                                                                                                                                                                   ".PastelBg(Color.FromArgb(70, 70, 70))}");

                        Console.CursorTop = int.Parse((option_positions[current_selection]).Split(',')[1]) + 4;
                        Console.CursorLeft = 10;
                        Console.Write($"{character_move_info.ElementAt(options.IndexOf(current_selection)).Value[1].PastelBg(Color.FromArgb(70, 70, 70))}");
                    }

                    Console.CursorTop = y;
                    Console.CursorLeft = x;
                    while (!Console.KeyAvailable)
                    {
                        Console.CursorTop = y;
                        Console.CursorLeft = x;
                        Console.Beep();
                        Console.Write($"{"^".PastelBg(Color.FromArgb(70, 70, 70))}");
                        Thread.Sleep(300);
                        Console.CursorTop = y;
                        Console.CursorLeft = x;
                        Console.Write($"{" ".PastelBg(Color.FromArgb(70, 70, 70))}");
                    }

                    ConsoleKey keypressed = Console.ReadKey(false).Key;

                    if (keypressed == ConsoleKey.LeftArrow || keypressed == ConsoleKey.A)
                    {
                        try
                        {  // use a try method to catch the exception that it doesnt work
                            int previous = options.IndexOf(current_selection);
                            current_selection = options[previous - 1];

                            if (text)
                            {
                                Console.ResetColor();
                                Console.CursorTop = int.Parse((option_positions[current_selection]).Split(',')[1]) + 4;
                                Console.CursorLeft = 10;
                                Console.Write($"{"                                                                                                                                                                                   ".PastelBg(Color.FromArgb(70, 70, 70))}");
                                Console.CursorTop = int.Parse((option_positions[current_selection]).Split(',')[1]) + 4;
                                Console.CursorLeft = 10;
                                Console.Write($"{character_move_info.ElementAt(options.IndexOf(current_selection)).Value[1].PastelBg(Color.FromArgb(70, 70, 70))}");
                            }
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            continue;
                        }
                    }
                    if (keypressed == ConsoleKey.RightArrow || keypressed == ConsoleKey.D)
                    {
                        try
                        {  // use a try method to catch the exception that it doesnt work
                            int previous = options.IndexOf(current_selection);
                            current_selection = options[previous + 1];

                            if (text)
                            {
                                Console.ResetColor();
                                Console.CursorTop = int.Parse((option_positions[current_selection]).Split(',')[1]) + 4;
                                Console.CursorLeft = 10;
                                Console.Write($"{"                                                                                                                                                                                   ".PastelBg(Color.FromArgb(70, 70, 70))}");
                                Console.CursorTop = int.Parse((option_positions[current_selection]).Split(',')[1]) + 4;
                                Console.CursorLeft = 10;
                                Console.Write($"{character_move_info.ElementAt(options.IndexOf(current_selection)).Value[1].PastelBg(Color.FromArgb(70, 70, 70))}");

                            }
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            continue;
                        }
                    }
                    if (keypressed == ConsoleKey.Enter)
                    {
                        Console.CursorTop = int.Parse((option_positions[current_selection]).Split(',')[1]) + 4;
                        Console.CursorLeft = 10;
                        return options.IndexOf(current_selection);
                    }
                }
                else if (axis == 1) // selection menu is vertical
                {
                    int y = int.Parse((option_positions[current_selection]).Split(',')[1]);
                    int x = int.Parse((option_positions[current_selection]).Split(',')[0]) + options[options.IndexOf(current_selection)].Length + 2;

                    if (text)
                    {
                        Console.ResetColor();
                        Console.CursorTop = int.Parse((option_positions[current_selection]).Split(',')[1]) + 4;
                        Console.CursorLeft = 10;
                        Console.Write($"{"                                                                                                                                                                                   ".PastelBg(Color.FromArgb(70, 70, 70))}");
                        Console.CursorTop = int.Parse((option_positions[current_selection]).Split(',')[1]) + 4;
                        Console.CursorLeft = 10;
                        Console.Write($"{character_move_info.ElementAt(options.IndexOf(current_selection)).Value[1].PastelBg(Color.FromArgb(70, 70, 70))}");
                    }

                    Console.CursorTop = y;
                    Console.CursorLeft = x;
                    while (!Console.KeyAvailable)
                    {
                        Console.CursorTop = y;
                        Console.CursorLeft = x;
                        Console.Beep();
                        Console.Write($"{"<".PastelBg(Color.FromArgb(70, 70, 70))}");
                        Thread.Sleep(300);
                        Console.CursorTop = y;
                        Console.CursorLeft = x;
                        Console.Write($"{" ".PastelBg(Color.FromArgb(70, 70, 70))}");
                    }

                    ConsoleKey keypressed = Console.ReadKey(false).Key;


                    if (keypressed == ConsoleKey.UpArrow || keypressed == ConsoleKey.W)
                    {
                        try
                        {  // use a try method to catch the exception that it doesnt work
                            int previous = options.IndexOf(current_selection);
                            current_selection = options[previous - 1];

                            if (text)
                            {
                                Console.ResetColor();
                                Console.CursorTop = int.Parse((option_positions[current_selection]).Split(',')[1]) + 4;
                                Console.CursorLeft = 10;
                                Console.Write($"{"                                                                                                                                                                                   ".PastelBg(Color.FromArgb(70, 70, 70))}");
                                Console.CursorTop = int.Parse((option_positions[current_selection]).Split(',')[1]) + 4;
                                Console.CursorLeft = 10;
                                Console.Write($"{character_move_info.ElementAt(options.IndexOf(current_selection)).Value[1].PastelBg(Color.FromArgb(70, 70, 70))}");
                            }
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            continue;
                        }
                    }
                    else if (keypressed == ConsoleKey.DownArrow || keypressed == ConsoleKey.S)
                    {
                        try
                        {  // use a try method to catch the exception that it doesnt work
                            int previous = options.IndexOf(current_selection);
                            current_selection = options[previous + 1];

                            if (text)
                            {
                                Console.ResetColor();
                                Console.CursorTop = int.Parse((option_positions[current_selection]).Split(',')[1]) + 4;
                                Console.CursorLeft = 10;
                                Console.Write($"{"                                                                                                                                                                                   ".PastelBg(Color.FromArgb(70, 70, 70))}");
                                Console.CursorTop = int.Parse((option_positions[current_selection]).Split(',')[1]) + 4;
                                Console.CursorLeft = 10;
                                Console.Write($"{character_move_info.ElementAt(options.IndexOf(current_selection)).Value[1].PastelBg(Color.FromArgb(70, 70, 70))}");
                            }
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            continue;
                        }
                    }
                    if (keypressed == ConsoleKey.Enter)
                    {
                        Console.CursorTop = int.Parse((option_positions[current_selection]).Split(',')[1]) + 4;
                        Console.CursorLeft = 10;
                        return options.IndexOf(current_selection);
                    }
                }
            }
        }
    }
    class enemy : moves // probably should move more things here
    {
        public int health = 100;

        public void print_enemy(int x, int y, string enemy)
        {
            Dictionary<char, string> grid_colours = new Dictionary<char, string>
            {
                    { '.', "66, 89, 78" },    // blank (gray)
                    { 'b', "0,0,0" },       // black
                    { 'y', "255,242,0" },   // yellow
                    { 'g', "158,158,158" }, // gray
                    { 'n', "47,54,153" },   // navy
                    { 'o', "255,126,0" },   // orange
                    { 'w', "255,255,255" }, // white
                    { 'c', "33,33,33" },    // coal
                    { 's', "255,219,172" }, // skin
                    { 'r', "248,68,52"},    // red
                    { 'f',  "252,60,4"}     // fire
            };

            string[] ChrisP = {
                ".....bbbbbbb.....",
                "...bbgyyyyygbb...",
                "..bggyyyyyyyggb..",
                "..bggyyyyyyyggb..",
                ".bnggyyyyyyyggnb.",
                ".bnggyyyyyyyggnb.",
                ".bnnccyyyyyygnnb.",
                ".bnccgccyyyynnnb.",
                ".bncggggcnyynnnbo",
                "bscggcgbcnnynnbsb",
                "bscgccccyyyynbosb",
                ".bocswbooocwbsob.",
                "..bsswbssscwssb..",
                "...osssssssss....",
                "...boossssssob...",
                "..brobooooobrrb..",
                ".orrobrgggrrrroo.",
                "bssbbrbwgwrrbossb",
                "bssbbrrbbrrrbbssb",
                ".bbbgbbggbbbgbbbb",
                "...bbnggbggnnb...",
                "...bggbbbbbggb...",
                "....bb.....bb...."
            };

            Dictionary<string, string[]> characters = new Dictionary<string, string[]> { { "Chris", ChrisP } };

            Console.CursorTop = y;
            Console.CursorLeft = x;
            foreach (string line in characters[enemy])
            {
                foreach (char character in line.Reverse())
                {
                    Console.Write($"{"  ".PastelBg(Color.FromArgb(int.Parse(grid_colours[character].Split(',')[0]), int.Parse(grid_colours[character].Split(',')[1]), int.Parse(grid_colours[character].Split(',')[2])))}");
                }
                Console.CursorTop++;
                Console.CursorLeft = x;
            }

        }

    }
    class moves
    {
        public Dictionary<string, string> move_info = new Dictionary<string, string>
        {
            { "Integration        ",  "Integration is a mathematical process used to find the area under a curve or to determine the total accumulation of a quantity \n          Attack move"},
            { "Differentiation    " , "Differentiation is a mathematical process used to find the rate at which a quantity changes \n          Attack move"},
            { "Binary             " , "01000010 01100001 01110011 01100101 00100000 00110010 00100000 01101110 01110101 01101101 01100010 01100101 01110010 00100000 01110011 01111001 01110011 01110100 01100101 01101101 \n          Attack move"},
            { "RPN                " , "Just put the operator anywhere \n          Attack move"},
            { "Overflow error     " , "Things just disappear \n          Special move"},
            { "Complex numbers    " , "Complex numbers are numbers that include both a real part and an imaginary part (Fake AHhhh numbers) \n          Attack move"},
            { "Numworks calculator" , "The worst calculator to ever exist ( Casio cg50 on top 🙏🙏) \n          Heal move"},
            { "Visual studio      " , "The greatest programming tool to ever exist \n          Heal move"},
            { "Google chromebook  " , "Deadly defense mechanism \n          Heal move"},
            { "Whiteboard         " , "The deadly 'who done it' weapon \n          Special move"},
            { "Python             " , "Does extra damage on Chris Palmer due to his fear of white space and indentation \n          Special move"},
            { "Polynomial divison " , "Synthetic division is superior to the grid method \n          Attack move"},
            { "Graph theory       " , "Prims algorithm is superior \n          Heal move"},
            { "Modulus            " , "Complex numbers and that \n          Attack move"},
            { "Bython             " , "Chris Palmers special move \n          Special move"}
        };
        public Dictionary<string, List<string>> questions = new Dictionary<string, List<string>>
        {
            { "Integration        " , new List<string> { "Integrate 3x^2dx between 1 and 4", "Integrate (4x^3−2x+5)dx between 0 and 2", "Integrate (2x+1)dx between 0 and 3", "Integrate sin(x)dx between −pi/2 and pi/2​", "Integrate cos(x)dx between 0 and pi", "Integrate (x+4)(x-3) between 1 and 3 simpliest form fraction" }},
            { "Binary             " , new List<string> { "1010 to decimal." , "1101 to decimal." , "10011 to decimal." , "11101 to decimal." , "101101 to decimal." }},
            { "RPN                " , new List<string> { "3 4 + 2 *" , "10 2 5 + *" , "7 3 - 4 *" , "6 3 2 * +", "8 4 / 5 +" }},
            { "Overflow error     " , new List<string> { "Input questions here" }},
            { "Complex numbers    " , new List<string> { "(2+3i)(2−3i)" ,"(4+5i)(4−5i)" , "(3+2i)(3−2i)" , "(6+i)(6−i)" , "(5+3i)(5−3i)" }},
            { "Numworks calculator" , new List<string> { "Input questions here" }},
            { "Visual studio      " , new List<string> { "Input questions here" }},
            { "Google chromebook  " , new List<string> { "Input questions here" }},
            { "Whiteboard         " , new List<string> { "Input questions here" }},
            { "Python             " , new List<string> { "Input questions here" }},
            { "Polynomial divison " , new List<string> { "2x^3−8x^2+10x−4 / 2x^2-4x+2" , "3x^3−12x^2+9x / 3x^2−9x" , "4x^3−12x^2+8x / 4x^2−8x" , "x^3+3x^2+3x+9 / x^2+3" }},
            { "Graph theory       " , new List<string> { "Input questions here" }},
            { "Modulus            " , new List<string> { "Modulus of 3+4i" , "Modulus of 6−8i", "Modulus of 5+12i", "Modulus of 7−24i", "Modulus of 9+12i" }},
            { "Bython             " , new List<string> { "Input questions here" }}
        };
        public Dictionary<string, List<string>> answers = new Dictionary<string, List<string>>
        {
            { "Integration        " , new List<string> { "63","22","12","0","0","-34/3" }},
            { "Binary             " , new List<string> { "10","13","19","29","45" }},
            { "RPN                " , new List<string> { "14","70","16","12","7" }},
            { "Overflow error     " , new List<string> { "" }},
            { "Complex numbers    " , new List<string> { "13","41","13","37","34" }},
            { "Numworks calculator" , new List<string> { "" }},
            { "Visual studio      " , new List<string> { "" }},
            { "Google chromebook  " , new List<string> { "" }},
            { "Whiteboard         " , new List<string> { "" }},
            { "Python             " , new List<string> { "" }},
            { "Polynomial divison " , new List<string> { "x-2", "x-1", "x-1", "x-3" }},
            { "Graph theory       " , new List<string> { "" }},
            { "Modulus            " , new List<string> { "5","10","13","25","15" }},
            { "Bython             " , new List<string> { "" }}
        };
    }
    class character : moves
    {
        public string name { get; set; }
        public int option { get; set; }
        public int health = 100;
        public string character_name { get; set; }
        public List<string> moves = new List<string>();
        public List<string> chris_moves = new List<string>();

        public Dictionary<string, string[]> character_move_info = new Dictionary<string, string[]>(); // string[] contains the damage at pos 0 and then the info about the move at pos 1
        public Dictionary<string, string[]> chris_move_info = new Dictionary<string, string[]>();
        public List<string> attack = new List<string> { "Integration        ", "Binary             ", "RPN                ", "Complex numbers    ", "Modulus            ", "Polynomial divison " };
        public List<string> defense = new List<string> { "Numworks calculator", "Visual studio      ", "Google chromebook  ", "Graph theory       " };
        public List<string> special_move = new List<string> { "Whiteboard         ", "Python             ", "Bython             ", "Overflow error     " };


        public void choose_moves()
        {
            Random moves_rnd = new Random();


            // assigning players moves
            moves.Add(attack[moves_rnd.Next(0, attack.Count)]);
            attack.Remove(moves[0]);

            moves.Add(attack[moves_rnd.Next(0, attack.Count)]);
            attack.Remove(moves[1]);
            moves.Add(attack[moves_rnd.Next(0, attack.Count)]);

            moves.Add(defense[moves_rnd.Next(0, defense.Count)]);

            moves.Add(special_move[moves_rnd.Next(0, special_move.Count)]);

            foreach (string move in moves)
            {
                int num = 0;
                if (defense.Contains(move))
                {
                    num = 8;
                }
                else if (special_move.Contains(move))
                {
                    num = 25;
                }
                else { num = 12; }
                string[] input_thing = new string[] { num.ToString(), move_info[move] };
                character_move_info.Add(move, input_thing);
            }

            // assigning chris's moves
            chris_moves.Add(attack[moves_rnd.Next(0, attack.Count)]);
            attack.Remove(chris_moves[0]);

            chris_moves.Add(attack[moves_rnd.Next(0, attack.Count)]);
            attack.Remove(chris_moves[1]);
            chris_moves.Add(attack[moves_rnd.Next(0, attack.Count)]);

            chris_moves.Add(defense[moves_rnd.Next(0, defense.Count)]);

            chris_moves.Add(special_move[moves_rnd.Next(0, special_move.Count)]);

            foreach (string move in chris_moves)
            {
                int num = 0;
                if (defense.Contains(move))
                {
                    num = 15;
                }
                else if (special_move.Contains(move))
                {
                    num = 35;
                }
                else { num = 25; }
                string[] input_thing = new string[] { num.ToString(), move_info[move] };
                chris_move_info.Add(move, input_thing);
            }
        }
        public string display_moves(graphics_settings scene, character player1)
        {

            Dictionary<string, string> option_positions = new Dictionary<string, string>
            {
                {moves[0], "10,45"},
                {moves[1], "44,45"},
                {moves[2], "78,45"},
                {moves[3], "114,45"},
                {moves[4], "154,45"}
            };

            for (int j = -1; j < 2; j += 2)
            {
                foreach (string pos in option_positions.Values)
                {
                    Console.CursorTop = int.Parse(pos.Split(',')[1]) + j;
                    Console.CursorLeft = int.Parse(pos.Split(',')[0]);
                    Console.ForegroundColor = ConsoleColor.Red;

                    for (int i = 0; i < 19; i++)
                    {
                        Console.Write("*");
                    }
                }
            }

            Console.ResetColor();
            Dictionary<string, string[]> character_move_info = player1.character_move_info;
            int option = scene.menu_selection(moves, option_positions, 0, true, character_move_info);
            string chosen_option = moves[option];
            return chosen_option;

        }
        public void print_character(int x, int y, string character_choice)
        {

            string[] charmander =
            {
                "....bbbb.........b...",
                "...bffffb.......brb..",
                "..bffffffb......brrb.",
                "..bffffffb......brrb.",
                ".bffffffffb....brrrrb",
                "bffffwbfffb....brryrb",
                "bffffbbffffb...bryyrb",
                "bffffbbffffb....bybb.",
                ".bffffffffffb...bfb..",
                "..bbfffffffffb.bffb..",
                "....bbbffbfffbbffb...",
                ".....byybfffffbffb...",
                ".....byyybbfffbfb....",
                "....bwbyyyffffbb.....",
                ".....bbbyyfffbb......",
                "........bbbfbb.......",
                ".........bwfwb.......",
                "..........bbbb......."
            };

            string[] person =
            {
                ".....bbbbbbb.....",
                "...bbgcccccgbb...",
                "..bggcccccccggb..",
                "..bggcccccccggb..",
                ".bnggcccccccggnb.",
                ".bnggcccccccggnb.",
                ".bnnccccccccgnnb.",
                ".bnccgccccnnnnb.",
                ".bncggggcnnnnnbo",
                "bscggcgbcnnnbnsb",
                "bscgccccnnnbosb",
                ".bocswbooocwbsob.",
                "..bsswbssscwssb..",
                "...osssssssss....",
                "...boossssssob...",
                "..brobooooobrrb..",
                ".orrobrgggrrrroo.",
                "bssbbrbwgwrrbossb",
                "bssbbrrbbrrrbbssb",
                ".bbbgbbggbbbgbbbb",
                "...bbnggbggnnb...",
                "...bggbbbbbggb...",
                "....bb.....bb...."
            };

            string[] frog =
            {
                "...bbb.....bbb...",
                "..bwwwb...bwwwb..",
                ".bwbbwwbbbwwbbwb.",
                ".bwbbwwlllwwbbwb.",
                ".bwwwwwlllwwwwwb.",
                "..bwwwlllllwwwb..",
                ".blllllllllllllb.",
                "bllblllllllllbllb",
                "blllbbbbbbbbblllb",
                ".blllllllllllllb.",
                "..bbblllllllbbb..",
                "...blllllllllb...",
                ".bblllllwlllllbb.",
                "blbllllwwwllllblb",
                "blllblbwwwblblllb",
                ".bbbwbwbbbwbwbbb."
            };


            Dictionary<char, string> grid_colours = new Dictionary<char, string>
            {
                    { '.', "70,70,70" },    // blank (gray)
                    { 'b', "0,0,0" },       // black
                    { 'y', "255,242,0" },   // yellow
                    { 'g', "158,158,158" }, // gray
                    { 'n', "47,54,153" },   // navy
                    { 'o', "255,126,0" },   // orange
                    { 'w', "255,255,255" }, // white
                    { 'c', "33,33,33" },    // coal
                    { 's', "255,219,172" }, // skin
                    { 'r', "248,68,52"},    // red
                    { 'f',  "252,60,4"},    // fire
                    { 'l',  "32, 214, 129"} // lime
            };

            Dictionary<string, string[]> characters = new Dictionary<string, string[]> { { "Charmander", charmander }, { "Person", person }, {"Frog",frog} };


            Console.CursorTop = y;
            Console.CursorLeft = x;

            foreach (string line in characters[character_choice])
            {
                foreach (char character in line.Reverse())
                {
                    if (character == '.')
                    {
                        Console.CursorLeft+=2;
                    }
                    else
                    {
                        Console.Write($"{"  ".PastelBg(Color.FromArgb(int.Parse(grid_colours[character].Split(',')[0]), int.Parse(grid_colours[character].Split(',')[1]), int.Parse(grid_colours[character].Split(',')[2])))}");
                    }
                }
                Console.CursorTop++;
                Console.CursorLeft = x;
            }
        }
    }
    internal class Program
    {
        static Dictionary<string, string[]> empty = new Dictionary<string, string[]>();
        static void Game(graphics_settings scene, character player1)
        {
            // blanking canvas
            scene.main_format(70,70,70);

            // character selection process
            Console.CursorTop = 0;
            List<string> options = new List<string> { "Charmander", "Person", "Frog" };
            Dictionary<string, string> option_positions = new Dictionary<string, string>
            {
                { "Charmander" , "35,40"},
                { "Person", "110,40"},
                { "Frog", "181,40"}
            };

            foreach (string option in option_positions.Keys)
            {
                player1.print_character(int.Parse(option_positions[option].Split(',')[0])-15, 10, option);
            }

            int choice = scene.menu_selection(options, option_positions, 0, false, empty);
            string character = options[choice];
            player1.character_name = character;
            // end

            scene.main_format(70, 70, 70);
            Console.CursorTop = 0;

            // call next phase
            battle(player1, scene, 0);
        }
        static void battle(character player1, graphics_settings scene, int time)
        {
            enemy Chris = new enemy();
            Chris.health = 100;


            // setting up the graphics
            scene.background_colour();
            player1.print_character(10, 20, player1.character_name);
            scene.display_health(player1);
            scene.seperator_vertical(190);
            scene.seperator_horizontal(40);
            scene.set_script();


            int text_y = 0;

            // choosing moves
            if (time == 0)
            {
                scene.text_box(195, 2, "Welcome to the introductory battle                                                                          Your skill moves are located at the bottom of the screeen, click one when its your turn to deal damage onto your opponent", 112);
                Thread.Sleep(3000);
                scene.text_box(195, 8, "A wild Chris Palmer spawned in...", 112);
                Chris.print_enemy(140, 2, "Chris");
                scene.display_health_C(Chris);
                Thread.Sleep(900);
                scene.text_box(195, 12, "Select a move to view its information and then click enter to confirm move", 112);
                player1.choose_moves();
                text_y = 16;
                Thread.Sleep(400);
            }
            else
            {
                // need to add a bit that displays the correct bit for the next battle
                player1.character_move_info.ElementAt(4).Value[0] = "25";
                Chris.print_enemy(140, 2, "Chris");
                scene.display_health_C(Chris);
                text_y = 2;
            }

            int battle_counter = 0;
            while (player1.health > 0 && Chris.health > 0)
            {
                Random damage_gen = new Random();
                Random rnd_move = new Random();

                if (battle_counter % 2 == 0)
                {
                    // outputing the moves
                    string chosen_move = player1.display_moves(scene, player1); double move_damage = 0.0;
                    if (player1.defense.Contains(chosen_move))
                    {
                        // player gets healed - move_damage is heal in this context

                        move_damage = damage_gen.Next(60, 101);
                        move_damage = ((move_damage / 100) * (int.Parse(player1.character_move_info[chosen_move][0]))); // move damage

                        scene.text_box(195, text_y, chosen_move + " healed you by " + Math.Ceiling(move_damage) + " hp!", 112);

                        if (player1.health + (int)Math.Ceiling(move_damage) > 300)
                        {
                            player1.health = 300;
                        }
                        else
                        {
                            player1.health = player1.health + (int)Math.Ceiling(move_damage);
                        }
                        scene.display_health(player1);
                    }
                    else
                    {
                        // game play
                        // selecting damage
                        move_damage = damage_gen.Next(60, 101);
                        move_damage = (move_damage / 100) * (int.Parse(player1.character_move_info[chosen_move][0])); // move damage

                        if (player1.moves.IndexOf(chosen_move) == 4)
                        {
                            player1.character_move_info[chosen_move][0] = "14";
                        }

                        scene.text_box(195, text_y, chosen_move + " dealt " + Math.Ceiling(move_damage) + " damage!", 112);

                        Chris.health = Chris.health - (int)Math.Ceiling(move_damage);
                        scene.display_health_C(Chris);
                    }
                }
                else
                {
                    // Chris's move
                    string chosen_move = player1.chris_moves[rnd_move.Next(0, player1.chris_moves.Count)];
                    string question = player1.questions[chosen_move][rnd_move.Next(0, player1.questions[chosen_move].Count)];
                    int pos = player1.questions[chosen_move].IndexOf(question);
                    string correct = player1.answers[chosen_move].ElementAt(pos);

                    if (player1.chris_moves.IndexOf(chosen_move) == 3)
                    {
                        double heal = damage_gen.Next(60, 101);
                        heal = ((heal / 100) * (int.Parse(player1.chris_move_info[chosen_move][0])));

                        if (Chris.health + (int)Math.Ceiling(heal) > 100)
                        {
                            Chris.health = 100;
                            Console.ForegroundColor = ConsoleColor.Red;
                            scene.text_box(195, text_y, "Chris healed by " + (int)Math.Ceiling(heal) + " hp!", 112);
                            Console.ResetColor();
                        }
                        else
                        {
                            Chris.health = Chris.health + (int)Math.Ceiling(heal);

                            Console.ForegroundColor = ConsoleColor.Red;
                            scene.text_box(195, text_y, "Chris healed by " + (int)Math.Ceiling(heal) + " hp!", 112);
                            Console.ResetColor();
                        }
                        scene.display_health_C(Chris);
                    }
                    else if (player1.chris_moves.IndexOf(chosen_move) == 0 || player1.chris_moves.IndexOf(chosen_move) == 1 || player1.chris_moves.IndexOf(chosen_move) == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        scene.text_box(195, text_y, "Chris used " + chosen_move + question, 112);
                        Console.ResetColor();

                        Console.CursorTop = text_y + 4;
                        Console.CursorLeft = 194;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Enter the answer here: ");
                        Console.ResetColor();

                        string final = "";
                        try
                        {
                            string answer = Console.ReadLine();
                            string[]ans_parts = answer.Split();
                            foreach (string parts in ans_parts)
                            {
                                final += parts;
                            }
                        }
                        catch (FormatException) { final = "0"; }

                        Console.CursorTop = text_y + 4;
                        Console.CursorLeft = 194;
                        Console.Write($"{"                                                      ".PastelBg(Color.FromArgb(54, 71, 61))}");

                        double move_damage = 0.0;
                        if (final == correct)
                        {
                            move_damage = damage_gen.Next(40, 81);
                        }
                        else
                        {
                            move_damage = damage_gen.Next(60, 101);
                        }

                        move_damage = (move_damage / 100) * (int.Parse(player1.chris_move_info[chosen_move][0])); // move damage

                        Console.ForegroundColor = ConsoleColor.Red;
                        scene.text_box(195, text_y, chosen_move + " dealt " + Math.Ceiling(move_damage) + " damage!", 112);
                        Console.ResetColor();

                        player1.health = player1.health - (int)Math.Ceiling(move_damage);

                        scene.display_health(player1);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        scene.text_box(195, text_y, "Chris used " + chosen_move + "It was very effective! -" + player1.chris_move_info[chosen_move][0] + " hp!", 112);
                        Console.ResetColor();

                        player1.health = player1.health - int.Parse(player1.chris_move_info[chosen_move][0]);

                        scene.display_health(player1);
                    }
                }
                text_y += 4;
                battle_counter++;

                if (text_y > 68)
                {
                    scene.clear_text();
                    text_y = 2;
                }

                Thread.Sleep(600);
            }
            if (player1.health <= 0)
            {
                scene.main_format(70, 70, 70);

                scene.display_menu();
                scene.text_box(10, 15, "You lost, where would you like to go next", 112);
                Thread.Sleep(300);

                List<string> options = new List<string> { "Library", "Gym", "Get the bus home" };
                Dictionary<string, string> option_positions = new Dictionary<string, string>
                {
                    {"Library", "10,20" },
                    {"Gym", "22,20"},
                    {"Get the bus home", "30,20"}
                };
                Dictionary<string, string[]> display_info = new Dictionary<string, string[]>
                {
                    {"Library", new string[] { "" , "Go to the library to increase your move damage"} },
                    {"Gym", new string[] { "" , "Go to the gym to increase health"} },
                    {"Get the bus home", new string[] {"" , "Give up and go home, Chris Palmer is too powerful" } }
                };
                int option = scene.menu_selection(options, option_positions, 0, true, display_info);
                string chosen_path = options[option];
                switch (chosen_path)
                {
                    case "Library":
                        library(scene, player1);
                        break;
                    case "Gym":
                        gym(scene, player1);
                        break;
                    case "Get the bus home":
                        System.Environment.Exit(0);
                        break;
                }
            }
            else if (Chris.health <= 0)
            {
                scene.main_format(70, 70, 70);
                scene.display_won();
                // add code to display ending information

                scene.display_student();
                player1.print_character(90,20,player1.character_name);
                Console.CursorTop = 20;
                Console.CursorLeft = 150;
                Console.Write($"{"Thank you for playing!!!".PastelBg(Color.FromArgb(70,70,70))}");
                Console.CursorTop = 0;

                Thread.Sleep(2200);

                scene.main_format(70,70,70);
                scene.display_bp();

                scene.text_box(20, 15, "Could you please leave a review", 70);

                Console.CursorTop = 20;
                Console.CursorLeft = 20;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.CursorTop = 26;
                Console.CursorLeft = 20;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("What rating out of 5 would you give? "); 
                string result = Console.ReadLine();

                Console.CursorTop = 32;
                Console.CursorLeft = 20;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Any other feedback? ");
                string feedback = Console.ReadLine();

                Console.CursorTop = 38;
                Console.CursorLeft = 20;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Thanks");
                // saving the information to a file

                string file = @"H:\My Drive\CS\Programming\Text base adventure\Text base adventure\Reviews.txt";
                string info = name + " " + result + " " + feedback;
                File.AppendAllText(file, Environment.NewLine + info);

                Thread.Sleep(3000);
                System.Environment.Exit(100);
            }
        }
        static void library(graphics_settings scene, character player1)
        {
            Debug.WriteLine("library");
            scene.main_format(70, 70, 70);
            scene.display_library();
            scene.display_testing();

            // add library functionality
            // increase move damage

            List<string> options = new List<string>
            {
                "Do practice questions"
            };
            Dictionary<string, string> option_positions = new Dictionary<string, string>
            {
                { "Do practice questions" , "90,48" }
            };
            player1.print_character(30, 43, player1.character_name);
            int option = scene.menu_selection(options, option_positions, 1, false, empty);
            string chosen = options[option];

            Console.CursorTop = 48;
            Console.CursorLeft = 90;
            Console.Write($"{"                          ".PastelBg(Color.FromArgb(70, 70, 70))}");

            switch (chosen)
            {
                case "Do practice questions":
                    Random rnd_question = new Random();
                    bool cont = true;
                    while (cont)
                    {
                        Console.CursorTop = 40;
                        Console.CursorLeft = 90;
                        Console.Write($"{"Select move to upgrade".PastelBg(Color.FromArgb(70, 70, 70))}");
                        List<string> possible_options = new List<string>
                        {
                                player1.moves[0],
                                player1.moves[1],
                                player1.moves[2]
                        };
                        Dictionary<string, string> move_options = new Dictionary<string, string>
                        {
                                { player1.moves[0] , "90,45" },
                                { player1.moves[1] , "90,48" },
                                { player1.moves[2] , "90,51" }
                        };
                        int option_move = scene.menu_selection(possible_options, move_options, 1, false, player1.character_move_info);
                        string chosen_move = player1.moves[option_move];

                        for (int i = 0; i < 3; i++)
                        {

                            Console.CursorTop = 40;
                            Console.CursorLeft = 90;
                            Console.Write($"{"                          ".PastelBg(Color.FromArgb(70, 70, 70))}");

                            Console.CursorTop = 45;
                            Console.CursorLeft = 90;
                            Console.Write($"{"                        ".PastelBg(Color.FromArgb(70, 70, 70))}");

                            Console.CursorTop = 48;
                            Console.CursorLeft = 90;
                            Console.Write($"{"                        ".PastelBg(Color.FromArgb(70, 70, 70))}");

                            Console.CursorTop = 51;
                            Console.CursorLeft = 90;
                            Console.Write($"{"                        ".PastelBg(Color.FromArgb(70, 70, 70))}");

                            string user_question = player1.questions[chosen_move][rnd_question.Next(0, player1.questions[chosen_move].Count)];
                            scene.text_box(10, 20, user_question, 112);

                            Console.CursorTop = 35;
                            Console.CursorLeft = 10;
                            Console.Write("Enter answer: ");
                            string final = "";

                            try
                            {
                                string answer = Console.ReadLine();
                                string[] ans_parts = answer.Split();
                                foreach (string parts in ans_parts)
                                {
                                    final += parts;
                                }
                            }
                            catch (FormatException) { final = ""; }
                            string correct = player1.answers[chosen_move][player1.questions[chosen_move].IndexOf(user_question)];
                            Debug.WriteLine(final);
                            Debug.WriteLine(correct);

                            if (final == correct)
                            {
                                player1.character_move_info[chosen_move][0] = (int.Parse(player1.character_move_info[chosen_move][0]) + 5).ToString();
                                Console.CursorTop = 37;
                                Console.CursorLeft = 10;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("Correct +5");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.CursorTop = 37;
                                Console.CursorLeft = 10;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("Wrong");
                                Console.ResetColor();
                            }

                            Thread.Sleep(400);
                            Console.CursorTop = 37;
                            Console.CursorLeft = 10;
                            Console.Write($"{"                     ".PastelBg(Color.FromArgb(70, 70, 70))}");
                            Console.CursorTop = 35;
                            Console.CursorLeft = 23;
                            Console.Write($"{"                             ".PastelBg(Color.FromArgb(70, 70, 70))}");

                        }


                        Console.CursorTop = 40;
                        Console.CursorLeft = 10;
                        try
                        {
                            Console.Write($"{"Upgrade another move? y/n ".PastelBg(Color.FromArgb(70, 70, 70))}");
                            string next = Console.ReadLine();
                            Console.CursorTop = 40;
                            Console.CursorLeft = 10;
                            Console.Write($"{"                                          ".PastelBg(Color.FromArgb(70, 70, 70))}");
                            if (next == "y") { cont = true; }
                            else { cont = false; }
                        }
                        catch (FormatException)
                        { cont = false; }

                    }
                    scene.main_format(70, 70, 70);

                    scene.display_menu();
                    List<string> continue_options = new List<string> { "Continue to battle Chris", "Gym", "Quit" };
                    Dictionary<string, string> option_pos = new Dictionary<string, string>
                    {
                        {"Continue to battle Chris", "10,10" },
                        {"Gym", "10,13" },
                        {"Quit" , "10,16" }
                    };
                    int choice = scene.menu_selection(continue_options, option_pos, 1, false, player1.character_move_info);
                    switch (continue_options[choice])
                    {
                        case "Continue to battle Chris":
                            if (player1.health <= 0)
                            {
                                player1.health = 100;
                            }
                            scene.main_format(70, 70, 70);
                            battle(player1, scene, 1);
                            break;
                        case "Gym":
                            gym(scene, player1);
                            break;
                        case "Quit":
                            System.Environment.Exit(0);
                            break;
                    }
                    break;
            }
        }
        static void gym(graphics_settings scene, character player1)
        {
            Debug.WriteLine("gym");
            scene.main_format(70, 70, 70);
            scene.display_gym();

            // add gym functionality

            player1.print_character(10, 30, player1.character_name);
            player1.health = 100;

            Dictionary<string, string[]> questions = new Dictionary<string, string[]>
            {
                {"What is Chris' trademark saying?", new string[]{"Teaching is not learning" , "Testing is learning" , "Learning is not testing" } },
                {"What does Chris hate about python?" , new string[] {"The white space" , "The name" , "The python documentation"} },
                {"What does Chris do on Friday lunch?" , new string[] {"Linguistics club" , "Runs about school" , "Does programming" } },
                {"Who has the best text based adventure game?(unbiased options)" , new string[] { "The person with phone holder number 5" , "Arran Cheung" , "The guy who sits on the left of Ashwyn"} },
                {"Nǐ néng dú dǒng zhège ma?", new string[]{ "Nǐ hǎo" , "Wǒ néng" , "Bīngqílín" } }
            };
            List<string> correct = new List<string>
            {
                "Testing is learning",
                "The white space",
                "Linguistics club",
                "correct",
                "Wǒ néng"
            };

            scene.text_box(10, 13, "Answer general knowledge questions correcly to increase starting health, you get +5 health for every correct answer", 112);
            scene.seperator_horizontal(23);
            scene.seperator_vertical(190);

            for (int i = 0; i < correct.Count; i++)
            {
                List<string> option = new List<string>
                {
                    questions.ElementAt(i).Value[0],
                    questions.ElementAt(i).Value[1],
                    questions.ElementAt(i).Value[2]
                };
                Dictionary<string, string> option_poses = new Dictionary<string, string>
                {
                    {questions.ElementAt(i).Value[0], "78,36"},
                    {questions.ElementAt(i).Value[1], "78,39"},
                    {questions.ElementAt(i).Value[2], "78,42"}
                };

                scene.text_box(78, 33, questions.ElementAt(i).Key, 112);
                int answer_choice = scene.menu_selection(option, option_poses, 1, false, player1.character_move_info);
                // make condition for when all answers are true

                bool correct_ans = false;
                if (i == 3) { correct_ans = true; }
                else { correct_ans = false; }
                if (correct[i] == option[answer_choice] || correct_ans)
                {
                    player1.health = player1.health + 5;
                    Console.CursorTop = 30;
                    Console.CursorLeft = 50;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Correct +5");
                    Console.ResetColor();
                }
                else
                {
                    Console.CursorTop = 30;
                    Console.CursorLeft = 50;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Wrong");
                    Console.ResetColor();
                }

                Thread.Sleep(400);
                Console.CursorTop = 30;
                Console.CursorLeft = 50;
                Console.Write($"{"                 ".PastelBg(Color.FromArgb(70, 70, 70))}");
                Console.CursorTop = 36;
                for (int j = 0; j < 7; j++)
                {
                    Console.CursorLeft = 78;
                    Console.Write($"{"                                                            ".PastelBg(Color.FromArgb(70, 70, 70))}");
                    Console.CursorTop += 1;
                }
            }

            scene.main_format(70, 70, 70);
            scene.display_gym();
            Console.CursorTop = 13;
            Console.CursorLeft = 10;
            Console.Write("Your health is now " + player1.health + "hp!");

            List<string> continue_options = new List<string> { "Go to N70 to batttle Chris", "Library", "Quit" };
            Dictionary<string, string> option_pos = new Dictionary<string, string>
            {
                {"Go to N70 to batttle Chris", "10,16" },
                {"Library", "10,19" },
                {"Quit" , "10,22" }
            };
            int choice = scene.menu_selection(continue_options, option_pos, 1, false, player1.character_move_info);
            switch (continue_options[choice])
            {
                case "Go to N70 to batttle Chris":
                    if (player1.health <= 0)
                    {
                        player1.health = 100;
                    }
                    scene.main_format(70, 70, 70);
                    battle(player1, scene, 1);
                    break;
                case "Library":
                    library(scene, player1);
                    break;
                case "Quit":
                    System.Environment.Exit(0);
                    break;

            }
        }
        static void Info(graphics_settings scene)
        {
            scene.display_info();
            scene.text_box(122, 15, "Game made by Arran Cheung                                                                                                                                                          To interact with the ui, use the arrow keys and click enter to continue through the menus. Console must be in fullscreeen with cascadia code font in size 14", 180);
            scene.text_box(122, 20, "The aim of the game is to beat Chris Palmer in a pokemon style pvp battle. In the game you will be asked to answer questions that, if you get right will reduce the damage done to your character.", 180);
            scene.text_box(122, 25, "The controls are displayed at the bottom left hand corner, the first 3 moves that are displayed are attack moves , the 4th move is the healing move and the last is the special move that does extra damage but can only be used one and then turns into a normal attack", 180);
        }
        static void Main(string[] args)
        {
            character player1 = new character();
            graphics_settings scene = new graphics_settings();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter fullscreen and click enter to continue");
            Console.ResetColor();
            Console.CursorVisible = false;
            Console.ReadKey();

            // setting up the main menu
            scene.main_format(70, 70, 70);

            scene.display_bp();

            scene.text_box(20, 15, "Welcome to my game                                                 Use the arrow keys to navigate through menus and click enter to continue", 70);

            scene.seperator_vertical(110);

            // main menu selection
            bool main = true;
            while (main)
            {
                List<string> options = new List<string> { "¬Play", "¬Info", "¬Quit" };
                Dictionary<string, string> option_positions = new Dictionary<string, string>
                {
                    { "¬Play" ,"20,20"},
                    { "¬Info" ,"20,23"},
                    { "¬Quit" ,"20,26"}
                };
                int option = scene.menu_selection(options, option_positions, 1, false, empty);
                switch (option)
                {
                    case 0:
                        Game(scene, player1);
                        main = false;
                        break;
                    case 1:
                        Info(scene);
                        break;
                    case 2:
                        System.Environment.Exit(0);
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}

// Wow you've found the bottom of the code :)
/*
    

................................................................................................................................................................................................................................................................................................................................................................................................................
............................................................................................................................................................:....::.::...:=++==:....:-==++==+++=====+==:.............=###+=--..:----:...:..::....::.............................................................................................................................................................
............................................................................................................................................................:....:...:....:...:--==--..................:---===--===-:.......--=-:::-:...::..:....:..............................................................................................................................................................
...........................................................................................................................................................::....:...:....-+*+=-.....:-=-..............:.............+##*+=-...:-==-..:.:...:....:..............................................................................................................................................................
............................................................................................................................................................:....:...:...........--:....................................................::..:....:..............................................................................................................................................................
.........................................................................................................................................................................................................::..:::-::..............................:..............................................................................................................................................................
...........................................................................................................................................................:-..................+%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#.............................................................................................................................................................................
....................................................................................................................:--===-::---....:-=--.:-===-:-:................-#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@+...............:-=++++=-::....:::.......::.........................................................................................................................
.................................................................................................................----:......:..:=*+=-....:-:-::............:@@@@@@@@@@@@@@@@%%#+=:..............................................--+@@@@@@@@@@@@@@@@@@@*:..............:---:...-=+=--:..-----:...................................................................................................................
......................................................................................................................-=++=-..:=:...-===:...........+@@@@@@@@@@@@@@@%+.....................................................................=%@@@@@@@@@@@@@@@#++=-..........:--......:....:---...................................................................................................................
.................................................................................................................=#%#+-........-*#+-..........:%@@@@@@@@@@@@-............................::::-::-::-::-::..........:...............:::..............:#@@@@@@@@@@@@#=..........+@%+=.........=...................................................................................................................
.................................................................................................................:....-=======-..........%@@@@@@@@@@%:...................................:::::::::::::::::::::::::::::.......................:............=%@@@@@@@@@@@%=..........-=++++==:-...................................................................................................................
.................................................................................................................=%@#=..-=-.........+@@@@@@@@@-..............-=---..:--===-..........................................:.............-+**+==-..--==:.::............-*@@@@@@@@@@#..............:...................................................................................................................
.................................................................................................................:...........=#@@@@@@@@@@@-..........:===-.........::..............................................................-.............-...-=-...............+@@@@@@@@@@#=........-...................................................................................................................
...................................................................................................:::...:.......-+*=.....=%@@@@@@@@@+........:-:::..........:-.............................................................................:....-:-:...-==--:..---.........=@@@@@@@@@+:.........:.....:...:::...::::::::.......................................................................................
.....................................................................................::::::........:.--:..............=@@@@@@@@#............--=++=-:......-.-..................:#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%=.....................................-..........-#@@@@@@@@+.....:-=--.....::...------:..........................................................................................
.....................................................................................:.........::..-=:..--.:-:....=@@@@@@@@@#-............:.........................=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=...............-==--:-=-..-++=..-.......+@@@@@@@@=.......-==:.:--:.......--=-.......................................................................................
....................................................................................::.:...........-===:.......-*@@@@@@@=..........:...--...::.---..........-@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#+=-=+#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*........................::--:........+@@@@@@@=.......:-.:-..-=+++-...........................................................................................
............................................................................................:................=@@@@@%+-........:=----::...............=@@@@@@@@@@@@@@@@@@@@@@@@@%-.............................................-%@@@@@@@@@@@@@@@@@@@@@@@@@=................::..:=++*+=:.....:%@@@@@@#......-..........-=+=:......................................................................................
.....................................................................................:....::::...........=@@@@@@@=.......:---..-................*@@@@@@@@@@@@@@@@@@%....................................--::.......:.....-.................*@@@@@@@@@@@@@@@@@@%.......:-....::.......:--.......+@@@@@@@*.......-===-............................................................................................
.......................................................................................:::......:.....=@@@@@@@+.....:..........:-:.........@@@@@@@@@@@@@@@@@=...........::......:--:---:.-++=-:..-==+#*-.....:---..........::-----:...............-@@@@@@@@@@@@@@@@@.........:=**++=:.............:%@@@@@@#...........=*+-......................................................................................
...................................................................................................=@@@@@@%......-.:::................@@@@@@@@@@@@@@@@..........:===-:..--.:----........:..................:-....-==--::............:--==+==-.............@@@@@@@@@@@@@@@..........-----.....--.......=@@@@@@@+:...:=-..........................................................................................
......................................................................::-:....:......:...:-.....-+@@@@@*.........-....-+++-.......@@@@@@@@@@@@@+...........:-..-:.....:.........:---===-.=###+-.:-=+..+@@#......:...=========------:.........:---=+=..=-.......+@@@@@@@@@@@@@=..........-=-:..............@@@@@@%-....+*+=...::..:-:............................................................................
...........................................................................---:.:--::-.:......%@@@@@..........:---.-=+=......-@@@@@@@@@@@@@..........=%@%+..=:.-..---.--.-..:::::.......-....:-.::...@@@@@@..++..=-=.................-==++=....:.-:.:*.:............%@@@@@@@@@@@@-......:---=--:...:........-%@@@@@#.....-+=:...::...:.:........................................................................
.......................................................................:---....-:...::.....#@@@@@+-........:+++-.:-:......#@@@@@@@@@@@:.......=%#-.-+:....:...........:-.-::......::---:.==-..==...@@@@@@@@@..--:...:----:::::.::...:-....=..........#.#-......-.........@@@@@@@@@@@@.......-=--:..............=@@@@@@*.....::......-:.-....:.......:...........................................................
......................................................................-++..-==...:......+@@@@@@+......-#*+-:-..:.......@@@@@@@@@@%..........--...::..=:=+=...#@+.....-..-..................:-..=..@@@@@..@@@@....++=...............:.:--+.=.*@@@@@+.......%-+:.#@#...........@@@@@@@@@@@=........---...-==+=.....-%@@@@@%-....-==-:::..:....:..:................................................................
......................................................................-..-+###+......-#@@@@@#:....:.........:......@@@@@@@@@@@............----*=...........-@@@@@@..-===..:.............-=-.:.-=.@@@@@=..=@@@@...+..::.....................@@@@@@@@@@@@...=.+....:-=.--.--.......+@@@@@@@@@@.........-....::-:......-@@@@@@%......-..=+-...:....................................................................
......................................................................-**=:....:...+@@@@@#-..........-=+-.......#@@@@@@@@@........-==+==-:........=@@@@....-@-=@@@#....-+.::............+-+..-=.:@@@@......@@@@....==:.............::.:.-..@@@@....@@@@@@+.=%........=:.....-........@@@@@@@@@@+......--:.....-........*@@@@@=.......:.:.....::..::.............................................................
.......................................................................--..+#=...=%@@@@*......--:::.::.......@@@@@@@@@@......=-:=................@@@@@@@@...@@@.@@@...=.--.:............+....#..@@@*........@@@@...--=.............=-+-.+.@@@..@@@@@..@@@@-....@@@......-@@=.#@%+=......=@@@@@@@@@-.....:.-==.:==:.-:.....=@@@@@=....-*=....:...::..............................................................
.......................................................................=-......%@@@@%......:-....:-:......%@@@@@@@@......+@@+..-.:+=..........+..@@@@@@@@@@..@@..@@@..:=*=-:............=#-.-=.@@@@...--.:...@@@@..#=-.............:..=...@@@.@@@@@@@@..@@#..-@@@@@@@@+.........:==:........@@@@@@@@@.....-.:.....:..-=:....#@@@@%-.............................................................................
..........................................................:--====-..::.-=....:@@@@@=..........--.......#@@@@@@@@+...................%@@@@@@@@....@@@...@@@@@:.@@.@@@..-+-.-:..............+.+.-@@@...........%@@@...:-:----:::.....*@+...#@@+.@@%...@@#.@@@..@@@@@@@@@@@@@...-%%-..:+#+........@@@@@@@@@........::.......:.....%@@@@*....:....:=+=.=+=..........................................................
........................................................-==:.......:..-:..-@@@@@%-....-:..-..-=-....+@@@@@@@@......:-..+#%+---...@@@@@@@@@@@@@@@..@@@.....@@@@.@..@@@...:=..---:...:::::-.*...@@@....++##-....%@@.............::-:.......@@@..#@@@@@@@..@@%.@@@..@@*...@@@@@@......:..:+#:..-.....@@@@@@@@+.......::--:..-:....:*@@@@@#.......:...-=.=..........................................................
........................................................=...=%@%*=.......+@@@@%:......:-==-.......*@@@@@@@.....:.--.-=--....::.%@@@@...+@=...@@@@.-@@#.@@@@.%@@@@.@@@....--....:::....:....+.-@@@..:.-...-#....@@..+.=.::::.......:=+%..@@@..@@@......@@@@.@@@@.@@@@@@@@....@.-%@@=..==..*@#.........@@@@@@@@:.....:....:..........#@@@@+....::=++.-#+..........................................................
........................................................-=++-..........@@@@@+.......-:...::.....@@@@@@@#.....+=....-...........@@@..@@@@@@@@@..@@@.@@@.@@@@@@.....@@@@.+:..-=--...:-----@@#..%@@@......=+.+....@@..#:=..................@@@.@@@@@@@@@@@@@..@@@.@@@+...@@@@@@@.@@@@@@.+...-..#:%=-=.....-@@@@@@@............:.......=#@@@@@=...-=-:..............................................................
........................................................-+=..==......+@@@@#.....-......:.....%@@@@@@@......==.-+--.....@@@@@..@@@..@@@=...@@@@..@@..@@.+@#.@@@@@...@@@..==..............-.+#.+@@@....-:.=++...@@@...:+----:....:---=..+@@@..@@%..@@@@@@#..@@@....@@@@@@...+..@@@=@@@.#-.@=..+.-..=..=:....-@@@@@@@....-=-...-..::.....-@@@@@-......==-..........................................................
...........................................................=-......*@@@@=..........:-......@@@@@@@-................=@@@@@@@@-.@@@.@@@.......@@@.@@@.@@@.@@@.@@@@@@@#@@*+@..+*+=-:.:=+*#+@=%*..@@@@@=........@@@@@..-.................+..@@@@@@...........@@@.-@@@@...@@@@+...@@@.@@@.+-.......:.--.+-.-**-...@@@@@@@.....:...:.:=*#=.....@@@@@:.................................................................
........................................................-=.......+@@@@%......:-==:.==-...@@@@@@@......--.-*-.....@@@@@@..@@@..@@@.@@@..-.....@@-.@@..@@..@@#..#@@@@@@@:..:.....................@@@@@@@@@@@@@@@@@...................=...*@@@@@...=+=#-:..@@@..@@@@@@@@@@@@%...@@@.@@=.....@@@@@@.-@=%-.=:.:.....@@@@@@@........-:..........:@@@@%...=+=..........................................................
.........................................................-++...%@@@@#..................@@@@@@+....-=.#.-#-....@@@@@@@..@@@@+..*@@..@@@.......@@-.@@+.@@@@@@@....@@@@@..@@.#@+............-%@@@@%...............-@@@@#.............--.=+.............-+.:@@@.%@@%...=@@@@@...@@@.%@@....@@@@@@@@.......+=.#%+.....#@@@@@@@......:==-==:.-:....@@@@@..............................................................
..........................................---.-*#+.=%%+......+@@@@%-.......=#*-......@@@@@@=..-*==.@.*=..++.=@@@@..@=..@@@.....@@@..@@@@..-@@@@.@@@:.*@@@@@..................@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@+..............=--++..+@@@@..@@@@@@......#.@@@.@@@..@@@@..@@@+.@@@@.....-:+.--.....@@@@@@%...--.--..:........*@@@#.....:-+*=.+%%+:.............................................
..........................................-..--...-=..:=..-%@@@@#....:...-:........@@@@@@....=+.-%--........=@@@@@@@@@.*@@@....*@@@..@@@@@@@@@.@@@@....@@+...:.......+@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@:........-:.:..@@@@@@@..@@@@@@.....@@@.@@.@@@@..@@@@=.@@@@@@@................@@@@@@@.......:*+=:++=....=@@@%=.......:....::............................................
..........................................-.+-.=@%:.%%.....+@@%=.......==.:++....@@@@@@*..:--.#+:......*@@@...@@@@.:@@@.-@@@....-@@@@@..@@*..@@@@@..-..........@@@@@@@@@@@@@@@@@@@%-......................................+@@@@@@@@@@@@@@@@@@@@@#.........=@@@@@@@@..@@:.*.@@@.%@-@@@..@@@@+.@@@@@*@@@@@....:..-=*%+....-@@@@@@.....:+.#........:*@@@@=..-#%+.#@@*..............................................
..........................................:.-..=-....::..=@@@#:...+=-.:..+:....@@@@@@....-..-:..#=..+@@@@@@@@@.......@@@..@@@.....@@@@@@@@@@@@@@.........@@@@@@@@@@@@@@@@@=..........................................................+@@@@@@@@@@@@@@@@.........=@@@@@@@.:..@@@.@@@@..@@@@@..@@@@.:@@..@@@@@.........-=....@@@@@@@..+#.-*.........:+#@@@@.........=#=............................................
............................................--.....-...#@@@@#....=..-:-#:....@@@@@@..:+*..=--==...@@@@@+..=@@@@+......@@@..@@@.......=@@@@@@@........@@@@@@@@@@@@@@:......................::::::::::::..........:...:=+#=...:...............@@@@@@@@@@@@@@..........=%++-..@@@....@@@@@....@@@@.@@@@@@@.@@@@@%..%@@#.=%*....+@@@@@....:-..:..::......@@@@=..-..+=..-............................................
..........................................:.--..+#-..:*@@@@+...=-.-+=......@@@@@@.....:--.-....%@@@@@..@@@@..@@@..%@@..@@@=.@@@*..:-............+@@@@@@@@@@@%...............=.........:..-.::::.:::...::..........:......:.........-...:..........%@@@@@@@@@@@..........-:.@@@@@@@@@@....@@@@+..@@@..@@@@...@*..+..+-....-:...+@@@@@..........-+*+=...:@@@@:....:#*=............................................
..........................................-...:....:#@@@*.........::...==@@@@@@...=:.........+@@@@@.@@@@@@@@.@@@........@@@@.@@@+=...........@@@@@@@@@@-..............:::.....@@@@@%...:--............:-::::.:::.....:-.....@@@@@=.....................=@@@@@@@@@@@....*@..@@@@@@@@.....@@@@.@@@.@@@@..@@@@@@........#%:.=.:....@@@@@@......:-:....:....*@@@@-....--............................................
..........................................:.--.::..-@@@=.....-=+=.......@@@@@...=....-.--..*.-@@@..@@@..@@@@.@@@:........%@@@@@:.#-.:....@@@@@@@@@@+.....=+..................@@@@@@@%........:::..:::................---...@@@@@@@@....-:....:-:............@@@@@@@@@@.......=@@....-.@@@@..@@@@@@.@@@@*.@@%..@@@@@@...#@*%*=.....@@@@@@......=+*+-.......%@@@+..--:............................................
..............................:::........:-=-:...=@@@@=..-++-.........@@@@@@..+..=-%=#-=..==.=@@@@.@@@@@@@@..@@@@@@@@@@...@@@@@......-@@@@@@@@@@......-+=:+.-=--*%#+::-=...-@@@@@@@@@....:::::.......:::....::::::::::.....@@@#@@@@@....:--...--:-==---=-:......%@@@@@@@@.............@@@..@@@.@@@@@..@@....@@@@@@@@@...........==..@@@@@=.................=@@@@+..-.:==:...=+=:--:.............................
............................:...:.....::.......-@@@@#......=+:.-=...-@@@@@.....-+-.=.:.-=.::..@@@@@.@@@@..@@@....@@@@@@%..........#@@@@@@@@@...........=*#=.:..:...::.....#@@@@...@@@.....::......::::....:::::..:...::...#@@@..=@@@@...=:-:-.......:--............=@@@@@@@@%...*#....@@@@.@@@@...@@@@@@...@@@@....@@@@....+%%#+.....%@@@@@..#+..%@%...::...:%@@@%...-....::...-................................
............................:..::..:::....--..:#@@=.....-...:......@@@@@....+...:..........@@...@@@@....@@@@@@@@@@@@@@@*.......@@@@@@@@@....................-:..=#+.-....@@@@@....@@@*....................:.........:-=..+@@@....-@@@@=...+=..=-::.....................@@@@@@@@@......@@@@@..@@@@@..@@@..@@@@+.@@@@..@@@@.......:-.::..@@@@@.....+.+=..---=...:+%@*...--.-=.:#+.=+:.............................
............................:...........:....=@@@@+.....=..+-....*@@@@@..-#.**:.=:..+@@@@-........@@@@..@@...@@@@@@@@@@+....@@@@@@@@@:.....=##+...............-=-..:...+@@@@@.....-@@@*...................:.........---..@@@@.-...=@@@@-...*#...-:.............--==--.....@@@@@@@@@......@@@@..@@@@=...@@@@@..@@@@@@@..@@@..+@@#:....+...@@@@+...:@+--.-:..:..-#@@@@....-..:=..----.............................
.................................:.:.::.....#@@@#...:=-.=.=.....@@@@@...*:#=..+:...@@@@@@@@@@@.....@@@@.:@@@@.............@@@@@@@+............-.............-....:....@@@@@...+-...@@@@...................:..............@@@.....=..@@@@@.....==.:................-=..-=.....+@@@@@@@......@@@@@..@@.@@@@@....@@@...@@..@@@.....:=+=::....@@@@@=.....=-.-++=....+%@@%....:++..+=.--.............................
.............................:::-:::.:....:@@@@+....:-:.:.....#@@@@@.....-.-=.--:..@@@.+%@@@@@@@@@...@@@:.@@@..+*+-....@@@@@@@@.....:-:-==.:++-............:-.-:-...-@@@@@..+-.....-@@@...................:....:....:=:.:@@@.-...:=-.@@@@@:....................:==...:.:-.......:@@@@@@@.....#@@@@@.+@@@..@@@@.@@@@@@@@.@@+:=+.......-.=....@@@@@.....-..........:#@@#=......-..-=:.............................
..........................................@@@%=....:...-:...-@@@@@...=+%@--.#.-...=@@@..%@@=..@@@@@@@#.@@@@@@=.+.....@@@@@@@=....**-.....-:.-=-.............-:.....@@@@@#..:..+=.:..@@@...................:.........:-..*@@@..-.:=....+@@@@@...-...............-..---.:-:-*=.=.....@@@@@@@+.....@@+.@@..@@@@@@@.@@@@@@.#@@@...-....*-:..==.=.#@@@@*....-....-......%@@@+...-..---...............................
..........................................@@=.......::......@@@@@...+.......-.+.+..@@@@.@@@@@@...@@@@@@..@@@@.....@@@@@@@+........:+=:...--...-...................@@@@@..--..-:.-=..@@@-:.................:..........=..@@@@.....=#=.*..@@@@@..................:--:..:..--..-..:.....=@@@@@@@......@@@@@@@@..@@......@@@@@.#@@@@@@..=.....+.-..@@@@@....:===:.......+@@%-..:::=-................................
............................---:--.-=..=@@@*....-..::-=-..@@@@@.......==+:.:+-..-...@@@.#@@.@@-.@@@@...@.%-.....@@@@@@@.....--:............-+=..===-..:.:---....@@@@@@....--..:--.=.@@@@:..:------::......:.....:......=@@@:.......-=....=@@@@@......:----====-..--:........=+--++......@@@@@@@....-@@@@-...@@@.@@@@@@@@..@@@@@-@@+.-=-+=.:@=...@@@@@...:....==.-==..=@@@@...-..-...............................
............................-..-..:-..=@@@%...:--........@@@@@.....:.............-..-@@@.@@@@%.@@@@@@@@@@....=@@@@@@*....==:..---:...-===:.....-...-:...:.....%@@@@@.....++-:..-..=.-@@@-...:.:.:.::......:....:.......@@@@.+.:.....=#.:%..@@@@@@......-=-......:...:---===-:..::.........%@@@@@@...........@@@.@@@.....@@@@..@@@@........-.-..:.%@@@@*.....-.-+:.....=@@@@+..-..:..............................
...........................:-.-.:+-..@@@*....:.-.:=-....@@@@#...:=.-.=....@@@@@#......@@@..@..@@@#.@@@+.....@@@@@@.....:.....................--.:=-...-=-....@@@@@@..--.....:..=.==..@@@+..........:......::...::......@@@..@.+----..=-......@@@@@........-++++=-...................::.......@@@@@@....:=+.+@@..@@#..@@@@@..@@@@%..@@@....=..+.-=..@@@@@.....-..:-++:...=@@@#...--:.............................
..............................-.....#@@@+......-.=....@@@@@...++.-.-%...@@@@@@@@@......@@@@.@@@+..........@@@@@@=...=--:...:--=-:............:---..=+=.....@@@@@@...-..-..:.-..*.-=..:@@@.......:..:......::...::.....=@@@..#.:....:=*..+*-...@@@@@@-.....:...................:.::.............@@@@@@:.....%@@@@@@.+@@@@..@@@@..@@@@@@@#.-:-.-+.#%..@@@@@.....-==.......-#@@@-...--.............................
.............................:-...:#@@%-....--:......@@@@@.........=...@@@@....@@@@*#-..@@@.@@@.........@@@@@@#......:::........:............:.....=:....@@@@@@=..#=.-:.--+.-..*.:=...@@@.....:....:......::...::.....@@@@..#.=.--=:.-..--......@@@@@@....:-::-::................::...:::........@@@@@@.....@@@@@.@@@@..@@@@..@@@@@..@#..-.-..+.......@@@@.....:..-----...=@@#:..--.............................
.................................-#@@@:...---.:.....@@@@@..++..--....#@@@.@@@@@.@@@@@@@@.@@-.@@...=...@@@@@@=............:::...:-............--:+=.....@@@@@@#.....-=..++.+.=..+---.*.@@@@....:.:..:......::...::.....@@@+..=.-.:.--.:*=.+%:=-...@@@@@@@.....+=--..................::...:..........@@@@@@....%@@.@@@..@@@@..@@@@..*@@@@+.=..+*..#%=-..+@@@@+....=-.....-...#@@@-................................
.................................+@@@=.......:=....@@@@@..-...=.....@@@-.@@@+#@:.....@@@@.@@@@@..-..#@@@@@-......-:....:..:--:-:.............:-......@@@@@@@.....=##=:....=.-..-=:..=.@@@@..........:.....::...::.....@@@.....=.-...-=.+#..+*......#@@@@@@-....-=..........................:=:.-*=...@@@@@@......@@@@@@#.@@@@@..@@@@@@.............##...@@@@%.....:..-:.:..:@@@@-...............................
................:::::.......:...=@@%-.....---::...@@@@=.:..+-.--..*@@@@.@@..@@@.@@@@@%.%@@.@@@@....@@@@@......-=:::...::....:....::..........::....@@@@@@@....=..:...-=++-:.:.=.-......@@@.......:....::.....:.......#@@@....=-.=--=.-*..=:...-..+....@@@@@@....:.....:---:........:....::.:-.=..:-:...@@@@@@....@@@@@.@@@@..@@@@@@...-*-.:.:.::=+-......@@@@@.....:..::.:...=@@@......:........................
..............--=---:-:::..-+.-%@@%-.....:-.....=@@@@..=-+.....:..*@@:..@@@@@@.@@@@@@@@.@@.......@@@@@@...-=---.=-:..:....:.:..:----:--::........@@@@@@@.......:::---.......:.=..:::...%@@+..--.:=-=..:---..:.:..-=..@@@..*.+:......:..=-.====.-.-.-...#@@@@@@.....-====---.-::.:::..::::---+==....:-...#@@@@@...::=..@@@@.@@@@@#.........:-==-...:====...@@@@@...:-..--..-...=@@@=..-:--:.:---.................
.............:.......:...:....@@@#:.........:..*@@@@..-..-.=-..-..+@@@@@.@@@@.@@@...@@.=@@+....:@@@@@....==...++-..............-....-:.........@@@@@@@...-%#+...:...:--:.......:..:.....@@@...-.:=.+.-...:-:....-=..#@@@..+.%.=..:...--.:-........:.%#....@@@@@@-........:-.-.:..:..............:.........%@@@@@.....%@@..@@@@.....=.:--.......:-:.....-...@@@@@.....::..--.....#@@:..:.--.-=.=:................
..............-==+=-..-=-...=@@@+....:..::.....@@@@..*-.----++:.:..@@@@@@@....@@..@@@:.@@@....@@@@@:...........................-::::.........@@@@@@@.......:-.............::...:........@@@#...-.=:=.=..-:=#=..--...@@@@.-.-#.=.:--..............-.:...-...@@@@@@@%.........:.-....::.::.......::...........@@@@@....@@@@.@@@....-.@.%...............--:=.:.+@@@@....:-==-:......@@@=..=.-..=..-:...............
...............::::...-:....%@@#+:......--....@@@@..+-.++.=...:..:.....@@@@@@.@@@@@@..@@@....@@@@@....:.....::...::.......................@@@@@@@@...-.::.+--.............::...:.....:..@@@@...-:..:.:..=-..+.::....@@@..:.-..=.-:-..............=+.+%=.=.....@@@@@@@.....==..-....::.::...::..::...::....=..%@@@@=...@@@@.@@@@..-.=----...............-:....%@@@+............:.:*@@@-......--..-...............
...................-:-:..:.+@@+=-.......-....@@@@:.++..-..-..-=-...:++...@@@@@=..@..@@@@...@@@@@..........:::.::..:...............:....*@@@@@@@....-...-:.................::...:.....:...@@@....-..-:=..:=--+......@@@@...=:.-:--.-................-...:-.......@@@@@@@@...........::.::...::..::...::....==...@@@@@@...@@@..@@@...-+-.-.............=#=..=.#.*@@@#...............*@@@:..:...=-.=...............
...............--..---..-=.#@+.:...:.:..-...@@@@-...-..#:...=+-..--:.......#@@@@@@@@@@....@@@@@...::...:.......:-::..................@@@@@@@@...-+==:..:...:..............::...:.....:...*@@@%...::..-:..-+=:.....@@@@..+...--.--................-=-.+#+=..::.....*@@@@@@@.........::.::...::..::...::..........@@@@@@...@@@@.@@+..*.:--............:-..+.#..-.@@@@@..-:...:--.....#@@%-.:...--:-...............
.............-==+-.---..=-.+@=....--.:.....@@@@...-.=%:.-**--...=+--+*.-.....:@@@@@@@...=@@@@=..--..........::....................@@@@@@@@.................................:...:.....:....@@@@+........-.........@@@@#..:=.=+...-=...............::.......==..:......@@@@@@@@:......................::...:-.......@@@@@...%@@@@@@.=.-.::............:===...#+...@@@@=..::.--====....#@@#..-....:................
.............--.=+:..=-.-==@@:...==---....@@@@..=.:+.=+-..-..-==-...:-.=%#-.....*@@%...@@@@@..--:-.:-=-:....:..:-:.:---........@@@@@@@@@.....=*==::==..+##++++-:----:...---....:.....:....-@@@@@...............@@@@@@..-.-+.........::....::...:.-..=-..-+=.:.-=..:....+@@@@@@@@..........:-===-.....:....:=+=-....=@@@@....#@@...==.:::.............--...-.+....@@@@.....=-...-.-...%@@..---:.--...............
.............-=..+=.-##.=@@@=...-:.......@@@@...----:..:===:.....-==:.-...--.:=.......@@@@#...----....:=*+-....:-----......@@@@@@@@@@......=-:.....................-==:.....----::::::......@@@@@@@-........@@@@@@@#...=::==+=.-------:.:----.::.=-..=-:+-......::........@@@@@@@@@+....:--::::...:--::.:......==....@@@@#......--...:..................:.+.=.-...@@@@=...-..:--.-...-@@@..-.-%.+...............
..............:+..=-....%@@:..:..-==....@@@@.....::..::..::...........-+++:...=.....=@@@@#.........--=-...------........@@@@@@@@@@....:-.........+@@@...+%=.-+=--==..:=:.+=:............-+#..*@@@@@@@@@@@@@@@@@@@@...:......:...:..-.:.::...:::..---:-......*...-.:..::......@@@@@@@@@=........:===-::..:.:....==.....@@@@@..:...--+.---.............:..:..::......@@@@....:=-:..-:-..+@@=...+#.+...............
...............==:-=.+.+@@#....-........@@@+...........................-++=....-.=.-@@@@+...-.-:--.....-:..:........%@@@@@@@@@#..............:+..@@@@@@@.......-..-+=..:-.:.............:..+-...@@@@@@@@@@@@@@@:...................-.:..-:::.:::........@@@@@@@................:@@@@@@@@@%.................:-...==.....@@@@@........-:..............................@@@@..:--....-::...*@@..=*.-=...............
.............:.-=:.=..-@@%:...-.-:.....@@@@.........:.................:....=-..--.#@@@@.....:.#===-..:==........%@@@@@@@@@@..................-...@@#@@@@@@....-+*=..+#+-::::............-=-..:.....-@@@@@@@@....=#+-.:.............-::...::...........@@@@@@@@@..........:.........%@@@@@@@@@%........=-..--+#+..-=.....@@@@@...:-:+:.+=.............................@@@:.......:......-@@*...--................
.............::.:-.-..@@%-.....--.....@@@@..........:.................-:.:..==...@@@@@....:=.:*.--..........@@@@@@@@@@@@......==-............:+..@@...@@@@@@......=:..=-..:..........................................:..............-:...::.........@@@@@@..#@@......:...:............@@@@@@@@@@@@........-:...=-..+*+-..%@@@@...:-.=#.=...........................=.=@@@...==-.:-.:....+@@#..=.................
..............::.=...+@@=...-.:-:....@@@@...........:.................:-=-=..-..@@@@@....=+:.:+.-......-@@@@@@@@@@@@-.....:.:-:..................@@@@...@@@@@@.....+=...:................:---...--..............+%%-................:::...::......@@@@@@-..@@@@......:.:...::.-+##=.......*@@@@@@@@@@@=......--.-=.........@@@@....+-.-=...........................=..@@@@=...=...::.....+@@+...:...............
..............:=.+..-@@*....=.=.....+@@@..................................-*-..%@@@@..==...........@@@@@@@@@@@@@+.......--...:-..............---.+@@@+....@@@@@@....-+..%++=................=+.....+@@@@@@@@:......+-=.............=::...........@@@@@#...@@@@..=....:..::.........=-........-@@@@@@@@@@@@@..........::-=...@@@@...%%+.............................=...@@@@...:..:--.::...@@@...:...............
.............:.-.+..@@#...=.=.---...@@@@.-=+++=-:...-:..::.......--:...:..-.:.#@@@#...........@@@@@@@@@@@@@*.........--:.-+*+-.:::::::::::::..+-...@@@*.....@@@@@....#..%.==..--.-++-.:=-......@@@@@@@@@@@@@@@@@:....:.-:.:---...:....+%#=-....@@@@@.....%@@@-...........:::...-#@#..++-.-=:......=@@@@@@@@@@@@@%.......-....@@@@......-.......:::...:--:..----:.:-*....@@@@...-.-.=.=....-@@%..-...............
.............:...-.@@@....-.:......=@@@..=......-===---...--:.-=-..--:.......#@@@%......@@@@@@@@@@@@@@@.......-++-.-:..::........:::::::::::.:-#...@@@@+.....#@@@@@....--.+-.--.-+=+=.......@@@@@@@@@@@@@@@@@@@@@@@......-...:::...-=-...-...*@@@@@.....@@@@....-::::.....:::......::.........-........@@@@@@@@@@@@@@@:......-@@@@..=..:.-=+=-..:--..-::..............#.-@@@...::-==.=.-...+@@#.-...............
...................@@+....-.:--...-@@@..+.+@@@#=...-..=+=....--.......:-+:...@@@@......-@@@@@@@@@+...........................................--.-...%@@@%......@@@@@=..%-....:..-+..:-.#..@@@@@@@@=..........#@@@@@@*..=.*@#-.=..=*==%-=+...@@@@@......@@@@%..-=.............................:-..............+@@@@@@@@@@...=...@@@@..-.......:--....:+%#+=---==+++--:.=..@@@@..::....-..-..=@@@.....::..........
..................=@%+..:.-:::....@@@@..*.*.....-:.......=:.--...#@@@:......@@@@...+:..-@@@..........+#%#=.....:--............................==.+...@@@@@..-...=@@@@@...-..-.-=.-=..==..@@@@@@.................#@@@@@......=.=.:*..:=:....@@@@#......@@@@@................................:...==-.....:..##-........@@+..+.-..=@@@@...-.:--..=*%*:.-==-.....:.....+.-+..#@@@#......::..-..=@%@=..............:.
.............:...:#@#=..::-:.....@@@@...=.=-==--.....................=.-:..@@@@...:=.:..@@@@@@@...........=++:.=+=-..........................::-.:....+@@@@.......@@@@@..:-.-.=...-=.=..@@@@@.....-..=-...........@@@@@..#%-..-.--.......@@@@@.......@@@@:..-.+=-...........................%@#..+#*=:...........+@@@@@@...+....-@@@#..:.....:................-=*%#=.*....@@@@.......::.:..-%#%%-.............-.
.............-..-#@@+....--.....=@@@=.................*@@@@@@@@%....-.:...@@@@.......:...+@@@@@@@@............=:..-..........................=.--::-@@..@@@@...=...@@@@@....-.+.=..=...@@@@@...:=..--=.-..=+#*=.....@@@@..+=.:.--.+-.=..@@@@@..-....@@@@-.#*:..::......................................=+-....@@@@@@@@-..++.=....%@@@....--.....=@@@@@@@:...........-:.-...@@@%....:.::.::..*+#@%.....:.......:.
.............-..=@@*:..-........@@@@.....:-...@@@@@@@@@@@@@@@@@@@@@@.....@@@@.....=+-=-.....@@@@@@@@@+....%@*..#%+...........................=.#=++......@@@@=..=...%@@@@@...-=.=.-....@@@....=-=--=-..-+.....-*#:...@@@@...--.-::.=..-@@@@.......%@@@@.....-.==-...........................++..#@#=......=@@@@@@@@@......+.-=....@@@@-.....@@@@@@@@@@@@@@@@@@@@@.....-=-..%@@@#...-.:-..-..:-=@@....::....:.:-.
.............-..-@@:...+....-..:@@@..#.....@@@@@@@@@@@@@@@@@@@@@@@@@@@..@@@@...=--..-...-=.....@@@@@@@@@@........-...........................-*+.=++#%%-..@@@@@..:....@@@@@..:-.---=:.@@@@............-:.++-......-...@@@-=-.-.-:....@@@@@.......-@@@@....+=+.+--.............................==:.....-@@@@@@@@@=.....::=#+.--.....@@@@..%@@@@@@@@@@@@@@@@@@@@@@@@@@.*=..-..@@@@...-..::.......@@............:-.
...............-@@@..-.--:.-=..@@@@..=.=-...@@@#++=:.............+@@@@@.@@@*..............=##-....+@@@@@@@@@.......-#%*-.:..=++=:...............-..--......@@@@@...*+..@@@@@..#-.:.+..@@@=...+%#-:==.:=.-..-:.+%%*-...@@@..:-:-.=...@@@@@...=#:.@@@@@....-.:...:.............:==.=+-:+#+-.....==....@@@@@@@@@.....+#+:......-.......@@@@.@@@@@@=.............+@@@@%@.*.:==...@@@=..-.:--:---...@@+.:-....-=-..-.
...............@@@:.....-:.:...@@@-...-=.-%@@@@@............--:....@@@@%@@@=...-:-:.:---.............%@@@@@@@@@.....-...+*...................-==:.....-=-:..@@@@@....-..@@@@@....+#...@@@...........:+.+.--.:.........@@@...+......@@@@-...#...@@@@@..=%#-.::---.............:=:.==.:-..-.:-.....@@@@@@@@@.....-......-==...+#+-=....@@@.@@@...........:........@@@@....-:...@@@@....-::...--..%@@+.--..--.--.=.
......::.......@@.......-:....+@@@....-:....=@@@@@......*@+..=.++...%@.@@@.....=.==......................@@@@@@@@@-...+:..-=*=..-.............................@@@@+......+@@@@.....#..@@@....:+=.=-.-@+=...:-..==--...@@@=.-.-=+..@@@@=..-+...@@@@-...............................-..........@@@@@@@@@....................:.....:--...@@#@@...+..+=--..-#-:...@@@@@..=+=*=...#@@@....-......-...=@@..=.:--.-=.-.
.....:.........@@....::.-....-@@@+.#.-=.-+%%*.@@@@@@....:.:=-.-..-..@@.@@@...:.*.-+:.-.::::::::::..:=-......@@@@@@@@@@...:..+%%:+...........................:..@@@@@-.....:@@@@..+#=-.@@@@..+*-.=+....-..:-...-:.....:@@@..=#=...@@@@=......@@@@@.......:...:::....................=#-....@@@@@@@@@......=+:.:::::::::.::.......::::..@@@@@..+%..-.+:.......@@@@@@......-=....@@@+...:...:..-...+@@..=.:.:.:-.-.
..::...::.....+@@....-..-....@@@@..%.+-.+=......@@@@@@......-=..+...@@.@=...--.+-.-=.:.............:.:+#=.......#@@@@@@@@.......=............................=-..@@@@@......@@@@.......@@@....:-:..=.-.==-..=+-.....-@@@:.-.....@@@@...:..@@@@@@..-..::......................-*=:......%@@@@@@@@......--..--...........::.....::..:-..#@..@-...-:.+-......@@@@@%...%#+-.:::-...@@@...:..:::.-...=@@=.=.:....-.-.
.:...::......=@@%....=.:-....@@@@..*.+..*-.:++....@@@@@@%..........@@.@@..-.=-.-+---...............---..-=+=.......@@@@@@@@=..-+-...........................-.....@@@@@*.....@@@@.*.:...@@@%....-#-.=+.--..-+......=@@@@..=.#=.@@@@.....-@@@@@...........:::.................::.....:@@@@@@@@......-=:..=#+:.................:-:..:::..=@.@@@..........+@@@@@@...=..:-..-:.....@@@=.......:.:...-@@@....-.-.:.:.
.............*@@*..=.+.:.....@@@..=..-..+-..-.-@=...@@@@@@@@+...+@@@+@@#...:-....:-.................:.......::.-+=....%@@@@@@@..............................-..=+...@@@@@=....@@@#..::..@@@@@...-.-.:.....-::.=..+@@@@@....-...@@@..-..@@@@@@.......:............................+@@@@@@@@.....#%=....=+....................:::........:@+.@@@%.....+@@@@@@@....%.=*.-..-:-.-..@@@@..:.::.:......@@@..:.+:-.....
.............*@%=..=.+......+@@%.-:.......+#.-=.=@....@@@@@@@@@@@@@@.@@..+#+.:++:..:.-............:=.=-.:--......-.......@@@@@@@............................=..-.....#@@@@@....@@@@.=+...@@@@@=..+=-......:-=-...@@@@@..+.+...@@@+....@@@@@...#*+.-............................=@@@@@@@......:=...::.-..-.-:...............:-:...:......@@@.@@@@@@@@@@@@@@...*@*.-.-+#-.*.=.*...@@@..::..........#%@..-.*-:-....
.:--:.-+=:...@@%..-..=.--..=@@@..:.=:-.=+=-.:.=#..#-....@@@@@@@@@@#.@@@.....-...-:.-.-..:..:..:....=........:-=-.-.==#*.....@@@@@....:-::--.....................%@@....@@@@@@...@@@..::...=@@@@=.....*++:.-:...+@@@@%......+.@@@#..@@@@@@...=#..#..............:...=+-....--..@@@@@@................::...:-..............:.::::--:.::....@@@.@@@@@@@@@@@........=......:+.-.+...@@@...--:=-......-%@-...+-.-....
.+:.:.=::--.%@@-..-..:.-...@@@@....#.-.....--:..:-..==........++...@@@=...:.:+*+-....:.....:..:....:=========-:..=#+...-:....-@@@@..+.......-----..................#=....@@@@@@%-@@.--......@@@@=...-+.+..=-...@@@@+..:-:::..@@..@@@@@@#...+..%................:.---.=:=-.*..@@@@@.....-=-*+=----=---:::-:...............:.:..---:..:..=.%@@@...@@%.......-:=##=.-:-=*#+-...-...=@@@..--.---:.:...*@+..-.:..-...
.+.::.=..=..@@@..-.--..-...@@@@....*.=:=-=................:-......@@@................................................:.........@@@@...+=#.#+-......@@@@@@@@@@@@@#....-.....@@@@@@@@...--++*..@@@@....+.-..-.:..@@@....-..=#..@@@@@@@@..........@@@@@@@@@@@@@*.....=-.%.==-...@@@...=.#-.-.-................................::.....:......=@@@........:..........................-@@@-.-:..--..-...=@#.....-.=.:.
.+.-:.-.:-..@@@..-.--..-...@@@#.-:.=.=.==-:...............:++.=...@@@................:............................::::..........@@@..#=.+.+....@@@@@@@@@@@@@@@@@@@@@....+-...@@@@@-..:..++.-.=@@@..=....+:.-..@@@-.==..+=..=.@@@@@@.........@@@@@@@@@@@@@@@@@@@@...-.##..-..@@@@...=.=..=-:.:....::...::...::::::::::::::..::....::...:...@@@@...:...-.............:.:......::...@@@#.-.:.--......=@%.....-.=.:.
.=.=:...-:.-@%%..-.-:..:...@@@..=-.=.=.:..-:.............:*.@..-.@@@@...............:.............................:::::..::.:...@@@@.-..-....@@@@@@@@@*......*@@@@@@@@%..-*+.......=::-..=+*..@@@........-....@@@..-=*..#%+.:.........=..%@@@@@@@@@+=-+%@@@@@@@@@@.....+=..%@@@...=#.*:..-:......::...::..:.............::.::....::....:...@@@...--==:...........................@@@@.:.-.-..-....-@@#......-.:.
.-.+....=..+@%+..-.=.....:+@@@..=-.-.-...:-...............=.#....@@@#..:............::...........................::.::....::-:..+@@@..=#+..+@@@@@@...............-@@@@@@....-++=.-=--..*%=...=@@@..+..........@@@..+..++...+:.....::-...@@@@@@-..............@@@@@@@..+.-+.@@@=..==..+:....:.....::...::..:.............::.::....::....:...@@@=.-#-:...............:.....:...:....@@@...-.=.-.-...:#@@..-...-.:.
...+.-..-..+@#:..:.=.=-..-@@@@.:=:.-..:---:..............:*:#.:..@@@..::.........................................-:........:....%@@@..:...@@@@@.........:.-.-.......@@@@@..-=.:#.::.-#*..:#..@@@@....+@@@@....+@@@..@@..#@*.=..-+%+....@@@@@......-:...........=@@@@@..@.+.@@@@....=*+..:.::.....::...::..-..::.........:...:.....:...:..:.@@@@..=.=-:.............:......::......@@@...-.=.+.=.:..:@@..-:..-.-.
..:+...:-..#@*.....=.=...-@@@+.-.....::-:..:............:.+*#.:.%@@-..-..........................................--............:@@@..+...@@@@@.......--:......=*#-...@@@@@+..::.:@**:=+==...@@@@-....@@@@@.....@@@@.....:.+.=.....:..@@@@@-...---.......---......@@@@@.#.:.-@@@........----...............:............................:...+@@@..:.%--.............-...::...::....@@@...-.=.+.=.:...@@..-:..-.-.
.-.:=+-.:..%@+...--..--..+@@@....----.....-.............:....-..@@@................................:::::.........::.-+++-......@@@@..+..+@@@:..-:....--===+==----+=....@@@@@.....-.#.......@@@@#....@@@@@@@.....@@@@@......-........@@@@@...:....-#%*=-.....:.....=@@@-.....%@@@@....==:....::-:........:...................................@@@*.===.-.............:....:....:....@@@--.-.=.=.-.....@@=..=-.:.-.
.-..--....=%@:.::::..::..%@@@....:-:...:--:.............:-+.:*.=@@@...:...+@@@@@@@@@@@@@@@@#:..................::...........@@@@@@..=:..@@@@..-=----:.......:.....::....@@@@@@@%......+@@@@@@@+....@@@@.@@@@.....@@@@@@=.........@@@@@@@..=.*.-+.:......-=+=-:......@@@..:...@@@@@#..................................:+%@@@@@@@@@@@@+....-..:@@@....--.............:....:.....:...%@@%=.=.=.::......#@+...-:..:.
.:.=......=%@-.--..-.=.:.@@@#........:....................*.:-.@@@@......+@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#=...............+@@@@@@@.......@@@-..:.............:.............@@@@@@@@@@@@@@@@@@@.....@@@@@..@@@@.....%@@@@@@@@@@@@@@@@@@@-.....*:...::..:..............@@@#..=...@@@@@@@%...................=@@@@@@@@@@@@@@@@@@@@@@@@@@@@%-.-...@@@...-...............::...::...::...+@@@=.-.=:...-.:..#@=...=-..:.
.-.=..:.:.=%@=.:..:-.-.:.@@@=.......::..................-.+....@@@@......=@@@..-@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@....%==..@@@.................:....:..::::....@@@@@@@@@@@@@@@.....#@@@@+...:@@@@@.....=@@@@@@@@@@@@@@@:.....=+-.-=.-:.::....::...:-...@@@@..:.:...@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@..@@.-..:...@@@..:-...............::...::...::...-@@@=.:.=:..::.:..#@=...=:..:.
.-.=..:...=%@=....:..-...@@@........::..................-.=....@@@%......=@@@@@............*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%......-.*..@@@-.................::.....::::........@@@@@@+......=@@@@@@.......@@@@@@.......@@@@@@@@=........--..==..--..:....::...--...@@@%..-=..=...@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%=...........@@@@@#......@@@..-:...............::...::...::....@@@+...-:..:..:..#@=.:.=:.:-.
.-.=..:...=%@=...::..:...@@@......:.::..................-.:-...@@@=....-...@@@@@=..%=....................+@@@@@@@@@@@@@@+......-##-+:#..@@@@................:-::.......--:................@@@@@@@@..=@@@@@=..@@@@@@@#...............:=+*+..=+..:=-..::....::...-:...@@@......=*.:.....@@@@@@@@@@@@@@@@@*=:...............#%.:..%@@@@@........@@@#.+................::...::...::....@@@#..::-..:..:..#@=...=:.:-.
.-.=..:...=%@=...:.......@@@........::..................:..:...@@@...:.=....-@@@@@....-=--:..............................==:.:.-:....=..*@@@................:............:=.-.:#@@@@@@@@@@@@@@@@..@@@@@@@@@@@@.:@@@@@@@@@@@@@@@@*........:+-.-+-.....:....::...-...-@@@...-=...-.-@%................................:--:......@@@@@....--:...@@@@.*................::...::...::....@@@@..-.-.:...:..%@=...=-.:-.
.-.=..:...=%@=...:.......@@@........::.........................@@@...:.=.::...@@@@@.....-:..-=-:--:.......::-::....:=+........--.++-:-...@@@@=.....--=-....:...-=++-:.....+.=.+++@@@@@@@@@@@@...@@@@@@@@@@@@@@@@..@@@@@@@@@@@@@*+-..=+==+=..==...::...............@@@@:.+.@.*:...-...#.:-.................--...-+*=:..-:.=...@@@@@...:.--:...@@@@.+..:.............:....::...::....@@@@..=...:......%@=...-:.:-.
.:.=..-...+%@-.-.=:--....@@@.....:..::..................:-=-...@@@..:..-:.-....@@@@@-..-..:--.-..--:...:::--::---.--....-=--:--..-...=+...@@@@@.....=++=-.....:-:.............-=#+....*@@-....@@@@@@.......=@@@@@....#@@@@@....=:=.:...........:-=++-:.-===-....*@@@@@.-.:+.%.+.:++#+=..==+--::.........:::...:......:.....+@@@@-..:.-.=:....@@@@.:..:..............:::::.....:....@@@@..----..-.:..#@=...=-.:-.
.-.-..:...+%@:.-.=.-:....@@@........::.....................:-..@@%...:.:-..:....+@@@@@..-..--.:.............::.....:---...:-:..::......-@..@@@@@@.......:............::........-@@@@@@#......@@@@#............@@@@+.......@@@@@@...............................@@@@@@..=...-+.+..:--..--.....---:::::..........-#+.+-*.=..@@@@@.......--.....+@@@..:.-.............................@@@@........:....#@+...-:..-.
.:.=..:...+%@-.-.=.-:....@@@........::..................:...=..@@%...-..:=:.-=-...@@@@@..+..=+.-:.--.............::.............--.:.-+..-..@@@@@@@@-..........+@@@@@@@@@@@@@#....#@@@@@=...%@@@.....--........@@@@....@@@@@@:....-@@@@@@@@@@@%.............@@@@@@@......:==:.=...........................-....-.-=..-...@@@@@...-=.:::..:...=@@@..-.-.............................@@@@...:....:....#@+...-:..-.
.-.=..-...+%@-.-.=.-.....@@@.....:..::..................:...=..@@%...-.-..-:-.:...=@@@@@..+..-+.=................::............=-%+.:-=#+.....@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@....=@@@@@..@@@......+..-==-....@@@...@@@@@+....@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@...:.-+-.....-...........................=.+==.:#.+#...@@@@....:-.+.=:.::...+@@@..-.-.............................@@@@.......::.:..#@+...=-..-.
.-.=..:...+%@-.-.-.-:....@@@........::..................:...=..@@%...=.--..-===:....@@@@@..-.-=..:==.............::............-.:-..=..--.-#...*@@@@@@@@@@@@@@@@@@@....#@@@@@@@@+....@@@@@.@@@...--.=:-.:::....@@@..@@@@*....%@@@@@@@@@@#%@@@@@@@@@@@@@@@@@@@@:..-=.......=*+-...........................=.#:.--..=..=@@@@........==.--.:...+@@@..-.-.............................@@@@.............#@+...=-..-.
.-.=..:...+%@-.-.-.::....@@@........::...................:..=..@@%...=..=:..:-:..=-..@@@@@...-...%.+-............::............=*=.:.=+-.--..-.......@@@@@@@@@@-.............@@@@@@....#@@@.@@@@...=:.-........*@@@.*@@@.....@@@@@@............*@@@@@@@@@@@%........::.=-.-=:.............................-..+=.-:....@@@@.....-+#-.--.=.:...+@@@..-.-.............................@@@@..:.......:..#@+...=-..-.
.:.-..-...+%@-.:.-.::....@@@.....:..::......................=..@@%...-.-=..:....:-....@@@@@......@.+-............................:.=.....--.=:...................++..-*#+=.....@@@@#....@@@*.@@@@.............*@@@..@@@*....@@@@@...-==-......................-*.:..:-+=.-=.-+-...........................=*:.%#-+..+@@@@......-.:-:-=.=.:...=@@@..-.-.............................@@@@.......:..:..#@+.:.-:..-.
...-..:...=%@-..:..-.....@@@.....:...:.....................:-..@@@....:--.-.....:=:-...+@@@@...-.#.=-............:-----=+*#+-......=.-=-.==.*+*+=...................:....==::=..@@@@=....@@@..@@@@@.........@@@@@@.%@@@....%@@@..........-=--....-.........---..-#-......=++@-+==-:.:----=+=-.::::::::::..-.=..-...+@@@@.......-++.....:.....+@@@..:.:.............................@@@@..:..........#@+.:.--..-.
.-:...::...#@+..--::.:...@@@.....:...:....................::...@@@...:-...-:---:.=++-....@@@@..-.%.=-.......................-=++---:..:-:.--:..............+@@@@-.....=++.:-:.-..@@@@....@@@..=@@@@@@@@@@@@@@@@@@..@@@*..:.@@@=...=*#+-........................=-..-=-=-..:.--....-=-.......-..:::::::::.:+=.:-...@@@@@....:===--:::--.......@@@@.-.:..............................@@@+.-::::.:-....@@=....-=.=.
.=-...:=...+@*...--......@@@.....:...:.........................@@@...-................-:..@@@@...*.=:..............:.............................#@@@@@@@@@@@@@@@@@@.:.....--.*..@@@@..:.%@@#....@@@@@@@@@@@@@+....@@@=..-.@@@....-..-:.:..=@@@@@@@@@@@@@@%............:---..-#@#.....-+*##*=....................@@@@@..............:.-.-:...@@@@.+................................@@@......:.......@@......+.=.
.+...::-...+@*...=-......@@@%....:...:....................-....@@@-...................:...-@@@@....-................:-=++=-..::...--......@@@@@@@@@@@@@@@@@@@@@@@@@#..-=#+==..-..@@@@....@@@.......................@@@+..:.@@@...@..=+:.+..%@@@@@@@@@@@@@@@@@@@@@@-..............-=-..--.......:::::::::..:-=....@@@@.................-.::...@@@@.*.:.............................+@@@..:...-.:.....@@-...-.=.-.
.+.:..::...+@#-..=:..:.:.#@@@:...:...:....................-....@@@#...................==...@@@@+..=..............=+=.................@@@@@@@@@@@@@@@@@@@=.......@@@@=...=-.-#-#..@@@*....@@@....@@@@@@@@@@@@@@-....@@@@..-.@@@#.:.%%-..-=.-%@:.....%@@@@@@@@@@@@@@@@@@@@.......:..-=+=..-+#*+:............=.+...@@@%..................:..:...@@@*.+...............................@@@@..-.-.-......-@@-...-.....
.+.-.::....=@%=..=.-.-.-.-@@@+...:...:..................:.-....@@@@...::..............=-:...*@@@-..:.............-.::---=++.....+@@@@@@@@@@@@@@*-...........@@@@@@@..+=.:-+=....@@@@+...:@@@.@@@@@@@@@@@@@@@@@@@@@..@@@....*@@@..:...#@:.*.=@@@@@@.........:*@@@@@@@@@@@@@@@@...............-.............+....@@@@....=+-............:......@@@..-:.:............................@@@+....-.-:.:-..%@@-..---..:.
.=.=..:.-..=@%#..-.=.-.=..@@@%...:...:..................-.-....%@@@..:.-.............:.--....@@@@................-.=-.......%@@@@@@@@@@@@@.............@@@@@@@@@@......:.:=....@@@@%....@@-@@@@@@@@@@@%#%@@@@@@@@@@@:@@+...+@@@@+...-:.:-....#@@@@@@@@.............+@@@@@@@@@@@@@@.....=+..=-..:::::::::..==..@@@@..:.=-.=..............-....@@@...-.:............................@@@....:-..-.--..@%+-.:-.--.-.
.=.=....=-.=@%#....=.=.=..%@@@...:......................-.=....-@@@..-.=............:-........@@@@................:.....%@@@@@@@@@@@=..............+@@@@@@@@@@.....#@@-......@@@@@=..=..@@@@@@@@...............+@@@@@@.==....@@@@@@.............@@@@@@@@@@..............:@@@@@@@@@@@@+.......................@@@@.....=:-=..............=:...@@@...-.-............................@@@.....-..-.=-..@#.=.==.-+.-.
.-.=....=-.:@@@....-.=.-..-@@@..:..-+=...--.............-.-.*#..@@@-...=..::......:.--.:.:-....@@@@.....::::.=*=.....+@@@@@@@@@#...............#@@@@@@@@@@.......=......-@@@@@@@@....+..@@@@@......=@@@@@@@@.......%@@@%......@@@@@@@@@............@@@@@@@@@@@%...............@@@@@@@@@@@.....---..--::=.--.@@@@=.......--.:--::::......=-..*@@@.-.+.-.............:...:----:--...@@@.:...--:..--..@#.-.==.:*.=.
.-::.-:.:--..@@-...:.:.:...@@@..--.#.=:.-:-:............---.=...@@@@..-:.:.::....::.:-:.=.=-...%@@@....--.=.=-....%@@@@@@@@..............%@@@@@@@@@@@@@.....#@.....#@@@@@@@@@@@-..:%@#-=.......:@@@@@@@@@@@@@@@@......==---....-@@@@@@@@@@@=....:.....-@@@@@@@@@@@@%..............+@@@@@@@@@......=-..:.:-.=@@@=.....-=--::--::::::......-.=@@@..#.%.-...............::-..:.#.=..@@@@...:.:==-....-@@:...-=:*.+.
.............@@=...........@@@..=-.+.+.:..-................-%+-..@@@=......::....::.::..+-+:....%@@@..--:-:.-.#..@@@@@@@...........@@@@@@@@@@@@@@@:.....:+.......@@@@@@@@@@..................+@@@@@@@@@@@@@@@@@@@@.................@@@@@@@@@@@@..:.=......:@@@@@@@@@@@@@@.............@@@@@@@@=.--.++.++=..@@@#...:..............::........@@@@..+.#.-.............:-.--..+.#....@@@%...-....:-...+@%..*....+.+.
.:.::...:::..@@*.....::....@@@@.-.:.--.-..-...............:.:=.-.@@@@.:....::....::.....:--.:...=@@@@.-.-*......@@@.......:*@@@@@@@@@@@@@@@@@@.......-..#=..@..@@@@@@@@..........:......++..+@@@@@-..........@@@@@@....................:@@@@@@@@@....-.=........@@@@@@@@@@@@@@@@@+........=@@@@..++..+..+.@@@@-...--...:--...::..::...--...@@@@.=..:.:.............::.-.=.+.:=...@@@=...-=-=:.-...#@#..#....=.=.
.::..........*@@+..:.-.....@@@@....-:.+:==.-............--+=...#.@@@@......::....::..---....-....=@@@..#.+:.=...@@@@@@@@@@@@@@@@@@@@@@@............::..:-.-..@@@@@@:........:::::.......=..@@@@@......=:..#=...%@@@@.....::::::-:..=.:......@@@@@@...-.+..#+-........+@@@@@@@@@@@@@@@@@@@@@@@@@....=:@-...@@@@..-:..==..--...::..::...-:...@@@...--..:............::.:-.+.=-.=+.+@@@...-.-=--.-..+%@+..=...::.-.
.-...:.......=@@%..:.-.:...=@@@-...+..+.+=.-............-..-==.@..@@@......::....::.-=:==----.....@@@@....#.#.*..@@@@@@@@@@@@@@...........::.......=+@@@....@@@@@....**=..::.:-::....:.....@@@:....++-.--...-.=..@@@@..............+.=..:.....@@@@@..=.#@+=-...=%%-.........=@@@@@@@@@@@@@@@@@@.=.....=..@@@@...-=.:.=..-....::..::...:-..@@@@...+.=.-.............:.::.+.-=.--.@@@:...=....+.-..@@%=..-..-...:.
.-.::::::::..:#@@..-.=.-....*@@@..-.-.-.+-.-............:=-....=..@@@......::....::.:=......:-=-...@@@@...#.=..............................=*%#=........-..@@@@@...=:......:--:.....:....:@@@@..+#-..=..+##::..*..@@@...:--::......=-.+%+.-.....@@@@*...-...........-==:.............@@@@%......-@@@@....@@@......:+.+.......::..::......+@@@=..==.*.=.............:-....:--.=.-@@@....-=++:+.-.:@@=....:.=.:.:.
..............-@@....-.-:....@@@...:.-..-..-............=+#=..++..@@@@............:..-==-:----:.....@@@=.=.=.+#-....==...=@@#.*@+.:--=++=--....--=-.:++#..%@@@@..:=..-....-:.............=@@@...=.-@@%+%=.:.--#.=.@@@...............:............@@@@..++-.*%##*%#+-...---...:-.=+:...........:=.....=:.@@@@....::.-=+.-=-...............@@@@...-..+.=.............=-=.:.--..-.@@@@.......-.:....@@.......+.+.:.
.-::::::..:....@@-...-.--....@@@*.-%.#..-..-............-..=+.=...=@@@#..::.:===-::....:--:....:....@@@@....+.....-=...-:....--................-..-++.....@@@@....+##..=+-=:.-+++-.:.....=@@@...=+=.......:.=++...%@@%-...-=++-..:.:..+*+=-=++=...@@@%..:+-.....--..-=:..:.-+=.....-:.=+-.=#+-.-+----..*@@@.........:..:.==-=+=:...=#*...@@@....=%=.==.............-.=-.-....-.@@@+....::.:.--.:@@#.:..=++=.=.:.
.:..::::::::...@@#-..-.-=::..@@@@.-..%.+==.-............-#+.#.=.:..@@@@...:.----.............::.::..-@@@..=..+=..:..=+=..-#@@+.:---.-=++=.:=+*+=..:-.=...:@@@........:....-...:......--..+@@@-....-#.........+-.+.@@@#-.......-:::-+*+....:-..-:..%@@@....:.:..---.-+++=-....:-=*#+:....:..:=+-:-.:=...@@@.....:---:..:=:.-.-.---.-+.:..#@@@...=#...-..............--.-::-.....@@@......:.:::..@@=.-=:::-:..-...
...............%@*-..-..-.....@@@..+=.=.-=.:............-.#.#.+.....@@@@....=..---........::.::......=@@@.:=..-.::...............................:-=.*....@@%..--..::+=-:.:--.=**+..=+-+..@@@-.*=...@@@@@@....---.@@@...++..+*=........=..:.=+:...%@@@-.-..=+-..................................-=.==.@@@@..............=.=.=-..:.:-+=..@@@@..-+-+=.=-..............:......--.@@@.....---..-=..@@..:-=-..:-----.
...............#@#+..:..-.....@@@+...--.-:..............-.=--.+.-...@@@@....+.-=:..---....::.::.......@@@-.#..-.::...........................::..:.::=....@@@:....:-.::--...-........-....@@@...:...@@@@@@@...-...@@@:....::....::.....:-.:-...=..@@@@...-....-............................:=.:..-....@@@@.....::.......-.=.:-..:-.....@@@@..:.....................-.:..:..-.=@@@...........-..@@.-=-:..-----:=.
...............+%%#=-...::....=@@@:.-=..-:..............-....:=.-....@@@@...=.+-...+.+....::.::.......@@@@.=:.-..............................::.--..:...-.@@@#....:+.....:=-=:..-==.-*+..%@@@.#.-..@@@@.@@@%..-....@@@...=:.:.-=:-.:--..--..-++...@@@@..#=..-..=:..........................:-.:...--..@@@......::.......-.-...:-::....%@@@...==..--.==............:=.+.=:=...@@@@.............:@@..--.........+.
...............:*%%#=.....:....@@@@...=..:-.............-:.:::..-..-..@@@*....+....+.*....::.::....-..=@@@..-.-.:............................:.:--.-:.:.=.@@@@.....--.....:-:..-=-.=....+@@@@.%.-.%@@@..+@@@..:....@@@@.....=:-::-:-:-...:.-:....@@@@+.#=.+-.:..-...........................-..:..:..@@@%......::..:....:::..:-=.-...:@@@@....=-.-:*.-.............=.#.+.=...@@@........::...-%@@......::...::=.
................-%%@=.....:....-@@@..-*+..=-............:.-==..=:.-...@@@@...--.--.*.*....::.::....+...@@@%.-.=.-:...........................:.--..*.--.*..@@@@*..--..::-:.....-:..:...@@@@@..#...@@@....@@@.....:..@@@@-...:....-:..:::........@@@@@..#..=.:..=-...........................--.:....+@@@.......::............---.+...@@@@..-+::.-=.@.-.............-.+.+:...@@@@....:..--=-..*@@+....::...:-==-.
.............:...#@@-.....:.....@@@@...=+.--............:.=:.:=:.+:.:..@@@-....::=.+.+........:....+...-@@@...=.-::............................-...%.--.+..#@@@@=.....:-==.---........#@@@@..#*-..@@@....@@@@..:--..-@@@@......-.-=-...........#@@@@....+#..+:-:.............................-.:.:..@@@@..-:...::.........:::--..=..-@@@....-#+..#.+--.............-.-..=..-@@@-...-:.:---=..#@+...::....:--::..
.............-=..-%@@=-..=-..:..-@@@@..=.##...............-:.-=.:=::-...@@@%..:..-.-.=.:--::..:...:+.-..@@@-..-..::............:-===::--:-=-...-++:=.-..==...@@@@@*......:.........-@@@@@@.......-@@@....#@@@....:...=@@@@@*.......-.....:...+@@@@@.......--..+-=.........:::...............--.==-..@@@...-:....:..::::::.:...:-....@@@@.:.....:.-:................-..+.:..@@@%.......:-....+@@+...::.........:.
.............=-.=.-@@%-...:......@@@@.....................:-=:.==....-..@@@@...:.:.....:-::.:......-.+..@@@@..:..::............:.....:-:::..#%=....+%#:.......@@@@@@@@..........=@@@@@@@@...=:::.@@@@.....@@@-..==-...%@@@@@@@@............@@@@@@%..+=-=-..-=..-::-::-==-....:.............:=.:=:...@@@...-:.......:::::-......-...#@@@...::-==:...::.................:=..%@@@.....=:.--.-..@@@.........::----:.
.............-=.-...%@:......--...@@@@...++-.............................@@@@...-..---.............-.-..+@@@..:..................:..::..........................@@@@@@@@@@@@@@@@@@@@@@*.....-....@@@@.....@@@#...-=..=..+@@@@@@@@@@@@@@@@@@@@@@@..=............-=-.......+#*-..............-=.=:...@@@@...:.............:.::.--...+@@@=............................-.--...@@@=...-.=..---..+@@-.:...............
..............--.:-.%@*...--=.....%@@@+..................................:@@@@.....=.-............:=.=...@@@..:.:.:............-=:.....:=-.--.....%@@@@@*.....+...*@@@@@@@@@@@@@@@@@...=*:-.-....@@@@.....@@@@...=-........+@@@@@@@@@@@@@@@@@%..........+@@@+.......-:.::...-:.............:-.=....@@@#...-:.............::...:..+@@@@.............................=.*...@@@@....-.+.:....-@@#..:...............
...............--.:.=@@*:.-.=-:....*@@@..-.:..............................-@@@@...:..-.............=.=...@@@...--.:............-.-#+.#@#.....@@@@@@@@@@@@@@@@.........-@@@@@@@@%..........=.:....@@@+..:..=@@@.:.=-.:=-........:@@@@@@@@@-.........@@@@@@@@@@@@@@@........*#=:..............::....-@@@=...::....................-@@@@..:..........................:=.*..@@@@....:-.=.-....@@@...................
.................=...+@@-.....-.....@@@@..............................:.+..+@@@@....:..............-.-...@@@*..-:.-............-==..--....@@@@@@@@@@@@@@@@@@@@#..-+...................-=-.=.:....@@@-....:.@@@.:.=-.....#@@#:.............-.+-..+@@@@@@@@@@@@@@@@@@@@..+@+..................:.....@@@=:...-:............:......:@@@@..--..........................:=....@@@#..:..--=.-...#@@=..::...............
.............:--.-=...@@#..:-:-.....@@@@+.............................:..=-..@@@*..-...............-..-..%@@@..:..:...............=-....@@@@@@@=.........@@@@@@@@.....*+..:....-:..::.-=+.-.:.:..@@@..-..-.@@@...--..:-.....=#%*++..=....-..@..@@@@@@@.........%@@@@@@@....:++..............:.-.:.@@@.....:...............++-..@@@@..-.-............................-..@@@#...+......-..#@@+....-...............
.............-.--.:+..*@@+....:......@@@@............:................:-.....@@@@:.................:.....=@@@........::.....::.:-.....@@@@@@@...............@@@@@#.@#+..--......:...--..-.:.:.:..@@@.....-.@@@...-:.:=-.:=++-....::*:.-.:.....@@@@%...............@@@@@@@....=#-...:::..--..::=:..@@@.............:::::...%...@@@@....:-.....................::.......@@@@..:.=.==-.....@@@.-.%.-...............
.............-:.-+.*-..#@@+...-.:-:...@@@@..--=.:..----=-=...............=-...@@@@+..............--:.:-..:@@@=...=--.----.---=-.....@@@@@@=....-==+++=--.....-@@@@.:.=:-..:==-:-=++=..++#-=.:.:..@@@...-...@@@.-.---..--:.....-===-=-..:-@@=.@@@@...:-=--:..::-.....+@@@@@@.......-===-...-.==.=..@@@.:...=++....-----:.::-..@@@@...++-...............:-=--.---......:@@@=....-..-=-...+@@..@.%--...............
..............-..==.....%@@-..=.......*@@@@.:.#..=:...==.=............-::.+.-..@@@@#....---...---....-:...@@@@...-.=-..::.-:......@@@@@@-.....=................@@@#.#:..:.-:............-.-......@@@..:....@@@.-......-:..:::......-.-+......@@@..............:---....-@@@@@@..........=*=:....=..@@@.:..:+.+:...:::.::.....@@@@*......:............:.....:-..----...@@@@...--..-:....=@@#..%.-.................
...............:...:.:..+#@%....=:.....#@@@=..==.-=..*=.+-..............-.-..+..@@@@@...:---.:-..:--.-....#@@@...--..++..=+.....@@@@@@-....+=.=................%@@@.=.:--::.............=.=......@@@...:...@@@.--==-:..............-.-..--..@@@#................:+%#....-@@@@@@...:+=.....-=...=..@@@.-...++-.:............@@@@:...=-..................-=+=..=-.....@@@@..--=:..-=-..-@@+.=.+--.................
...............::..:...:+%@@@...:--.....@@@@..-..::-.+.=..............:=:....-=..@@@@@....:.::..:....-...:%@@@...=+-...-=.....@@@@@@-.......++=.............:...@@@.-.----..............=.=.:....@@@:..:...@@@...=--:..............=.+.-.-..@@@*.....................-....-@@@@@@...::.+%+-....=..@@@......-:.:-.-=*+=....@@@@..==..-*#=.............----:..=..-=..@@@@...--:.......-@@@..+-.==.................
.............:::-..:....:+=@@-...=-.:-...@@@@...:-.-.+.-.:............-.-:..:.-*..@@@@@.....:..-.---::....#@@@..:-.#:.==....@@@@@@-......:-.................:...@@@.:.=::-..............=.=.:....@@@=.-:...@@@...:.:...............=.+.-.-..@@@*.................::..:......-@@@@@@.......+##..=.:@@@....:..-.-..+-.....:@@@@.......................:-.....--.=...@@@@........:.....%@@=.-.=+.=.................
.............-.:=..-:-=....%@@-..:..-+....@@@@.....-.-=...............:.=:..:-.:-..@@@@@%...-.-:.+.--....:%@@@...---=-....@@@@@@%....-=-.....::................@@@@...=.:=..............-.+.-....@@@%.-:.:-@@@...-.-:..............-.:...:..%@@@....................:===-.....+@@@@@@......=--.=.+@@@..:.-..-.-..+.-...#@@@@...=@#:-.%%=............-:.:::..:.-..@@@@...=.......-:-*@@+..-:.@.=.................
.............-..=..=-=++...-@@@....--=.-...@@@@........==-............-*+.--.=+-:...@@@@@+.......=-=:....:%@@@....:.....@@@@@@#............::..................@@@#..--..-..............-.-......@@@@.-:.:=@@@.--=.=-..............::.:......@@@:..................:............@@@@@@@......-.=.%@@@..-.-..=.=..-....@@@@@...=-....-=.-............:-=*--.-+...@@@@%..:.=+--..-:.:@@@..:::.++..-...............
.............:.:=..=...-:...:@@@.......-....@@@@.....=...:............:...-:...:.....:@@@@@....-.....:-..:#@@@.:.=....@@@@@@+......:=++=..:...:-:....--:......@@@@...=..=:..............:.+.-....@@@@.:...%@@*...--:................:=.=:....@@@@...-:........-:..::--.::..::.....#@@@@@#....-.=.%@@@.....-=-.-=+....@@@@@...:..++...-==..............:..=-.=..@@@@@....-...-....-@@@..::..:.-=.-...............
.............::.::.-===-.:...=@@@......:.....@@@@....+.==-............-===:.--:..::....@@@@@...:--.-===-..#@@@......@@@@@@@....-=.:-:::.----:.::--...-.-..-..@@@@...:=.:===:.............-*.#....=@@@....-@@@.-=-.-.................--.:+.-...@@@@..-=....:.:.-.:.--::.:--=--.:-....+@@@@@%......-@@@.-.:.=-:..:...#@@@@#..:*.:....:.:................=-.=....#@@@@...:.==*+....:@@@....---:=.=.-...............
....................:::.......-@@%...-.=-.....@@@@...=.+...............:-....::::...:...@@@@@....=....:..:#@@*....@@@@@@%....-=+=........--:.:-..=-..-:-.....@@@%.--..-*..=-..............-.#.-...@@@....+@@@...+..--..............:..-.*.+:=.=@@@%..-+=:.-.=.=:-.---:...::-:...==....@@@@@@%.....@@@..:..--::....@@@@@....--..---..................-:-=.=...@@@@@...:-.:.:.....%@@.........:::.................
...............................=@@@:....-......@@@@..-...............................=...+@@@@@...:.--:..*@@@...%@@@@@@....-=-..:.............:=..--.--:...-@@@@..+-*+.##:--.............:*#+.=...@@@+...@@@@...+...--.............-.--.-:+....@@@@...--..-.=.--:............-=-..--....@@@@@@%...@@@.=..=:.....*@@@@@...-..........................-:.=....@@@@@...:-..:.-...-@@@-.............:...............
............................:.-.=@@@:..:+.-:...=@@@@..................................:....@@@@@.........=@@@*@@@@@@@....:-.....-..............----........@@@@=.%..+#..-=-...............--..-...*@@@...@@@....=..:.-.............-:-:=.....=..@@@@...+....-................--.==..-.....@@@@@@@-@@@.-.=:.....@@@@@...*:+...........................-.-=..@@@@@...:-.:-.....+@@@+..............................
...........................--.#..-@@@-..-.=.-....@@@@-..............................::..-+..@@@@@@.......+@@@@@@@@@....:......--:............::..-..-=-..=@@@@...+.=--==.:=..............:-.:-.---.@@@..=@@@....+...-:.............::.--.:.==.*..@@@@....:...---:............-+=..--.=+:....@@@@@@@@@........=@@@@@..@=.-+............................:...@@@@#....:.-=-:...#@@@=...........:...................
...........................-=.#...-@@@-...:-.-....@@@@%.............................:..-......@@@@@+.......@@@@@%.......--.:-................:-....-....-@@@@...=.:-..===.--............::-:=..-.%.@@@@@@@@*.=:.=::::..................:=-..=.....@@@@-..:-.::..:..............=+=:-..-+#=...-@@@@@@=..=-...@@@@@+..=..##-..........................:...-@@@@+..-=:..=:.:..#@@@=........::::....................
............................=..+=..-%@+.....-..-...@@@@-............................-::-=*:.*..@@@@@%...:-.........:=++-::...-=--............--.--..-...%@@@-.++....::..+:=-...............-=:::.#..@@@@@@@.:.+-.==-:-.............::..+#-.-..=-...@@@@.....+.=:...................:=-...-+-..............:@@@@@....=-..................................@@@@.....=-.:--...-*@+........:.........................
............................-=:.....*@@@=....-.-....@@@@@..--=*=...-+=:.............::....-:.....@@@@@@...:=:...=#+-.:.-:.:=++..-............:-..:-....%@@@%.....:.::..::-..--====+=-:..:.....--:=...@@@@@..=..-:....-...-:-:......:::-:..*....-=...@@@#....+.+...............:..............:...........@@@@@%...-++=.-:..................=*+::-:-....@@@@-..:-----.....*@@@+...::.............................
...........................:-.*+-...=@@@@+....-..-...@@@@@..:...-=.-.-...............--:--:-++-...%@@@@@.......................--..................:..%@@@@...:--:..:::..............-*#+...-:....--........=:-::-==--........::---:..-==-==+-...-..@@@@-.....:...............:--===--..........:=*=...@@@@@@...=+-..--=:..............:-:-...-......#@@@@....---.......#@@@@=..::..............................
...........................:=.........-#%#-......:.-..*@@@@...%+.:=+.*-:............................@@@@@@......-=+=:.:-:-++**+-...............=+:....@@@%................::-=+#%@@%=....:=------..........-:.........++-..----................:.:-..@@@@...+--.........................:---==-.:....@@@@@@...........................-=-.-%%:.*-...@@@@@..............=@@%:....................................
............................-==:..-=..-#@@@-..:==.:-...+@@@@@..-%*.-.-................................@@@@@@.......-=:.........................=....-@@@@...=..:..........----:......-#@%+.............--=-:...--=+*+...:--...---:.::...:--::....=.=..@@@@....+.................:-====-:...........@@@@@@#..............::............-:.....=-....@@@@@....-:..===-:=%@@@#...-..:..............................
.............................:-:::.=:.:+#@@#:..:.:=--....@@@@@...=....-:................................@@@@@@.....=-.-*#+-...=--..............-+:..@@@@..:.-....:............:-==++=-...-+++++=-...::...............:++..=##+-..:-.+*=-...:-:::.-=:...@@@@..-=.................-::...--:........#@@@@@...............................:=-.:**....%@@@@-....--..==-:-+%@@@#-..-:..::.............................
................................--..=-...+@@@...-+-.......*@@@@..=+=+=.=...........................+%%=..=@@@@@@......:...--.--.-............:.....@@@@.....:.....:::::--:.....................................................---:.......:......=+=....@@@@.....................:.::...:......@@@@@@...................................-.=.-%..@@@@@...---...-.:..:#@@@+...-...:...............................
.............................:-.:=:.:+....-@@@*....-=:......@@@@@...:#.=...........................-........@@@@@@%....=-.-...==-.................@@@@...-=.:......:.:::.............:@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@.......................:.+.-...@@@@....................--===...=-.-@@@@@@....-*...:::::::::::.::.....................@@@@@.....--.--.....@@%#=..-=...:--..............................
............................--+..=-..=--=...@@@@-.....:...-..@@@@@.....-...........................-+*=.......@@@@@@......++-....................%@@@=..:.=................@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#......:==-.........=@@@*..............................@@@@@-...:-:*+-.............::..............=*...@@@@@=...-=.:-.+:....@@@==..+#+=..=---.............................
...........................::.=-.--..:..:....%@@@=...:.-..+#..%@@@@@.....-*+-.=+-:.---.............++=.:%%-......@@@@@%....=-.+#**+=....-+*=....#@@@-...==+.......-@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#*+-:-=*%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=........----.+@@@-..=:..::---:....:#%=.....#@@@@@@....=:..#-....::::::::::.:.......----:.-+...:@@@@@...-+.:-:..-...@@@@=...=-..-..=.--.............................
............................--.-==..-:..:-=:...@@@+....-=-......@@@@@...::..=-.....................:.+=.....=@@@@@...@@@@.....=.....+@@*....*%..@@@.........@@@@@@@@@@@@@@@@@@@@@+...........................................-@@@@@@@@@@@@@@@@@@@@*........@@@@...........:....=--:...@@@@...@@@@@......%@%-.::::::::::...-++=-:-:....:...@@@@@@...-.+:..:.....@@@@...==:.==-..:==:.............................
...........................................-*+..%@@@*.......:--..#@@@@@..-==:..-++=*+-.............#@+..#..@@@@@@@@@@*.#@@@+.....-=-......=-=..*@@@....@@@@@@@@@@@@@@@@%................................................................%@@@@@@@@@@@@@@=....@@@@........::.-+=......@@@..-@@@@@@@@@@...-................:-=-..=...-:.:...@@@@@.....+*.=+:...:@@@@-..............................................
...........................................:-:..=@@@@@-......==....@@@@@...........................:..:...@@@@@@:..*@@@@.+@@@@.......#@+..-.#*.#@@@@@@@@@@@@@@@@@.......................:............................:.......................#@@@@@@@@@@@@@@.@@@.......:--.......@@@@%.@@@@#...%@@@@@....@@:............-...-..#@%=....@@@@@@....--..=.=....@@@@=..-............................................
.............................................:-....%@@@#-.-+-.#@#...@@@@@@....##--%#-:.............=..-.-@@@@=........%@@@.@@@@@@..............#@@@@@@@@@@@...........:.................::..........................::.............:.................@@@@@@@@@@+.=%%#*+-......@@@@@@.+@@-.........@@@@....:-............::*%*:.......@@@@@@........=.*+...#@@@+..--.............................................
..........................................:-==..#*..*@@@@=..*....::...@@@@@@......................:+.=*.@@@@.....=.--...=@@-.@@@@@@@......--=..:@@@@@.........::...::...............................................:..............--=+++++=-...........=@@@@@@:..........#@@@@@@@%.@@@.....:-:....@@@@...=.............:--...-+*..*@@@@@-....=-==.+....-@@@@-.=@#.:............................................
...............................................-.....-+@@@....=%#=......@@@@@%.-#..=-..............+-...@@@..-++=-..@#...@@@...@@@@@@@@+.................-#%:.==-......:::::......................................................:=::........:-..+#+#..........-=-....#@@@@@@@@...@@@..:.:.-+.:=...@@@.=%+...................-...@@@@@@....:-....-...=@@@@%..::...-............................................
...........................................-+#+.:*+....-@@@-.......+#-...#@@@@@...%..+.............-=..@@@........--.....@@@......@@@@@@@@=........-%@@=..:.=.............:.........................................................::.........:.......=-.+-........@@@@@@@@@@.....@@@......-.......@@@@....................-...@@@@@@....:-:.=#+:...=%@@@*..=-.+%+:............................................
...............................................:-..::...:@@@@%..-=.....:....@@@@@..=.=.:=-.-==-.::....*@@@..:=.....-+..-@@@@.#=......@@@@@@@@@#...........*##-..:::==+=-......::::-::-:::........::::::.....::...::::.....::--==+++-::-=*#*+-..::....:=:.:......*@@@@@@@@@........:@@@@:...=.-...:...@@@.-#=-..:=+-.:-..--....@@@@@@+....++...:.....=@@@#...=..=-..:............................................
...........................................:=++-.==-.-....+@@@@:...+#+:.....:@@@@@@.......-:..........@@@@.#*.:=+:....@@@@@@..-*-.......@@@@@@@@@@*...............::....=*+-::--::.........:.....::::::-..:::::-:::::-=---:..................--::...........%@@@@@@@@@@.............@@@@@.......++-...@@+...---:..:=-.-+....@@@@@@%...-=......:...=@@@@...--.:-..---............................................
.............................................................#@@@+........+=...@@@@@@:....:..-+=..-...@@@+.........@@@@@@@-......-%@@#.....=@@@@@@@@@@@.............:--...........::...:----::---:.....----::::::::::.......:--====-..-----:............@@@@@@@@@@@.......*+-........@@@@@@...........@@@..=#:.==-..++-...%@@@@@@........=*+=...-@@@@*..........................................................
........................................................-...=%@@@@@:...*+.......-@@@@@@.....-=-..*++=.@@@........@@@@@@@....--.-................@@@@@@@@@@@@:..........::==---......................:................-===---......................=@@@@@@@@@@@@@.............+%*::....+@@@@@@%........@@@.....:::-:.....:@@@@@@.....:-+*.==...=@@@@@=...........................................................
........................................................-.-=-..-@@@@#.............-@@@@@@+....*#--..+.@@+...=@@@@@@@@@....:-..-:=--:...--...........@@@@@@@@@@@@@@-............:+#%%+-.::......:----==--------------:.......................=@@@@@@@@@@@@@@+.....-@@@#-.-++..:..=++=.....@@@@@@@@%....@@@=....-=-.....@@@@@@@.....-----+.....%@@@@...-..........................................................
........................................................-:-......#@@@@-....--==-:....@@@@@@@......*=..@@%@@@@@@@@@@@..++.*#:..==-..:--:.::.:=++--.......@@@@@@@@@@@@@@@@@@+...........................................................*@@@@@@@@@@@@@@@@.......*@+..........-:-#*....-.=#...@@@@@@@@@@#@@@*.-+...:...@@@@@@@....+%*:...:....#@@@%...:.+..........................................................
........................................................:..-+#+....*@@@@....:..==......@@@@@@@.....--.@@@@@@@@@@.................-++=-..--......:--..........%@@@@@@@@@@@@@@@@@@@#........................................:#@@@@@@@@@@@@@@@@@@@@@@.........:--...-=+-..+%#+..-...*#+:..........@@@@@@@@@@=........@@@@@@@....-:...-+-...:%@@@@=...:=.=..........................................................
..........................................................:==-.--...:@@@@@+......-=......@@@@@@@......=@@@@........:..=-..=+*+=.=.....:...--.-+..::::-.............=@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@.......:-....:-=---=*=:..--.......:++...=+=:.....-.....#@@@@%......@@@@@@@%.......-.........@@@@%....-..--..........................................................
..........................................................-...-..:.....@@@@#.....:.-.-.....@@@@@@@-..............:...::..:=...-..=++=-.:--..--::--===-::::-:..............+@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@............-=..::.:-...........:..:::...-=.:==...--.=*-=................@@@@@@@.....--.=.=-....=*@@@@+.........:...........................................................
..........................................................:=+=-...:......+@@@@*...--...==....@@@@@@@#...........-....:.::.-=-.=+:......................:-..........................+@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@+...........:---:-==+=.:-..-.:=*#+-..-==-.......:---.--.:==::..-..+=..=+*+.....@@@@@@@@.....:....=......*@@@@#...-=-..::.............................................................
..........................................................................=@@@@@-....==-..:....-@@@@@@@@...-*+:.+*+-:...........-............................................................................................................................................::.:....::-....+#+:.......:@@@@@@@#......::.--.:...-@@@@@*.........................................................................
......................................................................:==:...#@@@@#:..............@@@@@@@@.....-:.....:..-=+-..::.........................................:..:..:..:....---::.....:::---:::.......:...::...:::..::::.........................................::.--.......---:.:......@@@@@@@@:....===#+::......%@@@@%...........................................................................
...............................................................................#@@@@*.......:........@@@@@@@@.....:====-:.................................................:.............-.......::-:::--::::::.:.....:...:::...::.............................................---...:----.........@@@@@@@@=.......-==:......+@@@@@=....:........................................................................
......................................................................-++-..-:...%@@@@@#......-=--.....=@@@@@@@@.......:...-+*+=..........................................:.............-....::-:......---::::.....::::::.:....::..:..........................................:-:...-+=-.......@@@@@@@@@......==-.........:@@@@@=...-...........................................................................
......................................................................--=*=........=@@@@@%..........-.....@@@@@@@@@.......=+:.-=:.......................................................:----::...:.:...........::::.:......:.::...-:........................................::.+#*=.......-@@@@@@@@@.......:..........=@@@@@@-......---........................................................................
......................................................................=-..--.:=:......:@@@@@*....-=+--.......@@@@@@@@@@......-:.=................::---....:-:......................................:---:......:......:.............::.............::...::::...............::.:=-........%@@@@@@@@@-.....-==.-:.......#@@@@@@....-.-=+=.:........................................................................
......................................................................:=+-..-...:......:@@@@@@#.....=-...:......@@@@@@@@@@......:...:.:---:-==-.......:----:-.................................:.......:-----::..:::--:..::.::-----::.............---:................:---:..:........@@@@@@@@@@+........:-.......-%@@@@@*....:=-.:--..:-........................................................................
........................................................................:---.--:..:.::.....+@@@@@#.....===:........#@@@@@@@@@@............::..-...:---......:...........................................::.......::::....::......................-..:=++==-.....-:.---...........@@@@@@@@@@+......:===.........=@@@@@@=...-+=........:..........................................................................
....................................................................................:-.-:....%@@@@@@...................@@@@@@@@@@@......-...-+#==:.....=+=-......................................................................................--.....:::..:-:...:.........#@@@@@@@@@@......:......--......*@@@@@+:...........................................................................................
.....................................................................................:..-*+.....+@@@@@@#.....==..:........=@@@@@@@@@@@-......--.......-:..=+=......................................................................................-*%%#+..-=:..=-......#@@@@@@@@@@@@.........-==-........@@@@@@#...............................................................................................
.....................................................................................--..--:.......@@@@@@#.......--..==-......*@@@@@@@@@@@@............=-...=:......................................................................................................@@@@@@@@@@@@@.......=-...=:........#@@@@@@=....---..........................................................................................
.......................................................................................=-...=**-......%@@@@@@%-...................@@@@@@@@@@@@@@.........-*++......................................................................................-+*=........@@@@@@@@@@@@@@-.....-=-..---........*@@@@@@*.....:.....---.......................................................................................
.....................................................................................-:.-++=..:++-......+@@@@@@@*........::............@@@@@@@@@@@@@@@...................................................................................................-@@@@@@@@@@@@@@*.............::........=@@@@@@@#=..:.....=+=-..........................................................................................
.....................................................................................::....-+=...-+*=.......+@@@@@@@#.........:..---......:@@@@@@@@@@@@@@@@@+...........:-:.............-===----...:------::..:----=-:...--==--:..................#@@@@@@@@@@@@@@@@@.........--:-=++=-......+@@@@@@@=.....==:.-+*+-...-=-.......................................................................................
.....................................................................................:.::-:...-=--....:-==.....+@@@@@@@%-..........:............=@@@@@@@@@@@@@@@@@@@:..............................::::----...............................-@@@@@@@@@@@@@@@@@@@%.........................-+#@@@@@@#:.....:...-:..................................................................................................
.....................................................................................:....::....:---:.............-#@@@@@@@@-........:-==:............%@@@@@@@@@@@@@@@@@@@@@@%+..................................................=@@@@@@@@@@@@@@@@@@@@@@@:...........----:...........=@@@@@@@............::...:--:.....::.......................................................................................
......................................................................................................................*@@@@@@@@@=.........:::...............*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%+=----=*%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@:..............................+@@@@@@@@%=....................................................................................................................
..................................................................................................................:........#@@@@@@@@+.............::................-@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-...........:-=-:.:-+#*=........=#@@@@@@@@@#-........................................................................................................................
.................................................................................................................-:....:.......-@@@@@@@@@+...........:-:.......................=#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#=-..............:-:...................:+%@@@@@@@@@%=.................:..........................................................................................................
.................................................................................................................-+++=-............-@@@@@@@@@@#...........--..------..............................-==++++=--:...........................:-===:....-==-.............+@@@@@@@@%-...........-++-........:..........................................................................................................
....................................................................................................................:---:.-+#@@-........=@@@@@@@@@@@@=....................-.......:-:::...................................:-.......:.......................-%@@@@@@@@@@@#-.........:--=+*=:.=:..................................................................................................................
.................................................................................................................---............:..:-.........%@@@@@@@@@@@@@=...............---:....................................:+##=:..-+=--:.-===-..........-#%@@@@@@@@@@@@@@@=.........=-:..-=+=...:==....:......:.......................................................................................................
....................................................................................................................:----:.-=+*+-..:--=-............+@@@@@@@@@@@@@%=...........................::---:-::.:......::...-.....................-*%%@@@@@@@@@@@@@............:--==-....:....-==-:....:...............................................................................................................
............................................................................................................................................................%@@@@@@@@@@@@@@+:......................................................+@@@@@@@@@@@@@@@@@#=.......:-:...............................................................................................................................................
..................................................................................................................................................................#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#++=======+++#@@@@@@@@@@@@@@@@@@@@@@@#-.............:-...................................................................................................................................................
..............................................................................................................................................:..::...::::..-..............+%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*........................-#%#-...............................................................................................................................................
.............................................................................................................................................:::........:...:---::.....................................:==---------==-.......................:==+=...:=++++-....................................................................................................................................................
.............................................................................................................................................::..:...:..................:--:..-:...................................................:------:.......=+=...:-=====-:...............................................................................................................................................
.............................................................................................................................................::.......:::....--==---:::....+#*+=-..:=+*+..-=--===-----:..............:====-::.::...=++==-:..=+#%%+...-.......-=-:...............................................................................................................................................
.............................................................................................................................................:------:::.:..:----......:-==-......:......-:............-=+++=====------.........:..:::-:-----.....-:::--=*#*+=-..-...............................................................................................................................................
................................................................................................................................................................................................................................................................................................................................................................................................................


*/