using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumberSystem.Constants
{
    public class WesternNumeralSystem
    {
        public Dictionary<int, string> ReturnNumeralValue()
        {
            Dictionary<int, string> Western = new Dictionary<int, string>()
                                            {
                                                {4," THOUSAND"},
                                                {5," THOUSAND"},
                                                {6," THOUSAND"},
                                                {7," MILLION"},
                                                {8," MILLION"},
                                                {9," MILLION"},
                                                {10," BILLION"},
                                                {11," BILLION"},
                                                {12," BILLION"},
                                                {13," TRILLION"},
                                                {14," TRILLION"},
                                                {15," TRILLION"},
                                                {16," QUADRILLION"},
                                                {17," QUADRILLION"},
                                                {18," QUADRILLION"},
                                                {19," QUINTILLION"},
                                                {20," QUINTILLION"},
                                                {21," QUINTILLION"},
                                                {22," SEXTILLION"},
                                                {23," SEXTILLION"},
                                                {24," SEXTILLION"},
                                                {25," OCTILIION"},
                                                {26," OCTILIION"}
                                            };
            return Western;
        }
    }
}