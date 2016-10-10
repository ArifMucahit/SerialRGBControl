using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arduinoSerialCom
{
    class LED
    {
        private static byte redPin,greenPin,bluePin,redPin1,greenPin1,bluePin1; // our settings is up here.
        private static string conPort;
        private static bool secLED;
        public byte RedPin{get{return redPin;}set{redPin = value;}}
        public byte GreenPin{get{return greenPin;}set{greenPin = value;}} 
        public byte BluePin {get{return bluePin;}set{bluePin = value;}}
        public byte RedPin1 {get{return redPin1;}set{redPin1 = value;}}
        public byte GreenPin1 {get{return greenPin1;}set{greenPin1 = value;}}
        public byte BluePin1 {get{return bluePin1;}set{bluePin1 = value;}}
        public bool SecLed {get{return secLED;}set{secLED = value;}}
        public string Connection{get{return conPort;}set{conPort = value;}}
    }
}
