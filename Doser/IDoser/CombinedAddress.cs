using System.Runtime.InteropServices;

namespace IDoser
{
    public class CombinedAddress
    {
        private object _host;
        private int _port;
        private string _comPort;
        private TypeAddress _type;



        /// <summary>
        /// Для IP-адреса это адрес хоста, при адресации rs485 - адреса устройства (тип int)
        /// </summary>
        public object Host => _host;

        /// <summary>
        /// Для IP-адреса это порт, при адресации rs485 - дополнительный параметр адреса (например номер дискретного выхода терминала)
        /// </summary>
        public int Port => _port;

        public string ComPort => _comPort;

        /// <summary>
        /// Тип адреса
        /// </summary>
        public TypeAddress Type => _type;

        CombinedAddress(object host, TypeAddress type)
        {
            _host = Host;
            _type = Type;
        }
        CombinedAddress(object host, string comPort, TypeAddress type)
        {
            _host = Host;
            _type = Type;
            _comPort = ComPort;
        }
        CombinedAddress(object host, int port, string comPort, TypeAddress type)
        {
            _host = Host;
            _port = Port;
            _type = Type;
            _comPort = ComPort;
        }
    }
}