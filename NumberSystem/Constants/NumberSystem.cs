using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumberSystem.Constants
{
    public static class NumberSystem
    {
        public static Dictionary<int, string> Single = new Dictionary<int, string>()
                                            {
                                                {0,""},
                                                {1," ONE"},
                                                {2," TWO"},
                                                {3," THREE"},
                                                {4," FOUR"},
                                                {5," FIVE"},
                                                {6," SIX"},
                                                {7," SEVEN"},
                                                {8," EIGHT"},
                                                {9," NINE"},
                                            };
        public static Dictionary<int, string> Double = new Dictionary<int, string>()
                                            {
                                                {0,""},
                                                {2," TWENTY"},
                                                {3," THIRTY"},
                                                {4," FOURTY"},
                                                {5," FIFTY"},
                                                {6," SIXTY"},
                                                {7," SEVENTY"},
                                                {8," EIGHTY"},
                                                {9," NINETY"},
                                            };
        public static Dictionary<int, string> Combo = new Dictionary<int, string>()
                                            {
                                                {0," TEN"},
                                                {1," ELEVEN"},
                                                {2," TWELVE"},
                                                {3," THIRTEEN"},
                                                {4," FOURTEEN"},
                                                {5," FIFTEEN"},
                                                {6," SIXTEEN"},
                                                {7," SEVENTEEN"},
                                                {8," EIGHTEEN"},
                                                {9," NINETEEN"},
                                            };
    }
}