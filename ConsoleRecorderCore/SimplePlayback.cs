using NAudio.Wave;
using System;
using System.IO;

namespace ConsoleRecorderCore
{
    public sealed class SimplePlayback
    {
        public delegate void StatusHandler(StatusPlayer status);
        public event StatusHandler AoAlterarStatusPlayer;

        private static readonly SimplePlayback _instance = new SimplePlayback();

        //private AudioFileReader _audioFileReader;
        private WaveStream _wave_provider;
        private IWavePlayer _wave_player;
        private WaveFileReader _wave_reader;

        public enum StatusPlayer
        {
            None,
            Opened,
            Playing,
            Paused,
            Stopped
        }

        public enum AudioType
        {
            File,
            Bytes
        }

        public SimplePlayback() { }

        public static SimplePlayback Instance
        {
            get
            {
                return _instance;
            }
        }

        public TimeSpan getCurrentTime()
        {
            if (_wave_provider != null)
                return _wave_provider.CurrentTime;

            return new TimeSpan();
        }

        public void setCurrenTime(TimeSpan time)
        {
            // Quando executa um áudio GSM via stream, o áudio vira ruído ao alterar a posição, apenas direto no strem que isso não ocorre.
            _wave_reader.CurrentTime = time;
        }

        public TimeSpan getTotalTime()
        {
            if (_wave_provider != null)
                return _wave_provider.TotalTime;

            return new TimeSpan();
        }

        public void setVolume(float volume)
        {
            _wave_player.Volume = volume;
        }

        public void BeginPlayback(string path_file)
        {
            Stream stream = obter_stream(path_file);
            BeginPlayback(stream);
        }

        public void BeginPlayback(Stream stream)
        {
            CleanUp();

            _wave_player = new WaveOutEvent();

            _wave_reader = new WaveFileReader(stream);

            definir_provider(stream);

            _wave_player.Init(_wave_provider);

            _wave_player.PlaybackStopped += OnPlaybackStopped;

            if (AoAlterarStatusPlayer != null)
                AoAlterarStatusPlayer(StatusPlayer.Opened);
        }

        public void play()
        {
            _wave_player.Play();

            if (AoAlterarStatusPlayer != null)
                AoAlterarStatusPlayer(StatusPlayer.Playing);
        }

        public void pause()
        {
            _wave_player.Pause();

            if (AoAlterarStatusPlayer != null)
                AoAlterarStatusPlayer(StatusPlayer.Paused);
        }

        public void stop()
        {
            _wave_player.Pause();
            setCurrenTime(new TimeSpan(0, 0, 0));

            if (AoAlterarStatusPlayer != null)
                AoAlterarStatusPlayer(StatusPlayer.Stopped);
        }

        private Stream obter_stream(string file)
        {
            byte[] bytes = File.ReadAllBytes(file);
            return new MemoryStream(bytes);
        }

        private void definir_provider(Stream source_stream)
        {
            switch (_wave_reader.WaveFormat.Encoding)
            {
                case WaveFormatEncoding.Gsm610:
                    _wave_provider = new RawSourceWaveStream(source_stream, new Gsm610WaveFormat());
                    break;

                case WaveFormatEncoding.Pcm:
                    _wave_provider = new RawSourceWaveStream(
                        source_stream, new WaveFormat(_wave_reader.WaveFormat.SampleRate,
                                                      _wave_reader.WaveFormat.BitsPerSample,
                                                      _wave_reader.WaveFormat.Channels));
                    break;

                default:
                    throw new Exception("Formato de áudio não suportado.");
            }
        }

        void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            setCurrenTime(new TimeSpan(0, 0, 0));
        }

        private void CleanUp()
        {
            if (_wave_provider != null)
            {
                _wave_provider.Dispose();
                _wave_provider = null;
            }

            if (_wave_player != null)
            {
                _wave_player.Dispose();
                _wave_player = null;
            }

            if (AoAlterarStatusPlayer != null)
                AoAlterarStatusPlayer(StatusPlayer.None);
        }
    }
}
