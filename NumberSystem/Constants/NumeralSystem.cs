using NumberSystem.CommonFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace NumberSystem.Constants
{
    public class NumeralSystem
    {
        public Dictionary<int, string> ReturnNumeralValue(string strNumberSystem)
        {
            if (strNumberSystem == "Western")
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

            if (strNumberSystem == "Indian")
            {
                Dictionary<int, string> Indian = new Dictionary<int, string>()
                                            {
                                                {4," THOUSAND"},
                                                {5," THOUSAND"},
                                                {6," LAKH"},
                                                {7," LAKHS"},
                                                {8," CRORE"},
                                                {9," CRORES"},
                                                {10," ARAB"},
                                                {11," ARABS"},
                                                {12," KHARAB"},
                                                {13," KHARABS"},
                                                {14," NEEL"},
                                                {15," NEELS"},
                                                {16," PADMA"},
                                                {17," PADMAS"},
                                                {18," SHANKA"},
                                                {19," SHANKAS"},
                                                {20," UPADH"},
                                                {21," UPADHS"},
                                                {22," ANK"},
                                                {23," ANKS"},
                                                {24," JALD"},
                                                {25," MADH"},
                                                {26," PARAARDHA"}
                                            };
                return Indian;
            }
            return null;
        }
    }
}