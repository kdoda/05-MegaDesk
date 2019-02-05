using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; //for asserts since I am paranoid
using System.IO;

//TODO maybe prevent orders not in the right date
namespace MegaDesk
{
    public class DeskQuote
    {
        private const int SIZE = 3;
        private const int Rush_3 = 3;
        private const int Rush_5 = 5;
        private const int Rush_7 = 7;
        private const int Normal_14 = 14;
        private const int DRAWERS_PRICE = 50;
        private const int BASE_PRICE = 200;
        private static List<int> OrderDays = new List<int> { Rush_3, Rush_5, Rush_7, Normal_14 };

        /// <summary>
        /// Dictionary that maps order days to prices based on size of the desk
        /// Indexes of List represent:
        /// First:  less than 1000 size of desk in^2
        /// Second: 1000 to 2000 size of desk in^2
        /// Third:  greater than 2000 size of desk in^2
        /// </summary>
        private static Dictionary<int, List<int>> prices;
        private int _DaysOrdered;

        public string CustomerName { get; set; }
        public DateTime DateOrdered { get; set; }
        public Desk Desk { get; set; }
       
        public DeskQuote()
        {
            loadPrices();
        }

        public int DaysOrdered
        {
            get
            {
                return _DaysOrdered;
            }

            set
            {
                Debug.Assert(value == Rush_3 || value == Rush_5 || value == Rush_7 || value == Normal_14);
                _DaysOrdered = value;
            }
        }

        private int _Price = -1;
        public int Price
        {
            get
            {
                if(_Price == -1)
                {
                    Debug.Assert(Desk.SurfaceArea > 0);
                    Debug.Assert(Desk.NrDrawers >= 0);
                    int extraSurfaceArea = Desk.SurfaceArea - 1000;
                    if (extraSurfaceArea < 0)
                    {
                        extraSurfaceArea = 0;
                    }
                    //IMPORTATNT: 1 inch of surface costs 1$ so the extraSurfaceArea automatically is the price also
                    int drawersPrice = Desk.NrDrawers * DRAWERS_PRICE;

                    _Price =  BASE_PRICE + extraSurfaceArea + drawersPrice + DaysOrderPrice + Desk.SurfaceMaterialPrice;
                }

                return _Price;
            }

            set
            {
                _Price = value;
            }
        }

        private int DaysOrderPrice
        {
            get
            {
                if (DaysOrdered == Normal_14)
                {
                    return 0;
                }

                Debug.Assert(prices.ContainsKey(DaysOrdered));
                List<int> daysPrices = prices[DaysOrdered];
                int surfaceArea = Desk.SurfaceArea;
                Debug.Assert(surfaceArea > 0);

                if (surfaceArea < 1000)
                {
                    return daysPrices[0];
                }
                else if (1000 <= surfaceArea && surfaceArea <= 2000)
                {
                    return daysPrices[1];
                }
                else
                {
                    return daysPrices[2];
                }
            }
            
        }

        public static List<KeyValuePair<string,int>> getFriendlyDaysOrdered()
        {
            var daysOrderedValues = new List<KeyValuePair<string, int>>();

            foreach (int orderDays in OrderDays)
            {
                daysOrderedValues.Add(ToFriendlyString(orderDays));
            }

            return daysOrderedValues;
        }

        private static KeyValuePair<string, int> ToFriendlyString(int orderDays)
        {
            loadPrices();
            switch (orderDays)
            {
                case Rush_3:
                    return new KeyValuePair<string, int>("3 (Rush)",3);
                case Rush_5:
                    return new KeyValuePair<string, int>("5 (Rush)",5);
                case Rush_7:
                    return new KeyValuePair<string, int>("7 (Rush)",7);
                case Normal_14:
                    return new KeyValuePair<string, int>("14 (Normal)",14);
                default:
                    Debug.Assert(false);
                    return new KeyValuePair<string, int>("Shouldn't hit this",0);
            }
        }

        private static void loadPrices()
        {
            try
            {
                if (prices == null)
                {
                    prices = new Dictionary<int, List<int>>();
                    string[] rawPrices = File.ReadAllLines("rushOrderPrices.txt");
                    int index = 0;
                    for (int i = 0; i < SIZE; ++i)
                    {
                        List<int> rowPrices = new List<int>();
                        for (int j = 0; j < SIZE; ++j)
                        {
                            int price = int.Parse(rawPrices[index++]);
                            rowPrices.Add(price);
                        }
                        prices.Add(translateIndexToKey(i), rowPrices);
                    }

                }
            }
            catch(Exception ex) //in case it fails for some reason use the default values
            {
                prices =  new Dictionary<int, List<int>>{
                                { Rush_3, new List<int> { 60, 70, 80 } },
                                { Rush_5, new List<int> { 40, 50, 60 } },
                                { Rush_7, new List<int> { 30, 35, 40 } },
                            };
            }

        }

        private static int translateIndexToKey(int index)
        {
            switch(index)
            {
                case 0:
                    return Rush_3;
                case 1:
                    return Rush_5;
                case 2:
                    return Rush_7;
                default:
                    Debug.Assert(false);
                    return -1;
            }
        }

        public static string CSVHeader()
        {
            return $"CustomerName,Price,DateOrdered,DaysOrdered,{Desk.CSVHeader()}";
        }

        public override string ToString()
        {
            return $"{CustomerName},{Price},{DateOrdered.ToString()},{DaysOrdered},{Desk.ToString()}\n";
        }
    }
}
