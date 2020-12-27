using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace explorer
{
    class functions
    {
        Stopwatch sw;

        public Label l_all_files;
        public Label l_search_files;
        public Label l_file;
        public ListBox lb_result;
        public ListBox lb_path;
        public Label l_time;
        public DirectoryInfo _dr;
        public int c;



        public string s_text;

        public int all_files = 0;
        public int search_file = 0;
        public int i = 0;
        public int c_Press = -1;//0-пауза 1-поиск

        public bool isSearch = false;
        public bool search;
        public bool obnyl;
        public bool IsPausePress = false;


        public void Search_time(Regex file)
        {
            sw = new Stopwatch();
            sw.Start();
            Search(_dr, file);
            sw.Stop();

            Console.WriteLine("Функция отработала!");  
        }

        public void Search (DirectoryInfo dr, Regex file)
        {
            if (search == true)
            {
                /* 
                 чем больше число, тем реже обновление:
                + производительность - отображения данных
                 чем меньше число, тем чаще обновление:
                - производительность + отображения данных
                */
                if (all_files % 31 == 0)
                {
                    Text_up(dr);
                }

                // Может возникнуть ошибка прав доступа
                try
                {

                    foreach (FileInfo info in dr.GetFiles())
                    {
                        all_files++;
                        if (file.IsMatch(info.Name))
                        {
                            if (IsPausePress == true && i < search_file)//Проверка что мы не начинаем заного а продолжаем с кр места и что у нас есть в словаре как минимум 1 запись
                            {
                                 i++;
                            }
                            else
                            {
                                search_file++;
                                IsPausePress = false;
                                i = 0;

                                lb_result.Invoke((MethodInvoker)delegate
                                {
                                    lb_result.Update();
                                    lb_result.Items.Add(info.Name);
                                });

                                lb_path.Invoke((MethodInvoker)delegate
                                {
                                lb_path.Items.Add(info.FullName);
                                });
                            }

                        }
                    }

                    foreach (DirectoryInfo directoryInfo in dr.GetDirectories())
                    {
                        Search(directoryInfo, file);
                    }
                }

                catch (Exception e)
                {
                }
            }
            //else
            //{
            //}
        }

        void Text_up(DirectoryInfo dr)
        {
            //Количество всех файлов
            l_all_files.Invoke((MethodInvoker)delegate {

                l_all_files.Text = all_files.ToString();
                l_all_files.Update();
            });
            //Количество найденных по фильтру файлов
            l_search_files.Invoke((MethodInvoker)delegate {

                l_search_files.Text = search_file.ToString();
                l_search_files.Update();
            });
            //Какую папку сейчас просматриваем
            l_file.Invoke((MethodInvoker)delegate {

                l_file.Text = dr.FullName;
                l_file.Update();

            });
            //Время работы
            l_time.Invoke((MethodInvoker)delegate {

                l_time.Text= sw.Elapsed.ToString();
                l_time.Update();

            });
        }
    }
}
