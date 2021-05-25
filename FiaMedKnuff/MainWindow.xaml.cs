using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FiaMedKnuff
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<SolidColorBrush> colors = new List<SolidColorBrush>();

        public ImageBrush imgBrush = new ImageBrush();

        public static List<Ellipse> greenChar = new List<Ellipse>();
        public static List<Ellipse> blueChar = new List<Ellipse>();
        public static List<Ellipse> redChar = new List<Ellipse>();
        public static List<Ellipse> yellowChar = new List<Ellipse>();

        public MainWindow()
        {
            InitializeComponent();

        }

        private UserControl gamePlan;

        private void content_Loaded(object sender, RoutedEventArgs e)
        {
            gamePlan = new UserControl();
            Grid DynamicGrid = new Grid();


            for (int i = 0; i < 4; i++)
            {
                Ellipse characther = new Ellipse()
                {
                    Fill = Brushes.LightGreen,
                    Stroke = Brushes.Black,
                    Width = 58,
                    Height = 58,
                };

                if (i == 0)
                {
                    Grid.SetRow(characther, 6);
                    Grid.SetColumn(characther, 10);
                    
                }
                if (i == 1)
                {
                    Grid.SetRow(characther, 8);
                    Grid.SetColumn(characther, 9);
                }

                if (i == 2)
                {
                    Grid.SetRow(characther, 9);
                    Grid.SetColumn(characther, 9);
                }

                if (i == 3)
                {
                    Grid.SetRow(characther, 9);
                    Grid.SetColumn(characther, 8);
                }
                Grid.SetZIndex(characther, 1000);
                DynamicGrid.Children.Add(characther);
                greenChar.Add(characther);
                
            } // green

            for (int i = 0; i < 4; i++)
            {
                Ellipse characther = new Ellipse()
                {
                    Fill = Brushes.Blue,
                    Stroke = Brushes.Black,
                    Width = 58,
                    Height = 58,
                };

                if (i == 0)
                {
                    Grid.SetRow(characther, 1);
                    Grid.SetColumn(characther, 9);

                }
                if (i == 1)
                {
                    Grid.SetRow(characther, 2);
                    Grid.SetColumn(characther, 9);
                }

                if (i == 2)
                {
                    Grid.SetRow(characther, 2);
                    Grid.SetColumn(characther, 8);
                }

                if (i == 3)
                {
                    Grid.SetRow(characther, 1);
                    Grid.SetColumn(characther, 8);
                }
                Grid.SetZIndex(characther, 1000);
                DynamicGrid.Children.Add(characther);
                blueChar.Add(characther);
            } // blue

            for (int i = 0; i < 4; i++)
            {
                Ellipse characther = new Ellipse()
                {
                    Fill = Brushes.Red,
                    Stroke = Brushes.Black,
                    Width = 58,
                    Height = 58,
                };

                if (i == 0)
                {
                    Grid.SetRow(characther, 1);
                    Grid.SetColumn(characther, 2);

                }
                if (i == 1)
                {
                    Grid.SetRow(characther, 2);
                    Grid.SetColumn(characther, 2);
                }

                if (i == 2)
                {
                    Grid.SetRow(characther, 2);
                    Grid.SetColumn(characther, 1);
                }

                if (i == 3)
                {
                    Grid.SetRow(characther, 1);
                    Grid.SetColumn(characther, 1);
                }
                Grid.SetZIndex(characther, 1000);
                DynamicGrid.Children.Add(characther);
                redChar.Add(characther);
            } // red

            for (int i = 0; i < 4; i++)
            {
                Ellipse characther = new Ellipse()
                {
                    Fill = Brushes.Yellow,
                    Stroke = Brushes.Black,
                    Width = 58,
                    Height = 58,
                };

                if (i == 0)
                {
                    Grid.SetRow(characther, 8);
                    Grid.SetColumn(characther, 2);

                }
                if (i == 1)
                {
                    Grid.SetRow(characther, 9);
                    Grid.SetColumn(characther, 2);
                }

                if (i == 2)
                {
                    Grid.SetRow(characther, 9);
                    Grid.SetColumn(characther, 1);
                }

                if (i == 3)
                {
                    Grid.SetRow(characther, 8);
                    Grid.SetColumn(characther, 1);
                }
                Grid.SetZIndex(characther, 1000);
                DynamicGrid.Children.Add(characther);
                yellowChar.Add(characther);
            } // yellow




            colors.Add(Brushes.Red);
            colors.Add(Brushes.Blue);
            colors.Add(Brushes.Green);
            colors.Add(Brushes.Yellow);

            

            for (int i = 0; i < 11; i++)
            {
                var row = new RowDefinition();
                row.Height = new GridLength(60);
                DynamicGrid.RowDefinitions.Add(row);

                var col = new ColumnDefinition();
                col.Width = new GridLength(60);
                DynamicGrid.ColumnDefinitions.Add(col);

            }

            for (int i = 4; i < 7; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Ellipse rec = new Ellipse()
                    {
                        Fill = Brushes.White,
                        Stroke = Brushes.Black,
                        Width = 58,
                        Height = 58,
                    };
                    Grid.SetRow(rec, i);
                    Grid.SetColumn(rec, j);
                    DynamicGrid.Children.Add(rec);
                    
                }
            } //vågrätt

            for (int i = 0; i < 12; i++)
            {
                for (int j = 4; j < 7; j++)
                {
                    Ellipse rec = new Ellipse()
                    {
                        Fill = Brushes.White,
                        Stroke = Brushes.Black,
                        Width = 58,
                        Height = 58,
                    };
                    Grid.SetRow(rec, i);
                    Grid.SetColumn(rec, j);
                    DynamicGrid.Children.Add(rec);

                }
            } // lodrätt

            for (int i = 0; i < 4; i++) // starter cirklar
            {
                Ellipse start = new Ellipse()
                {
                    Fill = colors[i],
                    Width = 164,
                    Height = 164
                };
                Grid.SetColumnSpan(start, 4);
                Grid.SetRowSpan(start, 4);
                if (i == 0)
                {
                    Grid.SetRow(start, 0);
                    Grid.SetColumn(start, 0);
                }

                if (i == 1)
                {
                    Grid.SetRow(start, 0);
                    Grid.SetColumn(start, 7);
                }

                if (i == 2)
                {
                    Grid.SetRow(start, 7);
                    Grid.SetColumn(start, 7);
                }

                if (i == 3)
                {
                    Grid.SetRow(start, 7);
                    Grid.SetColumn(start, 0);
                }

                DynamicGrid.Children.Add(start);
            }
            
            for (int i = 0; i < 12; i++)
            {
                for (int j = 5; j < 6; j++)
                {
                    if (i < 5)
                    {
                        Ellipse rec = new Ellipse()
                        {
                            Fill = Brushes.Blue,
                            Stroke = Brushes.Black,
                            Width = 58,
                            Height = 58,
                        };
                        Grid.SetRow(rec, i);
                        Grid.SetColumn(rec, j);
                        DynamicGrid.Children.Add(rec);

                    }

                    if (i > 5)
                    {
                        Ellipse rec = new Ellipse()
                        {
                            Fill = Brushes.Yellow,
                            Stroke = Brushes.Black,
                            Width = 58,
                            Height = 58,
                        };
                        Grid.SetRow(rec, i);
                        Grid.SetColumn(rec, j);
                        DynamicGrid.Children.Add(rec);
                    }
                }
            }

            for (int i = 5; i < 6; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (j < 5)
                    {
                        Ellipse rec = new Ellipse()
                        {
                            Fill = Brushes.Red,
                            Stroke = Brushes.Black,
                            Width = 58,
                            Height = 58,
                        };
                        Grid.SetRow(rec, i);
                        Grid.SetColumn(rec, j);
                        DynamicGrid.Children.Add(rec);

                    }

                    if (j > 5)
                    {
                        Ellipse rec = new Ellipse()
                        {
                            Fill = Brushes.Green,
                            Stroke = Brushes.Black,
                            Width = 58,
                            Height = 58,
                        };
                        Grid.SetRow(rec, i);
                        Grid.SetColumn(rec, j);
                        DynamicGrid.Children.Add(rec);
                    }

                }
            }


            Ellipse kola = new Ellipse()
            {
                Fill = Brushes.White,
                Stroke = Brushes.Black,
                Width = 58,
                Height = 58
            };
            Grid.SetRow(kola, 6);
            Grid.SetColumn(kola, 6);
            DynamicGrid.Children.Add(kola);


            int dice = 2;

            if (dice == 2)
            {


                for (int i = 0; i < 6; i++)
                {
                    int row = Grid.GetRow(greenChar[0]);
                    int column = Grid.GetColumn(greenChar[0]);
                    if (Grid.GetRow(greenChar[0]) == Grid.GetRow(kola) && Grid.GetColumn(greenChar[0]) == Grid.GetColumn(kola))
                    {
                        for (; i < 6; i++)
                        {
                            row = Grid.GetRow(greenChar[0]);
                            column = Grid.GetColumn(greenChar[0]);
                            Grid.SetRow(greenChar[0], row + 1);
                            Grid.SetColumn(greenChar[0], column);

                        }
                    }
                    else
                    {
                        if (i < 6)
                        {
                            Grid.SetRow(greenChar[0], row);
                            Grid.SetColumn(greenChar[0], column - 1);
                        }
                    }
                }
            }





            gamePlan.Content = DynamicGrid;
            content.Children.Add(gamePlan);
        }
    }
}
