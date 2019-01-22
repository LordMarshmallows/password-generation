using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp20
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Pas> Pas { get; set; }
        public string pose;
        public int ch;
        public int Oi = 0;
        ObservableCollection<string> password;
      
        public MainWindow()
        {
            Pas = new ObservableCollection<Pas> { };
            InitializeComponent();
            pasvoList.ItemsSource = Pas;
            password = new ObservableCollection<string> {};
            passswordObservableCollection.ItemsSource = password;
          

            using (StreamReader sr = new StreamReader(@"D:\NSF\password generator\password.txt", System.Text.Encoding.Default))
            {
                string pas;
                //  char[] array = new char[100];
                //sr.Read(array, 1, 11);
                pas = sr.ReadToEnd();
                String[] words = pas.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                // string[] words = pas.Split('▯');

                for (int j = 0; j < words.Length; j++)
                {
                    int dl = pas.Length;
                    char[] array = new char[dl];

                    array = words[j].ToCharArray();
                    for (int i = 0; i < array.Length; i++)
                    {
                        switch (array[i])
                        {

                            case 'z':
                                array[i] = 'a';
                                break;
                            case 'a':
                                array[i] = 'b';
                                break;
                            case 'q':
                                array[i] = 'c';
                                break;
                            case 'w':
                                array[i] = 'd';
                                break;
                            case 's':
                                array[i] = 'e';
                                break;
                            case 'x':
                                array[i] = 'f';
                                break;
                            case 'c':
                                array[i] = 'g';
                                break;
                            case 'd':
                                array[i] = 'h';
                                break;
                            case 'e':
                                array[i] = 'i';
                                break;
                            case 'r':
                                array[i] = 'j';
                                break;
                            case 'f':
                                array[i] = 'k';
                                break;
                            case 'v':
                                array[i] = 'l';
                                break;
                            case 'b':
                                array[i] = 'm';
                                break;
                            case 'g':
                                array[i] = 'n';
                                break;
                            case 't':
                                array[i] = 'o';
                                break;
                            case 'y':
                                array[i] = 'p';
                                break;
                            case 'h':
                                array[i] = 'q';
                                break;
                            case 'n':
                                array[i] = 'r';
                                break;
                            case 'm':
                                array[i] = 's';
                                break;
                            case 'j':
                                array[i] = 't';
                                break;
                            case 'i':
                                array[i] = 'u';
                                break;
                            case 'u':
                                array[i] = 'v';
                                break;
                            case 'k':
                                array[i] = 'w';
                                break;
                            case 'l':
                                array[i] = 'x';
                                break;
                            case 'o':
                                array[i] = 'y';
                                break;
                            case 'p':
                                array[i] = 'z';
                                break;
                            case 'P':
                                array[i] = 'A';
                                break;
                            case 'O':
                                array[i] = 'B';
                                break;
                            case 'L':
                                array[i] = 'C';
                                break;
                            case 'K':
                                array[i] = 'D';
                                break;
                            case 'I':
                                array[i] = 'E';
                                break;
                            case 'U':
                                array[i] = 'F';
                                break;
                            case 'J':
                                array[i] = 'G';
                                break;
                            case 'M':
                                array[i] = 'H';
                                break;
                            case 'N':
                                array[i] = 'I';
                                break;
                            case 'H':
                                array[i] = 'J';
                                break;
                            case 'Y':
                                array[i] = 'K';
                                break;
                            case 'T':
                                array[i] = 'L';
                                break;
                            case 'G':
                                array[i] = 'M';
                                break;
                            case 'B':
                                array[i] = 'N';
                                break;
                            case 'V':
                                array[i] = 'O';
                                break;
                            case 'F':
                                array[i] = 'P';
                                break;
                            case 'R':
                                array[i] = 'Q';
                                break;
                            case 'E':
                                array[i] = 'R';
                                break;
                            case 'D':
                                array[i] = 'S';
                                break;
                            case 'C':
                                array[i] = 'T';
                                break;
                            case 'X':
                                array[i] = 'U';
                                break;
                            case 'S':
                                array[i] = 'V';
                                break;
                            case 'Q':
                                array[i] = 'W';
                                break;
                            case 'W':
                                array[i] = 'X';
                                break;
                            case 'Z':
                                array[i] = 'Y';
                                break;
                            case 'A':
                                array[i] = 'Z';
                                break;
                            case '5':
                                array[i] = '1';
                                break;
                            case '3':
                                array[i] = '2';
                                break;
                            case '0':
                                array[i] = '3';
                                break;
                            case '1':
                                array[i] = '4';
                                break;
                            case '2':
                                array[i] = '5';
                                break;
                            case '8':
                                array[i] = '6';
                                break;
                            case '6':
                                array[i] = '7';
                                break;
                            case '7':
                                array[i] = '8';
                                break;
                            case '4':
                                array[i] = '9';
                                break;
                            case '9':
                                array[i] = '0';
                                break;
                        }


                    }
                    string value = String.Concat<char>(array);
                    Pas.Add(new Pas() { Sec = value, Pa = value });






                }
             ;

                // label.Content = words;
                //  foreach (string s in words)
                // {
                //   
                //     char[] array = new char[dl];

                //    words[j] = String.Concat<char>(array);
                //       if (s.Trim() != "▯")
                // string value = String.Concat<char>(array);


                // }


                //    pas = String.Concat<char>(array);


                //  string value = String.Concat<char>(array);
                //   label.Content = value;
            }



        }
        public static string GetUniqueKey(int maxSize)
        {

            char[] chars = new char[62];

            chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();

        }
        public static string GetUniqueKey2(int maxSize)
        {

            char[] chars = new char[52];

            chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();

        }
        public static string GetUniqueKey3(int maxSize)
        {

            char[] chars = new char[36];

            chars = "abcdefghijklmnopqrstuvwxyz1234567890".ToCharArray();
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();

        }
        public static string GetUniqueKey4(int maxSize)
        {

            char[] chars = new char[26];

            chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int ch;
            string s = chislo.Text;
          
            if (s != "")
            {
                try
                {
                    ch = int.Parse(s);
                    if (ch > 20)
                    {
                        ch = 20;
                        chislo.Text = "20";
                    }
                    if (ch < 4)
                    {
                        ch = 4;
                        chislo.Text = "4";
                    }
                    if ((ch1.IsChecked == true) & (ch2.IsChecked == true))
                    {
                        pose = GetUniqueKey(ch);
                        labelpas.Content = pose;
                    }
                    if ((ch1.IsChecked == true) & (ch2.IsChecked == false))
                    {
                        pose = GetUniqueKey2(ch);
                        labelpas.Content = pose;
                    }
                    if ((ch1.IsChecked == false) & (ch2.IsChecked == true))
                    {
                        pose = GetUniqueKey3(ch);
                        labelpas.Content = pose;
                    }
                    if ((ch1.IsChecked == false) & (ch2.IsChecked == false))
                    {
                        pose = GetUniqueKey4(ch);
                        labelpas.Content = pose;
                    }
                }

                catch
                {
                    chislo.Text = "";

                }
               
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        { 
             }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

            using (FileStream fstream = new FileStream(@"D:\NSF\password generator\password.txt", FileMode.OpenOrCreate))
            {
                var ar = pose.ToCharArray();
                char[] buf = new char[pose.Length+1];

               
                for (int i = 0; i < ar.Length; i++)
                {

                    switch (ar[i])
                    {
                        case 'a':
                            ar[i] = 'z';
                            break;
                        case 'b':
                            ar[i] = 'a';
                            break;
                        case 'c':
                            ar[i] = 'q';
                            break;
                        case 'd':
                            ar[i] = 'w';
                            break;
                        case 'e':
                            ar[i] = 's';
                            break;
                        case 'f':
                            ar[i] = 'x';
                            break;
                        case 'g':
                            ar[i] = 'c';
                            break;
                        case 'h':
                            ar[i] = 'd';
                            break;
                        case 'i':
                            ar[i] = 'e';
                            break;
                        case 'j':
                            ar[i] = 'r';
                            break;
                        case 'k':
                            ar[i] = 'f';
                            break;
                        case 'l':
                            ar[i] = 'v';
                            break;
                        case 'm':
                            ar[i] = 'b';
                            break;
                        case 'n':
                            ar[i] = 'g';
                            break;
                        case 'o':
                            ar[i] = 't';
                            break;
                        case 'p':
                            ar[i] = 'y';
                            break;
                        case 'q':
                            ar[i] = 'h';
                            break;
                        case 'r':
                            ar[i] = 'n';
                            break;
                        case 's':
                            ar[i] = 'm';
                            break;
                        case 't':
                            ar[i] = 'j';
                            break;
                        case 'u':
                            ar[i] = 'i';
                            break;
                        case 'v':
                            ar[i] = 'u';
                            break;
                        case 'w':
                            ar[i] = 'k';
                            break;
                        case 'x':
                            ar[i] = 'l';
                            break;
                        case 'y':
                            ar[i] = 'o';
                            break;
                        case 'z':
                            ar[i] = 'p';
                            break;
                        case 'A':
                            ar[i] = 'P';
                            break;
                        case 'B':
                            ar[i] = 'O';
                            break;
                        case 'C':
                            ar[i] = 'L';
                            break;
                        case 'D':
                            ar[i] = 'K';
                            break;
                        case 'E':
                            ar[i] = 'I';
                            break;
                        case 'F':
                            ar[i] = 'U';
                            break;
                        case 'G':
                            ar[i] = 'J';
                            break;
                        case 'H':
                            ar[i] = 'M';
                            break;
                        case 'I':
                            ar[i] = 'N';
                            break;
                        case 'J':
                            ar[i] = 'H';
                            break;
                        case 'K':
                            ar[i] = 'Y';
                            break;
                        case 'L':
                            ar[i] = 'T';
                            break;
                        case 'M':
                            ar[i] = 'G';
                            break;
                        case 'N':
                            ar[i] = 'B';
                            break;
                        case 'O':
                            ar[i] = 'V';
                            break;
                        case 'P':
                            ar[i] = 'F';
                            break;
                        case 'Q':
                            ar[i] = 'R';
                            break;
                        case 'R':
                            ar[i] = 'E';
                            break;
                        case 'S':
                            ar[i] = 'D';
                            break;
                        case 'T':
                            ar[i] = 'C';
                            break;
                        case 'U':
                            ar[i] = 'X';
                            break;
                        case 'V':
                            ar[i] = 'S';
                            break;
                        case 'W':
                            ar[i] = 'Q';
                            break;
                        case 'X':
                            ar[i] = 'W';
                            break;
                        case 'Y':
                            ar[i] = 'Z';
                            break;
                        case 'Z':
                            ar[i] = 'A';
                            break;
                        case '1':
                            ar[i] = '5';
                            break;
                        case '2':
                            ar[i] = '3';
                            break;
                        case '3':
                            ar[i] = '0';
                            break;
                        case '4':
                            ar[i] = '1';
                            break;
                        case '5':
                            ar[i] = '2';
                            break;
                        case '6':
                            ar[i] = '8';
                            break;
                        case '7':
                            ar[i] = '6';
                            break;
                        case '8':
                            ar[i] = '7';
                            break;
                        case '9':
                            ar[i] = '4';
                            break;
                        case '0':
                            ar[i] = '9';
                            break;

                    }
                    buf[i] = ar[i];
                }

                int f = buf.Length;
                buf[f-1] = ',';
                fstream.Seek(0, SeekOrigin.End);
                byte[] array = System.Text.Encoding.Default.GetBytes(buf);
                fstream.Write(array, 0, array.Length);

            }
        

        
        }
    }
 }
