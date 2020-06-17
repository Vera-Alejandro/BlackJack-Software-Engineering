using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Blackjack.GamePlay
{
    public class Sound
    {
        private string _fileName { get; set; }
        private string _name { get; set; }

        public Sound( string fileName )
        {
            _fileName = fileName;
            _name = _fileName.Substring( _fileName.Length - 4 );
        }

        //must import winmm.dll to use mciSendString
        [DllImport( "winmm.dll" )]
        static extern int mciSendString( string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback );
        public void Play( )
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string callString = "open ";
            string callType;
            string fileType = _fileName.Substring( (_fileName.Length - 4), 4 );
            if (fileType.ToLower() == ".mp3")
            {
                callType = "MPEGVideo";
            }
            else if (fileType.ToLower() == ".wav")
            {
                callType = "waveaudio";
            }
            else
            {
                Console.WriteLine( "File must be .mp3 or .wav" );
                return;
            }

            callString += string.Format( "{0}Resources\\sounds\\", System.IO.Path.GetFullPath( System.IO.Path.Combine( RunningPath, @"..\..\" ) ) );
            callString += _fileName;
            callString += " type ";
            callString += callType;
            callString += " alias ";
            callString += _name;

            string playString = "play ";
            playString += _name;

            mciSendString( @callString, null, 0, IntPtr.Zero );
            mciSendString( @playString, null, 0, IntPtr.Zero );
        }
    }
}
