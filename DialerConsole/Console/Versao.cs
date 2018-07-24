using System;

namespace Console
{
    class Versao
    {
        private const int MAJOR = 3;
        private const int MINOR = 8;
        private const int RELEASE = 0;

        public new static string ToString()
        {
            return String.Format("{0}.{1}.{2}", MAJOR, MINOR, RELEASE);
        }
    }
}
