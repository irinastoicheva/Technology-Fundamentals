namespace P02
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                string pattern = @"^([A-Z][a-z\s']+):([A-Z\s]+)$";
                Match macth = Regex.Match(input, pattern);
                if (!macth.Success)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    string encryptedArtist = macth.Groups[1].Value;
                    int key = encryptedArtist.Length;
                    string encryptedSong = macth.Groups[2].Value;
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < encryptedArtist.Length; i++)
                    {
                        if (encryptedArtist[i] == ' ' || encryptedArtist[i] == '\t')
                        {
                            sb.Append(encryptedArtist[i]);
                        }
                        else
                        {
                            if (i == 0)
                            {
                                if (encryptedArtist[i] + key > 90)
                                {
                                    sb.Append((char)(encryptedArtist[i] + key - 26));
                                }
                                else
                                {
                                    sb.Append((char)(encryptedArtist[i] + key));
                                }
                            }
                            else
                            {
                                if (encryptedArtist[i] == '\'')
                                {
                                    sb.Append(encryptedArtist[i]);
                                }
                                else
                                {
                                    if (encryptedArtist[i] + key > 122)
                                    {
                                        sb.Append((char)(encryptedArtist[i] + key - 26));
                                    }
                                    else
                                    {
                                        sb.Append((char)(encryptedArtist[i] + key));
                                    }
                                }
                            }
                        }
                    }
                    sb.Append("@");
                    for (int i = 0; i < encryptedSong.Length; i++)
                    {
                        if (encryptedSong[i] == ' ' || encryptedSong[i] == '\t')
                        {
                            sb.Append(encryptedSong[i]);
                        }
                        else
                        {
                            if (encryptedSong[i] + key > 90)
                            {
                                sb.Append((char)(encryptedSong[i] + key - 26));
                            }
                            else
                            {
                                sb.Append((char)(encryptedSong[i] + key));
                            }
                        }
                    }

                    Console.WriteLine($"Successful encryption: {sb}");
                    sb.Clear();
                }

                input = Console.ReadLine();
            }
        }
    }
}

